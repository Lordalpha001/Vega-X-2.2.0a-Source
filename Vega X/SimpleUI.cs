// Decompiled with JetBrains decompiler
// Type: Vega_X.SimpleUI
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using EasyExploits;
using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
  public class SimpleUI : Form
  {
    private ExploitAPI api = new ExploitAPI();
    private Module module = new Module();
    private Point lastPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Button button10;
    private Button button1;
    private FastColoredTextBox fastColoredTextBox1;
    private Button button3;
    private Button button2;
    private Button button4;
    private Button button5;
    private Button button6;

    public SimpleUI() => this.InitializeComponent();

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button10_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void button5_Click(object sender, EventArgs e) => this.module.LaunchExploit();

    private void button2_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void button3_Click(object sender, EventArgs e) => this.module.ExecuteScript(this.fastColoredTextBox1.Text);

    private void button4_Click(object sender, EventArgs e) => this.fastColoredTextBox1.Clear();

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void SimpleUI_Load(object sender, EventArgs e) => this.TopMost = true;

    private void label1_MouseUp(object sender, MouseEventArgs e)
    {
    }

    private void label1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void label1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void button6_Click(object sender, EventArgs e) => new ScriptHub().Show();

    private void fastColoredTextBox1_Load(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SimpleUI));
      this.panel1 = new Panel();
      this.button1 = new Button();
      this.button10 = new Button();
      this.panel2 = new Panel();
      this.label1 = new Label();
      this.fastColoredTextBox1 = new FastColoredTextBox();
      this.button3 = new Button();
      this.button2 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.fastColoredTextBox1).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.button10);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(0, -1);
      this.panel1.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮ\u0530");
      this.panel1.Size = new Size(543, 41);
      this.panel1.TabIndex = 0;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.button1.BackColor = Color.FromArgb(60, 60, 60);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = SystemColors.ControlLightLight;
      this.button1.Location = new Point(509, 5);
      this.button1.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլذ");
      this.button1.Size = new Size(30, 27);
      this.button1.TabIndex = 15;
      this.button1.Text = \u003F0\u003F.\u003F1\u003F("Y");
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button10.BackColor = Color.FromArgb(60, 60, 60);
      this.button10.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button10.FlatStyle = FlatStyle.Flat;
      this.button10.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button10.ForeColor = SystemColors.ControlLightLight;
      this.button10.Location = new Point(475, 5);
      this.button10.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܱ");
      this.button10.Size = new Size(28, 27);
      this.button10.TabIndex = 14;
      this.button10.Text = \u003F0\u003F.\u003F1\u003F("―");
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(0, 1);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(44, 40);
      this.panel2.TabIndex = 11;
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Window;
      this.label1.Location = new Point(203, 9);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(144, 21);
      this.label1.TabIndex = 4;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("DŴɷͮЮՕجܦࠪग़\u0A61୪\u0C76൩\u0E61༣ၗᅈ");
      this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new MouseEventHandler(this.label1_MouseMove);
      this.label1.MouseUp += new MouseEventHandler(this.label1_MouseUp);
      this.fastColoredTextBox1.AutoCompleteBracketsList = new char[10]
      {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '"',
        '"',
        '\'',
        '\''
      };
      this.fastColoredTextBox1.AutoIndentCharsPatterns = \u003F0\u003F.\u003F1\u003F("9Ĺɬͭуԅٵݱ࡛ॷ\u0A04\u0B74ఃഏ\u0E7Aབၸᅔሉገᐟᕃ᙭\u1737ᠴᤤᨦ᭫ᱹᵹṱὰ\u202A℮∻⍍\u2463┥☦✲⠰⥹⩫⭧Ɐⵢ⸸⼫〯ㄪ㈏㌋");
      this.fastColoredTextBox1.AutoScrollMinSize = new Size(195, 70);
      this.fastColoredTextBox1.BackBrush = (Brush) null;
      this.fastColoredTextBox1.BackColor = Color.FromArgb(50, 50, 50);
      this.fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
      this.fastColoredTextBox1.CharHeight = 14;
      this.fastColoredTextBox1.CharWidth = 8;
      this.fastColoredTextBox1.CommentPrefix = \u003F0\u003F.\u003F1\u003F("/Ĭ");
      this.fastColoredTextBox1.Cursor = Cursors.IBeam;
      this.fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
      this.fastColoredTextBox1.Font = new Font(\u003F0\u003F.\u003F1\u003F("HťɼͺѮգٷܤࡍ१\u0A76"), 9.75f);
      this.fastColoredTextBox1.ForeColor = Color.White;
      this.fastColoredTextBox1.IndentBackColor = Color.FromArgb(40, 40, 40);
      this.fastColoredTextBox1.IsReplaceMode = false;
      this.fastColoredTextBox1.Language = Language.Lua;
      this.fastColoredTextBox1.LeftBracket = '(';
      this.fastColoredTextBox1.LeftBracket2 = '{';
      this.fastColoredTextBox1.Location = new Point(6, 46);
      this.fastColoredTextBox1.Name = \u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ");
      this.fastColoredTextBox1.Paddings = new Padding(0);
      this.fastColoredTextBox1.RightBracket = ')';
      this.fastColoredTextBox1.RightBracket2 = '}';
      this.fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, (int) byte.MaxValue);
      this.fastColoredTextBox1.ServiceColors = (ServiceColors) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("GŁɬͪўճٷݵ\u086Bॽੳୂ\u0C70൬\u0E67ཐၾᅨሾጠᑞᕩᙹ\u177CᡠᥫᩢᭅᱪᵨṬὰ\u2072"));
      this.fastColoredTextBox1.Size = new Size(525, 154);
      this.fastColoredTextBox1.TabIndex = 25;
      this.fastColoredTextBox1.Text = \u003F0\u003F.\u003F1\u003F("lŭȟͨј՛ٚܚ\u0861घਚଖ౦\u0D5D\u0E5Eགၝᅕሏ\u137Bᑤᔡᘡᜧᠣᤅᨊᬆᱣᵑṏ\u1F4E\u200CⅬ≊⍟\u243D╙♣\u277F⡺⥭⩣⭿ⱺ\u2D7A⸞⼘〜ㄚ\u3222㌣㐭㕁㙪㝮㡬㤨㩅㭿㰥㴵㹜㽄䀱");
      this.fastColoredTextBox1.Zoom = 100;
      this.fastColoredTextBox1.Load += new EventHandler(this.fastColoredTextBox1_Load);
      this.button3.BackColor = Color.FromArgb(65, 65, 65);
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = SystemColors.Control;
      this.button3.Location = new Point(12, 206);
      this.button3.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլز");
      this.button3.Size = new Size(89, 30);
      this.button3.TabIndex = 26;
      this.button3.Text = \u003F0\u003F.\u003F1\u003F("BžɠͧѶն٤");
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button2.BackColor = Color.FromArgb(65, 65, 65);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.ForeColor = SystemColors.Control;
      this.button2.Location = new Point(202, 206);
      this.button2.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլس");
      this.button2.Size = new Size(89, 30);
      this.button2.TabIndex = 27;
      this.button2.Text = \u003F0\u003F.\u003F1\u003F("FŸɢͨХՂ٪ݮ\u0864");
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button4.BackColor = Color.FromArgb(65, 65, 65);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = SystemColors.Control;
      this.button4.Location = new Point(107, 206);
      this.button4.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլص");
      this.button4.Size = new Size(89, 30);
      this.button4.TabIndex = 28;
      this.button4.Text = \u003F0\u003F.\u003F1\u003F("FŨɦͣѳ");
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.BackColor = Color.FromArgb(65, 65, 65);
      this.button5.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = SystemColors.Control;
      this.button5.Location = new Point(442, 206);
      this.button5.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլش");
      this.button5.Size = new Size(89, 30);
      this.button5.TabIndex = 29;
      this.button5.Text = \u003F0\u003F.\u003F1\u003F("Gűɰ͢ѡթ");
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.BackColor = Color.FromArgb(65, 65, 65);
      this.button6.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.ForeColor = SystemColors.Control;
      this.button6.Location = new Point(297, 206);
      this.button6.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլط");
      this.button6.Size = new Size(89, 30);
      this.button6.TabIndex = 30;
      this.button6.Text = \u003F0\u003F.\u003F1\u003F("YŪɺͮѶձؤ\u074B\u0877ॣ");
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(45, 45, 45);
      this.ClientSize = new Size(543, 245);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.fastColoredTextBox1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F(".Žɠͮѵԫٍݠ\u086D९"));
      this.Name = \u003F0\u003F.\u003F1\u003F("[Ůɫ͵Ѩզ݈ٗ");
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = \u003F0\u003F.\u003F1\u003F("[Ůɫ͵Ѩզ݈ٗ");
      this.Load += new EventHandler(this.SimpleUI_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.fastColoredTextBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
