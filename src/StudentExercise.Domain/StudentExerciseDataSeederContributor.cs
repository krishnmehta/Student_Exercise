using System;
using System.Threading.Tasks;
using StudentExercise.Students;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace StudentExercise;

public class StudentExerciseDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Student, Guid> _studentRepository;

    public StudentExerciseDataSeederContributor(IRepository<Student, Guid> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _studentRepository.GetCountAsync() <= 0)
        {
            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Krishn Mehta",
                    RollNo = 19,
                    Age = 21,
                    Email = "kri@gmail.com",
                    Address = "Sakar Apartment"
                },
                autoSave: true
            );

            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Ramesh",
                    RollNo = 25,
                    Age = 23,
                    Email = "ra@gmail.com",
                    Address = "BlueStar Apartment"
                },
                autoSave: true
            );
        }
    }
}
