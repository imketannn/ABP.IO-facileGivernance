using CommonModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CommonModule.Permissions;

public class CommonModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CommonModulePermissions.GroupName, L("Permission:CommonModule"));

        var KeywordPermission = myGroup.AddPermission(CommonModulePermissions.Keyword.Default, L("Permission:Keyword"));
        KeywordPermission.AddChild(CommonModulePermissions.Keyword.Create, L("Permission:Keyword.Create"));
        KeywordPermission.AddChild(CommonModulePermissions.Keyword.View, L("Permission:Keyword.View"));
        KeywordPermission.AddChild(CommonModulePermissions.Keyword.Edit, L("Permission:Keyword.Edit"));
        KeywordPermission.AddChild(CommonModulePermissions.Keyword.Delete, L("Permission:Keyword.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CommonModuleResource>(name);
    }
}
