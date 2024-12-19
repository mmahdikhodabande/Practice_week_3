
namespace Hospital_management_Project
{
    internal class RoomFullException : Exception
    {
        public RoomFullException(string? message) : base(message)
        {
        }
    }
}