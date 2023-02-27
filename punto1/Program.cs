// Realizar un programa donde el usuario ingrese los valores trimestrales del año
//y muestre en pantalla su renta anual, el total de renta a pagar y el % de impuesto agregado
//y muestre en pantalla su renta anual, el total de renta a pagar y el % de impuesto agregado

Console.WriteLine("Los tramos para la declaración de la renta de un país ");

Console.WriteLine("ingrese el valor de renta");
int renta = Int32.Parse(Console.ReadLine());

//porcentaje de impuesto a pagar 

int impuesto_1 = 5;
int impuesto_2 = 10;
int impuesto_3 = 15;
int impuesto_4 = 20;
int impuesto_5 = 30;

// operaciones renta con el impuesto a pagar 


int total_impuesto_1 = renta * impuesto_1 / 100;
int total_impuesto_2 = renta * impuesto_2 / 100;
int total_impuesto_3 = renta * impuesto_3 / 100;
int total_impuesto_4 = renta * impuesto_4 / 100;
int total_impuesto_5 = renta * impuesto_5 / 100;


//condicional de eleccion de  porcentajes del cual la  renta se va a pagar 

if (renta < 10000){


    Console.WriteLine("el total de renta es: " + (renta + total_impuesto_1) + "el impúesto agregado es de: " + impuesto_1 + "%");
    Environment.Exit(0);
}

if (renta  >=10000 && renta  <=20000){

 Console.WriteLine("el total de renta es: " + (renta + total_impuesto_2) + "el impúesto agregado es de: " + impuesto_2 + "%");
    Environment.Exit(0);
}


if (renta  >=20000 && renta  <=35000){

    
 Console.WriteLine("el total de renta es: " + (renta + total_impuesto_3) + "el impúesto agregado es de: " + impuesto_3 + "%");
    Environment.Exit(0);


}

if (renta  >=35000 && renta  <=45000){

    
 Console.WriteLine("el total de renta es: " + (renta + total_impuesto_4) + "el impúesto agregado es de: " + impuesto_4 + "%");
    Environment.Exit(0);


}

if (renta  >=45000 ){

    
 Console.WriteLine("el total de renta es: " + (renta + total_impuesto_5) + "el impúesto agregado es de: " + impuesto_5 + "%");
    Environment.Exit(0);


}