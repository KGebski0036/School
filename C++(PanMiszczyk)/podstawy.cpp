#include <iostream>
/***********************************************
* to jest program co  cos robi
*
************************************************/
using namespace std;

int main()
{
    cout << "Ala ma ";
      cout << endl
         << "kota"
         << endl;

    cout << "Ala ma kota" << endl;
    cout << "x = " << 120 << endl;
    cout << "y  = " << 3.14 << endl;
    cout << "Wynik: " << 2*(3+5)-1/3. << endl;
    cout << "Koniec" << endl; // Wypisanie komunikatu


    /* Ala
    ma kota
    Filemona */
    return 250;
}



#include <iostream>

using namespace std;

int main()
{
    cout << " 1. " << 123 << endl;
    cout << " 2. " << +123 << endl;
    cout << " 3. " << -123 << endl;
    cout << " 4. " << 0123 << endl; // oct
    cout << " 5. " << 0x123 << endl; // liczba szesnastkowa
    cout << " 6. " << 0XFF << " " << 0xff << endl;
    cout << " 7. " << 1. << " " << .25 << endl;
    cout << " 8. " << 3.14 << endl;
    cout << " 9. " << 3.5e4 << endl;
    cout << "10. " << 3.5E-4 << endl;
    return 0;
}



//deklaracja zmiennych
#include <iostream>

using namespace std;

int main()
{
    // int - typ caÂ³kowity
    int a;
    a = 10;
    cout << a << endl;
    // float - typ zmiennopozycyjny (rzeczywisty)
    //         pojedynczej precyzji
    float b;
    b = 3.14;
    cout << b << endl;
    // double - typ zmiennopozycyjny (rzeczywisty)
    //          podwÃ³jnej precyzji
    double c;
    c = 45.345;
    cout << c << endl;

    long double d;
    d = 45.345;
    cout << d << endl;

    b = 1111111111.1111111111;
    c = 1111111111.1111111111;
    d = 1111111111.1111111111;
    cout << "    1111111111.1111111111" << endl;
    cout.precision(25);
    cout << "b = " << b << endl;
    cout << "c = " << c << endl;
    cout << "d = " << d << endl;
    cout << "    1234567890 1234567890" << endl;
    cout << "Rozmiar float:       " << sizeof(float) << endl;
    cout << "Rozmiar double:      " << sizeof(double) << endl;
    cout << "Rozmiar long double: " << sizeof(long double) << endl;
    return 0;
}


#include <iostream>

using namespace std;

int main()
{
    int a = 0;
    unsigned int b = 0; // lub        unsigned b = 0;
    short int c = 0; // lub           short c = 0;
    long int d = 0; // lub            long d = 0;
    unsigned short int e = 0; // lub  unsigned short e = 0;
    cout << "Rozmiar int: " << sizeof(int) << endl;
    cout << "Rozmiar unsigned: " << sizeof(unsigned) << endl;
    cout << "Rozmiar short: " << sizeof(short) << endl;
    cout << "Rozmiar long: " << sizeof(long) << endl;
    cout << a << endl;
    return 0;
}





#include <iostream>

using namespace std;

int main()
{
    cout << " 1.  7 / 2 = " << 7/2 << endl; // wynik calkowity
    cout << " 2.  7. / 2 = " << 7./2 << endl; // wynik rzeczywisty
    int a = 7. / 2; // wynik double skonwetrowany do int
    cout << " 3.  a = " << a << endl;
    double b = 7. / 2;
    cout << " 4.  b = " << b << endl;

    short c = 100000; // za duza liczba dla typu short
    cout << " 5.  c = " << c << endl;
    int d = 100000; // za duza liczba dla typu short
    cout << " 6.  d = " << d << endl;

    const int x = 123; // stala numeryczna
    cout << " 7.  x = " << x << endl;
    // x = 250; blad - nie mozna zmienac stalej
    cout << " 8.  x = " << x << endl;

    return 0;
}



#include <iostream>

using namespace std;

int main()
{
    unsigned char z = 'A'; // znak w kodzie ASCII 0 - 255
    cout << "1. " << z << " " << int(z) << endl;
    z = 245;
    cout << "2. " << z << " " << (int)z << endl;
    z = 'A' + 2;
    cout << "3. " << z << endl;
    cout << sizeof(char) << endl;
    //     "X" to w pamieci dwa znaki 'X' '\0'

    bool b = true;
    cout << "4. " << b << endl;
    b = false;
    cout << "5. " << b << endl;
    b = 20;
    cout << "6. " << b << endl;
    b = -10;
    cout << "7. " << b << endl;
    b = 0;
    cout << "8. " << b << endl;
    // 0 -> false   inne liczby -> true
    return 0;
}




#include <iostream>

using namespace std;

int main()
{
    cout << "1. " << 7 % 3 << endl;
    // % - operator reszta z dzielenia (modulo)

/*
    Priorytety w wyrazeniach arytmetycznych
    P1  ( )  najwyzszy priorytet w wyrazeniu
    P2  + -     operator znaku liczby (operator unarny, czyli jednoargumentowy) )
    P3  * / %
    P4  + -  operatory binarne (dwuargumentowe)

*/
    cout << 2 * 3 % 5 << endl;
    int i,j,k,x;
    i = 100;
    j = 25;
    k = 13;
    x = (5 * ((j % k) + i) / (2 * k)) / 2;
    cout << "x = " << x << endl;
    return 0;
}



#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    cout << " 1. " << 123 << " " << oct << 123 << endl;
    cout << " 2. " << 8 << dec << " " << 8 << " " << hex << 255 << endl;
    cout << " 3. " << setbase(10) << 234 << endl;
    cout << " 4. " << setbase(8) << 234 << endl;
    cout << " 5. " << setbase(16) << 234 << endl;
    cout << " 6. " << setbase(2) << 234 << endl; //nieprawidlowu parametr
    cout << dec;
    cout << " 7. " << 'A' << " " << int('A') << " " << (int)'A' << endl;
    cout << " 8. " << setprecision(7) << 5234.32656789 << endl;
    cout << "    12345678901234567890" << endl;
    cout << " 9. " << setw(20) << 3475.326 << endl;
    cout << "10. " << scientific << 34960000000.  << endl;
    cout << "11. " << fixed << 34960000000.  << endl;
    cout << "12. " << setprecision(3) << 34960000000.  << endl;
    cout << defaultfloat;
    cout << "13. "  << 5234.32656789  << endl;



    return 0;
}



#include <iostream>
#include <string>

using namespace std;

int main()
{
    string napis1 = "C++";
    string napis2("Jezyk");
    cout << napis2 << " " << napis1 << endl;
    string s = napis2 + " programowania " + napis1;
    cout << s << endl;
    //s = "Ala " + "ma kota."; // Zle!
    // "Ala" - null-terminated string
    // "Ala" --->  'A' 'l' 'a' '\0'
    // string("Ala")  - string
    s = "Ala " + string("ma kota.");
    cout << s << endl;
    return 0;
}



#include <iostream>
#include <string>

using namespace std;

int main()
{
    string napis(""); // pusty string
    cout << "1. Wpisz tekst:";
    cin >> napis; //wczyta tekstt do spacji
    cout << napis << endl;

    cin.clear(); //czyszczenie flag bledow
    cin.ignore( 1000, '\n' ); //usuniecie do 1000 znakow ze strumienia
                              //do znaku nowego wiersza '\n'

    cout << "2. Wpisz tekst:";
    getline(cin, napis); // wczytanie wiersza tekstu
    cout << napis << endl;

    return 0;
}



#include <iostream>
#define KOMUNIKAT cout << "Witaj!" << endl;
#define A 5
#define WYNIK 10 + 2

using namespace std;

int main()
{
    KOMUNIKAT
    int x;
    x = WYNIK * A;
//  x = 10 + 2 * 5;
    cout << x << endl;

    return 0;
}




#include <iostream>

using namespace std;
int c = 30;
int n = 1;
void f(void);

int main()
{
    int a = 1;
    int n = 2;
    cout << " 1. a = " << a << endl;
    cout << " 2. n = " << n << endl;
    {
        cout << " 3. n = " << n << endl;
        int b = 10;
        int n = 3;
        cout << " 4. a = " << a << endl;
        cout << " 5. b = " << b << endl;
        cout << " 6. c = " << c << endl;
        cout << " 7. n = " << n << endl;
        cout << " 8. n = " << ::n << endl;
    }
    // cout << " 9. b = " << b << endl; // error
    cout << "10. c = " << c << endl;
    cout << "11. n = " << n << endl;
    f();
    return 0;
}

void f(void)
{
    cout << "f1. c = " << c << endl;
    cout << "f2. n = " << n << endl;
}