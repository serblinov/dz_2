/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645-> 5
78-> третьей цифры нет
32679 -> 6 */
Console.WriteLine("Введите число: ");
int DigitNumber = Convert.ToInt32(Console.ReadLine());
int Digit = new int();
while(DigitNumber > 1000)
{
    if(DigitNumber > 1000)
    {
        DigitNumber = DigitNumber /10;   
    }
} 
     if(DigitNumber < 1000)
    {
        Digit = DigitNumber % 10;
        Console.WriteLine($"Третья цифра: {Digit}");
    }
                                                                                                          
if(DigitNumber < 100)
{
    Console.WriteLine("Третьей цифры нет");
}