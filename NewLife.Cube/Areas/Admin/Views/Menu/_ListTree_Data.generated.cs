﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    
    #line 6 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Menu/_ListTree_Data.cshtml")]
    public partial class _Areas_Admin_Views_Menu__ListTree_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.Menu>>
    {
        public _Areas_Admin_Views_Menu__ListTree_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var enableSelect = this.EnableSelect();
    //var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\n    <thead>\n        <tr>\n");

            
            #line 20 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
             if (enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\n");

            
            #line 23 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 801), Tuple.Create("\"", 840)
            
            #line 24 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 808), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 808), false)
);

WriteLiteral(">编号</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 892), Tuple.Create("\"", 941)
            
            #line 25 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 899), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("TreeNodeName"))
            
            #line default
            #line hidden
, 899), false)
);

WriteLiteral(">节点名</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 994), Tuple.Create("\"", 1042)
            
            #line 26 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1001), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("DisplayName"))
            
            #line default
            #line hidden
, 1001), false)
);

WriteLiteral(">显示名</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1095), Tuple.Create("\"", 1135)
            
            #line 27 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1102), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Url"))
            
            #line default
            #line hidden
, 1102), false)
);

WriteLiteral(">链接</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1187), Tuple.Create("\"", 1228)
            
            #line 28 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1194), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Sort"))
            
            #line default
            #line hidden
, 1194), false)
);

WriteLiteral(">排序</a></th>\n            ");

WriteLiteral("\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1377), Tuple.Create("\"", 1421)
            
            #line 30 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1384), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Visible"))
            
            #line default
            #line hidden
, 1384), false)
);

WriteLiteral(">可见</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"必要。必要的菜单，必须至少有角色拥有这些权限，如果没有则自动授权给系统角色\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1519), Tuple.Create("\"", 1565)
            
            #line 31 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
           , Tuple.Create(Tuple.Create("", 1526), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Necessary"))
            
            #line default
            #line hidden
, 1526), false)
);

WriteLiteral(">必要</a></th>\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"权限子项。逗号分隔，每个权限子项名值竖线分隔\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1648), Tuple.Create("\"", 1695)
            
            #line 32 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1655), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Permission"))
            
            #line default
            #line hidden
, 1655), false)
);

WriteLiteral(">权限子项</a></th>\n");

            
            #line 33 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 33 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">升</th>\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">降</th>\n");

WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\n");

            
            #line 38 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");

            
            #line 42 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
         foreach (var entity in Model)
        {
            var p = entity.Parent as IEntityTree;
            if (p == null)
            {
                p = fact.EntityType.GetValue("Root") as IEntityTree;
            }
            var id = entity.ID;

            
            #line default
            #line hidden
WriteLiteral("            <tr>\n");

            
            #line 51 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2423), Tuple.Create("\"", 2441)
            
            #line 53 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 2431), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 2431), false)
);

WriteLiteral(" /></td>\n");

            
            #line 54 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center hidden-md hidden-sm hidden-xs\"");

WriteLiteral(">");

            
            #line 55 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                                                 Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 56 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.TreeNodeName);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 57 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");

            
            #line 58 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.Url);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                                  Write(entity.Sort.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\n                ");

WriteLiteral("\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2860), Tuple.Create("\"", 2923)
, Tuple.Create(Tuple.Create("", 2868), Tuple.Create("glyphicon", 2868), true)
, Tuple.Create(Tuple.Create(" ", 2877), Tuple.Create("glyphicon-", 2878), true)
            
            #line 62 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2888), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "ok" : "remove"
            
            #line default
            #line hidden
, 2888), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2924), Tuple.Create("\"", 2975)
, Tuple.Create(Tuple.Create("", 2932), Tuple.Create("color:", 2932), true)
            
            #line 62 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                     , Tuple.Create(Tuple.Create(" ", 2938), Tuple.Create<System.Object, System.Int32>(entity.Visible ? "green" : "red"
            
            #line default
            #line hidden
, 2939), false)
, Tuple.Create(Tuple.Create("", 2974), Tuple.Create(";", 2974), true)
);

WriteLiteral("></i>\n                </td>\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 3067), Tuple.Create("\"", 3132)
, Tuple.Create(Tuple.Create("", 3075), Tuple.Create("glyphicon", 3075), true)
, Tuple.Create(Tuple.Create(" ", 3084), Tuple.Create("glyphicon-", 3085), true)
            
            #line 65 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3095), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "ok" : "remove"
            
            #line default
            #line hidden
, 3095), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 3133), Tuple.Create("\"", 3186)
, Tuple.Create(Tuple.Create("", 3141), Tuple.Create("color:", 3141), true)
            
            #line 65 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                       , Tuple.Create(Tuple.Create(" ", 3147), Tuple.Create<System.Object, System.Int32>(entity.Necessary ? "green" : "red"
            
            #line default
            #line hidden
, 3148), false)
, Tuple.Create(Tuple.Create("", 3185), Tuple.Create(";", 3185), true)
);

WriteLiteral("></i>\n                </td>\n                <td>");

            
            #line 67 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
               Write(entity.Permission);

            
            #line default
            #line hidden
WriteLiteral("</td>\n");

            
            #line 68 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 68 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\n");

            
            #line 71 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 71 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                         if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[0])
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3564), Tuple.Create("\"", 3600)
            
            #line 73 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3571), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id })
            
            #line default
            #line hidden
, 3571), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\n");

            
            #line 74 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\n");

            
            #line 77 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 77 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                         if (p != null && entity != p.Childs[p.Childs.Count - 1])
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3914), Tuple.Create("\"", 3952)
            
            #line 79 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 3921), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id })
            
            #line default
            #line hidden
, 3921), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\n");

            
            #line 80 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\n");

WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 83 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\n                    </td>\n");

            
            #line 85 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\n");

            
            #line 87 "..\..\Areas\Admin\Views\Menu\_ListTree_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\n</table>");

        }
    }
}
#pragma warning restore 1591
