namespace BlockFour {
  public class Block4 {
    public static void Solution() {
      string[] temp = System.Console.ReadLine().Split();
      int height = int.Parse(temp[0]), length = int.Parse(temp[1]);
      int[][] matrix = new int[Math.Max(height, length)][];
      System.Console.WriteLine($"\nInput a matrix {height}x{length}:");

      for (int i = 0; i < height; i++)
      {
        matrix[i] = Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);
      }

      /* todo: flip_matrix() */ 

      int[] null_counter = new int[length];
      for (int i = 0; i < length; i++) {
        for (int j = 0; j < height; j++) {if (matrix[i][j]==0) null_counter[i]++;}
      }
      
      for (int i = 1; i < length; i++)
      {
        var save = matrix[i];
        int save_nc = null_counter[i];
        for (int j = i-1; j >= 0;)
        {
          if (save_nc < null_counter[j]) {
            null_counter[j+1] = null_counter[j];
            null_counter[j] = save_nc;
            matrix[j+1] = matrix[j];
            matrix[j] = save;
            j--;
          } else {
            break;
          }
        }
      }

      //  1 0 0 0   13 <- a 0
      //  2 0 0 1   12 <- b 1
      //  0 2 2 1   11 <- c 2 
      //  0 0 0 0   14 <- d 3
      //  
      //  b, 12
      //  12 13
      //  11 13 12
      //
      //
      //
      //
      //
      //
      //
      //


      System.Console.WriteLine("Resulting matrix:");
      for (int i = 0; i < height; i++) {
        for (int j = 0; j < length; j++) {
          System.Console.Write($"{matrix[j][i],2} ");
        }
        System.Console.WriteLine();
      }
    }
  }
}
