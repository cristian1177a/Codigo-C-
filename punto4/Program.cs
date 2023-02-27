//En una empresa, los empleados son premiados al final de cada año por su rendimiento. Los puntos que pueden tener en la evaluación son: 0.0, 0.4 y 0.6. pero no pueden tener valores intermedios entre las cifras mencionadas. A continuación se muestra una tabla con los niveles correspondientes a cada puntuación. La bonificación de dinero de cada nivel es de 50000$ multiplicada por la puntuación del nivel. Al final del programa se debe imprimir el nivel de evaluación y la bonificación ganada.

//declaracion de las variables 
float pp = 0;
int BONIFICACION = 50000;



//ingresar datos 
Console.WriteLine("sistema de calificasion de empleados");
Console.WriteLine("Ingresa el nombre");
string? Name = Console.ReadLine();
Console.WriteLine("Ingresa el apellido");
string? Last_Name = Console.ReadLine();
Console.WriteLine("Ingresa los puntos que gano el empleado: Rango de puntiación (0,0)(0,4)(0,6))");
pp = float.Parse(Console.ReadLine());


//switch para  mostrar los resultados 
switch (pp)
{
    case 0.0f:
        Console.WriteLine($"El empleado: {Name} {Last_Name}" );
        Console.WriteLine("Tu nivel de Evaluación es: Inaceptable La bonificación ganada es: " + Math.Round(BONIFICACION * pp));
        break;
    case 0.4f:
        Console.WriteLine($"El empleado: {Name} {Last_Name}" );
        Console.WriteLine("Tu nivel de Evaluación es: Aceptable La bonificación ganada es: " + Math.Round(BONIFICACION * pp));
        break;
    case 0.6f:
        Console.WriteLine($"El empleado: {Name} {Last_Name}" );
        Console.WriteLine("Tu nivel de Evaluación es: Meritorio La bonificación ganada es: " + Math.Round(BONIFICACION * pp));
        break;
    default:
        Console.WriteLine($"El empleado: {Name} {Last_Name}" );
        Console.WriteLine("\nLos puntos Ingresados no son validos");
        break;
}
