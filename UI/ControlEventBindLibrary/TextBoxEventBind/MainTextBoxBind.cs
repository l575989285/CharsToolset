﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Ui.ControlEventLibrary.TextBoxEvent;
using Core.CacheLibrary.OperateCache.TextBoxOperateCache;
using Core.CacheLibrary.ControlCache;
using Core.StaticMethod.Method.Utils;
using UI.ComponentLibrary.ControlLibrary.RightMenu;
using Core.DefaultData.DataLibrary;

namespace UI.ControlEventBindLibrary.TextBoxEventBind
{
    internal class MainTextBoxBind
    {
        /// <summary>
        /// 文本框文本改变事件
        /// </summary>
        internal void textBoxChanged(object sender, EventArgs e){
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.内容改变事件, textBox);
        }

        /// <summary>
        /// 文本框鼠标移过事件
        /// </summary>
        internal void textBoxMouseMove(object sender, MouseEventArgs e){
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.鼠标移过事件, textBox);
        }
        /// <summary>
        /// 文本框的鼠标在组件内并释放鼠标按键事件
        /// </summary>
        internal void textBoxMouseUp(object sender, MouseEventArgs e){
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.鼠标按下事件, textBox);
        }
        /// <summary>
        /// 文本框的鼠标按下事件
        /// </summary>
        internal void textBoxMouseDown(object sender, MouseEventArgs e){
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.鼠标按下事件, textBox);
        }
        /// <summary>
        /// 文本框的鼠标移入事件
        /// </summary>
        internal void textBoxMouseEnter(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.鼠标移入事件, textBox);
        }
        /// <summary>
        /// 文本框启用事件
        /// </summary>
        internal void textBoxEnter(object sender, EventArgs e){
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.控件启用事件, textBox);
        }
        /// <summary>
        /// 文本框获得焦点事件
        /// </summary>
        internal void textBoxGotFocus(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.获取焦点事件, textBox);
        }
        /// <summary>
        /// 文本框的键盘按下事件
        /// </summary>
        internal void textBoxKeyDown(object sender, KeyEventArgs e) {
            TextBox textBox = (TextBox) sender;
            setEventBindMethod(TextBoxEventTypeEnum.键盘按下事件, textBox);
            /*============绑定文本框按键按下事件执行方法===================*/
            textBoxkeyDownBinding(e, textBox);
            
        }
        /// <summary>
        /// 文本框的键盘松开事件
        /// </summary>
        internal void textBoxKeyUp(object sender, KeyEventArgs e) {
            TextBox textBox = (TextBox)sender;
            setEventBindMethod(TextBoxEventTypeEnum.键盘松开事件, textBox);
            /*============绑定文本框按键松开事件执行方法===================*/
            textBoxkeyUpBinding(e, textBox);
            
        }
        /// <summary>
        /// 文本框键盘按下事件绑定
        /// </summary>
        private void textBoxkeyDownBinding(KeyEventArgs e,TextBox t) {
            try {
                Dictionary<Type, object> data = new Dictionary<Type, object>();
                data.Add(typeof(TextBox), t);
                // 全选
                if(e.Control && e.KeyCode.Equals(Keys.A)) {
                    TextBoxUtilsMet.textAllSelect(t);
                }
                // 撤销
                if(e.Control && e.KeyCode.Equals(Keys.Z)) { 
                    // 将文本框置于撤销状态
                    MainTextBoxEventMet.cancelTextBoxCache(data);
                }
                // 恢复
                if(e.Control && e.KeyCode.Equals(Keys.Y)) { 
                    // 将文本框置于恢复状态
                    MainTextBoxEventMet.restoreTextBoxCache(data);
                }
            } catch(Exception exc) {
                Console.WriteLine(exc.StackTrace);
            }
            
        }

        /// <summary>
        /// 文本框松开事件绑定
        /// </summary>
        private void textBoxkeyUpBinding(KeyEventArgs e, TextBox t) {
            try {
                
            } catch(Exception exc) {
                Console.WriteLine(exc.StackTrace);
            }
            
        }
        /// <summary>
        /// 文本框事件类型对应的执行方法
        /// </summary>
        private void setEventBindMethod(TextBoxEventTypeEnum eventType, TextBox textBox) { 
            StatusStrip toolStrip = ControlCacheFactory.getSingletonCache().ContainsKey(EnumUtilsMet.GetDescription(DefaultNameEnum.TOOL_START)) ?
            (StatusStrip)ControlCacheFactory.getSingletonCache()[EnumUtilsMet.GetDescription(DefaultNameEnum.TOOL_START)]:null;

            Dictionary<Type, object> data = new Dictionary<Type, object>();
            data.Add(typeof(TextBox), textBox);
            data.Add(typeof(StatusStrip), toolStrip);
            // 状态栏事件
            TextBoxBindStatusBarEvent.setOnStatusBarEventBind(eventType, textBox);
            // 菜单项事件
            // OnTopMenuEvent.setOnTopMenuEventBind(eventType, textBox);
            switch(eventType) { 
                case TextBoxEventTypeEnum.内容改变事件 : 
                    /*============将文本数据放入缓冲区===================*/
                    MainTextBoxEventMet.setTextBoxCache(data);
                break;
                case TextBoxEventTypeEnum.鼠标移入事件 :
                    /*============绑定右键菜单===================*/
                    TextRightMenu.bindingTextBox(textBox);
                break;
                case TextBoxEventTypeEnum.获取焦点事件 :
                    /*============赋值到即将要操作的文本框===================*/
                    TextBoxCache.UpOperatingTextBox = textBox;
                break;
            }
                
        }
    }
}