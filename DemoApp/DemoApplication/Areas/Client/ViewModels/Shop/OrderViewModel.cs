namespace DemoApplication.Areas.Client.ViewModels.Shop
{
    public class OrderViewModel
    {
    
        public List<ItemViewModel> Models { get; set; }
        public int SumTotal { get; set; }
        public class ItemViewModel
        {
           

            public int Id { get; set; }
            public string Title { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public double Total { get; set; }
            public ItemViewModel(int id, string title, int quantity, double price, double total)
            {
                Id = id;
                Title = title;
                Quantity = quantity;
                Price = price;
                Total = total;
            }
        }
    }
}
