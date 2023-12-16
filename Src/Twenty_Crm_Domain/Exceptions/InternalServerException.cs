namespace Twenty_Crm_Domain.Exceptions;

public class InternalServerException : Exception
{
    public InternalServerException(string message) :
        base(message)
    {

    }
}
