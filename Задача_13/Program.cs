Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int min = 10;
int fax = 0;
if (num < 100)
{
    fax = 0;
    
} 
else if (num > 100)

 {while (num > 999)

    num = num / 10;
    fax = (num % min);}

if (fax < 1)
{
     Console.Write("Третьей цифры нет");
}
else if (fax >= 1)
{
   Console.Write(fax); 
}
