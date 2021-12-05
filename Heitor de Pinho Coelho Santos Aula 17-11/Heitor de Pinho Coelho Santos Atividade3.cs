using System;

 public class Veiculo
{
    string[] nomeProprietario = new string[5000], modelo = new string[5000] , marca = new string[5000], cor = new string[5000], combustivel = new string[5000], placa = new string[5000];
    int[] anoFabricação = new int[5000];

    public string Proprietario(){
        string prop = "";
        for(int i = 0; i<5000; i++){
            if((anoFabricação[i]<=1990) && (combustivel[i]=="gasolina")){
                prop= nomeProprietario[i];
            }
        }
        return prop;
    }

    public string Marca(){
        string veiculo = "";
        for(int i = 0; i<5000; i++){
            if(marca[i]=="GM"){
                veiculo = modelo[i];
            }
        }
        return veiculo;
    }

    public string CorPrata(){
        string prop = "";
        for(int i = 0; i<5000; i++){
            if(cor[i]=="prata"){
                prop= nomeProprietario[i];
            }
        }
        return prop;
    }

    public string anos(){
        string modelo1 = "";
        string placa2 = "";
        for(int i = 0; i<5000; i++){
            if(cor[i]=="prata"){
                modelo1 = modelo[i];
                placa2 = placa[i];
            }
        }
        return modelo1;
    }
}

