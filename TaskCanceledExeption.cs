using System.Runtime.Serialization;

namespace GradeBook
{
    [Serializable]
    internal class TaskCanceledExeption : Exception
    {
        public TaskCanceledExeption()
        {
        }

        public TaskCanceledExeption(string? message) : base(message)
        {
        }

        public TaskCanceledExeption(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TaskCanceledExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}