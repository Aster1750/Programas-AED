using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		int num=0, soma=0, quant=0, maior=num, menor=0, quantImpar=0;
		do{
			Console.WriteLine("Digite um número(30000 para encerrar)");
			num = int.Parse(Console.ReadLine());
			if(quant == 0){
			 menor = num;
			}
			if(num != 30000){
				quant++;
				soma = soma + num;
				if(num > maior){
				 maior = num;
				}
				if(num < menor){
					menor = num;
				}
				if(num%2 != 0){
				quantImpar++;
				}
			}
		} while(num != 30000);
		
		Console.WriteLine("A soma é "+soma);
		Console.WriteLine("A quantidade de números digitados é "+quant);
		Console.WriteLine("A média é "+(soma/quant));
		Console.WriteLine("O maior número é "+maior);
		Console.WriteLine("O menor número é "+menor);
		Console.WriteLine("A quantidade de ímpares é "+(quantImpar*100/quant)+"% dos números");
	}	
}