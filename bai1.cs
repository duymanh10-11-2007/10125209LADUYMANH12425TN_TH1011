using System;

class Program
{
    // Hàm đệ quy tính S(n) = 1 + 2 + ... + n
    static long S1(int n)
    {
        // Trường hợp suy biến (điểm dừng)
        if (n == 1)
        {
            return 1;
        }
        // Trường hợp đệ quy
        return S1(n - 1) + n;
    }

    static void Main()
    {
        Console.Write("Nhập n (> 0): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            long ketQua = S1(n);
            Console.WriteLine($"Kết quả S({n}) = {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}