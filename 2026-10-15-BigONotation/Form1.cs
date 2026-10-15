namespace BigONotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // O(1)
            rtbO1Ex1.Text = "int[] numbers = { 10, 20, 30, 40, 50 };\nint answer = numbers[2];\nConsole.WriteLine(answer);";
            rtbO1Ex2.Text = "int a = 10;\nint b = 20;\nint sum = a + b;\nConsole.WriteLine(sum);";
            rtbO1Ex3.Text = "string[] fruits = { \"Apple\", \"Banana\", \"Mango\" };\nstring fruit = fruits[0];\nConsole.WriteLine(fruit);";
            // O(n)
            rtbOnEx1.Text = "int[] numbers = { 10, 20, 30, 40, 50 };\nfor (int i = 0; i < numbers.Length; i++)\n{\n    Console.WriteLine(numbers[i]);\n}";
            rtbOnEx2.Text = "string[] names = { \"Ana\", \"Ben\", \"Carlo\", \"David\" };\nforeach (string name in names)\n{\n    if (name == \"Carlo\")\n    {\n        Console.WriteLine(\"Found!\");\n    }\n}";
            rtbOnEx3.Text = "int[] numbers = { 5, 10, 15 };\nint total = 0;\nforeach (int number in numbers)\n{\n    total = total + number;\n}\nConsole.WriteLine(total);";
            // O(log n)
            rtbOlogEx1.Text = "int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };\nint left = 0;\nint right = numbers.Length - 1;\nwhile (left <= right)\n{\n    int middle = (left + right) / 2;\n    if (numbers[middle] == 50)\n    {\n        Console.WriteLine(\"Found!\");\n        break;\n    }\n    else if (numbers[middle] < 50)\n        left = middle + 1;\n    else\n        right = middle - 1;\n}";
            rtbOlogEx2.Text = "int n = 16;\nwhile (n > 1)\n{\n    n = n / 2;\n    Console.WriteLine(n);\n}";
            rtbOlogEx3.Text = "int low = 1;\nint high = 100;\nwhile (low <= high)\n{\n    int middle = (low + high) / 2;\n    Console.WriteLine(middle);\n    high = middle - 1;\n}";
            // O(n²)
            rtbOn2Ex1.Text = "int[] numbers = { 1, 2, 3, 4, 5 };\nfor (int i = 0; i < numbers.Length; i++)\n{\n    for (int j = 0; j < numbers.Length; j++)\n    {\n        Console.WriteLine(numbers[i] + \" \" + numbers[j]);\n    }\n}";
            rtbOn2Ex2.Text = "int[] numbers = { 1, 2, 3 };\nfor (int i = 0; i < numbers.Length; i++)\n{\n    for (int j = 0; j < numbers.Length; j++)\n    {\n        Console.WriteLine(numbers[i] + \" \" + numbers[j]);\n    }\n}";
            rtbOn2Ex3.Text = "string[] students = { \"Ana\", \"Ben\", \"Carlo\" };\nfor (int i = 0; i < students.Length; i++)\n{\n    for (int j = 0; j < students.Length; j++)\n    {\n        Console.WriteLine(students[i] + \" checks \" + students[j]);\n    }\n}";
            // O(2^n)
            rtbO2nEx1.Text = "int n = 3;\nint combinations = 1;\nfor (int i = 0; i < n; i++)\n{\n    combinations = combinations * 2;\n}\nConsole.WriteLine(\"Number of combinations: \" + combinations);";
            rtbO2nEx2.Text = "int tosses = 5;\nint possibilities = 1;\nfor (int i = 0; i < tosses; i++)\n{\n    possibilities *= 2;\n}\nConsole.WriteLine(\"Possible results: \" + possibilities);";
            rtbO2nEx3.Text = "int positions = 4;\nint possibilities = 1;\nfor (int i = 0; i < positions; i++)\n{\n    possibilities *= 2;\n}\nConsole.WriteLine(\"Possible passwords: \" + possibilities);";
        }

        private void btnO1Ex1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int answer = numbers[2];
            lblO1Ex1.Text = "Output: " + answer;
        }

        private void btnO1Ex2_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;
            int sum = a + b;
            lblO1Ex2.Text = "Output: " + sum;
        }

        private void btnO1Ex3_Click(object sender, EventArgs e)
        {
            string[] fruits = { "Apple", "Banana", "Mango" };
            string fruit = fruits[0];
            lblO1Ex3.Text = "Output: " + fruit;
        }

        private void btnOnEx1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i] + "\n";
            }
            lblOnEx1.Text = "Output:\n" + result;
        }

        private void btnOnEx2_Click(object sender, EventArgs e)
        {
            string[] names = { "Ana", "Ben", "Carlo", "David" };
            string result = "";
            foreach (string name in names)
            {
                if (name == "Carlo")
                {
                    result = "Found!";
                }
            }
            lblOnEx2.Text = "Output: " + result;
        }

        private void btnOnEx3_Click(object sender, EventArgs e)
        {
            int[] numbers = { 5, 10, 15 };
            int total = 0;
            foreach (int number in numbers)
            {
                total = total + number;
            }
            lblOnEx3.Text = "Output: " + total;
        }

        private void btnOlogEx1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70 };
            int left = 0;
            int right = numbers.Length - 1;
            string result = "";
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (numbers[middle] == 50)
                {
                    result = "Found!";
                    break;
                }
                else if (numbers[middle] < 50)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            lblOlogEx1.Text = "Output: " + result;
        }

        private void btnOlogEx2_Click(object sender, EventArgs e)
        {
            int n = 16;
            string result = "";
            while (n > 1)
            {
                n = n / 2;
                result += n + "\n";
            }
            lblOlogEx2.Text = "Output:\n" + result;
        }

        private void btnOlogEx3_Click(object sender, EventArgs e)
        {
            int low = 1;
            int high = 100;
            string result = "";
            while (low <= high)
            {
                int middle = (low + high) / 2;
                result += middle + "\n";
                high = middle - 1;
            }
            lblOlogEx3.Text = "Output:\n" + result;
        }

        private void btnOn2Ex1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    result += numbers[i] + " " + numbers[j] + "\n";
                }
            }
            rtbOutOn2Ex1.Text = "Output:\n" + result;
        }

        private void btnOn2Ex2_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3 };
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    result += numbers[i] + " " + numbers[j] + "\n";
                }
            }
            lblOn2Ex2.Text = "Output:\n" + result;
        }

        private void btnOn2Ex3_Click(object sender, EventArgs e)
        {
            string[] students = { "Ana", "Ben", "Carlo" };
            string result = "";
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students.Length; j++)
                {
                    result += students[i] + " checks " + students[j] + "\n";
                }
            }
            lblOn2Ex3.Text = "Output:\n" + result;
        }

        private void btnO2nEx1_Click(object sender, EventArgs e)
        {
            int n = 3;
            int combinations = 1;
            for (int i = 0; i < n; i++)
            {
                combinations = combinations * 2;
            }
            rtbOutO2nEx1.Text = "Output: Number of combinations: " + combinations;
        }

        private void btnO2nEx2_Click(object sender, EventArgs e)
        {
            int tosses = 5;
            int possibilities = 1;
            for (int i = 0; i < tosses; i++)
            {
                possibilities *= 2;
            }
            rtbOutO2nEx2.Text = "Output: Possible results: " + possibilities;
        }

        private void btnO2nEx3_Click(object sender, EventArgs e)
        {
            int positions = 4;
            int possibilities = 1;
            for (int i = 0; i < positions; i++)
            {
                possibilities *= 2;
            }
            rtbOutO2nEx3.Text = "Output: Possible passwords: " + possibilities;
        }
    }
}
