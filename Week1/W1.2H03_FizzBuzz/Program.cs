class Program {
    static void Main() {
        int start, end;
        start = Convert.ToInt32(Console.ReadLine());
        end = Convert.ToInt32(Console.ReadLine());

        for (var i = start; i <= end; i++) {
            string type = i switch {
                int n when (n % 3 == 0) && (n % 5 == 0) => "FizzBuzz",
                int n when n % 3 == 0 => "Fizz",
                int n when n % 5 == 0 => "Buzz",
                _ => Convert.ToString(i)
            };
            Console.WriteLine(type);
        }
    }
}
