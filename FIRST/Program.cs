string[] array = new string[5] {"Hello", "2", "world", ":-)", "geekbrains"};
string[] array2 = new string[array.Length];
int n = 0;
void NewArray(string[] array, string[] array2)
{
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[n] = array[i];
        n++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(array, array2);
PrintArray(array2);
