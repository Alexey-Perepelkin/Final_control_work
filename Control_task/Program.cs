string[] inputDates = { "tasty", ":)", "hot", "fat", "expensive" };
int sizeInputDates = inputDates.Length;
int LendhtVal = 3;
int newSizeArr = 0;
int i = 0;
for (i = 0; i < sizeInputDates; i++)
    if (inputDates[i].Length <= LendhtVal) newSizeArr++;
string[] newDates = new string[newSizeArr];

int indexNewDates = 0;
for (i = 0; i < sizeInputDates; i++)
    if (inputDates[i].Length <= LendhtVal)
    {
        newDates[indexNewDates] = inputDates[i];
        indexNewDates++;
    }
Console.Clear();
for (i = 0; i < newSizeArr; i++)
    if (i == newSizeArr - 1) Console.Write($"{newDates[i]}");
    else Console.Write($"{newDates[i]}, ");