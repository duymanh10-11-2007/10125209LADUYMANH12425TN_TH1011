using System;

class bai4
{
    // Hàm đệ quy tính x^N với N >= 0
    static double LuyThua(double x, int n)
    {
        // Trường hợp suy biến (điểm dừng)
        if (n == 0)
        {
            return 1.0;
        }
        // Trường hợp đệ quy
        return LuyThua(x, n - 1) * x;
    }

    // Hàm tính S(x, n) nhận cả n âm và n dương
    static double S(double x, int n)
    {
        if (n < 0)
        {
            return 1.0 / LuyThua(x, -n);
        }
        else
        {
            return LuyThua(x, n);
        }
    }

    static void Main()
    {
        Console.Write("Nhập x: ");
        bool isValidX = double.TryParse(Console.ReadLine(), out double x);

        Console.Write("Nhập n (số nguyên): ");
        bool isValidN = int.TryParse(Console.ReadLine(), out int n);

        if (isValidX && isValidN)
        {
            // Kiểm tra trường hợp 0 mũ âm (không xác định)
            if (x == 0 && n < 0)
            {
                Console.WriteLine("Lỗi: Không thể tính 0 với số mũ âm!");
            }
            else
            {
                double ketQua = S(x, n);
                Console.WriteLine($"Kết quả S({x}, {n}) = {ketQua}");
            }
        }
        else
        {
            Console.WriteLine("Dữ liệu nhập vào không hợp lệ!");
        }
    }
}