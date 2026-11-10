using System;

class Program
{
    // Hàm đệ quy tìm ước số lẻ lớn nhất của n
    static int UocLeMax(int n)
    {
        // Trường hợp suy biến: Nếu n là số lẻ
        if (n % 2 != 0)
        {
            return n;
        }
        // Trường hợp đệ quy: Nếu n là số chẵn
        return UocLeMax(n / 2);
    }

    static void Main()
    {
        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            int ketQua = UocLeMax(n);
            Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {ketQua}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ!");
        }
    }
}