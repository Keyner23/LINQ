/*Taller LINQ*/


// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


/*Filtrar y mostrar solo los números pares de la lista numbers.*/

// IEnumerable<int> scoreQuery =
//     from number in numbers
//     where number %2==0
//     select number;


// foreach (var i in scoreQuery)
// {
//     Console.WriteLine(i + " ");
// }



/*Usando LINQ, calcular la suma de todos los números impares en la lista numbers.*/

// var impares =
//     from number in numbers
//     where number % 2 != 0
//     select number;

// int suma = impares.Sum();
// Console.WriteLine($"La suma de los números impares es: {suma}");



/*Ordenar de manera descendente los números mayores que 5 en la lista numbers.*/
// var n =
//     from number in numbers
//     where number > 5
//     select number;

// var ordenadoDesc = n.OrderByDescending(x => x).ToList();
// Console.WriteLine(string.Join(", ", ordenadoDesc));



/*Contar cuántos números son menores o iguales a 3 en la lista numbers.*/

// var n =
//     from number in numbers
//     where number <=3
//     select number;

// var conteo = n.Count();
// Console.WriteLine($"hay {conteo} numeros mayores o iguales a 3");



/*Seleccionar cada número en la lista numbers y multiplicarlo por 2.*/

// var n =
//     from number in numbers
//     select number;

// foreach (var i in numbers)
// {
//     Console.WriteLine($"{i} x {2} = {i * 2}");
// }



// List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Ana", "Eve" };


/*Ordenar los nombres en la lista names alfabéticamente.*/
// var n =
//     from name in names
//     select name;

// var ordenadoDesc = n.OrderBy(s => s);
// Console.WriteLine(string.Join(", ", ordenadoDesc));

/*Seleccionar los nombres en la lista names que empiezan con la letra 'A'.*/

// var n =
//     from name in names
//     where name.StartsWith("A")
//     select name;

// foreach (var i in n)
// {
//     Console.WriteLine(i);
// }


/*Contar cuántos nombres en la lista names tienen más de 5 caracteres.*/

// var n =
//     from name in names
//     where name.Length >= 5
//     select name;

// var conteo = n.Count();
// Console.WriteLine($"hay {conteo} nombres con más de 5 caracteres");


/*Concatenar todos los nombres de la lista names en una sola cadena separada por espacios.*/
// var n =
//     from name in names
//     select name;

// var concatenado = string.Join(" ", n);
// Console.WriteLine(concatenado);


/*Encontrar y mostrar el nombre más largo en la lista names.*/

// var n =
//     from name in names
//     select name;

// var nombreMasLargo = n.OrderByDescending(s => s.Length).FirstOrDefault();
// Console.WriteLine($"El nombre más largo es: {nombreMasLargo}");


List<string> words = new List<string> { "burro","apple", "banana", "cherry", "date",
"elderberry" };


/*Verificar si todas las palabras en la lista words tienen más de 3 caracteres.*/
// var n =
//     from word in words
//     select word;

// var resultado = n.All(s => s.Length > 3);
// Console.WriteLine($"¿todas las palabras tienen más de 3 caracteres? {resultado}");


/*Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.*/

// var n =
//     from word in words
//     select word;
// var primeraConB = n.FirstOrDefault(s => s.StartsWith("b"));
// Console.WriteLine($"La primera palabra que empieza con B es: {primeraConB}");


/*Contar cuántas palabras en la lista words contienen la letra 'e'.*/
// var n =
//     from word in words
//     select word;
// var conteo = n.Count(s => s.Contains("e"));
// Console.WriteLine($"hay {conteo} palabras que contienen la letra e");


/*Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.*/
// var n =
//     from word in words
//     select word;

// foreach (var item in words)
// {
//     Console.WriteLine(item.ToUpper());
// }

/*Verificar si alguna palabra en la lista words termina con la letra 'y'.*/
var n =
    from word in words
    select word;

var resultado = n.Any(s => s.EndsWith("y"));
Console.WriteLine($"¿Alguna palabra termina con la letra y? {resultado}");