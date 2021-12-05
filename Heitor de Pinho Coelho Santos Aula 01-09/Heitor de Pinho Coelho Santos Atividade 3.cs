using System;
					
public class Program
{
	public static void Main()
	{
		int codigoEstado, peso, codigoCarga;
		Console.WriteLine("digite o codigo do estado");
		codigoEstado = int.Parse(Console.ReadLine());
		Console.WriteLine("digite o peso da carga em toneladas");
		peso = int.Parse(Console.ReadLine());
		Console.WriteLine("digite o codigo da carga");
		codigoCarga = int.Parse(Console.ReadLine());

		
		Console.WriteLine("O peso da carga em quilos é "+peso*1000);
		
		if (codigoCarga >=10 && codigoCarga <= 20){
			
			Console.WriteLine("O preço total sem imposto é: "+peso*1000000*100+" reais");
			
			switch (codigoEstado)
			{
				case 1:
					Console.WriteLine("o imposto é de 35%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*100)*1.35+" reais");
					break;
				case 2:
					Console.WriteLine("o imposto é de 25%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*100)*1.25+" reais");
					break;
				case 3:
					Console.WriteLine("o imposto é de 15%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*100)*1.15+" reais");
					break;
				case 4:
					Console.WriteLine("o imposto é de 5%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*100)*1.05+" reais");
					break;
				case 5:
					Console.WriteLine("o imposto é de 0%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*100)+" reais");
					break;	

				default:
					Console.WriteLine("Codigo incorreto");
					break;
			}
		} else if(codigoCarga >=21 && codigoCarga <= 30){

			Console.WriteLine("O preço total sem imposto é: "+peso*1000000*250+" reais");
			
			switch (codigoEstado)
			{
				case 1:
					Console.WriteLine("o imposto é de 35%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*250)*1.35+" reais");
					break;
				case 2:
					Console.WriteLine("o imposto é de 25%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*250)*1.25+" reais");
					break;
				case 3:
					Console.WriteLine("o imposto é de 15%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*250)*1.15+" reais");
					break;
				case 4:
					Console.WriteLine("o imposto é de 5%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*250)*1.05+" reais");
					break;
				case 5:
					Console.WriteLine("o imposto é de 0%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*250)+" reais");
					break;	

				default:
					Console.WriteLine("Codigo incorreto");
					break;
			}
		} else if(codigoCarga >= 31 && codigoCarga <= 40){
			
			Console.WriteLine("O preço total sem imposto é: "+peso*1000000*340+" reais");
			
			switch (codigoEstado)
			{
				case 1:
					Console.WriteLine("o imposto é de 35%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*340)*1.35+" reais");
					break;
				case 2:
					Console.WriteLine("o imposto é de 25%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*340)*1.25+" reais");
					break;
				case 3:
					Console.WriteLine("o imposto é de 15%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*340)*1.15+" reais");
					break;
				case 4:
					Console.WriteLine("o imposto é de 5%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*340)*1.05+" reais");
					break;
				case 5:
					Console.WriteLine("o imposto é de 0%");
					Console.WriteLine("O preço total com imposto é: "+(peso*1000000*340)+" reais");
					break;	

				default:
					Console.WriteLine("Codigo incorreto");
					break;
			}
		}  
	}
}