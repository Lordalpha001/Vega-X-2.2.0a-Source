// Decompiled with JetBrains decompiler
// Type: Vega_X.UserControl1
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using FastColoredTextBoxNS;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Vega_X
{
  public class UserControl1 : UserControl
  {
    private IContainer components = (IContainer) null;
    private FastColoredTextBox fastColoredTextBox1;
    private ContextMenuStrip contextMenuStrip1;

    public UserControl1() => this.InitializeComponent();

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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (UserControl1));
      this.fastColoredTextBox1 = new FastColoredTextBox();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      ((ISupportInitialize) this.fastColoredTextBox1).BeginInit();
      this.SuspendLayout();
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
      this.fastColoredTextBox1.AutoScrollMinSize = new Size(507, 126);
      this.fastColoredTextBox1.BackBrush = (Brush) null;
      this.fastColoredTextBox1.BackColor = Color.FromArgb(50, 50, 50);
      this.fastColoredTextBox1.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
      this.fastColoredTextBox1.CharHeight = 14;
      this.fastColoredTextBox1.CharWidth = 8;
      this.fastColoredTextBox1.CommentPrefix = \u003F0\u003F.\u003F1\u003F("/Ĭ");
      this.fastColoredTextBox1.Cursor = Cursors.IBeam;
      this.fastColoredTextBox1.DisabledColor = Color.FromArgb(100, 180, 180, 180);
      this.fastColoredTextBox1.Dock = DockStyle.Fill;
      this.fastColoredTextBox1.Font = new Font(\u003F0\u003F.\u003F1\u003F("HťɼͺѮգٷܤࡍ१\u0A76"), 9.5f);
      this.fastColoredTextBox1.ForeColor = Color.White;
      this.fastColoredTextBox1.IndentBackColor = Color.FromArgb(45, 45, 45);
      this.fastColoredTextBox1.IsReplaceMode = false;
      this.fastColoredTextBox1.Language = Language.Lua;
      this.fastColoredTextBox1.LeftBracket = '(';
      this.fastColoredTextBox1.LeftBracket2 = '{';
      this.fastColoredTextBox1.Location = new Point(0, 0);
      this.fastColoredTextBox1.Name = \u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ");
      this.fastColoredTextBox1.Paddings = new Padding(0);
      this.fastColoredTextBox1.RightBracket = ')';
      this.fastColoredTextBox1.RightBracket2 = '}';
      this.fastColoredTextBox1.SelectionColor = Color.FromArgb(60, 0, 0, (int) byte.MaxValue);
      this.fastColoredTextBox1.ServiceColors = (ServiceColors) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("GŁɬͪўճٷݵ\u086Bॽੳୂ\u0C70൬\u0E67ཐၾᅨሾጠᑞᕩᙹ\u177CᡠᥫᩢᭅᱪᵨṬὰ\u2072"));
      this.fastColoredTextBox1.Size = new Size(669, 251);
      this.fastColoredTextBox1.TabIndex = 24;
      this.fastColoredTextBox1.Text = componentResourceManager.GetString(\u003F0\u003F.\u003F1\u003F("~Ŷɥ͡їռپݾ\u0862४੪\u0B59౩\u0D73\u0E7Eཋၧᅿሷጫᑐᕦᙺ\u1775"));
      this.fastColoredTextBox1.Zoom = 100;
      this.fastColoredTextBox1.Load += new EventHandler(this.fastColoredTextBox1_Load);
      this.contextMenuStrip1.Name = \u003F0\u003F.\u003F1\u003F("rſɡͺѨմٿ݇\u086C०ੲ\u0B55\u0C71\u0D76\u0E6Aིူ");
      this.contextMenuStrip1.Size = new Size(61, 4);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.fastColoredTextBox1);
      this.Name = \u003F0\u003F.\u003F1\u003F("YŸɯͻыը٨ݱ\u0876६੮ର");
      this.Size = new Size(669, 251);
      ((ISupportInitialize) this.fastColoredTextBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
