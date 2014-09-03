//-----------------------------------------------------------------
//
// @(#)$Id: IRepository.cs,v 1.0 2014/09/03 11:16:51 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:16:51 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using Amazon.Infrastructure.DomainBase;

namespace Amazon.Infrastructure.Framework.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        //
        // Summary:
        //   load entity by key, lazy
        //
        // Parameters:
        //   akey:
        //     the primary key
        //
        // Returns:
        //   the entity
        T Load(object akey);

        //
        // Summary:
        //   get entity by key, not lazy
        //
        // Parameters:
        //   akey:
        //     the primary key
        //
        // Returns:
        //   the entity
        T Get(object akey);

        //
        // Summary:
        //   get all entities
        //
        // Returns:
        //   the all entities
        IList<T> GetAll();

        //
        // Summary:
        //   save the entity
        // Parameters:
        //   entity:
        //     the entity to save
        void Save(T entity);

        //
        // Summary:
        //   update the entity
        // Parameters:
        //   entity:
        //     the entity to update
        void Update(T entity);

        //
        // Summary:
        //   delete the entity
        // Parameters:
        //   entity:
        //     the entity to delete
        void Delete(T entity);
    }
}