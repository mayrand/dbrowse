namespace HardkorowyKodsu;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        listView1 = new System.Windows.Forms.ListView();
        listView2 = new System.Windows.Forms.ListView();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(listView1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(listView2);
        splitContainer1.Size = new System.Drawing.Size(1310, 888);
        splitContainer1.SplitterDistance = 436;
        splitContainer1.TabIndex = 0;
        // 
        // listView1
        // 
        listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        listView1.Location = new System.Drawing.Point(0, 0);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(436, 888);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.List;
        // 
        // listView2
        // 
        listView2.Dock = System.Windows.Forms.DockStyle.Fill;
        listView2.Location = new System.Drawing.Point(0, 0);
        listView2.Name = "listView2";
        listView2.Size = new System.Drawing.Size(870, 888);
        listView2.TabIndex = 0;
        listView2.UseCompatibleStateImageBehavior = false;
        listView2.View = System.Windows.Forms.View.List;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1310, 888);
        Controls.Add(splitContainer1);
        Text = "HardkorowyKodsu ";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListView listView2;

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListView listView1;

    #endregion
}