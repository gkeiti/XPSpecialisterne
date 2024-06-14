namespace Dinamica
{
    public class IdadeEmDias
    {
        public static void CalculaIdadeEmDias()
        {
            Console.Clear();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite o dia do nascimento");
                int diaNasc = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o mês do nascimento");
                int mesNasc = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o ano do nascimento:");
                int anoNasc = int.Parse(Console.ReadLine());

                DateTime dataNascimento = new DateTime(anoNasc, mesNasc, diaNasc);

                var idadeEmDias = (DateTime.Now - dataNascimento).Days;

                Console.WriteLine($"A idade em dias de uma pessoa que nasceu em {dataNascimento.ToString("dd/MM/yyyy")} é {idadeEmDias}");

                Console.WriteLine("Deseja continuar? 1 para sim; enter para sair");
                continuar = Console.ReadLine() == "1";
                Console.WriteLine();
            }
        }
    }
}
