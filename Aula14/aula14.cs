using System;
// APRENDENDO SOBRE INTERFACE

public interface IVeiculo{
    void ligar();
    void desligar();
    void info();
}

public interface ICombate{
    void disparar();
}


class Carro:IVeiculo, ICombate{
    public int municao;
    public bool ligado;

    public Carro(){
        this.ligado=false;
        this.municao=100;
    }

    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }
    public void info(){
        Console.WriteLine("Munição..:" + this.municao);
        Console.WriteLine("Ligado...:{0}", this.ligado? "Sim":"Não");
    }
    public void disparar(){
        Console.WriteLine("--Disparo realizado!--");
        this.municao-=1;
        Console.WriteLine("Munição atual: "+this.municao);
        Console.WriteLine("----------------------");
    }
}

class Aula14{
    static void Main(){
        Carro c1=new Carro();

        c1.info();
        c1.ligar();
        c1.disparar();
        c1.info();
    }
}