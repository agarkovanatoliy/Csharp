// Вид 1 
// Ментод который ничего не возвращает и
// не принимает на вход никаких значений

void Method1 ()
{
    Console.WriteLine("Автор ...");
}

//Method1 (); //способ вызова подобного метода




// Вид 2 
// Ментод который ничего не возвращает 
// но принимает на вход какието аргументы


void Method2(string arg)
{
    Console.WriteLine(arg);
}
//Method2 ("Текст сообщения");  //способ вызова подобного метода


void Method21(string arg1, int arg2)
{
    int i = 0;
    while (i < arg2)
    {
    Console.WriteLine(arg1);
    i++;
    }
}
//Method21 ("Текст ", 4);  //способ вызова подобного метода
//Method21 (arg2: 4, arg1: "Текст ");  // способ вызова метода с именованием аргументов, аргументы могут иддти не попорядку



// Вид 3
// Ментод который чтото  возвращает и
// не принимает на вход никаких значений

int Method3()
{
    return DateTime.Now.Year;
}

// int year = Method3(); // создаем переменную и присваивааем ей результат работы метода
// Console.WriteLine(year);

// Вид 4
// Ментод который чтото возвращает и
// принимает на вход какието аргументы


string Method4(string arg1, int arg2)
{
    int i = 0;
    string result = String.Empty; // String.Empty; присвоение переменной пустой строки
    while (i < arg2)
    {
       result = result + arg1; 
       i++;
    }
    return result;
}

// string res = Method4("z", 10);
// Console.WriteLine(res);



string Method41(string arg1, int arg2)
{
    string result = String.Empty; // String.Empty; присвоение переменной пустой строки
    for(int i = 0; i < arg2; i++)
    {
       result = result + arg1;   
    }
    return result;
}

// string res = Method41("z", 10);
// Console.WriteLine(res);
