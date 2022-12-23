// Decompiled with JetBrains decompiler
// Type: Vega_X.AdjustableScripts
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
  public class AdjustableScripts : Form
  {
    private ExploitAPI api = new ExploitAPI();
    private Point lastPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Button button9;
    private Button button2;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox4;
    private Label label6;
    private Button button1;
    private Button button3;
    private Button button4;
    private Button button5;

    public AdjustableScripts() => this.InitializeComponent();

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button9_Click(object sender, EventArgs e) => this.Close();

    private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      string text = this.textBox1.Text;
      if ((int) e.KeyChar != (int) Convert.ToChar((object) Keys.Return))
        return;
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("_Ŗɛ͐Кգٞݐࡉॊੜ\u0B5Eం൧ๅཊ၉ᅋቶፉᑅᕚᙇᝓ\u180Eᥜ᩶᭼ᱮᵺṹὭ⁽Ⅵ∸⍝\u2461╾♳\u277F⡿⥦⩪⬣ⱛ\u2D6A\u2E66⽢せㅷ㉣㍠㑠㔣㘿㜡") + text);
      this.textBox1.Clear();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void AdjustableScripts_Load(object sender, EventArgs e) => this.TopMost = true;

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
    {
      string text = this.textBox2.Text;
      if ((int) e.KeyChar != (int) Convert.ToChar((object) Keys.Return))
        return;
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("_Ŗɛ͐Кգٞݐࡉॊੜ\u0B5Eం൧ๅཊ၉ᅋቶፉᑅᕚᙇᝓ\u180Eᥜ᩶᭼ᱮᵺṹὭ⁽Ⅵ∸⍝\u2461╾♳\u277F⡿⥦⩪⬣ⱆ\u2D7E\u2E67⽹じㅨ㉱㍠㑶㔣㘿㜡") + text);
      this.textBox2.Clear();
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
    {
      string text = this.textBox4.Text;
      if ((int) e.KeyChar != (int) Convert.ToChar((object) Keys.Return))
        return;
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("~ŹɺͳлՃټݠ\u087Aॣ\u0A7F୯౮൩ลཌྷၻᅩቱ\u136Fᑱᕽᘣ\u173Fᠡ") + text);
      this.textBox4.Clear();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("]Řɕ͒Иե٘ݒࡋ॔ੂଡ଼ఀൡใ\u0F48။ᅅቸፋᑇᕜᙁᝑ᠌ᥢᩈ\u1B7EᱬᵼṿὯⁿⅫ∶⍟\u2463╸♵\u277D⡽⥸⩴⬡ⱙ\u2D6C\u2E60⽠すㅹ㉭㍢㑢㔥㘹㜣㠳㤷"));
      Console.Beep();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("yżɱ;дՎٷݥ\u087D०\u0A64\u0B72\u0C71\u0D74\u0E3E\u0F48ၼᅬቺ።ᑾᕰᘨ\u173Aᠦᤴᨽᬵᰬᴳ"));
      Console.Beep();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("]Řɕ͒Иե٘ݒࡋ॔ੂଡ଼ఀൡใ\u0F48။ᅅቸፋᑇᕜᙁᝑ᠌ᥢᩈ\u1B7EᱬᵼṿὯⁿⅫ∶⍟\u2463╸♵\u277D⡽⥸⩴⬡ⱄ\u2D78\u2E61⽻ずㅦ㉿㍢㑴㔥㘹㜣㠷㤱"));
      Console.Beep();
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("]Řɕ͒Иե٘ݒࡋ॔ੂଡ଼ఀൡใ\u0F48။ᅅቸፋᑇᕜᙁᝑ᠌ᥢᩈ\u1B7EᱬᵼṿὯⁿⅫ∶⍟\u2463╸♵\u277D⡽⥸⩴⬡ⱄ\u2D78\u2E61⽻ずㅦ㉿㍢㑴㔥㘹㜣㠷㤱"));
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("yżɱ;дՎٷݥ\u087D०\u0A64\u0B72\u0C71\u0D74\u0E3E\u0F48ၼᅬቺ።ᑾᕰᘨ\u173Aᠦᤴᨽᬵᰬᴳ"));
      this.api.SendLuaScript(\u003F0\u003F.\u003F1\u003F("]Řɕ͒Иե٘ݒࡋ॔ੂଡ଼ఀൡใ\u0F48။ᅅቸፋᑇᕜᙁᝑ᠌ᥢᩈ\u1B7EᱬᵼṿὯⁿⅫ∶⍟\u2463╸♵\u277D⡽⥸⩴⬡ⱙ\u2D6C\u2E60⽠すㅹ㉭㍢㑢㔥㘹㜣㠳㤷"));
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("mŇɆ̉ѫՏهݗࡅी\u0A56ୄ\u0C52ി๓ིၸᅲቼ\u1370ᑻᕶᙢ\u177C\u187B\u197Dᩡᬱ᱘ᵮṸὨ\u202Cⅉ≯⍬\u2466┧♔❠⡷⥦⩶⬯"));
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void label1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void label1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AdjustableScripts));
      this.panel1 = new Panel();
      this.button9 = new Button();
      this.button2 = new Button();
      this.panel2 = new Panel();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox4 = new TextBox();
      this.label6 = new Label();
      this.button1 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.panel1.Controls.Add((Control) this.button9);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮ\u0530");
      this.panel1.Size = new Size(393, 44);
      this.panel1.TabIndex = 0;
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.button9.BackColor = Color.FromArgb(60, 60, 60);
      this.button9.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button9.FlatStyle = FlatStyle.Flat;
      this.button9.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button9.ForeColor = SystemColors.ControlLightLight;
      this.button9.Location = new Point(360, 5);
      this.button9.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլظ");
      this.button9.Size = new Size(30, 27);
      this.button9.TabIndex = 18;
      this.button9.Text = \u003F0\u003F.\u003F1\u003F("Y");
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button2.BackColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ControlLightLight;
      this.button2.Location = new Point(327, 5);
      this.button2.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլس");
      this.button2.Size = new Size(30, 27);
      this.button2.TabIndex = 17;
      this.button2.Text = \u003F0\u003F.\u003F1\u003F("―");
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(3, 3);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(47, 37);
      this.panel2.TabIndex = 12;
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Window;
      this.label1.Location = new Point((int) sbyte.MaxValue, 10);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(124, 21);
      this.label1.TabIndex = 4;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("FŪɩͬЬՓتܤࠨ॔\u0A65\u0B77౭\u0D73\u0E76ི");
      this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new MouseEventHandler(this.label1_MouseMove);
      this.label2.AutoSize = true;
      this.label2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = SystemColors.Control;
      this.label2.Location = new Point(90, 53);
      this.label2.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԳ");
      this.label2.Size = new Size(218, 25);
      this.label2.TabIndex = 207;
      this.label2.Text = \u003F0\u003F.\u003F1\u003F("TžɴͦѲձ٥ݵ\u087Dमੀୣ౯ൣ\u0E6Fཡၤᅧቱ\u136Dᑬᕬᙲ");
      this.label2.Click += new EventHandler(this.label2_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = SystemColors.Window;
      this.label3.Location = new Point(12, 86);
      this.label3.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԲ");
      this.label3.Size = new Size(93, 21);
      this.label3.TabIndex = 208;
      this.label3.Text = \u003F0\u003F.\u003F1\u003F("]Ũɤͬѵյ١ݦ\u0866ऻ");
      this.label4.AutoSize = true;
      this.label4.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = SystemColors.Window;
      this.label4.Location = new Point(262, 87);
      this.label4.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԵ");
      this.label4.Size = new Size(103, 21);
      this.label4.TabIndex = 209;
      this.label4.Text = \u003F0\u003F.\u003F1\u003F("Aſɤ\u0378ЧՖ٪ݳ\u0866॰\u0A3B");
      this.textBox1.Location = new Point(15, 111);
      this.textBox1.Name = \u003F0\u003F.\u003F1\u003F("|Ţɾͱцլٺܰ");
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 210;
      this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
      this.textBox1.KeyPress += new KeyPressEventHandler(this.textBox1_KeyPress);
      this.textBox2.Location = new Point(265, 111);
      this.textBox2.Name = \u003F0\u003F.\u003F1\u003F("|Ţɾͱцլٺܳ");
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 211;
      this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
      this.textBox2.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
      this.textBox4.Location = new Point(139, 111);
      this.textBox4.Name = \u003F0\u003F.\u003F1\u003F("|Ţɾͱцլٺܵ");
      this.textBox4.Size = new Size(100, 20);
      this.textBox4.TabIndex = 230;
      this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
      this.textBox4.KeyPress += new KeyPressEventHandler(this.textBox4_KeyPress);
      this.label6.AutoSize = true;
      this.label6.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = SystemColors.Window;
      this.label6.Location = new Point(136, 86);
      this.label6.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԷ");
      this.label6.Size = new Size(65, 21);
      this.label6.TabIndex = 228;
      this.label6.Text = \u003F0\u003F.\u003F1\u003F("Oŵɧͳѭշٻܻ");
      this.button1.BackColor = Color.FromArgb(65, 65, 65);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = SystemColors.Control;
      this.button1.Location = new Point(15, 136);
      this.button1.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլذ");
      this.button1.Size = new Size(100, 23);
      this.button1.TabIndex = 232;
      this.button1.Text = \u003F0\u003F.\u003F1\u003F("WŁɐ͇ѕ");
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.BackColor = Color.FromArgb(65, 65, 65);
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = SystemColors.Control;
      this.button3.Location = new Point(139, 136);
      this.button3.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլز");
      this.button3.Size = new Size(100, 23);
      this.button3.TabIndex = 233;
      this.button3.Text = \u003F0\u003F.\u003F1\u003F("WŁɐ͇ѕ");
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.BackColor = Color.FromArgb(65, 65, 65);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = SystemColors.Control;
      this.button4.Location = new Point(265, 136);
      this.button4.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլص");
      this.button4.Size = new Size(100, 23);
      this.button4.TabIndex = 234;
      this.button4.Text = \u003F0\u003F.\u003F1\u003F("WŁɐ͇ѕ");
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.button5.BackColor = Color.FromArgb(65, 65, 65);
      this.button5.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = SystemColors.Control;
      this.button5.Location = new Point(12, 167);
      this.button5.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլش");
      this.button5.Size = new Size(370, 40);
      this.button5.TabIndex = 235;
      this.button5.Text = \u003F0\u003F.\u003F1\u003F("OřɈ͟эԸٖݚ࡙ऴੀୗ\u0C45ൄๆཀ၊ᅟራ፞ᑆᔨᙃᝃᡃ᥅ᩖ\u1B4E᱕");
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(50, 50, 50);
      this.ClientSize = new Size(394, 218);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F(".Žɠͮѵԫٍݠ\u086D९"));
      this.Name = \u003F0\u003F.\u003F1\u003F("PŴɥͻѾո٪ݨ\u0865७\u0A54\u0B65\u0C77൭\u0E73ྲྀၲ");
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = \u003F0\u003F.\u003F1\u003F("PŴɥͻѾո٪ݨ\u0865७\u0A54\u0B65\u0C77൭\u0E73ྲྀၲ");
      this.Load += new EventHandler(this.AdjustableScripts_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
