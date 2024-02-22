class Program {
  public static void Main() {
    double[] arr;
    no: 
    Console.Write("\nMain - 1;\nExtras - 2, 3, 4;\nChoose: ");
    int input = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (input)
    {
      case 1:
        Console.WriteLine("4. Дана сукупність n цілих чисел, що\n   являє собою координати точок на деякій координатній прямій.\n   Знайдіть найширший з проходів.");
        MaxInterval(input_array());
        break;
      case 2:
        Console.WriteLine("18. Дано дві сукупності цілих додатних чисел.\n    Одна виражає ширини прогалин, які потрібно перекрити мостами.\n    Інша виражає довжини мостів. Яку кількість прогалин можливо перекрити мостами?");
        MaxHolesCovered(input_array(), input_array());
        break;
      case 3:
        Console.WriteLine("19. Дано сукупність з n≥4 дійсних додатних чисел,\n    що являють собою довжини відрізків.\n    Які відрізки слід вибрати, щоб трикутник мав найбільшу площу?");
        int i;
        Console.Write("\n    Введіть сукупність чисел: ");
        arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);
        double answer = MaxAreaTriangle(arr, out i);
        if (answer > 0.0) {
          Console.WriteLine($"\nНайбільшу площу має т-к: ({arr[i]}, {arr[i-1]}, {arr[i-2]}) - '{answer:0.#2}'");
        } else {
          Console.WriteLine($"\nНеможливо утворити трикутник");
        }
        break;
      case 4:
        Console.WriteLine("20. Дано сукупність з n (n≥4) дійсних додатних чисел,\n    що являють собою довжини відрізків.\n    Скільки є різних способів сформувати невироджений трикутник?");
        Console.WriteLine("\n    Введіть сукупність чисел: ");
        arr = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToDouble);
        CountTriangles(arr);
        break;
      default:
        Console.WriteLine("bad input");
        goto no;
    }
  }

  private static void MaxInterval(int[] array) {
    array = sort(array);
    int max = 0, index = 0;
    for (int i = 0; i < array.Length - 1; i++) {
      int len = array[i+1] - array[i];
      if (max < len) { max = len; index = i;}
    }
    Console.WriteLine($"\nНайширший прохід має ширину '{max}' ({array[index]}, {array[index+1]})");
  }
 
  private static void MaxHolesCovered(int[] holes, int[] bridges) {
    int counter = 0;
    holes = sort(holes);
    bridges = sort(bridges);
    for (int i = holes.Length-1; i>=0; i--) {
      for (int j = bridges.Length-1-counter; j>=0; j--)
      {
        if (bridges[j]>holes[i]) {
          counter++;
          System.Console.WriteLine($"міст '{bridges[j]}' -> яма '{holes[i]}'");
          break;
        }
      }
    }
    Console.WriteLine($"\nМаксимальна кількість перекритих прогалин: {counter}");
  }

  private static double MaxAreaTriangle(double[] arr, out int i) {
    arr = sort_double(arr);
    for (i = arr.Length-1; i > 2; i--)
    {
      double a=arr[i], b=arr[i-1], c=arr[i-2];
      if (a-b-c < 0) {
        double p = (a+b+c)/2.0;
        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
      }
    }
    return 0.0;
  }

  private static void CountTriangles(double[] arr) {
    int counter = 0;
    arr = sort_double(arr);
    for (int i = arr.Length - 1; i >= 2 ; i--)
    {
      for (int j = i-1; j >= 1 ; j--)
      {
        for (int k = j-1; k >= 0 ; k--)
        {
          if (arr[i]-arr[j]-arr[k] < 0) {
            Console.WriteLine($"-> ({arr[i]}, {arr[j]}, {arr[k]})");
            counter++;
          }
        }
      }   
    }
    Console.WriteLine($"\nКількість різних невироджених трикутників: {counter}");
  }
  
  private static void build(int[] arr, int n)
  {
    for (int i = 1; i < n; i++)
    {
      if (arr[i] > arr[(i - 1) / 2])
      {
        int j = i;
        while (arr[j] > arr[(j - 1) / 2])
        { 
          swap(arr, j, (j - 1) / 2);
          j = (j - 1) / 2;
        }
      }
    }
  }
   
  private static int[] sort(int[] arr)
  {
    int n = arr.Length;
    build(arr, n);
    for (int i = n - 1; i > 0; i--)
    {
      swap(arr, 0, i);
      int temp;
      int j = 0;
      do
      {
        temp = j*2+1;
        if (temp < i-1 && arr[temp] < arr[temp+1]) { temp++; }
        if (temp < i && arr[j] < arr[temp]) { swap(arr, j, temp); }
        j = temp;
      } while (temp < i);
    }
    return arr;
  }
  
  private static void build_double(double[] arr, int n)
  {
    for (int i = 1; i < n; i++)
    {
      if (arr[i] > arr[(i - 1) / 2])
      {
        int j = i;
        while (arr[j] > arr[(j - 1) / 2])
        { 
          swap(arr, j, (j - 1) / 2);
          j = (j - 1) / 2;
        }
      }
    }
  }
   
  private static double[] sort_double(double[] arr)
  {
    int n = arr.Length;
    build_double(arr, n);
    for (int i = n - 1; i > 0; i--)
    {
      swap(arr, 0, i);
      int j = 0, temp;
      do
      {
        temp = j*2+1;
        if (temp < i-1 && arr[temp] < arr[temp+1]) { temp++; }
        if (temp < i && arr[j] < arr[temp]) { swap(arr, j, temp); }
        j = temp;
      } while (temp < i);
    }
    return arr;
  }

  private static void print_array(int[] arr) {
    foreach (var item in arr) { Console.Write($"{item} "); }
    Console.WriteLine();
  }

  private static void swap<T>(T[] arr, int i, int j) 
  {
    T temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
  }

  private static int[] input_array() {
    Console.Write("\n   Введіть сукупність чисел: ");
    return Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
  }
}
