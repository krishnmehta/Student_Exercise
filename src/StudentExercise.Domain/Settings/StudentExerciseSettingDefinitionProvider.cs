using Volo.Abp.Settings;

namespace StudentExercise.Settings;

public class StudentExerciseSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(StudentExerciseSettings.MySetting1));
    }
}
