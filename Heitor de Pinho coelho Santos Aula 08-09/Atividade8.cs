using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		int n1=0, n2=1 ,n3 ,num;    
		
        Console.WriteLine("Digite o número de elementos: ");    
        num = int.Parse(Console.ReadLine());  
		
        Console.WriteLine(n1);   
		Console.WriteLine(n2);
		
        for(int i=2; i<num; i++){    
			n3=n1+n2;    
			Console.WriteLine(n3+" ");    
			n1=n2;    
			n2=n3;    
        }    
	}	
}