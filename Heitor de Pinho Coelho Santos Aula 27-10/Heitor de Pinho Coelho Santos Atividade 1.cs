using System;
					
public class Program
{
	public static void Main()
	{   
		int nota1, nota2, nota3;            

		Console.WriteLine("Digite as três notas na sequência");
		nota1 = int.Parse(Console.ReadLine());  
		nota2 = int.Parse(Console.ReadLine());
		nota3 = int.Parse(Console.ReadLine());

		char AP;

		Console.WriteLine("Digite A para média Aritmética e P para média Ponderada");
		AP = Char.Parse(Console.ReadLine());
	    
		switch(AP){
			case 'A':
					int ma = (nota1 + nota2 + nota3)/3;
					Console.WriteLine("A média Aritmética é: "+ma);
				break;
			case 'P':
					int mp = (nota1*5 + nota2*3 + nota3*2)/10;
					Console.WriteLine("A média ponderada é: "+mp);
				break;
			default:
				Console.WriteLine("Inválido");
				break;
		}   

	}
}