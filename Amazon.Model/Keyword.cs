//-----------------------------------------------------------------
//
// @(#)$Id: Class1.cs,v 1.0 2014/09/03 11:08:31 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:08:31 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using Amazon.Infrastructure.DomainBase;

namespace Amazon.Model
{
    /// <summary>
    /// Keyword model
    /// </summary>
    public class Keyword : EntityBase
    {
        /// <summary>
        /// Amazon's product ASIN code
        /// </summary>
        public virtual String ASIN { get; set; }
    }
}
