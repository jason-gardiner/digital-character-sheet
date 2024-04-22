using System;
using System.Linq;

namespace DigitalCharacterSheet.Utilities;

public static class StringExtensionMethods
{
    public static int RemoveNonNumerics(this string str)
    {
        try
        {
            return int.Parse(str.Where(c => char.IsDigit(c)).ToArray());
        }
        catch (Exception ex)
        {
            return -1;
        }
    }
}