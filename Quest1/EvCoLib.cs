namespace EverybodyCodes;

public class Quest1
{
    public int PotionsNo (string? army)
    {
        int result = 0;
        if(army != null && army.Length>0)
{
    foreach (char creature in army.ToCharArray())
        if(creature=='B')
            result+=1;
        else if (creature=='C')
            result+=3;
}
    }
}
