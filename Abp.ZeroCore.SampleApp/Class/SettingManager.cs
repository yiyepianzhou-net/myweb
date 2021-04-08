using Abp.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.ZeroCore.SampleApp.Class
{
    public class SettingManager : ISettingManager
    {
        public void ChangeSettingForApplication(string name, string value)
        {
            throw new NotImplementedException();
        }

        public Task ChangeSettingForApplicationAsync(string name, string value)
        {
            throw new NotImplementedException();
        }

        public void ChangeSettingForTenant(int tenantId, string name, string value)
        {
            throw new NotImplementedException();
        }

        public Task ChangeSettingForTenantAsync(int tenantId, string name, string value)
        {
            throw new NotImplementedException();
        }

        public void ChangeSettingForUser(UserIdentifier user, string name, string value)
        {
            throw new NotImplementedException();
        }

        public Task ChangeSettingForUserAsync(UserIdentifier user, string name, string value)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ISettingValue> GetAllSettingValues()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ISettingValue> GetAllSettingValues(SettingScopes scopes)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ISettingValue>> GetAllSettingValuesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ISettingValue>> GetAllSettingValuesAsync(SettingScopes scopes)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ISettingValue> GetAllSettingValuesForApplication()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ISettingValue>> GetAllSettingValuesForApplicationAsync()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ISettingValue> GetAllSettingValuesForTenant(int tenantId)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ISettingValue>> GetAllSettingValuesForTenantAsync(int tenantId)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<ISettingValue> GetAllSettingValuesForUser(UserIdentifier user)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ISettingValue>> GetAllSettingValuesForUserAsync(UserIdentifier user)
        {
            throw new NotImplementedException();
        }

        public string GetSettingValue(string name)
        {
            return "xxx";
        }

        public Task<string> GetSettingValueAsync(string name)
        {
            throw new NotImplementedException();
        }

        public string GetSettingValueForApplication(string name)
        {
            throw new NotImplementedException();
        }

        public string GetSettingValueForApplication(string name, bool fallbackToDefault)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSettingValueForApplicationAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSettingValueForApplicationAsync(string name, bool fallbackToDefault)
        {
            throw new NotImplementedException();
        }

        public string GetSettingValueForTenant(string name, int tenantId)
        {
            return "tenant";
        }

        public string GetSettingValueForTenant(string name, int tenantId, bool fallbackToDefault)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSettingValueForTenantAsync(string name, int tenantId)
        {
            return Task.FromResult("true");
        }

        public async Task<string> GetSettingValueForTenantAsync(string name, int tenantId, bool fallbackToDefault)
        {
            return await GetSettingValueForTenantAsync(name, tenantId);
        }

        public string GetSettingValueForUser(string name, int? tenantId, long userId)
        {
            throw new NotImplementedException();
        }

        public string GetSettingValueForUser(string name, int? tenantId, long userId, bool fallbackToDefault)
        {
            throw new NotImplementedException();
        }

        public string GetSettingValueForUser(string name, UserIdentifier user)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSettingValueForUserAsync(string name, int? tenantId, long userId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSettingValueForUserAsync(string name, int? tenantId, long userId, bool fallbackToDefault)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSettingValueForUserAsync(string name, UserIdentifier user)
        {
            throw new NotImplementedException();
        }
    }
}
