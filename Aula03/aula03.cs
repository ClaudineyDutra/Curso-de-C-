using System;

class Aula03{
    static void Main(){
        int num=0;
        byte n1=10; // 0 e 255
        float valor = 5.3f;
        char letra='c'; //apenas um caracter
        string nome="Claudiney"; //Armazena um conjunto de caracteres


        var aux=nome; //Assume o tipo do dado que recebe
        Console.WriteLine("Valor da variável:" + aux);

        int num1, num2, res;
        num1=10;
        num2=5;
        res = num1 * num2;

        Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " é " + res);
    }
}