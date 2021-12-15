using System;
using System.Text.RegularExpressions;


var rx = new Regex("(?<n1> \\d+) \\s* (?<op> \\+|-|\\*|/) \\s* (?<n2> \\d+)",
                   RegexOptions.IgnorePatternWhitespace);
var s = Console.ReadLine();
var m = rx.Match(s);
if (!m.Success)
{
    Console.WriteLine("No match");
    return;
}

Console.WriteLine($"Split input: {m.Groups["n1"].Value} {m.Groups["op"].Value} {m.Groups["n2"].Value}");
