using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(rot13("SERR PBQR PNZC")); // Resultado: "FREE CODE CAMP"
        Console.WriteLine(rot13("SERR CVMMN!")); // Resultado: "FREE PIZZA!"
        Console.WriteLine(rot13("SERR YBIR?")); // Resultado: "FREE LOVE?"
        Console.WriteLine(rot13("GUR DHVPX OEBJA QBT WHZCRQ BIRE GUR YNML SBK.")); // Resultado: "THE QUICK BROWN DOG JUMPED OVER THE LAZY FOX."
    }

    static string rot13(string cadena)
    {
        string resultado = "";

        foreach (char caracter in cadena)
        {
            if (char.IsLetter(caracter))
            {
                char letraCifrada = caracter;

                if (char.IsUpper(caracter))
                {
                    letraCifrada = (char)(((caracter - 'A' + 13) % 26) + 'A');
                }
                else
                {
                    letraCifrada = (char)(((caracter - 'a' + 13) % 26) + 'a');
                }

                resultado += letraCifrada;
            }
            else
            {
                resultado += caracter;
            }
        }

        return resultado;
    }
}
