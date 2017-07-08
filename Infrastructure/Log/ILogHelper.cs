using System;
namespace Infrastructure.Log
{
    public interface ILogHelper
    {
        void Error(string message);
        void Error(string message, Exception ex);
    }
}
