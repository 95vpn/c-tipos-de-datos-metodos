# Tipos de datos c# - Metodos

## Tipos de Datos
```csharp
Unsigned integral types
byte  : 0 to 255
ushort: 0 to 65535
uint  : 0 to 4294967295
ulong : 0 to 18446744073709551615

Floating point types:
float  : -3.4028235E+38 to 3.4028235E+38 (with ~6-9 digits of precision)
double : -1.7976931348623157E+308 to 1.7976931348623157E+308 (with ~15-17 digits of precision)
decimal: -79228162514264337593543950335 to 79228162514264337593543950335 (with 28-29 digits of precition)

```

## Cambiar tipos de datos
**Conversión de Ampliación**
Un valor almacenado en una variable de tipo int convertida a una variable de tipo decimal no pierde información.

**Conversión de restriccion**
Convertir un valor de un tipo de datos que puede contener mas información a un tipo dxe datos que puede contener menos información.

**ToString():**  convierte tipos de datos numericos a string.
**Parse():** convierte un cadena en tipos de datos indicado `int.Parse()`.
**Convert:** tiene muchos metodos auxiliares para convertir un valor de un tipo a otro.
**TryParse():** analiza una cadena en el tipo de datos numerico dado. Si tiene éxito, almacena el valor convertido en un parametro de salida. Devuelve un bool para indicar si la acción tuvo exito o falló. 
`(int.TryParse(value), out result)`

## Operaciones en matrices
La clase `Array` contiene metodos que puede utilizar para manipular el contenido, las disposición y el tamaño de una matriz.

**Sort():** método de la clase Array para ordenar los elementos de la matriz alfanumericamente.
**Reverse():** método de la clase Array para invertir el orden de los elementos.
**Array.Clear():** permite eliminar el contenido de elementos específicos de la matriz y reemplazarlos con el valor predetermnado de la matriz. (Si borra un elemento de la matriz string, el valor borrado se reemplaza con `null`, cuando se borra un elemento de la matriz int el remplazo es `0`) `Array.Clear(arreglo, inicio, fin)`
**Resize():** método que pasa la matriz por la referencia, usando la palabra clave `ref,` se utiliza para cambiar el tamaño de una matriz unidimensional `Array.Resize(ref matriz, nuevoTamañoDeLaMatriz)`
**ToCharArray():** método que utiliza para crear una matriz de `char`, donde cada elemento de la matriz representa un carater de la cadena original.
**Join():** separa cada elementos de la matriz de carateres. `String.Join(delimitador,  matriz)`
**Split():** divide una cadena en una matriz de cadenas usando un delimitador `cadena.Split(delimitador)`.

## Formato de Cadenas
Formato compuesto
Utiliza marcadores numerados dentro de una cadena.

**String.Format() : **
```csharp
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}", first, second);
```
### Interpolación de cadenas
Es una técnica se simplifica el formato compuesto. Para que se pueda interpolar una cadena debe anteponerle la directiva `$`
`Console.WriteLine($"{first} {second}")`;

#### Formatos
- **Formato Moneda: ** Se usa el especificador de formato cadena `:C`;
- **Formato Numerico:** Se usa el especificador de formato numerico `:N`;
- **Formato de Porcentaje:** Se usa el especificador de formato `:P` para dar formato a los porcentajes y redondearlos a 2 decimales.

## Métodos 
- **PadLeft(), PadRight():** Métodos que agregan espacios en blanco para fines de formato. 
- **Trim():** elimina todos los espacios en blanco  al inicio y al final de la cadena.
- **TrimStart():** elimina todos los espacios en blanco al inicio de la cadena.
- **TrimEnd():** elimina los espacios en blanco al final de la cadena.
- **GetHashCode():** devuelve un entero (código hash) que representa el contenido de la cadena.
- **Length():** devuelve la cantidad de caracteres de una cadena.
- **Contains():** determina si una cadena contiene una subcadena especifica.
-  **StartsWith():** verifica si una cadena comienza con una subcadena específica.
- **EndsWith():** verifica si una si una cadena termina con una subcadena específica.
- **SubsString():** permite recuperar una parte específica de una cadena, extrayendo caracteres desde una pisición inicial hasta una longitud especificada.
