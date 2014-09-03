//-----------------------------------------------------------------
//
// @(#)$Id: SessionFactory.cs,v 1.0 2014/09/03 11:15:44 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:15:44 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.SqlCommand;

namespace Amazon.Infrastructure.Framework.Repository.Impl.Hbm
{
    /// <summary>
    /// Session factory
    /// </summary>
    public class SessionFactory
    {
        private static ISessionFactory sessionFactory;
        private static ISessionStorage sessionStorage;

        static SessionFactory()
        {
            try
            {
                sessionStorage = new HttpSessionStorage();
                Configuration cfg = new Configuration().Configure();
                sessionFactory = cfg.BuildSessionFactory();
            }
            catch (System.Exception ex)
            {
                System.Console.Write(ex.Message);
            }
        }

        /*
         * 创建Session
         */
        public static ISession CreateSession()
        {
            lock (sessionFactory)
            {
                ISession session = sessionStorage.Get();
                if (session == null)
                {
                    session = sessionFactory.OpenSession();
                    sessionStorage.Set(session);
                }
                return session;
            }
        }

        public static void CloseSession()
        {
            ISession session = sessionStorage.Get();
            if (session != null && session.IsOpen)
            {
                session.Close();
                sessionStorage.Set(null);
            }
        }
    }


    [Serializable]
    public class EmptyInterceptor : IInterceptor
    {   //前面省略n行代码   

        public virtual SqlString OnPrepareStatement(SqlString sql) {

            return sql;

        }


        public void AfterTransactionBegin(ITransaction tx) {
            //throw new NotImplementedException();  
        }

        public void AfterTransactionCompletion(ITransaction tx) {
            //throw new NotImplementedException();  
        }

        public void BeforeTransactionCompletion(ITransaction tx) {
            //throw new NotImplementedException();  
        }

        public int[] FindDirty(object entity, object id, object[] currentState, object[] previousState, string[] propertyNames, NHibernate.Type.IType[] types) {
            //throw new NotImplementedException();  
            return null;
        }

        public object GetEntity(string entityName, object id) {
            //throw new NotImplementedException();  
            return null;
        }

        public string GetEntityName(object entity) {
            //throw new NotImplementedException();  
            return "";
        }

        public object Instantiate(string entityName, EntityMode entityMode, object id) {
            //throw new NotImplementedException();  
            return null;
        }

        public bool? IsTransient(object entity) {
            //throw new NotImplementedException();  
            return true;
        }

        public void OnCollectionRecreate(object collection, object key) {
            //throw new NotImplementedException();  
        }

        public void OnCollectionRemove(object collection, object key) {
            //throw new NotImplementedException();  
        }

        public void OnCollectionUpdate(object collection, object key) {
            //throw new NotImplementedException();  
        }

        public void OnDelete(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types) {
            //throw new NotImplementedException();  
        }

        public bool OnFlushDirty(object entity, object id, object[] currentState, object[] previousState, string[] propertyNames, NHibernate.Type.IType[] types) {
            //throw new NotImplementedException();  
            return true;
        }

        public bool OnLoad(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types) {
            //throw new NotImplementedException();  
            return true;
        }

        public bool OnSave(object entity, object id, object[] state, string[] propertyNames, NHibernate.Type.IType[] types) {
            //throw new NotImplementedException();  
            return true;
        }

        public void PostFlush(System.Collections.ICollection entities) {
            //throw new NotImplementedException();  
        }

        public void PreFlush(System.Collections.ICollection entities) {
            //throw new NotImplementedException();  
        }

        public void SetSession(ISession session) {
            //throw new NotImplementedException();  
        }
    }
    public class MyInterceptor : EmptyInterceptor
    {

        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql) {
            Console.WriteLine(sql.ToString());
            return base.OnPrepareStatement(sql);

        }

    }   
}