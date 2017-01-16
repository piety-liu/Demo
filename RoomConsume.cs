/************************************************************************************
* Copyright (c) 2017 All Rights Reserved.
* CLR版本： 4.0.30319.42000
* 机器名称：LIUQC-PC
* 公司名称：中电百达兴科技有限公司
* 命名空间：WindowsFormsApplication1
* 文件名：  RoomConsume
* 版本号：  V1.0.0.0
* 唯一标识：92019f46-0410-4b9d-98a1-6f066bd96a49
* 当前的用户域：LIUQC-PC
* 创建人：  柳前程
* 电子邮箱：liuqiancheng@chinabata.cn
* 创建时间：2017-01-13 星期五 11:53:08
* 描述：
*=====================================================================
* 修改标记
* 	修改时间：2017-01-13 星期五 11:53:08
* 	修改人： liuqc
* 	版本号： V1.0.0.0
*   描述：
/************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// 房间消费项目
    /// </summary>
    public class RoomConsume
    {
        /// <summary>
        /// 名称
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 价格
        /// </summary>
        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        private string unit;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        /// <summary>
        /// 数量
        /// </summary>
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
