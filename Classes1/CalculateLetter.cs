using System;
using System.Globalization;
namespace Palindrom.Classes1;
class Letter
{
    public string Text{get;set;}
    public void Claculate()
    {
        System.Console.WriteLine();
        Console.Write("Enter text");
        Text=Console.ReadLine();

        Char[]a=Text.ToArray();
        // Simvollarning hisoblagichi
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        // Har bir simvolni sanash
        foreach (char c4 in a)
        {
            if (charCount.ContainsKey(c4))
            {
                charCount[c4]++;//HISOBLAYDIGAN SANAGICH
            }
            else
            {
                charCount[c4] = 1;
            }
         }
        // Natijalarni chiqarish
        foreach (var kvp in charCount)
        {
            Console.WriteLine($"'{kvp.Key}': {kvp.Value} martta");
        }
        
    }
}