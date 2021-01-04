using System;

namespace Equation_second_degré
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Title ="Resolution d'une Equation de Second Degré dans R";

                Console.WriteLine("Résolution d'une équation de la forme Ax² + Bx + C = 0");
                Console.WriteLine();
                Console.Write("Entrez la valeur de A : ");
                var A = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Entrez la valeur de B : ");
                var B = Convert.ToDouble(Console.ReadLine());
            
                Console.Write("Entrez la valeur de C : ");
                var C = Convert.ToDouble(Console.ReadLine());

                if (A == 0 && B == 0 && C == 0)
                {
                    Console.WriteLine("Sr = R\nCar les valeurs de A, B et C sont nulles");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("---Calcul du Discriminant delta---");
                    double disc = (B * B) - (4 * A * C);
                    Console.WriteLine("delta = b²-4ac");
                    Console.WriteLine("delta = ({0})² - 4 x {1} x {2}", B, A, C);
                    Console.WriteLine("delta = {0} - 4 x {1}", B*B, A*C);
                    Console.WriteLine("delta = {0} - {1}", B*B, 4*A*C);
                    Console.WriteLine("delta = {0}", disc);

                    Console.WriteLine();

                    if (disc < 0)
                    {
                        Console.WriteLine("delta < 0 donc\n Sr = Ø");
                    }
                    else if (disc == 0)
                    {
                        Console.WriteLine("delta = 0, il existe donc une unique solution X1 ");

                        var x1 = -B / 2 * A;
                        Console.WriteLine("X1 = (-b) / 2a");
                        Console.WriteLine("X1 = ({0}) / 2 x {1}", -B, A);
                        Console.WriteLine("X1 = {0} / {1}", -B, 2*A);
                        Console.WriteLine("X1 = {}", x1);
                        Console.WriteLine("\tSr = {}", x1);
                        Console.WriteLine("La forme factorisée de cette équation est : P(x) = {0}(x + ({1}))", A, x1 * x1);
                    }
                    else
                    {
                        Console.WriteLine("delta > 0, il existe donc deux solutions X1 et X2");
                        var racDisc = Math.Sqrt(disc);
                        var x1 = (-B + racDisc) / 2 * A;
                        var x2 = (-B - racDisc) / 2 * A;

                        Console.WriteLine("X1 = (-B - sqrt(delta) / 2 x A\t\t X2 = (-B + sqrt(delta) / 2 x A");
                        Console.WriteLine("X1 = ({0} - sqrt({1})) / 2 x {2}\t\t X2 = ({0} + sqrt({1})) / 2 x {2}", -B, disc, A);
                        Console.WriteLine("X1 = {0} / {1}\t\t\t\t X2 = {2} / {1}", -B - racDisc, 2*A, -B + racDisc);
                        Console.WriteLine("X1 = {0}\t\t\t\t\t X2 = {1}", x1, x2);
                        Console.WriteLine("\t\tSr = [{0} ; {1}]", x1, x2);
                        Console.WriteLine("La forme factorisée de cette équation est : P(x) = {0}(x - ({1}))(x - ({2}))", A, x1, x2);
                    }
                }


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
