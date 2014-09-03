//-----------------------------------------------------------------
//
// @(#)$Id: Content.cs,v 1.0 2014/09/03 11:38:48 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 11:38:48 $
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
    public class PageContent : EntityBase
    {
        /// <summary>
        /// Amazon's product ASIN code
        /// </summary>
        public virtual String ASIN { get; set; }

        /// <summary>
        /// Search date
        /// </summary>
        public virtual DateTime Date { get; set; }

        /// <summary>
        /// Sale price
        /// </summary>
        public virtual double SalePrice { get; set; }

        /// <summary>
        /// Reference price
        /// </summary>
        public virtual double ReferencePrice { get; set; }

        /// <summary>
        /// Reduction price
        /// </summary>
        public virtual double ReductionPrice { get; set; }

        /// <summary>
        /// The first kind rank
        /// </summary>
        public virtual int Rank1st { get; set; }

        /// <summary>
        /// The second kind rank
        /// </summary>
        public virtual int Rank2nd { get; set; }

        /// <summary>
        /// the third kind rank
        /// </summary>
        public virtual int Rank3rd { get; set; }

        /// <summary>
        /// Picture
        /// </summary>
        public virtual byte[] Picture { get; set; }
    }
}
