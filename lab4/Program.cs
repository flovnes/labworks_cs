global using System.Text;
global using System.Diagnostics;
global using System.Text.RegularExpressions;
global using System.Collections.Generic;
class lab4
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Console.WriteLine("1. Введіть n: ");
        // int num = int.Parse(Console.ReadLine());
        // Forward(num);
        // Backwards(num);
        // ForwardBuilder(num);
        // BackwardsBuilder(num);
        // Console.WriteLine("9. Фільтрування. Введіть рядок: ");
        // FormatString(Console.ReadLine());
        // Console.WriteLine("15. Формат. Введіть перший рядок, введіть другий рядок: ");
        // Console.WriteLine(CompareSpaces(Console.ReadLine(), Console.ReadLine()));
        // Console.WriteLine("16. Анаграми. Введіть перший рядок, введіть другий рядок: ");
        // Console.WriteLine(Anagram(Console.ReadLine(), Console.ReadLine()));
        // Console.WriteLine("17. Дужки. Введіть рядок: ");
        // Console.WriteLine(ValidateParentheses(Console.ReadLine()));
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
        string result_letters;
        string result_numbers;
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
        int count = 0;
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
        Regex regex = new Regex(@"[^a-zA-Z()<>/+:-;,. ]");
        string line = regex.Replace(input, "");

        char[] delimiters = { ' ', '(', ')', '[', ']', '<', '>', '+', '-', ',', '.', '/', ':', ';', '\t' };

        List<string> words = line.Trim().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> search = new List<string>();

        Console.WriteLine($"Found {words.Count} words to match: {string.Join(", ", words)}");

        for (int index = 0; index < words.Count; index++)
        {
            Console.WriteLine($"[{index + 1}/{words.Count}] Word: {words[index]}");

            if (CheckWord(words[index].ToCharArray(), pattern.ToCharArray()))
            {
                Console.WriteLine($"+ '{words[index]}' added.");
                search.Add(words[index]);
            }
        }

        switch (search.Count)
        {
            case 0:
                Console.WriteLine("No matches found.");
                break;
            default:
                Console.WriteLine($"\nFound {search.Count} matches in:\n  \"{input}\"");
                break;
        }

        return search.ToArray();
    }

    static bool CheckWord(char[] word, char[] pattern)
    {
        int wordIndex = 0, patternIndex = 0;
        while (wordIndex < word.Length)
        {
            Console.WriteLine(
                $"    ({patternIndex + 1}/{pattern.Length}) Expected: {pattern[patternIndex]}, got: {word[wordIndex]}");

            switch (pattern[patternIndex])
            {
                case '?':
                    Console.WriteLine("      :symbol skipped by '?'");
                    patternIndex++;
                    wordIndex++;
                    break;
                case '*':
                    Console.WriteLine("      :inside '*'");
                    if (patternIndex + 1 == pattern.Length)
                    {
                        Console.WriteLine("      :'*' is last character");
                        return true;
                    }
                    else
                    {
                        int indexOfLastNext = FindLast(word, pattern[patternIndex + 1]);
                        if (indexOfLastNext != -1)
                        {
                            Console.WriteLine(
                                $"      :jumped to the last occurrence of {pattern[patternIndex + 1]}");
                            wordIndex = indexOfLastNext;
                            patternIndex++;
                        }
                        else
                        {
                            Console.WriteLine(
                                $"      :no matches for {pattern[patternIndex + 1]} found. skipping word");
                            break;
                        }
                    }
                    break;
                default:
                    if (pattern[patternIndex] == word[wordIndex])
                    {
                        patternIndex++;
                        wordIndex++;
                    }
                    else
                    {
                        Console.WriteLine("- Unmatched symbol. Skipping word.");
                        return false;
                    }
                    break;
            }

            if (patternIndex > pattern.Length - 1)
            {
                return true;
            }
        }

        return false;
    }

    static int FindLast(char[] word, char letter)
    {
        Console.WriteLine($"      :'find_last' -> looking for the last occurrence of {letter}");
        int last = -1;
        for (int letterIndex = 0; letterIndex < word.Length; letterIndex++)
        {
            Console.WriteLine($"      'find_last': comparing {word[letterIndex]} to {letter}");
            if (word[letterIndex] == letter)
            {
                Console.WriteLine($"      'find_last': last index of {letter} is {letterIndex}");
                last = letterIndex;
            }
        }
        return last;
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