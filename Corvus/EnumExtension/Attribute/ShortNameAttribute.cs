namespace Corvus.EnumExtension.Attribute
{
    public class ShortNameAttribute : System.Attribute
    {
        public string ShortName { get; set; }

        public ShortNameAttribute(string shortName)
        {
            ShortName = shortName;
        }

    }
}
