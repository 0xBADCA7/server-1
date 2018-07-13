﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.Core.Models.Table;

namespace Bit.Core.Repositories
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        Task<User> GetByEmailAsync(string email);
        Task<ICollection<User>> SearchAsync(string email, int skip, int take);
        Task<ICollection<User>> GetManyByPremiumAsync(bool premium);
        Task<ICollection<User>> GetManyByPremiumRenewalAsync();
        Task<string> GetPublicKeyAsync(Guid id);
        Task<DateTime> GetAccountRevisionDateAsync(Guid id);
        Task UpdateStorageAsync(Guid id);
        Task UpdateRenewalReminderDateAsync(Guid id, DateTime renewalReminderDate);
    }
}
