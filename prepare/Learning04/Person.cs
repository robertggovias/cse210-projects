// Simple inheritace
public class Person
{
    public string GetName()
    {
        return "Robert";
    }
}

public class Student : Person
{
    public string GetNumber()
    {
        return "98321094782";
    }
}

public class BigPerson
{
    // una variable protegida es legible entre las clase derivada (BigStudent)
    protected string _big_name;

    public BigPerson(string bigName)
    {
        _big_name = bigName;
    }

    public string GetBigName()
    {
        return _big_name;
    }
}

public class BigStudent : BigPerson
{
    private string _number;

    public BigStudent(string hereda_bigname, string numeroBig)
        : base(hereda_bigname) // base llama al constructor de la clase padre
    {
        _number = numeroBig;
        //hereda_bigname = base.GetBigName();
        
    }
    public string GetStudentInfo(){
        return _big_name +" " + _number;
    }

    public string GetBigNumber()
    {
        return _number;
        
    }
    
}