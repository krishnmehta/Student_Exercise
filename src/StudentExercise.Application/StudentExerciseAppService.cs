using System;
using System.Collections.Generic;
using System.Text;
using StudentExercise.Localization;
using Volo.Abp.Application.Services;

namespace StudentExercise;

/* Inherit your application services from this class.
 */
public abstract class StudentExerciseAppService : ApplicationService
{
    protected StudentExerciseAppService()
    {
        LocalizationResource = typeof(StudentExerciseResource);
    }
}
