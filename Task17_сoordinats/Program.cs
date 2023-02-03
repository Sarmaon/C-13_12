// Задача 17. Напишите программу, которая принимает на вход координаты точки (х, у)
//причем Х и У не равны нулю и выдает номер четверит плоскости, в которой находится
//эта точка.

Console.WriteLine("Введите координаты точки");

Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

int quater = Quater(x, Y);
string result = quater > 0 ?  $"Указанные координаты соотвтетствуют четверти => {quater}" 
                            : "Введены некоректные координаты";              //(? - обозначает ТОГДА) (: - иначе)
Console.WriteLine(result);

int Quater(int xc, int yc)
{
    if(xc > 0 && yc > 0) return 1;
    if(xc < 0 && yc > 0) return 2;              //&& - обозначение "или"
    if(xc < 0 && yc < 0) return 3;
    if(xc > 0 && yc < 0) return 4;
    return 0;
}