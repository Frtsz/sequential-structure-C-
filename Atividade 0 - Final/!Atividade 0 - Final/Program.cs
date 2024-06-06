using System.Data;

namespace _Atividade_0___Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repetir = "S";
            while (repetir == "S" ^ repetir == "s")
            {
                Console.Clear();
                Console.WriteLine("._____________________.");
                Console.WriteLine("|-----ATIVIDADE 0-----|");
                Console.WriteLine("|_____________________|");
                Console.WriteLine("|      1_Terreno      |");
                Console.WriteLine("|     2_Retângulo     |");
                Console.WriteLine("|      3_Idades       |");
                Console.WriteLine("|       4_Soma        |");
                Console.WriteLine("|       5_Troco       |");
                Console.WriteLine("|      6_Circulo      |");
                Console.WriteLine("|     7_Pagamento     |");
                Console.WriteLine("|      8_Consumo      |");
                Console.WriteLine("|      9_Medidas      |");
                Console.WriteLine("|     10_Duração      |");
                Console.WriteLine("|_____________________|");
                Console.Write("     ---> ");
                int menu = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:

                        Console.Write("Digite a largura do terreno: ");
                        double larg = double.Parse(Console.ReadLine());
                        Console.Write("Digite a profundidade do terreno: ");
                        double prof = double.Parse(Console.ReadLine());
                        Console.Write("Digite o preço do m²: R$");
                        double val = double.Parse(Console.ReadLine());

                        double area = larg * prof;
                        double prec = area * val;

                        Console.WriteLine("Area do terreno: {0}M²", area);
                        Console.WriteLine("Valor do terreno: R${0}", prec);

                        break;

                    case 2:

                        Console.Write("Digite a base do retângulo: ");
                        double bas = double.Parse(Console.ReadLine());
                        Console.Write("Digite a altura do retângulo: ");
                        double alt = double.Parse(Console.ReadLine());

                        area = bas * alt;
                        double per = (bas * 2) + (alt * 2);
                        double diag = Math.Sqrt((bas * bas) + (alt * alt));
                        diag = Math.Round(diag, 4);

                        Console.WriteLine("Area do retângulo: {0}", area);
                        Console.WriteLine("Perímetro do retângulo: {0}", per);
                        Console.WriteLine("Diagonal do retângulo: {0},", diag);

                        break;

                    case 3:

                        Console.WriteLine("DADOS DA PRIMEIRA PESSOA:");
                        Console.Write("Nome: ");
                        string n1 = Console.ReadLine();
                        Console.Write("Idade: ");
                        double i1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("\nDADOS DA SEGUNDA PESSOA:");
                        Console.Write("Nome: ");
                        string n2 = Console.ReadLine();
                        Console.Write("Idade: ");
                        double i2 = double.Parse(Console.ReadLine());

                        double media = (i1 + i2) / 2;

                        Console.WriteLine("\nA média das idades de {0} e {1} é de {2}", n1, n2, media);

                        break;

                    case 4:

                        Console.Write("Digite o valor de X: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Digite o valor de Y: ");
                        double y = double.Parse(Console.ReadLine());
                        Console.WriteLine("----- {0} + {1} = {2} -----", x, y, (x + y));

                        break;

                    case 5:

                        Console.Write("Preço unitario do produto: R$");
                        double unit = double.Parse(Console.ReadLine());
                        Console.Write("Quantidade comprada: ");
                        double quant = double.Parse(Console.ReadLine());
                        Console.Write("Dinheiro recebido: R$");
                        double rece = double.Parse(Console.ReadLine());

                        double total = unit * quant;
                        double pagar = rece - total;

                        Console.WriteLine("Troco: R${0}", pagar);

                        break;

                    case 6:

                        Console.Write("Raio do círculo: ");
                        double raio = double.Parse(Console.ReadLine());

                        area = Math.PI * (raio * raio);
                        area = Math.Round(area, 3);
                        Console.WriteLine("Area do circulo: {0}", area);

                        break;

                    case 7:

                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Horas trabalhadas: ");
                        double horas = double.Parse(Console.ReadLine());
                        Console.Write("Valor por hora: ");
                        double valor = double.Parse(Console.ReadLine());


                        Console.WriteLine("O pagamento para {0} será de {1}", nome, (horas * valor));

                        break;

                    case 8:

                        Console.Write("Distância percorrida: ");
                        double dp = double.Parse(Console.ReadLine());
                        Console.Write("Combustivel gasto: ");
                        double cg = double.Parse(Console.ReadLine());
                        double cm = dp / cg;
                        cm = Math.Round(cm, 3);
                        Console.WriteLine("O consumo médio é de {0}", cm);

                        break;

                    case 9:

                        Console.Write("Medida de A: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Medida de B: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Medida de C: ");
                        double c = double.Parse(Console.ReadLine());

                        double quadrado = a * a;
                        quadrado = Math.Round(quadrado, 4);
                        double triangulo = (a * b) / 2;
                        triangulo = Math.Round(triangulo, 4);
                        double trapezio = ((a + b) * c) / 2;
                        trapezio = Math.Round(trapezio, 4);

                        Console.WriteLine("Area do quadrado: {0}\nArea do triângulo: {1}\nArea do trapézio: {2}", quadrado, triangulo, trapezio);

                        break;

                    case 10:

                        Console.Write("Digite a duraão em segundos: ");
                        double s1 = double.Parse(Console.ReadLine());

                        double hr = s1 / 3600;
                        hr = Math.Round(hr, 0);
                        double min = (s1 % 3600) / 60;
                        min = Math.Round(min, 0);
                        double sec = (s1 % 3600) % 60;

                        Console.WriteLine("{0}:{1}:{2}", hr, min, sec);

                        break;
                }

                Console.WriteLine("\n\nDeseja continuar o laço? (S/N)");
                repetir = Console.ReadLine();

                if(repetir == "N" ^ repetir == "n") { }
            }
        }
    }
}
