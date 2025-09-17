/*Taller LINQ*/


List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


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

var n =
    from number in numbers
    select number;

foreach (var i in numbers)
{
    Console.WriteLine($"{i} x {2} = {i * 2}");
}