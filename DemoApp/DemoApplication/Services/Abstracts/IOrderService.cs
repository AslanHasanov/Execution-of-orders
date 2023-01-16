using DemoApplication.Areas.Client.ViewModels.Shop;
using DemoApplication.Database.Models;

namespace DemoApplication.Services.Abstracts
{
    public interface IOrderService
    {
        Task<Order> AddOrderAsync(int SumToal);
        Task AddOrderProductAsync(OrderViewModel model,string OrderId);
    }
}
