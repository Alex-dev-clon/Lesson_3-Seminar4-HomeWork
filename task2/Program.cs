// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
int [] CreateArray (int size){
    int [] array = new int [size];
    for (int i = 0; i < size; i++){
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
    }
    return array;
}

int ReadNumber(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckNumber (int number){
    if (number % 2 == 0) return true;
    return false;
}

int [] array = CreateArray(ReadNumber("Enter lenght of array: "));
int count = 0;
for (int i = 0; i < array.Length; i++){
    if (CheckNumber(array[i])) count++;
}
Console.WriteLine("\nCount of even numbers = " + count);