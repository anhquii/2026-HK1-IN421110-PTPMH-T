namespace EduHUB_Ch1.Domain;

// <summary> Câu lạc bọ sinh viên </summary>
public class Club
{
    private readonly List<Member> _nember = [];

    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public DateTime CreateAt { get; private set; }

    public IReadOnlyList<Member> Nember => _nember;

    private Club ( string name, string description )
    {
        Id = Guid.NewGuid ();
        Name = name;
        Description = description;
        CreateAt = DateTime.UtcNow;
    }

    /// <exception cref="ArgumentException">Tên trống.</exception>

    public static Club Create( string name, string description )
    {
        if (string.IsNullOrWhiteSpace( name )) 
            throw new ArgumentNullException ("Tên CLB không được để trống", "name" );

        return new Club ( name.Trim(), description?.Trim( ) ?? string.Empty);

    }

    public void AddMember( Member member )
    {
        ArgumentNullException.ThrowIfNull(member);
        if (_nember.Any(m => m.Id == member.Id))
            throw new InvalidOperationException($"{member} đã là thành viên của {Name}.");
        _nember.Add(member);
    }

    /// <summary>
    /// Số thành viên hiện có
    /// </summary>
    public int MemberCount() => _nember.Count;

}
