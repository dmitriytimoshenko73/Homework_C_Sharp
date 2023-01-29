//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Enter number one  ");
string strNumberA = Console.ReadLine ();
int numberA = Convert.ToInt32(strNumberA);
Console.WriteLine("Enter number two ");
string strNumberB = Console.ReadLine ();
int numberB = Convert.ToInt32(strNumberB);
if (numberA > numberB)
{
    Console.WriteLine(numberA + "max");
    Console.WriteLine(numberB + "min");
}
else
{
    Console.WriteLine(numberB + "max");
    Console.WriteLine(numberA + "min");
}

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Enter number one ");
string strNumberA1 = Console.ReadLine ();
int numberA1 = Convert.ToInt32(strNumberA1);
Console.WriteLine("Enter number two ");
string strNumberB1 = Console.ReadLine ();
int numberB1 = Convert.ToInt32(strNumberB1);
Console.WriteLine("Enter number three ");
string strNumberC1 = Console.ReadLine ();
int numberC1 = Convert.ToInt32(strNumberC1);
if (numberA1 > numberB1) 
{
    Console.WriteLine(numberA1 + "max");    
}
else if(numberB1 > numberC1)
{ 
    Console.WriteLine(numberB1 + "max");
}
else
{
    Console.WriteLine(numberC1 + "max");
}  

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter number ");
string strNumber = Console.ReadLine ();
int number = Convert.ToInt32(strNumber);
if (number%2 == 0)
{
    Console.WriteLine ("Число четное");
}
else
{
   Console.WriteLine ("Число не четное"); 
}

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number ");
string strNumberD = Console.ReadLine ();
int numberD = Convert.ToInt32(strNumberD);
int result = 2;
while (result < numberD)
{
    Console.Write(result + " ");
    result +=2;
}    



