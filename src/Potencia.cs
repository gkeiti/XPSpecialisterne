namespace Dinamica
{
    public class Potencia
    {
        public static void CalculaPotencia()
        {
            Console.Clear();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite um número:");
                double numero = double.Parse(Console.ReadLine());

                string resposta = "";

                double calculoPotencia = 0;

                if (numero % 2 == 0)
                {
                    calculoPotencia = Math.Pow(numero, 2);
                    resposta = $"{numero} é um número par e seu quadrado é {calculoPotencia} (pois {numero}^2 = {calculoPotencia})";
                }
                else
                {
                    calculoPotencia = Math.Pow(numero, 3);
                    resposta = $"{numero} é um número ímpar e seu cubo é {calculoPotencia} (pois {numero}^3 = {calculoPotencia})";

                }

                Console.WriteLine(resposta);

                Console.WriteLine("Deseja continuar? 1 para sim; enter para sair");
                continuar = Console.ReadLine() == "1";
                Console.WriteLine();
            }
        }
    }
}
