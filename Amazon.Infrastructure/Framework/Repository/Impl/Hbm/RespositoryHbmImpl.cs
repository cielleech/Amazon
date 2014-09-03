//-----------------------------------------------------------------
//
// @(#)$Id: RespositoryHbmImp.cs,v 1.0 2014/09/03 11:15:05 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:15:05 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System.Collections.Generic;
using Amazon.Infrastructure.DomainBase;
using Amazon.Infrastructure.Framework.Repository.Impl.Hbm;
using NHibernate;

namespace Amazon.Infrastructure.Framework.Repository.Impl.Hbm
{
    public abstract class RespositoryHbmImpl<T> : IRepository<T> where T : EntityBase {
        protected ISession Session {
            get {
                    return SessionFactory.CreateSession();
            }
        }
        
        /*
         * 根据主键延时载入实体
         */
        public virtual T Load(object akey) {
            try {
                T result = Session.Load<T>(akey);

                if (result == null)
                    throw new RepositoryException("返回实体为空");

                return result;
            }
            catch(System.Exception ex)
            {
                throw new RepositoryException("获取实体失败", ex);
            }
        }

        /*
         * 根据主键载入实体
         */
        public virtual T Get(object akey) {
            try {
                T result = Session.Get<T>(akey);

                if (result == null)
                    throw new RepositoryException("返回实体为空");

                return result;
            }
            catch(System.Exception ex)
            {
                throw new RepositoryException("获取实体失败", ex);
            }
        }

        /*
         * 获取所有实体
         */
        public virtual IList<T> GetAll() {
            try {
                return Session.CreateCriteria<T>().List<T>();
            }
            catch (System.Exception ex) {
                throw new RepositoryException("获取实体失败", ex);
            }
        }

        /*
         * 保存实体
         */
        public virtual void Save(T entity) {
            try {
                Session.SaveOrUpdate(entity);
                Session.Flush();
            }
            catch (System.Exception ex) {
                throw new RepositoryException("保存实体失败", ex);
            }
        }

        /*
         * 更新实体
         */
        public virtual void Update(T entity) {
            try {
                Session.Update(entity);
                Session.Flush();
            }
            catch (System.Exception ex) {
                throw new RepositoryException("更新实体失败", ex);
            }
        }

        /*
         * 删除实体
         */
        public virtual void Delete(T entity) {
            try {
                Session.Delete(entity);
                Session.Flush();
            }
            catch (System.Exception ex) {
                throw new RepositoryException("删除实体失败", ex);
            }
        }
    }
}