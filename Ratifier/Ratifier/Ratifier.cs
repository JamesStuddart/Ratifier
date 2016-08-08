using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratifier
{
    public static partial class Ratifier
    {
        public static bool Ratify(object obj, bool ignoreChildren = false)
        {
            RequiredCheck(obj, ignoreChildren);

            MaxLengthCheck(obj, ignoreChildren);
            MinLengthCheck(obj, ignoreChildren);


            MeetsRegExCheck(obj, ignoreChildren);

            return true;
        }




    }

    public static class RatifierExt
    {
        public static bool Ratify(this object obj, bool ignoreChildren = false)
        {
            return Ratifier.Ratify(obj, ignoreChildren);
        }
    }

}
