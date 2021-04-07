using Abp.Application.Features;
using System.Threading.Tasks;

namespace Abp.ZeroCore.SampleApp.Class
{
    public class AbpZeroFeatureValueStore : IAbpZeroFeatureValueStore
    {
        public string GetEditionValueOrNull(int editionId, string featureName)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetEditionValueOrNullAsync(int editionId, string featureName)
        {
            throw new System.NotImplementedException();
        }

        public string GetValueOrNull(int tenantId, string featureName)
        {
            throw new System.NotImplementedException();
        }

        public string GetValueOrNull(int tenantId, Feature feature)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetValueOrNullAsync(int tenantId, string featureName)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetValueOrNullAsync(int tenantId, Feature feature)
        {
            throw new System.NotImplementedException();
        }

        public void SetEditionFeatureValue(int editionId, string featureName, string value)
        {
            throw new System.NotImplementedException();
        }

        public Task SetEditionFeatureValueAsync(int editionId, string featureName, string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
