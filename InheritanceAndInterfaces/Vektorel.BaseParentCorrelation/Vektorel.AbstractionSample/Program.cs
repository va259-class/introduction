namespace Vektorel.AbstractionSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle();
            Console.WriteLine($"{r.KnownName} için alan : {r.GetArea()}");

            var c = new Circle();
            Console.WriteLine($"{c.KnownName} için alan : {c.GetArea()}");
        }
    }

    interface IPerimeter
    {
        public double GetPerimeter(); // Çevre
    }

    abstract class Shape
    {
        public string KnownName { get; set; }
        public abstract double GetArea();
    }

    sealed class Rectangle : Shape, IPerimeter
    {
        public Rectangle()
        {
            KnownName = "Dikdörtgen";
        }
        public double LongEdge { get; set; }
        public double ShortEdge { get; set; }

        public override double GetArea()
        {
            return LongEdge * ShortEdge;
        }

        public double GetPerimeter()
        {
            return 2 * (LongEdge + ShortEdge);
        }
    }

    class Square : Shape
    {
        public Square()
        {
            KnownName = "Kare";
        }

        public double Edge { get; set; }

        public override double GetArea()
        {
            return Math.Pow(Edge, 2);
        }
    }

    sealed class Circle : Shape
    {
        public Circle()
        {
            KnownName = "Çember";
        }

        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

}
