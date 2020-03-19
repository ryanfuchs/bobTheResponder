using System;
using System.Runtime.CompilerServices;

using Microsoft.VisualBasic;

public static class Bob
{
    public static string Response(string statement)
    {
        string bobsResponse = "";

        foreach (char statementCharacter in statement)
        {
            switch (statementCharacter)
            {
                case '.':
                    bobsResponse = "Whatever.";
                    break;

                case '!':
                    bobsResponse = "Whoa, chill out!";
                    break;

                case '?':
                    if (statement == statement.ToUpper() && !statementContainsNoLetters(statement))
                    {
                        bobsResponse = "Calm down, I know what I'm doing!";
                    }
                    else
                    {
                        bobsResponse = "Sure.";
                    }
                    break;
            }
        }

        if (bobsResponse == "")
        {
            if (statement == statement.ToUpper())
            {
                if (statementContainsNoLetters(statement))
                {
                    bobsResponse = "Whatever.";
                }
                else
                {
                    bobsResponse = "Whoa, chill out!";
                }
            }
        }

        return bobsResponse;
    }

    private static bool statementContainsNoLetters(string statement)
    {
        if (statement.ToUpper() == statement.ToLower())
        {
            return true;
        }

        return false;
    }
}