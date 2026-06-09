internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Datos academicos\nNombre: Federico Cotto GArcia" + "\nGrado: IVC" + "\nClave: 8");

        //Crear e inicializar el arreglo
        int[] edadPersonas = new int[7];
        int cantidadPersonasMayores = 0;
        int cantidadPersonasMenores = 0;
        //Llenar el arreglo
        for (int i = 0; i < edadPersonas.Length; i++)
        {
            Console.WriteLine("Ingrese la edad de la persona: " + (i + 1) + ": ");
            edadPersonas[i] = Convert.ToInt32(Console.ReadLine());
            if (edadPersonas[i] >= 18)
            {
                cantidadPersonasMayores++;
                //cantidadPersonasMayores++;= cacntidadpersonasmayore +1


            }
            if (edadPersonas[i] < 18)
            {
                cantidadPersonasMenores++;
                //cantidadPersonasMayores++;= cacntidadpersonasmayore +1


            }
          
            
        }
        //Resultado
        Console.WriteLine();
        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadPersonasMayores);
        Console.WriteLine("Cantidad de personas menores de edad: " + cantidadPersonasMenores);
        Console.WriteLine("Cantidad de personas : "+ (cantidadPersonasMayores + cantidadPersonasMenores));
    }
}
