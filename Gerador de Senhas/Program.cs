// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("=".PadLeft(17, '='));
Console.WriteLine("GERADOR DE SENHAS");
Console.WriteLine("=".PadLeft(17, '='));
Console.ResetColor();
Thread.Sleep(2000);
Console.Clear();

return1:
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("Você deseja que sua senha tenha quantos caracteres?");
Console.ResetColor();

Console.Write("R:");
if(int.TryParse(Console.ReadLine(), out int caracteres)) {
    Console.Clear();
    return2:
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Você deseja que sua senha tenha números? (Digite 's' para 'sim' ou 'n' para 'não')");
    Console.ResetColor();

    Console.Write("R:");
    string num = Console.ReadLine().ToLower();
    if((num == "s") || (num == "n")) {

        Console.Clear();
        return3:
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("Você deseja que sua senha tenha letras? (Digite 's' para 'sim' ou 'n' para 'não')");
        Console.ResetColor();

        Console.Write("R:");
        string letra = Console.ReadLine().ToLower();
        if((letra == "s") || (letra == "n")) {

        }
        else {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Valor inválido. Tente novamente.");
            Thread.Sleep(1500);
            Console.ResetColor();
            Console.Clear();
            goto return3;
        }

    }
    else {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Valor inválido. Tente novamente.");
        Thread.Sleep(1500);
        Console.ResetColor();
        Console.Clear();
        goto return2;
    }

}
else {
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Valor inválido. Tente novamente.");
    Thread.Sleep(1500);
    Console.ResetColor();
    Console.Clear();
    goto return1;
}
