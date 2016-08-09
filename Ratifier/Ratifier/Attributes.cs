using System;

namespace Ratifier
{
    public class Required : Attribute { }

    //currently not supported
    //public class AtLeastOne : Attribute
    //{
    //    internal string GroupName { get; }

    //    public AtLeastOne(string groupName)
    //    {
    //        GroupName = groupName;
    //    }
    //    public AtLeastOne()
    //    {
    //        GroupName = "--Ungrouped--";
    //    }
    //}

    public class MeetsRegEx : Attribute
    {
        internal string Pattern { get; }

        public MeetsRegEx(string pattern)
        {
            Pattern = pattern;
        }
    }

    public class CanBeNull : Attribute
    {
        internal bool Value { get; }

        public CanBeNull(bool value = true)
        {
            Value = value;
        }
    }

    public class MaxLength : Attribute
    {
        internal int Value { get; }

        public MaxLength(int value)
        {
            Value = value;
        }
    }

    public class MinLength : Attribute
    {
        internal int Value { get; }

        public MinLength(int value)
        {
            Value = value;
        }
    }

    //currently not supported
    //public class MinValue : Attribute
    //{
    //    internal int Value { get; }

    //    public MinValue(int value)
    //    {
    //        Value = value;
    //    }
    //}

    //public class MaxValue : Attribute
    //{
    //    internal int Value { get; }

    //    public MaxValue(int value)
    //    {
    //        Value = value;
    //    }
    //}


}
