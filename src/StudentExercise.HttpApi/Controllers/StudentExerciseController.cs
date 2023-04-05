using StudentExercise.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace StudentExercise.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentExerciseController : AbpControllerBase
{
    protected StudentExerciseController()
    {
        LocalizationResource = typeof(StudentExerciseResource);
    }
}
