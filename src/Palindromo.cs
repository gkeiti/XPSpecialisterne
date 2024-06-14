namespace Dinamica
{
    public class Palindromo
    {
        public static void VerificaPalindromo()
        {
            Console.Clear();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Digite uma palavra:");
                string palavra = Console.ReadLine();
                string palavraLowcase = palavra.ToLower();

                bool isPalindromo = false;

                int length = palavra.Length;
                string resultado = "";

                for (int pos = 0; pos < length / 2; pos++)
                {
                    var letraEsquerdaDireita = palavraLowcase.Substring(pos, 1);
                    var letraDireitaEsquerda = palavraLowcase.Substring(length - pos - 1, 1);

                    if (letraEsquerdaDireita == letraDireitaEsquerda)
                        isPalindromo = true;
                    else
                    {
                        isPalindromo = false;
                        break;
                    }
                }

                if (isPalindromo)
                {
                    resultado = $"{palavra} é palíndromo";
                }
                else
                {
                    resultado = $"{palavra} não é palíndromo";
                }

                Console.WriteLine(resultado);

                Console.WriteLine("Deseja continuar? 1 para sim; enter para sair");
                continuar = Console.ReadLine() == "1";
                Console.WriteLine();
            }
        }
    }
}
