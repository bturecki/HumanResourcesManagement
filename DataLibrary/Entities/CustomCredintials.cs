using DataLibrary.Abstract;

namespace DataLibrary.Entities
{
    internal class CustomCredintials : ICustomCredintials
    {
        public string Login { get; set; }
        public bool IsAdmin { get; set; }
        internal string Password { get; set; }
    }
}
