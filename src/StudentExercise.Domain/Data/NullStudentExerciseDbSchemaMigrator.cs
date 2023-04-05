using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace StudentExercise.Data;

/* This is used if database provider does't define
 * IStudentExerciseDbSchemaMigrator implementation.
 */
public class NullStudentExerciseDbSchemaMigrator : IStudentExerciseDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
