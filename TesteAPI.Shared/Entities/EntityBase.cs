using System;
using System.ComponentModel.DataAnnotations;

namespace TesteAPI.Shared.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; protected set; }
    }
}
