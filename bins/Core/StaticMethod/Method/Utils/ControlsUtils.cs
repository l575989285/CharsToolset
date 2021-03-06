﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;
using System.Data;
using Core.CacheLibrary.ControlCache;
using Core.DefaultData.DataLibrary;

namespace Core.StaticMethod.Method.Utils
{
    /// <summary>
    /// 关于控件集的工具类
    /// </summary>
    public static class ControlsUtils
    {
       
        /// <summary>
        /// 以不同颜色重写控件不同宽度的相同样式的边框
        /// </summary>
        /// <param name="gra">要画图的矩形区域</param>
        /// <param name="rec">表示矩形的位置和大小</param>
        /// <param name="borderS">边框样式</param>
        /// <param name="leftW">左边框宽度</param>
        /// <param name="topW">上边框宽度</param>
        /// <param name="rightW">右边框宽度</param>
        /// <param name="bottomW">下边框宽度</param>
        /// <param name="colorLeft">左边框颜色</param>
        /// <param name="colorTop">上边框颜色</param>
        /// <param name="colorRight">右边框颜色</param>
        /// <param name="colorBottom">下边框颜色</param>
        public static void SetControlBorderStyle(Graphics gra,
            Rectangle rec, ButtonBorderStyle borderS,
            int leftW, int topW, int rightW, int bottomW,
            Color colorLeft, Color colorTop, Color colorRight, Color colorBottom) {

            ControlPaint.DrawBorder(gra, rec,
            colorLeft, leftW, borderS, //左边
            colorTop, topW, borderS, //上边
            colorRight, rightW, borderS, //右边
            colorBottom, bottomW, borderS);//底边
        }
        /// <summary>
        /// 以固定颜色重写控件不同宽度的相同样式的边框
        /// </summary>
        /// <param name="gra">要画图的矩形区域</param>
        /// <param name="rec">表示矩形的位置和大小</param>
        /// <param name="borderS">边框样式</param>
        /// <param name="leftW">左边框宽度</param>
        /// <param name="topW">上边框宽度</param>
        /// <param name="rightW">右边框宽度</param>
        /// <param name="bottomW">下边框宽度</param>
        /// <param name="color">边框颜色</param>
        public static void SetControlBorderStyle(Graphics gra,
            Rectangle rec, ButtonBorderStyle borderS,
            int leftW, int topW, int rightW, int bottomW,
            Color color) {

            ControlPaint.DrawBorder(gra, rec,
            color, leftW, borderS, //左边
            color, topW, borderS, //上边
            color, rightW, borderS, //右边
            color, bottomW, borderS);//底边
        }
        /// <summary>
        /// 以不同颜色重写控件相同同宽度的相同样式的边框
        /// </summary>
        /// <param name="gra">要画图的矩形区域</param>
        /// <param name="rec">表示矩形的位置和大小</param>
        /// <param name="borderS">边框样式</param>
        /// <param name="borderW">边框宽度</param>
        /// <param name="colorLeft">左边框颜色</param>
        /// <param name="colorTop">上边框颜色</param>
        /// <param name="colorRight">右边框颜色</param>
        /// <param name="colorBottom">下边框颜色</param>
        public static void SetControlBorderStyle(Graphics gra,
            Rectangle rec, ButtonBorderStyle borderS,
            int borderW,
            Color colorLeft, Color colorTop, Color colorRight, Color colorBottom) 
            {
            ControlPaint.DrawBorder(gra, rec,
            colorLeft, borderW, borderS, //左边
            colorTop, borderW, borderS, //上边
            colorRight, borderW, borderS, //右边
            colorBottom, borderW, borderS);//底边
        }
        /// <summary>
        /// 以相同同颜色重写控件相同宽度的相同样式的边框
        /// </summary>
        /// <param name="gra">要画图的矩形区域</param>
        /// <param name="rec">表示矩形的位置和大小</param>
        /// <param name="borderS">边框样式</param>
        /// <param name="borderW">边框宽度</param>
        /// <param name="color">边框颜色</param>
        public static void SetControlBorderStyle(Graphics gra,
            Rectangle rec, ButtonBorderStyle borderS, int borderW, Color color) {
            ControlPaint.DrawBorder(gra, rec,
            color, borderW, borderS, //左边
            color, borderW, borderS, //上边
            color, borderW, borderS, //右边
            color, borderW, borderS);//底边
        }
        /// <summary>
        /// 获取指定控件集中的指定姓名的控件
        /// </summary>
        /// <param name="tab">指定的控件集</param>
        /// <param name="cName">指定的控件姓名</param>
        /// <param name="fuzzy">是否模糊匹配</param>
        /// <returns>获得的控件，如果没获得，则返回null</returns>
        public static Control GetControlByName(Control.ControlCollection cAll, string cName, bool fuzzy) {
            Control control = null;
            // 循环判断给定控件集中的全部控件
            for (int i=0; i<cAll.Count; i++) {
                control = cAll[i];
                // 判断控件名是否为给定控件名相同名
                if((!fuzzy && control.Name.Equals(cName)) || (fuzzy && control.Name.IndexOf(cName) >= 0)) {
                    break;
                }
                if(control.Controls.Count > 0){ 
                    GetControlByName(control.Controls, cName, fuzzy);
                }
            }
            return control;
        }
        /// <summary>
        /// 获取指定控件集中获得焦点的控件
        /// </summary>
        /// <param name="tab">指定的控件集</param>
        /// <param name="type">指定的类型</param>
        /// <returns>获得的控件，如果没获得，则返回null</returns>
        public static Control GetFocueControlByType(Control.ControlCollection cAll) {
            if(cAll == null) return null;
            Control control = null;
            for(int i=0; i<cAll.Count; i++) {
                control = cAll[i];
                // 循环判断给定控件集中的全部控件
                if(control.Focused) {
                    // 将控件赋值
                    break;
                }
                if (control.Controls.Count > 0) { GetFocueControlByType(control.Controls); }
            }
            return control;
        }
        /// <summary>
        /// 获取指定控件集中获得焦点的控件
        /// </summary>
        /// <param name="tab">指定的控件集</param>
        /// <param name="type">指定的类型</param>
        /// <returns>获得的控件，如果没获得，则返回null</returns>
        public static Control GetFocueControlByType(Control[] cAll) {
            if(cAll == null) return null;
            Control control = null;
            for(int i=0; i<cAll.Length; i++) {
                control = cAll[i];
                // 循环判断给定控件集中的全部控件
                if(control.Focused) {
                    // 将控件赋值
                    break;
                }
                if (control.Controls.Count > 0) { GetFocueControlByType(control.Controls); }
            }
            return control;
        }
        /// <summary>
        /// 获取指定控件集中的指定类型的获得焦点的控件
        /// </summary>
        /// <param name="tab">指定的控件集</param>
        /// <param name="type">指定的类型</param>
        /// <returns>获得的控件，如果没获得，则返回null</returns>
        public static T GetFocueControlByType<T>(Control.ControlCollection cAll)where T:Control {
            if(cAll == null) return null;
            List<T> conLise = null;
            T retCon = null;
            GetAllControlByType<T>(ref conLise, cAll);
            if(conLise != null && conLise.Count > 0) {
                foreach (T con in conLise) {
                    if (con != null && con is T && con.Focused) { 
                        retCon = con;
                    }
                }
            }
            return retCon;
        }
        /// <summary>
        /// 获取指定控件集中的指定类型的所有控件
        /// </summary>
        /// <param name="tab">指定的控件集</param>
        /// <param name="type">指定的类型</param>
        /// <returns>获得的控件列表，如果没获得，则返回空列表</returns>
        public static void GetAllControlByType<T>(ref List<T> conList, Control.ControlCollection cAll) where T:Control{
            if(conList == null) conList = new List<T>();
            // 循环判断给定控件集的全部控件
            foreach (Control con in cAll) {
                // 判断控件类型是否为给定控件类型
                if (con != null && con is T) {
                    conList.Add((T)con);
                }
                if(con != null && con.Controls.Count > 0) {
                    GetAllControlByType(ref conList, con.Controls);
                } 
            }
        }
        /// <summary>
        /// 生成历史纪录的Panel
        /// </summary>
        /// <param name="con">要显示记录的控件</param>
        /// <param name="confather">历史记录放入到父容器</param>
        /// <param name="isClose">失去焦点关闭</param>
        /// <param name="historical">历史记录的数组</param>
        /// <param name="panelW">历史纪录Panel的宽</param>
        /// <param name="itemH">每个记录的高</param>
        public static Panel GetHistoricalPanel(Control con, Control.ControlCollection confather, bool isClose,
            string[] historical, int panelW, int itemH) {
            Panel panel = null;
            Label tempLab = null;
            // 判断历史数据是否为null或长度是否为0
            if(historical != null && !0.Equals(historical.Length)) {
                panel = new Panel();
                panel.Name = con.Name + "_panel";
                panel.Width = panelW;
                panel.BackColor = con.FindForm().BackColor;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Font = con.Font;
                foreach (string findVal in historical) { 
                    tempLab = getHistoricalItem(panel, "", itemH);
                    // 文本内容
                    tempLab.Text = findVal;
                    // 绑定鼠标点击事件
                    tempLab.MouseClick += (object sender, MouseEventArgs e) => { 
                        Label lab = (Label)sender;
                        // 赋值到控件
                        con.Text = lab.Text;
                        // 判断控件是否为文本框类型
                        if(con.GetType().Equals(typeof(TextBox))) ((TextBox)con).SelectionStart = lab.Text.Length;
                        // 关闭父容器
                        lab.Parent.Dispose();
                    };
                    // 添加到Label中
                    panel.Controls.Add(tempLab);
                }
                // 设置panel位置
                panel.Location = new Point(con.Location.X, con.Location.Y + con.Height + 1);
                // 设置Panel高度
                if(panel.Controls.Count * itemH <= (con.FindForm().ClientSize.Height - panel.Location.Y - 2)) { 
                    panel.Height = panel.Controls.Count * itemH + 2;
                } else {
                    panel.Height = (con.FindForm().ClientSize.Height - panel.Location.Y - 5) + 2;
                    foreach(Control c in panel.Controls) { 
                        c.Width = c.Width - 25;
                    }
                }
                // 将控件加入到控件的父容器中
                confather.Add(panel);
                if(isClose) {
                    // 绑定失去焦点事件
                    panel.LostFocus += (object sender, EventArgs e) => {
                        Panel p = (Panel)sender;
                        if(!p.IsDisposed) { 
                            p.Dispose();
                        }
                    };
                }
                // 显示Panel
                panel.Show();
                // 置于顶层
                panel.BringToFront();
                panel.Focus();
            }
            return panel;
        }

        /// <summary>
        /// 创建历史记录的项
        /// </summary>
        private static Label getHistoricalItem(Control parent, string name, int height) { 
            Label itemLabel = new Label();
            itemLabel.Name = name;
            itemLabel.BorderStyle = BorderStyle.None;
            itemLabel.AutoSize = false;
            itemLabel.Font = parent.Font;
            itemLabel.Width = parent.ClientSize.Width - (parent.Padding.Left + parent.Padding.Right) - 2;
            itemLabel.Height = height;
            itemLabel.BackColor = parent.BackColor;
            itemLabel.Cursor = Cursors.Hand;
            // 相对位置
            itemLabel.Location = new Point(0, parent.Controls.Count * height);
            // 绑定鼠标移入事件
            itemLabel.MouseEnter += (object sender, EventArgs e) => { 
                Label lab = (Label)sender;
                lab.BackColor = ColorTranslator.FromHtml("#0078D7");
                lab.ForeColor = Color.White;
                // 设置提示
                new ToolTip().SetToolTip(lab, lab.Text);
            };
            // 绑定鼠标按下
            itemLabel.MouseDown += (object sender, MouseEventArgs e) => {
                Label lab = (Label)sender;
                if(MouseButtons.Left.Equals(e.Button)) { 
                    lab.BackColor = ColorTranslator.FromHtml("#026BBF");
                    lab.ForeColor = Color.White;
                }
            };
            // 绑定鼠标移出事件
            itemLabel.MouseLeave += (object sender, EventArgs e) => { 
                Label lab = (Label)sender;
                lab.BackColor = parent.BackColor;
                lab.ForeColor = Color.Black;
            };
            return itemLabel;
        }

        /// <summary>
        /// 为控件绑定提示消息
        /// </summary>
        /// <param name="con">控件</param>
        /// <param name="tipVal">提示消息</param>
        /// <param name="x">X坐标，相对于控件</param>
        /// <param name="y">Y坐标，相对于控件</param>
        /// <param name="time">显示时间</param>
        /// <param name="back">背景色</param>
        /// <param name="fontCol">前景色</param>
        /// <returns></returns>
        public static ToolTip GetControlMessTip(Control con, string tipVal, int x, int y, int time, Color back, Color fontCol) { 
            ToolTip tip = new ToolTip();
            tip.UseFading = true;
            // 启用动画效果
            tip.UseAnimation = true;
            // 设置显示的文本和定位坐标
            tip.Show(tipVal, con, x, y, time);
            // 重绘
            tip.OwnerDraw = false;
            tip.Draw += (object sender, DrawToolTipEventArgs e) =>{ 
                ToolTip tempTT = (ToolTip)sender;
                using (Brush backBrush = new SolidBrush(tempTT.BackColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.DrawBorder();
                }
                using (Brush textBrush = new SolidBrush(tempTT.ForeColor))
                {
                    StringFormat sf = new StringFormat();
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    // sf.FormatFlags = StringFormatFlags.;
                    sf.Trimming = StringTrimming.None;
 
                    e.Graphics.DrawString(e.ToolTipText, e.Font, textBrush, e.Bounds, sf);
                }
            };
            // 启用气球
            tip.IsBalloon = false;
            // 设置背景颜色
            tip.BackColor = back;
            // 设置前景颜色
            tip.ForeColor = fontCol;
            // 激活
            tip.Active = true;
            return tip;
        }
        /// <summary>
        /// 异步并延迟执行基于某个控件的无返回值的方法
        /// </summary>
        /// <param name="con">指定控件</param>
        /// <param name="time">毫秒</param>
        /// <param name="e">执行事件</param>
        public static void AsynchronousMethod(Control con, int time , EventHandler e) {
            AsynchronousMethod(time, new ElapsedEventHandler(delegate{
                if(con.InvokeRequired) { 
                    con.Invoke(e);
                }
            }));
        }
        /// <summary>
        /// 异步并延迟执行某个无返回值的方法
        /// </summary>
        /// <param name="time">毫秒</param>
        /// <param name="e">执行事件</param>
        public static void AsynchronousMethod(int time , ElapsedEventHandler e) {
            // 延迟1毫秒执行方法
            System.Timers.Timer timer = new System.Timers.Timer(time==0? 1:time);
            // 到达时间的时候执行事件；
            timer.Elapsed += e;
            // 设置是执行一次（false）还是一直执行(true)；
            timer.AutoReset = false;
            // 是否执行System.Timers.Timer.Elapsed事件；
            timer.Enabled = true;
            
        }
        public static void TimersMethod(ElapsedEventHandler e) {
            TimersMethod(200, -1, null, e);
        }
        public static void TimersMethod(int time, ElapsedEventHandler e) {
            TimersMethod(time, -1, null, e);
        }
        public static void TimersMethod(int time, int timeout, ElapsedEventHandler e) {
            TimersMethod(time, timeout, null, e);
        }
        /// <summary>
        /// 循环调用某个无返回值的方法
        /// </summary>
        /// <param name="time">毫秒</param>
        /// <param name="timeout">超时时间</param>
        /// <param name="con">基于某个控件的方法</param>
        /// <param name="e">执行事件</param>
        public static void TimersMethod(int time, int timeout, Control con, ElapsedEventHandler e) {
            try { 
                // 延迟1毫秒执行方法
                System.Timers.Timer timer = new System.Timers.Timer(time);
                int tt = 0;
                ElapsedEventHandler handler = (object sender, ElapsedEventArgs e1)=>{ 
                    if (timeout != -1 && tt >= timeout) timer.Dispose();
                    if(con != null) {
                        if(con.InvokeRequired) { 
                            con.Invoke(new EventHandler(delegate(object obj, EventArgs e2){ 
                                e.Invoke(sender, e1);
                            }));
                        }
                    } else { 
                        e.Invoke(sender, e1);
                    }
                    tt += time;
                };
                // 到达时间的时候执行事件；
                timer.Elapsed += handler;
                // 设置是执行一次（false）还是一直执行(true)；
                timer.AutoReset = true;
                // 是否执行System.Timers.Timer.Elapsed事件；
                timer.Enabled = true;
                
            } catch (Exception ex) { 
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// 设置控件的Tag数据
        /// </summary>
        /// <param name="con"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public static void SetControlTag(Control con, string key, object val) { 
            Dictionary<string, object> tagD = new Dictionary<string,object>();
            try {
                // 判断Tag数据不为null
                if(con.Tag != null) { 
                    tagD = (Dictionary<string, object>)con.Tag;
                    // 判断是否存在该Key
                    if(tagD.ContainsKey(key)) { 
                        tagD[key] = val;
                    } else { 
                        tagD.Add(key, val);
                    }
                    con.Tag = tagD;
                } else {
                    tagD.Add(key, val);
                    con.Tag = tagD;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            
        }
        /// <summary>
        /// 设置控件的Tag数据
        /// </summary>
        /// <param name="con"></param>
        /// <param name="key"></param>
        /// <param name="val"></param>
        public static void SetControlTag(object tag, string key, object val) { 
            Dictionary<string, object> tagD = new Dictionary<string,object>();
            try {
                // 判断Tag数据不为null
                if(tag != null) { 
                    tagD = (Dictionary<string, object>)tag;
                    // 判断是否存在该Key
                    if(tagD.ContainsKey(key)) {
                        if( !tagD[key].Equals(val)) tagD[key] = val;
                    } else { 
                        tagD.Add(key, val);
                    }
                    tag = tagD;
                } else {
                    tagD.Add(key, val);
                    tag = tagD;
                }
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            
        }
        /// <summary>
        /// 获取控件的Tag数据并强制转化为Dictionary格式
        /// </summary>
        /// <param name="t">要获取tag的文本框</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetControlTagToDic(Control con)
        {
            Dictionary<string, object> tagD=new Dictionary<string,object>();
            try {
                if(con.Tag == null) return tagD;
                tagD = (Dictionary<string, object>)con.Tag;
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            return tagD;
        }
        /// <summary>
        /// 获取控件的Tag数据并强制转化为Dictionary格式
        /// </summary>
        /// <param name="t">要获取tag的文本框</param>
        /// <returns></returns>
        public static Dictionary<string, object> GetControlTagToDic(object tag) {
            Dictionary<string, object> tagD=new Dictionary<string,object>();
            try {
                if(tag == null) return tagD;
                tagD = (Dictionary<string, object>)tag;
            } catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
            return tagD;
        }

        /// <summary>
        /// 获取控件在客户区的坐标,相对于顶级父容器的坐标
        /// </summary>
        /// <param name="c">控件</param>
        /// <returns>坐标点</returns>
        public static Point LocationOnClient(Control c) {
            var retval = new Point(0, 0);
            for(; c.Parent != null; c = c.Parent)
            {
                retval.Offset(c.Location);
            }
            return retval;
        }

        /// <summary>
        /// 显示消息询问对话框，含有确定和取消按钮的对话框
        /// </summary>
        /// <param name="text">对话框里显示的内容</param>
        /// <param name="headT">对话框标题</param>
        /// <param name="okDeleg">点击确定按钮执行的委托</param>
        /// <param name="cenDeleg">点击取消按钮执行的委托</param>
        public static DialogResult ShowAskMessBox(string text, string headT, Action okDeleg, Action cenDeleg) {
            // 弹出对话框
            DialogResult dr = MessageBox.Show(text, headT, MessageBoxButtons.OK | MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Exclamation);
            // 如果点击"确定"按钮
            if(dr == DialogResult.OK){
                if(okDeleg != null) { 
                    okDeleg.Invoke();
                }
            }
            // 如果点击"取消"按钮
            if(dr == DialogResult.Cancel){ 
                if(cenDeleg != null) { 
                    cenDeleg.Invoke();
                }
            }
            return dr;
        }
        /// <summary>
        /// 清除控件的重绘刷新
        /// </summary>
        /// <param name="con"></param>
        public static void ClearRedrawFlashing(Control con) { 
            con.GetType().GetProperty("DoubleBuffered",System.Reflection.BindingFlags.Instance
                       |System.Reflection.BindingFlags.NonPublic).SetValue(con,true, null);
        }
        /// <summary>
        /// 设置容器集中全部的复选框的Check为true 或 false
        /// </summary>
        /// <param name="controls">容器集</param>
        /// <param name="check">true或false</param>
        public static void SetControlsChecked(Control.ControlCollection controls, bool check) {
            foreach (Control con in controls) {
                if(con is CheckBox && con.Enabled) { 
                    ((CheckBox)con).Checked = check;
                }else if (con.Controls.Count > 0) { 
                    SetControlsChecked(con.Controls, check);
                }
            }
        }
        /// <summary>
        /// 返回容器集中全部的复选框的Check
        /// </summary>
        /// <param name="controls">容器集</param>
        public static void GetControlsChecked(ref List<bool> checkens, Control.ControlCollection controls) {
            if(checkens == null) checkens = new List<bool>();
            foreach (Control con in controls) {
                if(con is CheckBox && con.Enabled) { 
                    checkens.Add( ((CheckBox)con).Checked);
                }else if (con.Controls.Count > 0) { 
                    GetControlsChecked(ref checkens, con.Controls);
                }
            }
        }
        /// <summary>
        /// 设置下拉列表框的值
        /// </summary>
        /// <param name="combo">下拉列表</param>
        /// <param name="items">key实际的值 val为要显示的值</param>
        public static void SetComboBoxItems(ComboBox combo, Dictionary<object, string> items) {
            int selIndex = 0;
            DataTable table = new DataTable();
            DataColumn column;
            DataRow row;
            column = new DataColumn("Name");
            table.Columns.Add(column);
            column = new DataColumn("Value");
            table.Columns.Add(column);
            // 设置数据源
            foreach(KeyValuePair<object, string> kvp in items) { 
                object key = kvp.Key;
                string val = kvp.Value;
                row = table.NewRow();
                row["Name"] = key;
                row["Value"] = val;
                table.Rows.Add(row);
            }
            
            // 绑定数据源
            combo.DisplayMember = "Value";
            combo.ValueMember = "Name";
            combo.DataSource = table;
            combo.SelectedIndex = selIndex;
        }
        /// <summary>
        /// 获取当前标签的文本框
        /// </summary>
        /// <returns></returns>
        public static TextBox GetSelectPageTextBox() { 
            Control con = null;
            con = ControlCacheFactory.getSingletonCache(DefaultNameEnum.TAB_CONTENT);
            if(con is TabControl) { 
                TabControl redrawTab = (TabControl)con;
                // 获取标签容器中当前标签的文本框
                con = ControlsUtils.GetControlByName(redrawTab.SelectedTab.Controls, EnumUtils.GetDescription(DefaultNameEnum.TEXTBOX_NAME_DEF), true);
            }
            // 转化为文本框
            TextBox textBox = con != null && con is TextBox?(TextBox)con : null;
            return textBox;
        }
        /// <summary>
        /// 导出数据到文本框
        /// </summary>
        public static void ExportTextBox(TextBox textBox, string s) {
            if (textBox != null) {
                int start = textBox.SelectionStart;
                if(textBox.SelectionLength == 0) { 
                    textBox.Text = s;
                } else { 
                    textBox.SelectedText = s;
                }
                textBox.SelectionStart = start;
                textBox.SelectionLength = s.Length;
            } else { 
                MessageBox.Show("要导出的容器必须为文本框");
            }
        }
        /// <summary>
        /// 导出数据到当前标签
        /// </summary>
        public static void ExportThisPage(string s) {
            TextBox textBox = GetSelectPageTextBox();
            ExportTextBox(textBox, s);
        }

    }
}
