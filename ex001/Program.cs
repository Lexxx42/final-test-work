// Write a program that from the existing array of strings 
// forms an array of strings whose length is less than or equal to 3 characters.

void PrintArray(string[] array) // Print array.
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

string[] FillArrayOutput(string[] array) // Fills array output.
{
    string[] arrayOut = new string[array.Length];
    int indexOut = 0;
    foreach (var item in array)
    {

        if (item.Length <= 3)
        {
            arrayOut[indexOut] = item;
            indexOut++;
        }
    }
    return arrayOut;
}



string[] arrayInput = { "Hello", "2", "world", ":-)" };
string[] arrayOutput = FillArrayOutput(arrayInput);
PrintArray(arrayOutput);