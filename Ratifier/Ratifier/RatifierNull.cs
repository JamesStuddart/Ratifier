using System.Reflection;

namespace Ratifier
{
    public static partial class Ratifier
    {
        public static void CanBeNullCheck(object obj)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = type.GetCustomAttribute<CanBeNull>();

                if (attr?.Value == false && prop.GetValue(obj) == null)
                {
                    throw new CanBeNullException();
                }
            }
        }
    }
}
