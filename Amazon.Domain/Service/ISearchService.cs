//-----------------------------------------------------------------
//
// @(#)$Id: IWebSpiderService.cs,v 1.0 2014/09/03 14:50:23 lichunhua Exp $
// @(#)$Author: lichunhua  $
// @(#)$Date: 2014/09/03 14:50:23 $
// @(#)$Description:
//
//
//
//                 All Rights Reserved.
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using Amazon.Model;

namespace Amazon.Domain.Service
{
    /// <summary>
    /// The service of web spider
    /// </summary>
    public interface ISearchService
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
        PageContent Search(String keyword);

        //
        // Summary:
        //   Search the pages by the all keywords
        //
        // Returns:
        //   the all PageCotent list
        IList<PageContent> SearchAll();
    }
}
