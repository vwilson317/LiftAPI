using FluentNHibernate.Mapping;

namespace Domain.Mappings
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
        }
    }
}
