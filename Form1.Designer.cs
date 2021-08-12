
namespace TwitterAPI_app
{
    partial class FormTwitterPost
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.butTweet = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTweets = new System.Windows.Forms.RichTextBox();
            this.lblHandler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHander = new System.Windows.Forms.Label();
            this.attachImage = new System.Windows.Forms.Button();
            this.imgAttach = new System.Windows.Forms.PictureBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayFollowers = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAttach)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTweet
            // 
            this.txtTweet.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTweet.Location = new System.Drawing.Point(194, 36);
            this.txtTweet.Multiline = true;
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(249, 106);
            this.txtTweet.TabIndex = 3;
            // 
            // butTweet
            // 
            this.butTweet.Location = new System.Drawing.Point(345, 160);
            this.butTweet.Name = "butTweet";
            this.butTweet.Size = new System.Drawing.Size(98, 23);
            this.butTweet.TabIndex = 4;
            this.butTweet.Text = "ツイート";
            this.butTweet.UseVisualStyleBackColor = true;
            this.butTweet.Click += new System.EventHandler(this.butTweet_Click);
            // 
            // profilePic
            // 
            this.profilePic.Location = new System.Drawing.Point(26, 36);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(131, 96);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 5;
            this.profilePic.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 153);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "名前";
            // 
            // txtTweets
            // 
            this.txtTweets.Location = new System.Drawing.Point(24, 273);
            this.txtTweets.Name = "txtTweets";
            this.txtTweets.Size = new System.Drawing.Size(419, 216);
            this.txtTweets.TabIndex = 7;
            this.txtTweets.Text = "";
            // 
            // lblHandler
            // 
            this.lblHandler.AutoSize = true;
            this.lblHandler.Location = new System.Drawing.Point(24, 165);
            this.lblHandler.Name = "lblHandler";
            this.lblHandler.Size = new System.Drawing.Size(0, 12);
            this.lblHandler.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 9;
            // 
            // lblHander
            // 
            this.lblHander.AutoSize = true;
            this.lblHander.Location = new System.Drawing.Point(24, 177);
            this.lblHander.Name = "lblHander";
            this.lblHander.Size = new System.Drawing.Size(35, 12);
            this.lblHander.TabIndex = 10;
            this.lblHander.Text = "label2";
            // 
            // attachImage
            // 
            this.attachImage.Location = new System.Drawing.Point(195, 160);
            this.attachImage.Name = "attachImage";
            this.attachImage.Size = new System.Drawing.Size(131, 23);
            this.attachImage.TabIndex = 11;
            this.attachImage.Text = "Attach Image";
            this.attachImage.UseVisualStyleBackColor = true;
            this.attachImage.Click += new System.EventHandler(this.attachImage_Click);
            // 
            // imgAttach
            // 
            this.imgAttach.Location = new System.Drawing.Point(195, 204);
            this.imgAttach.Name = "imgAttach";
            this.imgAttach.Size = new System.Drawing.Size(130, 63);
            this.imgAttach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAttach.TabIndex = 12;
            this.imgAttach.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(294, 189);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(0, 12);
            this.lblImage.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayFollowers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayFollowers
            // 
            this.displayFollowers.Name = "displayFollowers";
            this.displayFollowers.Size = new System.Drawing.Size(69, 20);
            this.displayFollowers.Text = "Followers";
            this.displayFollowers.Click += new System.EventHandler(this.displayFollowers_Click);
            // 
            // FormTwitterPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(471, 511);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.imgAttach);
            this.Controls.Add(this.attachImage);
            this.Controls.Add(this.lblHander);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHandler);
            this.Controls.Add(this.txtTweets);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.profilePic);
            this.Controls.Add(this.butTweet);
            this.Controls.Add(this.txtTweet);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormTwitterPost";
            this.Text = "Twitter投稿";
            this.Load += new System.EventHandler(this.FormTwitterPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAttach)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.Button butTweet;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtTweets;
        private System.Windows.Forms.Label lblHandler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHander;
        private System.Windows.Forms.Button attachImage;
        private System.Windows.Forms.PictureBox imgAttach;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayFollowers;
    }
}

