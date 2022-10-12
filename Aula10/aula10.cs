using System;

class aula10{
    static void Main(){
        soma(10, 54, 100, 6, 7, 8, 5);
    }

    static void soma(params int[]nums){
        int res = 0;

        if (nums.Length < 1){
            Console.WriteLine("Nenhum número passado");
        }else if (nums.Length < 2){
            Console.WriteLine("Números insuficientes para somar");
        }else{
            foreach (int num in nums){
                res += num;
            }
            Console.WriteLine("Resultado da soma......: {0}", res);
        }
    }
}