public static class Menu
{
     public static void Show()
     {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        DrawScreen(30);
        WriteOptions();
        var option = short.Parse(Console.ReadLine());
        HandleMenuOptions(option);
     }
     public static void DrawScreen(int limit)
     {
          Loop(limit);
          Lines(limit);
          Loop(limit);
     }
     public static void HandleMenuOptions(short option)
     {
          switch (option)
          {
               case 1: Editor.Show(); break;
               case 2: Console.WriteLine("View"); break;
               case 0: 
               {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
               }; 

               default: Show(); break;
          }
     }

     public static void WriteOptions()
     {
          Console.SetCursorPosition(3,2);
          Console.WriteLine("Editor HTML");
          Console.SetCursorPosition(3,3);
          Console.WriteLine("=========================================");
          Console.SetCursorPosition(3,4);
          Console.WriteLine("Seleciona uma opção abaixo:");
          Console.SetCursorPosition(3,6);
          Console.WriteLine("1 - Novo arquivo");
          Console.SetCursorPosition(3,7);
          Console.WriteLine("2 - Abrir");
          Console.SetCursorPosition(3,8);
          Console.WriteLine("3 - Sair");
          Console.SetCursorPosition(3,10);
          Console.WriteLine("Opção: ");
          
     }
     public static void Loop(int limit)
     {
          Console.Write("+");
          for (int i = 0; i <= limit; i++)
                   Console.Write("-");
          Console.Write("+");
          Console.Write("\n");
     }
     public static void Lines(int limit)
     {
          for (int lines = 0; lines <= limit; lines++)
          {
               Console.Write("|");
               for (int i = 0; i <= limit; i++)
                    Console.Write(" ");
               Console.Write("|");
               Console.Write("\n");
          }
     }
}
