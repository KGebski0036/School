#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;

int main (){

   int tablicaPytan[8][3];
   srand(time(0));
   int liczba1, liczba2;
   bool czyPowtarza = true;

   do{
      for(int j = 0, i = 0 ; i<8;i++){
         liczba1 = rand()%8+2;
         liczba2 = rand()%8+2;
         tablicaPytan[i][j] = liczba1;
         j++;
         tablicaPytan[i][j] = liczba2;
         j++;
         tablicaPytan[i][j] = liczba1*liczba2;
         j = 0;
      }

      for(int j = 0, i = 0 ; i<8;i++){

         int aktualna1, aktualna2;

         liczba1 = tablicaPytan[i][j];
         j++;
         liczba2 = tablicaPytan[i][j];
         j = 0;

         for(int k = 0, l = i + 1 ; l<8;l++){
            if(liczba1 == tablicaPytan[l][k++] && liczba2 == tablicaPytan[l][k]){
               czyPowtarza = true;
               break;
            }else {
               czyPowtarza = false;
            }
            k = 0;
         }

         if(czyPowtarza){
            break;
         }
      }
   }while(czyPowtarza);

   int odp, poprawne=0;
   for (int j = 0, i = 0; i < 8; i++){
      cout<<"\nIle to: "<<tablicaPytan[i][j++]<<" * "<<tablicaPytan[i][j++]<<" = ";
      cin>>odp;
      if(odp == tablicaPytan[i][j]){
         cout<<"\nDobrze!";
         poprawne++;
      }else{
         cout<<"\nŹle";
      }
      j = 0;
   }
   cout<<"\nTwój końcowy wynik to: "<<poprawne/8.0f*100<<"%.\n";
   

   return 0;
}