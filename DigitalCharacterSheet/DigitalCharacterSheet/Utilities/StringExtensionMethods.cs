using System;
using System.Linq;

namespace DigitalCharacterSheet.Utilities;

public static class StringExtensionMethods
{
    public static int ToPureInt(this string str) => str != String.Empty ? int.Parse(str.RemoveNonNumberics()) : 0;

    public static string RemoveNonNumberics(this string str) => new string(str.Where(char.IsDigit).ToArray());
}