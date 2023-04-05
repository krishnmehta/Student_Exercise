using System;
using Volo.Abp.Application.Dtos;

namespace StudentExercise.Students;

public class StudentDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public int RollNo { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }
}
