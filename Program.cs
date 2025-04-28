using System;

namespace Burbuja {
    public class Orden {
        public static void Main() {
            
            int[] Numeros = new int[10];

            Console.WriteLine("Ingresa 10 números:");

            for (int i = 0; i < Numeros.Length; i++) {
                Console.Write($"Número #{i + 1}: ");
                Numeros[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < Numeros.Length - 1; i++) {
                for (int j = 0; j < Numeros.Length - 1 - i; j++) {
                    if (Numeros[j] > Numeros[j + 1]) {
                        int temporal = Numeros[j];
                        Numeros[j] = Numeros[j + 1];
                        Numeros[j + 1] = temporal;
                    }
                }
            }

            int minimo = Numeros[0];
            int maximo = Numeros[Numeros.Length - 1];

            Console.WriteLine($"\nEl número mínimo es: {minimo}");
            Console.WriteLine($"El número máximo es: {maximo}");

            Console.WriteLine("\nLista ordenada de menor a mayor:");
            for (int i = 0; i < Numeros.Length; i++) {
                Console.Write(Numeros[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
