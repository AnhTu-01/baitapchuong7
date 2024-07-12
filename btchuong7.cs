using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Tạo một Từ điển với khóa là kiểu string và giá trị là kiểu int
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        // Thêm một số giá trị cặp khóa cho Từ điển
        dictionary.Add("apple", 1);
        dictionary.Add("banana", 2);
        dictionary.Add("cherry", 3);

        // Sử dụng phương pháp ContainsKey để kiểm tra xem một khóa có tồn tại trong Từ điển hay không
        string keyToCheck = "banana";
        if (dictionary.ContainsKey(keyToCheck))
        {
            Console.WriteLine($"Khóa '{keyToCheck}' tồn tại trong Từ điển.");
        }
        else
        {
            Console.WriteLine($"Khóa '{keyToCheck}' không tồn tại trong Từ điển.");
        }

        // Sử dụng phương thức TryGetValue để truy xuất giá trị được liên kết với một khóa nhất định một cách an toàn
        int value;
        if (dictionary.TryGetValue("cherry", out value))
        {
            Console.WriteLine($"Giá trị liên kết với khóa 'cherry' là: {value}");
        }
        else
        {
            Console.WriteLine($"Khóa 'cherry' không tồn tại trong Từ điển.");
        }

        // Sử dụng vòng lặp foreach để lặp qua các mục KeyValuePair<TKey, TValue> trong Từ điển và in chúng
        Console.WriteLine("Các mục trong Từ điển:");
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine($"Khóa: {kvp.Key}, Giá trị: {kvp.Value}");
        }
    }
}