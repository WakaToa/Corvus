namespace Corvus.EnumExtension.Attribute
{
    public class FullNameAttribute : System.Attribute
    {
        public string FullName { get; set; }

        public FullNameAttribute(string fullName)
        {
            FullName = fullName;
        }

    }
}
