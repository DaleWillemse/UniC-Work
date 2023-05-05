class Vehicle  // base class  
{
    public string brand = "Ford";  // Vehicle field

}

class Car : Vehicle  // derived class
{
    public string modelName = "Mustang";
    public void hoot()             // Vehicle method 
    {
        Console.WriteLine("Beep beep.");
    }
}

class Plane : Vehicle
{
    public string modelName = "Tri-Motor";
    public void rotor()
    {
        Console.WriteLine("RrrRrrr");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.hoot();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);

        Plane myPlane = new Plane();
        myPlane.rotor();
        Console.WriteLine(myPlane.modelName);

    }
}