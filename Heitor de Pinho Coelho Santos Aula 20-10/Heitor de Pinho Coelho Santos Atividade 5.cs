using System;

public class Program
{
	public static int crescente(int[] vet){
		int crescente = 0;
		for(int i = 0; i<7; i++){
			if((vet[i]+1) == vet[i+1]){
				crescente = 1;
			} else{
				crescente = 0;
				return crescente;
			}
		}
		return crescente;
	}
    public static void Main()
    {
        Random rnd = new Random();
		int[] vet = new int[8];
		
		Console.WriteLine("Vetor Completo:");
		
		for(int i = 0; i<8; i++){
			vet[i] = rnd.Next(1, 9);
			Console.WriteLine(vet[i]);
		}
		
		Console.WriteLine("O valor retornado é: "+ crescente(vet));
    }
}