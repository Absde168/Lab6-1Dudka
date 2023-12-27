Console.WriteLine("Введите первое натуральное число:");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
int number2 = int.Parse(Console.ReadLine());

if (IsPalindrome(number1) || IsPalindrome(number2)) 
{
    Console.WriteLine("Хотя бы одно из чисел является палиндромом");
}
else
{
    Console.WriteLine("Ни одно из чисел не является палиндромом");
}
Console.ReadLine();
static bool IsPalindrome(int number)
{
    string str = number.ToString(); 

    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i]) 
        {
            return false;
        }
    }

    return true;
}
