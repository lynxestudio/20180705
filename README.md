# Utilizando las clases de ADO.NET en Oracle.

Hace bastante tiempo que hice unas clases de ADO.NET para Oracle (un tipo helper de manera elemental). Quizás no es la manera más optima de acceder a una base de datos, pero al menos en ambientes restringidos en donde existen aplicaciones legadas donde no es posible actualizar otro proveedor de ADO.NET para Oracle que no sea el que viene predeterminado por .NET.

Aquí esta la clase para manejar la conexión, se llama OracleDataBase

Fig 1. Clase para manejar la conexion a la base de datos.



Utilizo otra clase llamada OracleDataBaseCommand para auxiliarme con los comandos.
Fig 2. Clase auxiliar para ejecutar los comandos en la base de datos.



Su utilización dentro de una clase que sirva para persistir o extraer datos sería de la siguiente manera.

Fig 3. Clase que utiliza las clases auxiliares para guardar un objeto.



Fig 4. Clase principal que crea, actualiza y consulta un cliente en la base de datos.

