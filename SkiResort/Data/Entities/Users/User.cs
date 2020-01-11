
namespace Data.Entities.Users
{
    public class User : Account
    {
        public virtual bool IsNaughty { get; set; }
        public virtual bool IsNice { get; set; }
    }
}
