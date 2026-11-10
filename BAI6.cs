using System;

class Program
{
    // Hàm đệ quy tìm UCLN theo thuật toán Euclid
    static int UCLN(int a, int b)
    {
        // Trường hợp suy biến: a chia hết cho b
        if (a % b == 0)
        {
            return b;
        }
        // Trường hợp đệ quy
        return UCLN(b, a % b);
    }

    static void Main()
    {
        Console.Write("Nhập số a (> 0): ");
        bool checkA = int.TryParse(Console.ReadLine(), out int a);

        Console.Write("Nhập số b (> 0): ");
        bool checkB = int.TryParse(Console.ReadLine(), out int b);

        if (checkA && checkB && a > 0 && b > 0)
        {
            int ketQua = UCLN(a, b);
            Console.WriteLine($"Ước số chung lớn nhất của {a} và {b} là: {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập 2 số nguyên dương hợp lệ!");
        }
    }
}
