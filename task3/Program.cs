// Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
int [] CreateArray (int size){
    int [] array = new int [size];
    for (int i = 0; i < size; i++){
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
    }
    return array;
}

int ReadNumber(string message){
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] array1 = CreateArray(ReadNumber("Enter lenght of array: "));
int [] array2 = new int [array1.Length];
Console.WriteLine();
for (int i = array1.Length - 1, j = 0; i >= 0 ; i--, j++){
    array2[j] = array1[i];
    Console.Write(array2[j] + " ");
}
