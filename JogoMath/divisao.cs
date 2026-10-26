public class Divisao
{
    public static string Executar()
    {
        Random gerador = new Random();
        int acertos = 0;

        {
            for (int i = 1; i <= 5; i++)
            {
                int numero1;
                int numero2;
                do
                {
                    numero1 = gerador.Next(0, 101);
                    numero2 = gerador.Next(0, 101);
                }


                while (numero2 == 0 || numero1 % numero2 != 0);





                    Console.WriteLine($"Rodada número {i}: {numero1} / {numero2} = ");

                int resultado = int.Parse(Console.ReadLine()!);
                {
                    if (resultado == numero1 / numero2)
                    {
                        Console.WriteLine("Certoo!");
                        acertos++;
                    }
                    else Console.WriteLine("Errou!");
                }




            }
            string resumoDoJogo = $"Jogo de Divisão -> Acertou {acertos} de 5 perguntas.";
            return resumoDoJogo;
        }
    }
}