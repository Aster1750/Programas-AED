using System;

namespace VSCode
{
    public class Jogos
    {
        public string titulo;
        public string estilo;

        public int codigo;
        public double preco;

        public static void Listar(Jogos[] jogos, int n){
            for(int i=0; i<n; i++){
                Console.WriteLine(jogos[i].titulo);
            }           
        }

        public static void BuscaTitulo(Jogos[] jogos, int n){
            string titulo;

            Console.WriteLine("Digite o tíulo do jogo:");
            titulo = Console.ReadLine();
            bool existe=false;

            for(int i=0; i<n; i++){
                if(titulo == jogos[i].titulo){
                    existe=true;
                    Console.WriteLine(jogos[i].titulo);
                    Console.WriteLine(jogos[i].estilo);
                    Console.WriteLine(jogos[i].codigo);
                    Console.WriteLine(jogos[i].preco);        
                }
                Console.WriteLine(jogos[i].titulo);
            } 

            if(existe==false){
                Console.WriteLine("O jogo não existe");
            }          
        }

        public static void BuscaEstilo(Jogos[] jogos, int n){
            string estilo;

            Console.WriteLine("Digite o estilo que deseja buscar:");
            estilo = Console.ReadLine();
            bool existe=false;

            for(int i=0; i<n; i++){
                if(estilo == jogos[i].estilo){
                    existe=true;
                    Console.WriteLine(jogos[i].titulo);
                    Console.WriteLine(jogos[i].estilo);
                    Console.WriteLine(jogos[i].codigo);
                    Console.WriteLine(jogos[i].preco);        
                }
                Console.WriteLine(jogos[i].titulo);
            } 

            if(existe==false){
                Console.WriteLine("O estilo não existe");
            }          
        }

        public static void Media(Jogos[] jogos, int n){
            double soma=0;
            for(int i=0; i<n; i++){
               soma = soma + jogos[i].preco;         
            }
            Console.WriteLine("A média é: "+(soma/n)); 
        }
    }
}
