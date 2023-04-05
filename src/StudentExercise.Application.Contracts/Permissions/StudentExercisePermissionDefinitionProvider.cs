using StudentExercise.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace StudentExercise.Permissions;

public class StudentExercisePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentExercisePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentExercisePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentExerciseResource>(name);
    }
}
