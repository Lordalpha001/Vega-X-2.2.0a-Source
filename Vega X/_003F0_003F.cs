// Decompiled with JetBrains decompiler
// Type: ?0?
// Assembly: Vega X, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8501888B-B958-4D70-B33E-3180FEC6B608
// Assembly location: D:\Vega X - v2.2.0a\Vega X - v2.2.0a\Vega X.exe

public class \u003F0\u003F
{
  public static string \u003F1\u003F(string _param0)
  {
    int length = _param0.Length;
    char[] chArray = new char[length];
    for (int index = 0; index < chArray.Length; ++index)
    {
      char ch = _param0[index];
      byte num1 = (byte) ((uint) ch ^ (uint) (length - index));
      byte num2 = (byte) ((int) ch >> 8 ^ index);
      chArray[index] = (char) ((uint) num2 << 8 | (uint) num1);
    }
    return string.Intern(new string(chArray));
  }
}
