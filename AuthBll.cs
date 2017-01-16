/************************************************************************************
* Copyright (c) 2016 All Rights Reserved.
* CLR版本： 4.0.30319.42000
* 机器名称：LIUQC-PC
* 公司名称：中电百达兴科技有限公司
* 命名空间：WindowsFormsApplication1
* 文件名：  AuthBll
* 版本号：  V1.0.0.0
* 唯一标识：a6c7aa14-4c0e-47e3-90eb-0cacc7c35d43
* 当前的用户域：LIUQC-PC
* 创建人：  柳前程
* 电子邮箱：liuqiancheng@chinabata.cn
* 创建时间：2016-08-30 15:26:25
* 描述：
*=====================================================================
* 修改标记
* 	修改时间：2016-08-30 15:26:25
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
    class AuthBll
    {
        public static int Countdown = 0;
        public static int GetTimeout()
        {
            try
            {
                if (Countdown == 0)
                {
                    // 参数配置文件
                    string countSt = "60";
                    //Countdown = 0;
                    if (countSt == null || "".Equals(countSt.Trim()))
                    {
                        // 默认为100秒
                        Countdown = 100;
                    }
                    else
                    {
                        Countdown = int.Parse(countSt);
                    }
                }
                return Countdown;
            }
            catch
            {
                return 100;
            }
        }
    }
}
