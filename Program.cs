string fraseUsuario = "";

Console.Write("Escreva uma frase: ");
fraseUsuario = Console.ReadLine()!;

Console.Write("Gostaria de editar a mensagem? (s/n)");
char editar = Convert.ToChar(Console.ReadLine()!);

if (editar == 's'){
    int Função = 0;

    Console.WriteLine("1 - Adicionar ao Inicio");
    Console.WriteLine("2 - Adcionar ao fim");
    Console.WriteLine("3 - Trocar Mensagem");

    do{
        Console.Write(Environment.NewLine + "Digite o numero da função que deseja realizar: ");
        Função = Convert.ToInt32(Console.ReadLine());
    } while (Função <= 0 || Função > 3);

    switch (Função)
    { case 1:
          
        Console.WriteLine(Environment.NewLine + " Adicionar ao Inicio: ".PadLeft(30, '>'));
          
        Console.Write(Environment.NewLine + "Insira o conteúdo a ser adicionado: ");
          
        string txtadd = Console.ReadLine()!;
         
        fraseUsuario = $"{txtadd} {fraseUsuario}";

        Console.WriteLine($"{Environment.NewLine}Mensagem editada: {fraseUsuario}");
        break;
        case 2: 
        Console.WriteLine(Environment.NewLine + " Adicionar ao fim: ".PadLeft(30, '>'));
          
        Console.Write(Environment.NewLine + "Insira o conteúdo a ser adicionado: ");
          
        string txtadd2 = Console.ReadLine()!;
         
        fraseUsuario = $"{fraseUsuario} {txtadd2}";

        Console.WriteLine($"{Environment.NewLine}Mensagem editada: {fraseUsuario}");
        break;
        case 3: 
        Console.WriteLine(Environment.NewLine + " Trocar Mensagem: ".PadLeft(30, '>'));

        Console.WriteLine($"Mensagem original: {fraseUsuario}");
        Console.Write($"{Environment.NewLine}--> Insira o texto a ser substituido: ");

        string txtTroca = Console.ReadLine()!;

        Console.Write($"{Environment.NewLine}--> Insira o texto a ser colocado: ");

        string txtNovo = Console.ReadLine()!;

        fraseUsuario = fraseUsuario.Replace(txtTroca, txtNovo);
        Console.Write($"{Environment.NewLine}Mensagem editada:{fraseUsuario}");
        break;
      }
}

Console.WriteLine(Environment.NewLine + "Pressione qualquer tecla para finalizar o progama...");
Console.ReadKey(true);