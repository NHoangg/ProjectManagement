using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

public class FileHandler
{
    public void SerializeToFile<T>(string filePath, T data)
    {
        try
        {
            // Thiết lập tùy chọn cho JSON serialization (nếu cần)
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // Tạo JSON dễ đọc
            };

            string jsonData = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonData); // Ghi dữ liệu JSON vào file
            Console.WriteLine("Dữ liệu đã được tuần tự hóa thành công.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi trong quá trình tuần tự hóa: {ex.Message}");
        }
    }

    public T DeserializeFromFile<T>(string filePath)
    {
        try
        {
            string jsonData = File.ReadAllText(filePath); // Đọc dữ liệu JSON từ file
            T data = JsonSerializer.Deserialize<T>(jsonData); // Giải tuần tự hóa dữ liệu JSON thành đối tượng
            return data;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi trong quá trình giải tuần tự hóa: {ex.Message}");
            return default(T);
        }
    }
}
