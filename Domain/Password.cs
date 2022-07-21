namespace Domain
{
    public class Password
    {
        string password;
        public Password(string password)
        {
            this.password = password;
        }
        public bool ShouldHaveValidPassword()
        {
            return password.Length < 8;
        }
    }
}