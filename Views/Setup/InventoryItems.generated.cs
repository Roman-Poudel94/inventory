﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.Inventory;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Setup/InventoryItems.cshtml")]
    public partial class _Views_Setup_InventoryItems_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Setup_InventoryItems_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Setup\InventoryItems.cshtml"
  
    ViewBag.Title = "Inventory Items";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"I" +
"nventory Items\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/inventory/item-scrud_" +
"view\";\r\n    scrudFactory.viewTableName = \"inventory.item-scrud-view\";\r\n\r\n    scr" +
"udFactory.formAPI = \"/api/forms/inventory/items\";\r\n    scrudFactory.formTableNam" +
"e = \"inventory.items\";\r\n\r\n    scrudFactory.excludedColumns = [\"audit_user_id\", \"" +
"audit_ts\", \"photo\"];\r\n\r\n    scrudFactory.allowDelete = true;\r\n    scrudFactory.a" +
"llowEdit = true;\r\n\r\n    scrudFactory.live = \"ItemName\";\r\n    scrudFactory.upload" +
"Hanlder = \"/dashboard/inventory/services/attachments\";\r\n\r\n    scrudFactory.card " +
"= {\r\n        image: \"photo\",\r\n        header: \"item_name\",\r\n        meta: \"item_" +
"code\",\r\n        description: \"unit_name\"        \r\n    };\r\n\r\n    scrudFactory.lay" +
"out = [\r\n        {\r\n            tab: \"\",\r\n            fields: [\r\n               " +
" [\"ItemId\", \"\"],\r\n                [\"Photo\"],\r\n                [\"ItemCode\", \"Item" +
"Name\"],\r\n            ]\r\n        }\r\n    ];\r\n\r\n    scrudFactory.keys = [\r\n        " +
"{\r\n            property: \"ItemGroupId\",\r\n            url: \'/api/forms/inventory/" +
"item-groups/display-fields\',\r\n            data: null,\r\n            valueField: \"" +
"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n            proper" +
"ty: \"ItemTypeId\",\r\n            url: \'/api/forms/inventory/item-types/display-fie" +
"lds\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n            text" +
"Field: \"Value\"\r\n        },\r\n        {\r\n            property: \"BrandId\",\r\n       " +
"     url: \'/api/forms/inventory/brands/display-fields\',\r\n            data: null," +
"\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n  " +
"      {\r\n            property: \"PreferredSupplierId\",\r\n            url: \'/api/fo" +
"rms/inventory/suppliers/display-fields\',\r\n            data: null,\r\n            v" +
"alueField: \"Key\",\r\n            textField: \"Value\"\r\n        },\r\n        {\r\n      " +
"      property: \"UnitId\",\r\n            url: \'/api/forms/inventory/units/display-" +
"fields\',\r\n            data: null,\r\n            valueField: \"Key\",\r\n            t" +
"extField: \"Value\"\r\n        },\r\n        {\r\n            property: \"IsVariantOf\",\r\n" +
"            url: \'/api/forms/inventory/items/display-fields\',\r\n            data:" +
" null,\r\n            valueField: \"Key\",\r\n            textField: \"Value\"\r\n        " +
"},\r\n        {\r\n            property: \"ReorderUnitId\",\r\n            url: \'/api/fo" +
"rms/inventory/units/display-fields\',\r\n            data: null,\r\n            value" +
"Field: \"Key\",\r\n            textField: \"Value\"\r\n        }\r\n    ];\r\n\r\n\r\n\r\n    $.ge" +
"t(\'/ScrudFactory/View.html\', function (view) {\r\n        $.get(\'/ScrudFactory/For" +
"m.html\', function (form) {\r\n            $(\"#ScrudFactoryView\").html(view);\r\n    " +
"        $(\"#ScrudFactoryForm\").html(form);\r\n            $.cachedScript(\"/assets/" +
"js/scrudfactory-view.js\");\r\n            $.cachedScript(\"/assets/js/scrudfactory-" +
"form.js\");\r\n        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
