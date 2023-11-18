
using AccessModP2.Weapon.Models;

using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


#region task1 Math methods
////Max ve Min ededin tapılması
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int max = Math.Max(x, y);
int min = Math.Min(x, y);
int result = max + min;
Console.WriteLine(result);

////kok alma
double num = double.Parse(Console.ReadLine());
double numroot = Math.Sqrt(num);
Console.WriteLine(numroot);


////menfi musbete cevirme bir nov modul
decimal num1 = decimal.Parse(Console.ReadLine());
decimal num2 = decimal.Parse(Console.ReadLine());
decimal result = num2 - num1;
Console.WriteLine(Math.Abs(result));

////yuvarlaqladirma
decimal z = decimal.Parse(Console.ReadLine());
Console.WriteLine(Math.Round(z));






#endregion

#region task2 regex methods

//son herfi m olani tap
string regexPattern = @"m$";
        Regex regex = new Regex(regexPattern);
        string input = "ilham hasn't form";
        Match match = regex.Match(input);

if (match.Success)
{
    Console.WriteLine("Match found.");
}
else
{
    Console.WriteLine("No match found.");
}




#endregion

#region Task3
Weapon weapon = new();
weapon.CombFilling(30);
weapon.SingleShotWeapon(0.7);
weapon.AutomaticWeapon(0.7);
Console.WriteLine(weapon.CombFilling);
#endregion






