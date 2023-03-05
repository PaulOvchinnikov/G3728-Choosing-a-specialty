Console.Clear();
Console.WriteLine(@"
Привет! Это Итоговое задание выполнено Павлом Овчинниковым гр. G3728 Аналитик данных 04.12.22
Программа из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
");
System.Console.WriteLine(" ");
System.Console.WriteLine("Для продолжения нажмите любую клавишу");
Console.ReadKey();


// Метод ввода строки с клавиатуры
string ReadText(string msg)
{
    Console.Write(msg);
    string? read_string_Data = Console.ReadLine() ?? "0";
    return read_string_Data;
}

// Метод разделения строки на слова в массив 
string[] TextSplitting(string text)
{
    char[] delimiterChars = { ' ', ',', '.', ':', ';', '"', '!', '?', '\t' };
    // char[] delimiterChars = { ' ', ',', '.', '"', '!', '?', '\t' };

    System.Console.WriteLine($"Первоначальный текст: '{text}'");
    string[] words = text.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

    // Вывод результата в консоль
    System.Console.WriteLine($"В тексте {words.Length} слов. Вот те из них, длина которых меньше либо равна трём символам: ");
    foreach (var word in words)
    {
        if (word.Length <= 3)
        { System.Console.WriteLine($"< {word} >, {word.Length}"); }
    }

    return words;
}

// string text = "one\ttwo :,five six seven";
string text = "Функция Аккермана ?! Заодно и вспомним , чего никогда не знали!!! Ну что ж , а не запустить ли нам подсчет Аккермана 5 на 5";
TextSplitting(text);

System.Console.WriteLine(" ");
System.Console.WriteLine("Для продолжения нажмите любую клавишу");
Console.ReadKey();

text = ReadText("А теперь с произвольным текстом. Введите введите с клавиатуры, либо вставьте скопированое: ");
TextSplitting(text);

System.Console.WriteLine();
System.Console.WriteLine("The End.");
