using Volo.Abp.Modularity;

namespace StudentExercise;

[DependsOn(
    typeof(StudentExerciseApplicationModule),
    typeof(StudentExerciseDomainTestModule)
    )]
public class StudentExerciseApplicationTestModule : AbpModule
{

}
