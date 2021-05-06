#include <iostream>
#include <regex>
#include <map>
#include<Windows.h>

#define TextAnalyzerFunctions _declspec(dllexport)

using namespace std;

typedef void(_stdcall* LPEXTFUNCRESPOND) (LPCSTR s);

extern "C" {

    TextAnalyzerFunctions void __stdcall GetMaxOccuringWordCpp(const char* input, LPEXTFUNCRESPOND respond)
    {
        string str = input;
        string result = "";
        map<string, int> mapWords;

        regex rgx("\\W|_");
        sregex_token_iterator iter(str.begin(), str.end(), rgx, -1);
        sregex_token_iterator end;

        int index = 0;
        while (iter != end) {

            if ((*iter).compare("") == 0)
            {
                ++iter;
                continue;
            }

            if (mapWords.count(*iter))
            {
                mapWords[*iter] += 1;
            }
            else
            {
                mapWords.insert(make_pair(*iter, 1));
            }

            ++iter;
        }

        int max = INT_MIN;
        for (auto& element : mapWords)
        {
            if (element.second > max)
            {
                max = element.second;
                result = element.first + " --> " + to_string(element.second);
            }
        }

        respond(result.c_str());
    }
}
