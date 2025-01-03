using Volo.Abp.Reflection;

namespace CommonModule.Permissions;

public class CommonModulePermissions
{
    public const string GroupName = "CommonModule";

    public static class Keyword
    {
        public const string Default = GroupName + ".Keywords";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string View = GroupName + ".View";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CommonModulePermissions));
    }
}
