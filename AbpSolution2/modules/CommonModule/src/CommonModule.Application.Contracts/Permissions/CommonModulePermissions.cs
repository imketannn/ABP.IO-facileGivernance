using Volo.Abp.Reflection;

namespace CommonModule.Permissions;

public class CommonModulePermissions
{
    public const string GroupName = "CommonModule";
    public const string CommonMaster = "CommonMaster";

    public static class Master
    {
        public const string CommonMaster = GroupName + ".Master";
    }
    public static class Keyword
    {
        public const string Default = GroupName + ".Keywords";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string View = Default + ".View";
    }

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CommonModulePermissions));
    }
}
