using System;
		
public class Agenda{ 
	public string[] vetorNome = new string[10];
	public int[] vetorIdade = new int[10];
	public float[] vetorAltura = new float[10];
	public int armazena = 0;
	
	public void armazenaPessoa (string nome, int idade, float altura){
	
		if(armazena < 10){
			vetorNome[armazena]=nome; 
			vetorIdade[armazena]=idade;
			vetorAltura[armazena]=altura;
			armazena++;
		}
	} 
	public void removePessoa (string nome){
		for(int i = 0; i<10; i++){
				if(nome == vetorNome[i]){
					vetorNome[i] = "";
					vetorIdade[i] = 0;
					vetorAltura[i] = 0;
				}
			}
	} 
	public int buscaPessoa (string nome){
		for(int i = 0; i<10; i++){
				if(nome == vetorNome[i]){
					return i;
				}
			}
		return 0;
	}   

	public void imprimePovo(){
		for(int i = 0; i<10; i++){
				Console.WriteLine("Nome: "+vetorNome[i]);
				Console.WriteLine("Idade: "+vetorIdade[i]);
				Console.WriteLine("Altura: "+vetorAltura[i]);
			}
	}   

	public void imprimePessoa (int j){
		
		for(int i = 0; i<10; i++){
			if(j==i){
				Console.WriteLine("Nome: "+vetorNome[i]);
				Console.WriteLine("Idade: "+vetorIdade[i]);
				Console.WriteLine("Altura: "+vetorAltura[i]);
			}
		}
	}  
}