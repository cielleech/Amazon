//-----------------------------------------------------------------
//
// @(#)$Id: HttpSessionStorage.cs,v 1.0 2014/09/03 11:15:26 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:15:26 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System.Web;
using NHibernate;

namespace Amazon.Infrastructure.Framework.Repository.Impl.Hbm
{
    public class HttpSessionStorage : ISessionStorage
    {
        public ISession Get()
        {
            return HttpContext.Current.Items["OIGHibernate"] as ISession;
        }

        public void Set(ISession session)
        {
            if (session == null)
                HttpContext.Current.Items.Remove("OIGHibernate");
            else
                HttpContext.Current.Items.Add("OIGHibernate", session);
        }

        //public ISession Session
        //{
           
        //    get
        //    {
                
        //    }

        //    set
        //    {
        //        if (value == null)
        //            HttpContext.Current.Items.Remove("OIGHibernate");
        //        else
        //            HttpContext.Current.Items.Add("OIGHibernate", value);
        //    }
        //}
    }
}