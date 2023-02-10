using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        var fileList = new List<string>()
        {
            "OODP assignment.docx",
            "Project Presentation.pptx",
            "TODO list.xlsx",
        };

        string whichFileToDelete = fileList[0];

        Console.WriteLine("File selected to delete: " + whichFileToDelete);

        char confirm = 'n';

        while (confirm != 'y') {
            Console.WriteLine("Really delete this file? (y/n)");
            string conf = Console.ReadLine();
            if (conf == "y") {
                confirm = 'y';
            } else if (conf == "n") {
                confirm = 'n';
                break;
            }
        };

        if (confirm == 'y')
        {
            fileList.Remove(whichFileToDelete);
            Console.WriteLine("File deleted");
        };
    }
}