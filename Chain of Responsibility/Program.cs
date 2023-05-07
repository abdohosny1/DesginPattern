using System;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            JopApplication jopApplication = new JopApplication
            {
                ApplicationName = "Abdo",
                JopCode = "123",
                jopTitle = "Great Jop",
                Comments = new System.Text.StringBuilder()
            };

            HREvalHandler hREvalHandler = new HREvalHandler();
            TechnicalEvalHandler technicalEvalHandler = new TechnicalEvalHandler();

            hREvalHandler.SetNext(technicalEvalHandler);
            hREvalHandler.HandleRequest(jopApplication);

            Console.WriteLine(jopApplication.Comments);
            Console.ReadLine();
        }
    }
}
