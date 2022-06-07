using System;
using System.IO;



public class program
{
    public static void Main(string[] args)
    {
        string? path;
        Console.WriteLine("Ingrese una ruta:");
        path = Console.ReadLine();
        mostrarDirectorio(path);

    }

    public static void mostrarDirectorio(string path)
    {
        if (Directory.Exists(path)){
            List<string> listadoCarpetas = Directory.GetDirectories(path).ToList();
            foreach(string CarpetaY in listadoCarpetas)
            {
                Console.WriteLine(CarpetaY);

                foreach(string item in Directory.GetFiles(CarpetaY))
                {
                    Console.WriteLine(item);
                }
            }

        }

    }
}