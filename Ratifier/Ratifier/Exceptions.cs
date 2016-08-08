using System;

namespace Ratifier
{
    public class RequiredFieldException : Exception { }
    public class FailedToMeetRegExException : Exception { }
    public class AtLeastOneException : Exception { }
    public class CanBeNullException : Exception { }

    public class MaxLengthException : Exception { }
    public class MinLengthException : Exception { }
    public class MaxValueException : Exception { }
    public class MinValueException : Exception { }
}
