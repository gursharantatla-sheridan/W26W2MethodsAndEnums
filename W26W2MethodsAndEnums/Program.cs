namespace W26W2MethodsAndEnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string s = "hello";
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Before changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);

            ChangeValues(ref n, s, a);

            Console.WriteLine("\nAfter changes:");
            Console.WriteLine("n = " + n);
            Console.WriteLine("s = " + s);
            Console.WriteLine("a[0] = " + a[0]);


            // output parameter example
            int rad = 5;
            //double area, circum;

            AreaAndCircum(rad, out double area, out double circum);

            Console.WriteLine("\n\nArea = " + area);
            Console.WriteLine("Circum = " + circum);
            Console.WriteLine("\n\n");


            //Console.Write("Enter a number: ");

            //if (int.TryParse(Console.ReadLine(), out int num))
            //    Console.WriteLine("\nnum = " + num);
            //else
            //    Console.WriteLine("\nInvalid input, please try again");



            // parameter arrays example
            int x = 4, y = 6;
            Console.WriteLine("x = " + x + " y = " + y);
            Console.WriteLine($"x = {x} y = {y}");
            Console.WriteLine("x = {0} y = {1}", x, y);


            int[] myArr = { 3, 2, 4, 5, 6, 7, 87, 6, 4 };
            PrintArray(myArr);
            PrintArray(3, 4, 4, 5, 6, 76, 7, 8, 7, 6, 5, 45, 4);



            PersonInfo("John", 34);
            PersonInfo(name: "John", age: 34);
            PersonInfo(age: 34, name: "John");
            PersonInfo("John");
        }


        // named arguments / optional args
        static void PersonInfo(string name, int age = 18)
        {
            // method body
        }


        // parameter array
        static void PrintArray(params int[] arr)
        {
            Console.WriteLine("\n\nTotal number of items: " + arr.Length);

            foreach (int i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }


        // output parameters
        static void AreaAndCircum(int r, out double area, out double circum)
        {
            area = Math.PI * r * r;
            circum = 2 * Math.PI * r;
        }



        static void ChangeValues(ref int num, string str, int[] arr)
        {
            num = 100;
            str = "bye";
            arr[0] = 100;
        }
    }
}
