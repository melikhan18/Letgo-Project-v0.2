using Letgo.DataAccess.EntityConfiguration;
using Letgo.Entity;
using Microsoft.EntityFrameworkCore;

namespace Letgo.DataAccess
{
	public class LetgoContext : DbContext
	{

		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Brand> Brands { get; set; }
		public DbSet<Like> Likes { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<ProductTag> ProductTags { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=Letgo1;Integrated Security=true;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			modelBuilder.Entity<Like>()
			.HasKey(l => new { l.UserId, l.ProductId });

			modelBuilder.Entity<Like>()
				.HasOne(l => l.User)
				.WithMany(u => u.Likes)
				.HasForeignKey(l => l.UserId);

			modelBuilder.Entity<Like>()
				.HasOne(l => l.Product)
				.WithMany(p => p.Likes)
				.HasForeignKey(l => l.ProductId);

			modelBuilder.Entity<ProductTag>()
		   .HasKey(pt => new { pt.ProductId, pt.TagId });

			modelBuilder.Entity<ProductTag>()
				.HasOne(pt => pt.Product)
				.WithMany(p => p.ProductTags)
				.HasForeignKey(pt => pt.ProductId);

			modelBuilder.Entity<ProductTag>()
				.HasOne(pt => pt.Tag)
				.WithMany(t => t.ProductTags)
				.HasForeignKey(pt => pt.TagId);

			//Dummy data buradan sonra eklendi.
			//Role Data
			modelBuilder.Entity<Role>().HasData(
				new Role { Id = 1, Name = "admin", Description = "admin" },
				new Role { Id = 2, Name = "user", Description = "user" });

			//User Data
			modelBuilder.Entity<User>().HasData(
				new User { Id = 1, Email = "admin@gmail.com", Password = "123456", FirstName = "admin", LastName = "admin", FullName = "admin admin", Address = "test adress admin", Gender = "Erkek", DateOfBirth = DateTime.Now, RoleId = 1, isLogin = false, City = "Çankırı", ProfilePhoto = "https://cdn1.vectorstock.com/i/1000x1000/51/95/businessman-avatar-cartoon-character-profile-vector-25645195.jpg" },
				new User { Id = 2, Email = "user@gmail.com", Password = "123456", FirstName = "user", LastName = "user", FullName = "user user", Address = "test adress user", Gender = "Kadın", DateOfBirth = DateTime.Now, RoleId = 1, isLogin = false, City = "Çankırı", ProfilePhoto = "https://w0.peakpx.com/wallpaper/979/89/HD-wallpaper-purple-smile-design-eye-smily-profile-pic-face-thumbnail.jpg" });

			//Category Data
			modelBuilder.Entity<Category>().HasData(
	   new Category { Id = 1, Name = "Elektronik", Description = "Elektronik ürünler", Url = "elektronik" },
	   new Category { Id = 2, Name = "Giyim ve Moda", Description = "Giyim ve moda ürünleri", Url = "giyim-ve-moda" },
	   new Category { Id = 3, Name = "Ev ve Dekorasyon", Description = "Ev ve dekorasyon ürünleri", Url = "ev-ve-dekorasyon" },
	   new Category { Id = 4, Name = "Kitaplar", Description = "Kitaplar", Url = "kitaplar" },
	   new Category { Id = 5, Name = "Spor ve Fitness", Description = "Spor ve fitness ürünleri", Url = "spor-ve-fitness" },
	   new Category { Id = 6, Name = "Beyaz Eşya", Description = "Beyaz eşya ürünleri", Url = "beyaz-esya" }
   );

			//Brand Data
			modelBuilder.Entity<Brand>().HasData(
	new Brand { Id = 1, Name = "Samsung", Description = "Samsung markası" },
	new Brand { Id = 2, Name = "Mavi", Description = "Mavi markası" },
	new Brand { Id = 3, Name = "JACK & JONES", Description = "JACK & JONES markası" },
	new Brand { Id = 4, Name = "LTB", Description = "LTB markası" },
	new Brand { Id = 5, Name = "Vivense", Description = "Vivense markası" },
	new Brand { Id = 6, Name = "Madamecoco", Description = "Madamecoco markası" },
	new Brand { Id = 7, Name = "Koctaş", Description = "Koctaş markası" },
	new Brand { Id = 8, Name = "English Home", Description = "English Home markası" },
	new Brand { Id = 9, Name = "Kitapyurdu", Description = "Kitapyurdu markası" },
	new Brand { Id = 10, Name = "D&R", Description = "D&R markası" },
	new Brand { Id = 11, Name = "Idefix", Description = "Idefix markası" },
	new Brand { Id = 12, Name = "Morhipo", Description = "Morhipo markası" },
	new Brand { Id = 13, Name = "Decathlon", Description = "Decathlon markası" },
	new Brand { Id = 14, Name = "Koray Spor", Description = "Koray Spor markası" },
	new Brand { Id = 15, Name = "Fenerbahçe", Description = "Fenerbahçe markası" },
	new Brand { Id = 16, Name = "Flo", Description = "Flo markası" },
	new Brand { Id = 17, Name = "Arçelik", Description = "Arçelik markası" },
	new Brand { Id = 18, Name = "Vestel", Description = "Vestel markası" },
	new Brand { Id = 19, Name = "Dyson", Description = "Dyson markası" },
	new Brand { Id = 20, Name = "Apple", Description = "Apple markası" },
	new Brand { Id = 21, Name = "Nike", Description = "Nike markası" },
	new Brand { Id = 22, Name = "Adidas", Description = "Adidas markası" },
	new Brand { Id = 23, Name = "Sony", Description = "Sony markası" },
	new Brand { Id = 24, Name = "LG", Description = "LG markası" },
	new Brand { Id = 25, Name = "Zara", Description = "Zara markası" },
	new Brand { Id = 26, Name = "Ikea", Description = "Ikea markası" },
	new Brand { Id = 27, Name = "H&M Home", Description = "H&M Home markası" },
	new Brand { Id = 28, Name = "Can Yayınları", Description = "Can Yayınları markası" },
	new Brand { Id = 29, Name = "ProForm", Description = "ProForm markası" }



);
			//Product Data
			modelBuilder.Entity<Product>().HasData(
			new Product
			{
				Id = 1,
				Name = "Sony PlayStation 5",
				Description = "Sony PlayStation 5 oyun konsolu",
				Price = 499.99m,
				StockQuantity = 20,
				ImageUrl = "https://ayb.akinoncdn.com/products/2022/03/22/69499/ac28180f-78cf-4519-88a3-f4fc3facd572_size780x780_quality60_cropCenter.jpg",
				CategoryId = 1, // Örneğin Elektronik kategorisi
				Color = Color.White,
				BrandId = 23, // Örneğin Sony markası
				UserId = 1, // Örneğin kullanıcı ID'si
				CreatedDate = DateTime.Now
			},
			new Product
			{
				Id = 2,
				Name = "Apple MacBook Pro",
				Description = "Apple MacBook Pro dizüstü bilgisayar",
				Price = 2999.99m,
				StockQuantity = 30,
				ImageUrl = "https://st-troy.mncdn.com/mnresize/1500/1500/Content/media/ProductImg/original/mnej3tua-637909908281168286.jpg",
				CategoryId = 1,
				Color = Color.White,
				BrandId = 20,
				UserId = 1,
				CreatedDate = DateTime.Now
			},
			new Product
			{
				Id = 3,
				Name = "Samsung Galaxy S21",
				Description = "Samsung Galaxy S21 akıllı telefon",
				Price = 1999.99m,
				StockQuantity = 50,
				ImageUrl = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/131806-1-2_large.jpg",
				CategoryId = 1,
				Color = Color.Black,
				BrandId = 1,
				UserId = 1,
				CreatedDate = DateTime.Now
			},
				new Product
				{
					Id = 4,
					Name = "Yüksek Bel Skinny Jean",
					Description = "Yüksek bel skinny jean modeli",
					Price = 89.99m,
					StockQuantity = 50,
					ImageUrl = "https://cdn.qukasoft.com/f/864889/b3NLVUoyVTArYkI4Tmk4Z1RvTTZKYms9/images/urunler/ultra-yuksek-bel-skinny-jean-95293.webp",
					CategoryId = 2,
					Color = Color.Blue,
					BrandId = 4,
					UserId = 1,
					CreatedDate = DateTime.Now
				},
				 new Product
				 {
					 Id = 5,
					 Name = "Kadife Elbise",
					 Description = "Yumuşak kadife kumaştan yapılmış şık elbise",
					 Price = 129.99m,
					 StockQuantity = 40,
					 ImageUrl = "https://productimages.hepsiburada.net/s/146/600-800/110000100343650.jpg",
					 CategoryId = 2,
					 Color = Color.Green,
					 BrandId = 25,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 6,
					 Name = "Deri Ceket",
					 Description = "Şık ve dayanıklı deri ceket",
					 Price = 249.99m,
					 StockQuantity = 25,
					 ImageUrl = "https://static.ticimax.cloud/30422/uploads/urunresimleri/buyuk/erkek-siyah-deri-mont-siyah-d8-4e9.jpg",
					 CategoryId = 2,
					 Color = Color.Black,
					 BrandId = 2,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 7,
					 Name = "Yumuşak Yatak Örtüsü",
					 Description = "Yumuşak ve şık yatak örtüsü",
					 Price = 79.99m,
					 StockQuantity = 35,
					 ImageUrl = "https://cdn.karaca.com/image/cdndata/1/202109/200.18.01.0593/8680214255261-1.jpg",
					 CategoryId = 3,
					 Color = Color.Blue,
					 BrandId = 26,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 8,
					 Name = "Makrome Duvar Asması",
					 Description = "El yapımı makrome duvar asması",
					 Price = 59.99m,
					 StockQuantity = 30,
					 ImageUrl = "https://www.solady.com.tr/images/59591-1/Hayat-a%C4%9Fac%C4%B1-makrome-duvar-as%C4%B1l%C4%B1-boho-ev-dekor-bohemian.jpeg",
					 CategoryId = 3,
					 Color = Color.White,
					 BrandId = 27,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 9,
					 Name = "Beyaz Zambaklar Ülkesinde",
					 Description = "Grigory Petrov'un ünlü eseri",
					 Price = 29.99m,
					 StockQuantity = 50,
					 ImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0001784820001-1.jpg",
					 CategoryId = 4,
					 Color = Color.White,
					 BrandId = 28,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 10,
					 Name = "Sapiens: İnsan Türünün Kısa Bir Tarihi",
					 Description = "Yuval Noah Harari'nin çok satan eseri",
					 Price = 39.99m,
					 StockQuantity = 40,
					 ImageUrl = "https://i0.wp.com/www.okudumizledimgezdim.com/wp-content/uploads/2020/09/IMG_0635.jpg?resize=1080%2C1440",
					 CategoryId = 4,
					 Color = Color.Black,
					 BrandId = 28,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 11,
					 Name = "Spor Matı",
					 Description = "Kaliteli ve dayanıklı spor matı",
					 Price = 49.99m,
					 StockQuantity = 20,
					 ImageUrl = "https://cdn03.ciceksepeti.com/cicek/kcm87519614-1/XL/cift-tarafli-8mm-pilates-minderi-egzersiz-minderi-yoga-mati-pilates-mati-pembe-kcm87519614-1-3bc468bddca7405a8d4b4d595c014983.jpg",
					 CategoryId = 5,
					 Color = Color.Blue,
					 BrandId = 21,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 12,
					 Name = "Koşu Bandı",
					 Description = "Profesyonel koşu bandı",
					 Price = 1999.99m,
					 StockQuantity = 10,
					 ImageUrl = "https://productimages.hepsiburada.net/s/43/1500/10757124423730.jpg",
					 CategoryId = 5,
					 Color = Color.Black,
					 BrandId = 29,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 13,
					 Name = "Buzdolabı",
					 Description = "Enerji verimli buzdolabı",
					 Price = 2499.99m,
					 StockQuantity = 15,
					 ImageUrl = "https://www.arcelik.com.tr/medias/7282120192-LO1-20200409-154345.png?context=bWFzdGVyfGltYWdlc3wyMDM0Nzc0fGltYWdlL3BuZ3xoZWQvaGM1LzExMjk5NTM1MTkyMDk0LzcyODIxMjAxOTJfTE8xXzIwMjAwNDA5XzE1NDM0NS5wbmd8YWE0YjNlMzQ4NzBhY2QwYWM1ODYyYjhlZjE5Y2Q4MDQ5N2VhY2M4ZjM4NWUxMWMwNzBiMGI2NTdhYTMxZjVhZA",
					 CategoryId = 6,
					 Color = Color.White,
					 BrandId = 17,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 14,
					 Name = "Çamaşır Makinesi",
					 Description = "Yüksek kapasiteli çamaşır makinesi",
					 Price = 1999.99m,
					 StockQuantity = 8,
					 ImageUrl = "https://statics.vestel.com.tr/productimages/20263189_r1_1000_1000.jpg",
					 CategoryId = 6,
					 Color = Color.White,
					 BrandId = 18,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 16,
					 Name = "Akıllı Telefon",
					 Description = "Yeni nesil akıllı telefon",
					 Price = 2999.99m,
					 StockQuantity = 10,
					 ImageUrl = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/samsung/thumb/135498-1_large.jpg",
					 CategoryId = 1,
					 Color = Color.Black,
					 BrandId = 20,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 17,
					 Name = "Kadın Ceketi",
					 Description = "Şık ve modern kadın ceketi",
					 Price = 149.99m,
					 StockQuantity = 20,
					 ImageUrl = "https://cdn.sorsware.com/oxxo/ContentImages/Product/23y/23YOX-POLDUZCEK1/klasik-blazer-ceket_sulphur-sari_1_detay.jpg",
					 CategoryId = 2,
					 Color = Color.Red,
					 BrandId = 25,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 18,
					 Name = "Yatak Odası Takımı",
					 Description = "Şık ve rahat yatak odası takımı",
					 Price = 2999.99m,
					 StockQuantity = 5,
					 ImageUrl = "https://www.berkemobilya.com.tr/media/catalog/product/cache/1/image/2000x1120/8cda07290adf5b61edee0d4066c5caef/_/y/_yatak.jpg",
					 CategoryId = 3,
					 Color = Color.White,
					 BrandId = 27,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 19,
					 Name = "Dekoratif Yastık",
					 Description = "Renkli ve desenli dekoratif yastık",
					 Price = 49.99m,
					 StockQuantity = 12,
					 ImageUrl = "https://m.media-amazon.com/images/I/81P8HGmxw7L._AC_UF1000,1000_QL80_.jpg",
					 CategoryId = 3,
					 Color = Color.Green,
					 BrandId = 27,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 20,
					 Name = "Bilim Kurgu Romanı",
					 Description = "Heyecan dolu bilim kurgu romanı",
					 Price = 29.99m,
					 StockQuantity = 4,
					 ImageUrl = "https://img-s1.onedio.com/id-553e1d9380b8f1f91ff0ee0b/rev-0/w-600/h-600/f-jpg/s-a04463fda12368eb6adbb3a9001fc6d3fce31517.jpg",
					 CategoryId = 4,
					 Color = Color.White,
					 BrandId = 28,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 21,
					 Name = "Bilim Kurgu Romanı 2",
					 Description = "Heyecan dolu bilim kurgu romanı",
					 Price = 29.99m,
					 StockQuantity = 4,
					 ImageUrl = "https://cdn.bkmkitap.com/Data/EditorFiles/Blog/blog-urunler/marsli-andy-weir.jpg",
					 CategoryId = 4,
					 Color = Color.White,
					 BrandId = 28,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 22,
					 Name = "Spor Ayakkabı",
					 Description = "Konforlu ve şık spor ayakkabı",
					 Price = 149.99m,
					 StockQuantity = 8,
					 ImageUrl = "https://akn-ss.b-cdn.net/products/2022/01/28/340690/5f2e615e-3ed0-47eb-a7b8-7022d59dc0d3_size1400x1400_quality100.jpg",
					 CategoryId = 5,
					 Color = Color.Blue,
					 BrandId = 22,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 23,
					 Name = "Spor Ayakkabı 2",
					 Description = "Konforlu ve şık spor ayakkabı",
					 Price = 149.99m,
					 StockQuantity = 8,
					 ImageUrl = "https://akn-ss.b-cdn.net/products/2023/01/30/747531/0ce73cac-6f98-4056-b846-4f7d8cada4e7_size1400x1400_quality100.jpg",
					 CategoryId = 5,
					 Color = Color.Blue,
					 BrandId = 22,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 24,
					 Name = "Arçelik Fırın",
					 Description = "Arçelik Fırın özel üretim",
					 Price = 149.99m,
					 StockQuantity = 8,
					 ImageUrl = "https://cdn.cimri.io/image/1200x1200/arelikminimidifrnlarfiyatlar_419046742.jpg",
					 CategoryId = 6,
					 Color = Color.Blue,
					 BrandId = 17,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 },
				 new Product
				 {
					 Id = 25,
					 Name = "Dyson süpürge",
					 Description = "Dyson süpürge özel üretim",
					 Price = 149.99m,
					 StockQuantity = 8,
					 ImageUrl = "https://dyson-h.assetsadobe2.com/is/image/content/dam/dyson/leap-petite-global/markets/turkey/fc/V10.jpg?$responsive$&cropPathE=desktop&fit=stretch,1&wid=1920",
					 CategoryId = 6,
					 Color = Color.Blue,
					 BrandId = 19,
					 UserId = 1,
					 CreatedDate = DateTime.Now
				 }

	);

			//Tags data
			modelBuilder.Entity<Tag>().HasData(
			new Tag { TagId = 1, TagName = "Kadın" },
			new Tag { TagId = 2, TagName = "Erkek" },
			new Tag { TagId = 3, TagName = "Anne" },
			new Tag { TagId = 4, TagName = "Çocuk" },
			new Tag { TagId = 5, TagName = "Ev & Mobilya" },
			new Tag { TagId = 6, TagName = "Ayakkabı & Çanta" },
			new Tag { TagId = 7, TagName = "Elektronik" },
			new Tag { TagId = 8, TagName = "Spor & Outdoor" },
			new Tag { TagId = 9, TagName = "Çok Satanlar" }
		);

			//Product Tags Data
			modelBuilder.Entity<ProductTag>().HasData(
				new ProductTag { ProductId = 1, TagId = 7 },
				new ProductTag { ProductId = 2, TagId = 7 },
				new ProductTag { ProductId = 3, TagId = 7 },
				new ProductTag { ProductId = 4, TagId = 2 },
				new ProductTag { ProductId = 5, TagId = 1 },
				new ProductTag { ProductId = 6, TagId = 8 },
				new ProductTag { ProductId = 7, TagId = 5 },
				new ProductTag { ProductId = 8, TagId = 5 },
				new ProductTag { ProductId = 9, TagId = 9 },
				new ProductTag { ProductId = 10, TagId = 4 }

				);
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new OrderConfiguration());
			modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
			modelBuilder.ApplyConfiguration(new BrandConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
