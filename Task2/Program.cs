public class Circle
{
    public const double PI = 3.14;
}

class Program
{
    static void Main(string[] args)
    {
        //Circle.PI = 3.14;
    }

}
//PI is a const, so its value is fixed at compile time and cannot be changed.
//Assigning to Circle.PI is not allowed, so the program will not compile.