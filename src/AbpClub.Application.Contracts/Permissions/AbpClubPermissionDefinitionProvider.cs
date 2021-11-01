﻿using AbpClub.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpClub.Permissions
{
    public class AbpClubPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpClubPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpClubPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpClubResource>(name);
        }
    }
}
