using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService
{
    public interface IMapper<Entity, Model>
    {
        Entity CreateEntity(Model model);
        Model CreateModel(Entity entity);
    }
}
