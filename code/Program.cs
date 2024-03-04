
    static string[] RecreateArray(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }


        string[] outputArray = new string[count];

        int index = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                outputArray[index] = inputArray[i];
                index++;
            }
        }

        return outputArray;
    }
void arrayPrint(string[] array)
{
     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

    Console.WriteLine("Введите элементы массива через запятую:");
    string? input = Console.ReadLine();
    string[] array = input.Split(',');
    string[] result = RecreateArray(array);

    Console.WriteLine($"Новый массив:");
    arrayPrint(RecreateArray(array));