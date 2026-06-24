using System.Dynamic;
using System.Net.Sockets;
using System.Text.Json;
HttpClient client = new HttpClient(); // creo una instancia de HttpClient 
HttpResponseMessage response = await client.GetAsync("https://v2.jokeapi.dev/joke/Programming?lang=es&amount=6");// en url especificamos la dirección web donde consultamos el servicio
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync(); // lee el archivo de la direccion que nosotros colocamos en url
Chistes? chistes = JsonSerializer.Deserialize<Chistes>(responseBody); // deserializa el archivo para nosotros poder trabajar


    foreach(var ch in chistes.jokes) // recorro la lista de jokes que esta dentro del objeto chistes
    {
        Console.WriteLine("------------- Nuevo Chiste -------------");
         if (ch.setup == null && ch.delivery == null)  // si las variables vienen vacias entonces escribo otro nombre de variable 
         {
            Console.WriteLine("comienzo:"+ch.joke);
    }
    else //si las variables vienen cargadas con informacion, escribimos con nombre de las variables que corresponde 
    {
        Console.WriteLine("comienzo : "+ch.setup); 
         Console.WriteLine(":"+ch.delivery);
    }
         
    }
    



