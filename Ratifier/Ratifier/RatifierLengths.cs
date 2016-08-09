using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ratifier
{
    public partial class Ratifier
    {
        private static void MaxLengthCheck(object obj)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = type.GetCustomAttribute<MaxLength>();

                if (attr != null)
                {
                    var value = prop.GetValue(obj) as string;

                    if (value == null || value.Length > attr.Value)
                    {
                        throw new MaxLengthException();
                    }
                }

            }
        }

        private static void MinLengthCheck(object obj)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = type.GetCustomAttribute<MinLength>();

                if (attr != null)
                {
                    var value = prop.GetValue(obj) as string;

                    if (value == null || value.Length < attr.Value)
                    {
                        throw new MinLengthException();
                    }
                }
            }

        }

    }
}
