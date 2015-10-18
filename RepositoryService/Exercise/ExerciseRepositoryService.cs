using System;
using System.Collections.Generic;
using APIModels;

namespace RepositoryService
{
    public interface IExerciseRepositoryService : IRepositoryBaseService<ExerciseResource>
    {
        
    }

    public class ExerciseRepositoryService : IExerciseRepositoryService
    {

        public IEnumerable<ExerciseResource> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExerciseResource Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ExerciseResource Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
