using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista11_PR2
{
    internal class Program
    {

        public static void Exercicio1()
        {
            int numero;
            int[] vet = new int[1000];
            Random random = new Random();

            bool numencontrado = true;
            for (int i = 0; i< 1000; i++)
            {
                vet[i] = random.Next(1, 1000);

            }
            do
            {
                Console.WriteLine("digite o numero que deseja encontrar:");
                numero = int.Parse(Console.ReadLine());

                for (int i = 0; i < 1000; i++)
                {
                    vet[i] = random.Next(1, 1000);
                    if (vet[i] == numero)
                    {
                        numencontrado = false;
                        Console.WriteLine("O numero digitado foi encontrado na posição {0}", i);
                        break;
                    }
                }
                if (numencontrado)
                    Console.WriteLine("o numero não foi encontrado no vetor.");

            } while (numencontrado);

        }
        public static void Exercicio2()
        {
           
            int[] vet = new int[2000];
            Random random = new Random();

            for (int i = 0;i < 2000; i++)
            {
                vet[i] = random.Next(1, 2000);
            }
            Console.WriteLine("Insira um nemero:");
            int n = int.Parse(Console.ReadLine());


            for(int i = 0; i < 2000; i++)
            {
                vet[i] = random.Next(1, 2000);
                if (vet[i] == n)
                {
                    Console.WriteLine("O numero digitado está na posição{0}", i);
                    n++;
                }
            }
            Console.WriteLine("O numero repete:"+ n );


        }
        public static void Exercicio3()
        {
            int[] vete = new int[10];
            int[] vets = new int[10];


            for (int i = 0; i < 10; i++) 
            {
                
                    Console.WriteLine("digite o elemento");
                    vete[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 10; i++)
            {
               if ( i % 2 == 0)
                {
                    vete[i] = i / 2;
                }

                else
                {
                    vete[i] = i / 3;
                }
            }

            Console.WriteLine("Vetor de Entrada");
            Console.WriteLine("Vetor de Saida ");



        }
        public static void Exercicio4()
        {
            
            int[] vet = new int[5000];
            Random random = new Random();
            for (int i = 0; i < 5000; i++)
            {
                vet[i] = random.Next(1, 5000);
            }
            for (int i = 0; i < 5000; i++)
            {
                
            }

        }
        static void Main(string[] args)
        {
            int exercicio;
            do
            {
                Console.WriteLine("======Menu======");
                Console.WriteLine("exercicio 1 - Digite1");
                Console.WriteLine("exercicio 2 - Digite2");
                Console.WriteLine("exercicio 3 - Digite3");
                Console.WriteLine("exercicio 4 - Digite4");
                Console.WriteLine("Digite 0 - caso queira sair:");

                exercicio = int.Parse(Console.ReadLine());

                switch (exercicio)
                {
                    case 0:
                        Console.WriteLine("Obrigada por utilizar este programa!!!");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    
                    ;
                    

                    default:
                        Console.WriteLine("Opção invalida:");
                        break;
                }
            } while (exercicio != 0);


        }
    }
}
