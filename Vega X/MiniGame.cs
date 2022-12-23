// Decompiled with JetBrains decompiler
// Type: Vega_X.MiniGame
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Vega_X
{
  public class MiniGame : Form
  {
    private Graphics graphics;
    private int x = 150;
    private int y = 100;
    private int dx = 3;
    private int dy = 2;
    private IContainer components = (IContainer) null;
    private Timer timer1;

    public MiniGame()
    {
      this.InitializeComponent();
      this.Paint += new PaintEventHandler(this.paintBall);
      this.DoubleBuffered = true;
    }

    private void paintBall(object sender, PaintEventArgs e)
    {
      this.graphics = e.Graphics;
      this.graphics.FillEllipse((Brush) new SolidBrush(Color.Blue), this.x, this.y, 10, 10);
    }

    private void MoveBall()
    {
      int num1 = this.x + this.dx;
      int num2 = this.y + this.dy;
      if (num1 < -5 || num1 > this.ClientSize.Width)
        this.dx = -this.dx;
      if (num2 < 0 || num2 > this.ClientSize.Height)
        this.dy = -this.dy;
      this.x += this.dx;
      this.y += this.dy;
      this.Invalidate();
    }

    private void MiniGame_Load(object sender, EventArgs e) => this.TopMost = true;

    private void timer1_Tick(object sender, EventArgs e) => this.MoveBall();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (MiniGame));
      this.timer1 = new Timer(this.components);
      this.SuspendLayout();
      this.timer1.Enabled = true;
      this.timer1.Interval = 10;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(60, 60, 60);
      this.ClientSize = new Size(800, 450);
      this.Icon = (Icon) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F(".Žɠͮѵԫٍݠ\u086D९"));
      this.Name = \u003F0\u003F.\u003F1\u003F("EŮɨͬуբٯݤ");
      this.Text = \u003F0\u003F.\u003F1\u003F("lŉɱͷњսٶݿ࠹र\u0A45\u0B73సേ\u0E7Aཨၴᄰቘ፧ᑣᕨᙤ\u177Dᠩᥜᩨᬦ᱈ᵫṵὧ\u2028");
      this.Load += new EventHandler(this.MiniGame_Load);
      this.ResumeLayout(false);
    }
  }
}
