/* Напиши программу, которая принимает на вход трехзначное число, а на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918-> 1 */

int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int threeDigitNumber (int number)
{
    int twoDigitNumber = number / 10;
    int secondDigitNumber = twoDigitNumber % 10;
    return secondDigitNumber;
}
int randomNumber = GetRandomNumberInRange(100, 999);
int secondDigit = threeDigitNumber(randomNumber);
Console.WriteLine($"Второй цифрой трехзначного числа {randomNumber} является цифра {secondDigit}");
