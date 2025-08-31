using System;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chuỗi ví dụ
            string text = "The dog is barking. It is very loud. Another dog is running.";

            // 1. Thay thế 'dog' bằng 'cat'
            string replaced = text.Replace("dog", "cat");

            // 2. Tìm vị trí dấu chấm đầu tiên
            int dotIndex = replaced.IndexOf(".");

            // 3. Nếu có dấu chấm thì cắt chuỗi đến đó
            string firstSentence;
            if (dotIndex != -1)
            {
                firstSentence = replaced.Substring(0, dotIndex + 1);
            }
            else
            {
                // Nếu không có dấu chấm, in toàn bộ chuỗi
                firstSentence = replaced;
            }

            // Xuất kết quả
            Console.WriteLine(firstSentence);
        }
    }
}
