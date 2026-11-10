using System;

class Program
{
    // Hàm đệ quy tính S(n) = 1 + 1/2 + 1/3 + ... + 1/n
    static double S3(int n)
    {
        // Trường hợp suy biến (điểm dừng)
        if (n == 1)
        {
            return 1.0;
        }
        // Trường hợp đệ quy (dùng 1.0 / n để tránh chia nguyên)
        return S3(n - 1) + 1.0 / n;
    }
    static void Main()
    {
        Console.Write("Nhập n (> 0): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            double ketQua = S3(n);
            // In kết quả với định dạng lấy 4 chữ số phần thập phân cho dễ nhìn
            Console.WriteLine($"Kết quả S({n}) = {ketQua:F4}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}