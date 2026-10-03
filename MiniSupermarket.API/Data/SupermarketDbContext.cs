using Microsoft.EntityFrameworkCore;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Data
{
    // DbContext đại diện cho phiên làm việc với cơ sở dữ liệu SQL Server
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(
            DbContextOptions<SupermarketDbContext> options
        ) : base(options)
        {
        }

        // ==========================================
        // KHAI BÁO CÁC BẢNG DỮ LIỆU
        // ==========================================

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }


        // ==========================================
        // CẤU HÌNH DỮ LIỆU MỒI (SWEET LAND)
        // ==========================================

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // ==========================================
            // SEED 15 CATEGORY
            // DANH MỤC BÁNH KẸO NHẬP KHẨU
            // ==========================================

            modelBuilder.Entity<Category>().HasData(

                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Kẹo",
                    Description = "Các loại kẹo mềm, kẹo cứng, kẹo dẻo nhập khẩu"
                },

                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Socola",
                    Description = "Socola thanh, socola viên và socola hộp nhập khẩu"
                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Bánh quy",
                    Description = "Bánh quy bơ, bánh quy socola và bánh quy nhập khẩu"
                },

                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Bánh xốp",
                    Description = "Các loại bánh xốp, wafer và bánh kem xốp"
                },

                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Snack",
                    Description = "Snack khoai tây, snack ngô và các loại đồ ăn nhẹ"
                },

                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Bánh ngọt",
                    Description = "Bánh ngọt đóng gói và các loại bánh nhập khẩu"
                },

                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Kẹo dẻo",
                    Description = "Kẹo dẻo trái cây, kẹo dẻo hình thú và kẹo gummy"
                },

                new Category
                {
                    CategoryId = 8,
                    CategoryName = "Socola cao cấp",
                    Description = "Socola cao cấp, socola quà tặng và socola hộp"
                },

                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Bánh quy cao cấp",
                    Description = "Bánh quy cao cấp dùng làm quà tặng"
                },

                new Category
                {
                    CategoryId = 10,
                    CategoryName = "Kẹo bạc hà",
                    Description = "Kẹo bạc hà, kẹo the và kẹo ngậm nhập khẩu"
                },

                new Category
                {
                    CategoryId = 11,
                    CategoryName = "Kẹo trái cây",
                    Description = "Các loại kẹo có hương vị trái cây"
                },

                new Category
                {
                    CategoryId = 12,
                    CategoryName = "Bánh ăn sáng",
                    Description = "Bánh ngũ cốc, bánh ăn sáng và sản phẩm tiện lợi"
                },

                new Category
                {
                    CategoryId = 13,
                    CategoryName = "Hạt & Đồ ăn vặt",
                    Description = "Các loại hạt, trái cây sấy và đồ ăn vặt nhập khẩu"
                },

                new Category
                {
                    CategoryId = 14,
                    CategoryName = "Quà tặng bánh kẹo",
                    Description = "Hộp bánh kẹo và set quà tặng Sweet Land"
                },

                new Category
                {
                    CategoryId = 15,
                    CategoryName = "Bánh kẹo khác",
                    Description = "Các sản phẩm bánh kẹo nhập khẩu khác"
                }
            );


            // ==========================================
            // SEED 15 CUSTOMER
            // KHÁCH HÀNG SWEET LAND
            // ==========================================

            modelBuilder.Entity<Customer>().HasData(

                new Customer
                {
                    CustomerId = 1,
                    CustomerName = "Nguyễn Văn An",
                    PhoneNumber = "0901122334",
                    Address = "25 Nguyễn Huệ, Quận 1, TP.HCM",
                    RewardPoints = 1500,
                    MembershipRank = "Vàng"
                },

                new Customer
                {
                    CustomerId = 2,
                    CustomerName = "Trần Thị Bình",
                    PhoneNumber = "0918877665",
                    Address = "118 Võ Văn Tần, Quận 3, TP.HCM",
                    RewardPoints = 500,
                    MembershipRank = "Bạc"
                },

                new Customer
                {
                    CustomerId = 3,
                    CustomerName = "Lê Văn Cường",
                    PhoneNumber = "0983344556",
                    Address = "72 Nguyễn Trãi, Quận 5, TP.HCM",
                    RewardPoints = 100,
                    MembershipRank = "Chuẩn"
                },

                new Customer
                {
                    CustomerId = 4,
                    CustomerName = "Phạm Thị Dung",
                    PhoneNumber = "0905678123",
                    Address = "156 Thành Thái, Quận 10, TP.HCM",
                    RewardPoints = 2300,
                    MembershipRank = "Vàng"
                },

                new Customer
                {
                    CustomerId = 5,
                    CustomerName = "Hoàng Văn Đức",
                    PhoneNumber = "0912345678",
                    Address = "43 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM",
                    RewardPoints = 800,
                    MembershipRank = "Bạc"
                },

                new Customer
                {
                    CustomerId = 6,
                    CustomerName = "Võ Thị Hà",
                    PhoneNumber = "0987654321",
                    Address = "89 Phạm Văn Đồng, Quận Gò Vấp, TP.HCM",
                    RewardPoints = 3200,
                    MembershipRank = "Kim Cương"
                },

                new Customer
                {
                    CustomerId = 7,
                    CustomerName = "Đặng Văn Giang",
                    PhoneNumber = "0909876543",
                    Address = "215 Cộng Hòa, Quận Tân Bình, TP.HCM",
                    RewardPoints = 250,
                    MembershipRank = "Chuẩn"
                },

                new Customer
                {
                    CustomerId = 8,
                    CustomerName = "Bùi Thị Hoa",
                    PhoneNumber = "0913456789",
                    Address = "36 Phan Đình Phùng, Quận Phú Nhuận, TP.HCM",
                    RewardPoints = 1200,
                    MembershipRank = "Bạc"
                },

                new Customer
                {
                    CustomerId = 9,
                    CustomerName = "Đỗ Văn Hùng",
                    PhoneNumber = "0981234567",
                    Address = "102 Nguyễn Thị Thập, Quận 7, TP.HCM",
                    RewardPoints = 4500,
                    MembershipRank = "Kim Cương"
                },

                new Customer
                {
                    CustomerId = 10,
                    CustomerName = "Nguyễn Thị Khánh",
                    PhoneNumber = "0903456789",
                    Address = "68 Hậu Giang, Quận 6, TP.HCM",
                    RewardPoints = 150,
                    MembershipRank = "Chuẩn"
                },

                new Customer
                {
                    CustomerId = 11,
                    CustomerName = "Trương Văn Long",
                    PhoneNumber = "0915678901",
                    Address = "145 Võ Văn Ngân, TP. Thủ Đức, TP.HCM",
                    RewardPoints = 1800,
                    MembershipRank = "Vàng"
                },

                new Customer
                {
                    CustomerId = 12,
                    CustomerName = "Phan Thị Mai",
                    PhoneNumber = "0986789012",
                    Address = "234 Lê Văn Khương, Quận 12, TP.HCM",
                    RewardPoints = 700,
                    MembershipRank = "Bạc"
                },

                new Customer
                {
                    CustomerId = 13,
                    CustomerName = "Lý Văn Nam",
                    PhoneNumber = "0907890123",
                    Address = "57 Lũy Bán Bích, Quận Tân Phú, TP.HCM",
                    RewardPoints = 5000,
                    MembershipRank = "Kim Cương"
                },

                new Customer
                {
                    CustomerId = 14,
                    CustomerName = "Huỳnh Thị Phương",
                    PhoneNumber = "0918901234",
                    Address = "321 Tỉnh Lộ 10, Quận Bình Tân, TP.HCM",
                    RewardPoints = 350,
                    MembershipRank = "Chuẩn"
                },

                new Customer
                {
                    CustomerId = 15,
                    CustomerName = "Mai Văn Quân",
                    PhoneNumber = "0989012345",
                    Address = "78 Nguyễn Hữu Trí, Huyện Bình Chánh, TP.HCM",
                    RewardPoints = 2600,
                    MembershipRank = "Vàng"
                }
            );


            // ==========================================
            // SEED 15 PRODUCT
            // SẢN PHẨM BÁNH KẸO NHẬP KHẨU SWEET LAND
            // ==========================================

            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    ProductId = 1,
                    Barcode = "SWT000001",
                    ProductName = "Kẹo dẻo Haribo Goldbears 200g",
                    Price = 95000m,
                    StockQuantity = 100,
                    CategoryId = 7
                },

                new Product
                {
                    ProductId = 2,
                    Barcode = "SWT000002",
                    ProductName = "Socola Ferrero Rocher 16 viên",
                    Price = 189000m,
                    StockQuantity = 80,
                    CategoryId = 8
                },

                new Product
                {
                    ProductId = 3,
                    Barcode = "SWT000003",
                    ProductName = "Bánh quy bơ Danisa 454g",
                    Price = 165000m,
                    StockQuantity = 60,
                    CategoryId = 9
                },

                new Product
                {
                    ProductId = 4,
                    Barcode = "SWT000004",
                    ProductName = "Bánh xốp Loacker Quadratini Chocolate 125g",
                    Price = 79000m,
                    StockQuantity = 90,
                    CategoryId = 4
                },

                new Product
                {
                    ProductId = 5,
                    Barcode = "SWT000005",
                    ProductName = "Snack khoai tây Pringles Original 107g",
                    Price = 72000m,
                    StockQuantity = 120,
                    CategoryId = 5
                },

                new Product
                {
                    ProductId = 6,
                    Barcode = "SWT000006",
                    ProductName = "Socola KitKat Mini 170g",
                    Price = 115000m,
                    StockQuantity = 100,
                    CategoryId = 2
                },

                new Product
                {
                    ProductId = 7,
                    Barcode = "SWT000007",
                    ProductName = "Kẹo bạc hà Alpenliebe 90g",
                    Price = 35000m,
                    StockQuantity = 150,
                    CategoryId = 10
                },

                new Product
                {
                    ProductId = 8,
                    Barcode = "SWT000008",
                    ProductName = "Socola Lindt Excellence Dark 100g",
                    Price = 135000m,
                    StockQuantity = 70,
                    CategoryId = 8
                },

                new Product
                {
                    ProductId = 9,
                    Barcode = "SWT000009",
                    ProductName = "Bánh quy Oreo Original 133g",
                    Price = 45000m,
                    StockQuantity = 180,
                    CategoryId = 3
                },

                new Product
                {
                    ProductId = 10,
                    Barcode = "SWT000010",
                    ProductName = "Kẹo trái cây Skittles Fruits 125g",
                    Price = 69000m,
                    StockQuantity = 110,
                    CategoryId = 11
                },

                new Product
                {
                    ProductId = 11,
                    Barcode = "SWT000011",
                    ProductName = "Bánh ngũ cốc Kellogg's 300g",
                    Price = 145000m,
                    StockQuantity = 50,
                    CategoryId = 12
                },

                new Product
                {
                    ProductId = 12,
                    Barcode = "SWT000012",
                    ProductName = "Hộp quà Socola Merci 250g",
                    Price = 175000m,
                    StockQuantity = 45,
                    CategoryId = 14
                },

                new Product
                {
                    ProductId = 13,
                    Barcode = "SWT000013",
                    ProductName = "Hạt hạnh nhân rang muối 200g",
                    Price = 120000m,
                    StockQuantity = 75,
                    CategoryId = 13
                },

                new Product
                {
                    ProductId = 14,
                    Barcode = "SWT000014",
                    ProductName = "Kẹo dẻo Trolli Sour Glowworms 200g",
                    Price = 105000m,
                    StockQuantity = 85,
                    CategoryId = 7
                },

                new Product
                {
                    ProductId = 15,
                    Barcode = "SWT000015",
                    ProductName = "Bánh quy Walkers Shortbread 150g",
                    Price = 125000m,
                    StockQuantity = 55,
                    CategoryId = 3
                }
            );
        }
    }
}
