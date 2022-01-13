#include <iostream>
#include <string>
#include <map>

int main() {
    std::string text;

    std::cout<<"Wpisz text: ";

    std::getline(std::cin,text);

    std::map<char, int> leters;

    for(auto& it : text){
        if(isalpha(it)){
            leters[tolower(it)]++;
        }
    }
    for(auto& [key, value] : leters){
        std::cout<<key<<" - "<<value<<'\n';
    }
    return 0;
}