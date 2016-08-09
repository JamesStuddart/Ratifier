using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratifier
{
    public static partial class Ratifier
    {
        public static void Ratify(object obj)
        {
            //check main item
            DoChecks(obj);

            //check child objects
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                //do check on lists
                if (prop is IEnumerable)
                {
                    foreach (var item in prop as IEnumerable)
                    {
                        DoChecks(item);
                    }
                }
                else
                {
                    DoChecks(prop.GetValue(obj));
                }
            }
        }

        private static void DoChecks(object obj)
        {
            RequiredCheck(obj);

            MaxLengthCheck(obj);
            MinLengthCheck(obj);

            MeetsRegExCheck(obj);

            CanBeNullCheck(obj);
        }
    }

    public static class RatifierExt
    {
        public static void Ratify(this object obj)
        {
            Ratifier.Ratify(obj);
        }
    }

}
