using System;

public class Jogador{
    public string nome;
    public bool status;
    public int vida;

    public Jogador(){
        nome = "Nearby";
        vida = 80;
        status = true;
    } 
    public Jogador(string n){
        nome = n;
        vida = 100;
        status = true;
    } 
    public Jogador(string n, int v, bool s){
        nome = n;
        vida = v;
        status = s;
    }

    public void info(){
        Console.WriteLine("Nome....: {0}", nome);
        Console.WriteLine("Vida....: {0}", vida);
        Console.WriteLine("Status..: {0}", status? "Vivo": "Morto");
        Console.WriteLine("--------------");
    }
}

class aula11{
    static void Main(){
        Jogador padrão = new Jogador();
        Jogador fulanin = new Jogador("fulanin");
        Jogador gui = new Jogador("Guilherme", 100, true);

        padrão.info();
        fulanin.info();
        gui.info();

    }
}