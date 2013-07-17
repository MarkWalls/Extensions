using System;
using System.Linq;

namespace Extensions.String
{

  public static class StringCoalesceExtension
      {
          public static string Coalesce(this string s, string sDefault)
          {
              return string.IsNullOrWhiteSpace(s) ? sDefault : s;
          }
          
          public static string ValueOrDefault(this string s, string sDefault)
          {
              if (string.IsNullOrEmpty(s))
                  return sDefault;
              return s;
          }
      }
}
