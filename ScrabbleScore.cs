using System;
using System.Collections.Generic;
using System.Text;


class ScrabbleScore
{

    Dictionary<int, string> PointScores = new Dictionary<int, string> {
        {0, " " },
        {1, "AEIOULNRST"},
        {2, "DG" },
        {3, "BCMP" },
        {4, "FHVWY"},
        {5, "K"},
        {8, "JX"},
        {10, "QZ" }
    };


    public int GetScrabbleScore(string word) {

        int wordScore = 0;

        foreach (char letter in word.ToUpper()) {

            foreach (int score in PointScores.Keys) {

                if (PointScores[score].Contains(letter))
                {
                    wordScore += score;
                }
            }

        }


        return wordScore;
    }
}
