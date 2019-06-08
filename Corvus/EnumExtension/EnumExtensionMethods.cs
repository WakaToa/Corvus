using System;
using System.Linq;
using Corvus.DarkOrbit.Data;
using Corvus.EnumExtension.Attribute;

namespace Corvus.EnumExtension
{
    public static class EnumExtensionMethods
    {
        public static string GetShortName(this Enum value)
        {
            var attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(ShortNameAttribute), false)
                .SingleOrDefault() as ShortNameAttribute;
            return attribute == null ? value.ToString() : attribute.ShortName;
        }

        public static string GetFullName(this Enum value)
        {
            var attribute = value.GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(typeof(FullNameAttribute), false)
                .SingleOrDefault() as FullNameAttribute;
            return attribute == null ? value.ToString() : attribute.FullName;
        }

        public static TechFactoryData.TechFactoryItem TechItemFromShortName(this string shortName)
        {
            var type = typeof(TechFactoryData.TechFactoryItem);
            if (!type.IsEnum)
                throw new ArgumentException();
            var fields = type.GetFields();
            var field = fields
                .SelectMany(f => f.GetCustomAttributes(
                    typeof(ShortNameAttribute), false), (
                    f, a) => new { Field = f, Att = a }).SingleOrDefault(a => ((ShortNameAttribute)a.Att)
                                                                              .ShortName == shortName);
            return (TechFactoryData.TechFactoryItem)field.Field.GetRawConstantValue();
        }

        public static TechFactoryData.TechFactoryItem TechItemFromFullName(this string fullName)
        {
            var type = typeof(TechFactoryData.TechFactoryItem);
            if (!type.IsEnum)
                throw new ArgumentException();
            var fields = type.GetFields();
            var field = fields
                .SelectMany(f => f.GetCustomAttributes(
                    typeof(FullNameAttribute), false), (
                    f, a) => new { Field = f, Att = a }).SingleOrDefault(a => ((FullNameAttribute)a.Att)
                                                                              .FullName == fullName);
            return (TechFactoryData.TechFactoryItem)field.Field.GetRawConstantValue();
        }

        public static GalaxyGate GalaxyGateFromFullName(this string fullName)
        {
            var type = typeof(GalaxyGate);
            if (!type.IsEnum)
                throw new ArgumentException();
            var fields = type.GetFields();
            var field = fields
                .SelectMany(f => f.GetCustomAttributes(
                    typeof(FullNameAttribute), false), (
                    f, a) => new { Field = f, Att = a }).SingleOrDefault(a => ((FullNameAttribute)a.Att)
                                                                              .FullName == fullName);
            return (GalaxyGate)field.Field.GetRawConstantValue();
        }
    }
}
