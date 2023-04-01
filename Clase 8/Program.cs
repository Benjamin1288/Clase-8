void matriz()
{
    string[] nombre = new string[]
    {
    "Anderson","Brandon","Yeimi","Fatima","Vivian"
    };

    //for (int i=0;i<nombre.Length;++)
    //{
    //    Console.WriteLine("Elemento:"+nombre[i]);
    //}
    foreach (string n in nombre)
    {
        Console.WriteLine("nombre: "+n);
    }
    int[] notas = new int[]
    {
        50,90,85,73,95
    };
    int promedio = 0;
    foreach (int n in notas)
    {
        promedio=promedio+n;
    }
    promedio = promedio/notas.Length;
    Console.WriteLine("El promedio es igual a: " + promedio);
    int mayor=0;
    for (int i=0; i<notas.Length;i++)
    {
    if (notas[i]>mayor)
    {
        mayor = notas[i];
    }
    }
    Console.WriteLine("La nota mas alta es: "+mayor);
    
}
matriz();
