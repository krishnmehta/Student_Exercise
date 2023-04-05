using Microsoft.AspNetCore.Authorization;
using StudentExercise.Students;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace StudentExercise.Students;
[Authorize]
public class StudentAppService :
    CrudAppService<
        Student, 
        StudentDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateStudentDto>,  
    IStudentAppService 
{
    public StudentAppService(IRepository<Student, Guid> repository)
        : base(repository)
    {

    }
}
