using System.Reflection;

namespace Ratifier
{
    public partial class Ratifier
    {
        private static void RequiredCheck(object obj, bool ignoreChildren = false)
        {
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = type.GetCustomAttribute<Required>();

                if (attr != null)
                {
                    var value = prop.GetValue(obj);

                    if (value == null)
                    {
                        throw new RequiredFieldException();
                    }


                    //if its a string make sure its actually got something in it
                    //var valueAsString = prop.GetValue(obj) as string;
                    //if (string.IsNullOrWhiteSpace(valueAsString))
                    //{
                    //    throw new RequiredFieldException();

                    //}

                }
            }
        }



    }
}
