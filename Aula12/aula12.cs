using System;


class Veiculo{
    public int velMax;
    private bool ligado;
    private int rodas;

    public Veiculo(int rodas){
        this.rodas=rodas;
    }

    public void ligar(){
        this.ligado=true;
    }
    public void desligar(){
        this.ligado=false;
    }

    public void info(){
        Console.WriteLine("Vel.Max....: {0}", this.velMax);
        Console.WriteLine("Ligado.....: {0}", this.ligado);
    }

    public bool getMotor(){
        return ligado;
    }

    public int getRodas(){
        return this.rodas;
    }
}

class Carro:Veiculo{
    
    public string cor;
    public string nome;

    public Carro(string nome, string cor):base(4){
        desligar();
        this.nome=nome;
        this.cor=cor;
        velMax=160;
    }
}

class Aula12{
    static void Main(){
        Carro c1=new Carro("Corolla", "Prata");

        Console.WriteLine("Nome.......: {0}", c1.nome);
        Console.WriteLine("Cor........: {0}", c1.cor);
        Console.WriteLine("Vel.Max....: {0}", c1.velMax);
        Console.WriteLine("Rodas......: {0}", c1.getRodas());
        Console.WriteLine("Stts.Motor.: {0}", c1.getMotor()? "Ligado":"Desligado");

    }
}