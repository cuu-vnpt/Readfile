using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Đường dẫn tới file CSV
            string filePath = "countries.csv";

            // Đọc từng dòng trong file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Tách các trường thông tin bằng dấu phẩy
                    string[] fields = line.Split(',');

                    // Lấy thông tin quốc gia
                    string countryCode = fields[4].Trim('"');
                    string countryName = fields[5].Trim('"');

                    // Hiển thị thông tin quốc gia
                    Console.WriteLine($"{countryCode}: {countryName}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}