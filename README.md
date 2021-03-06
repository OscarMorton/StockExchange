# STOCK EXCHANGE PROJECT

_Ac谩 va un p谩rrafo que describa lo que es el proyecto_

## Comenzando 馃殌

Despu茅s de haber clonado con 茅xito el repositorio y haber abierto la soluci贸n en Visual Studio, se deber谩n seguir los siguientes pasos:
### 1. Modificar la url de la base de datos local.

Para ello se debe modificar el string de conexi贸n a la base de datos local en el archivo "BagMVC/appsettings.json" de la siguiente forma:
```
"ConnectionStrings": {
    "BagContext": "Server=(localdb)\\mssqllocaldb;Database=BagContextFinal;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
```

### 2. Actualizar la base de datos con los modelos de datos de BagLib


En la "Consola del Administrador de paquetes" seleccionando el proyecto BagLib y ejecutando el comando "update-database" se consigue generar las tablas de la base de datos segun las migraciones correspondientes:
```
Versi贸n de host 6.0.0.275 de la Consola del Administrador de paquetes

Escriba 'get-help NuGet' para ver todos los comandos de NuGet disponibles.

PM> update-database
Build started...
Build succeeded.
Done.
```

### 3. Incluir la clave de la Api de AlphaVantage 馃敡

En la web de "https://www.alphavantage.co/" deberemos solicitar una clave gratuita e incluirla en el archivo "secrets.json" de la siguiente forma:

Para acceder a los secretos: Right click sobre el proyecto BAGMVC -> Administrar secretos del usuario -> Incluir lo siguiente
```
  "ApiKeys": {
    "Stocks":"APIKEY"
  } 
```
### 4. Crear un usuario en la base de datos 馃敡

Utilizando Microsoft SQL Server Management Studio se debe crear un usuario con id = 1, si no esta mierda no funciona :/

### 5. Poblar la base de datos con los Countries y las Currencies 馃敡

Para poder tener los datos de los paises y las monedas, se deben poblar estas tablas. Para ello, lanzamos la aplicaci贸n y en la View de Countries, pulsamos sobre Actualizar desde API, o lo que es lo mismo, vamos a la direcci贸n:

```
https://localhost/Countries/Update
```






## Ejecutando las pruebas 鈿欙笍

_Explica como ejecutar las pruebas automatizadas para este sistema_

### Analice las pruebas end-to-end 馃敥

_Explica que verifican estas pruebas y por qu茅_

```
Da un ejemplo
```

### Y las pruebas de estilo de codificaci贸n 鈱笍

_Explica que verifican estas pruebas y por qu茅_

```
Da un ejemplo
```

## Despliegue 馃摝

_Agrega notas adicionales sobre como hacer deploy_

## Construido con 馃洜锔?

_Menciona las herramientas que utilizaste para crear tu proyecto_

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - El framework web usado
* [Maven](https://maven.apache.org/) - Manejador de dependencias
* [ROME](https://rometools.github.io/rome/) - Usado para generar RSS

## Contribuyendo 馃枃锔?

Por favor lee el [CONTRIBUTING.md](https://gist.github.com/villanuevand/xxxxxx) para detalles de nuestro c贸digo de conducta, y el proceso para enviarnos pull requests.

## Wiki 馃摉

Puedes encontrar mucho m谩s de c贸mo utilizar este proyecto en nuestra [Wiki](https://github.com/tu/proyecto/wiki)

## Versionado 馃搶

Usamos [SemVer](http://semver.org/) para el versionado. Para todas las versiones disponibles, mira los [tags en este repositorio](https://github.com/tu/proyecto/tags).

## Autores 鉁掞笍

_Menciona a todos aquellos que ayudaron a levantar el proyecto desde sus inicios_

* **Andr茅s Villanueva** - *Trabajo Inicial* - [villanuevand](https://github.com/villanuevand)
* **Fulanito Detal** - *Documentaci贸n* - [fulanitodetal](#fulanito-de-tal)

Tambi茅n puedes mirar la lista de todos los [contribuyentes](https://github.com/your/project/contributors) qu铆enes han participado en este proyecto. 

## Licencia 馃搫

Este proyecto est谩 bajo la Licencia (Tu Licencia) - mira el archivo [LICENSE.md](LICENSE.md) para detalles

## Expresiones de Gratitud 馃巵

* Comenta a otros sobre este proyecto 馃摙
* Invita una cerveza 馃嵑 o un caf茅 鈽? a alguien del equipo. 
* Da las gracias p煤blicamente 馃.
* etc.



---
鈱笍 con 鉂わ笍 por [Villanuevand](https://github.com/Villanuevand) 馃槉