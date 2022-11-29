# Maggiori Gianni - SegundoParcial - Division: 2D

# La Generala Fruta

# Consigna: 

## Hacer una aplicación que administre una sala de juegos, teniendo que desarrollar uno de los 5 juegos planteados (La Generala, El Truco, El Chinchon, El Uno, La Escoba de 15). Los juegos se tienen que simular solos, jugados automaticamente por la maquina sin detener el flujo del programa, bloquear otras funcionabilidades, o tener cortes en la forma en la que el programa se desenvuelve. Usando los temas vistos en clases desde la mitad del cuatrimestre hasta el final de la catedra. 

# Reglas y explicación de cómo se desarrollan las partidas:

Cada jugador, al empezar una partida realizará 10 tiradas de dados cada cierto tiempo a determinar por el sistema, luego de cada tirada el sistema analizará los dados que salieron en la tirada y determinará si el jugador pudo realizar o no un juego. Los juegos son los mismos que en la generala convencional o tradicional, pero a diferencia de la generala convencional, en La Generala Fruta (made in UTN) los jugadores no pueden tirar los dados mas de 1 vez por ronda. 

# Sistema de puntos

Los juegos numéricos se mantienen iguales que la Generala convencional X cantidad de puntos al 1, X cantidad de puntos al 2, etc... Con el desarrollo de la partida el sistema determinará automaticamente cual es el dado con mas cantidad de repeticiones y se lo asignara a esa jugada el valor correspondiente siempre y cuando no forme parte de una jugada especial. Las jugadas especiales son Escalera con un puntaje de 25 puntos, Full con un puntaje de 35 puntos, Poker con un puntaje de 45 puntos, Generala con un puntaje de 55 puntos. En caso de sacar generala el jugador que obtenga generala no gana automaticamente, como seria el caso en la Generala tradicional.
La tabla con sus respectivas jugadas empieza con -1 como indicativo de valor ilógico, a medida que se desarrolla la partida ese valor se actualizara con su valor correspondiente, siendo 0 si tuvo que tachar una jugada o un valor superior a 0 si logró realizar una jugada.

# Instructivo de uso de la App y recorrido por sus diferentes secciones

Al iniciar el programa lo primero con lo que nos encontraremos es el login de la App.

![image](https://user-images.githubusercontent.com/86836893/204462478-0ef5f17b-6999-4583-ba12-43cb0a09ef16.png)

Si sos un usuario nuevo, lo primero que tendrias que hacer es registrarte en la App yendo al boton Registrarse el cual, luego de completar todos los datos creara tu usuario y estará listo para entrar en la App, si ya tenés un usuario anteriormente cargado podes iniciar sesion directamente o si queres probar el programa sin loguearte podes utilizar el boton autocompletar, el cual usara el usuario por defecto de la aplicacion. El login esta diseñado para trabajar directamente con la base de datos de SQL para asegurar la permanencia de los usuarios.

La pantalla de registro contiene campos donde podras ingresar los datos necesarios para crear tu usuario como se muestra en la siguiente pantalla. 

![image](https://user-images.githubusercontent.com/86836893/204463847-4522c4fa-8b50-4cc3-bb1b-cb34a7a58370.png)

Una vez logueado el usuario que utilizará la aplicacion, se mostrara la pantalla principal.

![image](https://user-images.githubusercontent.com/86836893/204464731-02cd0146-ab52-4016-85f0-f68f2c89f124.png)

La pantalla principal esta dividida en secciones que hacen referencia a su area de responsabilidad.
En la seccion de mesas de juego se mostraran todas las mesas que fueron creadas esten jugando o bien hayan finalizado la correspondiente partida, ni bien empezado el programa no se visualizara ninguna, ya que es el usuario quien determinara quien jugara contra quien. 

![image](https://user-images.githubusercontent.com/86836893/204467056-39cd2889-752b-4e0a-9e47-c0270eada720.png)


Lo primero que se deberia hacer antes de intentar crear una mesa de juego es importar los jugadores. 

![image](https://user-images.githubusercontent.com/86836893/204467241-4f7efdd2-783d-49bb-97c8-51920e5d447f.png)


Se deja a eleccion del usuario de que forma quiere importar los jugadores de la aplicacion, puede importarlos directamente desde la base de datos lo cual es altamente recomendable si usted es un usuario que jamas uso la aplicacion y nunca generó archivos de tipo JSON o XML para persistir esos datos. 

NOTA IMPORTANTE: Para poder importar los jugadores sin usar la base de datos previamente deberá al menos una vez (o la primera vez) cargarlos desde la base de datos y luego exportaros en formato JSON o XML, eso esta ubicado en donde dice Exportar Datos como se muestra a continuación.


![image](https://user-images.githubusercontent.com/86836893/204473606-21562824-9e2d-452b-9d10-f54a14a677b0.png)


Luego de haber importado los jugadores desde la base de datos o desde archivos de tipo JSON o XML exportados anteriormente, ya esta todo listo para que usted pueda seleccionar dos jugadores y crear una mesa de juego como se muestra a continuacion.


![image](https://user-images.githubusercontent.com/86836893/204467649-e872a352-0c5c-4784-a2a0-264ca194e338.png)


Luego de haber seleccionado a ambos jugadores ya esta todo listo para darle click al boton crear mesa, lo cual mostrara la siguiente pantalla.


![image](https://user-images.githubusercontent.com/86836893/204468383-8395d55c-d5e2-4c06-bd3e-01ed0f87b3ca.png)


Esa Pantalla es donde se desarrolla la partida, esta totalmente automatizada desde las tiradas que se ejecutan con una task en un hilo secundario, como la actualizacion del puntaje, el informe del ganador y la realizacion de un informe de la partida. Al finalizar la partida, la pantalla se vera asi.


![image](https://user-images.githubusercontent.com/86836893/204470670-57644265-3099-45f2-8619-382926d55148.png)


Al momento de crear la mesa, se actualizara el grid donde se muestran las partidas en la pantalla principal, donde se mostrara el codigo unico de la partida y los jugadores que formaron parte de esa partida. 
Se vera de la siguiente forma.


![image](https://user-images.githubusercontent.com/86836893/204471122-d764051d-fc66-41a6-8469-f51815faeaa7.png)


La aplicacion esta diseñada para guardar un registro local de la partida en un archivo de texto que se guardara de forma prederminada en una carpeta llamada Archivos en el escritorio. Dicho informe se visualizara yendo a la carpeta mencionada anteriormente y abriendo el o los archivos de los cuales usted quiere ver el informe como se muestra a continuacion.


![image](https://user-images.githubusercontent.com/86836893/204471798-cfe1fbe7-1f06-4cc9-9494-d687a8ab1ff5.png)


Encontraran un archivo similar al siguiente que concuerda con la partida de ejemplo antes mostrada.


![image](https://user-images.githubusercontent.com/86836893/204472139-53750f53-2ddf-431e-b71d-5a5a1ead66b6.png)


Al abrir el archivo usted vera lo siguiente.


![image](https://user-images.githubusercontent.com/86836893/204472392-7183a07d-0556-478a-9b5e-362198a464a3.png)


Usted puede, si quiere, agregar mas jugadores al programa. Al hacer click en el boton nuevo jugador como se ve en la siguiente imagen.


![image](https://user-images.githubusercontent.com/86836893/204475572-d4fc5052-a34b-46cc-9cb4-90eb1f3df6b2.png)


Lo cual abrira un formulario de registro que solo le pedira su nombre completo. Como se muestra a continuacion.


![image](https://user-images.githubusercontent.com/86836893/204476384-51cbb3ec-b060-433e-97d3-b026166a8b2d.png)


Aclaracion: Al dar de alta un nuevo jugador este se dara de alta directamente en la base de datos. Usted luego debera volver a importar desde la base de datos los jugadores para ver reflejados los cambios, por ejemplo, si usted da de alta 20 nuevos jugadores cuando termine el proceso de ingresar a cada jugador debera actualizar el listado de jugadores como ya se explico previamente.


![image](https://user-images.githubusercontent.com/86836893/204477530-08699948-0a36-47b7-8f8e-91eb5ab9d2eb.png)


Para exportar datos usted puede dirigirse a la siguiente seccion donde encontrara dos botones con los que puede exportar los jugadores con todos sus datos en archivos de tipo JSON o XML o ambos si asi lo desea.


![image](https://user-images.githubusercontent.com/86836893/204478131-96d59ae1-7230-46f3-baad-83ac8567ac49.png)


Los archivos que contienen los jugadores de la aplicacion en cualquiera de los dos formatos propuestos estaran ubicados en una carpeta especial en el escritorio llamada Archivos (es la misma carpeta donde se guardaran de forma automatica los registros de las partidas una vez finalizadas).


![image](https://user-images.githubusercontent.com/86836893/204478637-9e8a7da0-cb84-4d81-ae73-3f1a3959fd54.png)


Una vez dentro de esa carpeta encontraremos todos los archivos generados por el sistema (ahora usted esta en condiciones de cerrar la aplicacion y al volverla a ejecutar decidir por usted mismo como quiere importar los jugadores para poder jugar partidas). 
Dentro de dicha carpeta encontrara algo similar a la siguiente imagen.


![image](https://user-images.githubusercontent.com/86836893/204479468-df3eae91-611a-43e8-a25b-a73025999cc1.png)


Para cualquiera de los archivos tanto JSON o XML usted necesitara alguna aplicacion para poder abrirlos o bien puede abrirlos con un bloque de notas. Se vera asi.


![image](https://user-images.githubusercontent.com/86836893/204480329-97580ae4-74cd-42bb-8a27-6023452bb5bb.png)


El archivo de extension XML puede abrirlo en cualquier navegador sin problema. Se vera de la siguiente manera.


![image](https://user-images.githubusercontent.com/86836893/204480683-e97c4fb8-6749-439a-8206-ec42838928d5.png)


Si usted desea chequear algunos datos estadisticos como por ejemplo el ranking de victorias. Puede hacer click en el boton Ranking de Victorias.


![image](https://user-images.githubusercontent.com/86836893/204481136-b283203e-4c87-490f-9d94-698f3cff3221.png)


El cual abrira una ventana como se muestra a continuación.


![image](https://user-images.githubusercontent.com/86836893/204481207-d1d60fd8-0407-4723-aff4-2d98e1c98d8d.png)


Esta ventana consulta con la base de datos y genera un ranking basado en la cantidad de partidas ganadas ordenandolas de mayor a menor. Asi podemos saber quien es el que mas partidas ha ganado.



# Justificacion Tecnica y autocritica sobre el proyecto


## Justificacion Tecnica

### SQL 

El programa trabaja en el login y el manejo de jugadores con SQL. Tambien trabaja con SQL donde se genera el ranking de victorias, la consulta sobre el ranking se hace directo a la base de datos por query.

### Interfases, Archivos, Serializacion y Generics

Como interfaz use una interfaz generica que define los metodos serializar y deserializar implementados en las clases SerializarJSON y SerializarXML utilizados para importar y exportar jugadores.
La clase estatica Archivo se encarga de leer y escribir archivos de texto.
Generics esta implementado en la combinacion de la interfaz IManejadoraDeArchivos, SerializarJSON y SerializarXML.

### Manejo de Exceptions

El manejo de exceptions se encuentra en casi todo el programa tratadas de forma correcta para que no rompa en tiempo de ejecucion.

### Unit Testing

Esta implementado en un proyecto dentro de la misma solucion llamado TestJuego. En este proyecto se encuentran las clases donde se realizaron los unit testing de las clases: Archivo, Juego/Generala, JugadorDAO, UsuarioDAO, SerializarJSON, SerializarXML. Todas las clases del proyecto TestJuego llevan el mismo nombre que la clase que testean con la palabra "Deberia" al final para identificarlas de mejor manera.
Nota Importante: Algunos metodos estan testeados en conjunto por una cuestion de que trabajan entre si, no me parecio tan importante hacer un Unit-Test aparte para esos metodos (sobre todo los que no manejan logica del juego o realizan tareas muy complicadas).

### Delegados, Task y Eventos y Programacion Multi-Hilos

Estan implementados en variados lugares. Dentro del proyecto de TestJuego (UnitTesting) especificamente en las clases que testean la serializacion JSON y XML se usan tasks que vienen de las clases de serializacion para mostrar por consola algunos datos para mejorar la prueba de UnitTesting.
En la clase Juego donde se desarrolla la partida y en la clase Partida que informa el ganador y genera el informe de la partida en conjunto con la clase Archivo.


## Autocritica

Podria haber incluido la clase Archivo dentro de IManejadoraDeArchivos e implementar esos metodos. Creo que podria haber hecho algunos UnitTesting mas, con respecto a metodos que no manejan logica del juego o no realizan tareas demaciado complicadas o extensas. Tambien creo que deberia haber hecho el doble testeo para metodos que pueden tirar exceptions, algunos estan hechos pero otros no, no se que tan importante hubiera sido, ya que se por que arrojarian excepciones esos metodos, pero tal vez hubiera sido mejor hacerlos, pense que no llegaba con el tiempo.



