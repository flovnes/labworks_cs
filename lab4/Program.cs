using System;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

#nullable disable

class lab4
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Console.WriteLine("Введіть n: ");
        // int num = int.Parse(Console.ReadLine());
        // // Forward(num);
        // // Backwards(num);
        // ForwardBuilder(num);
        // BackwardsBuilder(num);
        // Console.WriteLine("Введіть рядок: ");
        // FormatString(Console.ReadLine());
        // Console.WriteLine("Введіть рядок: ");
        // Console.WriteLine(compareSpaces(input, example));
        // Console.WriteLine("Введіть рядок: ");
        // Console.WriteLine(anagram(input, example));
        // Console.WriteLine("Введіть рядок: ");
        // Console.WriteLine(validateParentheses("((()))"));
        // Console.WriteLine("Введіть рядок: ");
        Console.WriteLine(findWords("Hello World, How are you dooing?", "d*i?g"));
        // findWordsRegex("Hello World, How are you doing?", "H*o");
    }

    static void Forward(int num)
    {
        var sw = new Stopwatch();
        string str = new string(new char[] { });

        sw.Start();
        for (int i = 1; i <= num; i++) { str += (i + " "); }
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"Forward()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void Backwards(int num)
    {
        var sw = new Stopwatch();
        string str = new string(new char[] { });

        sw.Start();
        for (int i = num; i >= 1; i--) { str = i + " " + str; }
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"Backwards()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void ForwardBuilder(int num)
    {
        var sw = new Stopwatch();
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = 1; i <= num; i++) { str.Append($"{i} "); }
        sw.Stop();
        // Console.WriteLine(str);
        Console.WriteLine($"Completed \"ForwardBuilder()\" for N = {num} in {sw.ElapsedMilliseconds}ms");
    }

    static void BackwardsBuilder(int num)
    {
        var sw = new Stopwatch();
        StringBuilder str = new StringBuilder();

        sw.Start();
        for (int i = num; i >= 1; i--) { str.Append($"{i} "); }
        sw.Stop();
        // Console.WriteLine(str);
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

    static string compareSpaces(string input, string example)
    {
        foreach (var (letterExample, letterInput) in example.Zip(input))
        {
            if (char.IsWhiteSpace(letterExample) && letterExample != letterInput)
            {
                return "NO";
            }
        }
        return "YES";
    }

    static string anagram(string input, string example)
    {
        input = input.ToLower();
        example = example.ToLower();

        var inputLetters = new string(input.Where(char.IsLetter).ToArray());
        var exampleLetters = new string(example.Where(char.IsLetter).ToArray());

        inputLetters = InsertSort(inputLetters);
        exampleLetters = InsertSort(exampleLetters);

        return inputLetters.Equals(exampleLetters) ? "YES" : "NO";
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

            if (found != -1)
            {
                st.Insert(found, si.Current);
            }
            else
            {
                st.Add(si.Current);
            }
        }

        return new string(st.ToArray());
    }

    static string validateParentheses(string input)
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
            }

            if (count < 0)
            {
                return "NO";
            }
        }

        return count == 0 ? "YES" : "NO";
    }

    static string findWords(string input, string example)
    {
        Regex.Replace(input, @"[^a-zA-Z ]", string.Empty);
        var words = input.Trim().Split();
        Console.WriteLine($"Words: {string.Join(", ", words)}");

        foreach (var word in words)
        {
            var star = false;
            var temp = "";
            var exampleI = 0;
            var wordI = 0;


            while (wordI < word.Length)
            {
                Console.WriteLine($"> Word: {word}");

                Console.WriteLine($"Char: {exampleI + 1}, Max: {example.Length}");

                Console.WriteLine($"Example symbol: {example.Substring(exampleI, 1)}, Word symbol: {word.Substring(wordI, 1)}");


                if (exampleI == example.Length - 1)
                {
                    return word;
                }

                switch (example.Substring(exampleI, 1))
                {
                    case "?":
                        Console.WriteLine("Found '?'");
                        Console.WriteLine($"Word symbol: {word.Substring(wordI, 1)}");
                        break;
                    case "*":
                        if (star)
                        {
                            Console.WriteLine("Still in '*'");
                            Console.WriteLine($"Word symbol: {word.Substring(wordI, 1)}");
                            if (temp != word.Substring(wordI, 1))
                            {
                                Console.WriteLine("Unmatched symbol. Star matching ends.");
                                exampleI++;
                                star = false;
                                continue;
                            }
                            else
                            {
                                wordI++;
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Found '*'");
                            star = true;
                            temp = word.Substring(wordI, 1);
                            Console.WriteLine($"Saving temp: {temp}");
                        }
                        wordI++;
                        continue;
                    default:
                        if (example.Substring(exampleI, 1) != word.Substring(wordI, 1))
                        {
                            exampleI++;
                            wordI++;
                            Console.WriteLine("Unmatched symbol, skipping word.");
                            goto exit_loop;
                            // break;
                        }
                        break;
                }
                exampleI++;
                wordI++;
                // break;
            }
        exit_loop:;
        }

        return "No matches found";
    }
    static void findWordsRegex(string input, string example)
    {
        var search = new Regex(example.Replace("?", ".").Replace("*", "(\\w)*"));
        var result = search.Match(input);
        if (result.Success)
        {
            Console.WriteLine(result.Value);
        }
        else
        {
            Console.WriteLine("No matches found.");
        }
    }
}