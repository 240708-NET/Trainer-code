using System; 
using System.Collections.Generic;
using System.Linq;

public class Test{

    public static List<string> alphabetize(List<string> stringList)
    {
        // WRITE YOUR CODE HERE
        stringList.Sort();
        return stringList;
    }

    //DO NOT TOUCH THE CODE BELOW
    public static void Main()
    {
        List<string> stringList = new List<string>{"This", "Is", "A", "List", "Of", "Words"};
        List<string> sortedList = alphabetize(stringList);
        
        foreach(string word in sortedList)
        {
            Console.WriteLine(word);
        }
    }
}