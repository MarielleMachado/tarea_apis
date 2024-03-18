import requests

try:
    response = requests.get('https://fakerapi.it/api/v1/images?_quantity=1&_type=kittens&_height=300') # Realiza una solicitud GET a la API
    response.raise_for_status()  # Lanza una excepción si la solicitud no fue exitosa

    data = response.json() # Parsea la respuesta como JSON
    print(data) # Imprime los datos en la consola
except requests.exceptions.RequestException as e:
    print('Error al realizar la solicitud:', e) # Imprime el mensaje de error en caso de fallo
