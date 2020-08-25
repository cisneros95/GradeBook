using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Class is a blue print
            //Instantiate new Book();
            // book is a variable of type new Book
            var book = new Book("Raul's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();           
                                    
            
        }
    }
}