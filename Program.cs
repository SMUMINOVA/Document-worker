using System;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class DocumentWorker{
            public void OpenDocument(){
                System.Console.WriteLine("Your document is open");
            }
            public void EditDocument(){
                System.Console.WriteLine("Document editing is available in the pro version");
            }
            public void SaveDocument(){
                System.Console.WriteLine("Document saving is available in the pro version");
            }
        }
    }
}
