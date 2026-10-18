using System.Text;
using EduHUB_Ch1.Domain;

Console.OutputEncoding = Encoding.UTF8;

const string Separator = "==========================";
const int EventCapacity = 50;


static void Step(int number, string title) => Console.WriteLine($"\n {Separator}\n Bước {number}:{title}\n{Separator}");


// Bước 1 - Tạo CLb
Step(1, "Tạo câu lạc bộ");
var club = Club.Create("Tech Club", "Câu lạc bộ công nghệ: workshop, hackthon, chia sẻ kiến thức");
Console.WriteLine($" CLB: {club.Name} - {club.Description}");

// Bước 2 - Thêm 3 thành viên
Step(2, "Thêm thành viên");
var members = new[]
{
    Member.Create("Nguyễn Văn An", "an.nv@student.dthu.edu.vn", "DH24001"),
    Member.Create("Trần Thị Bình", "binh.tt@student.dthu.edu.vn", "DH24002"),
    Member.Create("Lê Hoàng Cường", "cuong.lh@student.dthu.edu.vn", "DH24003"),
};

foreach (var member in members)
{
    club.AddMember(member);
    Console.WriteLine($" + {member} <{member.Email}> " );
}
Console.WriteLine($"Tổng thành viên: {club.MemberCount()}");


// Bước 3 - tạo sự kiện
Step(3, "Tạo sự kiện");
var workshop = Event.Create(club.Id, "Workshop AI", DateTime.Today.AddDays(7).AddHours(14), EventCapacity);
Console.WriteLine($"Sự kiện: {workshop.Title} - {workshop.Date:dd/MM/yyyy HH:mm}");