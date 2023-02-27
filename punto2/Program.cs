//Escribir un programa para una sala de juegos que quiere calcular de forma automática el precio que debe cobrar a sus clientes por ingresar. El software solicita al usuario el nombre completo y la edad del cliente para que  muestra al final el nombre completo, el precio de la entrada y su descuento si lo tiene. Si el cliente es menor de 4 años puede entrar gratis, si tiene entre 4 y 18 años debe pagar la entrada y tendrá un descuento del 5% y si es mayor de 18 años debe pagar la entrada y tendrá un descuento del 3%. La entrada tiene un valor de 15000$.
Console.WriteLine("bienvenidos a la sala de juegos precio de entrada $15000 ");



//ingreso de datps , nombre completo y edad 


Console.WriteLine("ingrese su nombre");
string nombrecompleto = Console.ReadLine();
Console.WriteLine("ingrese su edad");
int edad = Int32.Parse(Console.ReadLine());

//variables de precio y descuentos 

int precio = 15000;
int descuento1 = 5;
int descuento2 = 3;

//operaciones para conocer los descuentos 

int total_4_18 = precio * descuento1 / 100;
int total_18 = precio * descuento2 / 100;


//condicional para  conocer el valora apagar teniendo en cuenta los descuentos dependiendo de la edad 


if (edad < 4){


    Console.WriteLine("la entrada es gratis ");
    Environment.Exit(0);
}

if (edad >=4 && edad <=18){

    Console.WriteLine("nombre: "+ nombrecompleto + "el precio de la entrada sera de: "+ (precio -= total_4_18)  + " el descuento fue de: "+ descuento1 + "%");
    Environment.Exit(0);
}


if (edad > 18){

   Console.WriteLine("nombre: "+ nombrecompleto + " el precio de la entrada sera de: "+ ( precio -= total_18) + " el descuento fue de: "+ descuento2 + "%");
    Environment.Exit(0);
}