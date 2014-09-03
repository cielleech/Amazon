//-----------------------------------------------------------------
//
// @(#)$Id: SessionModule.cs,v 1.0 2014/09/03 11:16:18 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:16:18 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using System.Web;
using Amazon.Infrastructure.Framework.Repository.Impl.Hbm;

namespace Amazon.Infrastructure.Framework.Repository.Impl.Hbm
{
    /// <summary>
    /// Summary description for SessionModule
    /// </summary>
    public class SessionModule : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(Context_BeginRequest);
            context.EndRequest += new EventHandler(Context_EndRequest);
        }

        public void Context_BeginRequest(object sender, EventArgs e)
        {
            SessionFactory.CreateSession();
        }

        public void Context_EndRequest(object sender, EventArgs e)
        {
            SessionFactory.CloseSession();
        }
    }
}