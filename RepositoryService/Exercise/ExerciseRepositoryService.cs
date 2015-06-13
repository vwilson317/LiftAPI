using System;
using System.Collections.Generic;
using APIModels;

namespace RepositoryService
{
    public interface IExerciseRepositoryService : IRepositoryBaseService<ExerciseModel>
    {
        
    }

    public class ExerciseRepositoryService : IExerciseRepositoryService
    {

        public IEnumerable<ExerciseModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ExerciseModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ExerciseModel Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
