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
            public virtual void EditDocument(){
                System.Console.WriteLine("Document editing is available in the pro version");
            }
            public virtual void SaveDocument(){
                System.Console.WriteLine("Document saving is available in the pro version");
            }
        }
        class ProDocumentWorker : DocumentWorker{
            public sealed override void EditDocument(){
                System.Console.WriteLine("Document have edited");
            }
            public override void SaveDocument(){
                System.Console.WriteLine("The document is saved in the old format, saving in other formats is available in the expert version");
            }
        }
        
        class ExpertDocumentWorker : ProDocumentWorker{
            public sealed override void SaveDocument(){
                System.Console.WriteLine("The document is saved in the new format");
            }
        }
    }
    
}
