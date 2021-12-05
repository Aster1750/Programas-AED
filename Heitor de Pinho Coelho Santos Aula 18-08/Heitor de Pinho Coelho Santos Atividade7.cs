using System;
					
public class Program
{
	public static void Main()
	{
		double sanduiche, queijo, presunto, carne;
		Console.WriteLine("Digite o valor de saduiches que quer fazer: ");
		
		sanduiche = Convert.ToDouble(Console.ReadLine());
		
		queijo = sanduiche*50;
		
		presunto = sanduiche*50;
		
		carne = sanduiche*100;
				
		Console.WriteLine("peso dos itens: "+ queijo/1000 +" quilos de queijo, "+presunto/1000+" quilos de presunto, "+carne/1000+" quilos de carne.");
	}
}