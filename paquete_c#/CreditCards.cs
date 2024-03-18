using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient()) // Crea un cliente HttpClient para realizar solicitudes HTTP
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://fakerapi.it/api/v1/credit_cards?_quantity=1"); // Realiza una solicitud GET a la API
                response.EnsureSuccessStatusCode(); // Lanza una excepción si la solicitud no fue exitosa

                string responseBody = await response.Content.ReadAsStringAsync(); // Lee el cuerpo de la respuesta como una cadena
                Console.WriteLine(responseBody); // Imprime la respuesta en la consola
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al realizar la solicitud: {e.Message}"); // Imprime el mensaje de error en caso de fallo
            }
        }
    }
}
