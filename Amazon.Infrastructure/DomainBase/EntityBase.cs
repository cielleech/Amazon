//-----------------------------------------------------------------
//
// @(#)$Id: EntityBase.cs,v 1.0 2014/09/03 11:23:40 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:23:40 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;

namespace Amazon.Infrastructure.DomainBase
{
    /// <summary>
    /// Entity base class
    /// </summary>
    public abstract class EntityBase
    {
        private object key;

        /// <summary>
        /// Default contrustor
        /// </summary>
        protected EntityBase()
            : this(null) {

        }

        /// <summary>
        /// overloaded constructor
        /// </summary>
        /// <param name="akey"></param>
        protected EntityBase(object akey) {
            this.key = akey;
        }

        /*
         * represents the primary identifier value for class
         */
        public virtual object Key {
            get { return this.key; }
        }

        public override Boolean Equals(object otherObject) {
            if (otherObject == null)
                return false;

            if (!(otherObject is EntityBase))
                return false;

            return this == (EntityBase)otherObject;
        }

        public static Boolean operator ==(EntityBase currentEntity, EntityBase otherEntity) {
            if ((object)currentEntity == null && (object)otherEntity == null)
                return true;

            if ((object)currentEntity == null || (object)otherEntity == null)
                return false;

            return currentEntity.key == otherEntity.key;
        }

        public static Boolean operator !=(EntityBase currentEntity, EntityBase otherEntity) {
            return !(currentEntity == otherEntity);
        }

        public override int GetHashCode() {
            if (this.key != null)
                return this.key.GetHashCode();

            return 0;
        }
    }
}
