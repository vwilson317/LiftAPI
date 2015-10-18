using System;
using APIModels;
using Repository;
using RepositoryService.Workout;

namespace RepositoryService.Exercise
{
    public interface IExerciseMapper : IMapper<Domain.Exercise, ExerciseResource>
    {

    }

    public class ExerciseMapper : IExerciseMapper
    {
        private IExerciseRepository _repo;
        private IExerciseMapper _mapper;

        public ExerciseMapper(IExerciseRepository repo, IExerciseMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public Domain.Exercise CreateEntity(ExerciseResource model)
        {
            throw new NotImplementedException();
        }

        public ExerciseResource CreateModel(Domain.Exercise entity)
        {
            throw new NotImplementedException();
        }
    }
}
