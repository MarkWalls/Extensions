using System;
using System.Linq;

namespace Extensions.String
{

  public static class StringCoalesceExtension
      {
          public static string Coalesce(this string s1, string s2)
          {
              return string.IsNullOrWhiteSpace(s1) ? s2 : s1;
          }
      }
}
