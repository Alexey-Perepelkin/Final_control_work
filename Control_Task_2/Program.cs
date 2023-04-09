string[] inputDates(int size)
{
    string[] arrValue = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите <{i+1}> элемент массива:\t");
        arrValue[i] = Console.ReadLine()!;
    }
    return arrValue;
}
void PrintArr(string[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.WriteLine(arr[i]);
}
string[] OutputDates(string[] arr, int lenghtString)
{
    int newSizeArr = 0;
    int sizeArr = arr.Length;
    int LenghtVal = lenghtString;
    int i = 0;

    for (i = 0; i < sizeArr; i++)
        if (arr[i].Length <= LenghtVal) newSizeArr++;
    string[] newDates = new string[newSizeArr];

    int indexNewDates = 0;
    for (i = 0; i < sizeArr; i++)
        if (arr[i].Length <= LenghtVal)
        {
            newDates[indexNewDates] = arr[i];
            indexNewDates++;
        }
      return  newDates;  
}
Console.Clear();

Console.Write("Введите размерност массива:\t");
int size = int.Parse(Console.ReadLine()!);

string[] arrValue = inputDates(size);

Console.Write("Колличество символов элемента массива больше или равно:\t");
int lenghtElement = int.Parse(Console.ReadLine()!);

string[] arrOutput = OutputDates(arrValue,lenghtElement);

PrintArr(arrOutput);