//-----------------------------------------------------------------
//
// @(#)$Id: RepositoryException.cs,v 1.0 2014/09/03 11:25:07 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:25:07 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;

namespace Amazon.Infrastructure.Framework.Repository
{
    [Serializable]
    public class RepositoryException : Exception {
        public RepositoryException(string message) : base(message) { }
        public RepositoryException(string message, Exception ex)
            : base(message, ex) { }
    }
}