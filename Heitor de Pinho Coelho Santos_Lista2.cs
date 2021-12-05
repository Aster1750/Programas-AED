using System;
					
public class Program
{
	public static void Main()
    {   
        int numero_de_acoes;            

        Console.WriteLine("Qual a quantidade de registros:");
        numero_de_acoes = int.Parse(Console.ReadLine());  

        int[] valor = new int[numero_de_acoes];
        int[] quantidade = new int[numero_de_acoes];
        string[] nome = new string[numero_de_acoes];              

        int escolha, valorAcao, quantidadeAcao;
        string nomeAcao;
        bool continuar=false;       

        while(!continuar){
            Console.WriteLine("1. Adicionar Ação, seu valor e quantidade");

            Console.WriteLine("2. Modificar ação da ação e quantidade");

            Console.WriteLine("3. Listar Ações valores e valor total");

            Console.WriteLine("4. Pesquisar Ações");

            Console.WriteLine("5. Sair");


            escolha = int.Parse(Console.ReadLine());

            switch(escolha){
                case 1:
                    Adicionar(valor, quantidade, nome, numero_de_acoes);
                    break;                
                case 2:
                    Console.WriteLine("Modifique a quantidade e valor das ações");
                    Console.WriteLine("Qual o nome da ação que voce deseja modificar:");
                    nomeAcao = Console.ReadLine();
                    Console.WriteLine("Qual o novo valor da ação:");
                    valorAcao = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a nova quantidade da ação:");
                    quantidadeAcao = int.Parse(Console.ReadLine());
                    Modificar(nome, nomeAcao, valor, quantidade, valorAcao, quantidadeAcao, numero_de_acoes);
                    break;
                case 3:
                    Listar(valor, quantidade, nome, numero_de_acoes);
                    break;
                case 4:
                    Console.WriteLine("Pesquisa de ações");
                    Console.WriteLine("Qual o nome da ação que voce deseja procurar:");
                    nomeAcao = Console.ReadLine();
                    Pesquisar(nome, nomeAcao, numero_de_acoes);
                    break;
                case 5:
                    continuar = true;
                    break;
                default:
                    Console.Write("Essa opção não existe");
                    break;
            }
        }
        
    }
    static void Adicionar(int[] vet1, int[] vet2, string[] vet3, int a){
        for(int i = 0; i<a; i++){
            Console.WriteLine("Qual o nome da ação:");
            vet3[i] = Console.ReadLine();
            Console.WriteLine("Qual o valor da ação?");
            vet1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de ações?");
            vet2[i] = int.Parse(Console.ReadLine());
        }
        
    }

    static void Pesquisar(string[] vet3, string busca, int a){
        for(int i = 0; i<a; i++){
            if(vet3[i] == busca){
                Console.WriteLine("ação encontrada");
            }
        }
        
    }

    static void Modificar(string[] vet1, string busca, int[] vet2, int[] vet3, int valor1, int valor2, int a){
        for(int i = 0; i<a; i++){
            if(vet1[i] == busca){
                vet2[i] = valor1;
                vet3[i] = valor2;
            }
        }            
    }

    static void Listar(int[] valor_Acao, int[] quant_Acao, string[] nome_Acao, int a){
        for(int i = 0; i<a; i++){
            int total;
            Console.WriteLine("Nome da ação " + nome_Acao[i] + " valor da ação " + valor_Acao + " quantidade de ação " + quant_Acao);
            total = valor_Acao[i] * quant_Acao[i];
            Console.WriteLine("Valor total das ações: " + total);
        }
        
    }
}