//O seguinte código usa sequências de caracteres de escape para adicionar linhas e guias:
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
//Saída:
Hello
World!
Hello   World!

//Para lidar com isso, use a sequência de escape \":
Console.WriteLine("Hello \"World\"!");
//Saída:
Hello "World"!

//E se você precisar usar a barra invertida para outras finalidades, como exibir um caminho de arquivo?
Console.WriteLine("c:\source\repos");
//Saída erro:
(1,22): error CS1009: Unrecognized escape sequence
//Para resolver o problema, use \\ para exibir uma barra invertida simples:
Console.WriteLine("c:\\source\\repos");
//Saída:
c:\source\repos
