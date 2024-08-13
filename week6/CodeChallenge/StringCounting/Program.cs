using System;
using System.Collections.Generic;
using System.Linq;

public class Test{
   
    public static int checkForALetter(List<string> stringList, string letter) {   
        int result = 0;
        foreach (string l in stringList) {
            if (l.ToLower().Contains(letter)) {
                result++;
            }
        }

        return result;
    }

    public static void Main() {
        string letter = "p";
        List<string> stringList = new List<string>{"quick", "rousing", "snappy", "sparkling", "sprightly", "spry", "stirring", "vivacious", "zippy"};

        Console.WriteLine(checkForALetter(stringList, letter));
    }
}