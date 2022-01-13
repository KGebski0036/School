#include <iostream>

class Mytame {
 private:
    size_t sec = 0;
 public:
    void addTime(int time){sec+=time;}
    std::string getTime(bool pm = false);
};

std::string Mytame::getTime(bool pm) {
    size_t timeInThisDay = sec % 86400;
    std::string result;
    if (pm) {
        if (timeInThisDay / 3600 > 12) {
            result += "PM ";
        } else {
            result += "AM ";
        }
        result += std::to_string((timeInThisDay / 3600) % 12);
    } else {
        result += std::to_string(timeInThisDay / 3600);
    }
    result += ':';
    if(((timeInThisDay % 3600) / 60)<10){
        result += '0';
    }
    result += std::to_string((timeInThisDay % 3600) / 60);
    return result;
}

int main(){
    Mytame time;

    size_t hour = 7;
    size_t min = 30;
    size_t quantityOfLessons = 80;
    size_t lessonTime = 45;
    size_t brakeTime = 5;

    std::cout<<"Wpisz godzine rozpoczencia:";
    std::cin>>hour;
    std::cout<<"\nWpisz minute rozpoczencia:";
    std::cin>>min;
    std::cout<<"\nWpisz ilość lekcji:";
    std::cin>>quantityOfLessons;
    std::cout<<"\nWpisz czas trwania lekcji:";
    std::cin>>lessonTime;
    std::cout<<"\nWpisz czas trwania przerwy:";
    std::cin>>brakeTime;

    time.addTime(hour * 3600 + min * 60); //set time of first lesson

    std::cout<<"_________________________\n";
    std::cout<<"| Nr.|  Lekcja\t\t|\n";
    std::cout<<"|-----------------------|\n";
    for(int i = 0; i < quantityOfLessons; i++){
        std::cout<<"|  "<<i<<" | ";
        std::cout<<time.getTime()<<'-';
        time.addTime(lessonTime * 60);
        std::cout<<time.getTime()<<"\t|\n";
        time.addTime(brakeTime * 60);
        std::cout<<"|-----------------------|\n";
    }
    return 0;
}
