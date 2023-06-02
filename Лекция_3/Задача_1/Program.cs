// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".



string Replace(string text, char oldValue, char newValue)              // метод который перебирает текст посимвольно,
{                                                                      // делает сравнение с искомым символом и в случае 
    string result = string.Empty;                                      // совподения меняет на нужный символ
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) 
        {
            result = result + $"{newValue}";
        }
        else
        {
            result = result + $"{text[i]}";
        }
    }
    return result;
}

string text = " - Я думаю, - сказал князь, улыбаясь, - что,"
            + " ежели бы вас послали вместо нашего милого Винценгероде,"
            + " вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'В', 'в');
Console.WriteLine(newText);
Console.WriteLine();