using StudentExercise.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace StudentExercise.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentExerciseEntityFrameworkCoreModule),
    typeof(StudentExerciseApplicationContractsModule)
    )]
public class StudentExerciseDbMigratorModule : AbpModule
{

}
