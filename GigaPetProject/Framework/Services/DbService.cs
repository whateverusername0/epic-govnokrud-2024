using GigaPetProject.Model;
using System.Collections.Generic;

namespace GigaPetProject.Framework.Services;

public interface IDbService<T> where T : Entity
{
    public IEnumerable<T> GetAll();
    public T Get(long id);
    public void Create(T entity);
    public void Update(long id, T updatedEntity);
    public void Delete(long id);
}