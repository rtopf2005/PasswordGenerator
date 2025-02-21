
using System;

Console.WriteLine("Hello user, please enter how many characters long you would like your password: ");

int a = -1;

if (int.TryParse(Console.ReadLine(), out a) && a>0)
{

        Random random = new Random();

        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789#@!$%^&*-_";
        string s = new string(Enumerable.Repeat(chars, a).Select(s => s[random.Next(s.Length)]).ToArray());
        Console.WriteLine(s);
}
else
{
    Console.WriteLine("You entered an invalid password length. Please run this program again.");
}
