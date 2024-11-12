using GigaPetProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GigaPetProject.Framework.Services;

// govnocrud by yours truly
public sealed partial class TODOService : IDbService<TODOEntity>
{
    public void Create(TODOEntity entity)
    {
        entity.CreatedAt = DateTime.Now;
        entity.UpdatedAt = DateTime.Now;
        App.DB.Todos.Add(entity);
        App.DB.SaveChanges();
    }

    public void Delete(long id)
    {
        App.DB.Todos.Remove(Get(id));
        App.DB.SaveChanges();
    }

    public TODOEntity Get(long id)
        => App.DB.Todos.Find(id);

    public IEnumerable<TODOEntity> GetAll()
        => App.DB.Todos.ToList();

    public void Update(long id, TODOEntity updatedEntity)
    {
        var ent = Get(id);
        if (ent == null)
            return;

        // update values
        // add more fields if necessary
        ent.Done = updatedEntity.Done;
        ent.Title = updatedEntity.Title;
        ent.Description = updatedEntity.Description;
        ent.DueDate = updatedEntity.DueDate;
        ent.Priority = updatedEntity.Priority;

        ent.UpdatedAt = DateTime.Now;

        App.DB.Todos.Update(ent);
        App.DB.SaveChanges();
    }
}