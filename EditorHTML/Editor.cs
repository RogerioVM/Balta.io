using System.Runtime.InteropServices.ComTypes;
using System.Text;
public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("MODO EDITOR:");
        Console.WriteLine("=======================================");
        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        
        Console.WriteLine("=======================================");
        Console.WriteLine("Deseja salvar o arquivo? (S) sim (N) não");
        Viewer.Show(file.ToString()); 
    }

    public static void SaveFile(string text)
    {
        Console.WriteLine("Qual o caminho do arquivo? ");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();
    }
}
