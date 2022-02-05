using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Domain.Entities
{
    public abstract class EntityBase : IEquatable<EntityBase>
    {
        public Guid Id { get; private set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(EntityBase? other)
        {
            return Id == other.Id;
        }
    }
}
