fetch('https://fakerapi.it/api/v1/persons?_quantity=1&_gender=male&_birthday_start=2005-01-01')
    .then(response => {
        if (!response.ok) {
            throw new Error('Error en la solicitud HTTP ' + response.status); // Lanza una excepción si la solicitud no fue exitosa
        }
        return response.json(); // Devuelve los datos de la respuesta como JSON
    })
    .then(data => console.log(data)) // Imprime los datos en la consola
    .catch(error => console.error('Error:', error)); // Maneja cualquier error que pueda ocurrir durante la solicitud
