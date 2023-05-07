
class Polymorphism
{

    public class Shapes
    {
        public int width { get; set; }
        public int height { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }
    }

    public class Circle : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Square : Shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }


    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Draw();

        Shapes shape = new Shapes();
        shape.Draw();
    }
}