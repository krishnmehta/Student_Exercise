using StudentExercise.Students;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace StudentExercise.Students;

public interface IStudentAppService :
    ICrudAppService< 
        StudentDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdateStudentDto> 
{

}
