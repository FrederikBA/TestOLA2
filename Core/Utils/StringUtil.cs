namespace Core.Utils;

public class StringUtil
{
    public string aBc { get; set; }

    public string Reverse()
    {
        var input = aBc;
        var reversed = string.Empty;
        for (var i = GetLength(input) - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        return reversed;
    }

    public string Capitalize()
    {
        var input = aBc;
        var capitalized = string.Empty;

        if (!string.IsNullOrEmpty(input))
        {
            foreach (char character in input)
            {
                if (character >= 'a' && character <= 'z')
                {
                    char capitalizedChar = (char)(character - ('a' - 'A'));
                    capitalized += capitalizedChar;
                }
                else if (character >= 'A' && character <= 'Z')
                {
                    capitalized += character;
                }
                else
                {
                    capitalized += character;
                }
            }
        }

        return capitalized;
    }

    public string LowerCase()
    {
        var input = aBc;
        var lowercased = string.Empty;

        if (!string.IsNullOrEmpty(input))
        {
            foreach (char character in input)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    char lowercasedChar = (char)(character + ('a' - 'A'));
                    lowercased += lowercasedChar;
                }
                else if (character >= 'a' && character <= 'z')
                {
                    lowercased += character;
                }
                else
                {
                    lowercased += character;
                }
            }
        }

        return lowercased;
    }



    private int GetLength(string input)
    {
        var length = 0;
        foreach (var character in input)
        {
            length++;
        }

        return length;
    }
}