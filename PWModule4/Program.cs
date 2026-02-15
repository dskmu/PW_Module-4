using PWModule4;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Открыть отчет (Report)");
            Console.WriteLine("2. Открыть резюме (Resume)");
            Console.WriteLine("3. Открыть письмо (Letter)");
            Console.WriteLine("4. Открыть счет (Invoice)");
            Console.WriteLine("0. Выход");
            Console.Write("\nВыберите тип документа: ");

            string choice = Console.ReadLine();
            DocumentCreator creator = null;

            switch (choice)
            {
                case "1":
                    creator = new ReportCreator();
                    break;
                case "2":
                    creator = new ResumeCreator();
                    break;
                case "3":
                    creator = new LetterCreator();
                    break;
                case "4":
                    creator = new InvoiceCreator();
                    break;
                case "0":
                    Console.WriteLine("Завершение программы...");
                    return;
                default:
                    Console.WriteLine("Неверный выбор! Попробуйте снова.");
                    continue;
            }

            if (creator != null)
            {
                creator.OpenDocument();
            }
        }
    }
}