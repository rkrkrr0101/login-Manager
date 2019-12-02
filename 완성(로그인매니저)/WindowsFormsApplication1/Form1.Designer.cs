namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.setuppanel = new System.Windows.Forms.Panel();
            this.Nbox = new System.Windows.Forms.TextBox();
            this.Nlabel = new System.Windows.Forms.Label();
            this.ADlabel = new System.Windows.Forms.Label();
            this.PWlabel = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.PWBox = new System.Windows.Forms.TextBox();
            this.ADBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IDShowBox = new System.Windows.Forms.TextBox();
            this.PWShowbox = new System.Windows.Forms.TextBox();
            this.AdShowLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoadPWPanel = new System.Windows.Forms.Panel();
            this.LoadPWButton = new System.Windows.Forms.Button();
            this.LoadPWBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.PWSetPanel = new System.Windows.Forms.Panel();
            this.PWSetBox = new System.Windows.Forms.TextBox();
            this.PWSetButton = new System.Windows.Forms.Button();
            this.PWSetequalBox = new System.Windows.Forms.TextBox();
            this.PWSetCancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.setuppanel.SuspendLayout();
            this.LoadPWPanel.SuspendLayout();
            this.PWSetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(321, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(240, 269);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // setuppanel
            // 
            this.setuppanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.setuppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.setuppanel.Controls.Add(this.Nbox);
            this.setuppanel.Controls.Add(this.Nlabel);
            this.setuppanel.Controls.Add(this.ADlabel);
            this.setuppanel.Controls.Add(this.PWlabel);
            this.setuppanel.Controls.Add(this.IDlabel);
            this.setuppanel.Controls.Add(this.IDBox);
            this.setuppanel.Controls.Add(this.PWBox);
            this.setuppanel.Controls.Add(this.ADBox);
            this.setuppanel.Controls.Add(this.button1);
            this.setuppanel.Location = new System.Drawing.Point(262, 258);
            this.setuppanel.Name = "setuppanel";
            this.setuppanel.Size = new System.Drawing.Size(178, 239);
            this.setuppanel.TabIndex = 1;
            this.setuppanel.TabStop = true;
            this.setuppanel.Visible = false;
            // 
            // Nbox
            // 
            this.Nbox.Location = new System.Drawing.Point(56, 27);
            this.Nbox.Name = "Nbox";
            this.Nbox.Size = new System.Drawing.Size(100, 21);
            this.Nbox.TabIndex = 1;
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Location = new System.Drawing.Point(9, 29);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(29, 12);
            this.Nlabel.TabIndex = 7;
            this.Nlabel.Text = "이름";
            // 
            // ADlabel
            // 
            this.ADlabel.AutoSize = true;
            this.ADlabel.Location = new System.Drawing.Point(9, 111);
            this.ADlabel.Name = "ADlabel";
            this.ADlabel.Size = new System.Drawing.Size(29, 12);
            this.ADlabel.TabIndex = 6;
            this.ADlabel.Text = "주소";
            // 
            // PWlabel
            // 
            this.PWlabel.AutoSize = true;
            this.PWlabel.Location = new System.Drawing.Point(-3, 83);
            this.PWlabel.Name = "PWlabel";
            this.PWlabel.Size = new System.Drawing.Size(53, 12);
            this.PWlabel.TabIndex = 5;
            this.PWlabel.Text = "패스워드";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(3, 56);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(41, 12);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "아이디";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(56, 54);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 21);
            this.IDBox.TabIndex = 2;
            // 
            // PWBox
            // 
            this.PWBox.Location = new System.Drawing.Point(56, 80);
            this.PWBox.Name = "PWBox";
            this.PWBox.Size = new System.Drawing.Size(100, 21);
            this.PWBox.TabIndex = 3;
            // 
            // ADBox
            // 
            this.ADBox.Location = new System.Drawing.Point(56, 108);
            this.ADBox.Name = "ADBox";
            this.ADBox.Size = new System.Drawing.Size(100, 21);
            this.ADBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDShowBox
            // 
            this.IDShowBox.BackColor = System.Drawing.Color.LightGreen;
            this.IDShowBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.IDShowBox.Location = new System.Drawing.Point(104, 123);
            this.IDShowBox.Name = "IDShowBox";
            this.IDShowBox.ReadOnly = true;
            this.IDShowBox.Size = new System.Drawing.Size(143, 21);
            this.IDShowBox.TabIndex = 6;
            // 
            // PWShowbox
            // 
            this.PWShowbox.BackColor = System.Drawing.Color.LightGreen;
            this.PWShowbox.ForeColor = System.Drawing.Color.DarkBlue;
            this.PWShowbox.Location = new System.Drawing.Point(104, 154);
            this.PWShowbox.Name = "PWShowbox";
            this.PWShowbox.ReadOnly = true;
            this.PWShowbox.Size = new System.Drawing.Size(143, 21);
            this.PWShowbox.TabIndex = 7;
            this.PWShowbox.TextChanged += new System.EventHandler(this.PWShowbox_TextChanged);
            // 
            // AdShowLabel
            // 
            this.AdShowLabel.AutoSize = true;
            this.AdShowLabel.BackColor = System.Drawing.Color.LightGreen;
            this.AdShowLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.AdShowLabel.Location = new System.Drawing.Point(102, 99);
            this.AdShowLabel.Name = "AdShowLabel";
            this.AdShowLabel.Size = new System.Drawing.Size(52, 12);
            this.AdShowLabel.TabIndex = 5;
            this.AdShowLabel.TabStop = true;
            this.AdShowLabel.Text = "Address";
            this.AdShowLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AdShowLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(34, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "주소";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(34, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(34, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "패스워드";
            // 
            // LoadPWPanel
            // 
            this.LoadPWPanel.Controls.Add(this.LoadPWButton);
            this.LoadPWPanel.Controls.Add(this.LoadPWBox);
            this.LoadPWPanel.Location = new System.Drawing.Point(36, 258);
            this.LoadPWPanel.Name = "LoadPWPanel";
            this.LoadPWPanel.Size = new System.Drawing.Size(200, 100);
            this.LoadPWPanel.TabIndex = 11;
            // 
            // LoadPWButton
            // 
            this.LoadPWButton.Location = new System.Drawing.Point(73, 67);
            this.LoadPWButton.Name = "LoadPWButton";
            this.LoadPWButton.Size = new System.Drawing.Size(75, 23);
            this.LoadPWButton.TabIndex = 1;
            this.LoadPWButton.Text = "로그인";
            this.LoadPWButton.UseVisualStyleBackColor = true;
            this.LoadPWButton.Click += new System.EventHandler(this.LoadPWButton_Click);
            // 
            // LoadPWBox
            // 
            this.LoadPWBox.Location = new System.Drawing.Point(55, 36);
            this.LoadPWBox.Name = "LoadPWBox";
            this.LoadPWBox.Size = new System.Drawing.Size(100, 21);
            this.LoadPWBox.TabIndex = 0;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(116, 229);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 12;
            this.setButton.Text = "설정";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // PWSetPanel
            // 
            this.PWSetPanel.Controls.Add(this.label5);
            this.PWSetPanel.Controls.Add(this.label4);
            this.PWSetPanel.Controls.Add(this.PWSetCancelButton);
            this.PWSetPanel.Controls.Add(this.PWSetequalBox);
            this.PWSetPanel.Controls.Add(this.PWSetBox);
            this.PWSetPanel.Controls.Add(this.PWSetButton);
            this.PWSetPanel.Location = new System.Drawing.Point(205, 75);
            this.PWSetPanel.Name = "PWSetPanel";
            this.PWSetPanel.Size = new System.Drawing.Size(214, 141);
            this.PWSetPanel.TabIndex = 13;
            this.PWSetPanel.Visible = false;
            // 
            // PWSetBox
            // 
            this.PWSetBox.Location = new System.Drawing.Point(86, 30);
            this.PWSetBox.Name = "PWSetBox";
            this.PWSetBox.Size = new System.Drawing.Size(100, 21);
            this.PWSetBox.TabIndex = 1;
            // 
            // PWSetButton
            // 
            this.PWSetButton.Location = new System.Drawing.Point(21, 115);
            this.PWSetButton.Name = "PWSetButton";
            this.PWSetButton.Size = new System.Drawing.Size(75, 23);
            this.PWSetButton.TabIndex = 0;
            this.PWSetButton.Text = "저장";
            this.PWSetButton.UseVisualStyleBackColor = true;
            this.PWSetButton.Click += new System.EventHandler(this.PWSetButton_Click);
            // 
            // PWSetequalBox
            // 
            this.PWSetequalBox.Location = new System.Drawing.Point(86, 61);
            this.PWSetequalBox.Name = "PWSetequalBox";
            this.PWSetequalBox.Size = new System.Drawing.Size(100, 21);
            this.PWSetequalBox.TabIndex = 2;
            // 
            // PWSetCancelButton
            // 
            this.PWSetCancelButton.Location = new System.Drawing.Point(114, 115);
            this.PWSetCancelButton.Name = "PWSetCancelButton";
            this.PWSetCancelButton.Size = new System.Drawing.Size(75, 23);
            this.PWSetCancelButton.TabIndex = 3;
            this.PWSetCancelButton.Text = "취소";
            this.PWSetCancelButton.UseVisualStyleBackColor = true;
            this.PWSetCancelButton.Click += new System.EventHandler(this.PWSetCancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "비밀번호";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "비밀번호확인";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(573, 289);
            this.Controls.Add(this.PWSetPanel);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.LoadPWPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdShowLabel);
            this.Controls.Add(this.PWShowbox);
            this.Controls.Add(this.IDShowBox);
            this.Controls.Add(this.setuppanel);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.setuppanel.ResumeLayout(false);
            this.setuppanel.PerformLayout();
            this.LoadPWPanel.ResumeLayout(false);
            this.LoadPWPanel.PerformLayout();
            this.PWSetPanel.ResumeLayout(false);
            this.PWSetPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel setuppanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PWlabel;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox PWBox;
        private System.Windows.Forms.TextBox ADBox;
        private System.Windows.Forms.Label ADlabel;
        private System.Windows.Forms.TextBox Nbox;
        private System.Windows.Forms.Label Nlabel;
        private System.Windows.Forms.TextBox IDShowBox;
        private System.Windows.Forms.TextBox PWShowbox;
        private System.Windows.Forms.LinkLabel AdShowLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LoadPWPanel;
        private System.Windows.Forms.Button LoadPWButton;
        private System.Windows.Forms.TextBox LoadPWBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Panel PWSetPanel;
        private System.Windows.Forms.TextBox PWSetBox;
        private System.Windows.Forms.Button PWSetButton;
        private System.Windows.Forms.TextBox PWSetequalBox;
        private System.Windows.Forms.Button PWSetCancelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

