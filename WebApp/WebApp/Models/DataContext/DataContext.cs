using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using WebApp.Models.Model;


namespace WebApp.Models.DataContext
{
    public class DataContext : DbContext
    {
        // Constructor, bağlantı stringi adı veriliyor
        public DataContext() : base("name=MyDbConnectionString")
        {
        }

        // DbSet ile tabloları tanımlıyoruz
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdminLog> AdminLogs { get; set; }
        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactRequest> ContactRequests{ get; set; }
        public DbSet<CustomerComment> CustomerComments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SubscriptionPlans> SubscriptionPlans { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProject> UserProjects { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }


    }
}