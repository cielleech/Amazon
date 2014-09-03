//-----------------------------------------------------------------
//
// @(#)$Id: SearchServiceImpl.cs,v 1.0 2014/09/03 15:19:08 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 15:19:08 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using Amazon.Model;

namespace Amazon.Domain.Service.Impl
{
    public class SearchServiceImpl : ISearchService
    {
        //
        // Summary:
        //   Search the page by the keyword
        //
        // Parameters:
        //   keyword:
        //     the keyword which is used for search
        //
        // Returns:
        //   The PageContent for the keyword
        public PageContent Search(String keyword) {
            return null;
        }

        //
        // Summary:
        //   Search the pages by the all keywords
        //
        // Returns:
        //   the all PageCotent list
        public IList<PageContent> SearchAll() {
            return null;
        }
    }
}