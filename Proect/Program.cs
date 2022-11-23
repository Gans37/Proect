string[] arr1 = {"Hello", "2", "world", ":-)"};
		string[] arr2 = {"1234", "1567", "-2", "computer science"};
		string[] arr3 = {"Russia", "Denmark", "Kazan"};
void SecondArrayWithIF(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arr1, arr2);
PrintArray(arr2);