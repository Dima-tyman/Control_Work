Console.Clear();

string[] array = {"hello", "2", "world", ":-)"};

int GetLengthArray (string[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) sum++;
    return sum;
}

void SelectValue (string[] newArr, string[] oldArr) {
    for (int i = 0, j = 0; i < oldArr.Length; i++)
        if (oldArr[i].Length <= 3) {
        newArr[j] = oldArr[i];
        j++;
        }
}

Console.WriteLine(string.Join(", ", array));
string[] newArray = new string[GetLengthArray(array)];
SelectValue (newArray, array);
Console.WriteLine(string.Join(", ", newArray));