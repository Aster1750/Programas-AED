using System;
					
public class Program
{
	public static void Main()
	{
		double horas, minutos, segundos;
		Console.WriteLine("Digite o tempo do show em segundos: ");
		
		segundos = Convert.ToInt32(Console.ReadLine());
		
		minutos = segundos/60;
		
		horas = minutos/60;
				
		Console.WriteLine("Horas:"+horas);
		
		Console.WriteLine("Minutos:"+minutos);
		
		Console.Write("segundos:"+segundos);
		
	}
}