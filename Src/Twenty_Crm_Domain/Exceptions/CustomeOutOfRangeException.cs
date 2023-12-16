namespace Twenty_Crm_Domain.Exceptions;

public class CustomeOutOfRangeException : Exception
{
    public CustomeOutOfRangeException(object arguman)
        : base($"the range of {nameof(arguman)} is out of range")
    {

    }

}
