using System.Text;
using EduHUB_Ch1.Domain;

Console.OutputEncoding = Encoding.UTF8;

const string Separator = "==========================";


static void Step(int number, string title) => Console.WriteLine($"\n {Separator}\n Bước {number}:{title}\n{Separator}");


// Bước 1 - Tạo CLb
Step(1, "Tạo câu lạc bộ");
var club = Club.Create("Tech Club", "Câu lạc bộ công nghệ: workshop, hackthon, chia sẻ kiến thức");
Console.WriteLine($" CLB: {club.Name} - {club.Description}");


