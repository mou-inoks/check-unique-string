//Program to verify by an algorithm if element contains double

bool Test(string word)
{
    var isUnique = false;
    
    for (int i = 0; i < word.Length; i++)
    {
        for (int j = 0; j < word.Length; j++)
        {
            if (word[i] == word[j] && i != j)
                isUnique = true;
        }
    }
    return isUnique;
}

Console.WriteLine(Test("test"));