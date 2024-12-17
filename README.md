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
