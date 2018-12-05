﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticDataLibrary
{
   /// <summary>
    /// 公用状态栏的全局静态数据
   /// </summary>
   public static class StrutsStripDateLib
   {
       /// <summary>
       /// 状态栏子项的Name标识
       /// </summary>
       public static class ItemName 
       {
           public const string 总字符数 = "总字符数";
           public const string 选中字符数 = "选中字符数";
           public const string 总行数 = "总行数";
           public const string 行列数 = "行列数";
           public const string 编码 = "编码";
           public const string 大小写状态 = "大小写状态";
           public const string 只读状态 = "只读状态";
       
       }
       
   }
}