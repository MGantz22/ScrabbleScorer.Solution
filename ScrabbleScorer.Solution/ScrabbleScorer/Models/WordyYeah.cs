using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Models
{
  public class WordyYeah
  {
    public static int LetterScore(char value)
   {
    char[] WordArray = {value};
    int scoreValue = 0;
    List<char> listPoint1 = new List<char> {'A', 'E', 'I', 'O','L','N','R','S','T'};
    List<char> listPoint2 = new List<char> {'D', 'G'};
    List<char> listPoint3 = new List<char> {'B','C','M','P'};
    List<char> listPoint4 = new List<char> {'F','H','V','W','Y'};
    List<char> listPoint5 = new List<char> {'J','X'};
    List<char> listPoint6 = new List<char> {'Q','Z'};

    foreach (char input in WordArray)
    {
       if (listPoint1.Contains(input))
    {
        scoreValue += 1;
    }
    else if (listPoint2.Contains(input))
    {
        scoreValue +=2;
    }
    else if (listPoint3.Contains(input))
    {
        scoreValue +=3;
    }
       else if (listPoint4.Contains(input))
    {
        scoreValue +=4;
    }
    else if (listPoint5.Contains(input))
    {
        scoreValue +=5;
    }
       else if (listPoint6.Contains(input))
    {
      scoreValue +=6;
    }
    else
    {
      scoreValue = 0;
    }

    }
    
    return scoreValue;
   }

  }

  
}
