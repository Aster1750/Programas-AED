using System;
					
public class Program
{
	public static void Main()
	{
	    int[] n_conta = new int [15];
		string[] nome_cliente = new string[15];
		double[] saldo = new double[15];
		int menu;
		double menorSaldo;
		string nomeCliente;

		Console.WriteLine("1 – Cadastrar contas");
		Console.WriteLine("2 – Visualizar todas as contas de um determinado cliente");
		Console.WriteLine("3 – Encontrar a conta com menor saldo e excluir esta conta");
		Console.WriteLine("Qual a opcao desejada: ");
		menu = int.Parse(Console.ReadLine());

		if(menu == 1){
			for(int i = 0; i<15; i++){
				Console.WriteLine("Qual o numero da conta: ");
				n_conta[i] = int.Parse(Console.ReadLine());
				Console.WriteLine("Qual o nome do cliente: ");
				nome_cliente[i] = Console.ReadLine();
				Console.WriteLine("Qual o  saldo: ");
				saldo[i] = Double.Parse(Console.ReadLine());
			}
		}
		if(menu == 2){
			Console.WriteLine("Qual o numero da conta: ");
			nomeCliente = Console.ReadLine();
			for(int i = 0; i<15; i++){
				if(nome_cliente[i]==nomeCliente){
					Console.WriteLine("Numero da conta: "+ n_conta[i]);
					Console.WriteLine("Nome do cliente: "+ nome_cliente[i]);
					Console.WriteLine("Saldo: "+ saldo[i]);
				}
			}
		}

		if(menu == 3){
			menorSaldo = saldo[0];
			for(int i = 0; i<15; i++){
				if(saldo[i]<menorSaldo){
					menorSaldo = saldo[i];
				}
			}
			for(int i = 0; i<15; i++){
				if(menorSaldo<saldo[i]){
					n_conta[i]=0;
					nome_cliente[i]=" ";
					saldo[i] = 0;
				}
			}
		}
	}
}