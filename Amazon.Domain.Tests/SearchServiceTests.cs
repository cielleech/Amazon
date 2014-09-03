//-----------------------------------------------------------------
//
// @(#)$Id: SearchServiceTests.cs,v 1.0 2014/09/03 15:17:43 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 15:17:43 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using NUnit.Framework;
using Amazon.Domain.Service;
using Amazon.Domain.Service.Impl;
using Amazon.Model;

namespace Amazon.Domain.Tests
{
    [TestFixture]
    public class SearchServiceTests
    {
        /// <summary>
        /// SearchService's Search() test
        /// </summary>
        [Test]
        public void SearchTest() {
            ISearchService service = new SearchServiceImpl();

            PageContent content = service.Search("1234");

            Assert.AreEqual(null, content);
        }

        public void SearchAllTest() {
            ISearchService service = new SearchServiceImpl();

            PageContent content = service.Search("1234");

            Assert.AreEqual(null, content);
        }
    }
}
