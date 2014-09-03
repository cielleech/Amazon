//-----------------------------------------------------------------
//
// @(#)$Id: ISessionStorage.cs,v 1.0 2014/09/03 11:20:55 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:20:55 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using NHibernate;

namespace Amazon.Infrastructure.Framework.Repository
{
    /// <summary>
    /// Session storage interface
    /// </summary>
    public interface ISessionStorage
    {
        ISession Get();

        void Set(ISession session);
    }
}