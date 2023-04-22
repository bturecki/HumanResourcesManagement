namespace DataLibrary
{
    public static class CurrentUser
    {
        public static bool IsAdmin { get; set; } = false;
        public static string Login { get; set; } = string.Empty;
    }
}
