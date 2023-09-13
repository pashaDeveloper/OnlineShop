using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>

            {
                new Product
                    {
                        Name = "کتاب جاوا",
                        Description = "کتاب جاوا برای شروع کار با زبان برنامه نویسی جاوا",
                        Price = 50000,
                        PicURl = "https://example.com/book1.jpg",
                        Type = "کتاب",
                        Brand = "ناشران آکادمی",
                        QuantityStock = 10
                    },
                    new Product
                    {
                        Name = "لپ تاپ ایسوس",
                        Description = "لپ تاپ ایسوس با صفحه نمایش ۱۵ اینچی",
                        Price = 2000000,
                        PicURl = "https://example.com/laptop1.jpg",
                        Type = "لپ تاپ",
                        Brand = "ایسوس",
                        QuantityStock = 5
                    },
                    new Product
                    {
                        Name = "گوشی موبایل سامسونگ",
                        Description = "گوشی موبایل سامسونگ با دوربین ۴۸ مگاپیکسلی",
                        Price = 3000000,
                        PicURl = "https://example.com/phone1.jpg",
                        Type = "موبایل",
                        Brand = "سامسونگ",
                        QuantityStock = 8
                    },
                    new Product
                    {
                        Name = "کفش ورزشی نایک",
                        Description = "کفش ورزشی نایک با رنگ سبز و طرح جدید",
                        Price = 1500000,
                        PicURl = "https://example.com/shoe1.jpg",
                        Type = "کفش",
                        Brand = "نایک",
                        QuantityStock = 12
                    },
                    new Product
                    {
                        Name = "تبلت آیپد",
                        Description = "تبلت آیپد با صفحه نمایش ۱۰.۲ اینچی",
                        Price = 4000000,
                        PicURl = "https://example.com/ipad1.jpg",
                        Type = "تبلت",
                        Brand = "اپل",
                        QuantityStock = 6
                    },
                    new Product
                    {
                        Name = "کتاب الگوریتم",
                        Description = "کتاب الگوریتم برای شروع کار با الگوریتم ها در برنامه نویسی",
                        Price = 60000,
                        PicURl = "https://example.com/book2.jpg",
                        Type = "کتاب",
                        Brand = "ناشران آکادمی",
                        QuantityStock = 15
                    },
                    new Product
                    {
                        Name = "لپ تاپ دل",
                        Description = "لپ تاپ دل با صفحه نمایش ۱۳ اینچی و کارت گرافیک داخلی",
                        Price = 2500000,
                        PicURl = "https://example.com/laptop2.jpg",
                        Type = "لپ تاپ",
                        Brand = "دل",
                        QuantityStock = 7
                    }
                    
            };
            // foreach(var product in products)
            // {
            //     context.products.Add(product);
            // }

            context.Products.AddRange(products);
            context.SaveChanges();
            //معنی استاتیک بودن کلاس این است ک ما می توانیم از این کلاس بدون مقدار دهی اولیه استفاده کنیم
        }
    }
}