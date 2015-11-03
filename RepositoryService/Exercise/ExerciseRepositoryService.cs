using System;
using System.Linq;
using Repository;
using RepositoryService.Common;
using Resources;

namespace RepositoryService.Exercise
{
    public interface IExerciseRepositoryService : IRepositoryService<ExerciseResource>
    {
        
    }

    public class ExerciseRepositoryService : IExerciseRepositoryService
    {
        private IRepository<Domain.Exercise> _repo;
        private IMapper<Domain.Exercise, ExerciseResource> _mapper;

        public ExerciseRepositoryService(IRepository<Domain.Exercise> repo, IMapper<Domain.Exercise, ExerciseResource> mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public void Create(ExerciseResource entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ExerciseResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ExerciseResource entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(ExerciseResource entity)
        {
            throw new NotImplementedException();
        }

        public ExerciseResource Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ExerciseResource> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
