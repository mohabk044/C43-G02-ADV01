namespace Demo
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region Before Generics 
            //int A = 3, B = 5;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //----------------------------

            //double A = 3, B = 5;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //-----------------------------
            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(2, 3);

            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");
            //Helper.SWAP(ref P1, ref P2);
            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");

            //-----------------------------
            //object P1 = new Point(1, 2);
            //object P2 = new Point(2, 3);

            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");
            //Helper.SWAP(ref P1, ref P2);
            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");

            //-------------------------------
            //object A = 3.6, B = 5.9;       //// Boxing
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //-------------------------------
            //object A = 3, B = 5;           //// Boxing
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //-------------------------------
            #endregion

            #region After Generics 
            //int A = 3, B = 5;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP<int>(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //-------------------------------

            //double A = 3.4, B = 5.9;
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");
            //Helper.SWAP<double>(ref A, ref B);
            //Console.WriteLine($"A = {A}");
            //Console.WriteLine($"B = {B}");

            //-------------------------------

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(2, 3);

            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");
            //Helper.SWAP<Point>(ref P1, ref P2);
            //Console.WriteLine($"P1 = {P1}");
            //Console.WriteLine($"P2 = {P2}");

            //-------------------------------
            #endregion

            #region Search Example
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //int Position = Helper.SearchArray(Numbers, 5);
            //Console.WriteLine(Position);

            //-----------------------------------

            Employee employee01 = new Employee(10, "Mohab", 3000);
            Employee employee02 = new Employee(5, "Ali", 7000);
            Employee employee03 = new Employee(7, "shimaa", 9000);

            Employee[] employees =
            {
                employee01, employee02, employee03
            };

            int Position = Helper<Employee>.SearchArray(employees, employee03);
            Console.WriteLine(Position);

            //-----------------------------------
            #endregion

            #region Example bubble sort
            int[] Num = { 2, 5, 3, 1, 6 };
            Helper<int>.BubbleSort(Num);
            foreach (int i in Num)
            {
                Console.WriteLine(i);
            }
            #endregion


            #region Icomparable  
            //Point[] points = new Point[]
            //{
            //    new Point(20,30),
            //    new Point(10,20),
            //    new Point(1,2),
            //    new Point(2,3)
            //};

            //Helper<Point>.BubbleSort(points);
            //foreach (Point point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Employee employee = new Employee() {ID = 1 , Name = "Mohab"  , Salary = 9000};
            //Employee employee2 = new Employee() { ID = 2, Name = "Ali" , Salary=4500};
            //Employee employee3 = new Employee() { ID = 3, Name = "Soha", Salary = 6000 };
            //Employee[] employees = new Employee[] { employee, employee2, employee3 };
            //Helper<Employee>.BubbleSort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

        }
    }
}
