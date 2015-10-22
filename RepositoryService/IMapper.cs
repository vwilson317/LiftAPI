namespace RepositoryService
{
    public interface IMapper<Entity, Model>
    {
        Entity CreateEntity(Model model);
        Model CreateResource(Entity entity);
    }
}
