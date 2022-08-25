Console.Write("Введите цифру от 1 до 7 обзначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if ( day > 5 )
{
    Console.Write ("Да, выходной");
}
else if ( day <= 5 )
{
    Console.Write ("Нет, не выходной");
}

