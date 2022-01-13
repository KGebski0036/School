#include <iostream>
#include <fstream>
#include <string>
#include <array>
#include <vector>

char encrypt(char ch, int i){
        return (((ch-65) + 26 - (i % 26)) % 26) + 65;
}

int main(){
    std::ifstream inputfile("dane_6_2.txt", inputfile.in);
    std::ofstream output;
    output.open("wyniki_6_2.txt", output.out | output.trunc);
    
    if(!(inputfile.is_open() && output.is_open())){
        std::cerr<<"Can't open or make a file\n";
        return 1;
    }

    std::string word;
    int key;

    while (inputfile >> word >> key)
    {    
        for(auto it : word){
            output << encrypt(it, key);
        }
        output << '\n';
    }

    output.close();
    inputfile.close();

    return 0;
}