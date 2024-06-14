namespace Dinamica
{
    public class Retangulo
    {
        public static void CalculaAreaRetangulo()
        {
            Console.Clear();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite a base:");
                double baseRet = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a altura:");
                double altRet = double.Parse(Console.ReadLine());

                double areaRet = baseRet * altRet;

                Console.WriteLine($"A área de um retângulo com base { baseRet } e altura { altRet } é { areaRet }");

                Console.WriteLine("Deseja continuar? 1 para sim; enter para sair");
                continuar = Console.ReadLine() == "1";
                Console.WriteLine();
            }
        }
    }
}
