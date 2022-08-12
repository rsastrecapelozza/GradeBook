using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, lets calculate your statistics");
            var book = new InMemoryBook("Scott's Grade Book");
            book.GradeAdded += OnGradeAdded;
            Console.WriteLine(InMemoryBook.CATEGORY);


            CancellationTokenSource tokenSource = new CancellationTokenSource();

            var delay = new DelayClass();
            Task task = delay.PauseTaskDelay();
            task.Wait();
            EnterGrades(book);

            void EnterGrades(IBook book)
            {
                var menu = new Menu();
                string menuItem = "x";

                while (menuItem != "3")
                {
                    Console.Clear();
                    menuItem = menu.CallMenu();

                    if (menuItem == "1")
                    {
                        double grade = book.AskForAGrade();
                        book.AddGrade(grade);

                    }

                    if (menuItem == "2")
                    {
                        var stats = book.GetStatistics();
                        book.ShowStatistics(stats);
                        Task task2 = delay.PauseTaskDelay();
                        task2.Wait();
                    }
                
                    if(menuItem == "3")
                    {
                        Console.WriteLine("Ok, bye!");
                    }
                    Task task = delay.PauseTaskDelay();
                    task.Wait();
                }
            }
            static void OnGradeAdded(Object sender, EventArgs e)
            {
                Console.WriteLine("A grade was added");
            }

        }
    }
}
