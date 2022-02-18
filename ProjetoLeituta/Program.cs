using System;

namespace ProjetoLeituta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de comandos que ira dar para o recruta!");
            string NUMEROS = Console.ReadLine();
            int NUMEROS1 = Convert.ToInt32(NUMEROS);
            Console.WriteLine("Para o soldado virar para direita digite 'D' e para virar para esquerda digite 'E'!!!");
            string comandos = Console.ReadLine();
            char[] comandosa = comandos.ToCharArray();

            Console.WriteLine("Lembre-se a direção inicial é para o norte, escreva 'Norte' para confirmar!!");
            string direcaoinicial = Console.ReadLine();
            Console.WriteLine("Aperte alguma tecla para iniciar!!");
            Console.ReadKey();


            if (NUMEROS1 >= 1 && NUMEROS1 <= 100)
            {
                if (direcaoinicial == "Norte")
                {
                    for (int i = 0; i < comandosa.Length; i++)
                    {
                        if (comandosa[i] == 'D')
                        {
                            if (direcaoinicial == "Norte")
                            {
                                direcaoinicial = "Leste";

                            }
                            else if (direcaoinicial == "Leste")
                            {
                                direcaoinicial = "Sul";
                            }
                            else if (direcaoinicial == "Sul")
                            {
                                direcaoinicial = "Oeste";
                            }
                            else if (direcaoinicial == "Oeste")
                            {
                                direcaoinicial = "Norte";
                            }
                        }
                        if (comandosa[i] == 'E')
                        {
                            if (direcaoinicial == "Norte")
                            {
                                direcaoinicial = "Oeste";
                            }
                            else if (direcaoinicial == "Oeste")
                            {
                                direcaoinicial = "Sul";
                            }
                            else if (direcaoinicial == "Sul")
                            {
                                direcaoinicial = "Leste";
                            }
                            else if (direcaoinicial == "Leste")
                            {
                                direcaoinicial = "Norte";
                            }
                        }
                    }
                }

                Console.WriteLine("A direção final do recruta é!!!");
                Console.WriteLine(direcaoinicial);

                Console.ReadKey();






            }







        }
    }
}
