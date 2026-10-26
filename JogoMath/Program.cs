//dotnet new console -n DesafioMatematica
class Progam
{

    static void Main()
    {
        List<string> listaHistorico = new List<string>();

        while (true)
        {
            Console.WriteLine("Bem vindo ao Jogo da Matemática");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Random ");
            Console.WriteLine("6 - Histórico de Jogos");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha o tipo de exercicío: ");


            string escolha = Console.ReadLine();

            if (escolha == "0")
            {
                Console.WriteLine("Jogo encerrado");
                return;
            }

            if (escolha == "1")
            {

                string resultadoDoJogo = Soma.Executar();
                listaHistorico.Add(resultadoDoJogo);
                Console.WriteLine("Jogo salvo no histórico");

            }

            else if (escolha == "2")
            {
                {
                    string resultadoDoJogo = Subtracao.Executar();
                    listaHistorico.Add(resultadoDoJogo);
                    Console.WriteLine("Jogo salvo no histórico");
                }
            }


            else if (escolha == "3")
            {
                {
                    string resultadoDoJogo = Divisao.Executar();
                    listaHistorico.Add(resultadoDoJogo);
                    Console.WriteLine("Jogo salvo no histórico");
                }
            }

            else if (escolha == "4")
            {
                {
                    string resultadoDoJogo = Multiplicacao.Executar();
                    listaHistorico.Add(resultadoDoJogo);
                    Console.WriteLine("Jogo salvo no histórico");
                }
            }

            else if (escolha == "5")
            {
                Random gerador = new Random();
                int jogoSorteado = gerador.Next(1, 5);

                string resultadoDoJogo = "";

                if (jogoSorteado == 1)
                    resultadoDoJogo = Soma.Executar();
                else if (jogoSorteado == 2)
                    resultadoDoJogo = Subtracao.Executar();
                else if (jogoSorteado == 3)
                    resultadoDoJogo = Divisao.Executar();
                else if (jogoSorteado == 4)
                    resultadoDoJogo = Multiplicacao.Executar();

                listaHistorico.Add(resultadoDoJogo);
                Console.WriteLine("Jogo salvo no histórico");
            }

            else if (escolha == "6")
            {
                Console.WriteLine("Ultimos Jogos");

                if (listaHistorico.Count == 0)
                {
                    Console.WriteLine("Nenhum jogo foi realizado.");
                }

                else
                {
                    foreach (string jogoSalvo in listaHistorico)
                    {
                        Console.WriteLine(jogoSalvo);
                    }
                }
            }

            else
            {
                Console.WriteLine("Essa opção não existe");
            }
        }
    }
}





