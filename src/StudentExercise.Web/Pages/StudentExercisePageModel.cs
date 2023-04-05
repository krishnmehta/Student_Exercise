using StudentExercise.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace StudentExercise.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentExercisePageModel : AbpPageModel
{
    protected StudentExercisePageModel()
    {
        LocalizationResourceType = typeof(StudentExerciseResource);
    }
}
