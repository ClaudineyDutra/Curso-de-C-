using System;

class aula09{
    static void Main(){
        int divid = 36;
        int divis = 4;
        int quoc, resto;
        quoc = divide(divid, divis, out resto);

        Console.WriteLine("O nº {0}/{1} tem quociente {2} e resto {3}", divid, divis, quoc, resto);

    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente = dividendo / divisor;
        resto = dividendo % divisor;
        return quociente;
    }
}