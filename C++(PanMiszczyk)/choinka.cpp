#include <iostream>
#include <fstream>
#include <ctime>
#include <cstdlib>

int main()
{

    std::ofstream output;
    int segments{};

    while (segments > 7 || segments < 1)
    {
        std::cout << "Ilość segmętów choinki (min-1 max-8): ";
        std::cin >> segments;
    }
    bool adorned;
    bool presents;
    std::cout << "jeżeli choinka ma być przystrojona wpisz 1, jeżeli nie wpisz 0: ";
    std::cin >> adorned;
    std::cout << "jeżeli byłeś grzeczny wpisz 1, jeżeli nie 0: ";
    std::cin >> presents;

    std::srand(std::time(nullptr));
    output.open("output.html");
    if (output.is_open())
    {
        const size_t center = 990;
        size_t widthSegment = 220;
        size_t height = 50;

        output << "<!DOCTYPE html>\n<html>\n<head>\n<title>Cristmas tree</title>\n</head>\n<body style='background-color: aqua;'>\n<svg style='width:2000px;height:950px;'>\n";
        //tree
        output << "<g fill='green'>\n";

        for (int i = 0; i < segments; i++)
        {
            widthSegment *= 1.24;
            output << "<polygon points=' " << center - widthSegment / 2 << "," << height + 200 << " " << center << "," << height << "," << center + widthSegment / 2 << "," << height + 200 << "'/>\n";
            height += 100;
        }

        output << "</g>\n";
        //root
        output << "<polygon points='970," << height + 100 << " 1010," << height + 100 << " 1010," << height + 200 << " 970," << height + 200 << " 'style='fill:rgb(165,42,42)';/>";

        if (presents)
        {
            for (int i = segments; i > 0; i--)
            {
                int randomRGB1 = std::rand() % 255;
                int randomRGB2 = std::rand() % 255;
                int randomRGB3 = std::rand() % 255;
                int randomRGB4 = std::rand() % 255;
                int randomRGB5 = std::rand() % 255;
                int randomRGB6 = std::rand() % 255;
                int randomPosition = std::rand() % widthSegment;
                int centerOfPresent = (center - widthSegment / 2) + randomPosition;
                output << "<polygon points='" << centerOfPresent + 35 << "," << height + 125 << " " << centerOfPresent + 35 << "," << height + 200 << " " << centerOfPresent - 35 << "," << height + 200 << " " << centerOfPresent - 35 << "," << height + 125 << " 'style='fill:rgb(" << randomRGB1 << "," << randomRGB2 << "," << randomRGB3 << ")'/>";
                output << "<polygon points='" << centerOfPresent + 20 << "," << height + 125 << " " << centerOfPresent + 20 << "," << height + 200 << " " << centerOfPresent - 20 << "," << height + 200 << " " << centerOfPresent - 20 << "," << height + 125 << " 'style='fill:rgb(" << randomRGB4 << "," << randomRGB5 << "," << randomRGB6 << ")'/>";
                output << "<polygon points='" << centerOfPresent + 35 << "," << height + 150 << " " << centerOfPresent + 35 << "," << height + 175 << " " << centerOfPresent - 35 << "," << height + 175 << " " << centerOfPresent - 35 << "," << height + 150 << " 'style='fill:rgb(" << randomRGB4 << "," << randomRGB5 << "," << randomRGB6 << ")'/>";
            }
        }

        if (adorned)
        {
            //star
            output << "<polygon points='990,10 930,198 1080,78 900,78 1050,198'style='fill:rgb(220, 243, 14);stroke:rgb(128, 126, 0);stroke-width:5;' />";

            //boubles

            for (int i = 0; i < segments; i++)
            {
                for (int j = (segments - i) * 2; j > 0; j--)
                {
                    int randomRGB1 = std::rand() % 255;
                    int randomRGB2 = std::rand() % 255;
                    int randomRGB3 = std::rand() % 255;
                    int boublePosition = std::rand() % widthSegment;
                    int centerOfBauble = (center - widthSegment / 2) + boublePosition;
                    output << "<circle cx='" << centerOfBauble << "' cy='" << height + 120 << "' r='20' stroke='black' stroke-width='3' fill=rgb(" << randomRGB1 << "," << randomRGB2 << "," << randomRGB3 << ") />";
                    output << "<polygon points='" << centerOfBauble + 5 << "," << height + 100 << " " << centerOfBauble + 5 << "," << height + 95 << " " << centerOfBauble - 5 << "," << height + 95 << " " << centerOfBauble - 5 << "," << height + 100 << "' style='fill:rgb(192,192,192)'/>";
                }
                widthSegment /= 1.24;
                height -= 100;
            }
        }

        output << "</svg></body></html>\n"
               << std::endl;
    }
    else
    {
        std::cerr << "Can not open a file" << std::endl;
        return 1;
    }

    output.close();
    return 0;
}