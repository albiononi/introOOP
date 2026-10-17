namespace introOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa ett objekt med radie 5 och beräkna arean
            Circle circle1 = new Circle(5);
            Console.WriteLine($"Arean för en cirkel med radie 5 är: {circle1.GetArea()}");

            // Skapa ett objekt med radie 6 och beräkna arean
            Circle circle2 = new Circle(6);
            Console.WriteLine($"Arean för en cirkel med radie 6 är: {circle2.GetArea()}");
        }
    }

    // Klassen Circle
    public class Circle
    {
        // De två variablerna som behövs
        public float _pi = 3.141f;
        public int _radius;

        // Konstruktor som tar emot radien när objektet skapas
        public Circle(int radius)
        {
            _radius = radius;
        }

        // Metod som räknar ut och returnerar arean
        public float GetArea()
        {
            return _radius * _radius * _pi;
        }
    }
}