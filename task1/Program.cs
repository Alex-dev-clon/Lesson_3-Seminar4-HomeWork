// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

bool CheckNumber (int number){
    int result = 0;
    while (number >= 10){
        result = result + number % 10;
        number = number / 10;
    }
    result += number;
    if (result % 2 == 0) return true;
    return false;
}

while (true){
    Console.WriteLine("Enter number: ");
    string source = Console.ReadLine();
    if (source == "q") break;
    int number = Convert.ToInt32(source);
    if (CheckNumber(number)) break;
}