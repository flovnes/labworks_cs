global using System.Text;
global using System.Diagnostics;
global using System.Text.RegularExpressions;
global using System.Collections.Generic;
class lab4
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("1. Введіть n: ");
        int num = int.Parse(Console.ReadLine());
        Forward(num);
        Backwards(num);
        ForwardBuilder(num);
        BackwardsBuilder(num);
        Console.WriteLine("9. Фільтрування. Введіть рядок: ");
        FormatString(Console.ReadLine());
        Console.WriteLine("15. Формат. Введіть перший рядок, введіть другий рядок: ");
        Console.WriteLine(CompareSpaces(Console.ReadLine(), Console.ReadLine()));
        Console.WriteLine("16. Анаграми. Введіть перший рядок, введіть другий рядок: ");
        Console.WriteLine(Anagram(Console.ReadLine(), Console.ReadLine()));
        Console.WriteLine("17. Дужки. Введіть рядок: ");
        Console.WriteLine(ValidateParentheses(Console.ReadLine()));
        Console.WriteLine("18. Пошук. Введіть Введіть рядок та шаблон: ");
        foreach (string word in FindWords(Console.ReadLine(), Console.ReadLine())) { Console.Write($"'{word}' "); }
        Console.WriteLine("\n18(regex). Введіть рядок та шаблон: ");
        foreach (Match match in FindWordsRegex(Console.ReadLine(), Console.ReadLine())) { Console.Write($"'{match.Value}' "); }
    }
    static void Forward(int num)
    {
        var sw = new Stopwatch();
        string str = new string(new char[] { });

        sw.Start();
        for (int i = 1; i <= num; i++) { str += (i + " "); }
        sw.Stop();

        Console.WriteLine($"Completed \"Forward()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void Backwards(int num)
    {
        var sw = new Stopwatch();
        string str = new string(new char[] { });

        sw.Start();
        for (int i = num; i >= 1; i--) { str = i + " " + str; }
        sw.Stop();

        Console.WriteLine($"Completed \"Backwards()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void ForwardBuilder(int num)
    {
        var sw = new Stopwatch();
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = 1; i <= num; i++) { str.Append($"{i} "); }
        sw.Stop();

        Console.WriteLine($"Completed \"ForwardBuilder()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void BackwardsBuilder(int num)
    {
        var sw = new Stopwatch();
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = num; i >= 1; i--) { str.Append($"{i} "); }
        sw.Stop();

        Console.WriteLine($"Completed \"BackwardsBuilder()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void FormatString(string str)
    {
        StringBuilder result_letters = new StringBuilder();
        StringBuilder result_numbers = new StringBuilder();
        foreach (char letter in str)
        {
            if (Char.ToLower(letter) >= 'a' && Char.ToLower(letter) <= 'z') { result_letters.Append(letter); }
            if (letter >= '0' && letter <= '9') { result_numbers.Append(letter); }
        }
        Console.WriteLine(result_letters.Append(result_numbers));
    }

    static string CompareSpaces(string input, string example)
    {
        foreach (var (letterExample, letterInput) in example.Zip(input))
        {
            if (char.IsWhiteSpace(letterExample) && letterExample != letterInput) { return "NO"; }
        }
        return "YES";
    }

    static string Anagram(string input, string other)
    {
        var inputLetters = new string(input.ToLower().Where(char.IsLetter).ToArray());
        var otherLetters = new string(other.ToLower().Where(char.IsLetter).ToArray());

        return InsertSort(inputLetters).Equals(InsertSort(otherLetters)) ? "YES" : "NO";
    }

    static string InsertSort(string s)
    {
        var st = new List<char>(s.Length);
        var si = s.GetEnumerator();
        if (si.MoveNext())
        {
            st.Add(si.Current);
        }
        else
        {
            return new string(st.ToArray());
        }

        while (si.MoveNext())
        {
            var found = -1;
            for (var idx = 0; idx < st.Count; idx++)
            {
                if (st[idx] >= si.Current)
                {
                    found = idx;
                    break;
                }
            }

            if (found != -1) { st.Insert(found, si.Current); } else { st.Add(si.Current); }
        }

        return new string(st.ToArray());
    }

    static string ValidateParentheses(string input)
    {
        var count = 0;
        foreach (var symbol in input)
        {
            switch (symbol)
            {
                case '(':
                    count++;
                    break;
                case ')':
                    count--;
                    break;
                default: break;
            }

            if (count < 0)
            {
                return "NO";
            }
        }

        return count == 0 ? "YES" : "NO";
    }

    static string[] FindWords(string input, string pattern)
    {
        string line = Regex.Replace(input, @"[^a-zA-Z()<>[]/+-:;,.   ]", string.Empty);
        char[] delimiters = { ' ', '(', ')', '[', ']', '<', '>', '+', '-', ',', '.', '/', ':', ';', '\t' };
        string[] words = line.Trim().Split(delimiters, System.StringSplitOptions.RemoveEmptyEntries);
        List<string> search = new List<string>();
        Console.WriteLine($"Words to match: {string.Join(", ", words)}");

        foreach (var word in words)
        {
            Console.WriteLine($"[{Array.IndexOf(words, word) + 1}/{words.Length}] Word: {word}");
            var star = false;
            var temp = "";
            var patternI = 0;
            var wordI = 0;

            while (wordI < word.Length)
            {
                Console.WriteLine($"    ({patternI + 1}/{pattern.Length}) Expected: {pattern.Substring(patternI, 1)}, got: {word.Substring(wordI, 1)}");

                switch (pattern.Substring(patternI, 1))
                {
                    case "?":
                        Console.WriteLine("      :symbol skipped by '?'");
                        patternI++;
                        wordI++;
                        break;
                    case "*":
                        if (star)
                        {
                            Console.WriteLine("      :'*' next symbol");
                            if (temp != word.Substring(wordI, 1))
                            {
                                Console.WriteLine("    Unmatched symbol. '*' ended.");
                                patternI++;
                                star = false;
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("      :'*' started.");
                            star = true;
                            temp = word.Substring(wordI, 1);
                            Console.WriteLine($"      :saving '*' match - '{temp}'");
                        }
                        wordI++;
                        continue;
                    default:
                        if (pattern.Substring(patternI, 1) == word.Substring(wordI, 1))
                        {
                            patternI++;
                            wordI++;
                            continue;
                        }
                        else
                        {
                            patternI++;
                            wordI++;
                            Console.WriteLine("- Unmatched symbol. Skipping word.");
                            break;
                        }
                }

                if (patternI == pattern.Length - 1)
                {
                    Console.WriteLine($"+ '{word}' added.");

                    search.Add(word);
                    break;
                }
            }
        }
        switch (search.Count)
        {
            case 0: Console.WriteLine("No matches found :("); break;
            default: Console.WriteLine($"\nFound {search.Count} matches in:\n  \"{input}\""); break;
        }
        return search.ToArray();
    }
    static MatchCollection FindWordsRegex(string input, string example)
    {
        var search = new Regex(example.Replace("?", ".").Replace("*", "(\\w)*"));
        var result = search.Matches(input);
        Console.WriteLine($"\nFound {result.Count} matches in:\n  \"{input}\"");
        Console.WriteLine($"Matched words: ");
        return result;
    }
}