// сложение 2-х заданных чисел

// int numberA = 5;
// int numberB = 3;
// int result = numberA + numberB;
// Console.WriteLine(result);


// сложение 2-х чисел полученых случайно

int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);