namespace clock;

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        Time = new System.Windows.Forms.Timer(components);
        DrawingArea = new Panel();
        SuspendLayout();
        // 
        // Time
        // 
        Time.Interval = 1000;
        Time.Tick += Time_Tick;
        // 
        // DrawingArea
        // 
        DrawingArea.BackColor = Color.FromArgb(0, 0, 64);
        DrawingArea.Location = new Point(-1, 0);
        DrawingArea.Name = "DrawingArea";
        DrawingArea.Size = new Size(1085, 655);
        DrawingArea.TabIndex = 0;
        DrawingArea.MouseUp += DrawingArea_MouseUp;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1082, 653);
        Controls.Add(DrawingArea);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "Form1";
        Text = "Qlock";
        Load += Form1_Load;
        Shown += Form1_Shown;
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Timer Time;
    private Panel DrawingArea;
}
