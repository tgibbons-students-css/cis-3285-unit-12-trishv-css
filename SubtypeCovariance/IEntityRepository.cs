using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: CIS3285, Trish Valeri
//version: 11/27/17
namespace SubtypeCovariance
{
    /// <summary>interface that uses generics to return a User type 
    /// instead of an Entity type.</summary>
    /// <typeparam name="TEntity">generic type (contained in the Entity class hierarchy)</typeparam>
    public interface IEntityRepository<TEntity>
        where TEntity : Entity
    {
        TEntity GetByID(Guid id);
    }
    
}
