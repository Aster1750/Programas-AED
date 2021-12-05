using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Heitor de Pinho Coelho Santos");
		
		int idade, peso, altura, mediaIdade=0, mediaAltura=0, menorIdade=0, quilo80=0;
		
		for(int i=0; i<5; i++){
			Console.WriteLine("Time"+(i+1));
			for(int j=0; j<11;j++){
				Console.WriteLine("Jogador "+(j+1)+" do time "+i+1);
				Console.WriteLine("digite sua idade");
				idade = int.Parse(Console.ReadLine());
				
				Console.WriteLine("digite seu peso");
				peso = int.Parse(Console.ReadLine());
				
				Console.WriteLine("digite sua altura");
				altura = int.Parse(Console.ReadLine());
			
				mediaIdade = mediaIdade+idade;
				mediaAltura = mediaAltura+altura;
				
				if(idade < 18){
					menorIdade++;
				}
				if(peso > 80){
					quilo80++;
				}
			}
			Console.WriteLine("A média de idade do time "+i+" é:"+mediaIdade);
			mediaIdade = 0;
		}
		Console.WriteLine("A quantidade de jogadores com idade inferior a 18 anos é :"+menorIdade);
		Console.WriteLine("A media da altura de todos os jogadores é"+(mediaAltura/55));
		Console.WriteLine("A porcentagem de jogadores com mais de 80 quilos entre todos os jogadores do campeonato é: "+(quilo80*100/55));
	}
}