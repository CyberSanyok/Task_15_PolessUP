using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        string beauty = "aabbaca";
        Console.WriteLine(FindBeauty(beauty));
    }
    public static int NumOfMostCommonSymbol(string beauty) 
    {
        int maxCount = 0;
        
        for (int i = 0; i < beauty.Length; i++) 
        {
            int count = 0;
            for (int j = 0; j < beauty.Length; j++)
            {
                if (beauty[i] == beauty[j])
                {
                    count++;
                    if(count>maxCount)maxCount = count;
                }
            }
        }
        return maxCount;
    }
    public static int NumOfLeastCommonSymbol(string beauty)
    {
        int minCount = beauty.Length;
        for (int i = 0; i < beauty.Length; i++)
        {
            int count = beauty.Count(x => x == beauty[i]);
        if (count < minCount)
            {
                minCount = count;
            }                       
        }
        return minCount;
    }
    public static int FindBeauty(string beauty) 
    {
      return NumOfMostCommonSymbol(beauty)-NumOfLeastCommonSymbol(beauty);
    }
}