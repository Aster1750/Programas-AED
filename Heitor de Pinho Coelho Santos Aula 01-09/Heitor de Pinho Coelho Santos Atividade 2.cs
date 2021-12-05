using System;
					
public class Program
{
	public static void Main()
	{
		int codigoProduto, peso, codigoPais;
		Console.WriteLine("digite o codigo do produto comprado");
		codigoProduto = int.Parse(Console.ReadLine());
		Console.WriteLine("digite o peso da carga em quilos");
		peso = int.Parse(Console.ReadLine());
		Console.WriteLine("digite o codigo do país de origem");
		codigoPais = int.Parse(Console.ReadLine());

		
		Console.WriteLine("O peso da carga em gramas é "+peso*1000);
		
		if (codigoProduto <= 4 && codigoProduto < 0){
			
			Console.WriteLine("O preço total sem imposto é: "+peso*1000*10+" reais");
			
			switch (codigoPais)
			{
				case 1:
					Console.WriteLine("o imposto é de 0%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*10)*1.0+" reais");
					break;

				case 2:
					Console.WriteLine("o imposto é de 15%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*10)*1.15+" reais");
					break;

				case 3:
					Console.WriteLine("o imposto é de 25%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*10)*1.25+" reais");
					break;

				default:
					Console.WriteLine("Codigo do país incorreto");
					break;
			}
		} else if(codigoProduto >= 5 && codigoProduto <=7){
			
			Console.WriteLine("O preço total sem imposto é: "+peso*1000*25+" reais");
			
			switch (codigoPais)
			{
				case 1:
					Console.WriteLine("o imposto é de 0%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*25)*1.0+" reais");
					break;

				case 2:
					Console.WriteLine("o imposto é de 15%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*25)*1.15+" reais");
					break;

				case 3:
					Console.WriteLine("o imposto é de 25%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*25)*1.25+" reais");
					break;

				default:
					Console.WriteLine("Codigo do país incorreto");
					break;
			}
		} else if(codigoProduto >= 8 && codigoProduto <=10){
			
			Console.WriteLine("O preço total sem imposto é: "+peso*1000*35+" reais");
			
			switch (codigoPais)
			{
				case 1:
					Console.WriteLine("o imposto é de 0%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*35)*1.0+" reais");
					break;

				case 2:
					Console.WriteLine("o imposto é de 15%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*35)*1.15+" reais");
					break;

				case 3:
					Console.WriteLine("o imposto é de 25%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000*35)*1.25+" reais");
					break;

				default:
					Console.WriteLine("Codigo do país incorreto");
					break;
			}
		}  
	}
}