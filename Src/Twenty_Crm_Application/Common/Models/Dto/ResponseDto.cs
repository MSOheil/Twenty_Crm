namespace Twenty_Crm_Application.Common.Models.Dto;

public class ResponseDto<T>
{
    public string? Message { get; set; }
    public int StatusCode { get; set; }
    public T Result { get; set; }
    public ResponseDto(string message, int statusCode, T data)
    {
        this.Message = message;
        this.StatusCode = statusCode;
        this.Result = data;
    }
}
