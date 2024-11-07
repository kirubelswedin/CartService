using CartService.Domain.Models;

namespace CartService.Domain.Factories;

public class ResponseFactory<T> : BaseResponseFactory
{
    public static ResponseResult<T> Success(T data, int statusCode = 200, string? message = null!)
    {
        return new ResponseResult<T>
        {
            Success = true,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
    
    public static ResponseResult<T> Created(T data, int statusCode = 201, string? message = null!)
    {
        return new ResponseResult<T>
        {
            Success = true,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
    
    public static ResponseResult<T> NotFound(T data, int statusCode = 404, string? message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
    
   public static ResponseResult<T> Failed(T data, int statusCode = 400, string? message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
   
    public static ResponseResult<T> ServerError(T data, int statusCode = 500, string? message = null!)
    {
        return new ResponseResult<T>
        {
            Success = false,
            StatusCode = statusCode,
            Message = message,
            Data = data
        };
    }
}

