namespace DataLibrary.Abstract
{
    public interface ICustomCredintials
    {
        string Login { get; set; }
        bool IsAdmin { get; set; }
    }
}
