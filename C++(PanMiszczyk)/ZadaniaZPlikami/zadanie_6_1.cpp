#include <iostream>
#include <fstream>
#include <string>
#include <array>
#include <vector>

char encrypt(char ch){
    if(isalpha(ch)){
        return (((ch + 107) - 65) % 26) + 65;
    }
    return '\n';
}

int main(){
    std::ifstream inputfile("dane_6_1.txt", inputfile.in);
    std::ofstream output;
    output.open("wyniki_6_1.txt", output.out | output.trunc);
    
    if(!(inputfile.is_open() && output.is_open())){
        std::cerr<<"Can't open or make a file\n";
        return 1;
    }

    std::vector<std::array<char, 30>> v {};
 
    for(std::array<char, 30> a {}; inputfile.getline(&a[0], 30);){
        v.push_back(a);
    }
 
    for (auto& it : v){
        for(auto ch : it){
            char ech = encrypt(ch);
            if(ch == 0)break;
            output<<ech;
        }
    }

    output.close();
    inputfile.close();
    
    return 0;
}