internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Federico Cotto Garcia\nIVC Clave 8");
        int[] numerosenteros = new int[8];
      
        
        int NOMayor=0;
        int POSMayor=0;
        for (int i = 0; i <numerosenteros.Length; i++)
        {
            Console.WriteLine("Ingrese numero desea: " + (i + 1) + ": ");
            numerosenteros[i] = Convert.ToInt32(Console.ReadLine());
            if (i == 0)
            {
                NOMayor = numerosenteros[i];
                POSMayor = i;
            }
            else 
            {
                if (numerosenteros[i] > NOMayor)
                {
                    NOMayor = numerosenteros[i];
                    POSMayor = i;
                }

            }
        }
        Console.WriteLine("numero Mayor: "+NOMayor);
        Console.WriteLine("Posicion del No.Mayor: " + POSMayor);


    }
}
