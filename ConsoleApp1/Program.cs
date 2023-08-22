string[] unidades =
{
    "cero",
    "uno",
    "dos",
    "tres",
    "cuatro",
    "cinco",
    "seis",
    "siete",
    "ocho",
    "nueve"
};
string[] decenas =
{
    "diez",
    "veinte",
    "treinta",
    "cuarenta",
    "cincuenta",
    "sesenta",
    "setenta",
    "ochenta",
    "noventa"
};
string[] centenas =
{
    "cien",
    "doscientos",
    "trecientos",
    "cuatrocientos",
    "quinientos",
    "seiscientos",
    "setecientos",
    "ochocientos",
    "novecientos"
};
string[] especiales =
{
    "once",
    "doce",
    "trece",
    "catorce",
    "quince",
    "dieciseais",
    "diecisiete",
    "dieciocho",
    "diecinueve"
};

int nuemro;
while (true)
{
    Console.Write("Ingrese un numero entre 0 y 9999: ");
    if (int.TryParse(Console.ReadLine(), out nuemro))
    {
        if(nuemro >= 0 && nuemro <= 9999)
        {
            string numeroenletra = convertirnumeroenletra(nuemro);
            Console.WriteLine($"El numero {nuemro} en letras es {numeroenletra}");
        }
        else
        {
            Console.WriteLine("El numero ingresado esta fuera del rango valido");
        }
    }
    else
    {
        Console.WriteLine("entrada no valida porfavor ingrese un numero valido");
    } 
}

string convertirnumeroenletra(int nuemro)
{
    if (nuemro == 0)
        return "cero";

    string numeroenletra = "";


    //Procesando unidades de millar
    int unidaddemillar = nuemro / 1000;
    if(unidaddemillar > 0)
    {
        if (unidaddemillar == 1)
            numeroenletra = "mil ";
        else
            numeroenletra += unidades[unidaddemillar] + "mil";
        nuemro %= 1000;
    }

    //procesando centenas
    int centena = nuemro / 100;
    if (centena > 0)
    {
        if (centena == 0)
            numeroenletra = "mil ";
        else
            numeroenletra += "ciento-" + unidades[centena];
        nuemro %= 100;
    }

    //procesando decenas y unidades
    if(nuemro >= 10 && nuemro <= 19)
    {
        numeroenletra += especiales[nuemro - 10];
    }
    else
    {
        int decena = nuemro / 10;
        if (decena > 0)
        {
            numeroenletra += " y ";
        }
    }

    return numeroenletra;
}