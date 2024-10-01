using Microsoft.EntityFrameworkCore;
using MieShop.Query.Domain.Entities;
using MieShop.Query.Domain.Entities.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MieShop.Query.Infrastructure.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Download> Download { get; set; }
        public DbSet<MediaFile> MediaFile { get; set; }
        public DbSet<MediaFolder> MediaFolder { get; set; }
        public DbSet<MediaStorage> MediaStorage { get; set; }
        public DbSet<AddressUser> AddressUser { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<BillDetail> BillDetail { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ChatMessage> ChatMessage { get; set; }
        public DbSet<ChatMessageParticipantStates> ChatMessageParticipantStates { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<ConfirmEmail> ConfirmEmail { get; set; }
        public DbSet<Conversation> Conversation { get; set; }
        public DbSet<DiscountEvent> DiscountEvent { get; set; }
        public DbSet<EventProduct> EventProduct { get; set; }
        public DbSet<FavoriteProduct> FavoriteProduct { get; set; }
        public DbSet<Participant> Participant { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<RankCustomer> RankCustomer { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
        public DbSet<ProductDetailPropertyDetail> ProductDetailPropertyDetail { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductReview> ProductReview { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<PropertyDetail> PropertyDetail { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<ShippingMethod> ShippingMethod { get; set; }
        public DbSet<ShippingMethodProduct> ShippingMethodProduct { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<TopicShop> TopicShop { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserSession> UserSession { get; set; }
        public DbSet<UserVoucher> UserVoucher { get; set; }
        public DbSet<Voucher> Voucher { get; set; }
    }
}
