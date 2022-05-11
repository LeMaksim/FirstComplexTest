class Program
{
    // Метод добавления в массив элемента путем последовательного увеличения
    // длины массива на 1 и добавление самого элемента.
    static string[] AddElement(string[] arrayToEnlarge, string validString)
    {
        Array.Resize(ref arrayToEnlarge, arrayToEnlarge.Length + 1);
        arrayToEnlarge[arrayToEnlarge.Length - 1] = validString;
        return arrayToEnlarge;
    }
    // Метод создания массива, если пользователь не хочет его вводить сам.
    static string[] AutoArray()
    {
        string[] arrayToFill = { "We're", "no", "strangers", "to", "love", "You", "know", "the", "rules", "and", "so", "do", "I", "(do", "I)", };

        return arrayToFill;
    }
    // Метод создания массива, состоящего из элементов длиной (1, 3]
    static string[] LimitedArray(string[] unlimitedArray)
    {
        string str = String.Join(" ", unlimitedArray);
        Console.WriteLine(str);

        Console.WriteLine("Все элементы состоящие меньше, чем из 3х символов: ");
        string[] finalArray = new string[0];
        foreach (string item in unlimitedArray)
        {
            if (item.Length <= 3)
            {
                finalArray = AddElement(finalArray, item);
            }
        }
        str = String.Join(" ", finalArray);
        Console.WriteLine(str);
        return finalArray;
    }
    static void Main()
    {
        Console.Clear();
        string[] initialArray = new string[0];
        string str;
        int tumbler = 0;
    Start:
        Console.WriteLine("Хочешь ввести массив сам? y/n");
        string check = Console.ReadLine();
        if (check.ToLower() == "y")
        {
            Console.Clear();
            Console.WriteLine("Введи ESCAPE чтобы закончить ввод.");
            tumbler = 1;
            while (true)
            {
                str = Console.ReadLine();
                if (str.ToUpper() == "ESCAPE") break;
                else initialArray = AddElement(initialArray, str);
            }
            Console.WriteLine(String.Join(" ", initialArray));

        }
        if (check.ToLower() == "n")
        {
            tumbler = 0;
            AutoArray();
        }
        else if (check.ToLower() != "y" && check.ToLower() != "n")
        {
            Console.WriteLine("Попробуй ещё!(Press Any Key(Except for Power Button))");
            Console.ReadKey();
            Console.Clear();
            goto Start;
        }
        Console.Clear();
        // Инициализация и заполнение конечного массива.
        string[] finalArray;
        if (tumbler == 1)
        {
            Console.Write("Ты ввёл: ");
            finalArray = LimitedArray(initialArray);
        }
        if (tumbler == 0)
        {
            finalArray = LimitedArray(AutoArray());
        }
    }
}
