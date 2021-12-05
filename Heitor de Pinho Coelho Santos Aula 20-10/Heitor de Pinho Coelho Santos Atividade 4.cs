using System;

public class Program
{
	public static int achaMenor(int[] vet){
		int menor = vet[1];

		for(int i = 0; i<10; i++){
			if(menor>vet[i]){
				menor = vet[i];
			}
		}
		return menor;
	}
    public static void Main()
    {
        Random rnd = new Random();
		int[] vet = new int[10];
		
		Console.WriteLine("Vetor Completo:");
		
		for(int i = 0; i<10; i++){
			vet[i] = rnd.Next(0, 99);
			Console.WriteLine(vet[i]);
		}
		
		Console.WriteLine("O menor termo é: "+ achaMenor(vet));
    }
}