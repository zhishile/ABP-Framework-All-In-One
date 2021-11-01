using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpClub.Data
{
    /* This is used if database provider does't define
     * IAbpClubDbSchemaMigrator implementation.
     */
    public class NullAbpClubDbSchemaMigrator : IAbpClubDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}