using StudentExercise.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace StudentExercise;

[DependsOn(
    typeof(StudentExerciseEntityFrameworkCoreTestModule)
    )]
public class StudentExerciseDomainTestModule : AbpModule
{

}
