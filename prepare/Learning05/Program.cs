using System;

class Program
{
    static void Main(string[] args)
    {
        Square squareA = new Square( "red",45);
        Console.WriteLine(
            $"I'm a {squareA.GetColor()} square with a side of {squareA._side} an area of {squareA.GetArea()}"
        );
        Rectangle rectangleA = new Rectangle("gray",10, 5);
        Circle circleA = new Circle("Blue",10);
        Console.WriteLine(
            $"I'm a {rectangleA.GetColor()} rectangle with a long side of {rectangleA._lengtLongSide} and a short side of {rectangleA._lengthShortSide} an area of {rectangleA.GetArea()}"
        );
        Console.WriteLine(
            $"I'm a {rectangleA.GetColor()} {rectangleA.GetShape()} and I have {rectangleA.Description()} and my area is {rectangleA.GetArea()}"
        );

        Console.WriteLine(
            $"I'm a {circleA.GetColor()} {circleA.GetShape()} and I have {circleA.Description()} and my area is {circleA.GetArea()}"
        );

        List<Shape> listA = new List<Shape>();
        listA = [circleA, squareA, rectangleA];

        foreach (Shape shape in listA)
        {
            Console.WriteLine(
                $"From list = I'm a {shape.GetColor()} {shape.GetShape()} and I have {shape.Description()} and my area is {shape.GetArea()}"
            );
        }

        /* Employee employee= new Employee("Pedro");
        employee.CalculatePay();
        Console.WriteLine($"{employee.Name} es asalariado {employee.CalculatePay()}");
        HourlyEmployee hourlyEmployee = new HourlyEmployee("Ignacio");
        Console.WriteLine($"{hourlyEmployee.Name} trabaja por horas {hourlyEmployee.CalculatePay()}");
        List<Employee> employees = new List<Employee>();
        employees=[];
        
        employees.Add(new Employee("GReat"));
        employees.Add(new HourlyEmployee("notGreat"));


        
        foreach (Employee e_mployee in employees){
            float pay = e_mployee.CalculatePay();
            Console.WriteLine($"{e_mployee.Name} {pay}");
        }
        static void DisplayPayCheck (Employee eejmplo){
            float pay = eejmplo.CalculatePay();
            string nombre = eejmplo.Name;
            Console.WriteLine ($"La funcion display apolicado {nombre} {pay}");
        }
        
        DisplayPayCheck(employee);
        DisplayPayCheck(hourlyEmployee);
        Employee manager = new Employee("nuevo gerente");

        static Employee GetManager(){
        
            return new Manager("Enrique");
        }
        static void DisplayManagerPay(){
            Employee manager = GetManager();
            float pay = manager.CalculatePay();
            Console.WriteLine($"El Manager {manager.Name} earn this amount {pay}");
        }
        DisplayManagerPay();

        List<EmployeeAbstract> employeeAbstracts = new List<EmployeeAbstract>();
        employeeAbstracts.Add(new SalaryEmployeeAbstract("Jaime"));
        employeeAbstracts.Add(new HourlyEmployeeAbstract("Carlos"));
        employeeAbstracts.Add(new ManagerAbstract("Papa"));
        foreach (EmployeeAbstract e in employeeAbstracts){
            float pay = e.CalculatePayAbstract();
            Console.WriteLine($"se llama {e._NameAbstract} y recibe {pay} ");

        }
         List<IEmployee> iemployeeAbstracts = new List<IEmployee>();
        iemployeeAbstracts.Add(new ISalaryEmployeeAbstract("Jaime"));
        iemployeeAbstracts.Add(new IHourlyEmployeeAbstract("Carlos"));
        iemployeeAbstracts.Add(new IManagerAbstract("Papa"));
        foreach (IEmployee e in iemployeeAbstracts){
            float pay = e.CalculatePayInterface();
            Console.WriteLine($"recibe {pay} ");
    } */
    }

    /* public class Employee
    {
        public Employee(string name){
            Name = name;
        }
        public string Name;
    
            protected float salary = 100f;
            public virtual float CalculatePay(){
                return salary;
            }
    }
    
    public class HourlyEmployee : Employee
    {
        public HourlyEmployee(string name):base(name){
    
        }
        
        private float rate = 9f;
        private float hours = 100f;
    
        public override float CalculatePay(){
            return rate*hours;
        }
    
        
    }
    public class Manager : Employee
    {
        public Manager(string name):base(name){}
        public float _bonus = 500;
        public override float CalculatePay(){
            return _bonus + salary;
        }
    }
    
    public abstract class EmployeeAbstract{
        public string _NameAbstract;
        protected float salary = 100f;
        protected float rate = 9f;
        protected float _bonus = 500;
        public EmployeeAbstract(string name){
            _NameAbstract = name;
        }
        public abstract float CalculatePayAbstract();
    }
    public class SalaryEmployeeAbstract : EmployeeAbstract
    {
        public string Name;
        public SalaryEmployeeAbstract(string name):base(name){
            Name = name;
        }
        public override float CalculatePayAbstract(){
            return salary;
        }
    }
    public class ManagerAbstract : EmployeeAbstract{
        public ManagerAbstract(string name):base(name){}
        public override float CalculatePayAbstract()
        {
            return salary + _bonus;
        }
    }
    
    public class HourlyEmployeeAbstract : EmployeeAbstract{
        public HourlyEmployeeAbstract(string name) :base(name){
        }
        public float _hours = 100;
        public override float CalculatePayAbstract(){
            return rate * _hours;
        }
    }
    
    public interface IEmployee{
        float CalculatePayInterface();
    }
    
    public class ISalaryEmployeeAbstract : IEmployee
    {
        public string Name;
        public ISalaryEmployeeAbstract(string name){
            Name = name;
        }
        float salary = 100f;
        public float CalculatePayInterface(){
            return salary;
        }
    }
    public class IManagerAbstract : IEmployee{
        public string Name;
        float salary = 100;
        float _bonus = 500;
        public IManagerAbstract(string name){}
        public float CalculatePayInterface()
        {
            return salary + _bonus;
        }
    }
    
    public class IHourlyEmployeeAbstract : IEmployee{
        public string Name;
        float rate = 9f;
        public IHourlyEmployeeAbstract(string name){
        }
        public float _hours = 100;
        public float CalculatePayInterface(){
            return rate * _hours;
        }
    } */
}
