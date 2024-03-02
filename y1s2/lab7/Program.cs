using Solution;
namespace Lab2 {
  public class Lab2 {
    public static void Main() {
      int match;
      do {
        System.Console.Write("\nВведіть номер блоку (1-4), 0 -> Вихід: ");
        match = int.Parse(System.Console.ReadLine());
        switch (match) {
          case 1: Block.One(); break;
          case 2: Block.Two(); break;
          case 3: Block.Three(); break;
          case 4: Block.Four(); break;
          default: break;
        }
      } while (match != 0);
    }
  }
}

