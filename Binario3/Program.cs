internal class Program
{
    private static void Main(string[] args)
    {
        int valor = 0;
        int resto;
        int quociente = 1;
        int[] binario = new int[8];
        int[] convertido = new int[8];
        int cont = binario.Length - 1;

        Console.WriteLine("Informe o número a ser convertido para binário");
        valor = int.Parse(Console.ReadLine());
        conversorBinario(valor);

        int[] conversorBinario(int valor)
        {

            resto = valor % 2;
            binario[cont] = resto;
            quociente = (valor / 2);
            valor = quociente;
            cont--;
            if (cont >= 0)
            {
                return conversorBinario(valor);
            }


            return binario;

        }

        Console.WriteLine("Binario: ");
        for (int i = 0; i <= binario.Length - 1; i++)
        {
            Console.WriteLine(binario[i] + " "); ;
        }





    }
}