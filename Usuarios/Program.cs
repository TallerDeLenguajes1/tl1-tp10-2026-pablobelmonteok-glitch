using System.Dynamic;
using System.Net.Sockets;
using System.Text.Json;

// Crear una Instancia de HttpClient:
HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/users/");// en url especificamos la dirección web donde consultamos el servicio
response.EnsureSuccessStatusCode();
// Enviar Solicitud GET: Se envía una solicitud GET a la URL especificada y se verifica que la respuesta sea exitosa.
// Leer y Deserializar la Respuesta:
string responseBody = await response.Content.ReadAsStringAsync();
List<Usuarios>? usuarios = JsonSerializer.Deserialize<List<Usuarios>>(responseBody);
/*foreach (var tarea1 in usuarios)
{
Console.WriteLine(" user name: " + tarea1.username + " email: " + tarea1.email + "  address street : " + tarea1.address.street + " address swite: " +tarea1.address.suite+ "address city:"+tarea1.address.city+ "address zipcode:"+tarea1.address.zipcode+ "geo lat:"+tarea1.address.geo.lat+ "geo lng:"+tarea1.address.geo.lng );
}*/

for (int i = 0; i < usuarios?.Count && i < 5; i++)
{
   Console.WriteLine(" user name: " + usuarios[i].username + " email: " + usuarios[i].email + "  address street : " + usuarios[i].address?.street + " address swite: " +usuarios[i].address?.suite+ "address city:"+usuarios[i].address?.city+ "address zipcode:"+usuarios[i].address?.zipcode+ "geo lat:"+usuarios[i].address?.geo?.lat+ "geo lng:"+usuarios[i].address?.geo?.lng ); 
}