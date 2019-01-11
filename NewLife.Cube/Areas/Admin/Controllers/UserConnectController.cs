﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using NewLife.Cube.Entity;
using XCode;
using XCode.Membership;

namespace NewLife.Cube.Admin.Controllers
{
    /// <summary>用户链接控制器</summary>
    [DisplayName("用户链接")]
    [Description("第三方登录信息")]
    [Area("Admin")]
    public class UserConnectController : EntityController<UserConnect>
    {
        static UserConnectController()
        {
            ListFields.RemoveField("AccessToken");
            ListFields.RemoveField("RefreshToken");
            ListFields.RemoveField("Avatar");
        }

        /// <summary>菜单不可见</summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        protected override IDictionary<MethodInfo, Int32> ScanActionMenu(IMenu menu)
        {
            if (menu.Visible)
            {
                menu.Visible = false;
                (menu as IEntity).Save();
            }

            return base.ScanActionMenu(menu);
        }
    }
}