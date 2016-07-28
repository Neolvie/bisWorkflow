using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Shared.Extenders
{
  public static class EnumExtenders
  {
    public static string GetDescription(this Enum enumerate)
    {
      var type = enumerate.GetType();
      var fieldInfo = type.GetField(enumerate.ToString());
      var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
      return (attributes.Length > 0) ? attributes[0].Description : enumerate.ToString();
    }

    public static IList ToList(this Type type)
    {
      if (type == null)
        throw new NullReferenceException("Type");
     
      var arrayList = new ArrayList();
      var enumValues = Enum.GetValues(type);

      foreach (Enum value in enumValues)
      {
        arrayList.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
      }

      return arrayList;
    }
  }
}