Console.Clear();

string[] array = {"hello", "2", "world", ":-)"};

//определение длины получаемого массива строк
int GetLengthArray (string[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) sum++;
    return sum;
}

//заполнение нового массива значениями с длиной равной или меньше 3 символа
void SelectValue (string[] newArr, string[] oldArr) {
    for (int i = 0, j = 0; i < oldArr.Length; i++)
        if (oldArr[i].Length <= 3) {
        newArr[j] = oldArr[i];
        j++;
        }
}

Console.WriteLine($"Начальный массив: {string.Join(", ", array)}");
string[] newArray = new string[GetLengthArray(array)];
SelectValue (newArray, array);
Console.WriteLine($"Массив со значениями с длинной равной или меньше 3 символа: {string.Join(", ", newArray)}");