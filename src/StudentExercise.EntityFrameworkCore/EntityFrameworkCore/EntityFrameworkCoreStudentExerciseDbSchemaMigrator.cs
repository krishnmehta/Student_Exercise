using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentExercise.Data;
using Volo.Abp.DependencyInjection;

namespace StudentExercise.EntityFrameworkCore;

public class EntityFrameworkCoreStudentExerciseDbSchemaMigrator
    : IStudentExerciseDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentExerciseDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentExerciseDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentExerciseDbContext>()
            .Database
            .MigrateAsync();
    }
}
