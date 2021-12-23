# STOCK EXCHANGE PROJECT

_Acá va un párrafo que describa lo que es el proyecto_

## Comenzando 🚀

Después de haber clonado con éxito el repositorio y haber abierto la solución en Visual Studio, se deberán seguir los siguientes pasos:
### 1. Modificar la url de la base de datos local.

Para ello se debe modificar el string de conexión a la base de datos local en el archivo "BagMVC/appsettings.json" de la siguiente forma:
```
"ConnectionStrings": {
    "BagContext": "Server=(localdb)\\mssqllocaldb;Database=BagContextFinal;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```

### 2. Actualizar la base de datos con los modelos de datos de BagLib


En la "Consola del Administrador de paquetes" seleccionando el proyecto BagLib y ejecutando el comando "update-database" se consigue generar las tablas de la base de datos segun las migraciones correspondientes:
```
Versión de host 6.0.0.275 de la Consola del Administrador de paquetes

Escriba 'get-help NuGet' para ver todos los comandos de NuGet disponibles.

PM> update-database
Build started...
Build succeeded.
Done.
```

### 3. Incluir la clave de la Api de AlphaVantage 🔧

En la web de "https://www.alphavantage.co/" deberemos solicitar una clave gratuita e incluirla en el archivo "secrets.json" de la siguiente forma:

Para acceder a los secretos: Right click sobre el proyecto BAGMVC -> Administrar secretos del usuario -> Incluir lo siguiente
```
  "ApiKeys": {
    "Stocks":"APIKEY"
  } 
```
### 4. Crear un usuario en la base de datos 🔧

Utilizando Microsoft SQL Server Management Studio se debe crear un usuario con id = 1, si no esta mierda no funciona :/

### 5. Poblar la base de datos con los Countries y las Currencies 🔧

Para poder tener los datos de los paises y las monedas, se deben poblar estas tablas. Para ello, lanzamos la aplicación y en la View de Countries, pulsamos sobre Actualizar desde API, o lo que es lo mismo, vamos a la dirección:

```
https://localhost/Countries/Update
```






## Ejecutando las pruebas ⚙️

_Explica como ejecutar las pruebas automatizadas para este sistema_

### Analice las pruebas end-to-end 🔩

_Explica que verifican estas pruebas y por qué_

```
Da un ejemplo
```

### Y las pruebas de estilo de codificación ⌨️

_Explica que verifican estas pruebas y por qué_

```
Da un ejemplo
```

## Despliegue 📦

_Agrega notas adicionales sobre como hacer deploy_

## Construido con 🛠️

_Menciona las herramientas que utilizaste para crear tu proyecto_

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - El framework web usado
* [Maven](https://maven.apache.org/) - Manejador de dependencias
* [ROME](https://rometools.github.io/rome/) - Usado para generar RSS

## Contribuyendo 🖇️

Por favor lee el [CONTRIBUTING.md](https://gist.github.com/villanuevand/xxxxxx) para detalles de nuestro código de conducta, y el proceso para enviarnos pull requests.

## Wiki 📖

Puedes encontrar mucho más de cómo utilizar este proyecto en nuestra [Wiki](https://github.com/tu/proyecto/wiki)

## Versionado 📌

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/tu/proyecto/tags).

## Autores ✒️

_Menciona a todos aquellos que ayudaron a levantar el proyecto desde sus inicios_

* **Andrés Villanueva** - *Trabajo Inicial* - [villanuevand](https://github.com/villanuevand)
* **Fulanito Detal** - *Documentación* - [fulanitodetal](#fulanito-de-tal)

También puedes mirar la lista de todos los [contribuyentes](https://github.com/your/project/contributors) quíenes han participado en este proyecto. 

## Licencia 📄

Este proyecto está bajo la Licencia (Tu Licencia) - mira el archivo [LICENSE.md](LICENSE.md) para detalles

## Expresiones de Gratitud 🎁

* Comenta a otros sobre este proyecto 📢
* Invita una cerveza 🍺 o un café ☕ a alguien del equipo. 
* Da las gracias públicamente 🤓.
* etc.



---
⌨️ con ❤️ por [Villanuevand](https://github.com/Villanuevand) 😊