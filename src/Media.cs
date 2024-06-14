namespace Dinamica
{
    public class Media
    {
        public static void CalculaMedia()
        {
            Console.Clear();
            bool continuar = true;

            while (continuar)
            {

                Console.WriteLine("Digite a primeira nota:");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota:");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota:");
                double c = double.Parse(Console.ReadLine());

                double media = (a + b + c) / 3;

                string status = "";

                if (media >= 7)
                {
                    status = "Aprovado";
                }
                else
                {
                    if (media >= 5 && media < 7)
                    {
                        status = "Recuperação";
                    }
                    else
                    {
                        if (media < 5)
                            status = "Reprovado";
                    }
                }

                Console.WriteLine($"Média: {media}; {status}.");

                Console.WriteLine("Deseja continuar? 1 para sim; enter para sair");
                continuar = Console.ReadLine() == "1";
                Console.WriteLine();
            }
        }
    }
}
