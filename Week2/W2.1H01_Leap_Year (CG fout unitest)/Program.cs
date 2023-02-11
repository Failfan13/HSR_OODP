namespace LeapYear{
    public class Program {
        public static void Main() {
            int input = Convert.ToInt32(Console.ReadLine());

            PrintIsLeapYear(input);
        }

        public static void PrintIsLeapYear(int year) {
            if (IsLeapYear(year) == true) {
                Console.WriteLine($"{year} is a leap year");
            } else {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
        public static bool IsLeapYear(int year) {

            bool by4, by100, by400;
            by4 = IsDivisibleBy(year, 4);
            by100 = IsDivisibleBy(year, 100);
            by400 = IsDivisibleBy(year, 400);

            if ((by4 == true && by100 == false) || by400 == true) {
                return true;
            } else {
                return false;
            };
        }
        public static bool IsDivisibleBy(int year, int devisNum) {
            return (year % devisNum == 0 ? true : false);
        }
    }
}