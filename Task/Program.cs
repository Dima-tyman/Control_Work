Console.Clear();

string[] array = {"hello", "2", "world", ":-)"};

int GetLengthArray (string[] arr) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3) sum++;
    return sum;
}

Console.WriteLine(string.Join(" ", array));
Console.WriteLine(GetLengthArray(array));