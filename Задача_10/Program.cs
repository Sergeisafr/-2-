Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int tu = (num / 10) % 10;
Console.Write(tu);
