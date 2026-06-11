internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Federico Cotto Garcia\nIVC Clave 8");

        int[] numerosenteros = new int[15];
        bool existerepetido = false;
        for (int indice = 0; indice < 15; indice++)
        {
            Console.Write("Ingrese el numero " + (indice + 1) + ": ");
            numerosenteros[indice] = Convert.ToInt32(Console.ReadLine());
        }


        for (int indice = 0; indice < 14; indice++)
        {
         
            for (int comparador = indice + 1; comparador < 15; comparador++)
            {
              
                if (numerosenteros[indice] == numerosenteros[comparador])
                {
                    existerepetido = true;
                }
            }
        }

      
        if (existerepetido)
        {
            Console.WriteLine("Si existe al menos un numero repetido");
        }
        else
        {
            Console.WriteLine("No existe ningun numero repetido.");
        }
    }




}
