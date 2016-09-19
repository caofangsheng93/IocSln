using Ioc.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc.Data.Mapping
{
   public class UserProfileMap:EntityTypeConfiguration<UserProfile>
    {
       public UserProfileMap()
       {
           //key  
           HasKey(t => t.Id);
           //properties             
           Property(t => t.FirstName).IsRequired().HasMaxLength(100).HasColumnType("nvarchar");
           Property(t => t.LastName).HasMaxLength(100).HasColumnType("nvarchar");
           Property(t => t.Address).HasColumnType("nvarchar");
           Property(t => t.AddedDate).IsRequired();
           Property(t => t.ModifiedDate).IsRequired();
           Property(t => t.IP);
           //table  
           ToTable("UserProfiles");
           //relation            
           HasRequired(t => t.User).WithRequiredDependent(u => u.UserProfile);  
       }
    }
}
