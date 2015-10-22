using System;
using Resources;

namespace RepositoryService.Exercise
{
    public interface IExerciseMapper : IMapper<Domain.Exercise, ExerciseResource>
    {

    }

    public class ExerciseMapper : IExerciseMapper
    {
        private IExerciseMapper _mapper;

        public ExerciseMapper(IExerciseMapper mapper)
        {
            _mapper = mapper;
        }

        public Domain.Exercise CreateEntity(ExerciseResource model)
        {
            throw new NotImplementedException();
        }

        public ExerciseResource CreateResource(Domain.Exercise entity)
        {
            throw new NotImplementedException();
        }
    }
}
