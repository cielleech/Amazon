//-----------------------------------------------------------------
//
// @(#)$Id: IContentRepository.cs,v 1.0 2014/09/03 14:33:55 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 14:33:55 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using Amazon.Infrastructure.Framework.Repository;
using Amazon.Model;

namespace Amazon.Dao.Repository
{
    /// <summary>
    /// PageContent repository interface
    /// </summary>
    public interface IPageContentRepository : IRepository<PageContent>
    {

    }
}