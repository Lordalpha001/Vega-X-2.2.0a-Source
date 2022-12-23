// Decompiled with JetBrains decompiler
// Type: Vega_X.VegaX
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using ComponentFactory.Krypton.Toolkit;
using EasyExploits;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
  public class VegaX : KryptonForm
  {
    private ExploitAPI api = new ExploitAPI();
    private Module module = new Module();
    private Point lastPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Button button1;
    private Button button2;
    private ListBox listBox1;
    private TabControl TabControl1;
    private Button RTab;
    private Label label2;
    private Button button12;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripSeparator toolStripSeparator11;
    private CheckBox checkBox1;
    private TrackBar trackBar1;
    private TrackBar trackBar2;
    private Timer timer1;
    private ToolStripSeparator toolStripSeparator14;
    private ToolStripMenuItem topBarPanelColorsToolStripMenuItem;
    private ToolStripMenuItem lightBlueToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripMenuItem deepRedToolStripMenuItem;
    private ToolStripMenuItem lightGreenToolStripMenuItem;
    private Button button13;
    private ToolStripSeparator toolStripSeparator17;
    private ToolStripMenuItem dimRedToolStripMenuItem;
    private ToolStripMenuItem brightPurpleToolStripMenuItem;
    private ToolStripMenuItem tRANSPARENTTEXTBOXToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem onToolStripMenuItem;
    private ToolStripMenuItem offToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripSeparator toolStripSeparator6;
    private RadioButton EasyExploitRadioButton;
    private RadioButton WrdRadioButton;
    private ToolStripMenuItem toolStripMenuItem1;
    private Panel panel3;
    private Panel panel4;
    private Panel panel5;
    private Panel panel6;
    private Panel panel7;
    private Panel panel8;
    private PictureBox pictureBox1;
    private Panel panel10;
    private Panel panel11;
    private Panel panel12;
    private Panel panel13;
    private Button button11;
    private Panel panel14;
    private RButton rButton1;
    private RButton rButton2;
    private RButton rButton3;
    private RButton rButton4;
    private RButton rButton5;
    private RButton rButton6;
    private RButton rButton7;
    private RButton rButton8;
    private RButton rButton9;
    private RButton rButton10;
    private Button ATab;
    private KryptonColorButton themesbutton;
    private Button button3;
    private Button button4;

    public VegaX() => this.InitializeComponent();

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      switch (MessageBox.Show(\u003F0\u003F.\u003F1\u003F("gōȁ\u0379Ѱիؽݎ\u087Eॻੵ\u0B74౮ശโཱུၽᅦሱፄᑠᔮᙎᝠᡤ\u1979ᩬᬨ᱑ᵣṢὥ‣\u215A∾"), \u003F0\u003F.\u003F1\u003F("DŴɷͮЮՕجݷࠪौੰୢ\u0C65\u0D70\u0E70ཪၭᅯ"), MessageBoxButtons.YesNo))
      {
        case DialogResult.Yes:
          Application.Exit();
          break;
      }
    }

    private void panel2_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("AŪɮͬШՅٿܥ࠵ड़\u0A44\u0B31"), \u003F0\u003F.\u003F1\u003F("DŴɠ͠Ѫնٲ"), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
    }

    private void label1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void label1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void button6_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
      {
        using (StreamWriter streamWriter = new StreamWriter(stream))
          streamWriter.Write(fastColoredTextBox.Text);
      }
    }

    private void button8_Click(object sender, EventArgs e) => (((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text = \u003F0\u003F.\u003F1\u003F("");

    private void button7_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void button5_Click(object sender, EventArgs e) => new Options().Show();

    private void VegaX_Load(object sender, EventArgs e)
    {
      this.timer1.Start();
      string text = \u003F0\u003F.\u003F1\u003F("YŪɺͮѶձ٦ݬ\u087Aड") + (this.TabControl1.TabCount + 1).ToString();
      UserControl1 userControl1 = new UserControl1();
      userControl1.Dock = DockStyle.Fill;
      TabPage tabPage = new TabPage(text);
      tabPage.Controls.Add((Control) userControl1);
      this.TabControl1.TabPages.Add(tabPage);
      this.TopMost = true;
      this.listBox1.Items.Clear();
      Functions.PopulateListBox(this.listBox1, \u003F0\u003F.\u003F1\u003F("'ħɔͥѷխٳݶ\u0872"), \u003F0\u003F.\u003F1\u003F("/Īɷͺѵ"));
      Functions.PopulateListBox(this.listBox1, \u003F0\u003F.\u003F1\u003F("'ħɔͥѷխٳݶ\u0872"), \u003F0\u003F.\u003F1\u003F("/ĪɯͷѠ"));
      this.pictureBox1.AllowDrop = true;
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.EasyExploitRadioButton.Checked = true;
    }

    private void button9_Click(object sender, EventArgs e) => new ScriptManager().Show();

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => (((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text = File.ReadAllText(string.Format(\u003F0\u003F.\u003F1\u003F("#ģɘͩѻաٷݲ\u0876फ\u0A78ଲ\u0C7C"), this.listBox1.SelectedItem));

    private void button3_Click(object sender, EventArgs e)
    {
      if (this.WrdRadioButton.Checked)
      {
        this.api.SendLuaScript((((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text);
      }
      else
      {
        if (!this.EasyExploitRadioButton.Checked)
          return;
        this.module.ExecuteScript((((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text);
      }
    }

    private void button11_Click(object sender, EventArgs e) => this.api.LaunchExploit();

    private void button4_Click(object sender, EventArgs e) => new ScriptHub().Show();

    private void button12_Click(object sender, EventArgs e)
    {
      string text = \u003F0\u003F.\u003F1\u003F("Zūɵͯѵհ١ݭ\u0879") + (this.TabControl1.TabCount + 1).ToString();
      UserControl1 userControl1 = new UserControl1();
      userControl1.Dock = DockStyle.Fill;
      TabPage tabPage = new TabPage(text);
      tabPage.Controls.Add((Control) userControl1);
      this.TabControl1.TabPages.Add(tabPage);
    }

    private void RTab_Click(object sender, EventArgs e) => this.TabControl1.TabPages.Remove(this.TabControl1.SelectedTab);

    private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void TabControl1_Click(object sender, EventArgs e)
    {
    }

    private void panel1_Click(object sender, EventArgs e)
    {
    }

    private void listBox1_Click(object sender, EventArgs e)
    {
    }

    private void VegaX_Click(object sender, EventArgs e)
    {
    }

    private void executeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.listBox1.SelectedIndex == -1)
        return;
      this.api.SendLuaScript(File.ReadAllText(\u003F0\u003F.\u003F1\u003F("{ŤɴͬѴշٱݝ") + this.listBox1.SelectedItem.ToString()));
      this.api.SendLuaCScript(File.ReadAllText(\u003F0\u003F.\u003F1\u003F("{ŤɴͬѴշٱݝ") + this.listBox1.SelectedItem.ToString()));
    }

    private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      if (this.listBox1.SelectedIndex != -1)
      {
        fastColoredTextBox.Text = File.ReadAllText(\u003F0\u003F.\u003F1\u003F("{ŤɴͬѴշٱݝ") + this.listBox1.SelectedItem.ToString());
      }
      else
      {
        int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("\u0018īȣ̤зԦ٢ܲࠥ॓ਜ਼\u0B5Eైഛ๛༙။ᅔቄ\u135Cᑄᕇᘒ\u1757ᡂ᥀ᩃᬍ᱘ᵃṏἉ⁄ⅎ≕⍑␄╁♇❇⡏⥭⩻⬽ⱨ\u2D69\u2E63⽰ぶㅰ㈶㍡㑻㔳㙾㝾㡱㥫㩧㭣㱫㴫㹣㽽䀨䅮䉨䌥䑰䕢䙠䜯"), \u003F0\u003F.\u003F1\u003F("JŢɯͤ"));
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
    }

    private void VegaX_FormClosing(object sender, FormClosingEventArgs e)
    {
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void redThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.DarkRed;

    private void orangeThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Orange;

    private void yellowThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Yellow;

    private void greenThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Green;

    private void blueThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Blue;

    private void purpleThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Purple;

    private void blackThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Black;

    private void pinkThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Pink;

    private void whiteThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.White;

    private void dEFAULTTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form.ActiveForm.BackColor = this.button12.BackColor;
      this.panel1.BackColor = this.button13.BackColor;
    }

    private void toolStripSeparator6_Click(object sender, EventArgs e)
    {
    }

    private void cUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void pictureBox1_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;

    private void pictureBox1_DragDrop(object sender, DragEventArgs e)
    {
      object data = e.Data.GetData(DataFormats.FileDrop);
      if (data == null)
        return;
      string[] strArray = data as string[];
      if (strArray.Length != 0)
        this.pictureBox1.Image = Image.FromFile(strArray[0]);
    }

    private void rEMOVECUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
    {
      switch (MessageBox.Show(\u003F0\u003F.\u003F1\u003F("kŁȍ͵ф՟؉ݺࡂे\u0A49ୈౚം\u0E76ཁၱᅪሽፈᑴᔺᙋ\u177D\u187A\u1979ᩣ᭱ᰳᵋṾὥ⁽℮≎⍹\u2478╾♦❥⠧⥒⩭⭡Ɱⵧ⸾"), \u003F0\u003F.\u003F1\u003F("YūɪͭЫՒةݴ॒ࠧ੭ୡ౮൧\u0E72"), MessageBoxButtons.YesNo))
      {
        case DialogResult.Yes:
          this.pictureBox1.Image = (Image) null;
          break;
      }
    }

    private void lightBlueThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.LightBlue;

    private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
    {
      if (this.checkBox1.CheckState == CheckState.Checked)
        Form.ActiveForm.Opacity = (double) this.trackBar1.Value / 10.0;
      if (this.checkBox1.CheckState != CheckState.Unchecked)
        return;
      Form.ActiveForm.Opacity = (double) this.trackBar2.Value / 10.0;
    }

    private void timer1_Tick_1(object sender, EventArgs e)
    {
      if (this.Opacity < 1.0)
        this.Opacity += 0.15;
      else
        this.timer1.Stop();
    }

    private void toolStripSeparator15_Click(object sender, EventArgs e)
    {
    }

    private void lightBlueToolStripMenuItem_Click_1(object sender, EventArgs e) => this.panel1.BackColor = Color.CornflowerBlue;

    private void deepRedToolStripMenuItem_Click(object sender, EventArgs e) => this.panel1.BackColor = Color.OrangeRed;

    private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e) => this.panel1.BackColor = Color.DarkSeaGreen;

    private void dEFAULTCOLORToolStripMenuItem_Click_1(object sender, EventArgs e) => this.panel1.BackColor = this.button13.BackColor;

    private void dimRedToolStripMenuItem_Click(object sender, EventArgs e) => this.panel1.BackColor = Color.IndianRed;

    private void brightPurpleToolStripMenuItem_Click(object sender, EventArgs e) => this.panel1.BackColor = Color.MediumPurple;

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void grayThemeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Gray;

    private void redToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Red;

    private void orangeToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Orange;

    private void yellowToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Yellow;

    private void greenToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Green;

    private void blueToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Blue;

    private void purpleToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Purple;

    private void darkGreenToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.DarkGreen;

    private void lightBlueToolStripMenuItem1_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.LightBlue;

    private void blackToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Black;

    private void pinkToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Pink;

    private void tanToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.Tan;

    private void whiteToolStripMenuItem_Click(object sender, EventArgs e) => Form.ActiveForm.BackColor = Color.White;

    private void dragAnyImageIntoTheBlankSpaceToAddACustomThemeToolStripMenuItem_Click(
      object sender,
      EventArgs e)
    {
    }

    private void cUSTOMTHEMEToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("\u001Eīȹ̰ѶԔغܷ\u0872कਢଠా൭ญ༥ဳᅩሁጪᐧᔢᘡᝬ᠅ᤈᨆᬟᱸᵔṐ\u1F5E‚ⅷ≝⍏⑂┕♠❜⠒⥥⩘⭊Ⰾⴊ\u2E78⽙かㅇ\u325B㍗㑇㕗㙁㝍㡖㤆㨀㭜㱶㵸㹿㽰䁸䅶䉠䌷䑂䕺䘴䝆䡡䥴䨰䭎䰮䵎乹佸偾兦剥匧呒啭噡坮塧夯"));
    }

    private void tRANSPARENTTEXTBOXToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void onToolStripMenuItem_Click(object sender, EventArgs e) => this.TabControl1.SendToBack();

    private void offToolStripMenuItem_Click(object sender, EventArgs e) => this.TabControl1.BringToFront();

    private void button14_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
      this.api.SendLuaScript(fastColoredTextBox.Text);
      this.api.SendLuaCScript(fastColoredTextBox.Text);
    }

    private void button15_Click(object sender, EventArgs e) => new ScriptHub().Show();

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void WrdRadioButton_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e) => this.panel1.BackColor = Color.Black;

    private void EasyExploitRadioButton_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button4_Click_1(object sender, EventArgs e) => (((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text = \u003F0\u003F.\u003F1\u003F("");

    private void panel4_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panel4_Click(object sender, EventArgs e) => (((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text = \u003F0\u003F.\u003F1\u003F("");

    private void panel3_Click(object sender, EventArgs e)
    {
      if (this.WrdRadioButton.Checked)
      {
        this.api.SendLuaScript((((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text);
      }
      else
      {
        if (!this.EasyExploitRadioButton.Checked)
          return;
        this.module.ExecuteScript((((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text);
      }
    }

    private void button8_Click_1(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void panel5_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void button6_Click_1(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
      {
        using (StreamWriter streamWriter = new StreamWriter(stream))
          streamWriter.Write(fastColoredTextBox.Text);
      }
    }

    private void panel6_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
      {
        using (StreamWriter streamWriter = new StreamWriter(stream))
          streamWriter.Write(fastColoredTextBox.Text);
      }
    }

    private void button7_Click_1(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
      this.api.SendLuaScript(fastColoredTextBox.Text);
      this.api.SendLuaCScript(fastColoredTextBox.Text);
    }

    private void panel7_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
      this.api.SendLuaScript(fastColoredTextBox.Text);
      this.api.SendLuaCScript(fastColoredTextBox.Text);
    }

    private void button14_Click_1(object sender, EventArgs e) => new Options().Show();

    private void panel8_Click(object sender, EventArgs e) => new Options().Show();

    private void panel9_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panel9_Click(object sender, EventArgs e)
    {
    }

    private void button16_Click(object sender, EventArgs e)
    {
    }

    private void button5_Click_1(object sender, EventArgs e)
    {
      if (this.WrdRadioButton.Checked)
      {
        this.api.LaunchExploit();
      }
      else
      {
        if (!this.EasyExploitRadioButton.Checked)
          return;
        this.module.LaunchExploit();
      }
    }

    private void panel10_Click(object sender, EventArgs e)
    {
      if (this.WrdRadioButton.Checked)
      {
        this.api.LaunchExploit();
      }
      else
      {
        if (!this.EasyExploitRadioButton.Checked)
          return;
        this.module.LaunchExploit();
      }
    }

    private void button10_Click(object sender, EventArgs e)
    {
    }

    private void panel12_Paint(object sender, PaintEventArgs e) => this.panel12.BackColor = this.rButton8.BackColor;

    private void button10_Click_1(object sender, EventArgs e) => new SimpleUI().Show();

    private void panel12_Click(object sender, EventArgs e) => new SimpleUI().Show();

    private void panel13_Click(object sender, EventArgs e) => new ScriptManager().Show();

    private void panel14_Click(object sender, EventArgs e) => new ScriptHub().Show();

    private void button11_Click_1(object sender, EventArgs e)
    {
      this.listBox1.Items.Clear();
      Functions.PopulateListBox(this.listBox1, \u003F0\u003F.\u003F1\u003F("'ħɔͥѷխٳݶ\u0872"), \u003F0\u003F.\u003F1\u003F("/Īɷͺѵ"));
      Functions.PopulateListBox(this.listBox1, \u003F0\u003F.\u003F1\u003F("'ħɔͥѷխٳݶ\u0872"), \u003F0\u003F.\u003F1\u003F("/ĪɯͷѠ"));
    }

    private void panel9_Leave(object sender, EventArgs e)
    {
    }

    private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
    {
    }

    private void panel10_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panel7_Paint(object sender, PaintEventArgs e)
    {
    }

    private void panel14_Paint(object sender, PaintEventArgs e)
    {
    }

    private void rButton1_Click(object sender, EventArgs e)
    {
      if (this.WrdRadioButton.Checked)
      {
        this.api.LaunchExploit();
      }
      else
      {
        if (!this.EasyExploitRadioButton.Checked)
          return;
        this.module.LaunchExploit();
      }
    }

    private void rButton2_Click(object sender, EventArgs e)
    {
      if (this.WrdRadioButton.Checked)
      {
        this.api.SendLuaScript((((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text);
      }
      else
      {
        if (!this.EasyExploitRadioButton.Checked)
          return;
        this.module.ExecuteScript((((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text);
      }
    }

    private void rButton3_Click(object sender, EventArgs e) => (((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).Text = \u003F0\u003F.\u003F1\u003F("");

    private void rButton4_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
      this.api.SendLuaScript(fastColoredTextBox.Text);
      this.api.SendLuaCScript(fastColoredTextBox.Text);
    }

    private void rButton5_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
      {
        using (StreamWriter streamWriter = new StreamWriter(stream))
          streamWriter.Write(fastColoredTextBox.Text);
      }
    }

    private void rButton6_Click(object sender, EventArgs e)
    {
      FastColoredTextBox fastColoredTextBox = ((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox;
      OpenFileDialog openFileDialog = new OpenFileDialog();
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      openFileDialog.Title = \u003F0\u003F.\u003F1\u003F("Kųɧͯ");
      fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
    }

    private void rButton7_Click(object sender, EventArgs e) => new Options().Show();

    private void rButton8_Click(object sender, EventArgs e)
    {
    }

    private void rButton8_Click_1(object sender, EventArgs e)
    {
    }

    private void rButton9_Click(object sender, EventArgs e) => new ScriptManager().Show();

    private void rButton10_Click(object sender, EventArgs e) => new SimpleUI().Show();

    private void rButton11_Click(object sender, EventArgs e)
    {
      string text = \u003F0\u003F.\u003F1\u003F("Zūɵͯѵհ١ݭ\u0879") + (this.TabControl1.TabCount + 1).ToString();
      UserControl1 userControl1 = new UserControl1();
      userControl1.Dock = DockStyle.Fill;
      TabPage tabPage = new TabPage(text);
      tabPage.Controls.Add((Control) userControl1);
      this.TabControl1.TabPages.Add(tabPage);
    }

    private void rButton11_Click_1(object sender, EventArgs e)
    {
      this.listBox1.Items.Clear();
      Functions.PopulateListBox(this.listBox1, \u003F0\u003F.\u003F1\u003F("'ħɔͥѷխٳݶ\u0872"), \u003F0\u003F.\u003F1\u003F("/Īɷͺѵ"));
      Functions.PopulateListBox(this.listBox1, \u003F0\u003F.\u003F1\u003F("'ħɔͥѷխٳݶ\u0872"), \u003F0\u003F.\u003F1\u003F("/ĪɯͷѠ"));
    }

    private void rButton8_Click_2(object sender, EventArgs e) => new ScriptHub().Show();

    private void rButton8_Enter(object sender, EventArgs e)
    {
    }

    private void rButton8_DragOver(object sender, DragEventArgs e) => this.panel14.BackColor = Color.DimGray;

    private void rButton8_MouseHover(object sender, EventArgs e)
    {
    }

    private void panel11_Paint(object sender, PaintEventArgs e)
    {
    }

    private void transparentTextBoxToolStripMenuItem1_Click(object sender, EventArgs e) => (((IEnumerable<Control>) this.TabControl1.SelectedTab.Controls.Find(\u003F0\u003F.\u003F1\u003F("uųɢͤьա١ݣ\u0879९੭ଡ଼ౢൾ\u0E71ཆၬᅺሰ"), true)).FirstOrDefault<Control>() as FastColoredTextBox).BackColor = Color.Transparent;

    private void themesbutton_SelectedColorChanged(object sender, ColorEventArgs e) => Form.ActiveForm.BackColor = this.themesbutton.SelectedColor;

    private void themesbutton_StyleChanged(object sender, EventArgs e)
    {
    }

    private void themesbutton_BackColorChanged(object sender, EventArgs e)
    {
    }

    private void themesbutton_PaletteChanged(object sender, EventArgs e)
    {
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
    }

    private void themesbutton_MouseClick(object sender, MouseEventArgs e)
    {
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
      Form.ActiveForm.BackColor = Color.FromArgb(45, 45, 45);
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.themesbutton.SelectedColor = Color.FromArgb(45, 45, 45);
      this.pictureBox1.Image = (Image) null;
    }

    private void button4_Click_2(object sender, EventArgs e) => this.contextMenuStrip1.Show((Control) this.button4, 0, this.button4.Height);

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (VegaX));
      this.panel1 = new Panel();
      this.EasyExploitRadioButton = new RadioButton();
      this.WrdRadioButton = new RadioButton();
      this.label2 = new Label();
      this.button11 = new Button();
      this.button2 = new Button();
      this.button1 = new Button();
      this.label1 = new Label();
      this.panel2 = new Panel();
      this.checkBox1 = new CheckBox();
      this.listBox1 = new ListBox();
      this.TabControl1 = new TabControl();
      this.RTab = new Button();
      this.button12 = new Button();
      this.contextMenuStrip1 = new ContextMenuStrip(this.components);
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.topBarPanelColorsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.lightBlueToolStripMenuItem = new ToolStripMenuItem();
      this.deepRedToolStripMenuItem = new ToolStripMenuItem();
      this.lightGreenToolStripMenuItem = new ToolStripMenuItem();
      this.dimRedToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripMenuItem1 = new ToolStripMenuItem();
      this.brightPurpleToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator17 = new ToolStripSeparator();
      this.toolStripSeparator14 = new ToolStripSeparator();
      this.tRANSPARENTTEXTBOXToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.onToolStripMenuItem = new ToolStripMenuItem();
      this.offToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.trackBar1 = new TrackBar();
      this.trackBar2 = new TrackBar();
      this.timer1 = new Timer(this.components);
      this.button13 = new Button();
      this.panel3 = new Panel();
      this.panel4 = new Panel();
      this.panel5 = new Panel();
      this.panel6 = new Panel();
      this.panel7 = new Panel();
      this.panel8 = new Panel();
      this.pictureBox1 = new PictureBox();
      this.panel10 = new Panel();
      this.panel11 = new Panel();
      this.panel12 = new Panel();
      this.panel13 = new Panel();
      this.panel14 = new Panel();
      this.ATab = new Button();
      this.rButton10 = new RButton();
      this.rButton9 = new RButton();
      this.rButton8 = new RButton();
      this.rButton7 = new RButton();
      this.rButton6 = new RButton();
      this.rButton5 = new RButton();
      this.rButton4 = new RButton();
      this.rButton3 = new RButton();
      this.rButton2 = new RButton();
      this.rButton1 = new RButton();
      this.themesbutton = new KryptonColorButton();
      this.button3 = new Button();
      this.button4 = new Button();
      this.panel1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.trackBar1.BeginInit();
      this.trackBar2.BeginInit();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.panel1.Controls.Add((Control) this.EasyExploitRadioButton);
      this.panel1.Controls.Add((Control) this.WrdRadioButton);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.button11);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.button1);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮ\u0530");
      this.panel1.Size = new Size(815, 43);
      this.panel1.TabIndex = 0;
      this.panel1.Click += new EventHandler(this.panel1_Click);
      this.panel1.Paint += new PaintEventHandler(this.panel1_Paint);
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.EasyExploitRadioButton.AutoSize = true;
      this.EasyExploitRadioButton.Location = new Point(138, 13);
      this.EasyExploitRadioButton.Name = \u003F0\u003F.\u003F1\u003F("SŴɧͪїթ٠ݣ\u0861।\u0A78\u0B59౫൭\u0E61ཨ၄ᅰተ\u1377ᑭᕯ");
      this.EasyExploitRadioButton.Size = new Size(59, 17);
      this.EasyExploitRadioButton.TabIndex = 325;
      this.EasyExploitRadioButton.Text = \u003F0\u003F.\u003F1\u003F("CŝȤ͂ђՈ");
      this.EasyExploitRadioButton.UseVisualStyleBackColor = true;
      this.EasyExploitRadioButton.CheckedChanged += new EventHandler(this.EasyExploitRadioButton_CheckedChanged);
      this.WrdRadioButton.AutoSize = true;
      this.WrdRadioButton.Location = new Point(62, 13);
      this.WrdRadioButton.Name = \u003F0\u003F.\u003F1\u003F("Yſɨ͙ѫխ١ݨࡄ॰ੰ\u0B77౭൯");
      this.WrdRadioButton.Size = new Size(72, 17);
      this.WrdRadioButton.TabIndex = 324;
      this.WrdRadioButton.Text = \u003F0\u003F.\u003F1\u003F("PŔɁ̤тՒو");
      this.WrdRadioButton.UseVisualStyleBackColor = true;
      this.WrdRadioButton.CheckedChanged += new EventHandler(this.WrdRadioButton_CheckedChanged);
      this.label2.AutoSize = true;
      this.label2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Ivory;
      this.label2.Location = new Point(56, 8);
      this.label2.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԳ");
      this.label2.Size = new Size(0, 25);
      this.label2.TabIndex = 21;
      this.label2.Visible = false;
      this.button11.BackColor = Color.FromArgb(65, 65, 65);
      this.button11.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button11.FlatStyle = FlatStyle.Flat;
      this.button11.ForeColor = SystemColors.Control;
      this.button11.Location = new Point(636, 6);
      this.button11.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܰ");
      this.button11.Size = new Size(89, 30);
      this.button11.TabIndex = 41;
      this.button11.Text = \u003F0\u003F.\u003F1\u003F("]ūɫ;Ѯչ١ܨࡔ॥\u0A77୭\u0C73\u0D76\u0E72");
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click_1);
      this.button2.BackColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ControlLightLight;
      this.button2.Location = new Point(732, 4);
      this.button2.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլس");
      this.button2.Size = new Size(30, 36);
      this.button2.TabIndex = 4;
      this.button2.Text = \u003F0\u003F.\u003F1\u003F("―");
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button1.BackColor = Color.FromArgb(60, 60, 60);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button1.ForeColor = SystemColors.ControlLightLight;
      this.button1.Location = new Point(768, 3);
      this.button1.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլذ");
      this.button1.Size = new Size(42, 37);
      this.button1.TabIndex = 3;
      this.button1.Text = \u003F0\u003F.\u003F1\u003F("Y");
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Window;
      this.label1.Location = new Point(331, 10);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(125, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("FŪɩͬЬՓتܤࠨॱ\u0A34ଫశഭาའ");
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new MouseEventHandler(this.label1_MouseMove);
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(2, 2);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(48, 39);
      this.panel2.TabIndex = 1;
      this.panel2.Click += new EventHandler(this.panel2_Click);
      this.panel2.Paint += new PaintEventHandler(this.panel2_Paint);
      this.checkBox1.AutoSize = true;
      this.checkBox1.ForeColor = SystemColors.Control;
      this.checkBox1.Location = new Point(702, 315);
      this.checkBox1.Name = \u003F0\u003F.\u003F1\u003F("jŠɢͥѮՆ٬ݺ࠰");
      this.checkBox1.Size = new Size(83, 17);
      this.checkBox1.TabIndex = 22;
      this.checkBox1.Text = \u003F0\u003F.\u003F1\u003F("_ŸɨͦѴն٤ݶ\u0866६ੵ");
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged_1);
      this.listBox1.BackColor = Color.FromArgb(57, 57, 57);
      this.listBox1.BorderStyle = BorderStyle.None;
      this.listBox1.ForeColor = SystemColors.Window;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new Point(686, 73);
      this.listBox1.Name = \u003F0\u003F.\u003F1\u003F("dŮɵͱцլٺܰ");
      this.listBox1.Size = new Size(116, 182);
      this.listBox1.TabIndex = 9;
      this.listBox1.Click += new EventHandler(this.listBox1_Click);
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.TabControl1.Location = new Point(73, 46);
      this.TabControl1.Name = \u003F0\u003F.\u003F1\u003F("_ūɫ͋Ѩըٱݶ\u086C८ਰ");
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(607, 268);
      this.TabControl1.TabIndex = 24;
      this.TabControl1.SelectedIndexChanged += new EventHandler(this.TabControl1_SelectedIndexChanged);
      this.TabControl1.Click += new EventHandler(this.TabControl1_Click);
      this.RTab.BackColor = Color.FromArgb(65, 65, 65);
      this.RTab.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.RTab.FlatStyle = FlatStyle.Flat;
      this.RTab.ForeColor = SystemColors.Control;
      this.RTab.Location = new Point(748, 47);
      this.RTab.Name = \u003F0\u003F.\u003F1\u003F("Vŗɣͣ");
      this.RTab.Size = new Size(54, 22);
      this.RTab.TabIndex = 26;
      this.RTab.Text = \u003F0\u003F.\u003F1\u003F("(Ĥɗͣѣ");
      this.RTab.UseVisualStyleBackColor = false;
      this.RTab.Click += new EventHandler(this.RTab_Click);
      this.button12.BackColor = Color.FromArgb(45, 45, 45);
      this.button12.Location = new Point(792, 100);
      this.button12.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܳ");
      this.button12.Size = new Size(10, 10);
      this.button12.TabIndex = 27;
      this.button12.Text = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܳ");
      this.button12.UseVisualStyleBackColor = false;
      this.contextMenuStrip1.BackColor = Color.FromArgb(70, 70, 70);
      this.contextMenuStrip1.Font = new Font(\u003F0\u003F.\u003F1\u003F("[Ţɡͪѡԣ݈ٗ"), 9f);
      this.contextMenuStrip1.Items.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.toolStripSeparator11,
        (ToolStripItem) this.topBarPanelColorsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator14,
        (ToolStripItem) this.tRANSPARENTTEXTBOXToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator10
      });
      this.contextMenuStrip1.Name = \u003F0\u003F.\u003F1\u003F("rſɡͺѨմٿ݇\u086C०ੲ\u0B55\u0C71\u0D76\u0E6Aིူ");
      this.contextMenuStrip1.Size = new Size(188, 66);
      this.contextMenuStrip1.MouseLeave += new EventHandler(this.contextMenuStrip1_MouseLeave);
      this.toolStripSeparator11.Name = \u003F0\u003F.\u003F1\u003F("`żɽͽуջټݤ\u087Cक़੯\u0B79౩\u0D75\u0E67ཱၫᅱሳጰ");
      this.toolStripSeparator11.Size = new Size(184, 6);
      this.topBarPanelColorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.lightBlueToolStripMenuItem,
        (ToolStripItem) this.deepRedToolStripMenuItem,
        (ToolStripItem) this.lightGreenToolStripMenuItem,
        (ToolStripItem) this.dimRedToolStripMenuItem,
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.brightPurpleToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator17
      });
      this.topBarPanelColorsToolStripMenuItem.ForeColor = SystemColors.Control;
      this.topBarPanelColorsToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("VŎɐ͝ѿկٌݺ\u0874ॼੴ\u0B54\u0C79൹\u0E7Bཡၡᅅቿ፠ᑢᕞᙸ\u1779ᡣ\u1979ᩅ᭢ᱨᵰṍί\u2067Ⅼ");
      this.topBarPanelColorsToolStripMenuItem.Size = new Size(187, 22);
      this.topBarPanelColorsToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("AŻɣ͐Ѱբدܡ࠭ड़੪\u0B64౬\u0D64วཅၪᅨቬ\u1370ᑲ");
      this.toolStripSeparator2.Name = \u003F0\u003F.\u003F1\u003F("gŽɾͼќպٿݥ\u087Bख़੬\u0B78౦\u0D74\u0E64\u0F70ၬᅰሳ");
      this.toolStripSeparator2.Size = new Size(145, 6);
      this.lightBlueToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("vŰɿͿѢ\u0557ٸݦ\u0877ॅ\u0A7Fୠౢ\u0D5E\u0E78ཹၣᅹቅ።ᑨᕰᙍ\u1777ᡧᥬ");
      this.lightBlueToolStripMenuItem.Size = new Size(148, 22);
      this.lightBlueToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("FŠɯͯѲԥنݯ\u0877।");
      this.lightBlueToolStripMenuItem.Click += new EventHandler(this.lightBlueToolStripMenuItem_Click_1);
      this.deepRedToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("|Ųɳͥцնٶ݅\u087Fॠ\u0A62\u0B5E\u0C78൹\u0E63ཹ၅ᅢቨ\u1370ᑍᕷᙧᝬ");
      this.deepRedToolStripMenuItem.Size = new Size(148, 22);
      this.deepRedToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("Ožɢͭѡռا݉\u0877॥੭\u0B65\u0C64");
      this.deepRedToolStripMenuItem.Click += new EventHandler(this.deepRedToolStripMenuItem_Click);
      this.lightGreenToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("wųɾͰѣՑ٧ݱ\u0876ॼ\u0A45\u0B7Fౠൢ\u0E5Eླྀၹᅣቹፅᑢᕨᙰᝍᡷᥧᩬ");
      this.lightGreenToolStripMenuItem.Size = new Size(148, 22);
      this.lightGreenToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("Gţɮ͠ѳԦقݶ\u0866१੯");
      this.lightGreenToolStripMenuItem.Click += new EventHandler(this.lightGreenToolStripMenuItem_Click);
      this.dimRedToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("sſɸ͆Ѷնمݿ\u0860ॢਫ਼\u0B78\u0C79ൣ\u0E79ཅၢᅨተፍᑷᕧᙬ");
      this.dimRedToolStripMenuItem.Size = new Size(148, 22);
      this.dimRedToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("Cůɨ̤ёէ٥");
      this.dimRedToolStripMenuItem.Click += new EventHandler(this.dimRedToolStripMenuItem_Click);
      this.toolStripMenuItem1.Name = \u003F0\u003F.\u003F1\u003F("fžɿͣѝչپݢ\u087Aॄ੭୩\u0C73ൌ\u0E70སၯᄰ");
      this.toolStripMenuItem1.Size = new Size(148, 22);
      this.toolStripMenuItem1.Text = \u003F0\u003F.\u003F1\u003F("GŨɢ͡Ѫ");
      this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
      this.brightPurpleToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("\u007FŮɲͽѱլهݣ\u0867।\u0A7F\u0B77\u0C45ൿ\u0E60རၞᅸቹ፣ᑹᕅᙢᝨᡰ᥍᩷᭧ᱬ");
      this.brightPurpleToolStripMenuItem.Size = new Size(148, 22);
      this.brightPurpleToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("Ožɢͭѡռاݖ\u0870ॶੳ୮\u0C64");
      this.brightPurpleToolStripMenuItem.Click += new EventHandler(this.brightPurpleToolStripMenuItem_Click);
      this.toolStripSeparator17.Name = \u003F0\u003F.\u003F1\u003F("`żɽͽуջټݤ\u087Cक़੯\u0B79౩\u0D75\u0E67ཱၫᅱሳጶ");
      this.toolStripSeparator17.Size = new Size(145, 6);
      this.toolStripSeparator14.Name = \u003F0\u003F.\u003F1\u003F("`żɽͽуջټݤ\u087Cक़੯\u0B79౩\u0D75\u0E67ཱၫᅱሳጵ");
      this.toolStripSeparator14.Size = new Size(184, 6);
      this.tRANSPARENTTEXTBOXToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.onToolStripMenuItem,
        (ToolStripItem) this.offToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator6
      });
      this.tRANSPARENTTEXTBOXToolStripMenuItem.ForeColor = SystemColors.Control;
      this.tRANSPARENTTEXTBOXToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("WŰɠͮьՎٜݎ࡞੍॔ୌ\u0C52ൎแབၜᅊቅ\u137Fᑠᕢᙞ\u1778\u1879ᥣ᩹ᭅᱢᵨṰὍ\u2077Ⅷ≬");
      this.tRANSPARENTTEXTBOXToolStripMenuItem.Size = new Size(187, 22);
      this.tRANSPARENTTEXTBOXToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("]ŋɀ̓ѝՏةݜࡂफ़ੑତు്๙");
      this.tRANSPARENTTEXTBOXToolStripMenuItem.Click += new EventHandler(this.tRANSPARENTTEXTBOXToolStripMenuItem_Click);
      this.toolStripSeparator5.Name = \u003F0\u003F.\u003F1\u003F("gŽɾͼќպٿݥ\u087Bख़੬\u0B78౦\u0D74\u0E64\u0F70ၬᅰሴ");
      this.toolStripSeparator5.Size = new Size(88, 6);
      this.onToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("|żɅͿѠբٞݸ\u0879ॣ\u0A79\u0B45ౢ൨\u0E70ཌྷၷᅧቬ");
      this.onToolStripMenuItem.Size = new Size(91, 22);
      this.onToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("Mů");
      this.onToolStripMenuItem.Click += new EventHandler(this.onToolStripMenuItem_Click);
      this.offToolStripMenuItem.Name = \u003F0\u003F.\u003F1\u003F("{ŵɴͅѿ\u0560٢ݞ\u0878ॹ\u0A63\u0B79\u0C45ൢ\u0E68\u0F70၍ᅷቧ\u136C");
      this.offToolStripMenuItem.Size = new Size(91, 22);
      this.offToolStripMenuItem.Text = \u003F0\u003F.\u003F1\u003F("LŤɧ");
      this.offToolStripMenuItem.Click += new EventHandler(this.offToolStripMenuItem_Click);
      this.toolStripSeparator6.Name = \u003F0\u003F.\u003F1\u003F("gŽɾͼќպٿݥ\u087Bख़੬\u0B78౦\u0D74\u0E64\u0F70ၬᅰሷ");
      this.toolStripSeparator6.Size = new Size(88, 6);
      this.toolStripSeparator10.Name = \u003F0\u003F.\u003F1\u003F("`żɽͽуջټݤ\u087Cक़੯\u0B79౩\u0D75\u0E67ཱၫᅱሳጱ");
      this.toolStripSeparator10.Size = new Size(184, 6);
      this.trackBar1.Location = new Point(792, 276);
      this.trackBar1.Name = \u003F0\u003F.\u003F1\u003F("}źɦͥѮՆ٢ݰ࠰");
      this.trackBar1.Size = new Size(10, 45);
      this.trackBar1.TabIndex = 1;
      this.trackBar1.Value = 7;
      this.trackBar2.Location = new Point(776, 276);
      this.trackBar2.Name = \u003F0\u003F.\u003F1\u003F("}źɦͥѮՆ٢ݰ࠳");
      this.trackBar2.Size = new Size(10, 45);
      this.trackBar2.TabIndex = 30;
      this.trackBar2.Value = 10;
      this.timer1.Tick += new EventHandler(this.timer1_Tick_1);
      this.button13.BackColor = Color.FromArgb(60, 60, 60);
      this.button13.Location = new Point(776, 191);
      this.button13.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܲ");
      this.button13.Size = new Size(10, 10);
      this.button13.TabIndex = 31;
      this.button13.Text = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܲ");
      this.button13.UseVisualStyleBackColor = false;
      this.panel3.BackColor = Color.FromArgb(65, 65, 65);
      this.panel3.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԢؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel3.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel3.Location = new Point(142, 329);
      this.panel3.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԲ");
      this.panel3.Size = new Size(36, 34);
      this.panel3.TabIndex = 2;
      this.panel3.Click += new EventHandler(this.panel3_Click);
      this.panel3.Paint += new PaintEventHandler(this.panel3_Paint);
      this.panel4.BackColor = Color.FromArgb(65, 65, 65);
      this.panel4.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԥؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel4.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel4.ForeColor = SystemColors.ControlText;
      this.panel4.Location = new Point(238, 328);
      this.panel4.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԵ");
      this.panel4.Size = new Size(36, 34);
      this.panel4.TabIndex = 3;
      this.panel4.Click += new EventHandler(this.panel4_Click);
      this.panel4.Paint += new PaintEventHandler(this.panel4_Paint);
      this.panel5.BackColor = Color.FromArgb(65, 65, 65);
      this.panel5.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԤؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel5.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel5.ForeColor = SystemColors.ControlText;
      this.panel5.Location = new Point(18, 124);
      this.panel5.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԴ");
      this.panel5.Size = new Size(37, 36);
      this.panel5.TabIndex = 4;
      this.panel5.Click += new EventHandler(this.panel5_Click);
      this.panel6.BackColor = Color.FromArgb(65, 65, 65);
      this.panel6.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԧؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel6.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel6.ForeColor = SystemColors.ControlText;
      this.panel6.Location = new Point(18, 192);
      this.panel6.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԷ");
      this.panel6.Size = new Size(38, 38);
      this.panel6.TabIndex = 5;
      this.panel6.Click += new EventHandler(this.panel6_Click);
      this.panel7.BackColor = Color.FromArgb(65, 65, 65);
      this.panel7.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԦؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel7.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel7.ForeColor = SystemColors.ControlText;
      this.panel7.Location = new Point(19, 261);
      this.panel7.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԶ");
      this.panel7.Size = new Size(38, 35);
      this.panel7.TabIndex = 6;
      this.panel7.Click += new EventHandler(this.panel7_Click);
      this.panel7.Paint += new PaintEventHandler(this.panel7_Paint);
      this.panel8.BackColor = Color.FromArgb(65, 65, 65);
      this.panel8.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԩؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel8.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel8.ForeColor = SystemColors.ControlText;
      this.panel8.Location = new Point(17, 57);
      this.panel8.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԹ");
      this.panel8.Size = new Size(39, 37);
      this.panel8.TabIndex = 6;
      this.panel8.Click += new EventHandler(this.panel8_Click);
      this.pictureBox1.BackColor = Color.Transparent;
      this.pictureBox1.Location = new Point(-1, -1);
      this.pictureBox1.Name = \u003F0\u003F.\u003F1\u003F("{ţɪͼѲմ٠݆\u086Cॺਰ");
      this.pictureBox1.Size = new Size(816, 389);
      this.pictureBox1.TabIndex = 29;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.pictureBox1.DragDrop += new DragEventHandler(this.pictureBox1_DragDrop);
      this.pictureBox1.DragEnter += new DragEventHandler(this.pictureBox1_DragEnter);
      this.panel10.BackColor = Color.FromArgb(65, 65, 65);
      this.panel10.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("gŷɻͱѿԣءܾࡍ९੮୧౬\u0D78\u0E66ཽၩᅢቌ\u1369ᑢᕥᙤ"));
      this.panel10.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel10.ForeColor = SystemColors.ControlText;
      this.panel10.Location = new Point(35, 323);
      this.panel10.Name = \u003F0\u003F.\u003F1\u003F("wŧɫ͡ѯԳر");
      this.panel10.Size = new Size(41, 42);
      this.panel10.TabIndex = 8;
      this.panel10.Click += new EventHandler(this.panel10_Click);
      this.panel10.Paint += new PaintEventHandler(this.panel10_Paint);
      this.panel11.BackColor = Color.Transparent;
      this.panel11.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("gŷɻͱѿԣؠܾࡍ९੮୧౬\u0D78\u0E66ཽၩᅢቌ\u1369ᑢᕥᙤ"));
      this.panel11.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel11.Location = new Point(275, 315);
      this.panel11.Name = \u003F0\u003F.\u003F1\u003F("wŧɫ͡ѯԳذ");
      this.panel11.Size = new Size(65, 73);
      this.panel11.TabIndex = 2;
      this.panel11.Paint += new PaintEventHandler(this.panel11_Paint);
      this.panel12.BackColor = Color.FromArgb(65, 65, 65);
      this.panel12.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("gŷɻͱѿԣأܾࡍ९੮୧౬\u0D78\u0E66ཽၩᅢቌ\u1369ᑢᕥᙤ"));
      this.panel12.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel12.ForeColor = SystemColors.ControlText;
      this.panel12.Location = new Point(603, 325);
      this.panel12.Name = \u003F0\u003F.\u003F1\u003F("wŧɫ͡ѯԳس");
      this.panel12.Size = new Size(39, 37);
      this.panel12.TabIndex = 9;
      this.panel12.Click += new EventHandler(this.panel12_Click);
      this.panel12.Paint += new PaintEventHandler(this.panel12_Paint);
      this.panel13.BackColor = Color.FromArgb(65, 65, 65);
      this.panel13.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("gŷɻͱѿԣآܾࡍ९੮୧౬\u0D78\u0E66ཽၩᅢቌ\u1369ᑢᕥᙤ"));
      this.panel13.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel13.ForeColor = SystemColors.ControlText;
      this.panel13.Location = new Point(480, 324);
      this.panel13.Name = \u003F0\u003F.\u003F1\u003F("wŧɫ͡ѯԳز");
      this.panel13.Size = new Size(41, 39);
      this.panel13.TabIndex = 10;
      this.panel13.Click += new EventHandler(this.panel13_Click);
      this.panel14.BackColor = Color.FromArgb(65, 65, 65);
      this.panel14.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("gŷɻͱѿԣإܾࡍ९੮୧౬\u0D78\u0E66ཽၩᅢቌ\u1369ᑢᕥᙤ"));
      this.panel14.BackgroundImageLayout = ImageLayout.Stretch;
      this.panel14.ForeColor = SystemColors.ControlText;
      this.panel14.Location = new Point(354, 323);
      this.panel14.Name = \u003F0\u003F.\u003F1\u003F("wŧɫ͡ѯԳص");
      this.panel14.Size = new Size(47, 43);
      this.panel14.TabIndex = 11;
      this.panel14.Click += new EventHandler(this.panel14_Click);
      this.panel14.Paint += new PaintEventHandler(this.panel14_Paint);
      this.ATab.BackColor = Color.FromArgb(65, 65, 65);
      this.ATab.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.ATab.FlatStyle = FlatStyle.Flat;
      this.ATab.ForeColor = SystemColors.Control;
      this.ATab.Location = new Point(688, 47);
      this.ATab.Name = \u003F0\u003F.\u003F1\u003F("Eŗɣͣ");
      this.ATab.Size = new Size(57, 22);
      this.ATab.TabIndex = 25;
      this.ATab.Text = \u003F0\u003F.\u003F1\u003F(".Ĥɗͣѣ");
      this.ATab.UseVisualStyleBackColor = false;
      this.ATab.Click += new EventHandler(this.button12_Click);
      this.rButton10.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton10.FlatAppearance.BorderSize = 0;
      this.rButton10.FlatStyle = FlatStyle.Flat;
      this.rButton10.ForeColor = Color.White;
      this.rButton10.Location = new Point(564, 320);
      this.rButton10.Name = \u003F0\u003F.\u003F1\u003F("{ŊɲͲѱի٭ܳ࠱");
      this.rButton10.Size = new Size(116, 62);
      this.rButton10.TabIndex = 50;
      this.rButton10.Text = \u003F0\u003F.\u003F1\u003F("ZšɪͶѩաأݗࡈ");
      this.rButton10.TextAlign = ContentAlignment.BottomCenter;
      this.rButton10.UseVisualStyleBackColor = false;
      this.rButton10.Click += new EventHandler(this.rButton10_Click);
      this.rButton9.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton9.FlatAppearance.BorderSize = 0;
      this.rButton9.FlatStyle = FlatStyle.Flat;
      this.rButton9.ForeColor = Color.White;
      this.rButton9.Location = new Point(442, 320);
      this.rButton9.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܸ");
      this.rButton9.Size = new Size(116, 62);
      this.rButton9.TabIndex = 49;
      this.rButton9.Text = \u003F0\u003F.\u003F1\u003F("]Ůɾ͢Ѻսب݊\u0867५\u0A65\u0B64౧\u0D73");
      this.rButton9.TextAlign = ContentAlignment.BottomCenter;
      this.rButton9.UseVisualStyleBackColor = false;
      this.rButton9.Click += new EventHandler(this.rButton9_Click);
      this.rButton8.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton8.FlatAppearance.BorderSize = 0;
      this.rButton8.FlatStyle = FlatStyle.Flat;
      this.rButton8.ForeColor = Color.White;
      this.rButton8.Location = new Point(319, 320);
      this.rButton8.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܹ");
      this.rButton8.Size = new Size(117, 62);
      this.rButton8.TabIndex = 48;
      this.rButton8.Text = \u003F0\u003F.\u003F1\u003F("YŪɺͮѶձؤ\u074B\u0877ॣ");
      this.rButton8.TextAlign = ContentAlignment.BottomCenter;
      this.rButton8.UseVisualStyleBackColor = false;
      this.rButton8.Click += new EventHandler(this.rButton8_Click_2);
      this.rButton8.DragOver += new DragEventHandler(this.rButton8_DragOver);
      this.rButton8.Enter += new EventHandler(this.rButton8_Enter);
      this.rButton8.MouseHover += new EventHandler(this.rButton8_MouseHover);
      this.rButton7.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton7.FlatAppearance.BorderSize = 0;
      this.rButton7.FlatStyle = FlatStyle.Flat;
      this.rButton7.ForeColor = Color.White;
      this.rButton7.Location = new Point(6, 50);
      this.rButton7.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܶ");
      this.rButton7.Size = new Size(61, 62);
      this.rButton7.TabIndex = 46;
      this.rButton7.Text = \u003F0\u003F.\u003F1\u003F("HŶɱͭѬլٲ");
      this.rButton7.TextAlign = ContentAlignment.BottomCenter;
      this.rButton7.UseVisualStyleBackColor = false;
      this.rButton7.Click += new EventHandler(this.rButton7_Click);
      this.rButton6.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton6.FlatAppearance.BorderSize = 0;
      this.rButton6.FlatStyle = FlatStyle.Flat;
      this.rButton6.ForeColor = Color.White;
      this.rButton6.Location = new Point(6, 118);
      this.rButton6.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܷ");
      this.rButton6.Size = new Size(61, 62);
      this.rButton6.TabIndex = 45;
      this.rButton6.Text = \u003F0\u003F.\u003F1\u003F("FŸɢͨХՂ٪ݮ\u0864");
      this.rButton6.TextAlign = ContentAlignment.BottomCenter;
      this.rButton6.UseVisualStyleBackColor = false;
      this.rButton6.Click += new EventHandler(this.rButton6_Click);
      this.rButton5.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton5.FlatAppearance.BorderSize = 0;
      this.rButton5.FlatStyle = FlatStyle.Flat;
      this.rButton5.ForeColor = Color.White;
      this.rButton5.Location = new Point(6, 186);
      this.rButton5.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܴ");
      this.rButton5.Size = new Size(61, 62);
      this.rButton5.TabIndex = 44;
      this.rButton5.Text = \u003F0\u003F.\u003F1\u003F("ZũɱͣХՂ٪ݮ\u0864");
      this.rButton5.TextAlign = ContentAlignment.BottomCenter;
      this.rButton5.UseVisualStyleBackColor = false;
      this.rButton5.Click += new EventHandler(this.rButton5_Click);
      this.rButton4.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton4.FlatAppearance.BorderSize = 0;
      this.rButton4.FlatStyle = FlatStyle.Flat;
      this.rButton4.ForeColor = Color.White;
      this.rButton4.Location = new Point(6, 254);
      this.rButton4.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܵ");
      this.rButton4.Size = new Size(63, 62);
      this.rButton4.TabIndex = 43;
      this.rButton4.Text = \u003F0\u003F.\u003F1\u003F("LŰɢͥХՂ٪ݮ\u0864");
      this.rButton4.TextAlign = ContentAlignment.BottomCenter;
      this.rButton4.UseVisualStyleBackColor = false;
      this.rButton4.Click += new EventHandler(this.rButton4_Click);
      this.rButton3.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton3.FlatAppearance.BorderSize = 0;
      this.rButton3.FlatStyle = FlatStyle.Flat;
      this.rButton3.ForeColor = Color.White;
      this.rButton3.Location = new Point(216, 321);
      this.rButton3.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܲ");
      this.rButton3.Size = new Size(78, 62);
      this.rButton3.TabIndex = 42;
      this.rButton3.Text = \u003F0\u003F.\u003F1\u003F("IťɭͦѴԥِݦ\u087Aॵ");
      this.rButton3.TextAlign = ContentAlignment.BottomCenter;
      this.rButton3.UseVisualStyleBackColor = false;
      this.rButton3.Click += new EventHandler(this.rButton3_Click);
      this.rButton2.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton2.FlatAppearance.BorderSize = 0;
      this.rButton2.FlatStyle = FlatStyle.Flat;
      this.rButton2.ForeColor = Color.White;
      this.rButton2.Location = new Point(110, 321);
      this.rButton2.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܳ");
      this.rButton2.Size = new Size(100, 62);
      this.rButton2.TabIndex = 41;
      this.rButton2.Text = \u003F0\u003F.\u003F1\u003F("Kŵɩͨѿս٭ܧࡕ०\u0A76୪\u0C72\u0D75");
      this.rButton2.TextAlign = ContentAlignment.BottomCenter;
      this.rButton2.UseVisualStyleBackColor = false;
      this.rButton2.Click += new EventHandler(this.rButton2_Click);
      this.rButton1.BackColor = Color.FromArgb(65, 65, 65);
      this.rButton1.FlatAppearance.BorderSize = 0;
      this.rButton1.FlatStyle = FlatStyle.Flat;
      this.rButton1.ForeColor = Color.White;
      this.rButton1.Location = new Point(7, 319);
      this.rButton1.Name = \u003F0\u003F.\u003F1\u003F("zŅɳͱѰլ٬ܰ");
      this.rButton1.Size = new Size(98, 62);
      this.rButton1.TabIndex = 0;
      this.rButton1.Text = \u003F0\u003F.\u003F1\u003F("Gűɰ͢ѡթ");
      this.rButton1.TextAlign = ContentAlignment.BottomCenter;
      this.rButton1.UseVisualStyleBackColor = false;
      this.rButton1.Click += new EventHandler(this.rButton1_Click);
      this.themesbutton.EmptyBorderColor = Color.Transparent;
      this.themesbutton.Location = new Point(688, 337);
      this.themesbutton.Name = \u003F0\u003F.\u003F1\u003F("xţɯͤѭմ٤ݰ\u0870ॷ੭୯");
      this.themesbutton.SelectedColor = Color.White;
      this.themesbutton.Size = new Size(116, 45);
      this.themesbutton.StateCommon.Back.Color1 = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateCommon.Back.Color2 = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateCommon.Border.Color1 = Color.Transparent;
      this.themesbutton.StateCommon.Border.Color2 = Color.Transparent;
      this.themesbutton.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
      this.themesbutton.StateCommon.Border.Rounding = 13;
      this.themesbutton.StateCommon.Content.ShortText.Color1 = Color.White;
      this.themesbutton.StateCommon.Content.ShortText.Color2 = Color.White;
      this.themesbutton.StateNormal.Content.Image.ImageColorMap = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateNormal.Content.Image.ImageColorTo = Color.FromArgb(65, 65, 65);
      this.themesbutton.StatePressed.Back.Color1 = Color.FromArgb(65, 65, 65);
      this.themesbutton.StatePressed.Back.Color2 = Color.FromArgb(65, 65, 65);
      this.themesbutton.StatePressed.Content.Image.ImageColorMap = Color.FromArgb(65, 65, 65);
      this.themesbutton.StatePressed.Content.Image.ImageColorTo = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateTracking.Back.Color1 = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateTracking.Back.Color2 = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateTracking.Content.Image.ImageColorMap = Color.FromArgb(65, 65, 65);
      this.themesbutton.StateTracking.Content.Image.ImageColorTo = Color.FromArgb(65, 65, 65);
      this.themesbutton.TabIndex = 51;
      this.themesbutton.Values.Text = \u003F0\u003F.\u003F1\u003F("]ŎȦ͑Ѭզٯݤ");
      this.themesbutton.SelectedColorChanged += new EventHandler<ColorEventArgs>(this.themesbutton_SelectedColorChanged);
      this.themesbutton.PaletteChanged += new EventHandler(this.themesbutton_PaletteChanged);
      this.themesbutton.BackColorChanged += new EventHandler(this.themesbutton_BackColorChanged);
      this.themesbutton.MouseClick += new MouseEventHandler(this.themesbutton_MouseClick);
      this.themesbutton.StyleChanged += new EventHandler(this.themesbutton_StyleChanged);
      this.button3.BackColor = Color.FromArgb(65, 65, 65);
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = SystemColors.Control;
      this.button3.Location = new Point(686, 287);
      this.button3.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլز");
      this.button3.Size = new Size(116, 22);
      this.button3.TabIndex = 52;
      this.button3.Text = \u003F0\u003F.\u003F1\u003F("IũɭͫѼդٳܦࡑ६੦୯\u0C64");
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click_1);
      this.button4.BackColor = Color.FromArgb(65, 65, 65);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = SystemColors.Control;
      this.button4.Location = new Point(686, 261);
      this.button4.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլص");
      this.button4.Size = new Size(116, 23);
      this.button4.TabIndex = 53;
      this.button4.Text = \u003F0\u003F.\u003F1\u003F("Yţɻ̪ыթٵܦࡑ६੦୯\u0C64");
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click_2);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(45, 45, 45);
      this.ClientSize = new Size(816, 389);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.themesbutton);
      this.Controls.Add((Control) this.panel12);
      this.Controls.Add((Control) this.rButton10);
      this.Controls.Add((Control) this.panel13);
      this.Controls.Add((Control) this.rButton9);
      this.Controls.Add((Control) this.panel14);
      this.Controls.Add((Control) this.rButton8);
      this.Controls.Add((Control) this.panel8);
      this.Controls.Add((Control) this.rButton7);
      this.Controls.Add((Control) this.panel5);
      this.Controls.Add((Control) this.rButton6);
      this.Controls.Add((Control) this.panel6);
      this.Controls.Add((Control) this.rButton5);
      this.Controls.Add((Control) this.panel7);
      this.Controls.Add((Control) this.rButton4);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.rButton3);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.rButton2);
      this.Controls.Add((Control) this.panel10);
      this.Controls.Add((Control) this.rButton1);
      this.Controls.Add((Control) this.panel11);
      this.Controls.Add((Control) this.RTab);
      this.Controls.Add((Control) this.checkBox1);
      this.Controls.Add((Control) this.ATab);
      this.Controls.Add((Control) this.TabControl1);
      this.Controls.Add((Control) this.listBox1);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.button12);
      this.Controls.Add((Control) this.pictureBox1);
      this.Controls.Add((Control) this.trackBar1);
      this.Controls.Add((Control) this.trackBar2);
      this.Controls.Add((Control) this.button13);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F(".Žɠͮѵԫٍݠ\u086D९"));
      this.Name = \u003F0\u003F.\u003F1\u003F("Sšɤͣљ");
      this.Opacity = 0.0;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
      this.StateCommon.Border.Rounding = 10;
      this.Text = \u003F0\u003F.\u003F1\u003F("PŠɣ͢Тՙ");
      this.FormClosing += new FormClosingEventHandler(this.VegaX_FormClosing);
      this.Load += new EventHandler(this.VegaX_Load);
      this.Click += new EventHandler(this.VegaX_Click);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.trackBar1.EndInit();
      this.trackBar2.EndInit();
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
