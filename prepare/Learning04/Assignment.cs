public class Assignment{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;}
    public string GetSummary() {
        return _studentName + " - " + _topic;}
        public string GetStudentName(){
            return _studentName;}
        public string GetTopic(){
            return _topic;}
}

public class Vehicle{
    public int _fuel;    
    public string _type;    
    public Vehicle(int fuel, string type){
        _fuel = fuel;        
        _type = type;}
    public void Move(int km) {
        int howManyKm = km;        
        do{
            km--;
            _fuel--;
        }
        while(_fuel > 0 || km > 0);                           
        Console.WriteLine($"You drived a {_type} for {howManyKm} Kms and you have {_fuel} Ltrs of gas");
        }}

public class Car: Vehicle{
    private int _doors;
    public Car(int fuel, string type, int doors):base(fuel, type){
        _doors = doors;}    
}

public class Plane: Vehicle{
    private int _altitude;
    public Plane(int fuel, string type, int altitude):base(fuel, type){
        _altitude = altitude;}    
}
public class Program1{
    Car redCar = new Car(150, "Car",4);
    redCar.Move(100);
    Plane concorde = new Plane(5000, "Plane",2000);
    concorde.Move(1000)
}
/*         return _studentName + " - " + _topic;}
        public string GetStudentName(){
            return _studentName;}
        public string GetTopic(){
            return _topic;}
} */
