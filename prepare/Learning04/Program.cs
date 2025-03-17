using System;

class Program
{
    static void Main(string[] args)
    {
        /* Student yo = new Student();
        Console.WriteLine(yo.GetName());
        Console.WriteLine(yo.GetNumber());
        BigStudent tu = new BigStudent("Raul", "14124");
        Console.WriteLine(tu.GetBigName());
        Console.WriteLine(tu.GetBigNumber()); */
        
        Assignment assignment= new Assignment("Robert", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment pitagoras = new MathAssignment("Pepino", "Fractions", "Section 7.3","Problem 9-19");
        Console.WriteLine(pitagoras.GetSummary());
        Console.WriteLine(pitagoras.GetHomeWorkList());

        WritingAssignment Shakespeare= new WritingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(Shakespeare.GetSummary());
        Console.WriteLine(Shakespeare.GetHomeWorkList());
    }
}
