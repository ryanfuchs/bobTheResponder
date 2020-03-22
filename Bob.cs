using System;
using System.Linq;
using System.Runtime.CompilerServices;

using Microsoft.VisualBasic;

public static class Bob
{
    public static string Response(string statement)
    {
        string bobsResponse = string.Empty;

        foreach (char statementCharacter in statement)
        {
            switch (statementCharacter)
            {
                case '.':
                    bobsResponse = "Whatever.";
                    break;

                case '!':
                    bobsResponse = "Whoa, chill out!";
                    if (statement != statement.ToUpper())
                    {
                        bobsResponse = "Whatever.";
                    }
                    break;

                case '?':
                {
                    if (statement == statement.ToUpper() && !StatementContainsNoLetters(statement))
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
        }

        if (IsStringEmpty(statement))
        {
            bobsResponse = "Fine. Be that way!";
        }
        else if(bobsResponse == string.Empty)
        {
            if (statement == statement.ToUpper())
            {
                bobsResponse = StatementContainsNoLetters(statement) ? "Whatever." : "Whoa, chill out!";
            }
            else
            {
                bobsResponse = "Whatever.";
            }
        }

        return bobsResponse;
    }

    private static bool IsStringEmpty(string statement) => statement.All(statementCharacter => statementCharacter == ' ' || !IsStringWhitespace(statementCharacter));

    private static bool IsStringWhitespace(char statementCharacter) => statementCharacter != '\t' && statementCharacter != '\n' && statementCharacter != '\r';

    private static bool StatementContainsNoLetters(string statement) => statement.ToUpper() == statement.ToLower();
}