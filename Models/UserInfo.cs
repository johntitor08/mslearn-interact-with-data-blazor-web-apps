namespace BlazingPizza.Models
{
    public class UserInfo
    {
        public int Id { get; set; }   // ✅ PK
        public string Name { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
