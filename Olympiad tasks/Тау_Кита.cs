string[] line = Console.ReadLine().Split();
string[] line2 = new string[line.Length];

line2[0] = line[line.Length / 2];
for (int i = 1; i <= line.Length / 2; i++)
{
    line2[i * 2 - 1] = line[line.Length / 2 - i];
    if (line.Length / 2 + i < line.Length)
    {
        line2[i * 2] = line[line.Length / 2 + i];
    }
}

for (int i = 0; i < line2.Length; i++)
{
    string word = line2[i];
    string new_word = "";

    new_word += word[word.Length / 2];
    for (int j = 1; j <= word.Length / 2; j++)
    {
        new_word += word[word.Length / 2 - j];
        if (word.Length / 2 + j < word.Length)
        {
            new_word += word[word.Length / 2 + j];
        }
    }
    line2[i] = new_word;
}

foreach (string word in line2)
{
    Console.Write(word + " ");
}
