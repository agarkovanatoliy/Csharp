Console.Clear(); // Очистка экрана в терминале

int xa = 20, ya = 1,
    xb = 1,  yb = 15,
    xc = 40, yc = 15;

Console.SetCursorPosition(xa, ya );  // SetCursorPosition(xa, ya ) - команда которая переводит курсор в заданные координаты
Console.WriteLine("+");    
Console.SetCursorPosition(xb, yb );
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc );
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;

while (count < 10000)
{
    int whot =new Random().Next(0,3);
    if (whot == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (whot == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if (whot == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y );
    Console.WriteLine("+");
    count ++;
}