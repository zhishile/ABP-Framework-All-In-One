using Volo.Abp.Settings;

namespace AbpClub.Settings
{
    public class AbpClubSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpClubSettings.MySetting1));
        }
    }
}
