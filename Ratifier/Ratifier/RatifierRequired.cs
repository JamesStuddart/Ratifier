using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ratifier
{
    public partial class Ratifier
    {
        private static void RequiredCheck(object obj)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = type.GetCustomAttribute<Required>();

                if (attr != null)
                {
                    if (prop.GetValue(obj) == null)
                    {
                        throw new RequiredFieldException();
                    }
                }
        }
    }



}
}
