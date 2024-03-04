string[] originalArray = new string[5] {"Уфа", "Омск", "Москва", "Шуя", "Гай"};
string[] newArray = new string[originalArray.Length];
void SecondArrayWithIF(string[] originalArray, string[] newArray)
{
     int count = 0;
     for (int i = 0; i < originalArray.Length; i++) {
     if(originalArray[i].Length <= 3)
         {
         newArray[count] = originalArray[i];
         count++;
         }
     }
 }
void PrintArray(string[] Array)
{
    Console.Write ("[ ");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
     Console.WriteLine ("]");
}
Console.WriteLine($"Новый массив:");
SecondArrayWithIF(originalArray, newArray);
PrintArray(newArray);
