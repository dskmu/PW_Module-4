using PWModule4;
class Program
{
    static void Main()
    {
        DocumentCreator creator;

        

        creator = new ReportCreator();
        creator.OpenDocument();

        creator = new ResumeCreator();
        creator.OpenDocument();

        creator = new LetterCreator();
        creator.OpenDocument();


    }
}