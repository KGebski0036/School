#include <iostream>
#include <fstream>
#include <string>
#include <array>
#include <vector>



int main(){
    std::ifstream inputfile("dane_6_3.txt", inputfile.in);
    std::ofstream output;
    output.open("wyniki_6_3.txt", output.out | output.trunc);
    
    if(!(inputfile.is_open() && output.is_open())){
        std::cerr<<"Can't open or make a file\n";
        return 1;
    }

    std::string word;
    std::string word2;
    int key;

    while (inputfile >> word >> word2){

         if(word[0] > word2[0]){
            key = 26 - word[0] + 65 + word2[0] - 65;
         }else{
            key = word2[0] - word[0];
         }

        for(int i = 0; i < word.length(); i++){
            if(((word[i] + key - 65) % 26) + 65 != word2[i]){
                output<<word<<'\n';
                break;
            }
        }
    }

    

    output.close();
    inputfile.close();
    
    return 0;
} 
