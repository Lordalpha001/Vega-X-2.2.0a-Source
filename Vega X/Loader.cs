// Decompiled with JetBrains decompiler
// Type: Vega_X.Loader
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using ComponentFactory.Krypton.Toolkit;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WinFormAnimation;

namespace Vega_X
{
  public class Loader : KryptonForm
  {
    private IContainer components = (IContainer) null;
    private Label label2;
    private System.Windows.Forms.Timer timer1;
    private Label label1;
    private Panel panel2;
    private Label label3;
    private Button button5;
    private CircularProgressBar.CircularProgressBar pbar;

    public Loader()
    {
      this.InitializeComponent();
      this.pbar.Value = 0;
    }

    private void Loader_Load(object sender, EventArgs e)
    {
      this.TopMost = true;
      this.timer1.Enabled = true;
      this.timer1.Interval = 60;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.pbar.PerformStep();
      this.pbar.Text = this.pbar.Value.ToString() + \u003F0\u003F.\u003F1\u003F("$");
      if (this.pbar.Value >= 100)
      {
        this.timer1.Enabled = false;
        this.timer1.Stop();
        this.Hide();
        Thread.Sleep(500);
        new VegaX().Show();
      }
      if (this.pbar.Value >= 65)
      {
        this.label3.Visible = true;
        this.label2.Visible = false;
      }
      this.pbar.Value = this.pbar.Value;
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.timer1.Enabled = false;
      this.timer1.Stop();
      this.Hide();
      Thread.Sleep(500);
      new VegaX().Show();
    }

    private void pbar_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Loader));
      this.label2 = new Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label1 = new Label();
      this.panel2 = new Panel();
      this.label3 = new Label();
      this.button5 = new Button();
      this.pbar = new CircularProgressBar.CircularProgressBar();
      this.SuspendLayout();
      this.label2.AutoSize = true;
      this.label2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.White;
      this.label2.Location = new Point(12, 305);
      this.label2.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԳ");
      this.label2.Size = new Size(133, 21);
      this.label2.TabIndex = 5;
      this.label2.Text = \u003F0\u003F.\u003F1\u003F("_ŽɰʹѦ\u0560٪ܬࡊग़ੀ\u0B7Bధനล\u0F2Aဣᄬሡ");
      this.label2.Click += new EventHandler(this.label2_Click);
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = Color.White;
      this.label1.Location = new Point(90, 10);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(165, 30);
      this.label1.TabIndex = 3;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("YūɪͭЫՒةܥࠧॊ੪\u0B65౧൧\u0E73");
      this.label1.Click += new EventHandler(this.label1_Click);
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(3, 2);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(48, 40);
      this.panel2.TabIndex = 12;
      this.label3.AutoSize = true;
      this.label3.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = Color.White;
      this.label3.Location = new Point(24, 305);
      this.label3.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԲ");
      this.label3.Size = new Size(97, 21);
      this.label3.TabIndex = 13;
      this.label3.Text = \u003F0\u003F.\u003F1\u003F("BżɮͤѠզ٠ܦࠫतਭଢయ");
      this.label3.Visible = false;
      this.button5.BackColor = Color.FromArgb(65, 65, 65);
      this.button5.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = SystemColors.Control;
      this.button5.Location = new Point(205, 278);
      this.button5.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլش");
      this.button5.Size = new Size(139, 48);
      this.button5.TabIndex = 14;
      this.button5.Text = \u003F0\u003F.\u003F1\u003F("_Šɣ\u0379ШՋ٩ݤ\u0860४੬୦");
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.pbar.AnimationFunction = KnownAnimationFunctions.Liner;
      this.pbar.AnimationSpeed = 100;
      this.pbar.BackColor = Color.Transparent;
      this.pbar.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 54.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.pbar.ForeColor = Color.White;
      this.pbar.InnerColor = Color.FromArgb(45, 45, 45);
      this.pbar.InnerMargin = 2;
      this.pbar.InnerWidth = -1;
      this.pbar.Location = new Point(64, 55);
      this.pbar.MarqueeAnimationSpeed = 2000;
      this.pbar.Name = \u003F0\u003F.\u003F1\u003F("tšɣͳ");
      this.pbar.OuterColor = Color.FromArgb(30, 30, 30);
      this.pbar.OuterMargin = -25;
      this.pbar.OuterWidth = 26;
      this.pbar.ProgressColor = Color.Black;
      this.pbar.ProgressWidth = 18;
      this.pbar.SecondaryFont = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 36f);
      this.pbar.Size = new Size(211, 206);
      this.pbar.StartAngle = 270;
      this.pbar.Step = 1;
      this.pbar.Style = ProgressBarStyle.Continuous;
      this.pbar.SubscriptColor = Color.FromArgb(166, 166, 166);
      this.pbar.SubscriptMargin = new Padding(10, -35, 0, 0);
      this.pbar.SubscriptText = \u003F0\u003F.\u003F1\u003F("");
      this.pbar.SuperscriptColor = Color.FromArgb(166, 166, 166);
      this.pbar.SuperscriptMargin = new Padding(10, 35, 0, 0);
      this.pbar.SuperscriptText = \u003F0\u003F.\u003F1\u003F("");
      this.pbar.TabIndex = 15;
      this.pbar.TextMargin = new Padding(8, 8, 0, 0);
      this.pbar.Value = 50;
      this.pbar.Click += new EventHandler(this.pbar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(45, 45, 45);
      this.ClientSize = new Size(355, 338);
      this.Controls.Add((Control) this.pbar);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.panel2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label3);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F(".Žɠͮѵԫٍݠ\u086D९"));
      this.Name = \u003F0\u003F.\u003F1\u003F("JŪɥͧѧճ");
      this.StartPosition = FormStartPosition.CenterScreen;
      this.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
      this.StateCommon.Border.Rounding = 10;
      this.Text = \u003F0\u003F.\u003F1\u003F("JŪɥͧѧճ");
      this.Load += new EventHandler(this.Loader_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
