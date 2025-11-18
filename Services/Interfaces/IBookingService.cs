using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Services.Interfaces
{
    public interface IBookingService
    {
        Task<Order> GetBookingByIdAsync(int id);
        Task<List<Order>> GetAllBookingsAsync();
        Task<bool> AddBookingAsync(Order order);
        Task UpdateBookingAsync(Order order);
        Task DeleteBookingAsync(int id);
    }
}
