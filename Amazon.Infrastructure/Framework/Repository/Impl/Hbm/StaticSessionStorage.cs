//-----------------------------------------------------------------
//
// @(#)$Id: StaticSessionStorage.cs,v 1.0 2014/09/03 11:23:02 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:23:02 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using System.Web;
using NHibernate;
using NHibernate.Impl;

namespace Amazon.Infrastructure.Framework.Repository.Impl.Hbm
{
    public class StaticSessionStorage : ISessionStorage
    {
        [ThreadStatic]
        private static ISession session = null;

        public ISession Get() {
            return session;
        }

        public void Set(ISession aSession) {
            session = aSession;
        }
    }
}