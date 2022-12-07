# _`GENERALA`_

## _Sobre mi... 😎_
Mi nombre es Maitena Galjot y les presento mi trabajo.
A pesar de que al principio me sentia medio perdida sobre como arrancar este TP, finalmente pude ir implementando cada uno de los temas... sin embargo, se que tengo que mejorar cosas.
A diferencia del primer TP, quede mucho mas conforme con la parte visual, creo que avance bastante!

## _Reseña 😶‍🌫️_
Una vez abierto el programa, debera logearse con alguno de los usuarios precargados que proporcionare a continuacion:
```
Usuario ------> Clave
```
    Maite --------> cami
    Isa ----------> algo
    Gustavo ------> algo2
>
o podra registrar uno propio.

Desues de logearse podra proceder a jugar una partida, eligiendo su oponente de una lista previamente dada, donde encontrara a los demas usuarios registrados.

La partida consta de 4 rondas, una ronda contiene un turno para cada jugador, que a su vez consta de 3 tiradas. En todo momento podra ir visualizando los puntos que va obteniendo cada jugador. Ya finalizada la partida, podra ver el nombre del jugador ganador por pantalla.

De todas formas, en caso de alguna duda, la aplicacion consta de un boton que le mostrara las reglas del juego en detalle.

## _Diagrama de clases 📜_

## _Justificacion tecnica 🤯️_
`SQL`
Utilizo SQL para llevar un registro de los jugadores, para esto tengo una clase ListaJugadores en la cual empleo los metodos necesarios para traer la lista de la base de datos, agregar nuevos jugadores y/o modificarlos.
`Manejo de excepciones`
Utilizo bloques try-catch en lugares esenciales del codigo: a la hora de manejar SQL, serializacion, archivos y task. Capturando asi posibles excepciones en los sitios mas propensos a generarlos.
`Unit testing`

`Generics`
Dentro de las entidades, se encuentra una clase generica abstracta llamada BaseDeDatos<T> donde implemento metodos a utilizarse para la conexion con SQL. En este caso la clase ListaJugadores mencionada anteriormente, hereda de esta clase generica, donde T vendria a ser de tipo Jugador. De esta forma, en caso de necesitar usar SQL para otro tipo de dato, podre recurrir a usar esta entidad generica. 
`Serializacion`
Dentro de la aplicacion se encuentra una clase estatica denominada Reglas, que posee justamente las reglas del juego. Aqui las reglas son creadas, serializadas y deserializadas en formato json.
`Escritura de archivos`

`Interfaces`
Retomando la serializacion, el programa posee una interfaz llamada ISerializacion donde se encuentran las firmas de los metodos para serializar y deserializar. En este caso utilizo la serializacion en formato json, sin embargo tranquilamente podria usarla en xml, por eso veo factible la utilizacion de interfaces en este caso, ya que ambos tipos de serializacion usan la misma firma.
`Delegados y eventos`
Utilizo delegados para la validacion de los puntos ingresados por el usuario a la hora de registrar una jugada. Ademas, se emplea un delegado cuya funcion es la de validar el ingreso correcto de numeros en los textbox del Login y Registro.
`Task`

