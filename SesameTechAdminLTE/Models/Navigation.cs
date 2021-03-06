﻿/*******************************************************************************************
 *Copyright (c) 2019  All Rights Reserved.
 *CLR版本: 4.0.30319.42000
 *机器名称:ZHIMATECH
 *公司名称:
 *命名空间:SesameTechAdminLTE.Models
 *文件名:Navigation
 *版本号:V1.0.0.0
 *唯一标识:dbe51f5f-6ab3-4cb1-b02e-848ec4fc3ee9
 *当前的用户域:ZHIMATECH
 *创建人:Administrator
 *电子邮箱:mzyfbz@dingtalk.com
 *创建时间:2019/11/29 11:21:27

 *描述
 *
 *==========================================================================================
 *修改标记
 *修改时间:2019/11/29 11:21:27
 *修改人:Administrator
 *版本号:V1.0.0.0
 *描述:
 *
********************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SesameTechAdminLTE.Models
{
    public class NavigationViewModel
    { 
        /// <summary>获得/设置 父级菜单ID 默认为0</summary>
        public string ParentId { set; get; }

        // <summary>获得/设置 父级菜单名称</summary>
        //public string ParentName { get; set; }

        /// <summary>获得/设置 菜单名称</summary>
        public string Name { get; set; }

        /// <summary>获得/设置 菜单序号</summary>
        public int DisplayOrder { get; set; }

        /// <summary>获得/设置 菜单图标</summary>
        public string Icon { get; set; }

        /// <summary>获得/设置 菜单URL地址</summary>
        public string Url { get; set; }

        /// <summary>获得/设置 菜单分类, 0 表示系统菜单 1 表示用户自定义菜单</summary>
        public string Category { get; set; }

        // <summary>获得 菜单分类名称，取字典表中的Name category="菜单"</summary>
        //public string CategoryName { get; set; }

        /// <summary>获得/设置 是否当前被选中 active为选中</summary>
        public string Active { get; set; }

        /// <summary>获得/设置 链接目标</summary>
        public string Target { get; set; }

        /// <summary>获得/设置 是否为资源文件, 0 表示菜单 1 表示资源 2 表示按钮</summary>
        public int IsResource { get; set; }

        /// <summary>获得/设置 所属应用程序，此属性由BA后台字典表分配</summary>
        public string Application { get; set; }

        /// <summary>获得/设置 当前菜单项的所有子菜单集合</summary>
        //public IEnumerable<Navigation> Menus { get; set; }
    }
}
