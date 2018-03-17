using ngApp.Web.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ngApp.Web.Models
{
    public static class ExtensionMethods
    {
        public static string ToDisplay(this Enum value)
        {
            var attributes = (DisplayAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DisplayAttribute), false);

            return attributes.Length > 0 ? attributes[0].Name : value.ToString();
        }

        public static IList<IdWithName> ToPasirinkimasList<TEnum>()
           where TEnum : struct
        {
            var i = 1;

            return EnumToObjectList<TEnum, IdWithName>(x => new IdWithName
            {
                Id = Convert.ToInt64(x),
                Name = x.ToName(),
                CountNr = i++
            }).OrderBy(o => o.Name).ToList();
        }

        public static IList<TObject> EnumToObjectList<TEnum, TObject>(Func<Enum, TObject> selectAction)
           where TEnum : struct
           where TObject : class, new()
        {
            if (selectAction == null)
                throw new ArgumentNullException("selectAction not set.");

            return Enum.GetValues(typeof(TEnum)).Cast<Enum>().Select(selectAction).ToList();
        }

        public static IdWithName ToPasirinkimas(this Enum item)
        {
            var enumMembers = Enum.GetValues(item.GetType()).Cast<Enum>();

            return new IdWithName()
            {
                Id = Convert.ToInt64(item),
                Name = item.ToName(),
                CountNr = enumMembers.ToList().IndexOf(item) + 1
            };
        }

        public static string ToName(this Enum value)
        {
            if (value == null)
                return String.Empty;

            var attribute = value.GetAttribute<DisplayAttribute>();

            return attribute != null ? attribute.Name : value.ToString();
        }

        public static TAttribute GetAttribute<TAttribute>(this Enum value)
          where TAttribute : Attribute
        {
            return value.GetAttributes<TAttribute>().FirstOrDefault();
        }

        public static IList<TAttribute> GetAttributes<TAttribute>(this Enum value)
           where TAttribute : Attribute
        {
            var mi = value.GetMemberInfo();

            if (mi == null)
                return null;

            var attributes = mi.GetCustomAttributes(typeof(TAttribute), false);

            return (IList<TAttribute>)attributes;
        }

        private static MemberInfo GetMemberInfo(this Enum value)
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());

            return memberInfo.FirstOrDefault();
        }

    }
}
