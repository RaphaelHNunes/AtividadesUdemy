using System.Globalization;

//string[] inf = Console.ReadLine().Split(' ');
//string nome = inf[0];
//int quartos = int.Parse(inf[1]);
//float preco = float.Parse(inf[2], CultureInfo.InvariantCulture);
//Console.WriteLine(nome);
//Console.WriteLine(quartos);
//Console.WriteLine(preco);

//ToString e console.writeline são metodos.

//Console.WriteLine("Entre com seu nome completo:");
//string nome = Console.ReadLine();
//Console.WriteLine("Quantos quartos tem na sua casa? ");
//int quartos = int.Parse(Console.ReadLine());
//Console.WriteLine("Entre com o preço de um produto: ");
//float preco = float.Parse(Console.ReadLine());

//Console.WriteLine("Seu ultimo nome, idade e altura: ");
//string[] inf2 = Console.ReadLine().Split(' ');
//string sobren= inf2[0];
//int idade = int.Parse(inf2[1]);
//double altura = double.Parse(inf2[2]); //para o usuario realizar a entrada com ponto
//Console.WriteLine(nome);
//Console.WriteLine(quartos);
//Console.WriteLine(preco);
//Console.WriteLine(sobren);
//Console.WriteLine(idade);
//Console.WriteLine(altura);

//---------------------------------------------------------------------------------------------------------------------------

//string[] reps =
//{
//    "ControlId671",
//     "ControlId1510",
//     "Henry671",
//     "Henry1510"
//};
//Console.WriteLine("Os relogios que oferecemos suporte são:");
//for (int i = 0; i < reps.Length; i++)
//{
//    Console.WriteLine(reps[i]);
//}

//Console.WriteLine("\nEntre com o codigo de usuario: ");
//string[] ent = Console.ReadLine().Split(',');// nessa linha, a entrada do usuario foi armazenada em "ent"

//for (int j = 0; j < ent.Length; j++)
//{
//    Console.WriteLine(ent[j]);
//}

//----------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("\nEntre com os relogios: ");
string[] reps = Console.ReadLine().Split(' ');

Console.WriteLine("\nEntre com codigos de usuarios: ");
int[] codigos = Console.ReadLine()
    .Split(',')
    .Select(int.Parse)
    .ToArray();

Console.WriteLine("\nInforme para qual relogio voce deseja enviar os colaboradores: ");
string relogio = Console.ReadLine();
if (reps.Contains(relogio))
{
    Console.WriteLine($"Relogio: {relogio}");
    Console.WriteLine($"Colaboradore: {string.Join(",",codigos)}");
}

else
{
    Console.WriteLine("Nao oferecemos suporte para esse relogio.");
}