using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CiberBoy
{
  public class Form1 : Form
  {
    private IContainer icontainer_0 = (IContainer) null;
    private Label label1;
    private Label label2;
    private PictureBox pictureBox1;
    private Button button1;
    private Button button2;

    public Form1() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e)
    {
      this.Hide();
      gdi.warning();
    }

    private void button2_Click(object sender, EventArgs e) => Environment.Exit(0);

    protected override void Dispose(bool disposing)
    {
      if ((disposing ? (this.icontainer_0 != null ? 1 : 0) : 0) != 0)
        this.icontainer_0.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.label1 = new Label();
      this.label2 = new Label();
      this.pictureBox1 = new PictureBox();
      this.button1 = new Button();
      this.button2 = new Button();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Location = new Point(71, 66);
      this.label1.Name = "label1";
      this.label1.Size = new Size(359, 143);
      this.label1.TabIndex = 0;
      this.label1.Text = componentResourceManager.GetString("label1.Text");
      this.label2.AutoSize = true;
      this.label2.Font = new Font("MS UI Gothic", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(70, 27);
      this.label2.Name = "label2";
      this.label2.Size = new Size(110, 21);
      this.label2.TabIndex = 1;
      this.label2.Text = "WARNING!";
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(12, 27);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(52, 55);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.button1.Location = new Point(74, 241);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Yes";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(155, 241);
      this.button2.Name = "button2";
      this.button2.Size = new Size(92, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "No, exit the app";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(435, 282);
      this.ControlBox = false;
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Name = nameof (Form1);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = " MALWARE ALERT";
      this.TopMost = true;
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
