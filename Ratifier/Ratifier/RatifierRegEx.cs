using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Ratifier
{
    public partial class Ratifier
    {
        private static void MeetsRegExCheck(object obj)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = type.GetCustomAttribute<MeetsRegEx>();

                if (attr != null)
                {
                    var value = prop.GetValue(obj) as string;

                    if (value == null)
                    {
                        throw new NullReferenceException();
                    }

                    var match = Regex.Match(value, attr.Pattern);
                    //length here is done to ensure ONLY full string matching occurs
                    if (!match.Success || match.Value.Length != value.Length)
                    {
                        throw new FailedToMeetRegExException();
                    }

                }
            }


           
        }


    }
}
