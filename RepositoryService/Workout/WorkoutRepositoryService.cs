using System;
using System.Linq;
using Domain;
using Repository;
using Resources;

namespace RepositoryService.Workout
{
    public interface IWorkoutRepositoryService : IRepositoryBaseService<LogResource>
    {

    }

    public class WorkoutRepositoryService : IWorkoutRepositoryService
    {
        private IRepository<WorkoutRoutine, object> _repo;
        private IWorkoutMapper _mapper;

        public WorkoutRepositoryService(IRepository<WorkoutRoutine,object> repo, IWorkoutMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public IQueryable<LogResource> GetAll()
        {
            var workoutEntities = _repo.GetAll();
            var workoutModels = workoutEntities.Select(_mapper.CreateResource).AsQueryable();
            return workoutModels;
        }

        public void Create(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(LogResource entity)
        {
            throw new NotImplementedException();
        }

        public LogResource Get(int id)
        {
            var workoutEntity = _repo.Get(id);
            var workoutModels = _mapper.CreateResource(workoutEntity);
            return workoutModels;
        }
    }
}
