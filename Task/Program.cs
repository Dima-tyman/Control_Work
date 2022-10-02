Console.Clear();

//ввод строк пользователем
string[] FillArray (int len) {
    string[] result = new string[len];
    for (int i = 0; i < result.Length; i++) {
        Console.Write($"Введите строку {i+1}: ");
        result[i] = Console.ReadLine();
        }
    return result;
}

//определение длины получаемого массива строк
int GetLengthArray (string[] arr, int limit) {
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= limit) sum++;
    return sum;
}

//заполнение нового массива значениями с длиной равной или меньше n (limitString) символа
void SelectValue (string[] newArr, string[] oldArr, int limit) {
    for (int i = 0, j = 0; i < oldArr.Length; i++)
        if (oldArr[i].Length <= limit) {
        newArr[j] = oldArr[i];
        j++;
        }
}

string[] defaultArray = {"hello", "2", "world", ":-)"};
int limitString = 3;

string anyValue = String.Empty;
Console.WriteLine("Введите любое значений и нажмите <Enter>, если хотите ввести свои строки.");
Console.WriteLine("Если хотите продолжить со строками по умолчанию, нажмите <Enter>.");
anyValue = Console.ReadLine();

string[] array;
if (anyValue == String.Empty) {
    array = new string[defaultArray.Length];
    Array.Copy(defaultArray, array, defaultArray.Length);
    }
else {
    Console.Clear();
    int length;
    Console.Write("Введите количество значений, которое хотите ввести: ");
    while(!int.TryParse(Console.ReadLine(), out length)) Console.Write("Введите число: ");
    array = FillArray(length);
}
Console.Clear();

Console.WriteLine($"Начальный массив: {string.Join(", ", array)}");
string[] newArray = new string[GetLengthArray(array, limitString)];
SelectValue (newArray, array, limitString);
Console.WriteLine($"Массив со значениями с длинной равной или меньше {limitString} символа: {string.Join(", ", newArray)}");