using System;

namespace SumadoraFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indique que problema desea resolver:");
            Console.WriteLine("1. Calculadora de sumas y restas en binario, decimal y hexa");
            Console.WriteLine("2. Contador de vocales en una cadena");
            Console.WriteLine("3. Sumador factorial");
            Console.WriteLine("4. Repartidor de porciones");

            Console.WriteLine("introduzca su opción:");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("¿Qué opción desea?");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("opción");
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            int numSum1, numSum2, resSum;
                            string Res = "";
                            double residuo = 0;
                            string Res2 = "";
                            double residuo2 = 0;
                            Console.WriteLine("Ingrese el primer número para sumar");
                            numSum1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el primer número para sumar");
                            numSum2 = Convert.ToInt32(Console.ReadLine());
                            //Para el decimal
                            resSum = numSum1 + numSum2;
                            Console.WriteLine("El resultado de la suma es: " + resSum);

                            //Para el binario 
                            long bin1 = ConversionBinaria(numSum1);
                            long bin2 = ConversionBinaria2(numSum2);
                            long resBin = 0;
                            resBin = bin1 + bin2;
                            Console.WriteLine("El resultado para binario es: " + resBin);
                            //Para el Hexa
                            do
                            {
                                residuo = ((int)(numSum1) / 16);
                                numSum1 = numSum1 / 16;
                                residuo = (residuo = numSum1) * 16;
                                if (residuo == 10)
                                {
                                    Res = "A" + Res;
                                }
                                if (residuo == 11)
                                {
                                    Res = "B" + Res;
                                }
                                if (residuo == 12)
                                {
                                    Res = "C" + Res;
                                }
                                if (residuo == 13)
                                {
                                    Res = "D" + Res;
                                }
                                if (residuo == 14)
                                {
                                    Res = "E" + Res;
                                }
                                if (residuo == 15)
                                {
                                    Res = "F" + Res;
                                }

                            }
                            while (numSum1!=0);
                            {
                                
                            }
                            do
                            {
                                residuo2 = ((int)(numSum2) / 16);
                                numSum2 = numSum2 / 16;
                                residuo2 = (residuo2 = numSum2) * 16;
                                if (residuo2 == 10)
                                {
                                    Res2 = "A" + Res2;
                                }
                                if (residuo2 == 11)
                                {
                                    Res2 = "B" + Res2;
                                }
                                if (residuo2 == 12)
                                {
                                    Res2 = "C" + Res2;
                                }
                                if (residuo2 == 13)
                                {
                                    Res2 = "D" + Res2;
                                }
                                if (residuo2 == 14)
                                {
                                    Res2 = "E" + Res2;
                                }
                                if (residuo2 == 15)
                                {
                                    Res2 = "F" + Res2;
                                }

                            }
                            while (numSum2 != 0);
                            {

                            }
                            String resHexa = "";
                            resHexa = Res + Res2;
                            Console.WriteLine("El resultado del hexa es: " + resHexa);
                            
                            


                            break;
                        case "2":
                            int numRes1, numRes2, resRes;
                            string ResRes = "";
                            double residuo1 = 0;
                            string ResRes2 = "";
                            double residuoResta2 = 0;
                            Console.WriteLine("Ingrese el primer número para sumar");
                            numSum1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese el primer número para sumar");
                            numSum2 = Convert.ToInt32(Console.ReadLine());
                            //Para el decimal
                            resRes = numSum1 + numSum2;
                            Console.WriteLine("El resultado de la resta es: " + resRes);

                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Ingrese la palabra que desea evaluar");
                    char[] palabra = Console.ReadLine().ToCharArray();
                    int numV = Vocales(palabra);
                    Console.WriteLine("La palabra ingresada contiene: " + numV+ " vocales.");

                    break;
                case "3":
                    Console.WriteLine("¿Qué numero desea calcular?");
                    int numF = Convert.ToInt32(Console.ReadLine());
                    int nFac = 1;
                    for (int i = 1; i <= numF; i++)
                    {
                        nFac = nFac * i;

                    }
                    Console.WriteLine("El factorial de: " + numF + ", es: " + nFac);
                    Console.ReadLine();
                    break;
                case "4":

                    break;


            }
            //1
            
            static long ConversionBinaria(int aux1)
            {
                long bin1 = 0;
                const int div = 2;
                long aux2 = 0;
                for(int i = aux1%div,j=0; aux1>0;aux1/=div,i=aux1%div, j++)
                {
                    aux2 = i % div;
                    bin1 += aux2 * (long)Math.Pow(10, j);
                }
                return bin1;
            }
            static long ConversionBinaria2(int aux2)
            {
                long bin2 = 0;
                const int div = 2;
                long aux3 = 0;
                for (int i = aux2 % div, j = 0; aux2 > 0; aux2 /= div, i = aux2 % div, j++)
                {
                    aux3 = i % div;
                    bin2 += aux3 * (long)Math.Pow(10, j);
                }
                return bin2;
            }
            //2
            static int Vocales(char[] palabraVocal)
            {
                int aux = 0;
                int i = 0;
                while (i < palabraVocal.Length)
                {
                    if (palabraVocal[i]=='a'|| palabraVocal[i] == 'e' || palabraVocal[i] == 'i' || palabraVocal[i] == 'o' || palabraVocal[i] == 'u')
                    {
                        aux++;
                    }
                    i++;
                }
                return aux;
            }
            
        }
    }
}
