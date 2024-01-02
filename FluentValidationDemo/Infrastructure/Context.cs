using Domain;

namespace Infrastructure
{
    public static class Context
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "AMD Ryzen 3 3100",
                Description = "A nice budget processor for gaming",
                Stock = 5,
                Category = Category.CPU
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "AMD RX 6700 XT",
                Description = "A powerful midrange GPU perfect for 1080p and 1440p Gaming",
                Stock = 6,
                Category = Category.GPU
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Nvidia Geforce RTX 4090",
                Description = "The most powerful and expensive GPU Available in the market. We encourage you to purchase this unit if you want the best of the best and really hate your wallet",
                Stock = 2,
                Category = Category.GPU
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Corsair Vengeance LPX 16GB DDR4 RAM",
                Description = "High-performance DDR4 memory for smooth multitasking and gaming",
                Stock = 8,
                Category = Category.RAM
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Samsung 970 EVO Plus 1TB NVMe SSD",
                Description = "Fast and reliable NVMe SSD for speedy storage and boot times",
                Stock = 10,
                Category = Category.Storage
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "ASUS ROG Strix B550-F Gaming Motherboard",
                Description = "Feature-rich motherboard with excellent gaming performance",
                Stock = 4,
                Category = Category.Motherboard
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "EVGA SuperNOVA 750 G5, 80 Plus Gold 750W, Fully Modular Power Supply",
                Description = "High-quality power supply for stable and efficient power delivery",
                Stock = 7,
                Category = Category.PowerSupply
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "NZXT H510i Compact ATX Mid-Tower PC Gaming Case",
                Description = "Sleek and compact case with smart features for efficient cooling",
                Stock = 3,
                Category = Category.Case
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Logitech G Pro X Mechanical Gaming Keyboard",
                Description = "Responsive and customizable mechanical keyboard for gaming enthusiasts",
                Stock = 9,
                Category = Category.Keyboard
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "SteelSeries Rival 600 Gaming Mouse",
                Description = "Precision gaming mouse with customizable weight and sensitivity",
                Stock = 5,
                Category = Category.Mouse
            }
        };
    }
}
