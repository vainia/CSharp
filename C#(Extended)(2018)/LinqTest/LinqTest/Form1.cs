using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqTest
{
    delegate void TestProc(StringBuilder sb);
    public partial class Form1 : Form
    {
        //private static Dictionary<string, TestProc> list = new Dictionary<string, TestProc>
        //{
        //    {"TestA", TestA },
        //    {"TestB", TestB },
        //    {"TestC", TestC },
        //    {"TestD", TestD },
        //    {"Test1", Test1 },
        //    {"Test2", Test2 },
        //    {"Test3", Test3 },
        //    {"Test4", Test4 },
        //    {"Test5", Test5 },
        //    {"Test6", Test6 },
        //    {"Test7", Test7 },
        //    {"Test8", Test8 },
        //    {"Test9", Test9 },
        //    {"Test10", Test10 },
        //    {"Test11", Test11 },
        //    {"Test12", Test12 },
        //    {"Test13", Test13 },
        //};
        public Form1()
        {
            InitializeComponent();
            var methods = typeof(Form1).GetMethods()
                .Where(item => item.IsStatic)
                .Where(item => item.ReturnType==typeof(void))
                .Where(item => item.GetParameters().Count() == 1)
                .Where(item => item.GetParameters()[0].ParameterType==typeof(StringBuilder))
                .Select(item => item.Name);
            foreach (var item in methods) BoxTest.Items.Add(item);
            BoxTest.SelectedIndex = 0;
        }
        private static string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        private static int[] numbersB = { 1, 3, 5, 7, 8 };
        public static void TestA(StringBuilder sb)
        {
            var shortDigits = digits.Where((digit, index) => digit.Length<index);
            foreach (var item in shortDigits) sb.Append(item).Append(" ");
        }
        public static void TestB(StringBuilder sb)
        {
            var numConv = from n in numbers select 100 + 2 * n;
            foreach (var item in numConv) sb.Append(item).Append(" ");
        }
        public static void TestC(StringBuilder sb)
        {
            var numConv = from n in numbers select new { n,value = 100 + 2 * n };
            foreach (var item in numConv) sb.Append(item.n).Append(":").Append(item.value).Append(" ");
        }
        public static void TestD(StringBuilder sb)
        {
            var lowNum = from n in numbers where n <= 6 && n%2 > 0  select digits[n];
            foreach (var item in lowNum) sb.Append(item).Append(" ");
        }
        public static void Test1(StringBuilder sb)
        {
            var lowNum = from n in numbers orderby n descending select digits[n];
            foreach (var item in lowNum) sb.Append(item).Append(" ");
        }
        public static void Test2(StringBuilder sb)
        {
            var lowNum = from n in numbers select new { num = n, word = digits[n], count = numbers.Count() + n };
            foreach (var item in lowNum) sb.Append(item.num).Append("-").Append(item.word).Append("-").Append(item.count).Append(" ");
        }
        public static void Test3(StringBuilder sb)
        {
            var numbers_ = from n in numbers select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            foreach (var n in numbers_) sb.Append("The number ").Append(n.Number).Append(" is ").Append(n.OddEven).Append(". ").Append(Environment.NewLine);
        }
        public static void Test4(StringBuilder sb)
        {
            var upperLowerWords = from w in digits select new { Upper = w.ToUpper(), Lower = w.ToLower() };

            foreach (var ul in upperLowerWords) sb.Append("Uppercase: ").Append(ul.Upper).Append(", Lowercase: ").Append(ul.Lower).Append(Environment.NewLine);
        }
        public static void Test5(StringBuilder sb)
        {
            var pairs = from a in numbers from b in numbersB where a < b select new { a, b };

            sb.Append("Pairs where a < b:").Append(Environment.NewLine);

            foreach (var pair in pairs) sb.Append(pair.a).Append(" is less than ").Append(pair.b).Append(Environment.NewLine);
        }
        public static void Test6(StringBuilder sb)
        {
            var nums = numbers.OrderBy(num=>num).SelectMany((n, nIndex) => digits[n].Select(o => "Digit #" + (nIndex) + " : " + o + Environment.NewLine));

            foreach (var item in nums) sb.Append(item).Append(" ");
        }
        public static void Test7(StringBuilder sb)
        {
            var uniqueNumbers = numbers.Union(numbersB);

            sb.Append("Unique numbers from both arrays:").Append(Environment.NewLine);

            foreach (var n in uniqueNumbers) sb.Append(n).Append(Environment.NewLine);
        }
        public static void Test8(StringBuilder sb)
        {
            var commonNumbers = numbers.Intersect(numbersB);

            sb.Append("Common numbers shared by both arrays:").Append(Environment.NewLine);

            foreach (var n in commonNumbers) sb.Append(n).Append(Environment.NewLine);
        }
        public static void Test9(StringBuilder sb)
        {
            IEnumerable<int> aOnlyNumbers = numbers.Except(numbersB);

            sb.Append("Numbers in first array but not second array:").Append(Environment.NewLine);

            foreach (var n in aOnlyNumbers) sb.Append(n).Append(Environment.NewLine);
        }
        public static void Test10(StringBuilder sb)
        {
            int fourthLowNum = (from n in numbers where n > 5 select n) .ElementAt(1);

            sb.Append("Second number > 5: ").Append(fourthLowNum).Append(Environment.NewLine);
        }
        public static void Test11(StringBuilder sb)
        {
            var first3Numbers = numbers.Take(3);

            sb.Append("First 3 numbers:").Append(Environment.NewLine);

            foreach (var n in first3Numbers) sb.Append(n).Append(Environment.NewLine);
        }
        public static void Test12(StringBuilder sb)
        {
            var allButFirst4Numbers = numbers.Skip(4);

            sb.Append("All but first 4 numbers:").Append(Environment.NewLine);

            foreach (var n in allButFirst4Numbers) sb.Append(n).Append(Environment.NewLine);
        }
        public static void Test13(StringBuilder sb)
        {
            var allButFirst3Numbers = numbers.SkipWhile(n => n % 3 != 0);

            sb.Append("All elements starting from first element divisible by 3:").Append(Environment.NewLine);

            foreach (var n in allButFirst3Numbers) sb.Append(n).Append(Environment.NewLine);
        }
    private void BtnExecute_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = (string)BoxTest.Items[BoxTest.SelectedIndex];

            MethodInfo method = typeof(Form1).GetMethod(name);

            method.Invoke(null, new object[] { sb });

            Log.Text = sb.ToString();

            //if (list.ContainsKey(name))
            //{
            //    list[name](sb);
            //    Log.Text = sb.ToString();
            //}
        }
        //https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
    }
}
