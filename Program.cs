using System;

namespace HW10
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the text editor!");
            System.Console.WriteLine("To work with a text editor, a trial version is available to you. \nTo get great opportunities in the pro and expert versions, you must enter the access key");
            System.Console.WriteLine("Do you want to continue with trial version?y/n");
            if (Console.ReadLine().ToLower() == "n") goto start;
            else goto end;
            start :
            int counter;
            System.Console.WriteLine("Which version do you want to choose?\n1.Pro version\n2.Expert version");
            string choice = Console.ReadLine();
            switch(choice){
                case "1": {
                    counter = 3;
                    var pDocWorker = new ProDocumentWorker();
                    while (counter > 0){
                    System.Console.WriteLine($"Please enter access key to continue(you have {counter} chances): ");
                    if (Console.ReadLine() ==  pDocWorker.proAccessKey){
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Access to the pro version was successfully obtained");
                        Console.ForegroundColor = ConsoleColor.White;
                        while (Console.ReadLine().ToLower() != "q"){
                            System.Console.WriteLine("You can: \n1.Open document\n2.Edit document\n3.Save document");
                            switch(Console.ReadLine()){
                                case "1": pDocWorker.OpenDocument(); break;
                                case "2": pDocWorker.EditDocument(); break;
                                case "3": pDocWorker.SaveDocument(); break;
                            }
                            System.Console.WriteLine("Enter some key to continue or q to exit");
                        }
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Access key is incorrectly typed!");
                        counter--;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if (counter == 0){
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Error! Error! Access is denied! You can use only trial version!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                } break;
                case "2": {
                    counter = 3;
                    var eDocWorker = new ExpertDocumentWorker();
                    while (counter > 0){
                    System.Console.WriteLine($"Please enter access key to continue(you have {counter} chances): ");
                    if (Console.ReadLine() ==  eDocWorker.expertAccessKey){
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Access to the expert version was successfully obtained");
                        Console.ForegroundColor = ConsoleColor.White;
                        while (Console.ReadLine().ToLower() != "q"){
                            System.Console.WriteLine("You can: \n1.Open document\n2.Edit document\n3.Save document");
                            switch(Console.ReadLine()){
                                case "1": eDocWorker.OpenDocument(); break;
                                case "2": eDocWorker.EditDocument(); break;
                                case "3": eDocWorker.SaveDocument(); break;
                            }
                            System.Console.WriteLine("Enter some key to continue or q to exit");
                        }
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Access key is incorrectly typed!");
                        counter--;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                }
                if (counter == 0){
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Error! Error! Access is denied! You can use only trial version!");
                    Console.ForegroundColor = ConsoleColor.White;
                } break;
                default: {System.Console.WriteLine("Error!"); goto start;}
            }
            end :
            var tDocWorker = new DocumentWorker();
            while (Console.ReadLine().ToLower() != "q"){
                System.Console.WriteLine("You can: \n1.Open document\n2.Edit document\n3.Save document");
                switch(Console.ReadLine()){
                    case "1": tDocWorker.OpenDocument(); break;
                    case "2": tDocWorker.EditDocument(); break;
                    case "3": tDocWorker.SaveDocument(); break;
                }
                System.Console.WriteLine("Enter some key to continue or q to exit");
            }
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
            public string proAccessKey = "SecureAccessCodeForProVersion";
            public sealed override void EditDocument(){
                System.Console.WriteLine("Document have edited");
            }
            public override void SaveDocument(){
                System.Console.WriteLine("The document is saved in the old format, saving in other formats is available in the expert version");
            }
        }
        
        class ExpertDocumentWorker : ProDocumentWorker{
            public string expertAccessKey = "SecureAccessCodeForExpertVersion";
            public sealed override void SaveDocument(){
                System.Console.WriteLine("The document is saved in the new format");
            }
        }
    }
    
}
