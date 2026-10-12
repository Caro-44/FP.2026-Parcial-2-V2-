# Guía de Programación

## Console.Write y Console.WriteLine

Ambos son métodos de lenguajes como C#, los cuales
sirven para mostrar un texto en la pantalla de la consola.
La diferencia principal entre ambos es que, mientras 
"Console.Write" deja el cursor en la misma línea, 
"Console.WriteLine" añade un salto de línea al terminar
de imprimir.

Un ejemplo sería:

```csharp
Console.WriteLine("¡Hola, Carolina!");
Console.WriteLine("¡Hola, Carolina!");
Console.WriteLine("¡Hola, Carolina!"); 
```

U otro ejemplo:

```csharp
Console.Write("Hola");
Console.Write("Carolina");
Console.Write("!");
```

---------

## Secuencias de Escape

Dentro de una cadena, es posible hacer que en tanto los comandos
"Console.Write" como "Console.WriteLine", se muestren
caracteres que de otra forma no son posibles.

Existen múltiples secuencias de escape, todas inician con: `\`

Las secuencias más comunes son:
 
- `\n` (Salto de Linea): Agrega un salto de línea ("Enter") al texto.
- `\t` (Tabulación): Permite alinear bloques de texto en columnas.
- `\"` (Comillas Dobles): Si se quiere insertar una `"`, es necesario agregar una `\` antes para distinguirla del inicio y fin.
- `\\` ( Barra Invertida): La `\` es el carácter inicial de todas las secuencias y se utiliza para "escapar", quedando como `\\` cuando se quiere mostrar.

-----------

## Colores

La consola utiliza colores por defecto, por lo general suelen ser:
- **Blanco**
- **Negro**

No obstante, es posible configurar la consola para mostrar 
otros colores, haciendo uso de los siguientes métodos:

- `Console.ForegroundColor`: Permite asignar un color al texto.
- `Console.BackgroundColor: Permite agregar un color al fondo.

Es importante regresar los colores a los valores por defecto
una vez que se haya terminado:

- `Console.ResetColor()`: Regresa los colores a los valores por defecto. 

***Existen 16 colores por defecto.***

-------------

## Variables y Tipos de Datos

Tipos de datos:
- `int:` Números enteros 
- `double:` Números decimales
- `string:` Cadena de texto
- `char:` Un solo carácter
- `bool:` Verdadero o Falso
- `decimal:` Números decimales exactos (para dinero)
- `reglas:` Para nombrar variables:

-----------

## ENTRADAS Y SALIDAS
- `Console.WriteLine()` Se escribe un texto y salta la línea.
- `Console.Write()` Escribe un texto, no salta de línea.

### **Entradas:**

- `Console.ReadLine()` Lee el texto escrito por el usuario en la consola.
- `Console.ReadKey()` Lee una tecla.

-------------

## OPERADORES

**Operaciones aritméticas:**
- Suma (+)
- Resta (-)
- Multiplicación (*)
- División (/)
- Moduladores (%)
- Suma Unaria (++) - *Puede ser prefijo o sufijo.*
- Resta Unaria (--) - *Puede ser prefijo o sufijo.*

**Comparación:**
- Igual ()
- Diferente ()
- Mayor que ()
- Menor que ()
- Mayor o igual que ()
- Menor o igual que ()

**Lógicos:**
- AND (&&)
- OR (||)
- NO (!)

----------------

## CONVERSIONES

### Tipos de conversiones

1. **Conversión implícita:** Se realiza automáticamente, Rider asume que se trata de una conversión cuando NO hay pérdida de datos.
2. **Conversión explícita:** Se debe de hacer una aclaración para forzar a Rider a realizar la conversión cuando existe una posible pérdida de datos.
3. **Parse:** Convierte un `string` a otro tipo de variable (Ej. `int`, `float`). Llega a lanzar excepciones si falla.
4. **TryParse:** Convierte un `string` a otro tipo de variables, no existe excepciones. Devuelve `true` si tiene éxito, o un `false` si falla.
5. **ToString():** Convierte cualquier tipo de variable a un `string`.

-------------------

## CONDICIONALES

- `if`, `else if`, `else`: Encargado de ejecutar bloques de código según alguna condición booleana existente (`bool`).
- `switch`: Selecciona un bloque de código según las condiciones booleanas que existan.
- Operador ternario: Es una forma abreviada de un `if` o `else`. Su formato es el siguiente: `condicion ? valor_si_true: valor_si_false`

--------------------

## FLUJO PARA ANALIZAR Y RESOLVER PROBLEMAS

1. Leer y comprender el problema planteado.
2. Identificar los datos de entrada.
3. Identificar los datos de salida.
4. Se comienza a diseñar el algoritmo.
5. Definir variables
6. Identificar posibles operaciones requeridas.
7. Escribir el código utilizando los nombres descriptivos.
8. Probar el código.
9. Corregir errores.
10. Eliminar redundancias.
11. Mejorar legibilidad.

---------------------

## DEBUGGING

1. Leer mensajes de error que pueden indicar problemas en las líneas.
2. Utilizar `Console.WriteLine()` para mostrar valores intermedios.
3. Validar la entrada del usuario.
4. Probar con códigos simples para evitar confusiones en códigos más complejos.

------------------

## CICLOS

Permiten repetir acciones hasta que la condición sea verdadera y permita que el
programa continúe avanzando. 
Los componentes de un ciclo son los siguientes:

1. Estado Inicial.
2. Condición.
3. Cambio.

- **While:** Se utiliza cuando se desconoce cuántas veces se debe de ejecutar el ciclo o cuando se necesite ejecutar 0 o más veces. `while (condición) {`
- **Do-While:** Se utiliza cuando se desconoce cuántas veces se debe de ejecutar el ciclo o cuando se necesite ejecutar al menos una vez. `dó{`
- **For:** Se utiliza cuando se conoce cúantas veces se debe ejecutar. `for(inicio; condicion; cambio) {`

**Break**

Termina inmediatamente el ciclo actual, sin realizar alguna otra acción.

**Continue**

Omite el resto de la iteración y continúa con la siguiente. 

### Jerarquía:

1. `while`: Repetir mientras algo ocurra (0+).
2. `do-while`: Ejecutar al menos una vez (+1).
3. `for`: Repetir una cantidad conocida.
4. `break`: Terminar el ciclo inmediatamente. 
5. `continue`: Saltar solo la iteración actual.

------------------