namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os comprimentos dos lados do triângulo:");
            Console.Write("Lado X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado Z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            string tipoTriangulo = VerificarTriangulo(x, y, z);
            Console.WriteLine(tipoTriangulo);
            Console.ReadLine();
        }

        static string VerificarTriangulo(double x, double y, double z)
        {
            if (x + y > z && x + z > y && y + z > x)
            {
                if (x == y && x == z && y == z)
                {
                    return "É um triângulo equilátero.";
                }
                else if (x == y || x == z || y == z)
                {
                    return "É um triângulo isósceles.";
                }
                else
                {
                    return "É um triângulo escaleno.";
                }
            }
            else
            {
                return "Não é possível formar um triângulo com esses comprimentos.";
            }


        }

    }
}