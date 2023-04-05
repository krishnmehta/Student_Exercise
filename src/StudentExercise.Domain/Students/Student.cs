using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace StudentExercise.Students;

public class Student : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    public int RollNo { get; set; }

    public int Age { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }
}
