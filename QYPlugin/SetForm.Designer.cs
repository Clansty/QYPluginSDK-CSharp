﻿namespace QYPlugin
{
    partial class SetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.getAppDir = new System.Windows.Forms.Button();
            this.getLoginQQ = new System.Windows.Forms.Button();
            this.LoginNick = new System.Windows.Forms.Button();
            this.LoginStatus = new System.Windows.Forms.Button();
            this.targqq = new System.Windows.Forms.TextBox();
            this.targGroup = new System.Windows.Forms.TextBox();
            this.tmsg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SendFriend = new System.Windows.Forms.Button();
            this.SendGroup = new System.Windows.Forms.Button();
            this.GroupTmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 221);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 217);
            this.textBox1.TabIndex = 0;
            // 
            // getAppDir
            // 
            this.getAppDir.Location = new System.Drawing.Point(12, 12);
            this.getAppDir.Name = "getAppDir";
            this.getAppDir.Size = new System.Drawing.Size(75, 23);
            this.getAppDir.TabIndex = 1;
            this.getAppDir.Text = "应用目录";
            this.getAppDir.UseVisualStyleBackColor = true;
            this.getAppDir.Click += new System.EventHandler(this.GetAppDir);
            // 
            // getLoginQQ
            // 
            this.getLoginQQ.Location = new System.Drawing.Point(93, 12);
            this.getLoginQQ.Name = "getLoginQQ";
            this.getLoginQQ.Size = new System.Drawing.Size(75, 23);
            this.getLoginQQ.TabIndex = 2;
            this.getLoginQQ.Text = "登录QQ";
            this.getLoginQQ.UseVisualStyleBackColor = true;
            this.getLoginQQ.Click += new System.EventHandler(this.GetLoginQQ);
            // 
            // LoginNick
            // 
            this.LoginNick.Location = new System.Drawing.Point(174, 12);
            this.LoginNick.Name = "LoginNick";
            this.LoginNick.Size = new System.Drawing.Size(75, 23);
            this.LoginNick.TabIndex = 3;
            this.LoginNick.Text = "登录昵称";
            this.LoginNick.UseVisualStyleBackColor = true;
            this.LoginNick.Click += new System.EventHandler(this.LoginNick_Click);
            // 
            // LoginStatus
            // 
            this.LoginStatus.Location = new System.Drawing.Point(255, 12);
            this.LoginStatus.Name = "LoginStatus";
            this.LoginStatus.Size = new System.Drawing.Size(75, 23);
            this.LoginStatus.TabIndex = 4;
            this.LoginStatus.Text = "在线状态";
            this.LoginStatus.UseVisualStyleBackColor = true;
            this.LoginStatus.Click += new System.EventHandler(this.LoginStatus_Click);
            // 
            // targqq
            // 
            this.targqq.Location = new System.Drawing.Point(12, 194);
            this.targqq.Name = "targqq";
            this.targqq.Size = new System.Drawing.Size(100, 21);
            this.targqq.TabIndex = 5;
            this.targqq.Text = "839827911";
            // 
            // targGroup
            // 
            this.targGroup.Location = new System.Drawing.Point(118, 194);
            this.targGroup.Name = "targGroup";
            this.targGroup.Size = new System.Drawing.Size(100, 21);
            this.targGroup.TabIndex = 6;
            this.targGroup.Text = "828390342";
            // 
            // tmsg
            // 
            this.tmsg.Location = new System.Drawing.Point(224, 194);
            this.tmsg.Name = "tmsg";
            this.tmsg.Size = new System.Drawing.Size(564, 21);
            this.tmsg.TabIndex = 7;
            this.tmsg.Text = "测试内容";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "目标 QQ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "目标群组";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "消息内容";
            // 
            // SendFriend
            // 
            this.SendFriend.Location = new System.Drawing.Point(336, 12);
            this.SendFriend.Name = "SendFriend";
            this.SendFriend.Size = new System.Drawing.Size(75, 23);
            this.SendFriend.TabIndex = 11;
            this.SendFriend.Text = "发送好友";
            this.SendFriend.UseVisualStyleBackColor = true;
            this.SendFriend.Click += new System.EventHandler(this.SendFriend_Click);
            // 
            // SendGroup
            // 
            this.SendGroup.Location = new System.Drawing.Point(417, 12);
            this.SendGroup.Name = "SendGroup";
            this.SendGroup.Size = new System.Drawing.Size(75, 23);
            this.SendGroup.TabIndex = 12;
            this.SendGroup.Text = "发送群";
            this.SendGroup.UseVisualStyleBackColor = true;
            this.SendGroup.Click += new System.EventHandler(this.SendGroup_Click);
            // 
            // GroupTmp
            // 
            this.GroupTmp.Location = new System.Drawing.Point(498, 12);
            this.GroupTmp.Name = "GroupTmp";
            this.GroupTmp.Size = new System.Drawing.Size(75, 23);
            this.GroupTmp.TabIndex = 13;
            this.GroupTmp.Text = "发送群临时";
            this.GroupTmp.UseVisualStyleBackColor = true;
            this.GroupTmp.Click += new System.EventHandler(this.GroupTmp_Click);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupTmp);
            this.Controls.Add(this.SendGroup);
            this.Controls.Add(this.SendFriend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tmsg);
            this.Controls.Add(this.targGroup);
            this.Controls.Add(this.targqq);
            this.Controls.Add(this.LoginStatus);
            this.Controls.Add(this.LoginNick);
            this.Controls.Add(this.getLoginQQ);
            this.Controls.Add(this.getAppDir);
            this.Controls.Add(this.textBox1);
            this.Name = "SetForm";
            this.Text = "SetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button getAppDir;
        private System.Windows.Forms.Button getLoginQQ;
        private System.Windows.Forms.Button LoginNick;
        private System.Windows.Forms.Button LoginStatus;
        private System.Windows.Forms.TextBox targqq;
        private System.Windows.Forms.TextBox targGroup;
        private System.Windows.Forms.TextBox tmsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SendFriend;
        private System.Windows.Forms.Button SendGroup;
        private System.Windows.Forms.Button GroupTmp;
    }
}