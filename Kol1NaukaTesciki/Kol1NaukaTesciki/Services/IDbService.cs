using Kol1NaukaTesciki.Models.DTOs;

namespace Kol1NaukaTesciki.Services;

public interface IDbService
{
    Task<CustomerRentalHistoryDto> GetRentalsForCustomerByIdAsync(int customerId);
    Task AddNewRentalAsync(int customerId, CreateRentalRequestDto rentalRequest);
}