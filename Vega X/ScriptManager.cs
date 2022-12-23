// Decompiled with JetBrains decompiler
// Type: Vega_X.ScriptManager
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using EasyExploits;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
  public class ScriptManager : Form
  {
    private Module module = new Module();
    private ExploitAPI api = new ExploitAPI();
    private DataTable table;
    private Point lastPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label2;
    private Label label1;
    private Panel panel2;
    private Button button107;
    private Button button2;
    private DataGridView dataGridView1;
    private RichTextBox richTextBox2;
    private Button button8;
    private Button button1;
    private Button button3;
    private Button button4;
    private Label label3;
    private Label label4;
    private RichTextBox richTextBox1;
    private Button button5;
    private Button button6;
    private Label label5;
    private Label label6;
    private Button button7;
    private Button button9;

    public ScriptManager() => this.InitializeComponent();

    private void ScriptManager_Load(object sender, EventArgs e)
    {
      this.TopMost = true;
      this.table = new DataTable();
      this.table.Columns.Add(\u003F0\u003F.\u003F1\u003F("QŭɷͮѤ"), typeof (string));
      this.table.Columns.Add(\u003F0\u003F.\u003F1\u003F("Tťɷͭѳնٲ"), typeof (string));
      this.dataGridView1.DataSource = (object) this.table;
      this.dataGridView1.Columns[\u003F0\u003F.\u003F1\u003F("Tťɷͭѳնٲ")].Visible = false;
    }

    private void label6_Click(object sender, EventArgs e)
    {
    }

    private void button8_Click(object sender, EventArgs e)
    {
      this.table.Rows.Add((object) this.richTextBox1.Text, (object) this.richTextBox2.Text);
      this.richTextBox1.Clear();
      this.richTextBox2.Clear();
    }

    private void button7_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("uŏȿͫѮչػݮ\u0871ॽ\u0A37\u0B65\u0C76൦\u0E7Aརၥᄰቢ\u136Fᑣᕭᙬᝯ\u187Bᤤᨧ᭠ᱬᵶṰὶ‡Ⅱ⊛⎚ⓝ▝⛛⟐⢪⦻⪥⮿ⲥⶠ⻓⾦ジㆤ㊣㎫㓇㗌㚊㞄㢍㧈㪆㯆㳏㶷㺠㾰䂨䆰䊋䏴䓳䗼䚏䞲䢼䦶䫷䮦䲧䶱亠価僱出劜厏咛喉囡埤壩妑媨害岷巤庰御悳憩拏揊撝旋曒柖棕榘櫄毗泃淑溓濆烞熐狛珆瓈疌皁矹磪秺竮篶糱綄绯翫胲致芵莰蒽藈蛴螺裫觽諣诤購跱軥迷邱釱銯鏽铮闾離韺飽馤骧鯵鳠鷨黦\u9FE1ꃵꆠꈖꌊꑝꔚꘉ꜕ꠔ\uA958ꨃ\uAB1E감굔깙꼡뀲넢눦댾됹때똧뜣렺뤼멍뭆밄봊븇뽂쀑섒숺쌭쐮야옯윲젼쥸쩽쬙찅촑츝콲퀂턓툝팇퐝픘홡흪\uD82B\uD93D\uDA33\uDB32\uDC2A\uDD2A\uDE6D\uDF62\uE015\uE128\uE25A\uE350\uE41D\uE545\uE654\uE74F\uE819\uE95B\uEA56\uEB58\uEC15\uED51\uEE4B\uEF57\uF052\uF145\uF25B\uF34B\uF40D\uF545\uF65F\uF70A\uF85E論禎פֿﰅﵐ﹋ｇ\u0001Ċɚ͆ј՟َݎ\u085Cस\u0A44\u0B55ే\u0D5Dใཆျᄰቭ\u137Bᑹᕸᙤᝤᠧᤨᩂ᭨ᱯᵫṺἣ‡"));
    }

    private void button4_Click(object sender, EventArgs e) => this.module.ExecuteScript(this.richTextBox2.Text);

    private void button3_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      using (Stream stream = (Stream) File.Open(saveFileDialog.FileName, FileMode.CreateNew))
      {
        using (StreamWriter streamWriter = new StreamWriter(stream))
          streamWriter.Write(this.richTextBox2.Text);
      }
    }

    private void richTextBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.richTextBox1.Clear();
      this.richTextBox2.Clear();
    }

    private void button6_Click(object sender, EventArgs e)
    {
      int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
      if (rowIndex <= -1)
        return;
      this.richTextBox1.Text = this.table.Rows[rowIndex].ItemArray[0].ToString();
      this.richTextBox2.Text = this.table.Rows[rowIndex].ItemArray[1].ToString();
    }

    private void button5_Click(object sender, EventArgs e) => this.table.Rows[this.dataGridView1.CurrentCell.RowIndex].Delete();

    private void button107_Click(object sender, EventArgs e) => this.Close();

    private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void button9_Click(object sender, EventArgs e) => this.module.LaunchExploit();

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ScriptManager));
      this.panel1 = new Panel();
      this.button107 = new Button();
      this.button2 = new Button();
      this.label2 = new Label();
      this.label1 = new Label();
      this.panel2 = new Panel();
      this.dataGridView1 = new DataGridView();
      this.richTextBox2 = new RichTextBox();
      this.button8 = new Button();
      this.button1 = new Button();
      this.button3 = new Button();
      this.button4 = new Button();
      this.label3 = new Label();
      this.label4 = new Label();
      this.richTextBox1 = new RichTextBox();
      this.button5 = new Button();
      this.button6 = new Button();
      this.label5 = new Label();
      this.label6 = new Label();
      this.button7 = new Button();
      this.button9 = new Button();
      this.panel1.SuspendLayout();
      ((ISupportInitialize) this.dataGridView1).BeginInit();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.panel1.Controls.Add((Control) this.button107);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.label2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮ\u0530");
      this.panel1.Size = new Size(779, 44);
      this.panel1.TabIndex = 1;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.button107.BackColor = Color.FromArgb(60, 60, 60);
      this.button107.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button107.FlatStyle = FlatStyle.Flat;
      this.button107.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button107.ForeColor = SystemColors.ControlLightLight;
      this.button107.Location = new Point(744, 8);
      this.button107.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠶");
      this.button107.Size = new Size(30, 27);
      this.button107.TabIndex = 23;
      this.button107.Text = \u003F0\u003F.\u003F1\u003F("Y");
      this.button107.UseVisualStyleBackColor = false;
      this.button107.Click += new EventHandler(this.button107_Click);
      this.button2.BackColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ControlLightLight;
      this.button2.Location = new Point(711, 8);
      this.button2.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլس");
      this.button2.Size = new Size(30, 27);
      this.button2.TabIndex = 22;
      this.button2.Text = \u003F0\u003F.\u003F1\u003F("―");
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = Color.Ivory;
      this.label2.Location = new Point(56, 8);
      this.label2.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԳ");
      this.label2.Size = new Size(0, 25);
      this.label2.TabIndex = 21;
      this.label2.Visible = false;
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Window;
      this.label1.Location = new Point(309, 11);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(186, 21);
      this.label1.TabIndex = 2;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("Aųɲ͵гՊرܽ\u082Fढ़੮\u0B7Eౢൺ\u0E7D༨၊ᅧቫ፥ᑤᕧᙳ");
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(2, 2);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(48, 39);
      this.panel2.TabIndex = 1;
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new Point(511, 108);
      this.dataGridView1.Name = \u003F0\u003F.\u003F1\u003F("iŭɿͫюպٮݢࡓ७੦\u0B75ర");
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.Size = new Size(246, 240);
      this.dataGridView1.TabIndex = 5;
      this.dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      this.richTextBox2.BackColor = Color.FromArgb(30, 30, 30);
      this.richTextBox2.BorderStyle = BorderStyle.None;
      this.richTextBox2.Font = new Font(\u003F0\u003F.\u003F1\u003F("HťɼͺѮգٷܤࡍ१\u0A76"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.richTextBox2.ForeColor = Color.ForestGreen;
      this.richTextBox2.Location = new Point(135, 144);
      this.richTextBox2.Name = \u003F0\u003F.\u003F1\u003F("~Ţɩ͡ќբپݱࡆ६\u0A7Aଳ");
      this.richTextBox2.Size = new Size(350, 204);
      this.richTextBox2.TabIndex = 137;
      this.richTextBox2.Text = \u003F0\u003F.\u003F1\u003F("4ĵȷ͆Ѵէ٧ݷ࠱ॉ\u0A60\u0B7B౿ബ๘ཀྵၻᅡቷ\u1372ᐥᕌᙦᝰᡤ");
      this.richTextBox2.TextChanged += new EventHandler(this.richTextBox2_TextChanged);
      this.button8.BackColor = Color.FromArgb(65, 65, 65);
      this.button8.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button8.FlatStyle = FlatStyle.Flat;
      this.button8.ForeColor = SystemColors.Control;
      this.button8.Location = new Point(135, 354);
      this.button8.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլع");
      this.button8.Size = new Size(83, 30);
      this.button8.TabIndex = 138;
      this.button8.Text = \u003F0\u003F.\u003F1\u003F("WŢɴͤ");
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button1.BackColor = Color.FromArgb(65, 65, 65);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = SystemColors.Control;
      this.button1.Location = new Point(402, 354);
      this.button1.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլذ");
      this.button1.Size = new Size(83, 30);
      this.button1.TabIndex = 139;
      this.button1.Text = \u003F0\u003F.\u003F1\u003F("FŨɦͣѳ");
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button3.BackColor = Color.FromArgb(65, 65, 65);
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = SystemColors.Control;
      this.button3.Location = new Point(313, 354);
      this.button3.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլز");
      this.button3.Size = new Size(83, 30);
      this.button3.TabIndex = 140;
      this.button3.Text = \u003F0\u003F.\u003F1\u003F("BŪɮͤ");
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.button4.BackColor = Color.FromArgb(65, 65, 65);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = SystemColors.Control;
      this.button4.Location = new Point(224, 354);
      this.button4.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլص");
      this.button4.Size = new Size(83, 30);
      this.button4.TabIndex = 141;
      this.button4.Text = \u003F0\u003F.\u003F1\u003F("BžɠͧѶն٤");
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = SystemColors.Window;
      this.label3.Location = new Point(50, 104);
      this.label3.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԲ");
      this.label3.Size = new Size(68, 32);
      this.label3.TabIndex = 24;
      this.label3.Text = \u003F0\u003F.\u003F1\u003F("RŬɰͯѧԻ");
      this.label4.AutoSize = true;
      this.label4.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = SystemColors.Window;
      this.label4.Location = new Point(35, 144);
      this.label4.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԵ");
      this.label4.Size = new Size(83, 32);
      this.label4.TabIndex = 142;
      this.label4.Text = \u003F0\u003F.\u003F1\u003F("Tťɷͭѳնػ");
      this.richTextBox1.BackColor = Color.FromArgb(30, 30, 30);
      this.richTextBox1.BorderStyle = BorderStyle.None;
      this.richTextBox1.Font = new Font(\u003F0\u003F.\u003F1\u003F("HťɼͺѮգٷܤࡍ१\u0A76"), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.richTextBox1.ForeColor = Color.ForestGreen;
      this.richTextBox1.Location = new Point(135, 108);
      this.richTextBox1.Name = \u003F0\u003F.\u003F1\u003F("~Ţɩ͡ќբپݱࡆ६\u0A7Aର");
      this.richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
      this.richTextBox1.Size = new Size(350, 28);
      this.richTextBox1.TabIndex = 143;
      this.richTextBox1.Text = \u003F0\u003F.\u003F1\u003F(">Ŀȱ̓Ѭռ٤ݼ\u087Fपੇ୩౪ൣลཌၦᅰቤ");
      this.button5.BackColor = Color.FromArgb(65, 65, 65);
      this.button5.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = SystemColors.Control;
      this.button5.Location = new Point(644, 354);
      this.button5.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլش");
      this.button5.Size = new Size(113, 30);
      this.button5.TabIndex = 144;
      this.button5.Text = \u003F0\u003F.\u003F1\u003F("Iũɧͯѽխاݕ\u0866ॶ੪\u0B72\u0C75");
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button6.BackColor = Color.FromArgb(65, 65, 65);
      this.button6.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.ForeColor = SystemColors.Control;
      this.button6.Location = new Point(511, 354);
      this.button6.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլط");
      this.button6.Size = new Size((int) sbyte.MaxValue, 30);
      this.button6.TabIndex = 145;
      this.button6.Text = \u003F0\u003F.\u003F1\u003F("DźɬͦЧՕ٦ݶ\u086Aॲੵ");
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.label5.AutoSize = true;
      this.label5.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = SystemColors.Window;
      this.label5.Location = new Point(212, 65);
      this.label5.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԴ");
      this.label5.Size = new Size(182, 32);
      this.label5.TabIndex = 146;
      this.label5.Text = \u003F0\u003F.\u003F1\u003F("]Ůɾ͢Ѻսب݊\u0867५\u0A65\u0B64౧\u0D73");
      this.label6.AutoSize = true;
      this.label6.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 18f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = SystemColors.Window;
      this.label6.Location = new Point(574, 66);
      this.label6.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԷ");
      this.label6.Size = new Size(121, 32);
      this.label6.TabIndex = 147;
      this.label6.Text = \u003F0\u003F.\u003F1\u003F("Xũɻ͡ѷղإ݈\u086Aॱੵ");
      this.label6.Click += new EventHandler(this.label6_Click);
      this.button7.BackColor = Color.FromArgb(65, 65, 65);
      this.button7.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.ForeColor = SystemColors.Control;
      this.button7.Location = new Point(22, 318);
      this.button7.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլض");
      this.button7.Size = new Size(96, 66);
      this.button7.TabIndex = 148;
      this.button7.Text = \u003F0\u003F.\u003F1\u003F("Uųɬ̺эշط݃\u0866ॱਲ਼\u0B46\u0C79\u0D75ฯཝၮᅾቢ\u137Aᑽᔨᙊᝧᡫᥥᩤ᭧ᱳ");
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button9.BackColor = Color.FromArgb(65, 65, 65);
      this.button9.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button9.FlatStyle = FlatStyle.Flat;
      this.button9.ForeColor = SystemColors.Control;
      this.button9.Location = new Point(22, 267);
      this.button9.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլظ");
      this.button9.Size = new Size(96, 45);
      this.button9.TabIndex = 149;
      this.button9.Text = \u003F0\u003F.\u003F1\u003F("Gűɰ͢ѡթ");
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(50, 50, 50);
      this.ClientSize = new Size(780, 404);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.richTextBox1);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.richTextBox2);
      this.Controls.Add((Control) this.dataGridView1);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = \u003F0\u003F.\u003F1\u003F("^ůɹͣѹռيݧ\u086B॥\u0A64୧\u0C73");
      this.Text = \u003F0\u003F.\u003F1\u003F("^ůɹͣѹռيݧ\u086B॥\u0A64୧\u0C73");
      this.Load += new EventHandler(this.ScriptManager_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((ISupportInitialize) this.dataGridView1).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
