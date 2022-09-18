string[] words = { "Hello", "2", "world", ":-" };
string[] newWords = new string[words.Length];
int count = 0;
for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length <= 3)
    {
        newWords[count] = words[i];
        count++;

    }

}
PrintArray(newWords);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

