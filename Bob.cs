using System;

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
            }
        }

        return bobsResponse;
    }
}