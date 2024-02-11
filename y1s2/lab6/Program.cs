class Program {
  public static void Main() { 
    Console.WriteLine("Введіть сукупність чисел: ");
    int[] array = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
    Console.Write("\nMain - 1;\nExtras - 2..4;\nChoose: ");
    no:
    int input = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (input)
    {
      case 1:
        MaxWidth(array);
        break;
      case 2:
        MaxArea(array);
        break;
      case 3:
        break;
      case 4:
        break;
      default:
        goto no;
    }
  }

  private static void MaxWidth(int[] array) {
    array = sort(array);
    int max = 0, index = 0;
    Console.WriteLine("Відсортований масив:");
    print_array(array);
    for (int i = 0; i < array.Length - 1; i++) {
      int len = array[i+1] - array[i];
      if (max < len) { max = len; index = i;}
    }
    Console.WriteLine($"\nНайширший прохід має ширину '{max}' ({array[index]}, {array[index+1]})");
  }
 
  private static void MaxArea(int[] arr) {
    double max = 0.0;
    int index = arr.Length;
    arr = sort(arr);
    Console.WriteLine("sorted:");
    print_array(arr);
    for (int i = arr.Length-1; i > 2; i--)
    {
      int a=arr[i], b=arr[i-1], c=arr[i-2];
      if (a-b-c < 0) {
        int p = (a+b+c)/2;
        double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        System.Console.WriteLine($"{area}");
        if (max < area) {max = area; index = i;}
      }
    }
    if (max != 0) {
    Console.WriteLine($"\nНайбільшу площу має т-к: {arr[index]} {arr[index-1]} {arr[index-2]} '{max}'");
    } else {
      System.Console.WriteLine($"\nНеможливо утворити трикутник");
    }
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

  private static void swap(int[] arr, int i, int j) 
  {
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
  }
}
