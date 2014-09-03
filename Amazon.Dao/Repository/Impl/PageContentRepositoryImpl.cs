//-----------------------------------------------------------------
//
// @(#)$Id: PageContentRepositoryImpl.cs,v 1.0 2014/09/03 15:41:15 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 15:41:15 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using Amazon.Infrastructure.Framework.Repository.Impl.Hbm;
using Amazon.Model;
using NHibernate;

namespace Amazon.Dao.Repository.Impl
{
    /// <summary>
    /// PageContent repository implement class
    /// </summary>
    public class PageContentRepositoryImpl : RespositoryHbmImpl<PageContent>, IPageContentRepository
    {
        public void Test() {
            ITransaction transaction = Session.BeginTransaction();
        }
    }
}