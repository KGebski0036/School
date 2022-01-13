def convertToCorrectCharacter(x):
    if (x < 10):
        return str(x)
    else:
        return chr(ord('A') + x - 10)


def convertNumber(liczba, podstawa):
    result = ""
    while liczba > 0:
        result += convertToCorrectCharacter(liczba % podstawa)
        liczba //= podstawa

    result = result[::-1]
    print(result)


liczba = int(input("Podaj liczbe w systemie dziesiętnym:"))
podstawa = int(input("Podaj podstawe systemu:"))
if(podstawa < 2 or podstawa > 20):
    podstawa = 10

convertNumber(liczba, podstawa)


















