using System;

namespace VSCode
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Os exercícios serão executados na sequência
            Exercicio1();
            Exercicio2();
        }

        static void Exercicio1(){
            Livro[] lista = new Livro[10];
            Livro livro = new Livro();
            Livro pequeno = new Livro();
            Livro caro = new Livro();
            int menor = 10000;
            double maisCaro = 0;

            for(int i = 0; i<10; i++){
                Console.WriteLine("Qual o titulo do livro: ");
                livro.Titulo = Console.ReadLine();
                
                Console.WriteLine("Qual o número de páginas do livro: ");
                livro.numeroPag = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual o preço do livro: ");
                livro.precoLivro = Double.Parse(Console.ReadLine());

                lista[i]=livro;

                if(livro.numeroPag < menor){
                    pequeno = livro;
                    menor = livro.numeroPag;
                }
                if(livro.precoLivro > maisCaro){
                    caro = livro;
                    maisCaro = livro.precoLivro;
                }
            }

            Console.WriteLine("Livro com menos páginas:"+pequeno.Titulo+"; Número de Páginas: "+pequeno.numeroPag+"; Preço:"+pequeno.precoLivro+" reais");
            Console.WriteLine("");
            Console.WriteLine("Livro mais caro: "+caro.Titulo+"; Número de Páginas"+caro.numeroPag+"; Preço:"+caro.precoLivro+" reais");
        }

        static void Exercicio2(){
            Pessoa pessoa = new Pessoa();
            int escolha, count= 0;
            bool continuar=false;

            while(!continuar){
            Console.WriteLine("0. SAIR");

            Console.WriteLine("1. Cadastrar pessoas");

            Console.WriteLine("2. Mostrar aniversariante do mês");

            escolha = int.Parse(Console.ReadLine());

            switch(escolha){
                case 0:
                    continuar=true;
                    return;               
                case 1:

                    Console.WriteLine("Digite o nome da pessoa:");
                    pessoa.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o ano de nascimento");
                    pessoa.Ano = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o endereço");
                    pessoa.Endereco = Console.ReadLine();
                    Console.WriteLine("Digite o telefone");
                    pessoa.telefone = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o mes de nascimento");
                    pessoa.Mes = int.Parse(Console.ReadLine());

                    count ++;
                    break;                
                case 2:
                    int mes;
                    Console.WriteLine("Digite o mes");
                    mes = int.Parse(Console.ReadLine());
                    mostraAniversariantes(mes, pessoa);
                    break;
                default:
                    Console.WriteLine("Essa opção não existe");
                    break;
            }
        }
        }
        static void mostraAniversariantes(int mes, Pessoa pessoa){
                if(mes == pessoa.Mes){
                  Console.WriteLine(pessoa.Nome+" faz aniversário nesse mês e possui"+(2021-pessoa.Ano)+" anos de idade"); 
               }
        }
    }
}
