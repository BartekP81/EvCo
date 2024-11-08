// See https://aka.ms/new-console-template for more information
using EverybodyCodes;
string? army = Console.ReadLine();
int result = Quest1.
if(army != null && army.Length>0)
{
    foreach (char creature in army.ToCharArray())
        if(creature=='B')
            result+=1;
        else if (creature=='C')
            result+=3;
}
Console.WriteLine(result);
