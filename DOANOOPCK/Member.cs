public class Members
{
    public string MemberName { get; set; }
    public int MemberID { get; set; }
    public string Role { get; set; }

    public Members(string membername, int id, string role)
    {
        MemberName = membername;
        MemberID = id;
        Role = role;
    }
    public void DisplayMemberInfo()
    {
        Console.WriteLine($"ID: {MemberID}, Menber's Name: {MemberName}, Member's Role: {Role}");
    }
}