using System;
using System.Collections.Generic;
using System.Linq;

public class OrderRange
{
    public (List<int> pares, List<int> impares) Build(List<int> numeros)
    {
        List<int> pares = numeros.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
        List<int> impares = numeros.Where(n => n % 2 != 0).OrderBy(n => n).ToList();

        return (pares, impares);
    }

    public void ShowResult(List<int> numeros, List<int> pares, List<int> impares)
    {
        Console.WriteLine(@$"Entrada: [{string.Join(", ", numeros)}] Salida: [{string.Join(", ", pares)}] [{string.Join(", ", impares)}]");
    }

    public static void Main()
    {
        OrderRange orderRange = new OrderRange();
        List<int> numeros = null;
        (List<int> pares, List<int> impares) resultado;
        /*Ejemplo 1*/

        numeros = new List<int> { 2, 1, 4, 5 };
        resultado = orderRange.Build(numeros);

        orderRange.ShowResult(numeros, resultado.pares, resultado.impares);

        /*Ejemplo 2*/

        numeros = new List<int> { 4, 2, 9, 3, 6 };
        resultado = orderRange.Build(numeros);

        orderRange.ShowResult(numeros, resultado.pares, resultado.impares);

        /*Ejemplo 3*/

        numeros = new List<int> { 58, 60, 55, 48, 57, 73 };
        resultado = orderRange.Build(numeros);

        orderRange.ShowResult(numeros, resultado.pares, resultado.impares);
    }
}
