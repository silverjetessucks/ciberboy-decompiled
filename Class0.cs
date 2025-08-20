using System;
using System.IO;
using System.Media;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
internal class Class0
{
  private Random random_0 = new Random();
  [CompilerGenerated]
  private static Func<int, int>[] func_0 = new Func<int, int>[10]
  {
    (Func<int, int>) (t => t & t >> 13),
    (Func<int, int>) (t => t * (t >> 12 | t >> 8) ^ (t >> (t >> (t << 2 | t >> 7)) | t >> t / 2 | t >> t / 4)),
    (Func<int, int>) (t => (t >> 10) * (t >> 8) + t),
    (Func<int, int>) (t => (t ^ (t >> t) / 5 + t << 5) + (t >> 5) * (t >> 14)),
    (Func<int, int>) (t => t / 7 ^ t >> 6 >> (t >> 3)),
    (Func<int, int>) (t => t * t >> 21),
    (Func<int, int>) (t => t * (t >> 12 | t >> 8) ^ (t >> (t >> (t << 2 | t >> 7)) | t >> t / 2 | t >> t / 4)),
    (Func<int, int>) (t => t & t >> 13),
    (Func<int, int>) (t => t * new Random().Next(int.MaxValue)),
    (Func<int, int>) (t => t * new Random().Next(int.MaxValue))
  };

  public static void smethod_0()
  {
    Thread thread = new Thread((ThreadStart) (() => Class0.smethod_6()));
    thread.Start();
    thread.Join();
    thread.Start();
  }

  [CompilerGenerated]
  [SpecialName]
  public static Func<int, int>[] smethod_1() => Class0.func_0;

  [CompilerGenerated]
  [SpecialName]
  public static void smethod_2(object object_0) => Class0.func_0 = (Func<int, int>[]) object_0;

  private static byte[] smethod_3(Func<int, int> func_1)
  {
    byte[] numArray = new byte[1440000];
    for (int index = 0; index < 1440000; ++index)
      numArray[index] = (byte) (func_1(index) & (int) byte.MaxValue);
    return numArray;
  }

  private static void smethod_4(byte[] byte_0, string string_0)
  {
    using (FileStream output = new FileStream(string_0, FileMode.Create))
    {
      using (BinaryWriter binaryWriter = new BinaryWriter((Stream) output))
      {
        binaryWriter.Write(new char[4]{ 'R', 'I', 'F', 'F' });
        binaryWriter.Write(36 + byte_0.Length);
        binaryWriter.Write(new char[4]{ 'W', 'A', 'V', 'E' });
        binaryWriter.Write(new char[4]{ 'f', 'm', 't', ' ' });
        binaryWriter.Write(16);
        binaryWriter.Write((short) 1);
        binaryWriter.Write((short) 1);
        binaryWriter.Write(48000);
        binaryWriter.Write(48000);
        binaryWriter.Write((short) 1);
        binaryWriter.Write((short) 8);
        binaryWriter.Write(new char[4]{ 'd', 'a', 't', 'a' });
        binaryWriter.Write(byte_0.Length);
        binaryWriter.Write(byte_0);
      }
    }
  }

  private static void smethod_5(byte[] byte_0)
  {
    string tempFileName = Path.GetTempFileName();
    Class0.smethod_4(byte_0, tempFileName);
    using (SoundPlayer soundPlayer = new SoundPlayer(tempFileName))
      soundPlayer.PlaySync();
    File.Delete(tempFileName);
  }

  public static void smethod_6()
  {
    // ISSUE: reference to a compiler-generated field
    foreach (Func<int, int> func_1 in Class0.func_0)
      Class0.smethod_5(Class0.smethod_3(func_1));
  }
}
