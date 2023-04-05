using AutoMapper;
using StudentExercise.Students;

namespace StudentExercise;

public class StudentExerciseApplicationAutoMapperProfile : Profile
{
    public StudentExerciseApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
