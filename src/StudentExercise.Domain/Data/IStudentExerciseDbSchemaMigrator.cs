using System.Threading.Tasks;

namespace StudentExercise.Data;

public interface IStudentExerciseDbSchemaMigrator
{
    Task MigrateAsync();
}
