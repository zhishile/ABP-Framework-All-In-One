using System.Threading.Tasks;

namespace AbpClub.Data
{
    public interface IAbpClubDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
