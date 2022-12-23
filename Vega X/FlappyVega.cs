// Decompiled with JetBrains decompiler
// Type: Vega_X.FlappyVega
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Vega_X
{
  public class FlappyVega : Form
  {
    private int pipespeed = 5;
    private int gravity = 7;
    private int score = 0;
    private Point lastPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Panel panel2;
    private Label label1;
    private PictureBox ground;
    private PictureBox pipedown;
    private PictureBox bird;
    private PictureBox pipeup;
    private Label Score;
    private System.Windows.Forms.Timer gametimer;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;

    public FlappyVega() => this.InitializeComponent();

    private void GameTimerEvent(object sender, EventArgs e)
    {
      this.bird.Top += this.gravity;
      this.pipedown.Left -= this.pipespeed;
      this.pipeup.Left -= this.pipespeed;
      this.Score.Text = this.score.ToString();
      if (this.pipedown.Left < -600)
      {
        this.pipedown.Left = 800;
        ++this.score;
      }
      if (this.pipeup.Left < -650)
      {
        this.pipeup.Left = 800;
        ++this.score;
      }
      if (!this.bird.Bounds.IntersectsWith(this.pipedown.Bounds) && !this.bird.Bounds.IntersectsWith(this.pipeup.Bounds) && !this.bird.Bounds.IntersectsWith(this.ground.Bounds) && !this.bird.Bounds.IntersectsWith(this.panel1.Bounds))
        return;
      this.endgame();
    }

    private void gamekeydown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.F)
        this.Close();
      if (e.KeyCode == Keys.A)
      {
        this.gametimer.Interval = 20;
        this.Score.Text += \u003F0\u003F.\u003F1\u003F("!");
        Thread.Sleep(50);
        this.Score.Text += \u003F0\u003F.\u003F1\u003F("Pŧɣ͢Ѫ\u0560ٹܬࡆ॥੭୭ధ\u0D3Bลཁ၂ᅑቘ");
      }
      if (e.KeyCode == Keys.Z)
      {
        this.gametimer.Interval = 3;
        this.Score.Text += \u003F0\u003F.\u003F1\u003F("!");
        Thread.Sleep(50);
        this.Score.Text += \u003F0\u003F.\u003F1\u003F("Všɡ͠Ѵվٻܮࡀॣ੯୯\u0C29വวགྷၝᅔቆፐᑕ");
      }
      if (e.KeyCode == Keys.Q)
      {
        this.gametimer.Interval = 10;
        this.Score.Text += \u003F0\u003F.\u003F1\u003F("!");
        Thread.Sleep(50);
        this.Score.Text += \u003F0\u003F.\u003F1\u003F("Pŧɣ͢Ѫ\u0560ٹܬࡆ॥੭୭ధ\u0D3Bลཌ၂ᅐቅ");
      }
      if (e.KeyCode == Keys.E)
      {
        this.gametimer.Enabled = true;
        this.label2.Visible = false;
        this.label3.Visible = false;
        this.label4.Visible = false;
        this.label5.Visible = false;
        this.label6.Visible = false;
      }
      if (e.KeyCode != Keys.Space)
        return;
      this.gravity = -7;
    }

    private void endgame()
    {
      this.gametimer.Stop();
      this.Score.Text += \u003F0\u003F.\u003F1\u003F("NũɪͣХՋٵݧ\u0873");
      this.Close();
    }

    private void gamekeyup(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Space)
        return;
      this.gravity = 7;
    }

    private void FlappyVega_Load(object sender, EventArgs e) => this.TopMost = true;

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void label5_Click(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FlappyVega));
      this.panel1 = new Panel();
      this.panel2 = new Panel();
      this.label1 = new Label();
      this.ground = new PictureBox();
      this.pipedown = new PictureBox();
      this.bird = new PictureBox();
      this.pipeup = new PictureBox();
      this.Score = new Label();
      this.gametimer = new System.Windows.Forms.Timer(this.components);
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.label5 = new Label();
      this.label6 = new Label();
      this.label7 = new Label();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.ground).BeginInit();
      ((ISupportInitialize) this.pipedown).BeginInit();
      ((ISupportInitialize) this.bird).BeginInit();
      ((ISupportInitialize) this.pipeup).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮ\u0530");
      this.panel1.Size = new Size(800, 40);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(1, 0);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(44, 40);
      this.panel2.TabIndex = 10;
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Window;
      this.label1.Location = new Point(324, 9);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(162, 21);
      this.label1.TabIndex = 3;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("BŶɵͰа\u0557خܠ्ࠬ੦୨\u0C78\u0D77\u0E7F༥ၒᅦብ፠");
      this.ground.Image = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("kŹɥͼѦգب\u074C\u0869ॢ\u0A65\u0B64"));
      this.ground.Location = new Point(-1, 404);
      this.ground.Name = \u003F0\u003F.\u003F1\u003F("aŷɫͶѬե");
      this.ground.Size = new Size(800, 144);
      this.ground.SizeMode = PictureBoxSizeMode.CenterImage;
      this.ground.TabIndex = 2;
      this.ground.TabStop = false;
      this.pipedown.Image = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("~ŤɼͮѮզٿݩࠨौ੩ୢ\u0C65\u0D64"));
      this.pipedown.Location = new Point(564, 281);
      this.pipedown.Name = \u003F0\u003F.\u003F1\u003F("xŮɶ͠Ѡլٵݯ");
      this.pipedown.Size = new Size(99, 123);
      this.pipedown.SizeMode = PictureBoxSizeMode.Zoom;
      this.pipedown.TabIndex = 3;
      this.pipedown.TabStop = false;
      this.bird.Image = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("hŠɺͣШՌ٩ݢ\u0865।"));
      this.bird.Location = new Point(96, 178);
      this.bird.Name = \u003F0\u003F.\u003F1\u003F("fŪɰͥ");
      this.bird.Size = new Size(49, 50);
      this.bird.SizeMode = PictureBoxSizeMode.Zoom;
      this.bird.TabIndex = 4;
      this.bird.TabStop = false;
      this.pipeup.Image = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("|Ţɺͬѽշب\u074C\u0869ॢ\u0A65\u0B64"));
      this.pipeup.Location = new Point(630, 40);
      this.pipeup.Name = \u003F0\u003F.\u003F1\u003F("vŬɴͦѷձ");
      this.pipeup.Size = new Size(91, 118);
      this.pipeup.SizeMode = PictureBoxSizeMode.Zoom;
      this.pipeup.TabIndex = 5;
      this.pipeup.TabStop = false;
      this.Score.AutoSize = true;
      this.Score.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Score.ForeColor = SystemColors.Window;
      this.Score.Location = new Point(12, 418);
      this.Score.Name = \u003F0\u003F.\u003F1\u003F("VŧɬͰѤ");
      this.Score.Size = new Size(0, 21);
      this.Score.TabIndex = 15;
      this.gametimer.Interval = 20;
      this.gametimer.Tick += new EventHandler(this.GameTimerEvent);
      this.label2.AutoSize = true;
      this.label2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = SystemColors.Window;
      this.label2.Location = new Point(12, 55);
      this.label2.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԳ");
      this.label2.Size = new Size(208, 32);
      this.label2.TabIndex = 11;
      this.label2.Text = \u003F0\u003F.\u003F1\u003F("Bţɵͼѽԭثݎ࠭ऩੜ୨ద\u0D56๐གၐᅕ");
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = SystemColors.Window;
      this.label3.Location = new Point(11, 348);
      this.label3.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԲ");
      this.label3.Size = new Size(196, 21);
      this.label3.TabIndex = 16;
      this.label3.Text = \u003F0\u003F.\u003F1\u003F("GŤɰͧѠԲض݁ࠨमੋୣ\u0C79പแཉၕᅂሥፉᑬᕦᙤ");
      this.label4.AutoSize = true;
      this.label4.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = SystemColors.Window;
      this.label4.Location = new Point(11, 372);
      this.label4.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԵ");
      this.label4.Size = new Size(217, 21);
      this.label4.TabIndex = 17;
      this.label4.Text = \u003F0\u003F.\u003F1\u003F("JūɽͤѥԵس݉࠵ऱ\u0A56ୠ\u0C7Cഭ้ནၞᅛቍፊᑃᔥᙉᝬᡦᥤ");
      this.label5.AutoSize = true;
      this.label5.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = SystemColors.Window;
      this.label5.Location = new Point(11, 324);
      this.label5.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԴ");
      this.label5.Size = new Size(188, 21);
      this.label5.TabIndex = 18;
      this.label5.Text = \u003F0\u003F.\u003F1\u003F("GŤɰͧѠԲضݑࠨमੋୣ\u0C79പ์ཉၔᅟሥፉᑬᕦᙤ");
      this.label5.Click += new EventHandler(this.label5_Click);
      this.label6.AutoSize = true;
      this.label6.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = Color.Red;
      this.label6.Location = new Point(110, 226);
      this.label6.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԷ");
      this.label6.Size = new Size(203, 21);
      this.label6.TabIndex = 19;
      this.label6.Text = \u003F0\u003F.\u003F1\u003F("Oųɩ̢зՆ٧ݱ\u0860ॡ\u0A31ଷ\u0C5Cൾ\u0E6C\u0F6Fၮᄭሩ\u135Cᑨᔦᙏ\u1771ᡮᥲᨠ");
      this.label7.AutoSize = true;
      this.label7.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = SystemColors.Window;
      this.label7.Location = new Point(241, 363);
      this.label7.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԶ");
      this.label7.Size = new Size(317, 32);
      this.label7.TabIndex = 20;
      this.label7.Text = \u003F0\u003F.\u003F1\u003F("KŨɼͫѤԶزݒ࠴ल\u0A45\u0B7Fయ്\u0E61ལၸᅯሩ\u135Cᑯᕣᘥᝃᡢ\u196Fᩤ");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(50, 50, 50);
      this.ClientSize = new Size(800, 450);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.Score);
      this.Controls.Add((Control) this.pipeup);
      this.Controls.Add((Control) this.bird);
      this.Controls.Add((Control) this.pipedown);
      this.Controls.Add((Control) this.ground);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = \u003F0\u003F.\u003F1\u003F("LťɩͷѶռْݦ\u0865ॠ");
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = \u003F0\u003F.\u003F1\u003F("Rſɳ͡Ѡնخݛ\u0869६੫\u0B29\u0C45൮\u0E68ཬၣᅢቯ፤");
      this.Load += new EventHandler(this.FlappyVega_Load);
      this.KeyDown += new KeyEventHandler(this.gamekeydown);
      this.KeyUp += new KeyEventHandler(this.gamekeyup);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.ground).EndInit();
      ((ISupportInitialize) this.pipedown).EndInit();
      ((ISupportInitialize) this.bird).EndInit();
      ((ISupportInitialize) this.pipeup).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
