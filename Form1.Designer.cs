namespace RevText
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.translateCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.throughHotKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RevText";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.translateCodeToolStripMenuItem,
            this.throughHotKeyToolStripMenuItem,
            this.kanaToolStripMenuItem,
            this.kanjiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(232, 136);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(231, 22);
            this.ToolStripMenuItem1.Text = "終了";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // translateCodeToolStripMenuItem
            // 
            this.translateCodeToolStripMenuItem.Name = "translateCodeToolStripMenuItem";
            this.translateCodeToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.translateCodeToolStripMenuItem.Text = "特殊文字を文字参照に変換する";
            this.translateCodeToolStripMenuItem.Click += new System.EventHandler(this.translateCodeToolStripMenuItem_Click);
            // 
            // throughHotKeyToolStripMenuItem
            // 
            this.throughHotKeyToolStripMenuItem.Name = "throughHotKeyToolStripMenuItem";
            this.throughHotKeyToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.throughHotKeyToolStripMenuItem.Text = "ホットキーの入力を透過する";
            this.throughHotKeyToolStripMenuItem.Click += new System.EventHandler(this.throughHotKeyToolStripMenuItem_Click);
            // 
            // kanaToolStripMenuItem
            // 
            this.kanaToolStripMenuItem.Name = "kanaToolStripMenuItem";
            this.kanaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.kanaToolStripMenuItem.Text = "仮名を変換する";
            this.kanaToolStripMenuItem.Click += new System.EventHandler(this.kanaToolStripMenuItem_Click);
            // 
            // kanjiToolStripMenuItem
            // 
            this.kanjiToolStripMenuItem.Name = "kanjiToolStripMenuItem";
            this.kanjiToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.kanjiToolStripMenuItem.Text = "漢字を変換する";
            this.kanjiToolStripMenuItem.Click += new System.EventHandler(this.kanjiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem translateCodeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem throughHotKeyToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kanaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kanjiToolStripMenuItem;
    }
}

