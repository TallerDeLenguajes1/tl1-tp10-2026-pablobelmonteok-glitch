using System.Text.Json;
Console.WriteLine("Hello, World!");
 

// Crear una Instancia de HttpClient:
HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");// en url especificamos la dirección web donde consultamos el servicio
response.EnsureSuccessStatusCode();
// Enviar Solicitud GET: Se envía una solicitud GET a la URL especificada y se verifica que la respuesta sea exitosa.
// Leer y Deserializar la Respuesta:
string responseBody = await response.Content.ReadAsStringAsync();
List<Tarea> tareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
foreach (var tarea1 in tareas)
{
Console.WriteLine("User id : " + tarea1.userId + " Id: " + tarea1.id + " Titulo: " + tarea1.title + "  Completado: " + tarea1.completed);
}
List<Tarea> listcomplet = JsonSerializer.Deserialize<List<Tarea>>(responseBody);

string jsonString = JsonSerializer.Serialize(listcomplet);
Console.WriteLine(jsonString);
await File.WriteAllTextAsync("tareas.json", jsonString );
