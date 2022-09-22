// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = Prompt("b1= ");
double k1 = Prompt("k1= ");

double b2 = Prompt("b2= ");
double k2 = Prompt("k2= ");
PointInter(b1, k1, b2, k2);

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}

void PointInter(double b1, double k1, double b2, double k2)
{
    double x,y;
    if ((k1 == k2) && (b1 == b2))
        System.Console.WriteLine("Прямые совпадают");

    else if (k1 == k2)
        System.Console.WriteLine("Прямые параллельны");
    else
    {
        x=(b2-b1)/(k1-k2);
        y=(k1*(b2-b1))/(k1-k2)+b1;
        System.Console.WriteLine("x= " + x + " y= " + y);
    }    
}