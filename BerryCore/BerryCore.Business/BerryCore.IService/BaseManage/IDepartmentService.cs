﻿#region << 版 本 注 释 >>

/*
* 项目名称 ：BerryCore.IService.BaseManage
* 项目描述 ：
* 类 名 称 ：IDepartmentService
* 类 描 述 ：
* 所在的域 ：DASHIXIONG
* 命名空间 ：BerryCore.IService.BaseManage
* 机器名称 ：DASHIXIONG
* CLR 版本 ：4.0.30319.42000
* 作    者 ：赵轶
* 创建时间 ：2019-12-17 16:36:19
* 更新时间 ：2019-12-17 16:36:19
* 版 本 号 ：V2.0.0.0
***********************************************************************
* Copyright © 大師兄丶 2019. All rights reserved.                     *
***********************************************************************
*/

#endregion << 版 本 注 释 >>

using BerryCore.Entity.BaseManage;
using System.Collections.Generic;

namespace BerryCore.IService.BaseManage
{
    /// <summary>
    /// 功能描述    ：IDepartmentService
    /// 创 建 者    ：赵轶
    /// 创建日期    ：2019-12-17 16:36:19
    /// 最后修改者  ：赵轶
    /// 最后修改日期：2019-12-17 16:36:19
    /// </summary>
    public interface IDepartmentService
    {
        #region 获取数据

        /// <summary>
        /// 部门列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<DepartmentEntity> GetDepartmentList();

        /// <summary>
        /// 部门实体
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns></returns>
        DepartmentEntity GetDepartmentEntity(string keyValue);

        #endregion 获取数据

        #region 验证数据

        /// <summary>
        /// 部门名称不能重复
        /// </summary>
        /// <param name="departmentName">公司名称</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        bool ExistFullName(string departmentName, string keyValue);

        /// <summary>
        /// 外文名称不能重复
        /// </summary>
        /// <param name="enCode">外文名称</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        bool ExistEnCode(string enCode, string keyValue);

        /// <summary>
        /// 中文名称不能重复
        /// </summary>
        /// <param name="shortName">中文名称</param>
        /// <param name="keyValue">主键</param>
        /// <returns></returns>
        bool ExistShortName(string shortName, string keyValue);

        #endregion 验证数据

        #region 提交数据

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="keyValue">主键</param>
        void RemoveByKey(string keyValue);

        /// <summary>
        /// 保存部门表单（新增、修改）
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <param name="departmentEntity">机构实体</param>
        /// <returns></returns>
        void AddDepartment(string keyValue, DepartmentEntity departmentEntity);

        #endregion 提交数据
    }
}