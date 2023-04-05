using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace StudentExercise.Web;

[Dependency(ReplaceServices = true)]
public class StudentExerciseBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentExercise";
}
