// Decompiled with JetBrains decompiler
// Type: Vega_X.Functions
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

using System.IO;
using System.Windows.Forms;

namespace Vega_X
{
  internal class Functions
  {
    public static OpenFileDialog OpenFile;

    public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
    {
      foreach (FileInfo file in new DirectoryInfo(Folder).GetFiles(FileType))
        lsb.Items.Add((object) file.Name);
    }

    static Functions()
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = \u003F0\u003F.\u003F1\u003F("cśɌ̌ѭՃمݍࡔआ\u0A0D\u0B0E\u0C0Dൎ๔ཁံᅢሷጲᑷᕯᙸᝤᡃᥳᩭ᭠ᰳᵔṸὼ\u206Aⅽ∭⌤␡╾♱\u277C⠮⥺⨯⬪ⱷ\u2D7A\u2E75");
      Functions.OpenFile = openFileDialog;
    }
  }
}
