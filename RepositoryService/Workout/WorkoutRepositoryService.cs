using System;
using System.Collections.Generic;
using System.Linq;
using APIModels;
using Repository;

namespace RepositoryService.Workout
{
    public interface IWorkoutRepositoryService : IRepositoryBaseService<LogModel>
    {

    }

    public class WorkoutRepositoryService : IWorkoutRepositoryService
    {
        private IWorkoutRepository _repo;
        private IWorkoutMapper _mapper;

        public WorkoutRepositoryService(IWorkoutRepository repo, IWorkoutMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IEnumerable<LogModel> GetAll()
        {
            var workoutEntities = _repo.GetAll();
            var workoutModels = workoutEntities.Select(_mapper.CreateModel).ToList();
            return workoutModels;
        }

        public LogModel Get(int id)
        {
            var workoutEntity = _repo.Get(id);
            var workoutModels = _mapper.CreateModel(workoutEntity);
            return workoutModels;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public LogModel Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
