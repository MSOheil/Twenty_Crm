namespace Twenty_Crm_Domain.Exceptions;

public class CustomeNullException : Exception
{
    public CustomeNullException(object argument) : base($"the {nameof(argument)} is null please enter it")
    {

    }
}
