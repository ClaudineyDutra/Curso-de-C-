using System;

class aula08{
    // Goto
    
    static void Main(){
        int tempo;
        char escolha;

        inicio:

        Console.Clear();
        Console.WriteLine("Calcular tempo de CE para RN");
        Console.WriteLine("Qual transporte deseja? [a] Avião [b] Barco [c] Carro");

        escolha = char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                tempo = 60;
                Console.WriteLine("Tempo: {0} min", tempo);
                break;
            case 'b':
                tempo = 360;
                Console.WriteLine("Tempo: {0} min", tempo);
                break;
            case 'c':
                tempo = 600;
                Console.WriteLine("Tempo: {0} min", tempo);
                break;
            
            default:
                Console.WriteLine("Escolha uma opção válida");
                break;
        }

        Console.WriteLine("Deseja calcular novamente?[s/n]");
        escolha = char.Parse(Console.ReadLine());

        if (escolha == 's'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }       
    }
}