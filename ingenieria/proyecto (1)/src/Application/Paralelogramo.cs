namespace Application;

public class Paralelogramo
{
    public static double Perimetro(double A , double B)
    {
        double perimetro = 2*A+B;
        return perimetro;
    }
    public static double Area(double base1, double centro)
    {
        double area = base1 * centro;
        return area;
    }
}