﻿// Decompiled with JetBrains decompiler
// Type: Vega_X.ScriptHub
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using ComponentFactory.Krypton.Toolkit;
using EasyExploits;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
  public class ScriptHub : KryptonForm
  {
    private ExploitAPI api = new ExploitAPI();
    private Module module = new Module();
    private Point lastPoint;
    private IContainer components = (IContainer) null;
    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Button button2;
    private Button button6;
    private Button button8;
    private Button button12;
    private Button button14;
    private Label label3;
    private Button button3;
    private Button button4;
    private Button button15;
    private Button button7;
    private Button button9;
    private Button button11;
    private Button button13;
    private Button button16;
    private Button button17;
    private Button button5;
    private Button button10;
    private Button button18;
    private Label label4;
    private Button button19;
    private Button button20;
    private Button button22;
    private Button button23;
    private Button button21;
    private Button button24;
    private Button button25;
    private Button button26;
    private Button button27;
    private Button button28;
    private Button button29;
    private Button button31;
    private Button button32;
    private Button button34;
    private Button button35;
    private Label label2;
    private Panel panel4;
    private Panel panel5;
    private Label label5;
    private Button button41;
    private Button button36;
    private Button button37;
    private Button button39;
    private Button button40;
    private Button button42;
    private Button button44;
    private Button button45;
    private Button button46;
    private Button button47;
    private Button button48;
    private Button button49;
    private Button button50;
    private Button button38;
    private Button button51;
    private Button button52;
    private Button button53;
    private Button button54;
    private Button button55;
    private Button button56;
    private Button button57;
    private Button button58;
    private Button button59;
    private Button button60;
    private Button button62;
    private Panel panel6;
    private Label label6;
    private Button button63;
    private Button button64;
    private Button button65;
    private Button button66;
    private Button button67;
    private Button button72;
    private Button button68;
    private Button button69;
    private Button button70;
    private Button button73;
    private Button button74;
    private Button button75;
    private Button button76;
    private Button button77;
    private Button button78;
    private Button button79;
    private Button button80;
    private Button button81;
    private Button button82;
    private Button button83;
    private Button button84;
    private Button button85;
    private Button button86;
    private Button button88;
    private Button button89;
    private Button button90;
    private Button button91;
    private Button button92;
    private Button button93;
    private Button button94;
    private Button button95;
    private Button button96;
    private Button button97;
    private Button button98;
    private Button button99;
    private Button button100;
    private Button button101;
    private Button button103;
    private Button button104;
    private Panel panel7;
    private Label label7;
    private Button button105;
    private Button button106;
    private Button button107;
    private Panel panel8;
    private Button button1;
    private Button button30;
    private Button button33;
    private Button button43;
    private Button button61;
    private Button button71;
    private Button button102;
    private Button button108;
    private Button button109;
    private Button button110;
    private Button button111;
    private Button button112;
    private Button button113;
    private Button button114;
    private Button button115;
    private Button button116;
    private Label label8;
    private Button button87;
    private Panel panel3;
    private Label label9;
    private Label label10;
    private Label label11;
    private Label label13;
    private Label label15;
    private Label label16;
    private Label label18;
    private Label label23;
    private Label label24;
    private Label label25;
    private Label label26;
    private Label label27;
    private Label label28;
    private Label label29;
    private Label label30;
    private Label label33;
    private Label label34;
    private Label label36;
    private Label label37;
    private Label label38;
    private Label label40;
    private RadioButton EXButton;
    private RadioButton WRDButton;
    private Label label12;
    private Label label41;
    private Label label17;
    private Label label19;

    public ScriptHub() => this.InitializeComponent();

    private void button2_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void label1_Click(object sender, EventArgs e)
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

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void button4_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click_1(object sender, EventArgs e) => this.Close();

    private void ScriptHub_Load_1(object sender, EventArgs e)
    {
      this.TopMost = true;
      this.EXButton.Checked = true;
    }

    private void button10_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button11_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥉ᩆᬷᱶᵁṓὨ‸")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥉ᩆᬷᱶᵁṓὨ‸")));
      }
    }

    private void button17_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥠ\u1A7D᭮ᱝᵞṀ\u1F46ⁱ")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥠ\u1A7D᭮ᱝᵞṀ\u1F46ⁱ")));
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(",ķȶ̱гԅؑܒࡎग़੍ଗ\u0C5F\u0D5Eโཝ၁ᅑቇፂᑕᕝᙍᝂᡂᥟᩏᭇᱜᴉṅὊ⁉ℌ≧⍅⑇╺♗❄⠳⥲⩴⭿ⱱ\u2D79\u2E7F⽡ぱㅪ㉻㍴㑼㕫㘡㝠㡭㥸㩾㭬㱺㴨㹵㽪䁱䅱䉡䍤")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(",ķȶ̱гԅؑܒࡎग़੍ଗ\u0C5F\u0D5Eโཝ၁ᅑቇፂᑕᕝᙍᝂᡂᥟᩏᭇᱜᴉṅὊ⁉ℌ≧⍅⑇╺♗❄⠳⥲⩴⭿ⱱ\u2D79\u2E7F⽡ぱㅪ㉻㍴㑼㕫㘡㝠㡭㥸㩾㭬㱺㴨㹵㽪䁱䅱䉡䍤")));
      }
    }

    private void button15_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥟᩴ᭒᱃ᵷḺὡ⁌")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥟᩴ᭒᱃ᵷḺὡ⁌")));
      }
    }

    private void button18_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("!ļȳ̶жվ٬ݭ࠳डੈଐౚ\u0D55๏དྷ၌ᅚቂፅᑐᕆᙐ\u175Dᡟ᥄ᩊᭀ᱙ᴂṈὅ⁄ℇ≫⍩\u246A╢☎❑⡘⥓⨰⭌Ⱳ\u2D7E\u2E77⽵ちㄵ㉄㍾㑼㕠㘼㝿㡰㥹㩡㬡㱞㵤㹪㽸䁢䅊䉮䍲䑠䔪䙯䝷䡠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("!ļȳ̶жվ٬ݭ࠳डੈଐౚ\u0D55๏དྷ၌ᅚቂፅᑐᕆᙐ\u175Dᡟ᥄ᩊᭀ᱙ᴂṈὅ⁄ℇ≫⍩\u246A╢☎❑⡘⥓⨰⭌Ⱳ\u2D7E\u2E77⽵ちㄵ㉄㍾㑼㕠㘼㝿㡰㥹㩡㬡㱞㵤㹪㽸䁢䅊䉮䍲䑠䔪䙯䝷䡠")));
      }
    }

    private void button13_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥙᩦᭈ᱀ᵥṀὕ⁐")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥙᩦᭈ᱀ᵥṀὕ⁐")));
      }
    }

    private void button9_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥫᩭ᭜ᱫᵽḳύ⁌")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥫᩭ᭜ᱫᵽḳύ⁌")));
      }
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193F᩿ᭃᱳᵬṄὒ\u2075")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193F᩿ᭃᱳᵬṄὒ\u2075")));
      }
    }

    private void button16_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("VŉɈ͋щԃؗܘࡄ॔\u0A43ଝౕ\u0D58ไཇၛᅏ\u1259ፘᑏᕛᙋᝈᡈᥑᩁ\u1B4D᱖ᴏṃὰ\u2073Ⅎ∭⍽\u242A╠♬✸⡵⥺⩹⭾Ⱨ⵿\u2E79⽻ぷㄢ㉡㍪㑹㕽㙭㝵㠩㥬㩩㭡㱴㵢")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("VŉɈ͋щԃؗܘࡄ॔\u0A43ଝౕ\u0D58ไཇၛᅏ\u1259ፘᑏᕛᙋᝈᡈᥑᩁ\u1B4D᱖ᴏṃὰ\u2073Ⅎ∭⍽\u242A╠♬✸⡵⥺⩹⭾Ⱨ⵿\u2E79⽻ぷㄢ㉡㍪㑹㕽㙭㝵㠩㥬㩩㭡㱴㵢")));
      }
    }

    private void button12_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Fᩰ᭗᱗ᵠḰἵ‷")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Fᩰ᭗᱗ᵠḰἵ‷")));
      }
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥍ᨳ\u1B7Eᱏᵽṛὔ⁕")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥍ᨳ\u1B7Eᱏᵽṛὔ⁕")));
      }
    }

    private void button14_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Cᩍ᭤᰼ᴳṕὕ⁇")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Cᩍ᭤᰼ᴳṕὕ⁇")));
      }
    }

    private void button4_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Fᩋ\u1B4EᱴᵣṄὐ‶")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Fᩋ\u1B4EᱴᵣṄὐ‶")));
      }
    }

    private void button3_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⍼\u2429╡♣✹⡶⥻⩾⭿Ɽ\u2D7E\u2E66⽺ぴㄣ㉦㍫㑺㕼㙢㝴㠪㥦㩡㭫㱷")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⍼\u2429╡♣✹⡶⥻⩾⭿Ɽ\u2D7E\u2E66⽺ぴㄣ㉦㍫㑺㕼㙢㝴㠪㥦㩡㭫㱷")));
      }
    }

    private void button6_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥚᩦ᭐᰼ᵽṒὒ⁃")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥚᩦ᭐᰼ᵽṒὒ⁃")));
      }
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button20_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᩲ᭤ᰳᴽṖὒ⁂")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᩲ᭤ᰳᴽṖὒ⁂")));
      }
    }

    private void button19_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥢᩀ᭕᱄ᵀṙὗ\u2072")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥢᩀ᭕᱄ᵀṙὗ\u2072")));
      }
    }

    private void button22_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197FᩋᭃᱏᴲṚ\u1F46⁇")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197FᩋᭃᱏᴲṚ\u1F46⁇")));
      }
    }

    private void button23_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Dᩥ᭵ᱨᵖṉἲ⁏")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Dᩥ᭵ᱨᵖṉἲ⁏")));
      }
    }

    private void button24_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥀ᩋ᭐᱖ᵊṫὅ‴")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥀ᩋ᭐᱖ᵊṫὅ‴")));
      }
    }

    private void button21_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥟᩅ᭳ᱽᴼṙὶ\u2068")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥟᩅ᭳ᱽᴼṙὶ\u2068")));
      }
    }

    private void button28_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Dᩍᭀ᱖ᵽḷὗ⁌")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Dᩍᭀ᱖ᵽḷὗ⁌")));
      }
    }

    private void button30_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197BᩳᭈᰲᵶṷὩ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197BᩳᭈᰲᵶṷὩ⁒")));
      }
    }

    private void button31_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥠᨵ᭵᱗ᴴṩὨ\u206A")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥠᨵ᭵᱗ᴴṩὨ\u206A")));
      }
    }

    private void button35_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤱᩬ᭔᱂ᵊḰά‷")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤱᩬ᭔᱂ᵊḰά‷")));
      }
    }

    private void button33_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥬᩯ\u1B7EᰳᵔṔὨ\u2072")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥬᩯ\u1B7EᰳᵔṔὨ\u2072")));
      }
    }

    private void button32_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥰᨲᭅ᱀ᵲṐὓ⁅")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥰᨲᭅ᱀ᵲṐὓ⁅")));
      }
    }

    private void button29_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤱᩅ᭐ᰱᵇṮὧ⁐")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤱᩅ᭐ᰱᵇṮὧ⁐")));
      }
    }

    private void button34_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⌨\u2429┩♱\u2779⡧⤻⩅⬼ⱖⴽ\u2E47⽻はㄣ㉦㍫㑠㕦㘨㝐㠫㥃㩫㭷㱣")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⌨\u2429┩♱\u2779⡧⤻⩅⬼ⱖⴽ\u2E47⽻はㄣ㉦㍫㑠㕦㘨㝐㠫㥃㩫㭷㱣")));
      }
    }

    private void button27_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("/Ĳȱ̴аոٮݯࡍय़\u0A4A\u0B12\u0C5C\u0D53ํཐ၂ᅔቀፇᑖᕀᙒ\u175FᡁᥚᩈᭂᱟᴄṊ\u1F47⁊℉≶⍐\u2451╋♊❅⡷⥫⩿⭪Ⱙⵠ⸶⽋っㅹ㉧㍹㑀㕙㙫㜿㡢㥯㩤㭢㰤㵋㹥㽤䁘䅯䉫䍛䑬䕬䙤")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("/Ĳȱ̴аոٮݯࡍय़\u0A4A\u0B12\u0C5C\u0D53ํཐ၂ᅔቀፇᑖᕀᙒ\u175FᡁᥚᩈᭂᱟᴄṊ\u1F47⁊℉≶⍐\u2451╋♊❅⡷⥫⩿⭪Ⱙⵠ⸶⽋っㅹ㉧㍹㑀㕙㙫㜿㡢㥯㩤㭢㰤㵋㹥㽤䁘䅯䉫䍛䑬䕬䙤")));
      }
    }

    private void button26_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Aᩃᬳ᱉ᵉḵή\u2060")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Aᩃᬳ᱉ᵉḵή\u2060")));
      }
    }

    private void button25_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥐᩱ᭮ᰵᵶḻὛ‵")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥐᩱ᭮ᰵᵶḻὛ‵")));
      }
    }

    private void button39_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1979ᩔ᭓᰼ᵅṥἴ⁊")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1979ᩔ᭓᰼ᵅṥἴ⁊")));
      }
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    private void button40_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177DᠦᤰᩱᬳᱮᵡḰὰ\u206B")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177DᠦᤰᩱᬳᱮᵡḰὰ\u206B")));
      }
    }

    private void button39_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Eᨴ᬴᱐ᵌṁὛ′")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Eᨴ᬴᱐ᵌṁὛ′")));
      }
    }

    private void button38_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥘᩋ᭶᱕ᴴṫὴ‵")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥘᩋ᭶᱕ᴴṫὴ‵")));
      }
    }

    private void button36_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button37_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥫᩀ᭰ᱭᵌṰὯ\u206B")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥫᩀ᭰ᱭᵌṰὯ\u206B")));
      }
    }

    private void button41_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(".ıȰ̳бջٯܐࡌड़ੋକ\u0C5D\u0D50์ཟ၃ᅗቁፀᑗᕃᙓᝀᡀᥙᩉᭅᱞᴇṋὈ⁋ℊ≧⍏␓╂♋\u277A⡬⥯⨳⭺Ɐ\u2D6D\u2E77⽹みㅲ㉳㍲㐽㕼㙱㝦㡠㤢㩭㭾㱾㵦㹮㽦䁴䅨䈪䍯䑷䕠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(".ıȰ̳бջٯܐࡌड़ੋକ\u0C5D\u0D50์ཟ၃ᅗቁፀᑗᕃᙓᝀᡀᥙᩉᭅᱞᴇṋὈ⁋ℊ≧⍏␓╂♋\u277A⡬⥯⨳⭺Ɐ\u2D6D\u2E77⽹みㅲ㉳㍲㐽㕼㙱㝦㡠㤢㩭㭾㱾㵦㹮㽦䁴䅨䈪䍯䑷䕠")));
      }
    }

    private void button43_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("_ůɹͯѣկ٭ܨࡁ३\u0A77ତ్൭\u0E76"));
    }

    private void button42_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
    }

    private void button44_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥉ᩤ᭠᱗ᵖḱὰ⁘")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥉ᩤ᭠᱗ᵖḱὰ⁘")));
      }
    }

    private void button45_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥎ᩮᬰ᱁ᵬṺ\u1F58‴")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥎ᩮᬰ᱁ᵬṺ\u1F58‴")));
      }
    }

    private void button47_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
    }

    private void button48_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᩓ᭱ᱤᵗḷὰ‷")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᩓ᭱ᱤᵗḷὰ‷")));
      }
    }

    private void button46_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
    }

    private void button49_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≂⍀\u2457╗♛❍⡏⥳⨱⭰ⱽ\u2D68\u2E6E⽼なㅿ㉣㍷㑢㔠㘣㜠㠿㥦㩺㭬㱯㵣㹣㼦䁅䅦䉯䍫䐪䕯䙷䝠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≂⍀\u2457╗♛❍⡏⥳⨱⭰ⱽ\u2D68\u2E6E⽼なㅿ㉣㍷㑢㔠㘣㜠㠿㥦㩺㭬㱯㵣㹣㼦䁅䅦䉯䍫䐪䕯䙷䝠")));
      }
    }

    private void button50_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥉ᩄ᭧᱈ᵗṪἷ⁄")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥉ᩄ᭧᱈ᵗṪἷ⁄")));
      }
    }

    private void button38_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥢᩃ᭯ᱨᵈḱί⁄")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥢᩃ᭯ᱨᵈḱί⁄")));
      }
    }

    private void button58_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥥᩪ᭕ᱜᵔṻὕ\u2073")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥥᩪ᭕ᱜᵔṻὕ\u2073")));
      }
    }

    private void button59_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button60_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥭᩋ᭳᰽ᵦṥὣ‸")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥭᩋ᭳᰽ᵦṥὣ‸")));
      }
    }

    private void button61_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("_ůɹͯѣկ٭ܨࡁ३\u0A77ତ్൭\u0E76"));
    }

    private void button62_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥰ\u1A5F᭧ᰲᵏṆὯ‸")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥰ\u1A5F᭧ᰲᵏṆὯ‸")));
      }
    }

    private void button56_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᤹ᨷᭀ᱆ᵼṖὨ\u206A")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᤹ᨷᭀ᱆ᵼṖὨ\u206A")));
      }
    }

    private void button55_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Eᩃᭃ᱆ᵡṉὗ⁛")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Eᩃᭃ᱆ᵡṉὗ⁛")));
      }
    }

    private void button51_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≂⍀\u2457╗♛❍⡏⥳⨱⭰ⱽ\u2D68\u2E6E⽼なㅿ㉣㍷㑢㔠㘣㜠㠿㥦㩺㭬㱯㵣㹣㼦䁅䅦䉯䍫䐪䕯䙷䝠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≂⍀\u2457╗♛❍⡏⥳⨱⭰ⱽ\u2D68\u2E6E⽼なㅿ㉣㍷㑢㔠㘣㜠㠿㥦㩺㭬㱯㵣㹣㼦䁅䅦䉯䍫䐪䕯䙷䝠")));
      }
    }

    private void button57_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Fᩃ᭰ᱽᵶḱὕ⁏")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Fᩃ᭰ᱽᵶḱὕ⁏")));
      }
    }

    private void button54_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⌨\u2429┩♱\u2779⡧⤻⩅⬼ⱖⴽ\u2E47⽻はㄣ㉦㍫㑠㕦㘨㝐㠫㥃㩫㭷㱣")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⌨\u2429┩♱\u2779⡧⤻⩅⬼ⱖⴽ\u2E47⽻はㄣ㉦㍫㑠㕦㘨㝐㠫㥃㩫㭷㱣")));
      }
    }

    private void button52_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197D\u1A5F\u1B7E᱉ᵜṰὔ\u2063")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197D\u1A5F\u1B7E᱉ᵜṰὔ\u2063")));
      }
    }

    private void button53_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥱᩩᭁᱟᵢṥὃ\u2077")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥱᩩᭁᱟᵢṥὃ\u2077")));
      }
    }

    private void button1_Click(object sender, EventArgs e) => this.Close();

    private void button67_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥣ\u1A7Dᬷ᱀ᵰḳὩ⁆")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥣ\u1A7Dᬷ᱀ᵰḳὩ⁆")));
      }
    }

    private void button66_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button65_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥄ᩆᭋᱎᵈṺ\u1F4F\u2063")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥄ᩆᭋᱎᵈṺ\u1F4F\u2063")));
      }
    }

    private void button64_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⌨\u2429┩♱\u2779⡧⤻⩅⬼ⱖⴽ\u2E47⽻はㄣ㉦㍫㑠㕦㘨㝐㠫㥃㩫㭷㱣")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("Uňɏ͊ъԂؘܙࡇॕ\u0A44ଜౖ\u0D59๛ཆၘᅎ\u125Eፙᑌᕚᙄᝉᡋᥐᩆ\u1B4C᱕ᴎṼά\u2070ℳ∪⌨\u2429┩♱\u2779⡧⤻⩅⬼ⱖⴽ\u2E47⽻はㄣ㉦㍫㑠㕦㘨㝐㠫㥃㩫㭷㱣")));
      }
    }

    private void button63_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≂⍀\u2457╗♛❍⡏⥳⨱⭰ⱽ\u2D68\u2E6E⽼なㅿ㉣㍷㑢㔠㘣㜠㠿㥦㩺㭬㱯㵣㹣㼦䁅䅦䉯䍫䐪䕯䙷䝠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≂⍀\u2457╗♛❍⡏⥳⨱⭰ⱽ\u2D68\u2E6E⽼なㅿ㉣㍷㑢㔠㘣㜠㠿㥦㩺㭬㱯㵣㹣㼦䁅䅦䉯䍫䐪䕯䙷䝠")));
      }
    }

    private void button72_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("_ůɹͯѣկ٭ܨࡁ३\u0A77ତ్൭\u0E76"));
    }

    private void button71_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("_ůɹͯѣկ٭ܨࡁ३\u0A77ତ్൭\u0E76"));
    }

    private void button70_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥢᩦ᭐᱂ᵝṠὓ⁐")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥢᩦ᭐᱂ᵝṠὓ⁐")));
      }
    }

    private void button69_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥟᩤ᭮᱑ᵉṹ\u1F46⁃")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥟᩤ᭮᱑ᵉṹ\u1F46⁃")));
      }
    }

    private void button68_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥥᨰ᭰ᱯᴶṅὴ\u2073")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥥᨰ᭰ᱯᴶṅὴ\u2073")));
      }
    }

    private void button73_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥩᩡᭊ᱔ᴱṵ\u1F46\u2078")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥩᩡᭊ᱔ᴱṵ\u1F46\u2078")));
      }
    }

    private void button77_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥲᩗ᬴ᱦᴷṍέ\u2077")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥲᩗ᬴ᱦᴷṍέ\u2077")));
      }
    }

    private void button74_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("(ŋɊ͍яԁؕܖࡊॖੁଛ\u0C53\u0D5Aๆཙ၅ᅍቛ፞ᑉᕙᙉᝆᡆᥓᩃᭋ᱐ᴍṁ\u1F4E⁍ℰ≿⍾\u246F╮☫✫⠫⤸⩞⭚ⱜⵜ\u2E4D⽙〿ㅢ㉯㍤㑢㔤㙆㝦㡩㥣㩯㭫㱣㵜㹗㽈")));
      }
    }

    private void button76_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("8ĻȺ̽пձ٥ݦ࠺द\u0A31୫ణപึ༩ဵᅝቋፎᑙᕉᙙ\u1756ᡖ\u1943ᩓ᭛᱀ᴝṑ\u1F5E⁝℀≥⍘\u245E╂♽❈⡛⥳⩇⭎ⱁⵍ⸍⽬くㅱ㉵㍸㑥㕈㙹㝫㡱㥧㩢㭦㰻㵾㹳㽸䁾䄠䉄䍬䑥䕧䙇䝦䡦䥬䩣䭼䰪䵯乷你")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("8ĻȺ̽пձ٥ݦ࠺द\u0A31୫ణപึ༩ဵᅝቋፎᑙᕉᙙ\u1756ᡖ\u1943ᩓ᭛᱀ᴝṑ\u1F5E⁝℀≥⍘\u245E╂♽❈⡛⥳⩇⭎ⱁⵍ⸍⽬くㅱ㉵㍸㑥㕈㙹㝫㡱㥧㩢㭦㰻㵾㹳㽸䁾䄠䉄䍬䑥䕧䙇䝦䡦䥬䩣䭼䰪䵯乷你")));
      }
    }

    private void button75_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("\"Ľȼ̷еտ٫ݬ࠰ठ\u0A37\u0B11ౙ\u0D54่ན၏ᅛቍፄᑓᕇᙗ\u175Cᡜ᥅ᩕᭁᱚᴃṏὄ⁇℆≢⍈\u2455╍♍❆⡥⥄⩍⭙ⱷ\u2D73\u2E78⽾とㄶ㉿㍢㑴㕲㙡㝱㠽㥼㩱㭦㱠㴢㹮㽮䁯䅺䉿䍦䑣䕨䙢䝱䡧䥤")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("\"Ľȼ̷еտ٫ݬ࠰ठ\u0A37\u0B11ౙ\u0D54่ན၏ᅛቍፄᑓᕇᙗ\u175Cᡜ᥅ᩕᭁᱚᴃṏὄ⁇℆≢⍈\u2455╍♍❆⡥⥄⩍⭙ⱷ\u2D73\u2E78⽾とㄶ㉿㍢㑴㕲㙡㝱㠽㥼㩱㭦㱠㴢㹮㽮䁯䅺䉿䍦䑣䕨䙢䝱䡧䥤")));
      }
    }

    private void button81_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥎ᨶᬱᱝᵡḶἴ‱")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥎ᨶᬱᱝᵡḶἴ‱")));
      }
    }

    private void button80_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button79_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᩳ᭼ᱵᵡṒὛ⁻")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᩳ᭼ᱵᵡṒὛ⁻")));
      }
    }

    private void button78_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᨱ᭞ᰵᵎṚἳ⁉")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᨱ᭞ᰵᵎṚἳ⁉")));
      }
    }

    private void button83_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᩖ᭔ᱠᵪṻἺ\u206B")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᩖ᭔ᱠᵪṻἺ\u206B")));
      }
    }

    private void button86_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Dᩋ᭣᰼ᵶṔὤ⁘")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Dᩋ᭣᰼ᵶṔὤ⁘")));
      }
    }

    private void button85_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᩳᬿ᱃ᵌṁὸ‶")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᩳᬿ᱃ᵌṁὸ‶")));
      }
    }

    private void button84_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩋ᭱ᱦᵰṖὣ\u2076")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩋ᭱ᱦᵰṖὣ\u2076")));
      }
    }

    private void button87_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("_ůɹͯѣկ٭ܨࡁ३\u0A77ତ్൭\u0E76"));
    }

    private void button82_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥌ᨰ᭑ᱟᵃḴὊ‴")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥌ᨰ᭑ᱟᵃḴὊ‴")));
      }
    }

    private void button100_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥏ᩰᭁᰲᵎṫέ⁉")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥏ᩰᭁᰲᵎṫέ⁉")));
      }
    }

    private void button101_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥅\u1A5F᭰ᰶᵆṙὁ\u2076")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥅\u1A5F᭰ᰶᵆṙὁ\u2076")));
      }
    }

    private void button102_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(\u003F0\u003F.\u003F1\u003F("_ůɹͯѣկ٭ܨࡁ३\u0A77ତ్൭\u0E76"));
    }

    private void button103_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("*ĵȴ͏эԇؓܔࡈक़\u0A4Fଙ\u0C51\u0D5Cเཛ၇ᅓቅ\u135Cᑋᕟᙏᝄᡄᥝᩍᭉ᱒ᴋṇὌ⁏ℎ≢⍳\u2471╹♥❃⡒⥬⩺⬸ⱎ⵰\u2E7A⽺ぷㅽ\u324F㍎㑢㕡㘣㝦㡫㥠㩦㬨㱀㵪㹶㽂䁮䅭")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("*ĵȴ͏эԇؓܔࡈक़\u0A4Fଙ\u0C51\u0D5Cเཛ၇ᅓቅ\u135Cᑋᕟᙏᝄᡄᥝᩍᭉ᱒ᴋṇὌ⁏ℎ≢⍳\u2471╹♥❃⡒⥬⩺⬸ⱎ⵰\u2E7A⽺ぷㅽ\u324F㍎㑢㕡㘣㝦㡫㥠㩦㬨㱀㵪㹶㽂䁮䅭")));
      }
    }

    private void button104_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button98_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193F\u1A5F\u1B4Dᱷᵇṙ\u1F4F⁅")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193F\u1A5F\u1B4Dᱷᵇṙ\u1F4F⁅")));
      }
    }

    private void button97_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(",ķȶ̱гԅؑܒࡎग़੍ଗ\u0C5F\u0D5Eโཝ၁ᅑቇፂᑕᕝᙍᝂᡂᥟᩏᭇᱜᴉṅὊ⁉ℌ≐⍄⑄╻♧❩⡴⥾⩾⭼Ɱⴸ\u2E44⽰ばㅷ㉫㌼㑘㕺㙬㜢㡡㥪㩣㭧㰧㵘㹊㽪䁥䅧䉧䍳")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(",ķȶ̱гԅؑܒࡎग़੍ଗ\u0C5F\u0D5Eโཝ၁ᅑቇፂᑕᕝᙍᝂᡂᥟᩏᭇᱜᴉṅὊ⁉ℌ≐⍄⑄╻♧❩⡴⥾⩾⭼Ɱⴸ\u2E44⽰ばㅷ㉫㌼㑘㕺㙬㜢㡡㥪㩣㭧㰧㵘㹊㽪䁥䅧䉧䍳")));
      }
    }

    private void button99_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Eᩰ᭞ᱳᵉṉί‸")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193Eᩰ᭞ᱳᵉṉί‸")));
      }
    }

    private void button96_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥝᩯᭋᰰᵼṉἲ‷")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥝᩯᭋᰰᵼṉἲ‷")));
      }
    }

    private void button94_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button95_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1942ᩖᬷᱟᴼṎὲ″")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1942ᩖᬷᱟᴼṎὲ″")));
      }
    }

    private void button93_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤰᩞ᭣ᰴᵶṤὌ″")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤰᩞ᭣ᰴᵶṤὌ″")));
      }
    }

    private void button92_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥦᩪ᭗ᱵᴷṋἷ⁒")));
      }
    }

    private void button91_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥬᩄ᭫᱐ᵆṠὪ\u206F")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥬᩄ᭫᱐ᵆṠὪ\u206F")));
      }
    }

    private void button90_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193FᩦᬲᱽᵆṠὪ⁋")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193FᩦᬲᱽᵆṠὪ⁋")));
      }
    }

    private void button89_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1978ᩣ᭴᱀ᵀṂἰ\u2062")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1978ᩣ᭴᱀ᵀṂἰ\u2062")));
      }
    }

    private void button88_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(",ķȶ̱гԅؑܒࡎग़੍ଗ\u0C5F\u0D5Eโཝ၁ᅑቇፂᑕᕝᙍᝂᡂᥟᩏᭇᱜᴉṅὊ⁉ℌ≈⍎⑅╺♰\u277A⡳⤴⩜⭬ⱬⵢ\u2E64⽰〻ㅾ㉳㍸㑾㔠㙢㝢㡭㥯㩹㭽㱺㵮㹨㽢䀪䅯䉷䍠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(",ķȶ̱гԅؑܒࡎग़੍ଗ\u0C5F\u0D5Eโཝ၁ᅑቇፂᑕᕝᙍᝂᡂᥟᩏᭇᱜᴉṅὊ⁉ℌ≈⍎⑅╺♰\u277A⡳⤴⩜⭬ⱬⵢ\u2E64⽰〻ㅾ㉳㍸㑾㔠㙢㝢㡭㥯㩹㭽㱺㵮㹨㽢䀪䅯䉷䍠")));
      }
    }

    private void button105_Click(object sender, EventArgs e)
    {
      this.Hide();
      new ScriptHub2().Show();
    }

    private void button107_Click(object sender, EventArgs e) => this.Close();

    private void button106_Click(object sender, EventArgs e)
    {
      this.Hide();
      new ScriptHub3().Show();
    }

    private void button113_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(".ıȰ̳бջٯܐࡌड़ੋକ\u0C5D\u0D50์ཟ၃ᅗቁፀᑗᕃᙓᝀᡀᥙᩉᭅᱞᴇṋὈ⁋ℊ≭⍎\u2452╔♌❬⡻⥲⩲⭢Ⱶ\u2D6C\u2E6C⽢ぴㅰ㈻㍠㑱㕣㙹㝿㡺㥾㨣㭦㱫㵠㹦㼨䁢䅤䉬䍬䑭䕥")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(".ıȰ̳бջٯܐࡌड़ੋକ\u0C5D\u0D50์ཟ၃ᅗቁፀᑗᕃᙓᝀᡀᥙᩉᭅᱞᴇṋὈ⁋ℊ≭⍎\u2452╔♌❬⡻⥲⩲⭢Ⱶ\u2D6C\u2E6C⽢ぴㅰ㈻㍠㑱㕣㙹㝿㡺㥾㨣㭦㱫㵠㹦㼨䁢䅤䉬䍬䑭䕥")));
      }
    }

    private void button114_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193E\u1A7D᭖ᰰᴳḺέ″")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u193E\u1A7D᭖ᰰᴳḺέ″")));
      }
    }

    private void button115_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᨷ\u1B4D᱓ᵡṺέ⁆")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u196Eᨷ\u1B4D᱓ᵡṺέ⁆")));
      }
    }

    private void button116_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤰᩑ᭕᱿ᵶṧὗ⁐")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᤰᩑ᭕᱿ᵶṧὗ⁐")));
      }
    }

    private void button111_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("'ĺȹ̼иհ٦ݧ࠵धਲ୪తഫี༨၊ᅜቈፏᑞᕈᙚ\u1757ᡙ\u1942ᩐ᭚᱇ᴜṒὟ⁂℁≧⍍⑊╋♈❉⡞⤔⨊⭩ⱂⵊ\u2E72⽃ねㅷ㉭㍨㑓㕯㙻㜷㡺㥷㩦㭠㱶㵠㸾㽑䁉䅝䈨䌾䐻䕘䙬䝥䡦䥵䩱䭡䱱䵧乥")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("'ĺȹ̼иհ٦ݧ࠵धਲ୪తഫี༨၊ᅜቈፏᑞᕈᙚ\u1757ᡙ\u1942ᩐ᭚᱇ᴜṒὟ⁂℁≧⍍⑊╋♈❉⡞⤔⨊⭩ⱂⵊ\u2E72⽃ねㅷ㉭㍨㑓㕯㙻㜷㡺㥷㩦㭠㱶㵠㸾㽑䁉䅝䈨䌾䐻䕘䙬䝥䡦䥵䩱䭡䱱䵧乥")));
      }
    }

    private void button110_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1942ᩉᭀ᱈ᴴṻὲ\u2063")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1942ᩉᭀ᱈ᴴṻὲ\u2063")));
      }
    }

    private void button112_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥋ᩥ᭐ᱭᵌṚὌ⁉")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ᥋ᩥ᭐ᱭᵌṚὌ⁉")));
      }
    }

    private void button109_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("-İȷ̲вպܑؐࡏढ़ੌଔ\u0C5E\u0D51ใཞ၀ᅖቆፁᑔᕂᙌᝁᡃᥘᩎ᭄ᱝᴆṄὉ⁈ℋ≠⍍\u2453╒♪❮⡩⤮⨭⬨Ⱜⴷ\u2E45⽳っㅵ㉾㍢㑢㔿㙢㝯㡤㥢㨤㭙㱹㵱㹏㽳䁧䄪䉯䍷䑠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("-İȷ̲вպܑؐࡏढ़ੌଔ\u0C5E\u0D51ใཞ၀ᅖቆፁᑔᕂᙌᝁᡃᥘᩎ᭄ᱝᴆṄὉ⁈ℋ≠⍍\u2453╒♪❮⡩⤮⨭⬨Ⱜⴷ\u2E45⽳っㅵ㉾㍢㑢㔿㙢㝯㡤㥢㨤㭙㱹㵱㹏㽳䁧䄪䉯䍷䑠")));
      }
    }

    private void button102_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1979ᩳᬶ᱆ᵲṚἻ\u2064")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u1979ᩳᬶ᱆ᵲṚἻ\u2064")));
      }
    }

    private void button108_Click(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥘ᩠᭔\u1C4BᵡṏὯ⁉")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥘ᩠᭔\u1C4BᵡṏὯ⁉")));
      }
    }

    private void button71_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("\"Ľȼ̷еտ٫ݬ࠰ठ\u0A37\u0B11ౙ\u0D54่ན၏ᅛቍፄᑓᕇᙗ\u175Cᡜ᥅ᩕᭁᱚᴃṏὄ⁇℆≢⍈\u2455╍♍❆⡥⥄⩍⭙ⱷ\u2D73\u2E78⽾とㄶ㉿㍢㑴㕲㙡㝱㠽㥼㩱㭦㱠㴢㹮㽮䁯䅺䉿䍦䑣䕨䙢䝱䡧䥤")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("\"Ľȼ̷еտ٫ݬ࠰ठ\u0A37\u0B11ౙ\u0D54่ན၏ᅛቍፄᑓᕇᙗ\u175Cᡜ᥅ᩕᭁᱚᴃṏὄ⁇℆≢⍈\u2455╍♍❆⡥⥄⩍⭙ⱷ\u2D73\u2E78⽾とㄶ㉿㍢㑴㕲㙡㝱㠽㥼㩱㭦㱠㴢㹮㽮䁯䅺䉿䍦䑣䕨䙢䝱䡧䥤")));
      }
    }

    private void button61_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᨴ᭯᱄ᵜṂὑ\u2073")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦᥒᨴ᭯᱄ᵜṂὑ\u2073")));
      }
    }

    private void button43_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≔⍀⑅╕♑❂⡒⥶⩮⭩Ɐⴴ\u2E69⽵〪ㅈ㉷㍠㑠㕼㙴㝰㡢㥢㨡㭠㱭㵢㹤㼦䁥䅦䉯䍫䐪䕯䙷䝠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(" ĳȲ̵зչ٭ݮ࠲फ़\u0A49ଓ\u0C5B\u0D52๎ད၍ᅕቃፆᑑᕁᙑ\u175Eᡞᥛᩋᭃ᱘ᴅṉ\u1F46⁅℈≔⍀⑅╕♑❂⡒⥶⩮⭩Ɐⴴ\u2E69⽵〪ㅈ㉷㍠㑠㕼㙴㝰㡢㥢㨡㭠㱭㵢㹤㼦䁥䅦䉯䍫䐪䕯䙷䝠")));
      }
    }

    private void button33_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Bᩢ᭶ᱫᴼḻὊ⁘")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("IŔɫͮѮԦشܵ\u0869ॹ\u0A64ୢ\u0C70\u0D76\u0E7Aོဿᅳበ፣ᐢᕾᙪ\u177Dᠦ\u197Bᩢ᭶ᱫᴼḻὊ⁘")));
      }
    }

    private void button30_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("$ĿȾ̹лս٩ݪ࠶ढਵ୯ధ\u0D56๊ཕ၉ᅙ\u124Fፊᑝᕅᙕ\u175Aᡚ᥇ᩗ᭟᱄ᴁṍὂ⁁℄≹⍀⑆╔♅❗⡍⥓⩑⬎ⱒ⵰\u2E7C⽱びㅣ㈷㍪㑻㕥㙿㝥㡠㥠㨽㭼㱱㵦㹠㼢䁿䅾䉸䍯䑠䕦䙾䝽䠪䥯䩷䭠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F("$ĿȾ̹лս٩ݪ࠶ढਵ୯ధ\u0D56๊ཕ၉ᅙ\u124Fፊᑝᕅᙕ\u175Aᡚ᥇ᩗ᭟᱄ᴁṍὂ⁁℄≹⍀⑆╔♅❗⡍⥓⩑⬎ⱒ⵰\u2E7C⽱びㅣ㈷㍪㑻㕥㙿㝥㡠㥠㨽㭼㱱㵦㹠㼢䁿䅾䉸䍯䑠䕦䙾䝽䠪䥯䩷䭠")));
      }
    }

    private void label9_Click(object sender, EventArgs e)
    {
    }

    private void label9_Click_1(object sender, EventArgs e)
    {
    }

    private void label9_Click_2(object sender, EventArgs e)
    {
    }

    private void button87_Click_1(object sender, EventArgs e)
    {
      if (this.WRDButton.Checked)
      {
        this.api.SendLuaScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(":ĥȤ̿нշ٣ݤ࠸नਿ୩డബะ\u0F2B့ᄣስፌᑛᕏᙟ\u1754ᡔ᥍ᩝ᭙᱂ᴛṗ\u1F5C ℞≲⍣\u246F╮♧❬⡫⥤⩭\u2B75Ⱇⴗ⸖⼒」ㅱ㉅㍫㐳㕎㙵㝶㡯㥵㩹㭣㱹㵧㸹㽋䀽䅼䉱䍦䑠䔢䙎䝀䠯䤻䨸䭗䱣䵱个佯偷兠")));
      }
      else
      {
        if (!this.EXButton.Checked)
          return;
        this.module.ExecuteScript(new WebClient().DownloadString(\u003F0\u003F.\u003F1\u003F(":ĥȤ̿нշ٣ݤ࠸नਿ୩డബะ\u0F2B့ᄣስፌᑛᕏᙟ\u1754ᡔ᥍ᩝ᭙᱂ᴛṗ\u1F5C ℞≲⍣\u246F╮♧❬⡫⥤⩭\u2B75Ⱇⴗ⸖⼒」ㅱ㉅㍫㐳㕎㙵㝶㡯㥵㩹㭣㱹㵧㸹㽋䀽䅼䉱䍦䑠䔢䙎䝀䠯䤻䨸䭗䱣䵱个佯偷兠")));
      }
    }

    private void label30_Click(object sender, EventArgs e)
    {
    }

    private void label9_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void label9_MouseDown(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void label9_MouseDown_1(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void label9_MouseMove_1(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void label9_MouseDown_2(object sender, MouseEventArgs e) => this.lastPoint = new Point(e.X, e.Y);

    private void label9_MouseMove_2(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      this.Left += e.X - this.lastPoint.X;
      this.Top += e.Y - this.lastPoint.Y;
    }

    private void WRDButton_CheckedChanged(object sender, EventArgs e)
    {
    }

    private void EXButton_CheckedChanged(object sender, EventArgs e)
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ScriptHub));
      this.panel1 = new Panel();
      this.EXButton = new RadioButton();
      this.WRDButton = new RadioButton();
      this.label9 = new Label();
      this.label10 = new Label();
      this.button107 = new Button();
      this.button2 = new Button();
      this.panel2 = new Panel();
      this.label1 = new Label();
      this.button6 = new Button();
      this.button8 = new Button();
      this.button12 = new Button();
      this.button14 = new Button();
      this.label3 = new Label();
      this.button3 = new Button();
      this.button4 = new Button();
      this.button15 = new Button();
      this.button7 = new Button();
      this.button9 = new Button();
      this.button11 = new Button();
      this.button13 = new Button();
      this.button16 = new Button();
      this.button17 = new Button();
      this.button5 = new Button();
      this.button10 = new Button();
      this.button18 = new Button();
      this.label4 = new Label();
      this.button19 = new Button();
      this.button20 = new Button();
      this.button22 = new Button();
      this.button23 = new Button();
      this.button21 = new Button();
      this.button24 = new Button();
      this.button25 = new Button();
      this.button26 = new Button();
      this.button27 = new Button();
      this.button28 = new Button();
      this.button29 = new Button();
      this.button31 = new Button();
      this.button32 = new Button();
      this.button34 = new Button();
      this.button35 = new Button();
      this.label2 = new Label();
      this.panel4 = new Panel();
      this.panel5 = new Panel();
      this.label5 = new Label();
      this.button41 = new Button();
      this.button36 = new Button();
      this.button37 = new Button();
      this.button39 = new Button();
      this.button40 = new Button();
      this.button42 = new Button();
      this.button44 = new Button();
      this.button45 = new Button();
      this.button46 = new Button();
      this.button47 = new Button();
      this.button48 = new Button();
      this.button49 = new Button();
      this.button50 = new Button();
      this.button38 = new Button();
      this.button51 = new Button();
      this.button52 = new Button();
      this.button53 = new Button();
      this.button54 = new Button();
      this.button55 = new Button();
      this.button56 = new Button();
      this.button57 = new Button();
      this.button58 = new Button();
      this.button59 = new Button();
      this.button60 = new Button();
      this.button62 = new Button();
      this.panel6 = new Panel();
      this.label6 = new Label();
      this.button63 = new Button();
      this.button64 = new Button();
      this.button65 = new Button();
      this.button66 = new Button();
      this.button67 = new Button();
      this.button72 = new Button();
      this.button68 = new Button();
      this.button69 = new Button();
      this.button70 = new Button();
      this.button73 = new Button();
      this.button74 = new Button();
      this.button75 = new Button();
      this.button76 = new Button();
      this.button77 = new Button();
      this.button78 = new Button();
      this.button79 = new Button();
      this.button80 = new Button();
      this.button81 = new Button();
      this.button82 = new Button();
      this.button83 = new Button();
      this.button84 = new Button();
      this.button85 = new Button();
      this.button86 = new Button();
      this.button88 = new Button();
      this.button89 = new Button();
      this.button90 = new Button();
      this.button91 = new Button();
      this.button92 = new Button();
      this.button93 = new Button();
      this.button94 = new Button();
      this.button95 = new Button();
      this.button96 = new Button();
      this.button97 = new Button();
      this.button98 = new Button();
      this.button99 = new Button();
      this.button100 = new Button();
      this.button101 = new Button();
      this.button103 = new Button();
      this.button104 = new Button();
      this.panel7 = new Panel();
      this.label7 = new Label();
      this.button105 = new Button();
      this.button106 = new Button();
      this.panel8 = new Panel();
      this.button1 = new Button();
      this.button30 = new Button();
      this.button33 = new Button();
      this.button43 = new Button();
      this.button61 = new Button();
      this.button71 = new Button();
      this.button102 = new Button();
      this.button108 = new Button();
      this.button109 = new Button();
      this.button110 = new Button();
      this.button111 = new Button();
      this.button112 = new Button();
      this.button113 = new Button();
      this.button114 = new Button();
      this.button115 = new Button();
      this.button116 = new Button();
      this.label8 = new Label();
      this.button87 = new Button();
      this.panel3 = new Panel();
      this.label11 = new Label();
      this.label13 = new Label();
      this.label15 = new Label();
      this.label16 = new Label();
      this.label18 = new Label();
      this.label23 = new Label();
      this.label24 = new Label();
      this.label25 = new Label();
      this.label26 = new Label();
      this.label27 = new Label();
      this.label28 = new Label();
      this.label29 = new Label();
      this.label30 = new Label();
      this.label33 = new Label();
      this.label34 = new Label();
      this.label36 = new Label();
      this.label37 = new Label();
      this.label38 = new Label();
      this.label40 = new Label();
      this.label12 = new Label();
      this.label41 = new Label();
      this.label17 = new Label();
      this.label19 = new Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.panel1.BackColor = Color.FromArgb(60, 60, 60);
      this.panel1.Controls.Add((Control) this.EXButton);
      this.panel1.Controls.Add((Control) this.WRDButton);
      this.panel1.Controls.Add((Control) this.label9);
      this.panel1.Controls.Add((Control) this.label10);
      this.panel1.Controls.Add((Control) this.button107);
      this.panel1.Controls.Add((Control) this.button2);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮ\u0530");
      this.panel1.Size = new Size(1237, 40);
      this.panel1.TabIndex = 0;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.EXButton.AutoSize = true;
      this.EXButton.Location = new Point(133, 12);
      this.EXButton.Name = \u003F0\u003F.\u003F1\u003F("MşɄͰѰշ٭ݯ");
      this.EXButton.Size = new Size(59, 17);
      this.EXButton.TabIndex = 19;
      this.EXButton.TabStop = true;
      this.EXButton.Text = \u003F0\u003F.\u003F1\u003F("CŝȤ͂ђՈ");
      this.EXButton.UseVisualStyleBackColor = true;
      this.EXButton.CheckedChanged += new EventHandler(this.EXButton_CheckedChanged);
      this.WRDButton.AutoSize = true;
      this.WRDButton.Location = new Point(57, 12);
      this.WRDButton.Name = \u003F0\u003F.\u003F1\u003F("^ŚɃ̈́Ѱհٷݭ\u086F");
      this.WRDButton.Size = new Size(72, 17);
      this.WRDButton.TabIndex = 17;
      this.WRDButton.TabStop = true;
      this.WRDButton.Text = \u003F0\u003F.\u003F1\u003F("PŔɁ̤тՒو");
      this.WRDButton.UseVisualStyleBackColor = true;
      this.WRDButton.CheckedChanged += new EventHandler(this.WRDButton_CheckedChanged);
      this.label9.AutoSize = true;
      this.label9.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label9.ForeColor = SystemColors.Window;
      this.label9.Location = new Point(964, 9);
      this.label9.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԸ");
      this.label9.Size = new Size(178, 21);
      this.label9.TabIndex = 16;
      this.label9.Text = \u003F0\u003F.\u003F1\u003F("(ĴɝͷѦռٶܮࡌ२੯୯౭ന๔ཥၷᅭታ\u1376ᑲ");
      this.label9.MouseDown += new MouseEventHandler(this.label9_MouseDown_2);
      this.label9.MouseMove += new MouseEventHandler(this.label9_MouseMove_2);
      this.label10.AutoSize = true;
      this.label10.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label10.ForeColor = Color.Red;
      this.label10.Location = new Point(928, 5);
      this.label10.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳر");
      this.label10.Size = new Size(43, 30);
      this.label10.TabIndex = 15;
      this.label10.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.button107.BackColor = Color.FromArgb(60, 60, 60);
      this.button107.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button107.FlatStyle = FlatStyle.Flat;
      this.button107.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button107.ForeColor = SystemColors.ControlLightLight;
      this.button107.Location = new Point(1200, 6);
      this.button107.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠶");
      this.button107.Size = new Size(30, 27);
      this.button107.TabIndex = 13;
      this.button107.Text = \u003F0\u003F.\u003F1\u003F("Y");
      this.button107.UseVisualStyleBackColor = false;
      this.button107.Click += new EventHandler(this.button107_Click);
      this.button2.BackColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Yźɱͣѿռ١ݫ\u0878फਖ਼୨౦\u0D74ฦབၡᅱቫ፧"), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.button2.ForeColor = SystemColors.ControlLightLight;
      this.button2.Location = new Point(1167, 6);
      this.button2.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլس");
      this.button2.Size = new Size(30, 27);
      this.button2.TabIndex = 12;
      this.button2.Text = \u003F0\u003F.\u003F1\u003F("―");
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.panel2.BackColor = Color.Transparent;
      this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F("fŴɺͶѾԣؾݍ\u086F८੧୬\u0C78൦\u0E7Dཀྵၢᅌቩ።ᑥᕤ"));
      this.panel2.BackgroundImageLayout = ImageLayout.Zoom;
      this.panel2.Location = new Point(1, 0);
      this.panel2.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԳ");
      this.panel2.Size = new Size(48, 40);
      this.panel2.TabIndex = 11;
      this.panel2.Paint += new PaintEventHandler(this.panel2_Paint);
      this.label1.AutoSize = true;
      this.label1.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.ForeColor = SystemColors.Window;
      this.label1.Location = new Point(498, 8);
      this.label1.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮ\u0530");
      this.label1.Size = new Size(210, 21);
      this.label1.TabIndex = 4;
      this.label1.Text = \u003F0\u003F.\u003F1\u003F("Jžɽ\u0378иՏضܸ࠴ीੱୣ\u0C79ൿ\u0E7A\u0F2D၄ᅾቨጩᑴᔧᙖᝤᡣᥦᨢᬰ");
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new MouseEventHandler(this.label1_MouseMove);
      this.button6.BackColor = Color.FromArgb(65, 65, 65);
      this.button6.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.ForeColor = SystemColors.Control;
      this.button6.Location = new Point(11, 88);
      this.button6.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլط");
      this.button6.Size = new Size(142, 30);
      this.button6.TabIndex = 21;
      this.button6.Text = \u003F0\u003F.\u003F1\u003F("^Ťɪ\u0378ѢՊٮݲ\u0860त\u0A44ୗై");
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_Click);
      this.button8.BackColor = Color.FromArgb(65, 65, 65);
      this.button8.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button8.FlatStyle = FlatStyle.Flat;
      this.button8.ForeColor = SystemColors.Control;
      this.button8.Location = new Point(1070, 440);
      this.button8.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլع");
      this.button8.Size = new Size(142, 30);
      this.button8.TabIndex = 23;
      this.button8.Text = \u003F0\u003F.\u003F1\u003F("[ŸɠͻѨըإ݈\u086A।\u0A64");
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new EventHandler(this.button8_Click);
      this.button12.BackColor = Color.FromArgb(65, 65, 65);
      this.button12.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button12.FlatStyle = FlatStyle.Flat;
      this.button12.ForeColor = SystemColors.Control;
      this.button12.Location = new Point(11, 122);
      this.button12.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܳ");
      this.button12.Size = new Size(142, 51);
      this.button12.TabIndex = 27;
      this.button12.Text = \u003F0\u003F.\u003F1\u003F("YŸɶͰѨդٳ࡙ܵ०\u0A60\u0B75\u0C75ൽฮཀၵᅸቾ\u136Cᑺᕾᘦ\u1737ᠤ᥄ᩗᭈ");
      this.button12.UseVisualStyleBackColor = false;
      this.button12.Click += new EventHandler(this.button12_Click);
      this.button14.BackColor = Color.FromArgb(65, 65, 65);
      this.button14.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button14.FlatStyle = FlatStyle.Flat;
      this.button14.ForeColor = SystemColors.Control;
      this.button14.Location = new Point(11, 209);
      this.button14.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܵ");
      this.button14.Size = new Size(142, 30);
      this.button14.TabIndex = 29;
      this.button14.Text = \u003F0\u003F.\u003F1\u003F("Uųɰ̴рեٰݢ\u0862मਫ਼\u0B65౦ൿ\u0E65ཀྵၳᅩቷጤᑄᕗᙈ");
      this.button14.UseVisualStyleBackColor = false;
      this.button14.Click += new EventHandler(this.button14_Click);
      this.label3.AutoSize = true;
      this.label3.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.ForeColor = SystemColors.Control;
      this.label3.Location = new Point(212, 51);
      this.label3.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԲ");
      this.label3.Size = new Size(91, 25);
      this.label3.TabIndex = 32;
      this.label3.Text = \u003F0\u003F.\u003F1\u003F("\\ŦɮͰѠնٰݣ\u086D");
      this.button3.BackColor = Color.FromArgb(65, 65, 65);
      this.button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = SystemColors.Control;
      this.button3.Location = new Point(11, 308);
      this.button3.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլز");
      this.button3.Size = new Size(142, 30);
      this.button3.TabIndex = 34;
      this.button3.Text = \u003F0\u003F.\u003F1\u003F("MżɢͧѮդة݊\u0868२\u0A60\u0B77ణോ๗");
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.button3_Click_1);
      this.button4.BackColor = Color.FromArgb(65, 65, 65);
      this.button4.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = SystemColors.Control;
      this.button4.Location = new Point(529, 539);
      this.button4.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլص");
      this.button4.Size = new Size(142, 30);
      this.button4.TabIndex = 35;
      this.button4.Text = \u003F0\u003F.\u003F1\u003F("DŠɫͯѹթٯܪ࡙ॡ\u0A60ୡ\u0C7Cതไབྷ၈");
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_Click_1);
      this.button15.BackColor = Color.FromArgb(65, 65, 65);
      this.button15.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button15.FlatStyle = FlatStyle.Flat;
      this.button15.ForeColor = SystemColors.Control;
      this.button15.Location = new Point(183, 440);
      this.button15.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܴ");
      this.button15.Size = new Size(142, 30);
      this.button15.TabIndex = 41;
      this.button15.Text = \u003F0\u003F.\u003F1\u003F("\\ŉɋ̷їռٹݱ\u087D॥ਰ\u0B73మപไ\u0F2Cဦᄩሯፍᐡᔩᘤᜤᡗᤦ");
      this.button15.UseVisualStyleBackColor = false;
      this.button15.Click += new EventHandler(this.button15_Click);
      this.button7.BackColor = Color.FromArgb(65, 65, 65);
      this.button7.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button7.FlatStyle = FlatStyle.Flat;
      this.button7.ForeColor = SystemColors.Control;
      this.button7.Location = new Point(183, 308);
      this.button7.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլض");
      this.button7.Size = new Size(142, 30);
      this.button7.TabIndex = 43;
      this.button7.Text = \u003F0\u003F.\u003F1\u003F("VŠɡ;бԻدݍ\u0861॥੨ୡ\u0C29\u0D5C\u0E62ཪၠᅴቬ\u1370ᑵ");
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new EventHandler(this.button7_Click);
      this.button9.BackColor = Color.FromArgb(65, 65, 65);
      this.button9.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button9.FlatStyle = FlatStyle.Flat;
      this.button9.ForeColor = SystemColors.Control;
      this.button9.Location = new Point(183, 176);
      this.button9.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլظ");
      this.button9.Size = new Size(142, 30);
      this.button9.TabIndex = 44;
      this.button9.Text = \u003F0\u003F.\u003F1\u003F("TŽɩ̯Сԭيݧ\u0865२\u0A7Cଧౕ൦\u0E76ཪၲᅵ");
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new EventHandler(this.button9_Click);
      this.button11.BackColor = Color.FromArgb(65, 65, 65);
      this.button11.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button11.FlatStyle = FlatStyle.Flat;
      this.button11.ForeColor = SystemColors.Control;
      this.button11.Location = new Point(183, 242);
      this.button11.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܰ");
      this.button11.Size = new Size(142, 30);
      this.button11.TabIndex = 45;
      this.button11.Text = \u003F0\u003F.\u003F1\u003F("BŤɩͥѡշئݹࠤत\u0A53ଦ");
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new EventHandler(this.button11_Click);
      this.button13.BackColor = Color.FromArgb(65, 65, 65);
      this.button13.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button13.FlatStyle = FlatStyle.Flat;
      this.button13.ForeColor = SystemColors.Control;
      this.button13.Location = new Point(708, 407);
      this.button13.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܲ");
      this.button13.Size = new Size(142, 30);
      this.button13.TabIndex = 46;
      this.button13.Text = \u003F0\u003F.\u003F1\u003F("_ŧɼͲѪռحݘ\u0872३੦୧౩ദื༤၄ᅗቈ");
      this.button13.UseVisualStyleBackColor = false;
      this.button13.Click += new EventHandler(this.button13_Click);
      this.button16.BackColor = Color.FromArgb(65, 65, 65);
      this.button16.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button16.FlatStyle = FlatStyle.Flat;
      this.button16.ForeColor = SystemColors.Control;
      this.button16.Location = new Point(183, 88);
      this.button16.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܷ");
      this.button16.Size = new Size(142, 30);
      this.button16.TabIndex = 47;
      this.button16.Text = \u003F0\u003F.\u003F1\u003F("TŔȰ͆Ѡջ٥ݸ\u0863५\u0A64ୢద൹ฤ༤၇ᄦ");
      this.button16.UseVisualStyleBackColor = false;
      this.button16.Click += new EventHandler(this.button16_Click);
      this.button17.BackColor = Color.FromArgb(65, 65, 65);
      this.button17.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button17.FlatStyle = FlatStyle.Flat;
      this.button17.ForeColor = SystemColors.Control;
      this.button17.Location = new Point(183, 275);
      this.button17.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܶ");
      this.button17.Size = new Size(142, 30);
      this.button17.TabIndex = 48;
      this.button17.Text = \u003F0\u003F.\u003F1\u003F("TŃɟ̮фբثݏ\u087F७ੵ\u0B7Fథൃ\u0E62\u0F6Fၤ");
      this.button17.UseVisualStyleBackColor = false;
      this.button17.Click += new EventHandler(this.button17_Click);
      this.button5.BackColor = Color.FromArgb(65, 65, 65);
      this.button5.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = SystemColors.Control;
      this.button5.Location = new Point(183, 122);
      this.button5.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլش");
      this.button5.Size = new Size(142, 51);
      this.button5.TabIndex = 49;
      this.button5.Text = \u003F0\u003F.\u003F1\u003F("VŰɻ͵ѵճ٭ݽ࠷ॏ\u0A7Cୱ౿\u0D76ัཬုᅏቩ፡ᑢᕤᘩᝋᡨᥫᩨ᭥ᱭᵦṲ");
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_Click);
      this.button10.BackColor = Color.FromArgb(65, 65, 65);
      this.button10.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button10.FlatStyle = FlatStyle.Flat;
      this.button10.ForeColor = SystemColors.Control;
      this.button10.Location = new Point(358, 122);
      this.button10.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܱ");
      this.button10.Size = new Size(142, 51);
      this.button10.TabIndex = 25;
      this.button10.Text = \u003F0\u003F.\u003F1\u003F("gŭɰ̆ѤՖِ݇ࡏुੳାౚ\u0D49๒༺ၥᄸቜ\u137Fᑹᕸᘳᝓ\u187D\u197Cᨣᬮ\u1C4CᵥṦὨ\u2066ⅼ∫⌦⑀╗♓✢⡽");
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new EventHandler(this.button10_Click);
      this.button18.BackColor = Color.FromArgb(65, 65, 65);
      this.button18.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button18.FlatStyle = FlatStyle.Flat;
      this.button18.ForeColor = SystemColors.Control;
      this.button18.Location = new Point(708, 374);
      this.button18.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܹ");
      this.button18.Size = new Size(142, 30);
      this.button18.TabIndex = 50;
      this.button18.Text = \u003F0\u003F.\u003F1\u003F("CŧɯͿѧթ٣ݽ\u086Dधੁ\u0B50్ണม\u0F33");
      this.button18.UseVisualStyleBackColor = false;
      this.button18.Click += new EventHandler(this.button18_Click);
      this.label4.AutoSize = true;
      this.label4.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.ForeColor = SystemColors.Control;
      this.label4.Location = new Point(47, 51);
      this.label4.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԵ");
      this.label4.Size = new Size(70, 25);
      this.label4.TabIndex = 51;
      this.label4.Text = \u003F0\u003F.\u003F1\u003F("BťɮͧѲ");
      this.button19.BackColor = Color.FromArgb(65, 65, 65);
      this.button19.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button19.FlatStyle = FlatStyle.Flat;
      this.button19.ForeColor = SystemColors.Control;
      this.button19.Location = new Point(183, 341);
      this.button19.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխسܸ");
      this.button19.Size = new Size(142, 30);
      this.button19.TabIndex = 53;
      this.button19.Text = \u003F0\u003F.\u003F1\u003F("FŠɻͥѸգ٫ݤ\u0862द\u0A43୨౪൬\u0E66");
      this.button19.UseVisualStyleBackColor = false;
      this.button19.Click += new EventHandler(this.button19_Click);
      this.button20.BackColor = Color.FromArgb(65, 65, 65);
      this.button20.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button20.FlatStyle = FlatStyle.Flat;
      this.button20.ForeColor = SystemColors.Control;
      this.button20.Location = new Point(11, 341);
      this.button20.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܱ");
      this.button20.Size = new Size(142, 30);
      this.button20.TabIndex = 54;
      this.button20.Text = \u003F0\u003F.\u003F1\u003F("Rźɧ͡Ѩԫًܩࡊ२੧ୱతൄ๗\u0F48");
      this.button20.UseVisualStyleBackColor = false;
      this.button20.Click += new EventHandler(this.button20_Click);
      this.button22.BackColor = Color.FromArgb(65, 65, 65);
      this.button22.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button22.FlatStyle = FlatStyle.Flat;
      this.button22.ForeColor = SystemColors.Control;
      this.button22.Location = new Point(11, 407);
      this.button22.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܳ");
      this.button22.Size = new Size(142, 30);
      this.button22.TabIndex = 56;
      this.button22.Text = \u003F0\u003F.\u003F1\u003F("]ŹɩͺѤբ٬ܪ࡚ॡ੪\u0B73౩\u0D65\u0E77\u0F6Dၳ");
      this.button22.UseVisualStyleBackColor = false;
      this.button22.Click += new EventHandler(this.button22_Click);
      this.button23.BackColor = Color.FromArgb(65, 65, 65);
      this.button23.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button23.FlatStyle = FlatStyle.Flat;
      this.button23.ForeColor = SystemColors.Control;
      this.button23.Location = new Point(183, 374);
      this.button23.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܲ");
      this.button23.Size = new Size(142, 30);
      this.button23.TabIndex = 57;
      this.button23.Text = \u003F0\u003F.\u003F1\u003F("^ũɳͷѿԷٗݹ\u0878ळੂ\u0B7D\u0C71\u0D76\u0E6Bཿၿᄫቶጩᐯᕁᘡᜩᠤᤤᩐᬦ");
      this.button23.UseVisualStyleBackColor = false;
      this.button23.Click += new EventHandler(this.button23_Click);
      this.button21.BackColor = Color.FromArgb(65, 65, 65);
      this.button21.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button21.FlatStyle = FlatStyle.Flat;
      this.button21.ForeColor = SystemColors.Control;
      this.button21.Location = new Point(11, 374);
      this.button21.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܰ");
      this.button21.Size = new Size(142, 30);
      this.button21.TabIndex = 58;
      this.button21.Text = \u003F0\u003F.\u003F1\u003F("QŧɸͼѫԮٌܬࡉ॥੨\u0B7Cధു๐ཌྷဣᄡሳ");
      this.button21.UseVisualStyleBackColor = false;
      this.button21.Click += new EventHandler(this.button21_Click);
      this.button24.BackColor = Color.FromArgb(65, 65, 65);
      this.button24.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button24.FlatStyle = FlatStyle.Flat;
      this.button24.ForeColor = SystemColors.Control;
      this.button24.Location = new Point(183, 407);
      this.button24.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܵ");
      this.button24.Size = new Size(142, 30);
      this.button24.TabIndex = 59;
      this.button24.Text = \u003F0\u003F.\u003F1\u003F("Bŵɿ\u0379т\u0560٪ݫ\u0869बਠପృൽ\u0E6Aྲྀၕᅫቴ፧ᑳ");
      this.button24.UseVisualStyleBackColor = false;
      this.button24.Click += new EventHandler(this.button24_Click);
      this.button25.BackColor = Color.FromArgb(65, 65, 65);
      this.button25.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button25.FlatStyle = FlatStyle.Flat;
      this.button25.ForeColor = SystemColors.Control;
      this.button25.Location = new Point(358, 407);
      this.button25.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܴ");
      this.button25.Size = new Size(142, 30);
      this.button25.TabIndex = 70;
      this.button25.Text = \u003F0\u003F.\u003F1\u003F("EťɯͯЩՉ٩ݢࠥॗ੦୧౪");
      this.button25.UseVisualStyleBackColor = false;
      this.button25.Click += new EventHandler(this.button25_Click);
      this.button26.BackColor = Color.FromArgb(65, 65, 65);
      this.button26.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button26.FlatStyle = FlatStyle.Flat;
      this.button26.ForeColor = SystemColors.Control;
      this.button26.Location = new Point(358, 374);
      this.button26.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܷ");
      this.button26.Size = new Size(142, 30);
      this.button26.TabIndex = 69;
      this.button26.Text = \u003F0\u003F.\u003F1\u003F("Užɸ;ѨԮٝݠ\u086Aॳ੬\u0B7Aధ\u0D55\u0E66ྲྀၪᅲት");
      this.button26.UseVisualStyleBackColor = false;
      this.button26.Click += new EventHandler(this.button26_Click);
      this.button27.BackColor = Color.FromArgb(65, 65, 65);
      this.button27.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button27.FlatStyle = FlatStyle.Flat;
      this.button27.ForeColor = SystemColors.Control;
      this.button27.Location = new Point(358, 341);
      this.button27.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܶ");
      this.button27.Size = new Size(142, 30);
      this.button27.TabIndex = 68;
      this.button27.Text = \u003F0\u003F.\u003F1\u003F("DŧɣͫЫՆ٬ݯ\u0866॥\u0A7Cତౄൗ่");
      this.button27.UseVisualStyleBackColor = false;
      this.button27.Click += new EventHandler(this.button27_Click);
      this.button28.BackColor = Color.FromArgb(65, 65, 65);
      this.button28.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button28.FlatStyle = FlatStyle.Flat;
      this.button28.ForeColor = SystemColors.Control;
      this.button28.Location = new Point(358, 88);
      this.button28.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܹ");
      this.button28.Size = new Size(142, 30);
      this.button28.TabIndex = 67;
      this.button28.Text = \u003F0\u003F.\u003F1\u003F("YŹɿ\u0378ѱԳٔݸ\u0877१\u0A7A୨\u0C7E\u0D78สཚၡᅪታ\u1369ᑥᕷ᙭ᝳ");
      this.button28.UseVisualStyleBackColor = false;
      this.button28.Click += new EventHandler(this.button28_Click);
      this.button29.BackColor = Color.FromArgb(65, 65, 65);
      this.button29.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button29.FlatStyle = FlatStyle.Flat;
      this.button29.ForeColor = SystemColors.Control;
      this.button29.Location = new Point(358, 506);
      this.button29.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխذܸ");
      this.button29.Size = new Size(142, 30);
      this.button29.TabIndex = 66;
      this.button29.Text = \u003F0\u003F.\u003F1\u003F("Sŋɉ̧ѕզٶݪ\u0872ॵ");
      this.button29.UseVisualStyleBackColor = false;
      this.button29.Click += new EventHandler(this.button29_Click);
      this.button31.BackColor = Color.FromArgb(65, 65, 65);
      this.button31.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button31.FlatStyle = FlatStyle.Flat;
      this.button31.ForeColor = SystemColors.Control;
      this.button31.Location = new Point(358, 176);
      this.button31.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܰ");
      this.button31.Size = new Size(142, 30);
      this.button31.TabIndex = 64;
      this.button31.Text = \u003F0\u003F.\u003F1\u003F("LŶɾ͠Ѱզ٠ݳ\u087Dरੇ୧\u0C79൮\u0E64ིဩᅍቿ\u1376ᑤᕪᙧᝧᡳ");
      this.button31.UseVisualStyleBackColor = false;
      this.button31.Click += new EventHandler(this.button31_Click);
      this.button32.BackColor = Color.FromArgb(65, 65, 65);
      this.button32.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button32.FlatStyle = FlatStyle.Flat;
      this.button32.ForeColor = SystemColors.Control;
      this.button32.Location = new Point(358, 242);
      this.button32.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܳ");
      this.button32.Size = new Size(142, 30);
      this.button32.TabIndex = 63;
      this.button32.Text = \u003F0\u003F.\u003F1\u003F("_şȮ͇ѭբ٦ݫ\u087Aॢ੧୮తൄ๗\u0F48");
      this.button32.UseVisualStyleBackColor = false;
      this.button32.Click += new EventHandler(this.button32_Click);
      this.button34.BackColor = Color.FromArgb(65, 65, 65);
      this.button34.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button34.FlatStyle = FlatStyle.Flat;
      this.button34.ForeColor = SystemColors.Control;
      this.button34.Location = new Point(358, 308);
      this.button34.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܵ");
      this.button34.Size = new Size(142, 30);
      this.button34.TabIndex = 61;
      this.button34.Text = \u003F0\u003F.\u003F1\u003F("\\ŪɩͨѢկٹܩࡇॡਦୖ\u0C74൦\u0E67ཥ");
      this.button34.UseVisualStyleBackColor = false;
      this.button34.Click += new EventHandler(this.button34_Click);
      this.button35.BackColor = Color.FromArgb(65, 65, 65);
      this.button35.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button35.FlatStyle = FlatStyle.Flat;
      this.button35.ForeColor = SystemColors.Control;
      this.button35.Location = new Point(358, 209);
      this.button35.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܴ");
      this.button35.Size = new Size(142, 30);
      this.button35.TabIndex = 60;
      this.button35.Text = \u003F0\u003F.\u003F1\u003F("@žɩ͢ѱԧلݩ\u086Bॠ੩\u0B72");
      this.button35.UseVisualStyleBackColor = false;
      this.button35.Click += new EventHandler(this.button35_Click);
      this.label2.AutoSize = true;
      this.label2.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.ForeColor = SystemColors.Control;
      this.label2.Location = new Point(391, 51);
      this.label2.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԳ");
      this.label2.Size = new Size(70, 25);
      this.label2.TabIndex = 71;
      this.label2.Text = \u003F0\u003F.\u003F1\u003F("BťɮͧѲ");
      this.panel4.BackColor = Color.Transparent;
      this.panel4.BorderStyle = BorderStyle.FixedSingle;
      this.panel4.ForeColor = SystemColors.ControlLightLight;
      this.panel4.Location = new Point(333, 87);
      this.panel4.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԵ");
      this.panel4.Size = new Size(19, 548);
      this.panel4.TabIndex = 72;
      this.panel5.BackColor = Color.Transparent;
      this.panel5.BorderStyle = BorderStyle.FixedSingle;
      this.panel5.ForeColor = SystemColors.ControlLightLight;
      this.panel5.Location = new Point(509, 87);
      this.panel5.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԴ");
      this.panel5.Size = new Size(13, 550);
      this.panel5.TabIndex = 73;
      this.label5.AutoSize = true;
      this.label5.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.ForeColor = SystemColors.Control;
      this.label5.Location = new Point(574, 52);
      this.label5.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԴ");
      this.label5.Size = new Size(57, 25);
      this.label5.TabIndex = 84;
      this.label5.Text = \u003F0\u003F.\u003F1\u003F("Hŭɰ͡Я");
      this.label5.Click += new EventHandler(this.label5_Click);
      this.button41.BackColor = Color.FromArgb(65, 65, 65);
      this.button41.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button41.FlatStyle = FlatStyle.Flat;
      this.button41.ForeColor = SystemColors.Control;
      this.button41.Location = new Point(529, 242);
      this.button41.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܰ");
      this.button41.Size = new Size(142, 30);
      this.button41.TabIndex = 90;
      this.button41.Text = \u003F0\u003F.\u003F1\u003F("Mŏɏ͊џԪوݽ\u0873३ਨୂౢ\u0D70\u0E6C");
      this.button41.UseVisualStyleBackColor = false;
      this.button41.Click += new EventHandler(this.button41_Click);
      this.button36.BackColor = Color.FromArgb(65, 65, 65);
      this.button36.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button36.FlatStyle = FlatStyle.Flat;
      this.button36.ForeColor = SystemColors.Control;
      this.button36.Location = new Point(529, 209);
      this.button36.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܷ");
      this.button36.Size = new Size(142, 30);
      this.button36.TabIndex = 91;
      this.button36.Text = \u003F0\u003F.\u003F1\u003F("WŹɣͣѧյٿܲࡕॹ\u0A7C୯\u0C7E\u0D78\u0E6Eླྀဩᅛቲ\u1374ᑳᕭᙵᝣᡭ");
      this.button36.UseVisualStyleBackColor = false;
      this.button36.Click += new EventHandler(this.button36_Click);
      this.button37.BackColor = Color.FromArgb(65, 65, 65);
      this.button37.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button37.FlatStyle = FlatStyle.Flat;
      this.button37.ForeColor = SystemColors.Control;
      this.button37.Location = new Point(529, 341);
      this.button37.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܶ");
      this.button37.Size = new Size(142, 30);
      this.button37.TabIndex = 92;
      this.button37.Text = \u003F0\u003F.\u003F1\u003F("Yļɛ́кՃاݐ࠱पਲ਼ବఱ");
      this.button37.UseVisualStyleBackColor = false;
      this.button37.Click += new EventHandler(this.button37_Click);
      this.button39.BackColor = Color.FromArgb(65, 65, 65);
      this.button39.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button39.FlatStyle = FlatStyle.Flat;
      this.button39.ForeColor = SystemColors.Control;
      this.button39.Location = new Point(888, 473);
      this.button39.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܸ");
      this.button39.Size = new Size(142, 30);
      this.button39.TabIndex = 94;
      this.button39.Text = \u003F0\u003F.\u003F1\u003F("[űɦ͢ѯվٮݫ\u0862न\u0A43୯\u0C64൩\u0E6Cཬၥ");
      this.button39.UseVisualStyleBackColor = false;
      this.button39.Click += new EventHandler(this.button39_Click_1);
      this.button40.BackColor = Color.FromArgb(65, 65, 65);
      this.button40.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button40.FlatStyle = FlatStyle.Flat;
      this.button40.ForeColor = SystemColors.Control;
      this.button40.Location = new Point(529, 88);
      this.button40.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܱ");
      this.button40.Size = new Size(142, 30);
      this.button40.TabIndex = 95;
      this.button40.Text = \u003F0\u003F.\u003F1\u003F("^ťɳͰѮնز݄\u087Eढ\u0A4Fୣ౯ൣ\u0E65ཻၭᅣሦፕᑥᕱᙶᝲ");
      this.button40.UseVisualStyleBackColor = false;
      this.button40.Click += new EventHandler(this.button40_Click);
      this.button42.BackColor = Color.FromArgb(65, 65, 65);
      this.button42.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button42.FlatStyle = FlatStyle.Flat;
      this.button42.ForeColor = SystemColors.Control;
      this.button42.Location = new Point(529, 308);
      this.button42.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܳ");
      this.button42.Size = new Size(142, 30);
      this.button42.TabIndex = 96;
      this.button42.Text = \u003F0\u003F.\u003F1\u003F("Cŷɥ̰ќէ٠ݹ\u0867५\u0A7D୧\u0C75ദ\u0E5D༤၄ᅗቈ");
      this.button42.UseVisualStyleBackColor = false;
      this.button42.Click += new EventHandler(this.button42_Click);
      this.button44.BackColor = Color.FromArgb(65, 65, 65);
      this.button44.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button44.FlatStyle = FlatStyle.Flat;
      this.button44.ForeColor = SystemColors.Control;
      this.button44.Location = new Point(183, 473);
      this.button44.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܵ");
      this.button44.Size = new Size(142, 30);
      this.button44.TabIndex = 98;
      this.button44.Text = \u003F0\u003F.\u003F1\u003F("VŊȮ͌Ѣբ٧ݨ\u087C८੩୫తൄ๗\u0F48");
      this.button44.UseVisualStyleBackColor = false;
      this.button44.Click += new EventHandler(this.button44_Click);
      this.button45.BackColor = Color.FromArgb(65, 65, 65);
      this.button45.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button45.FlatStyle = FlatStyle.Flat;
      this.button45.ForeColor = SystemColors.Control;
      this.button45.Location = new Point(529, 176);
      this.button45.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܴ");
      this.button45.Size = new Size(142, 30);
      this.button45.TabIndex = 99;
      this.button45.Text = \u003F0\u003F.\u003F1\u003F("IůɭͿѦմٶܤࡄॗੈ");
      this.button45.UseVisualStyleBackColor = false;
      this.button45.Click += new EventHandler(this.button45_Click);
      this.button46.BackColor = Color.FromArgb(65, 65, 65);
      this.button46.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button46.FlatStyle = FlatStyle.Flat;
      this.button46.ForeColor = SystemColors.Control;
      this.button46.Location = new Point(358, 440);
      this.button46.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܷ");
      this.button46.Size = new Size(142, 30);
      this.button46.TabIndex = 100;
      this.button46.Text = \u003F0\u003F.\u003F1\u003F("OſɿͮѤը٤ܧࡁॐ੍ଣడള");
      this.button46.UseVisualStyleBackColor = false;
      this.button46.Click += new EventHandler(this.button46_Click);
      this.button47.BackColor = Color.FromArgb(65, 65, 65);
      this.button47.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button47.FlatStyle = FlatStyle.Flat;
      this.button47.ForeColor = SystemColors.Control;
      this.button47.Location = new Point(11, 440);
      this.button47.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܶ");
      this.button47.Size = new Size(142, 30);
      this.button47.TabIndex = 101;
      this.button47.Text = \u003F0\u003F.\u003F1\u003F("YţɼͯѻԨوݠࠥौ੦୮౭");
      this.button47.UseVisualStyleBackColor = false;
      this.button47.Click += new EventHandler(this.button47_Click);
      this.button48.BackColor = Color.FromArgb(65, 65, 65);
      this.button48.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button48.FlatStyle = FlatStyle.Flat;
      this.button48.ForeColor = SystemColors.Control;
      this.button48.Location = new Point(183, 506);
      this.button48.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܹ");
      this.button48.Size = new Size(142, 30);
      this.button48.TabIndex = 102;
      this.button48.Text = \u003F0\u003F.\u003F1\u003F("LŢɿͣЩ՜٢ݪ\u0860ॴ੬୰\u0C75");
      this.button48.UseVisualStyleBackColor = false;
      this.button48.Click += new EventHandler(this.button48_Click);
      this.button49.BackColor = Color.FromArgb(65, 65, 65);
      this.button49.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button49.FlatStyle = FlatStyle.Flat;
      this.button49.ForeColor = SystemColors.Control;
      this.button49.Location = new Point(529, 407);
      this.button49.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܸ");
      this.button49.Size = new Size(142, 30);
      this.button49.TabIndex = 103;
      this.button49.Text = \u003F0\u003F.\u003F1\u003F("[ůɽͼѢդٮܨࡋॣ\u0A62ୡ౭൦\u0E72");
      this.button49.UseVisualStyleBackColor = false;
      this.button49.Click += new EventHandler(this.button49_Click);
      this.button50.BackColor = Color.FromArgb(65, 65, 65);
      this.button50.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button50.FlatStyle = FlatStyle.Flat;
      this.button50.ForeColor = SystemColors.Control;
      this.button50.Location = new Point(529, 374);
      this.button50.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܱ");
      this.button50.Size = new Size(142, 30);
      this.button50.TabIndex = 104;
      this.button50.Text = \u003F0\u003F.\u003F1\u003F("YŹɿ\u0378ѱԳٔݸ\u0877१\u0A7A୨\u0C7E\u0D78สཚၡᅪታ\u1369ᑥᕷ᙭ᝳ");
      this.button50.UseVisualStyleBackColor = false;
      this.button50.Click += new EventHandler(this.button50_Click);
      this.button38.BackColor = Color.FromArgb(65, 65, 65);
      this.button38.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button38.FlatStyle = FlatStyle.Flat;
      this.button38.ForeColor = SystemColors.Control;
      this.button38.Location = new Point(529, 440);
      this.button38.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܹ");
      this.button38.Size = new Size(142, 30);
      this.button38.TabIndex = 105;
      this.button38.Text = \u003F0\u003F.\u003F1\u003F(" Ġȣ̾лԺث݈\u0868६\u0A60ୣథ\u0D53\u0E62\u0F6Eၪ");
      this.button38.UseVisualStyleBackColor = false;
      this.button38.Click += new EventHandler(this.button38_Click_1);
      this.button51.BackColor = Color.FromArgb(65, 65, 65);
      this.button51.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button51.FlatStyle = FlatStyle.Flat;
      this.button51.ForeColor = SystemColors.Control;
      this.button51.Location = new Point(708, 539);
      this.button51.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܰ");
      this.button51.Size = new Size(142, 30);
      this.button51.TabIndex = 117;
      this.button51.Text = \u003F0\u003F.\u003F1\u003F("XŰɺ̳єոٷݧ\u087A।\u0A62୬ప\u0D5A\u0E61ཪၳᅩብ\u1377ᑭᕳ");
      this.button51.UseVisualStyleBackColor = false;
      this.button51.Click += new EventHandler(this.button51_Click);
      this.button52.BackColor = Color.FromArgb(65, 65, 65);
      this.button52.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button52.FlatStyle = FlatStyle.Flat;
      this.button52.ForeColor = SystemColors.Control;
      this.button52.Location = new Point(708, 209);
      this.button52.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܳ");
      this.button52.Size = new Size(142, 30);
      this.button52.TabIndex = 116;
      this.button52.Text = \u003F0\u003F.\u003F1\u003F("WżɪͫЭ\u0558٣ݯࠩॎ੦\u0B65౬൨\u0E6Aྲྀၸ");
      this.button52.UseVisualStyleBackColor = false;
      this.button52.Click += new EventHandler(this.button52_Click);
      this.button53.BackColor = Color.FromArgb(65, 65, 65);
      this.button53.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button53.FlatStyle = FlatStyle.Flat;
      this.button53.ForeColor = SystemColors.Control;
      this.button53.Location = new Point(183, 209);
      this.button53.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܲ");
      this.button53.Size = new Size(142, 30);
      this.button53.TabIndex = 115;
      this.button53.Text = \u003F0\u003F.\u003F1\u003F("BŸɼ͢Ѷ\u0560٢ݱ\u0863म\u0A44ୢ౭ൣ\u0E67ཡၳᅣሥፎᑶᕯᙱ");
      this.button53.UseVisualStyleBackColor = false;
      this.button53.Click += new EventHandler(this.button53_Click);
      this.button54.BackColor = Color.FromArgb(65, 65, 65);
      this.button54.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button54.FlatStyle = FlatStyle.Flat;
      this.button54.ForeColor = SystemColors.Control;
      this.button54.Location = new Point(708, 341);
      this.button54.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܵ");
      this.button54.Size = new Size(142, 30);
      this.button54.TabIndex = 114;
      this.button54.Text = \u003F0\u003F.\u003F1\u003F("JŮɦ\u0378ѳԦوݡࠣडਲ਼");
      this.button54.UseVisualStyleBackColor = false;
      this.button54.Click += new EventHandler(this.button54_Click);
      this.button55.BackColor = Color.FromArgb(65, 65, 65);
      this.button55.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button55.FlatStyle = FlatStyle.Flat;
      this.button55.ForeColor = SystemColors.Control;
      this.button55.Location = new Point(708, 275);
      this.button55.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܴ");
      this.button55.Size = new Size(142, 30);
      this.button55.TabIndex = 113;
      this.button55.Text = \u003F0\u003F.\u003F1\u003F("Můɥ\u0379Ѽԧًݠࠤॄ\u0A57ୈ");
      this.button55.UseVisualStyleBackColor = false;
      this.button55.Click += new EventHandler(this.button55_Click);
      this.button56.BackColor = Color.FromArgb(65, 65, 65);
      this.button56.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button56.FlatStyle = FlatStyle.Flat;
      this.button56.ForeColor = SystemColors.Control;
      this.button56.Location = new Point(708, 242);
      this.button56.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܷ");
      this.button56.Size = new Size(142, 30);
      this.button56.TabIndex = 112;
      this.button56.Text = \u003F0\u003F.\u003F1\u003F("CŻɯͿѺբ٤ݮࠨॆੴୱ౭\u0D70\u0E76ི");
      this.button56.UseVisualStyleBackColor = false;
      this.button56.Click += new EventHandler(this.button56_Click);
      this.button57.BackColor = Color.FromArgb(65, 65, 65);
      this.button57.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button57.FlatStyle = FlatStyle.Flat;
      this.button57.ForeColor = SystemColors.Control;
      this.button57.Location = new Point(708, 308);
      this.button57.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܶ");
      this.button57.Size = new Size(142, 30);
      this.button57.TabIndex = 111;
      this.button57.Text = \u003F0\u003F.\u003F1\u003F("[Ŷɤ̵їա٧ݢ\u0878४\u0A7C\u0B7Eబഹส\u0F48ၽᅳቩጨᑂᕢᙰᝬ");
      this.button57.UseVisualStyleBackColor = false;
      this.button57.Click += new EventHandler(this.button57_Click);
      this.button58.BackColor = Color.FromArgb(65, 65, 65);
      this.button58.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button58.FlatStyle = FlatStyle.Flat;
      this.button58.ForeColor = SystemColors.Control;
      this.button58.Location = new Point(708, 88);
      this.button58.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܹ");
      this.button58.Size = new Size(142, 30);
      this.button58.TabIndex = 110;
      this.button58.Text = \u003F0\u003F.\u003F1\u003F("EſɸͫѿԬلݬࠩी\u0A62୪౩തไབྷ၈");
      this.button58.UseVisualStyleBackColor = false;
      this.button58.Click += new EventHandler(this.button58_Click);
      this.button59.BackColor = Color.FromArgb(65, 65, 65);
      this.button59.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button59.FlatStyle = FlatStyle.Flat;
      this.button59.ForeColor = SystemColors.Control;
      this.button59.Location = new Point(1070, 88);
      this.button59.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխطܸ");
      this.button59.Size = new Size(142, 30);
      this.button59.TabIndex = 109;
      this.button59.Text = \u003F0\u003F.\u003F1\u003F("DŠɤͪѮԪٚݡ\u086Aॳ੩\u0B65\u0C77൭\u0E73");
      this.button59.UseVisualStyleBackColor = false;
      this.button59.Click += new EventHandler(this.button59_Click);
      this.button60.BackColor = Color.FromArgb(65, 65, 65);
      this.button60.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button60.FlatStyle = FlatStyle.Flat;
      this.button60.ForeColor = SystemColors.Control;
      this.button60.Location = new Point(708, 440);
      this.button60.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܱ");
      this.button60.Size = new Size(142, 30);
      this.button60.TabIndex = 108;
      this.button60.Text = \u003F0\u003F.\u003F1\u003F("_ţȦ͈Ѧհٮݨ\u0862त\u0A44ୗై");
      this.button60.UseVisualStyleBackColor = false;
      this.button60.Click += new EventHandler(this.button60_Click);
      this.button62.BackColor = Color.FromArgb(65, 65, 65);
      this.button62.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button62.FlatStyle = FlatStyle.Flat;
      this.button62.ForeColor = SystemColors.Control;
      this.button62.Location = new Point(888, 341);
      this.button62.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܳ");
      this.button62.Size = new Size(142, 30);
      this.button62.TabIndex = 106;
      this.button62.Text = \u003F0\u003F.\u003F1\u003F("_ŧɼͲѪռحݘ\u0872३੦୧౩ദื༤၄ᅗቈ");
      this.button62.UseVisualStyleBackColor = false;
      this.button62.Click += new EventHandler(this.button62_Click);
      this.panel6.BackColor = Color.Transparent;
      this.panel6.BorderStyle = BorderStyle.FixedSingle;
      this.panel6.ForeColor = SystemColors.ControlLightLight;
      this.panel6.Location = new Point(681, 87);
      this.panel6.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԷ");
      this.panel6.Size = new Size(21, 550);
      this.panel6.TabIndex = 74;
      this.label6.AutoSize = true;
      this.label6.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.ForeColor = SystemColors.Control;
      this.label6.Location = new Point(751, 52);
      this.label6.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԷ");
      this.label6.Size = new Size(64, 25);
      this.label6.TabIndex = 118;
      this.label6.Text = \u003F0\u003F.\u003F1\u003F("CŽɰͱѣղ");
      this.button63.BackColor = Color.FromArgb(65, 65, 65);
      this.button63.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button63.FlatStyle = FlatStyle.Flat;
      this.button63.ForeColor = SystemColors.Control;
      this.button63.Location = new Point(708, 473);
      this.button63.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܲ");
      this.button63.Size = new Size(142, 30);
      this.button63.TabIndex = 121;
      this.button63.Text = \u003F0\u003F.\u003F1\u003F("_ŪɡͼѺզئݖ\u0870ॢ੬\u0B65");
      this.button63.UseVisualStyleBackColor = false;
      this.button63.Click += new EventHandler(this.button63_Click);
      this.button64.BackColor = Color.FromArgb(65, 65, 65);
      this.button64.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button64.FlatStyle = FlatStyle.Flat;
      this.button64.ForeColor = SystemColors.Control;
      this.button64.Location = new Point(529, 473);
      this.button64.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܵ");
      this.button64.Size = new Size(142, 30);
      this.button64.TabIndex = 122;
      this.button64.Text = \u003F0\u003F.\u003F1\u003F("YŤɮ̪ўա٫ݢࠥ॓੦ୱ\u0C75");
      this.button64.UseVisualStyleBackColor = false;
      this.button64.Click += new EventHandler(this.button64_Click);
      this.button65.BackColor = Color.FromArgb(65, 65, 65);
      this.button65.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button65.FlatStyle = FlatStyle.Flat;
      this.button65.ForeColor = SystemColors.Control;
      this.button65.Location = new Point(358, 473);
      this.button65.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܴ");
      this.button65.Size = new Size(142, 30);
      this.button65.TabIndex = 123;
      this.button65.Text = \u003F0\u003F.\u003F1\u003F("[ŪɲͷѾսٽݵ࠱ी\u0A60୧ౣ\u0D78หཌၠᅺቢጡᑶᔤᙄ\u1757ᡈ");
      this.button65.UseVisualStyleBackColor = false;
      this.button65.Click += new EventHandler(this.button65_Click);
      this.button66.BackColor = Color.FromArgb(65, 65, 65);
      this.button66.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button66.FlatStyle = FlatStyle.Flat;
      this.button66.ForeColor = SystemColors.Control;
      this.button66.Location = new Point(529, 275);
      this.button66.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܷ");
      this.button66.Size = new Size(142, 30);
      this.button66.TabIndex = 124;
      this.button66.Text = \u003F0\u003F.\u003F1\u003F("VŦɰͳѼժخ݊\u0879०ਪ\u0B5Aౡ൪\u0E73ཀྵၥᅷቭ\u1373");
      this.button66.UseVisualStyleBackColor = false;
      this.button66.Click += new EventHandler(this.button66_Click);
      this.button67.BackColor = Color.FromArgb(65, 65, 65);
      this.button67.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button67.FlatStyle = FlatStyle.Flat;
      this.button67.ForeColor = SystemColors.Control;
      this.button67.Location = new Point(11, 473);
      this.button67.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܶ");
      this.button67.Size = new Size(142, 30);
      this.button67.TabIndex = 125;
      this.button67.Text = \u003F0\u003F.\u003F1\u003F("TŽɵͽѠժ٨ܬࠤपੌ\u0B65౨\u0D72\u0E60༤၄ᅗቈ");
      this.button67.UseVisualStyleBackColor = false;
      this.button67.Click += new EventHandler(this.button67_Click);
      this.button72.BackColor = Color.FromArgb(65, 65, 65);
      this.button72.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button72.FlatStyle = FlatStyle.Flat;
      this.button72.ForeColor = SystemColors.Control;
      this.button72.Location = new Point(1070, 473);
      this.button72.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܳ");
      this.button72.Size = new Size(142, 30);
      this.button72.TabIndex = 130;
      this.button72.Text = \u003F0\u003F.\u003F1\u003F("GŢɩ͢ШՈ٠ݣࠤॄ\u0A57ୈ");
      this.button72.UseVisualStyleBackColor = false;
      this.button72.Click += new EventHandler(this.button72_Click);
      this.button68.BackColor = Color.FromArgb(65, 65, 65);
      this.button68.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button68.FlatStyle = FlatStyle.Flat;
      this.button68.ForeColor = SystemColors.Control;
      this.button68.Location = new Point(708, 506);
      this.button68.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܹ");
      this.button68.Size = new Size(142, 30);
      this.button68.TabIndex = 131;
      this.button68.Text = \u003F0\u003F.\u003F1\u003F("IūɣͯѢդٮܨࡀ३\u0A61୩౬൦\u0E64");
      this.button68.UseVisualStyleBackColor = false;
      this.button68.Click += new EventHandler(this.button68_Click);
      this.button69.BackColor = Color.FromArgb(65, 65, 65);
      this.button69.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button69.FlatStyle = FlatStyle.Flat;
      this.button69.ForeColor = SystemColors.Control;
      this.button69.Location = new Point(529, 506);
      this.button69.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܸ");
      this.button69.Size = new Size(142, 30);
      this.button69.TabIndex = 132;
      this.button69.Text = \u003F0\u003F.\u003F1\u003F("XŦɿͳѵսخݙ\u0875२\u0A65୦౦ധิ༥၅ᅶቶ\u136E");
      this.button69.UseVisualStyleBackColor = false;
      this.button69.Click += new EventHandler(this.button69_Click);
      this.button70.BackColor = Color.FromArgb(65, 65, 65);
      this.button70.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button70.FlatStyle = FlatStyle.Flat;
      this.button70.ForeColor = SystemColors.Control;
      this.button70.Location = new Point(1070, 341);
      this.button70.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܱ");
      this.button70.Size = new Size(142, 30);
      this.button70.TabIndex = 133;
      this.button70.Text = \u003F0\u003F.\u003F1\u003F("UĳɝͿѵԯٞݤ\u0869२੯\u0B29\u0C4F൦\u0E6Bའဤᅄ\u1257ፈ");
      this.button70.UseVisualStyleBackColor = false;
      this.button70.Click += new EventHandler(this.button70_Click);
      this.button73.BackColor = Color.FromArgb(65, 65, 65);
      this.button73.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button73.FlatStyle = FlatStyle.Flat;
      this.button73.ForeColor = SystemColors.Control;
      this.button73.Location = new Point(11, 539);
      this.button73.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܲ");
      this.button73.Size = new Size(142, 30);
      this.button73.TabIndex = 135;
      this.button73.Text = \u003F0\u003F.\u003F1\u003F("EŦɺ͡Ѿվد݂\u0864४੮ପే൭\u0E7Fཱིၶᄤቄፗᑈ");
      this.button73.UseVisualStyleBackColor = false;
      this.button73.Click += new EventHandler(this.button73_Click);
      this.button74.BackColor = Color.FromArgb(65, 65, 65);
      this.button74.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button74.FlatStyle = FlatStyle.Flat;
      this.button74.ForeColor = SystemColors.Control;
      this.button74.Location = new Point(1070, 506);
      this.button74.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܵ");
      this.button74.Size = new Size(142, 30);
      this.button74.TabIndex = 136;
      this.button74.Text = \u003F0\u003F.\u003F1\u003F("Qſɷͼѵաٺܭࡎ४\u0A7E\u0B7D\u0C64ൢ\u0E61ཪၱᅭቦ\u1372");
      this.button74.UseVisualStyleBackColor = false;
      this.button74.Click += new EventHandler(this.button74_Click);
      this.button75.BackColor = Color.FromArgb(65, 65, 65);
      this.button75.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button75.FlatStyle = FlatStyle.Flat;
      this.button75.ForeColor = SystemColors.Control;
      this.button75.Location = new Point(11, 275);
      this.button75.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܴ");
      this.button75.Size = new Size(142, 30);
      this.button75.TabIndex = 137;
      this.button75.Text = \u003F0\u003F.\u003F1\u003F("TŰɱ̳сզٱݽ\u0863भ\u0A5Fୢ౧ർ\u0E64སၲᅪቶጣᐡᔲ");
      this.button75.UseVisualStyleBackColor = false;
      this.button75.Click += new EventHandler(this.button75_Click);
      this.button76.BackColor = Color.FromArgb(65, 65, 65);
      this.button76.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button76.FlatStyle = FlatStyle.Flat;
      this.button76.ForeColor = SystemColors.Control;
      this.button76.Location = new Point(358, 275);
      this.button76.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܷ");
      this.button76.Size = new Size(142, 30);
      this.button76.TabIndex = 138;
      this.button76.Text = \u003F0\u003F.\u003F1\u003F("ZŮɧ͡Ѯչٯݨ\u0863धੁ\u0B50్ണม\u0F32");
      this.button76.UseVisualStyleBackColor = false;
      this.button76.Click += new EventHandler(this.button76_Click);
      this.button77.BackColor = Color.FromArgb(65, 65, 65);
      this.button77.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button77.FlatStyle = FlatStyle.Flat;
      this.button77.ForeColor = SystemColors.Control;
      this.button77.Location = new Point(183, 539);
      this.button77.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܶ");
      this.button77.Size = new Size(142, 30);
      this.button77.TabIndex = 139;
      this.button77.Text = \u003F0\u003F.\u003F1\u003F("@źɺͤѴբټݯ\u0861ब\u0A4Aୣ\u0C64\u0D64\u0E68ཥၮᄤቄፗᑈ");
      this.button77.UseVisualStyleBackColor = false;
      this.button77.Click += new EventHandler(this.button77_Click);
      this.button78.BackColor = Color.FromArgb(65, 65, 65);
      this.button78.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button78.FlatStyle = FlatStyle.Flat;
      this.button78.ForeColor = SystemColors.Control;
      this.button78.Location = new Point(708, 572);
      this.button78.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܹ");
      this.button78.Size = new Size(142, 30);
      this.button78.TabIndex = 140;
      this.button78.Text = \u003F0\u003F.\u003F1\u003F("SřɈ̮ѝխ٢ݤ\u087D४੦୪౩തไབྷ၈");
      this.button78.UseVisualStyleBackColor = false;
      this.button78.Click += new EventHandler(this.button78_Click);
      this.button79.BackColor = Color.FromArgb(65, 65, 65);
      this.button79.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button79.FlatStyle = FlatStyle.Flat;
      this.button79.ForeColor = SystemColors.Control;
      this.button79.Location = new Point(529, 572);
      this.button79.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܸ");
      this.button79.Size = new Size(142, 30);
      this.button79.TabIndex = 141;
      this.button79.Text = \u003F0\u003F.\u003F1\u003F("_Űɴ̯эդٸݲࠪै\u0A7D\u0B73౩നโརၰᅬ");
      this.button79.UseVisualStyleBackColor = false;
      this.button79.Click += new EventHandler(this.button79_Click);
      this.button80.BackColor = Color.FromArgb(65, 65, 65);
      this.button80.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button80.FlatStyle = FlatStyle.Flat;
      this.button80.ForeColor = SystemColors.Control;
      this.button80.Location = new Point(358, 572);
      this.button80.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܱ");
      this.button80.Size = new Size(142, 30);
      this.button80.TabIndex = 142;
      this.button80.Text = \u003F0\u003F.\u003F1\u003F("_ŸɨͬѢԦّݫ\u0874१ੳ");
      this.button80.UseVisualStyleBackColor = false;
      this.button80.Click += new EventHandler(this.button80_Click);
      this.button81.BackColor = Color.FromArgb(65, 65, 65);
      this.button81.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button81.FlatStyle = FlatStyle.Flat;
      this.button81.ForeColor = SystemColors.Control;
      this.button81.Location = new Point(11, 605);
      this.button81.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܰ");
      this.button81.Size = new Size(142, 30);
      this.button81.TabIndex = 143;
      this.button81.Text = \u003F0\u003F.\u003F1\u003F("JŬȬ̓ѥզ٬ܧࡁॐ੍ଣడള");
      this.button81.UseVisualStyleBackColor = false;
      this.button81.Click += new EventHandler(this.button81_Click);
      this.button82.BackColor = Color.FromArgb(65, 65, 65);
      this.button82.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button82.FlatStyle = FlatStyle.Flat;
      this.button82.ForeColor = SystemColors.Control;
      this.button82.Location = new Point(708, 122);
      this.button82.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܳ");
      this.button82.Size = new Size(142, 51);
      this.button82.TabIndex = 144;
      this.button82.Text = \u003F0\u003F.\u003F1\u003F("Pŵɵͳѷտط݅\u087Cॹ੦\u0B7E\u0C70\u0D64\u0E60ོိᄾራፐᑬᕭᙵᝩ\u187Dᤤᩋ᭷ᱣ");
      this.button82.UseVisualStyleBackColor = false;
      this.button82.Click += new EventHandler(this.button82_Click);
      this.button83.BackColor = Color.FromArgb(65, 65, 65);
      this.button83.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button83.FlatStyle = FlatStyle.Flat;
      this.button83.ForeColor = SystemColors.Control;
      this.button83.Location = new Point(708, 605);
      this.button83.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܲ");
      this.button83.Size = new Size(142, 29);
      this.button83.TabIndex = 153;
      this.button83.Text = \u003F0\u003F.\u003F1\u003F("AŹɮ͠ѢԬيݿ\u087D१ਧୖ౩\u0D65\u0E7Aཧၳ");
      this.button83.UseVisualStyleBackColor = false;
      this.button83.Click += new EventHandler(this.button83_Click);
      this.button84.BackColor = Color.FromArgb(65, 65, 65);
      this.button84.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button84.FlatStyle = FlatStyle.Flat;
      this.button84.ForeColor = SystemColors.Control;
      this.button84.Location = new Point(183, 572);
      this.button84.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܵ");
      this.button84.Size = new Size(142, 30);
      this.button84.TabIndex = 152;
      this.button84.Text = \u003F0\u003F.\u003F1\u003F("]űɲͶѽյټݽ࠭त\u0A46\u0B65\u0C7Aർวཁၤᅩቦ\u1371ᐨ");
      this.button84.UseVisualStyleBackColor = false;
      this.button84.Click += new EventHandler(this.button84_Click);
      this.button85.BackColor = Color.FromArgb(65, 65, 65);
      this.button85.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button85.FlatStyle = FlatStyle.Flat;
      this.button85.ForeColor = SystemColors.Control;
      this.button85.Location = new Point(358, 605);
      this.button85.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܴ");
      this.button85.Size = new Size(142, 30);
      this.button85.TabIndex = 151;
      this.button85.Text = \u003F0\u003F.\u003F1\u003F("SţɣͪѠլ٠ܫࡄौ\u0A5Fଧౕ൦\u0E76ཪၲᅵ");
      this.button85.UseVisualStyleBackColor = false;
      this.button85.Click += new EventHandler(this.button85_Click);
      this.button86.BackColor = Color.FromArgb(65, 65, 65);
      this.button86.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button86.FlatStyle = FlatStyle.Flat;
      this.button86.ForeColor = SystemColors.Control;
      this.button86.Location = new Point(529, 605);
      this.button86.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܷ");
      this.button86.Size = new Size(142, 30);
      this.button86.TabIndex = 150;
      this.button86.Text = \u003F0\u003F.\u003F1\u003F("Uşɒ̴уճٸݾ\u087B६੬ୠ౧പํེၨᅨበጤᑆᕑᙑ");
      this.button86.UseVisualStyleBackColor = false;
      this.button86.Click += new EventHandler(this.button86_Click);
      this.button88.BackColor = Color.FromArgb(65, 65, 65);
      this.button88.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button88.FlatStyle = FlatStyle.Flat;
      this.button88.ForeColor = SystemColors.Control;
      this.button88.Location = new Point(888, 605);
      this.button88.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܹ");
      this.button88.Size = new Size(142, 30);
      this.button88.TabIndex = 170;
      this.button88.Text = \u003F0\u003F.\u003F1\u003F("LŨɨͼѫջٻܧࡕ०\u0A76୪\u0C72\u0D75");
      this.button88.UseVisualStyleBackColor = false;
      this.button88.Click += new EventHandler(this.button88_Click);
      this.button89.BackColor = Color.FromArgb(65, 65, 65);
      this.button89.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button89.FlatStyle = FlatStyle.Flat;
      this.button89.ForeColor = SystemColors.Control;
      this.button89.Location = new Point(888, 572);
      this.button89.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܸ");
      this.button89.Size = new Size(142, 30);
      this.button89.TabIndex = 169;
      this.button89.Text = \u003F0\u003F.\u003F1\u003F("JſɸͥѻԪوݤ\u086Bदੑ୫౬൮\u0E72");
      this.button89.UseVisualStyleBackColor = false;
      this.button89.Click += new EventHandler(this.button89_Click);
      this.button90.BackColor = Color.FromArgb(65, 65, 65);
      this.button90.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button90.FlatStyle = FlatStyle.Flat;
      this.button90.ForeColor = SystemColors.Control;
      this.button90.Location = new Point(888, 539);
      this.button90.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܱ");
      this.button90.Size = new Size(142, 30);
      this.button90.TabIndex = 168;
      this.button90.Text = \u003F0\u003F.\u003F1\u003F("\\Ũɸ\u0379ѣլپݢࠦ॑੫୬౮\u0D72");
      this.button90.UseVisualStyleBackColor = false;
      this.button90.Click += new EventHandler(this.button90_Click);
      this.button91.BackColor = Color.FromArgb(65, 65, 65);
      this.button91.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button91.FlatStyle = FlatStyle.Flat;
      this.button91.ForeColor = SystemColors.Control;
      this.button91.Location = new Point(888, 506);
      this.button91.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܰ");
      this.button91.Size = new Size(142, 30);
      this.button91.TabIndex = 167;
      this.button91.Text = \u003F0\u003F.\u003F1\u003F("FŵɥͷбՄ٠ݡ\u0861ॿਫଥ\u0C29ൊ\u0E66ཥၮᅴቢ፡ᑪ");
      this.button91.UseVisualStyleBackColor = false;
      this.button91.Click += new EventHandler(this.button91_Click);
      this.button92.BackColor = Color.FromArgb(65, 65, 65);
      this.button92.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button92.FlatStyle = FlatStyle.Flat;
      this.button92.ForeColor = SystemColors.Control;
      this.button92.Location = new Point(183, 605);
      this.button92.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܳ");
      this.button92.Size = new Size(142, 30);
      this.button92.TabIndex = 166;
      this.button92.Text = \u003F0\u003F.\u003F1\u003F("FŹɵ̯шա٣ݤ\u0878ऩੁ\u0B74ద\u0D49ๅཕ၃ᄠ");
      this.button92.UseVisualStyleBackColor = false;
      this.button92.Click += new EventHandler(this.button92_Click);
      this.button93.BackColor = Color.FromArgb(65, 65, 65);
      this.button93.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button93.FlatStyle = FlatStyle.Flat;
      this.button93.ForeColor = SystemColors.Control;
      this.button93.Location = new Point(888, 440);
      this.button93.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܲ");
      this.button93.Size = new Size(142, 30);
      this.button93.TabIndex = 165;
      this.button93.Text = \u003F0\u003F.\u003F1\u003F("YŹɿ\u0378ѱԳقݤ\u087E६੦\u0B64ౢ൬สཚၡᅪታ\u1369ᑥᕷ᙭ᝳ");
      this.button93.UseVisualStyleBackColor = false;
      this.button93.Click += new EventHandler(this.button93_Click);
      this.button94.BackColor = Color.FromArgb(65, 65, 65);
      this.button94.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button94.FlatStyle = FlatStyle.Flat;
      this.button94.ForeColor = SystemColors.Control;
      this.button94.Location = new Point(888, 374);
      this.button94.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܵ");
      this.button94.Size = new Size(142, 30);
      this.button94.TabIndex = 164;
      this.button94.Text = \u003F0\u003F.\u003F1\u003F("WšɷͰѤպټݨ\u087Fफ\u0A45୯న\u0D54\u0E69ཫၥᅱቫ፠");
      this.button94.UseVisualStyleBackColor = false;
      this.button94.Click += new EventHandler(this.button94_Click);
      this.button95.BackColor = Color.FromArgb(65, 65, 65);
      this.button95.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button95.FlatStyle = FlatStyle.Flat;
      this.button95.ForeColor = SystemColors.Control;
      this.button95.Location = new Point(888, 407);
      this.button95.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܴ");
      this.button95.Size = new Size(142, 30);
      this.button95.TabIndex = 163;
      this.button95.Text = \u003F0\u003F.\u003F1\u003F("_ŧɻͽв՜ٱݡ\u082Eफ़\u0A65୦౿\u0D65\u0E69ཱིၩᅷሤፄᑗᕈ");
      this.button95.UseVisualStyleBackColor = false;
      this.button95.Click += new EventHandler(this.button95_Click);
      this.button96.BackColor = Color.FromArgb(65, 65, 65);
      this.button96.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button96.FlatStyle = FlatStyle.Flat;
      this.button96.ForeColor = SystemColors.Control;
      this.button96.Location = new Point(708, 176);
      this.button96.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܷ");
      this.button96.Size = new Size(142, 30);
      this.button96.TabIndex = 162;
      this.button96.Text = \u003F0\u003F.\u003F1\u003F("]Źȷ͞Ѻջٷܲࡂॳ\u0A7D୧\u0C7D\u0D78หྲྀဩᅜት\u1373ᑶᕰᙁ\u176D\u1878");
      this.button96.UseVisualStyleBackColor = false;
      this.button96.Click += new EventHandler(this.button96_Click);
      this.button97.BackColor = Color.FromArgb(65, 65, 65);
      this.button97.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button97.FlatStyle = FlatStyle.Flat;
      this.button97.ForeColor = SystemColors.Control;
      this.button97.Location = new Point(888, 275);
      this.button97.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܶ");
      this.button97.Size = new Size(142, 30);
      this.button97.TabIndex = 161;
      this.button97.Text = \u003F0\u003F.\u003F1\u003F("VŸɺͱѺյٽܮ࡞॥੦\u0B7F\u0C65൩\u0E73ཀྵၷᄤቄፗᑈ");
      this.button97.UseVisualStyleBackColor = false;
      this.button97.Click += new EventHandler(this.button97_Click);
      this.button98.BackColor = Color.FromArgb(65, 65, 65);
      this.button98.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button98.FlatStyle = FlatStyle.Flat;
      this.button98.ForeColor = SystemColors.Control;
      this.button98.Location = new Point(888, 242);
      this.button98.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܹ");
      this.button98.Size = new Size(142, 30);
      this.button98.TabIndex = 160;
      this.button98.Text = \u003F0\u003F.\u003F1\u003F("WűɻͣѦԱّݡ\u086Aभਫ਼୪ౣൺ\u0E6D༧၇ᄥቆ።ᑠᕸ");
      this.button98.UseVisualStyleBackColor = false;
      this.button98.Click += new EventHandler(this.button98_Click);
      this.button99.BackColor = Color.FromArgb(65, 65, 65);
      this.button99.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button99.FlatStyle = FlatStyle.Flat;
      this.button99.ForeColor = SystemColors.Control;
      this.button99.Location = new Point(888, 308);
      this.button99.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխػܸ");
      this.button99.Size = new Size(142, 30);
      this.button99.TabIndex = 159;
      this.button99.Text = \u003F0\u003F.\u003F1\u003F("[ŻɿͶѿն٠ܱࡃ०\u0A63\u0B78ౠ൪\u0E7Eསၺᄧቁፐᑍᔣᘡᜳ");
      this.button99.UseVisualStyleBackColor = false;
      this.button99.Click += new EventHandler(this.button99_Click);
      this.button100.BackColor = Color.FromArgb(65, 65, 65);
      this.button100.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button100.FlatStyle = FlatStyle.Flat;
      this.button100.ForeColor = SystemColors.Control;
      this.button100.Location = new Point(888, 88);
      this.button100.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠱");
      this.button100.Size = new Size(142, 30);
      this.button100.TabIndex = 158;
      this.button100.Text = \u003F0\u003F.\u003F1\u003F("@Ţɽ\u0379ѻպ٤ݢ\u086Cपਖ਼୧౮൨\u0E71༤၄ᅗቈ");
      this.button100.UseVisualStyleBackColor = false;
      this.button100.Click += new EventHandler(this.button100_Click);
      this.button101.BackColor = Color.FromArgb(65, 65, 65);
      this.button101.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button101.FlatStyle = FlatStyle.Flat;
      this.button101.ForeColor = SystemColors.Control;
      this.button101.Location = new Point(888, 122);
      this.button101.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠰");
      this.button101.Size = new Size(142, 51);
      this.button101.TabIndex = 157;
      this.button101.Text = \u003F0\u003F.\u003F1\u003F("ZŻɹͭдՕ٠ݤ\u0879ॻ\u0A7Dଭ\u0C5Fൿ\u0E78འၦᅠሦ፝ᐤᕋᙷᝣ");
      this.button101.UseVisualStyleBackColor = false;
      this.button101.Click += new EventHandler(this.button101_Click);
      this.button103.BackColor = Color.FromArgb(65, 65, 65);
      this.button103.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button103.FlatStyle = FlatStyle.Flat;
      this.button103.ForeColor = SystemColors.Control;
      this.button103.Location = new Point(888, 176);
      this.button103.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠲");
      this.button103.Size = new Size(142, 30);
      this.button103.TabIndex = 155;
      this.button103.Text = \u003F0\u003F.\u003F1\u003F("QžɾͨЯՈٿݹ\u0862ॾ\u0A7Aନొ൧\u0E76\u0F70ၦᅰ\u1259");
      this.button103.UseVisualStyleBackColor = false;
      this.button103.Click += new EventHandler(this.button103_Click);
      this.button104.BackColor = Color.FromArgb(65, 65, 65);
      this.button104.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button104.FlatStyle = FlatStyle.Flat;
      this.button104.ForeColor = SystemColors.Control;
      this.button104.Location = new Point(888, 209);
      this.button104.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠵");
      this.button104.Size = new Size(142, 30);
      this.button104.TabIndex = 154;
      this.button104.Text = \u003F0\u003F.\u003F1\u003F("WŦɶͳѺչ١ݩ࠭ड़\u0A64ୣ౧ർวཁၐᅍሣጡᐲ");
      this.button104.UseVisualStyleBackColor = false;
      this.button104.Click += new EventHandler(this.button104_Click);
      this.panel7.BackColor = Color.Transparent;
      this.panel7.BorderStyle = BorderStyle.FixedSingle;
      this.panel7.ForeColor = SystemColors.ControlLightLight;
      this.panel7.Location = new Point(859, 87);
      this.panel7.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԶ");
      this.panel7.Size = new Size(23, 550);
      this.panel7.TabIndex = 75;
      this.label7.AutoSize = true;
      this.label7.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label7.ForeColor = SystemColors.Control;
      this.label7.Location = new Point(935, 52);
      this.label7.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԶ");
      this.label7.Size = new Size(57, 25);
      this.label7.TabIndex = 171;
      this.label7.Text = \u003F0\u003F.\u003F1\u003F("Hŭɰ͡Я");
      this.button105.BackColor = Color.FromArgb(65, 65, 65);
      this.button105.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button105.FlatStyle = FlatStyle.Flat;
      this.button105.ForeColor = SystemColors.Control;
      this.button105.Location = new Point(601, 643);
      this.button105.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠴");
      this.button105.Size = new Size(622, 35);
      this.button105.TabIndex = 172;
      this.button105.Text = \u003F0\u003F.\u003F1\u003F("@űɣ\u0379ѿպح݄\u087E२\u0A29\u0B74ధ\u0D56\u0E64ལၦᄢሳ");
      this.button105.UseVisualStyleBackColor = false;
      this.button105.Click += new EventHandler(this.button105_Click);
      this.button106.BackColor = Color.FromArgb(65, 65, 65);
      this.button106.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button106.FlatStyle = FlatStyle.Flat;
      this.button106.ForeColor = SystemColors.Control;
      this.button106.Location = new Point(12, 643);
      this.button106.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠷");
      this.button106.Size = new Size(581, 35);
      this.button106.TabIndex = 173;
      this.button106.Text = \u003F0\u003F.\u003F1\u003F("@űɣ\u0379ѿպح݄\u087E२\u0A29\u0B74ధ\u0D56\u0E64ལၦᄢሲ");
      this.button106.UseVisualStyleBackColor = false;
      this.button106.Click += new EventHandler(this.button106_Click);
      this.panel8.BackColor = Color.Transparent;
      this.panel8.BorderStyle = BorderStyle.FixedSingle;
      this.panel8.ForeColor = SystemColors.ControlLightLight;
      this.panel8.Location = new Point(1040, 88);
      this.panel8.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԹ");
      this.panel8.Size = new Size(22, 550);
      this.panel8.TabIndex = 174;
      this.button1.BackColor = Color.FromArgb(65, 65, 65);
      this.button1.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = SystemColors.Control;
      this.button1.Location = new Point(1070, 605);
      this.button1.Name = \u003F0\u003F.\u003F1\u003F("eųɱͰѬլذ");
      this.button1.Size = new Size(142, 30);
      this.button1.TabIndex = 190;
      this.button1.Text = \u003F0\u003F.\u003F1\u003F("_ũɦͥѿխا݇\u0876ॷ੦\u0B76\u0C72");
      this.button1.UseVisualStyleBackColor = false;
      this.button30.BackColor = Color.FromArgb(65, 65, 65);
      this.button30.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button30.FlatStyle = FlatStyle.Flat;
      this.button30.ForeColor = SystemColors.Control;
      this.button30.Location = new Point(1070, 572);
      this.button30.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܱ");
      this.button30.Size = new Size(142, 30);
      this.button30.TabIndex = 189;
      this.button30.Text = \u003F0\u003F.\u003F1\u003F("\\ŻɿͪЫՙ٪ݺ\u086Eॶੱତౄൗ่");
      this.button30.UseVisualStyleBackColor = false;
      this.button30.Click += new EventHandler(this.button30_Click_1);
      this.button33.BackColor = Color.FromArgb(65, 65, 65);
      this.button33.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button33.FlatStyle = FlatStyle.Flat;
      this.button33.ForeColor = SystemColors.Control;
      this.button33.Location = new Point(1070, 539);
      this.button33.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխرܲ");
      this.button33.Size = new Size(142, 30);
      this.button33.TabIndex = 188;
      this.button33.Text = \u003F0\u003F.\u003F1\u003F("LŦɬ\u0378ЫՈٰݸ\u0866ॵ\u0A76ତౄൗ่");
      this.button33.UseVisualStyleBackColor = false;
      this.button33.Click += new EventHandler(this.button33_Click_1);
      this.button43.BackColor = Color.FromArgb(65, 65, 65);
      this.button43.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button43.FlatStyle = FlatStyle.Flat;
      this.button43.ForeColor = SystemColors.Control;
      this.button43.Location = new Point(1070, 242);
      this.button43.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխضܲ");
      this.button43.Size = new Size(142, 30);
      this.button43.TabIndex = 187;
      this.button43.Text = \u003F0\u003F.\u003F1\u003F("AŹɹ͡Ѫբج݇\u0863९੭ଧు\u0D50ํ༣အᄲ");
      this.button43.UseVisualStyleBackColor = false;
      this.button43.Click += new EventHandler(this.button43_Click_1);
      this.button61.BackColor = Color.FromArgb(65, 65, 65);
      this.button61.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button61.FlatStyle = FlatStyle.Flat;
      this.button61.ForeColor = SystemColors.Control;
      this.button61.Location = new Point(11, 506);
      this.button61.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխشܰ");
      this.button61.Size = new Size(142, 30);
      this.button61.TabIndex = 186;
      this.button61.Text = \u003F0\u003F.\u003F1\u003F("NŪɢͼѿԪلݭࠧु\u0A50୍ణഡำ");
      this.button61.UseVisualStyleBackColor = false;
      this.button61.Click += new EventHandler(this.button61_Click_1);
      this.button71.BackColor = Color.FromArgb(65, 65, 65);
      this.button71.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button71.FlatStyle = FlatStyle.Flat;
      this.button71.ForeColor = SystemColors.Control;
      this.button71.Location = new Point(11, 242);
      this.button71.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխصܰ");
      this.button71.Size = new Size(142, 30);
      this.button71.TabIndex = 185;
      this.button71.Text = \u003F0\u003F.\u003F1\u003F("TŰɱ̳сզٱݽ\u0863भ\u0A5Fୢ౧ർ\u0E64སၲᅪቶጣᐡᔳ");
      this.button71.UseVisualStyleBackColor = false;
      this.button71.Click += new EventHandler(this.button71_Click_1);
      this.button102.BackColor = Color.FromArgb(65, 65, 65);
      this.button102.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button102.FlatStyle = FlatStyle.Flat;
      this.button102.ForeColor = SystemColors.Control;
      this.button102.Location = new Point(11, 176);
      this.button102.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠳");
      this.button102.Size = new Size(142, 30);
      this.button102.TabIndex = 184;
      this.button102.Text = \u003F0\u003F.\u003F1\u003F("_ŸɾͦѠժجݘ\u0863।\u0A7D୫౧\u0D71\u0E6Bཱဢᄳ");
      this.button102.UseVisualStyleBackColor = false;
      this.button102.Click += new EventHandler(this.button102_Click_1);
      this.button108.BackColor = Color.FromArgb(65, 65, 65);
      this.button108.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button108.FlatStyle = FlatStyle.Flat;
      this.button108.ForeColor = SystemColors.Control;
      this.button108.Location = new Point(1070, 407);
      this.button108.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠹");
      this.button108.Size = new Size(142, 30);
      this.button108.TabIndex = 183;
      this.button108.Text = \u003F0\u003F.\u003F1\u003F("XŶɵʹѾիٽܭࡃ७ਪ\u0B5A\u0C78ൢ\u0E63ཡဤᅄ\u1257ፈ");
      this.button108.UseVisualStyleBackColor = false;
      this.button108.Click += new EventHandler(this.button108_Click);
      this.button109.BackColor = Color.FromArgb(65, 65, 65);
      this.button109.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button109.FlatStyle = FlatStyle.Flat;
      this.button109.ForeColor = SystemColors.Control;
      this.button109.Location = new Point(1070, 308);
      this.button109.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܲ࠸");
      this.button109.Size = new Size(142, 30);
      this.button109.TabIndex = 182;
      this.button109.Text = \u003F0\u003F.\u003F1\u003F("@źɸ;ѫաح݀\u0862६੬ନ\u0C54\u0D56\u0E5C༤။ᅗቃ");
      this.button109.UseVisualStyleBackColor = false;
      this.button109.Click += new EventHandler(this.button109_Click);
      this.button110.BackColor = Color.FromArgb(65, 65, 65);
      this.button110.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button110.FlatStyle = FlatStyle.Flat;
      this.button110.ForeColor = SystemColors.Control;
      this.button110.Location = new Point(1070, 209);
      this.button110.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠱");
      this.button110.Size = new Size(142, 30);
      this.button110.TabIndex = 181;
      this.button110.Text = \u003F0\u003F.\u003F1\u003F("AŹɹ͡Ѫբج݇\u0863९੭ଧు\u0D50ํ༣အᄳ");
      this.button110.UseVisualStyleBackColor = false;
      this.button110.Click += new EventHandler(this.button110_Click);
      this.button111.BackColor = Color.FromArgb(65, 65, 65);
      this.button111.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button111.FlatStyle = FlatStyle.Flat;
      this.button111.ForeColor = SystemColors.Control;
      this.button111.Location = new Point(358, 539);
      this.button111.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠰");
      this.button111.Size = new Size(142, 30);
      this.button111.TabIndex = 180;
      this.button111.Text = \u003F0\u003F.\u003F1\u003F("YŹɿ\u0378ѱԳٔݸ\u0877१\u0A7A\u0B64ౢ൬สཚၡᅪታ፤ᑨᕷ᙭ᝳ");
      this.button111.UseVisualStyleBackColor = false;
      this.button111.Click += new EventHandler(this.button111_Click);
      this.button112.BackColor = Color.FromArgb(65, 65, 65);
      this.button112.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button112.FlatStyle = FlatStyle.Flat;
      this.button112.ForeColor = SystemColors.Control;
      this.button112.Location = new Point(1070, 374);
      this.button112.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠳");
      this.button112.Size = new Size(142, 30);
      this.button112.TabIndex = 179;
      this.button112.Text = \u003F0\u003F.\u003F1\u003F("EřȨ͌чՑؤ݄ࡗै");
      this.button112.UseVisualStyleBackColor = false;
      this.button112.Click += new EventHandler(this.button112_Click);
      this.button113.BackColor = Color.FromArgb(65, 65, 65);
      this.button113.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button113.FlatStyle = FlatStyle.Flat;
      this.button113.ForeColor = SystemColors.Control;
      this.button113.Location = new Point(11, 572);
      this.button113.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠲");
      this.button113.Size = new Size(142, 30);
      this.button113.TabIndex = 178;
      this.button113.Text = \u003F0\u003F.\u003F1\u003F("Uűȯ͆Ѣգٯܪࡅ३ੳୣ\u0C76തไབྷ၈");
      this.button113.UseVisualStyleBackColor = false;
      this.button113.Click += new EventHandler(this.button113_Click);
      this.button114.BackColor = Color.FromArgb(65, 65, 65);
      this.button114.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button114.FlatStyle = FlatStyle.Flat;
      this.button114.ForeColor = SystemColors.Control;
      this.button114.Location = new Point(1070, 275);
      this.button114.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠵");
      this.button114.Size = new Size(142, 30);
      this.button114.TabIndex = 177;
      this.button114.Text = \u003F0\u003F.\u003F1\u003F("Pţɵͮѥդ٢ݬࠪख़੧୮౨\u0D71ฤངၗᅈ");
      this.button114.UseVisualStyleBackColor = false;
      this.button114.Click += new EventHandler(this.button114_Click);
      this.button115.BackColor = Color.FromArgb(65, 65, 65);
      this.button115.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button115.FlatStyle = FlatStyle.Flat;
      this.button115.ForeColor = SystemColors.Control;
      this.button115.Location = new Point(1070, 122);
      this.button115.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠴");
      this.button115.Size = new Size(142, 51);
      this.button115.TabIndex = 176;
      this.button115.Text = \u003F0\u003F.\u003F1\u003F("NŴɲʹѽշطݚ\u087Cॲ\u0A76ଲౖ\u0D45ๆ\u0F2Eၱᄬቀ\u136Fᑰᕊᙵᝣᡲᤤᩋ᭷ᱣ");
      this.button115.UseVisualStyleBackColor = false;
      this.button115.Click += new EventHandler(this.button115_Click);
      this.button116.BackColor = Color.FromArgb(65, 65, 65);
      this.button116.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button116.FlatStyle = FlatStyle.Flat;
      this.button116.ForeColor = SystemColors.Control;
      this.button116.Location = new Point(1070, 176);
      this.button116.Name = \u003F0\u003F.\u003F1\u003F("kŽɳͲѪժزܳ࠷");
      this.button116.Size = new Size(142, 30);
      this.button116.TabIndex = 175;
      this.button116.Text = \u003F0\u003F.\u003F1\u003F("GŻɻͿѴ\u0560خ݁\u0865७੯\u0B29\u0C49\u0D72\u0E72ཪၢᅢተ\u136C");
      this.button116.UseVisualStyleBackColor = false;
      this.button116.Click += new EventHandler(this.button116_Click);
      this.label8.AutoSize = true;
      this.label8.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label8.ForeColor = SystemColors.Control;
      this.label8.Location = new Point(1109, 52);
      this.label8.Name = \u003F0\u003F.\u003F1\u003F("jŤɦͦѮԹ");
      this.label8.Size = new Size(70, 25);
      this.label8.TabIndex = 191;
      this.label8.Text = \u003F0\u003F.\u003F1\u003F("BťɮͧѲ");
      this.button87.BackColor = Color.FromArgb(65, 65, 65);
      this.button87.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 45);
      this.button87.FlatStyle = FlatStyle.Flat;
      this.button87.ForeColor = SystemColors.Control;
      this.button87.Location = new Point(529, 122);
      this.button87.Name = \u003F0\u003F.\u003F1\u003F("jŲɲͱѫխغܶ");
      this.button87.Size = new Size(142, 51);
      this.button87.TabIndex = 201;
      this.button87.Text = \u003F0\u003F.\u003F1\u003F("OŻɩ̼шճٴݭ\u087Bॷ\u0A61\u0B7Bౡല้\u0F30ၜᅭቿ፥ᑻᕾᘩ\u1774ᠧ᥄ᩎᬤ᱓ᵧṵ");
      this.button87.UseVisualStyleBackColor = false;
      this.button87.Click += new EventHandler(this.button87_Click_1);
      this.panel3.BackColor = Color.Transparent;
      this.panel3.BorderStyle = BorderStyle.FixedSingle;
      this.panel3.ForeColor = SystemColors.ControlLightLight;
      this.panel3.Location = new Point(162, 88);
      this.panel3.Name = \u003F0\u003F.\u003F1\u003F("vŤɪͦѮԲ");
      this.panel3.Size = new Size(15, 549);
      this.panel3.TabIndex = 73;
      this.label11.AutoSize = true;
      this.label11.BackColor = Color.FromArgb(65, 65, 65);
      this.label11.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.ForeColor = Color.Red;
      this.label11.Location = new Point(650, 159);
      this.label11.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳذ");
      this.label11.Size = new Size(20, 13);
      this.label11.TabIndex = 17;
      this.label11.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label13.AutoSize = true;
      this.label13.BackColor = Color.FromArgb(65, 65, 65);
      this.label13.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label13.ForeColor = Color.Red;
      this.label13.Location = new Point(829, 159);
      this.label13.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳز");
      this.label13.Size = new Size(20, 13);
      this.label13.TabIndex = 203;
      this.label13.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label15.AutoSize = true;
      this.label15.BackColor = Color.FromArgb(65, 65, 65);
      this.label15.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label15.ForeColor = Color.Red;
      this.label15.Location = new Point(479, 257);
      this.label15.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳش");
      this.label15.Size = new Size(20, 13);
      this.label15.TabIndex = 204;
      this.label15.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label16.AutoSize = true;
      this.label16.BackColor = Color.FromArgb(65, 65, 65);
      this.label16.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label16.ForeColor = Color.Red;
      this.label16.Location = new Point(1009, 489);
      this.label16.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳط");
      this.label16.Size = new Size(20, 13);
      this.label16.TabIndex = 205;
      this.label16.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label18.AutoSize = true;
      this.label18.BackColor = Color.FromArgb(65, 65, 65);
      this.label18.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label18.ForeColor = Color.Red;
      this.label18.Location = new Point(478, 522);
      this.label18.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳع");
      this.label18.Size = new Size(20, 13);
      this.label18.TabIndex = 207;
      this.label18.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label23.AutoSize = true;
      this.label23.BackColor = Color.FromArgb(65, 65, 65);
      this.label23.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label23.ForeColor = Color.Red;
      this.label23.Location = new Point(829, 291);
      this.label23.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ز");
      this.label23.Size = new Size(20, 13);
      this.label23.TabIndex = 212;
      this.label23.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label24.AutoSize = true;
      this.label24.BackColor = Color.FromArgb(65, 65, 65);
      this.label24.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label24.ForeColor = Color.Red;
      this.label24.Location = new Point(1009, 159);
      this.label24.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ص");
      this.label24.Size = new Size(20, 13);
      this.label24.TabIndex = 213;
      this.label24.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label25.AutoSize = true;
      this.label25.BackColor = Color.FromArgb(65, 65, 65);
      this.label25.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label25.ForeColor = Color.Red;
      this.label25.Location = new Point(1009, 192);
      this.label25.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ش");
      this.label25.Size = new Size(20, 13);
      this.label25.TabIndex = 214;
      this.label25.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label26.AutoSize = true;
      this.label26.BackColor = Color.FromArgb(65, 65, 65);
      this.label26.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label26.ForeColor = Color.Red;
      this.label26.Location = new Point(1009, 291);
      this.label26.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ط");
      this.label26.Size = new Size(20, 13);
      this.label26.TabIndex = 215;
      this.label26.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label27.AutoSize = true;
      this.label27.BackColor = Color.FromArgb(65, 65, 65);
      this.label27.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label27.ForeColor = Color.Red;
      this.label27.Location = new Point(132, 588);
      this.label27.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ض");
      this.label27.Size = new Size(20, 13);
      this.label27.TabIndex = 216;
      this.label27.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label28.AutoSize = true;
      this.label28.BackColor = Color.FromArgb(65, 65, 65);
      this.label28.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label28.ForeColor = Color.Red;
      this.label28.Location = new Point(479, 291);
      this.label28.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ع");
      this.label28.Size = new Size(20, 13);
      this.label28.TabIndex = 217;
      this.label28.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label29.AutoSize = true;
      this.label29.BackColor = Color.FromArgb(65, 65, 65);
      this.label29.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label29.ForeColor = Color.Red;
      this.label29.Location = new Point(479, 357);
      this.label29.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯ\u0530ظ");
      this.label29.Size = new Size(20, 13);
      this.label29.TabIndex = 218;
      this.label29.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label30.AutoSize = true;
      this.label30.BackColor = Color.FromArgb(65, 65, 65);
      this.label30.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label30.ForeColor = Color.Red;
      this.label30.Location = new Point(304, 104);
      this.label30.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԱر");
      this.label30.Size = new Size(20, 13);
      this.label30.TabIndex = 219;
      this.label30.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label33.AutoSize = true;
      this.label33.BackColor = Color.FromArgb(65, 65, 65);
      this.label33.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label33.ForeColor = Color.Red;
      this.label33.Location = new Point(650, 489);
      this.label33.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԱز");
      this.label33.Size = new Size(20, 13);
      this.label33.TabIndex = 222;
      this.label33.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label34.AutoSize = true;
      this.label34.BackColor = Color.FromArgb(65, 65, 65);
      this.label34.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label34.ForeColor = Color.Red;
      this.label34.Location = new Point(304, 159);
      this.label34.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԱص");
      this.label34.Size = new Size(20, 13);
      this.label34.TabIndex = 223;
      this.label34.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label36.AutoSize = true;
      this.label36.BackColor = Color.FromArgb(65, 65, 65);
      this.label36.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label36.ForeColor = Color.Red;
      this.label36.Location = new Point(1009, 621);
      this.label36.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԱط");
      this.label36.Size = new Size(20, 13);
      this.label36.TabIndex = 225;
      this.label36.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label37.AutoSize = true;
      this.label37.BackColor = Color.FromArgb(65, 65, 65);
      this.label37.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label37.ForeColor = Color.Red;
      this.label37.Location = new Point(479, 456);
      this.label37.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԱض");
      this.label37.Size = new Size(20, 13);
      this.label37.TabIndex = 226;
      this.label37.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label38.AutoSize = true;
      this.label38.BackColor = Color.FromArgb(65, 65, 65);
      this.label38.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label38.ForeColor = Color.Red;
      this.label38.Location = new Point(829, 489);
      this.label38.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԱع");
      this.label38.Size = new Size(20, 13);
      this.label38.TabIndex = 227;
      this.label38.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label40.AutoSize = true;
      this.label40.BackColor = Color.FromArgb(65, 65, 65);
      this.label40.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label40.ForeColor = Color.Red;
      this.label40.Location = new Point(131, 456);
      this.label40.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԶر");
      this.label40.Size = new Size(20, 13);
      this.label40.TabIndex = 229;
      this.label40.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label12.AutoSize = true;
      this.label12.BackColor = Color.FromArgb(65, 65, 65);
      this.label12.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label12.ForeColor = Color.Red;
      this.label12.Location = new Point(304, 456);
      this.label12.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳس");
      this.label12.Size = new Size(20, 13);
      this.label12.TabIndex = 230;
      this.label12.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label41.AutoSize = true;
      this.label41.BackColor = Color.FromArgb(65, 65, 65);
      this.label41.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label41.ForeColor = Color.Red;
      this.label41.Location = new Point(829, 555);
      this.label41.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԶذ");
      this.label41.Size = new Size(20, 13);
      this.label41.TabIndex = 232;
      this.label41.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label17.AutoSize = true;
      this.label17.BackColor = Color.FromArgb(65, 65, 65);
      this.label17.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label17.ForeColor = Color.Red;
      this.label17.Location = new Point(650, 423);
      this.label17.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳض");
      this.label17.Size = new Size(20, 13);
      this.label17.TabIndex = 233;
      this.label17.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.label19.AutoSize = true;
      this.label19.BackColor = Color.FromArgb(65, 65, 65);
      this.label19.Font = new Font(\u003F0\u003F.\u003F1\u003F("Bŵɨ͡ѨԬٞ݃ࠩज़\u0A62୫౬൦\u0E6C\u0F6Eၥ"), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label19.ForeColor = Color.Red;
      this.label19.Location = new Point(1191, 324);
      this.label19.Name = \u003F0\u003F.\u003F1\u003F("kŧɧ͡ѯԳظ");
      this.label19.Size = new Size(20, 13);
      this.label19.TabIndex = 234;
      this.label19.Text = \u003F0\u003F.\u003F1\u003F("✕");
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(50, 50, 50);
      this.ClientSize = new Size(1237, 688);
      this.Controls.Add((Control) this.label19);
      this.Controls.Add((Control) this.label17);
      this.Controls.Add((Control) this.label41);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.label40);
      this.Controls.Add((Control) this.label38);
      this.Controls.Add((Control) this.label37);
      this.Controls.Add((Control) this.label36);
      this.Controls.Add((Control) this.label34);
      this.Controls.Add((Control) this.label33);
      this.Controls.Add((Control) this.label30);
      this.Controls.Add((Control) this.label29);
      this.Controls.Add((Control) this.label28);
      this.Controls.Add((Control) this.label27);
      this.Controls.Add((Control) this.label26);
      this.Controls.Add((Control) this.label25);
      this.Controls.Add((Control) this.label24);
      this.Controls.Add((Control) this.label23);
      this.Controls.Add((Control) this.label18);
      this.Controls.Add((Control) this.label16);
      this.Controls.Add((Control) this.label15);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.button60);
      this.Controls.Add((Control) this.panel3);
      this.Controls.Add((Control) this.button87);
      this.Controls.Add((Control) this.button82);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.panel8);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.button30);
      this.Controls.Add((Control) this.button33);
      this.Controls.Add((Control) this.button43);
      this.Controls.Add((Control) this.button61);
      this.Controls.Add((Control) this.button71);
      this.Controls.Add((Control) this.button102);
      this.Controls.Add((Control) this.button108);
      this.Controls.Add((Control) this.button109);
      this.Controls.Add((Control) this.button110);
      this.Controls.Add((Control) this.button111);
      this.Controls.Add((Control) this.button112);
      this.Controls.Add((Control) this.button113);
      this.Controls.Add((Control) this.button114);
      this.Controls.Add((Control) this.button115);
      this.Controls.Add((Control) this.button116);
      this.Controls.Add((Control) this.button106);
      this.Controls.Add((Control) this.button105);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.panel7);
      this.Controls.Add((Control) this.button88);
      this.Controls.Add((Control) this.button89);
      this.Controls.Add((Control) this.button90);
      this.Controls.Add((Control) this.button91);
      this.Controls.Add((Control) this.button92);
      this.Controls.Add((Control) this.button93);
      this.Controls.Add((Control) this.button94);
      this.Controls.Add((Control) this.button95);
      this.Controls.Add((Control) this.button96);
      this.Controls.Add((Control) this.button97);
      this.Controls.Add((Control) this.button98);
      this.Controls.Add((Control) this.button99);
      this.Controls.Add((Control) this.button100);
      this.Controls.Add((Control) this.button101);
      this.Controls.Add((Control) this.button103);
      this.Controls.Add((Control) this.button104);
      this.Controls.Add((Control) this.button83);
      this.Controls.Add((Control) this.button84);
      this.Controls.Add((Control) this.button85);
      this.Controls.Add((Control) this.button86);
      this.Controls.Add((Control) this.button81);
      this.Controls.Add((Control) this.button80);
      this.Controls.Add((Control) this.button79);
      this.Controls.Add((Control) this.button78);
      this.Controls.Add((Control) this.button77);
      this.Controls.Add((Control) this.button76);
      this.Controls.Add((Control) this.button75);
      this.Controls.Add((Control) this.button74);
      this.Controls.Add((Control) this.button73);
      this.Controls.Add((Control) this.button70);
      this.Controls.Add((Control) this.button69);
      this.Controls.Add((Control) this.button68);
      this.Controls.Add((Control) this.button72);
      this.Controls.Add((Control) this.button67);
      this.Controls.Add((Control) this.button66);
      this.Controls.Add((Control) this.button65);
      this.Controls.Add((Control) this.button64);
      this.Controls.Add((Control) this.button63);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.panel6);
      this.Controls.Add((Control) this.button51);
      this.Controls.Add((Control) this.button52);
      this.Controls.Add((Control) this.button53);
      this.Controls.Add((Control) this.button54);
      this.Controls.Add((Control) this.button55);
      this.Controls.Add((Control) this.button56);
      this.Controls.Add((Control) this.button57);
      this.Controls.Add((Control) this.button58);
      this.Controls.Add((Control) this.button59);
      this.Controls.Add((Control) this.button62);
      this.Controls.Add((Control) this.button38);
      this.Controls.Add((Control) this.button50);
      this.Controls.Add((Control) this.button49);
      this.Controls.Add((Control) this.button48);
      this.Controls.Add((Control) this.button47);
      this.Controls.Add((Control) this.button46);
      this.Controls.Add((Control) this.button45);
      this.Controls.Add((Control) this.button44);
      this.Controls.Add((Control) this.button42);
      this.Controls.Add((Control) this.button40);
      this.Controls.Add((Control) this.button39);
      this.Controls.Add((Control) this.button37);
      this.Controls.Add((Control) this.button36);
      this.Controls.Add((Control) this.button41);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.panel5);
      this.Controls.Add((Control) this.panel4);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.button25);
      this.Controls.Add((Control) this.button26);
      this.Controls.Add((Control) this.button27);
      this.Controls.Add((Control) this.button28);
      this.Controls.Add((Control) this.button29);
      this.Controls.Add((Control) this.button31);
      this.Controls.Add((Control) this.button32);
      this.Controls.Add((Control) this.button34);
      this.Controls.Add((Control) this.button35);
      this.Controls.Add((Control) this.button24);
      this.Controls.Add((Control) this.button21);
      this.Controls.Add((Control) this.button23);
      this.Controls.Add((Control) this.button22);
      this.Controls.Add((Control) this.button20);
      this.Controls.Add((Control) this.button19);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.button18);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button17);
      this.Controls.Add((Control) this.button16);
      this.Controls.Add((Control) this.button13);
      this.Controls.Add((Control) this.button11);
      this.Controls.Add((Control) this.button9);
      this.Controls.Add((Control) this.button7);
      this.Controls.Add((Control) this.button15);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.button14);
      this.Controls.Add((Control) this.button12);
      this.Controls.Add((Control) this.button10);
      this.Controls.Add((Control) this.button8);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject(\u003F0\u003F.\u003F1\u003F(".Žɠͮѵԫٍݠ\u086D९"));
      this.Name = \u003F0\u003F.\u003F1\u003F("Zūɵͯѵհًݷ\u0863");
      this.StartPosition = FormStartPosition.CenterScreen;
      this.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
      this.StateCommon.Border.Rounding = 10;
      this.Text = \u003F0\u003F.\u003F1\u003F("Zūɵͯѵհًݷ\u0863");
      this.Load += new EventHandler(this.ScriptHub_Load_1);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void ScriptHub_Load(object sender, EventArgs e)
    {
    }
  }
}
