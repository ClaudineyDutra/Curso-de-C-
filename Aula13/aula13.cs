using System;

public class Veiculo{
    //Aprendendo injeção de dependência
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }

    public void aceleracao(int mult){
        velAtual += 10*mult;
    }

    public int getVelAtual(){
        return this.velAtual;
    }
}

class Carro:Veiculo{
    public Veiculo veiculo_teste;
    public Carro(Veiculo veiculo_inject){
        veiculo_teste=veiculo_inject;
    }

    public void setAceleracao(int mult){
        veiculo_teste.aceleracao(mult);
    }
}

class Aula13{
    static void Main(){
        Veiculo v1=new Veiculo();
        Carro c1=new Carro(v1);

        c1.setAceleracao(2);
        Console.WriteLine(v1.getVelAtual());
    }
}