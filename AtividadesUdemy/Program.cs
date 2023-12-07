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
string r1 = "ControlId671";
string r2 = "ControlId1510";
string r3 = "Henry671";
string r4 = "Henry1510";
Console.WriteLine("Os relogios que oferecemos suporte são:");
Console.WriteLine(r1);
Console.WriteLine(r2);
Console.WriteLine(r3);
Console.WriteLine(r4);

Console.WriteLine("\nEntre com o codigo de usuario: ");
string[] ent = Console.ReadLine().Split(',');// nessa linha, a entrada do usuario foi armazenada em "ent"
string col = ent[0]; //nas linhas abaixo, por causa do comando split oque foi armazenado foi entregue em linhas separadas 
string col2 = ent[1];
string col3 = ent[2];
string col4 = ent[3];
string col5 = ent[4];
string col6 = ent[5];
string col7 = ent[6];
string col8 = ent[7];

Console.WriteLine("\nColaborador " + col);
Console.WriteLine("Colaborador " + col2);
Console.WriteLine("Colaborador " + col3);
Console.WriteLine("Colaborador " + col4);
Console.WriteLine("Colaborador " + col5);
Console.WriteLine("Colaborador " + col6);
Console.WriteLine("Colaborador " + col7);
Console.WriteLine("Colaborador " + col8);
