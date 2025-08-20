using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class5
{
  private static bool bool_0 = false;
  private static Class5.Delegate7 delegate7_0;
  private static Class5.Delegate10 delegate10_0;
  private static Class5.Delegate8 delegate8_0;
  private static int[] int_0;
  private static bool bool_1;
  private static long long_0;
  private static Dictionary<int, int> MbqQvAhky1;
  private static Class5.Delegate9 delegate9_0;
  private static int int_1;
  private static byte[] byte_0;
  private static int int_2;
  private static IntPtr intptr_0;
  [Class5.Attribute0(typeof (Class5.Attribute0.Class6<object>[]))]
  private static bool bool_2;
  internal static object object_0;
  private static List<int> list_0;
  private static byte[] byte_1;
  internal static Hashtable hashtable_0;
  private static long long_1;
  private static bool bool_3;
  private static IntPtr intptr_1;
  private static uint[] uint_0;
  private static int int_3;
  private static IntPtr intptr_2;
  private static int int_4;
  private static bool bool_4;
  private static bool bool_5;
  internal static Class5.Delegate3 delegate3_0;
  internal static Class5.Delegate3 delegate3_1;
  private static bool bool_6;
  private static IntPtr intptr_3;
  internal static Assembly assembly_0 = typeof (Class5).Assembly;
  private static Class5.Delegate5 delegate5_0;
  private static object object_1;
  private static int int_5;
  private static Class5.Delegate6 delegate6_0;
  private static string[] string_0;
  private static SortedList sortedList_0;
  private static List<string> list_1;
  private static object object_2;

  static Class5()
  {
    Class5.uint_0 = new uint[64]
    {
      3614090360U,
      3905402710U,
      606105819U,
      3250441966U,
      4118548399U,
      1200080426U,
      2821735955U,
      4249261313U,
      1770035416U,
      2336552879U,
      4294925233U,
      2304563134U,
      1804603682U,
      4254626195U,
      2792965006U,
      1236535329U,
      4129170786U,
      3225465664U,
      643717713U,
      3921069994U,
      3593408605U,
      38016083U,
      3634488961U,
      3889429448U,
      568446438U,
      3275163606U,
      4107603335U,
      1163531501U,
      2850285829U,
      4243563512U,
      1735328473U,
      2368359562U,
      4294588738U,
      2272392833U,
      1839030562U,
      4259657740U,
      2763975236U,
      1272893353U,
      4139469664U,
      3200236656U,
      681279174U,
      3936430074U,
      3572445317U,
      76029189U,
      3654602809U,
      3873151461U,
      530742520U,
      3299628645U,
      4096336452U,
      1126891415U,
      2878612391U,
      4237533241U,
      1700485571U,
      2399980690U,
      4293915773U,
      2240044497U,
      1873313359U,
      4264355552U,
      2734768916U,
      1309151649U,
      4149444226U,
      3174756917U,
      718787259U,
      3951481745U
    };
    Class5.bool_5 = false;
    Class5.bool_3 = false;
    Class5.object_0 = (object) null;
    Class5.MbqQvAhky1 = (Dictionary<int, int>) null;
    Class5.object_2 = new object();
    Class5.int_2 = 0;
    Class5.object_1 = new object();
    Class5.list_1 = (List<string>) null;
    Class5.list_0 = (List<int>) null;
    Class5.byte_1 = new byte[0];
    Class5.byte_0 = new byte[0];
    Class5.intptr_2 = IntPtr.Zero;
    Class5.intptr_0 = IntPtr.Zero;
    Class5.string_0 = new string[0];
    Class5.int_0 = new int[0];
    Class5.int_5 = 1;
    Class5.bool_6 = false;
    Class5.sortedList_0 = new SortedList();
    Class5.int_4 = 0;
    Class5.long_0 = 0L;
    Class5.delegate3_0 = (Class5.Delegate3) null;
    Class5.delegate3_1 = (Class5.Delegate3) null;
    Class5.long_1 = 0L;
    Class5.int_3 = 0;
    Class5.bool_1 = false;
    Class5.bool_4 = false;
    Class5.int_1 = 0;
    Class5.intptr_3 = IntPtr.Zero;
    Class5.bool_2 = false;
    Class5.hashtable_0 = new Hashtable();
    Class5.delegate5_0 = (Class5.Delegate5) null;
    Class5.delegate6_0 = (Class5.Delegate6) null;
    Class5.delegate7_0 = (Class5.Delegate7) null;
    Class5.delegate8_0 = (Class5.Delegate8) null;
    Class5.delegate9_0 = (Class5.Delegate9) null;
    Class5.delegate10_0 = (Class5.Delegate10) null;
    Class5.intptr_1 = IntPtr.Zero;
    try
    {
      RSACryptoServiceProvider.UseMachineKeyStore = true;
    }
    catch
    {
    }
  }

  private void method_0()
  {
  }

  internal static byte[] smethod_0(object object_3)
  {
    uint[] object_3_1 = new uint[16];
    uint num1 = (uint) ((448 - object_3.Length * 8 % 512 + 512) % 512);
    if (num1 == 0U)
      num1 = 512U;
    uint length = (uint) ((long) object_3.Length + (long) (num1 / 8U) + 8L);
    ulong num2 = (ulong) object_3.Length * 8UL;
    byte[] numArray = new byte[(int) length];
    for (int index = 0; index < object_3.Length; ++index)
      numArray[index] = (byte) object_3[index];
    numArray[object_3.Length] |= (byte) 128;
    for (int index = 8; index > 0; --index)
      numArray[(long) length - (long) index] = (byte) (num2 >> (8 - index) * 8 & (ulong) byte.MaxValue);
    uint num3 = (uint) (numArray.Length * 8) / 32U;
    uint uint_1_1 = 1732584193;
    uint uint_1_2 = 4023233417;
    uint uint_1_3 = 2562383102;
    uint uint_1_4 = 271733878;
    for (uint index1 = 0; index1 < num3 / 16U; ++index1)
    {
      uint num4 = index1 << 6;
      for (uint index2 = 0; index2 < 61U; index2 += 4U)
        object_3_1[(int) (index2 >> 2)] = (uint) ((int) numArray[(int) num4 + ((int) index2 + 3)] << 24 | (int) numArray[(int) num4 + ((int) index2 + 2)] << 16 | (int) numArray[(int) num4 + ((int) index2 + 1)] << 8) | (uint) numArray[(int) num4 + (int) index2];
      uint num5 = uint_1_1;
      uint num6 = uint_1_2;
      uint num7 = uint_1_3;
      uint num8 = uint_1_4;
      Class5.smethod_1(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 0U, (ushort) 7, 1U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 1U, (ushort) 12, 2U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 2U, (ushort) 17, 3U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 3U, (ushort) 22, 4U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 4U, (ushort) 7, 5U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 5U, (ushort) 12, 6U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 6U, (ushort) 17, 7U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 7U, (ushort) 22, 8U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 8U, (ushort) 7, 9U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 9U, (ushort) 12, 10U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 10U, (ushort) 17, 11U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 11U, (ushort) 22, 12U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 12U, (ushort) 7, 13U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 13U, (ushort) 12, 14U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 14U, (ushort) 17, 15U, (object) object_3_1);
      Class5.smethod_1(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 15U, (ushort) 22, 16U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 1U, (ushort) 5, 17U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 6U, (ushort) 9, 18U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 11U, (ushort) 14, 19U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 0U, (ushort) 20, 20U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 5U, (ushort) 5, 21U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 10U, (ushort) 9, 22U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 15U, (ushort) 14, 23U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 4U, (ushort) 20, 24U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 9U, (ushort) 5, 25U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 14U, (ushort) 9, 26U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 3U, (ushort) 14, 27U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 8U, (ushort) 20, 28U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 13U, (ushort) 5, 29U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 2U, (ushort) 9, 30U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 7U, (ushort) 14, 31U, (object) object_3_1);
      Class5.smethod_2(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 12U, (ushort) 20, 32U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 5U, (ushort) 4, 33U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 8U, (ushort) 11, 34U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 11U, (ushort) 16, 35U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 14U, (ushort) 23, 36U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 1U, (ushort) 4, 37U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 4U, (ushort) 11, 38U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 7U, (ushort) 16, 39U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 10U, (ushort) 23, 40U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 13U, (ushort) 4, 41U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 0U, (ushort) 11, 42U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 3U, (ushort) 16, 43U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 6U, (ushort) 23, 44U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 9U, (ushort) 4, 45U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 12U, (ushort) 11, 46U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 15U, (ushort) 16, 47U, (object) object_3_1);
      Class5.smethod_3(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 2U, (ushort) 23, 48U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 0U, (ushort) 6, 49U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 7U, (ushort) 10, 50U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 14U, (ushort) 15, 51U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 5U, (ushort) 21, 52U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 12U, (ushort) 6, 53U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 3U, (ushort) 10, 54U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 10U, (ushort) 15, 55U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 1U, (ushort) 21, 56U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 8U, (ushort) 6, 57U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 15U, (ushort) 10, 58U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 6U, (ushort) 15, 59U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 13U, (ushort) 21, 60U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_1, uint_1_2, uint_1_3, uint_1_4, 4U, (ushort) 6, 61U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_4, uint_1_1, uint_1_2, uint_1_3, 11U, (ushort) 10, 62U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_3, uint_1_4, uint_1_1, uint_1_2, 2U, (ushort) 15, 63U, (object) object_3_1);
      Class5.smethod_4(ref uint_1_2, uint_1_3, uint_1_4, uint_1_1, 9U, (ushort) 21, 64U, (object) object_3_1);
      uint_1_1 += num5;
      uint_1_2 += num6;
      uint_1_3 += num7;
      uint_1_4 += num8;
    }
    byte[] destinationArray = new byte[16];
    Array.Copy((Array) BitConverter.GetBytes(uint_1_1), 0, (Array) destinationArray, 0, 4);
    Array.Copy((Array) BitConverter.GetBytes(uint_1_2), 0, (Array) destinationArray, 4, 4);
    Array.Copy((Array) BitConverter.GetBytes(uint_1_3), 0, (Array) destinationArray, 8, 4);
    Array.Copy((Array) BitConverter.GetBytes(uint_1_4), 0, (Array) destinationArray, 12, 4);
    return destinationArray;
  }

  private static void smethod_1(
    ref uint uint_1,
    uint uint_2,
    uint uint_3,
    uint uint_4,
    uint uint_5,
    ushort ushort_0,
    uint uint_6,
    object object_3)
  {
    uint_1 = uint_2 + Class5.smethod_5(uint_1 + (uint) ((int) uint_2 & (int) uint_3 | ~(int) uint_2 & (int) uint_4) + (uint) object_3[(int) uint_5] + Class5.uint_0[(int) uint_6 - 1], ushort_0);
  }

  private static void smethod_2(
    ref uint uint_1,
    uint uint_2,
    uint uint_3,
    uint uint_4,
    uint uint_5,
    ushort ushort_0,
    uint uint_6,
    object object_3)
  {
    uint_1 = uint_2 + Class5.smethod_5(uint_1 + (uint) ((int) uint_2 & (int) uint_4 | (int) uint_3 & ~(int) uint_4) + (uint) object_3[(int) uint_5] + Class5.uint_0[(int) uint_6 - 1], ushort_0);
  }

  private static void smethod_3(
    ref uint uint_1,
    uint uint_2,
    uint uint_3,
    uint uint_4,
    uint uint_5,
    ushort ushort_0,
    uint uint_6,
    object object_3)
  {
    uint_1 = uint_2 + Class5.smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + (uint) object_3[(int) uint_5] + Class5.uint_0[(int) uint_6 - 1], ushort_0);
  }

  private static void smethod_4(
    ref uint uint_1,
    uint uint_2,
    uint uint_3,
    uint uint_4,
    uint uint_5,
    ushort ushort_0,
    uint uint_6,
    object object_3)
  {
    uint_1 = uint_2 + Class5.smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + (uint) object_3[(int) uint_5] + Class5.uint_0[(int) uint_6 - 1], ushort_0);
  }

  private static uint smethod_5(uint uint_1, ushort ushort_0)
  {
    return uint_1 >> 32 - (int) ushort_0 | uint_1 << (int) ushort_0;
  }

  internal static bool smethod_6()
  {
    if (!Class5.bool_5)
    {
      Class5.smethod_8();
      Class5.bool_5 = true;
    }
    return Class5.bool_3;
  }

  internal Class5()
  {
  }

  private void bcYlbtpnnE(byte[] byte_2, byte[] byte_3, byte[] byte_4)
  {
    int num1 = byte_4.Length % 4;
    int num2 = byte_4.Length / 4;
    byte[] numArray = new byte[byte_4.Length];
    int num3 = byte_2.Length / 4;
    uint num4 = 0;
    if (num1 > 0)
      ++num2;
    for (int index1 = 0; index1 < num2; ++index1)
    {
      int num5 = index1 % num3;
      int index2 = index1 * 4;
      uint index3 = (uint) (num5 * 4);
      uint num6 = (uint) ((int) byte_2[(int) index3 + 3] << 24 | (int) byte_2[(int) index3 + 2] << 16 | (int) byte_2[(int) index3 + 1] << 8) | (uint) byte_2[(int) index3];
      uint maxValue = (uint) byte.MaxValue;
      int num7 = 0;
      uint num8;
      uint num9;
      if (index1 == num2 - 1 && num1 > 0)
      {
        num8 = 0U;
        num9 = num4 + num6;
        for (int index4 = 0; index4 < num1; ++index4)
        {
          if (index4 > 0)
            num8 <<= 8;
          num8 |= (uint) byte_4[byte_4.Length - (1 + index4)];
        }
      }
      else
      {
        num9 = num4 + num6;
        uint index5 = (uint) index2;
        num8 = (uint) ((int) byte_4[(int) index5 + 3] << 24 | (int) byte_4[(int) index5 + 2] << 16 | (int) byte_4[(int) index5 + 1] << 8) | (uint) byte_4[(int) index5];
      }
      int num10 = (int) num9;
      uint num11 = 1887561676;
      uint num12 = (uint) num10;
      uint num13 = 1698083717;
      num13 = 209171268U;
      uint num14 = (uint) (18902373 * ((int) num12 & 63)) + (num12 >> 6);
      num11 = 748174338U;
      ulong num15 = 2341404752;
      num15 = 2341404753UL;
      uint num16 = (uint) (7401476UL % ((ulong) (num14 * num14) | 1UL));
      uint num17 = num14 / 209171268U + 209171268U;
      uint num18 = num14 + num14 + num17 + num14;
      uint num19 = (uint) (107923705UL % ((ulong) (928470899U * num14) | 1UL));
      uint num20 = (num14 ^ num14 << 7) + num16;
      uint num21 = (num20 ^ num20 << 18) + num18;
      uint num22 = (num21 ^ num21 >> 1) + num19;
      num4 = (uint) num10 + (uint) (double) (((num22 << 12) - num22 ^ num16) + num22);
      if (index1 == num2 - 1 && num1 > 0)
      {
        uint num23 = num4 ^ num8;
        for (int index6 = 0; index6 < num1; ++index6)
        {
          if (index6 > 0)
          {
            maxValue <<= 8;
            num7 += 8;
          }
          numArray[index2 + index6] = (byte) ((num23 & maxValue) >> num7);
        }
      }
      else
      {
        uint num24 = num4 ^ num8;
        numArray[index2] = (byte) (num24 & (uint) byte.MaxValue);
        numArray[index2 + 1] = (byte) ((num24 & 65280U) >> 8);
        numArray[index2 + 2] = (byte) ((num24 & 16711680U) >> 16);
        numArray[index2 + 3] = (byte) ((num24 & 4278190080U) >> 24);
      }
    }
    Class5.byte_1 = numArray;
  }

  internal static SymmetricAlgorithm smethod_7()
  {
    if (Class5.smethod_6())
      return (SymmetricAlgorithm) new AesCryptoServiceProvider();
    try
    {
      return (SymmetricAlgorithm) new RijndaelManaged();
    }
    catch
    {
      try
      {
        return (SymmetricAlgorithm) Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
      }
      catch
      {
        return (SymmetricAlgorithm) Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
      }
    }
  }

  internal static void smethod_8()
  {
    try
    {
      MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
    }
    catch
    {
      Class5.bool_3 = true;
      return;
    }
    try
    {
      Class5.bool_3 = CryptoConfig.AllowOnlyFipsAlgorithms;
    }
    catch
    {
    }
  }

  internal static byte[] smethod_9(byte[] byte_2)
  {
    return !Class5.smethod_6() ? new MD5CryptoServiceProvider().ComputeHash(byte_2) : Class5.smethod_0((object) byte_2);
  }

  internal static void UgZlfUthnQ(
    HashAlgorithm hashAlgorithm_0,
    Stream stream_0,
    uint uint_1,
    byte[] byte_2)
  {
    int num;
    for (; uint_1 > 0U; uint_1 -= (uint) num)
    {
      num = uint_1 > (uint) byte_2.Length ? byte_2.Length : (int) uint_1;
      stream_0.Read(byte_2, 0, num);
      Class5.smethod_10(hashAlgorithm_0, byte_2, 0, num);
    }
  }

  internal static void smethod_10(
    HashAlgorithm hashAlgorithm_0,
    byte[] byte_2,
    int int_6,
    int int_7)
  {
    hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
  }

  internal static uint smethod_11(
    uint uint_1,
    int int_6,
    long long_2,
    BinaryReader binaryReader_0)
  {
    for (int index = 0; index < int_6; ++index)
    {
      binaryReader_0.BaseStream.Position = long_2 + (long) (index * 40 + 8);
      uint num1 = binaryReader_0.ReadUInt32();
      uint num2 = binaryReader_0.ReadUInt32();
      int num3 = (int) binaryReader_0.ReadUInt32();
      uint num4 = binaryReader_0.ReadUInt32();
      if (num2 <= uint_1 && uint_1 < num2 + num1)
        return num4 + uint_1 - num2;
    }
    return 0;
  }

  private static void smethod_12(Stream stream_0, int int_6)
  {
    Class5.Class8 class8 = new Class5.Class8(stream_0);
    class8.method_0().Position = 0L;
    byte[] numArray1 = class8.method_1((int) class8.method_0().Length);
    class8.method_4();
    byte[] numArray2 = new byte[32];
    numArray2[0] = (byte) 127;
    numArray2[0] = (byte) 156;
    numArray2[0] = (byte) 113;
    numArray2[0] = (byte) 140;
    numArray2[1] = (byte) 108;
    numArray2[1] = (byte) 96;
    numArray2[1] = (byte) 67;
    numArray2[2] = (byte) 172;
    numArray2[2] = (byte) 114;
    numArray2[2] = (byte) 96;
    numArray2[2] = (byte) 104;
    numArray2[2] = (byte) 103;
    numArray2[2] = (byte) 248;
    numArray2[3] = (byte) 128;
    numArray2[3] = (byte) 69;
    numArray2[3] = (byte) 168;
    numArray2[3] = (byte) 134;
    numArray2[3] = (byte) 42;
    numArray2[3] = (byte) 244;
    numArray2[4] = (byte) 77;
    numArray2[4] = (byte) 161;
    numArray2[4] = (byte) 72;
    numArray2[4] = (byte) 141;
    numArray2[4] = (byte) 122;
    numArray2[4] = (byte) 71;
    numArray2[5] = (byte) 96;
    numArray2[5] = (byte) 66;
    numArray2[5] = (byte) 221;
    numArray2[6] = (byte) 91;
    numArray2[6] = (byte) 92;
    numArray2[6] = (byte) 134;
    numArray2[6] = (byte) 196;
    numArray2[7] = (byte) 76;
    numArray2[7] = (byte) 175;
    numArray2[7] = (byte) 197;
    numArray2[8] = (byte) 154;
    numArray2[8] = (byte) 182;
    numArray2[8] = (byte) 158;
    numArray2[9] = (byte) 105;
    numArray2[9] = (byte) 104;
    numArray2[9] = (byte) 98;
    numArray2[9] = (byte) 116;
    numArray2[9] = (byte) 181;
    numArray2[10] = (byte) 113;
    numArray2[10] = (byte) 78;
    numArray2[10] = (byte) 164;
    numArray2[10] = (byte) 153;
    numArray2[10] = (byte) 93;
    numArray2[10] = (byte) 84;
    numArray2[11] = (byte) 144;
    numArray2[11] = (byte) 137;
    numArray2[11] = (byte) 78;
    numArray2[11] = (byte) 119;
    numArray2[11] = (byte) 235;
    numArray2[12] = (byte) 165;
    numArray2[12] = (byte) 36;
    numArray2[12] = (byte) 124;
    numArray2[13] = (byte) 92;
    numArray2[13] = (byte) 143;
    numArray2[13] = (byte) 146;
    numArray2[13] = (byte) 119;
    numArray2[13] = (byte) 147;
    numArray2[13] = (byte) 60;
    numArray2[14] = (byte) 120;
    numArray2[14] = (byte) 114;
    numArray2[14] = (byte) 127;
    numArray2[14] = (byte) 174;
    numArray2[15] = (byte) 88;
    numArray2[15] = (byte) 103;
    numArray2[15] = (byte) 92;
    numArray2[15] = (byte) 145;
    numArray2[15] = (byte) 175;
    numArray2[16] = (byte) 105;
    numArray2[16] = (byte) 152;
    numArray2[16] = (byte) 89;
    numArray2[17] = (byte) 148;
    numArray2[17] = (byte) 42;
    numArray2[17] = (byte) 200;
    numArray2[18] = (byte) 106;
    numArray2[18] = (byte) 205;
    numArray2[18] = (byte) 170;
    numArray2[18] = (byte) 132;
    numArray2[19] = (byte) 136;
    numArray2[19] = (byte) 147;
    numArray2[19] = (byte) 131;
    numArray2[19] = (byte) 134;
    numArray2[19] = (byte) 62;
    numArray2[20] = (byte) 126;
    numArray2[20] = (byte) 143;
    numArray2[20] = (byte) 54;
    numArray2[20] = (byte) 251;
    numArray2[21] = (byte) 100;
    numArray2[21] = (byte) 130;
    numArray2[21] = (byte) 104;
    numArray2[21] = (byte) 14;
    numArray2[21] = (byte) 53;
    numArray2[22] = (byte) 127;
    numArray2[22] = (byte) 131;
    numArray2[22] = (byte) 186;
    numArray2[23] = (byte) 110;
    numArray2[23] = (byte) 116;
    numArray2[23] = (byte) 187;
    numArray2[24] = (byte) 99;
    numArray2[24] = (byte) 134;
    numArray2[24] = (byte) 66;
    numArray2[25] = (byte) 88;
    numArray2[25] = (byte) 156;
    numArray2[25] = (byte) 180;
    numArray2[25] = (byte) 155;
    numArray2[25] = (byte) 96;
    numArray2[25] = (byte) 64;
    numArray2[26] = (byte) 110;
    numArray2[26] = (byte) 111;
    numArray2[26] = (byte) 115;
    numArray2[26] = (byte) 105;
    numArray2[27] = (byte) 142;
    numArray2[27] = (byte) 120;
    numArray2[27] = (byte) 105;
    numArray2[27] = (byte) 100;
    numArray2[27] = (byte) 110;
    numArray2[28] = (byte) 139;
    numArray2[28] = (byte) 126;
    numArray2[28] = (byte) 90;
    numArray2[29] = (byte) 135;
    numArray2[29] = (byte) 35;
    numArray2[29] = (byte) 137;
    numArray2[29] = (byte) 63;
    numArray2[29] = (byte) 54;
    numArray2[29] = (byte) 20;
    numArray2[30] = (byte) 86;
    numArray2[30] = (byte) 180;
    numArray2[30] = (byte) 163;
    numArray2[30] = (byte) 143;
    numArray2[30] = (byte) 24;
    numArray2[31] = (byte) 157;
    numArray2[31] = (byte) 124;
    numArray2[31] = (byte) 144;
    numArray2[31] = (byte) 29;
    byte[] numArray3 = numArray2;
    byte[] numArray4 = new byte[16];
    numArray4[0] = (byte) 66;
    numArray4[0] = (byte) 93;
    numArray4[0] = (byte) 110;
    numArray4[0] = (byte) 59;
    numArray4[0] = (byte) 136;
    numArray4[0] = (byte) 239;
    numArray4[1] = (byte) 154;
    numArray4[1] = (byte) 76;
    numArray4[1] = (byte) 104;
    numArray4[1] = (byte) 146;
    numArray4[1] = (byte) 124;
    numArray4[1] = (byte) 231;
    numArray4[2] = (byte) 74;
    numArray4[2] = (byte) 129;
    numArray4[2] = (byte) 173;
    numArray4[2] = (byte) 116;
    numArray4[2] = (byte) 113;
    numArray4[2] = (byte) 50;
    numArray4[3] = (byte) 123;
    numArray4[3] = (byte) 197;
    numArray4[3] = (byte) 72;
    numArray4[3] = (byte) 37;
    numArray4[4] = (byte) 97;
    numArray4[4] = (byte) 108;
    numArray4[4] = (byte) 135;
    numArray4[4] = (byte) 186;
    numArray4[5] = (byte) 101;
    numArray4[5] = (byte) 119;
    numArray4[5] = (byte) 91;
    numArray4[5] = (byte) 112;
    numArray4[6] = (byte) 65;
    numArray4[6] = (byte) 150;
    numArray4[6] = (byte) 98;
    numArray4[6] = (byte) 133;
    numArray4[6] = (byte) 216;
    numArray4[7] = (byte) 218;
    numArray4[7] = (byte) 127;
    numArray4[7] = (byte) 88;
    numArray4[7] = (byte) 105;
    numArray4[7] = (byte) 209;
    numArray4[8] = (byte) 126;
    numArray4[8] = (byte) 88;
    numArray4[8] = (byte) 164;
    numArray4[8] = (byte) 219;
    numArray4[8] = (byte) 95;
    numArray4[8] = (byte) 174;
    numArray4[9] = (byte) 154;
    numArray4[9] = (byte) 165;
    numArray4[9] = (byte) 96;
    numArray4[9] = (byte) 6;
    numArray4[10] = (byte) 156;
    numArray4[10] = (byte) 125;
    numArray4[10] = (byte) 86;
    numArray4[11] = (byte) 136;
    numArray4[11] = (byte) 116;
    numArray4[11] = (byte) 94;
    numArray4[11] = (byte) 79;
    numArray4[12] = (byte) 165;
    numArray4[12] = (byte) 98;
    numArray4[12] = (byte) 181;
    numArray4[12] = (byte) 39;
    numArray4[12] = (byte) 220;
    numArray4[13] = (byte) 127;
    numArray4[13] = (byte) 125;
    numArray4[13] = (byte) 150;
    numArray4[13] = (byte) 43;
    numArray4[14] = (byte) 84;
    numArray4[14] = (byte) 150;
    numArray4[14] = (byte) 153;
    numArray4[14] = (byte) 138;
    numArray4[15] = (byte) 100;
    numArray4[15] = (byte) 103;
    numArray4[15] = (byte) 112;
    numArray4[15] = (byte) 181;
    numArray4[15] = (byte) 59;
    byte[] numArray5 = numArray4;
    Array.Reverse((Array) numArray5);
    byte[] publicKeyToken = Class5.assembly_0.GetName().GetPublicKeyToken();
    if (publicKeyToken != null && publicKeyToken.Length != 0)
    {
      numArray5[1] = publicKeyToken[0];
      numArray5[3] = publicKeyToken[1];
      numArray5[5] = publicKeyToken[2];
      numArray5[7] = publicKeyToken[3];
      numArray5[9] = publicKeyToken[4];
      numArray5[11] = publicKeyToken[5];
      numArray5[13] = publicKeyToken[6];
      numArray5[15] = publicKeyToken[7];
    }
    for (int index = 0; index < numArray5.Length; ++index)
      numArray3[index] = (byte) ((uint) numArray3[index] ^ (uint) numArray5[index]);
    if (int_6 == -1)
    {
      SymmetricAlgorithm symmetricAlgorithm = Class5.smethod_7();
      symmetricAlgorithm.Mode = CipherMode.CBC;
      ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor(numArray3, numArray5);
      Stream stream = (Stream) new MemoryStream();
      CryptoStream cryptoStream = new CryptoStream(stream, decryptor, CryptoStreamMode.Write);
      cryptoStream.Write(numArray1, 0, numArray1.Length);
      cryptoStream.FlushFinalBlock();
      Class5.byte_1 = Class5.smethod_28((MemoryStream) stream);
      stream.Close();
      cryptoStream.Close();
      numArray1 = Class5.byte_1;
    }
    if (Class5.assembly_0.EntryPoint == (MethodInfo) null)
      Class5.int_2 = 80;
    new Class5().bcYlbtpnnE(numArray3, numArray5, numArray1);
  }

  internal static string smethod_13(string string_1)
  {
    "{11111-22222-50001-00000}".Trim();
    byte[] bytes = Convert.FromBase64String(string_1);
    return Encoding.Unicode.GetString(bytes, 0, bytes.Length);
  }

  internal static uint smethod_14(
    IntPtr intptr_4,
    IntPtr intptr_5,
    IntPtr intptr_6,
    [MarshalAs(UnmanagedType.U4)] uint uint_1,
    IntPtr intptr_7,
    ref uint uint_2)
  {
    IntPtr ptr = intptr_6;
    if (Class5.bool_0)
      ptr = intptr_5;
    long key = IntPtr.Size != 4 ? Marshal.ReadInt64(ptr, IntPtr.Size * 2) : (long) Marshal.ReadInt32(ptr, IntPtr.Size * 2);
    object obj = Class5.hashtable_0[(object) key];
    if (obj == null)
      return Class5.delegate3_0(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
    Class5.Struct3 struct3 = (Class5.Struct3) obj;
    IntPtr num1 = Marshal.AllocCoTaskMem(struct3.byte_0.Length);
    Marshal.Copy(struct3.byte_0, 0, num1, struct3.byte_0.Length);
    if (struct3.bool_0)
    {
      intptr_7 = num1;
      uint_2 = (uint) struct3.byte_0.Length;
      Class5.smethod_23(intptr_7, struct3.byte_0.Length, 64, ref Class5.int_1);
      return 0;
    }
    Marshal.WriteIntPtr(ptr, IntPtr.Size * 2, num1);
    Marshal.WriteInt32(ptr, IntPtr.Size * 3, struct3.byte_0.Length);
    uint num2 = 0;
    if (uint_1 == 216669565U && !Class5.bool_2)
      Class5.bool_2 = true;
    else
      num2 = Class5.delegate3_0(intptr_4, intptr_5, intptr_6, uint_1, intptr_7, ref uint_2);
    return num2;
  }

  private static int smethod_15() => 5;

  private static void smethod_16()
  {
    try
    {
      RSACryptoServiceProvider.UseMachineKeyStore = true;
    }
    catch
    {
    }
  }

  private static Delegate smethod_17(IntPtr intptr_4, Type type_0)
  {
    return (Delegate) typeof (Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
    {
      typeof (IntPtr),
      typeof (Type)
    }).Invoke((object) null, new object[2]
    {
      (object) intptr_4,
      (object) type_0
    });
  }

  internal static unsafe void smethod_18()
  {
    if (!Class5.bool_6)
    {
      Class5.bool_6 = true;
      long num1 = 0;
      Marshal.ReadIntPtr(new IntPtr((void*) &num1), 0);
      Marshal.ReadInt32(new IntPtr((void*) &num1), 0);
      Marshal.ReadInt64(new IntPtr((void*) &num1), 0);
      Marshal.WriteIntPtr(new IntPtr((void*) &num1), 0, IntPtr.Zero);
      Marshal.WriteInt32(new IntPtr((void*) &num1), 0, 0);
      Marshal.WriteInt64(new IntPtr((void*) &num1), 0, 0L);
      Marshal.Copy(new byte[1], 0, Marshal.AllocCoTaskMem(8), 1);
      Class5.smethod_16();
      if (IntPtr.Size == 4 && Type.GetType("System.Reflection.ReflectionContext", false) != (Type) null)
      {
        foreach (ProcessModule module in (ReadOnlyCollectionBase) Process.GetCurrentProcess().Modules)
        {
          if (module.ModuleName.ToLower() == "clrjit.dll")
          {
            Version version1 = new Version(module.FileVersionInfo.ProductMajorPart, module.FileVersionInfo.ProductMinorPart, module.FileVersionInfo.ProductBuildPart, module.FileVersionInfo.ProductPrivatePart);
            Version version2 = new Version(4, 0, 30319, 17020);
            Version version3 = new Version(4, 0, 30319, 17921);
            if (version1 >= version2 && version1 < version3)
            {
              Class5.bool_0 = true;
              break;
            }
          }
        }
      }
      Class5.Class8 class8_1 = new Class5.Class8(Class5.assembly_0.GetManifestResourceStream("pbDJqG55PYuFygOPGg.8Y1cUmabFwjSx6V9qB"));
      class8_1.method_0().Position = 0L;
      byte[] buffer1 = class8_1.method_1((int) class8_1.method_0().Length);
      byte[] numArray1 = new byte[32];
      numArray1[0] = (byte) 182;
      numArray1[0] = (byte) 102;
      numArray1[0] = (byte) 92;
      numArray1[0] = (byte) 107;
      numArray1[1] = (byte) 155;
      numArray1[1] = (byte) 153;
      numArray1[1] = (byte) 33;
      numArray1[1] = (byte) 206;
      numArray1[2] = (byte) 116;
      numArray1[2] = (byte) 180;
      numArray1[2] = (byte) 154;
      numArray1[2] = (byte) 52;
      numArray1[3] = (byte) 92;
      numArray1[3] = (byte) 119;
      numArray1[3] = (byte) 206;
      numArray1[3] = (byte) 174;
      numArray1[4] = (byte) 38;
      numArray1[4] = (byte) 71;
      numArray1[4] = (byte) 134;
      numArray1[4] = (byte) 137;
      numArray1[5] = (byte) 101;
      numArray1[5] = (byte) 77;
      numArray1[5] = (byte) 103;
      numArray1[5] = (byte) 86;
      numArray1[5] = (byte) 84;
      numArray1[5] = (byte) 16;
      numArray1[6] = (byte) 211;
      numArray1[6] = (byte) 50;
      numArray1[6] = (byte) 130;
      numArray1[6] = (byte) 98;
      numArray1[6] = (byte) 201;
      numArray1[6] = (byte) 202;
      numArray1[7] = (byte) 109;
      numArray1[7] = (byte) 156;
      numArray1[7] = (byte) 105;
      numArray1[8] = (byte) 107;
      numArray1[8] = (byte) 182;
      numArray1[8] = (byte) 196;
      numArray1[9] = (byte) 104;
      numArray1[9] = (byte) 220;
      numArray1[9] = (byte) 88;
      numArray1[9] = (byte) 110;
      numArray1[9] = (byte) 195;
      numArray1[10] = (byte) 85;
      numArray1[10] = (byte) 139;
      numArray1[10] = (byte) 147;
      numArray1[10] = (byte) 85;
      numArray1[10] = (byte) 89;
      numArray1[10] = (byte) 243;
      numArray1[11] = (byte) 152;
      numArray1[11] = (byte) 96;
      numArray1[11] = (byte) 43;
      numArray1[12] = (byte) 145;
      numArray1[12] = (byte) 141;
      numArray1[12] = (byte) 150;
      numArray1[12] = (byte) 136;
      numArray1[12] = (byte) 92;
      numArray1[13] = (byte) 90;
      numArray1[13] = (byte) 143;
      numArray1[13] = (byte) 113;
      numArray1[13] = (byte) 122;
      numArray1[13] = (byte) 151;
      numArray1[13] = (byte) 173;
      numArray1[14] = (byte) 114;
      numArray1[14] = (byte) 144;
      numArray1[14] = (byte) 189;
      numArray1[14] = (byte) 193;
      numArray1[14] = (byte) 21;
      numArray1[15] = (byte) 110;
      numArray1[15] = (byte) 54;
      numArray1[15] = (byte) 136;
      numArray1[15] = (byte) 118;
      numArray1[15] = (byte) 103;
      numArray1[16] = (byte) 182;
      numArray1[16] = (byte) 122;
      numArray1[16] = (byte) 182;
      numArray1[17] = (byte) 76;
      numArray1[17] = (byte) 128;
      numArray1[17] = (byte) 74;
      numArray1[18] = (byte) 50;
      numArray1[18] = (byte) 132;
      numArray1[18] = (byte) 83;
      numArray1[19] = (byte) 147;
      numArray1[19] = (byte) 188;
      numArray1[19] = (byte) 187;
      numArray1[19] = (byte) 146;
      numArray1[19] = (byte) 174;
      numArray1[20] = (byte) 108;
      numArray1[20] = (byte) 128;
      numArray1[20] = (byte) 172;
      numArray1[20] = (byte) 218;
      numArray1[20] = (byte) 89;
      numArray1[21] = (byte) 142;
      numArray1[21] = (byte) 119;
      numArray1[21] = (byte) 128;
      numArray1[21] = (byte) 50;
      numArray1[22] = (byte) 110;
      numArray1[22] = (byte) 200;
      numArray1[22] = (byte) 158;
      numArray1[22] = (byte) 58;
      numArray1[23] = (byte) 150;
      numArray1[23] = (byte) 101;
      numArray1[23] = (byte) 89;
      numArray1[23] = (byte) 200;
      numArray1[24] = (byte) 155;
      numArray1[24] = (byte) 174;
      numArray1[24] = (byte) 11;
      numArray1[25] = (byte) 121;
      numArray1[25] = (byte) 144;
      numArray1[25] = (byte) 119;
      numArray1[25] = (byte) 173;
      numArray1[26] = (byte) 118;
      numArray1[26] = (byte) 112;
      numArray1[26] = (byte) 229;
      numArray1[27] = (byte) 162;
      numArray1[27] = (byte) 104;
      numArray1[27] = (byte) 151;
      numArray1[27] = (byte) 119;
      numArray1[28] = (byte) 164;
      numArray1[28] = (byte) 114;
      numArray1[28] = (byte) 136;
      numArray1[28] = (byte) 158;
      numArray1[28] = (byte) 91;
      numArray1[29] = (byte) 128;
      numArray1[29] = (byte) 134;
      numArray1[29] = (byte) 92;
      numArray1[29] = (byte) 80;
      numArray1[30] = (byte) 181;
      numArray1[30] = (byte) 99;
      numArray1[30] = (byte) 105;
      numArray1[30] = (byte) 110;
      numArray1[30] = (byte) 200;
      numArray1[30] = (byte) 5;
      numArray1[31] = (byte) 151;
      numArray1[31] = (byte) 112;
      numArray1[31] = (byte) 118;
      numArray1[31] = (byte) 215;
      numArray1[31] = (byte) 171;
      byte[] rgbKey = numArray1;
      byte[] numArray2 = new byte[16];
      numArray2[0] = (byte) 182;
      numArray2[0] = (byte) 134;
      numArray2[0] = (byte) 101;
      numArray2[0] = (byte) 99;
      numArray2[0] = (byte) 183;
      numArray2[1] = (byte) 125;
      numArray2[1] = (byte) 53;
      numArray2[1] = (byte) 139;
      numArray2[1] = (byte) 104;
      numArray2[1] = (byte) 135;
      numArray2[1] = (byte) 175;
      numArray2[2] = (byte) 166;
      numArray2[2] = (byte) 154;
      numArray2[2] = (byte) 84;
      numArray2[2] = (byte) 149;
      numArray2[3] = (byte) 152;
      numArray2[3] = (byte) 163;
      numArray2[3] = (byte) 102;
      numArray2[3] = (byte) 124;
      numArray2[3] = (byte) 61;
      numArray2[3] = (byte) 250;
      numArray2[4] = (byte) 86;
      numArray2[4] = (byte) 101;
      numArray2[4] = (byte) 77;
      numArray2[4] = (byte) 13;
      numArray2[5] = (byte) 167;
      numArray2[5] = (byte) 130;
      numArray2[5] = (byte) 59;
      numArray2[5] = (byte) 158;
      numArray2[5] = (byte) 236;
      numArray2[6] = (byte) 66;
      numArray2[6] = (byte) 98;
      numArray2[6] = (byte) 201;
      numArray2[6] = (byte) 122;
      numArray2[6] = (byte) 45;
      numArray2[6] = (byte) 102;
      numArray2[7] = (byte) 122;
      numArray2[7] = (byte) 94;
      numArray2[7] = (byte) 205;
      numArray2[7] = (byte) 128;
      numArray2[7] = (byte) 178;
      numArray2[8] = (byte) 170;
      numArray2[8] = (byte) 115;
      numArray2[8] = (byte) 108;
      numArray2[8] = (byte) 154;
      numArray2[8] = (byte) 64;
      numArray2[8] = (byte) 129;
      numArray2[9] = (byte) 103;
      numArray2[9] = (byte) 109;
      numArray2[9] = (byte) 89;
      numArray2[9] = (byte) 178;
      numArray2[9] = (byte) 96;
      numArray2[9] = (byte) 132;
      numArray2[10] = (byte) 207;
      numArray2[10] = (byte) 141;
      numArray2[10] = (byte) 198;
      numArray2[11] = (byte) 127;
      numArray2[11] = (byte) 114;
      numArray2[11] = (byte) 166;
      numArray2[11] = (byte) 116;
      numArray2[11] = (byte) 65;
      numArray2[12] = (byte) 86;
      numArray2[12] = (byte) 160;
      numArray2[12] = (byte) 121;
      numArray2[12] = (byte) 102;
      numArray2[12] = (byte) 137;
      numArray2[12] = (byte) 251;
      numArray2[13] = (byte) 158;
      numArray2[13] = (byte) 110;
      numArray2[13] = (byte) 92;
      numArray2[13] = (byte) 95;
      numArray2[13] = (byte) 29;
      numArray2[14] = (byte) 118;
      numArray2[14] = (byte) 157;
      numArray2[14] = (byte) 168;
      numArray2[14] = (byte) 84;
      numArray2[15] = (byte) 95;
      numArray2[15] = (byte) 94;
      numArray2[15] = (byte) 164;
      numArray2[15] = (byte) 162;
      numArray2[15] = (byte) 69;
      numArray2[15] = (byte) 50;
      byte[] rgbIV = numArray2;
      Array.Reverse((Array) rgbIV);
      byte[] publicKeyToken = Class5.assembly_0.GetName().GetPublicKeyToken();
      if (publicKeyToken != null && publicKeyToken.Length != 0)
      {
        rgbIV[1] = publicKeyToken[0];
        rgbIV[3] = publicKeyToken[1];
        rgbIV[5] = publicKeyToken[2];
        rgbIV[7] = publicKeyToken[3];
        rgbIV[9] = publicKeyToken[4];
        rgbIV[11] = publicKeyToken[5];
        rgbIV[13] = publicKeyToken[6];
        rgbIV[15] = publicKeyToken[7];
        Array.Clear((Array) publicKeyToken, 0, publicKeyToken.Length);
      }
      for (int index = 0; index < rgbIV.Length; ++index)
        rgbKey[index] = (byte) ((uint) rgbKey[index] ^ (uint) rgbIV[index]);
      byte[] numArray3 = buffer1;
      int num2 = numArray3.Length % 4;
      int num3 = numArray3.Length / 4;
      byte[] numArray4 = new byte[numArray3.Length];
      int num4 = rgbKey.Length / 4;
      uint num5 = 0;
      if (num2 > 0)
        ++num3;
      for (int index1 = 0; index1 < num3; ++index1)
      {
        int num6 = index1 % num4;
        int index2 = index1 * 4;
        uint index3 = (uint) (num6 * 4);
        uint num7 = (uint) ((int) rgbKey[(int) index3 + 3] << 24 | (int) rgbKey[(int) index3 + 2] << 16 | (int) rgbKey[(int) index3 + 1] << 8) | (uint) rgbKey[(int) index3];
        uint maxValue = (uint) byte.MaxValue;
        int num8 = 0;
        uint num9;
        uint num10;
        if (index1 == num3 - 1 && num2 > 0)
        {
          num9 = num5 + num7;
          num10 = 0U;
          for (int index4 = 0; index4 < num2; ++index4)
          {
            if (index4 > 0)
              num10 <<= 8;
            num10 |= (uint) numArray3[numArray3.Length - (1 + index4)];
          }
        }
        else
        {
          uint index5 = (uint) index2;
          num9 = num5 + num7;
          num10 = (uint) ((int) numArray3[(int) index5 + 3] << 24 | (int) numArray3[(int) index5 + 2] << 16 | (int) numArray3[(int) index5 + 1] << 8) | (uint) numArray3[(int) index5];
        }
        uint num11 = num9;
        int num12 = (int) num11;
        int num13 = (int) num11;
        uint num14 = 1887561676;
        uint num15 = (uint) num13;
        uint num16 = 1698083717;
        num16 = 209171268U;
        uint num17 = (uint) (18902373 * ((int) num15 & 63)) + (num15 >> 6);
        num14 = 748174338U;
        ulong num18 = 2341404752;
        num18 = 2341404753UL;
        uint num19 = (uint) (7401476UL % ((ulong) (num17 * num17) | 1UL));
        uint num20 = num17 / 209171268U + 209171268U;
        uint num21 = num17 + num17 + num20 + num17;
        uint num22 = (uint) (107923705UL % ((ulong) (928470899U * num17) | 1UL));
        uint num23 = (num17 ^ num17 << 7) + num19;
        uint num24 = (num23 ^ num23 << 18) + num21;
        uint num25 = (num24 ^ num24 >> 1) + num22;
        int num26 = (int) (uint) (double) (((num25 << 12) - num25 ^ num19) + num25);
        num5 = (uint) (num12 + num26);
        if (index1 == num3 - 1 && num2 > 0)
        {
          uint num27 = num5 ^ num10;
          for (int index6 = 0; index6 < num2; ++index6)
          {
            if (index6 > 0)
            {
              maxValue <<= 8;
              num8 += 8;
            }
            numArray4[index2 + index6] = (byte) ((num27 & maxValue) >> num8);
          }
        }
        else
        {
          uint num28 = num5 ^ num10;
          numArray4[index2] = (byte) (num28 & (uint) byte.MaxValue);
          numArray4[index2 + 1] = (byte) ((num28 & 65280U) >> 8);
          numArray4[index2 + 2] = (byte) ((num28 & 16711680U) >> 16);
          numArray4[index2 + 3] = (byte) ((num28 & 4278190080U) >> 24);
        }
      }
      byte[] buffer2 = numArray4;
      int num29 = buffer2.Length / 8;
      fixed (byte* numPtr1 = buffer2)
      {
        for (int index = 0; index < num29; ++index)
        {
          byte* numPtr2 = numPtr1 + index * 8;
          *(long*) numPtr2 = *(long*) numPtr2 ^ 688277590L;
        }
      }
      Class5.Class8 class8_2 = new Class5.Class8((Stream) new MemoryStream(buffer2));
      class8_2.method_0().Position = 0L;
      long int64 = Marshal.GetHINSTANCE(Class5.assembly_0.GetModules()[0]).ToInt64();
      int int_8_1 = 0;
      int num30 = 0;
      if (Class5.assembly_0.Location == null || Class5.assembly_0.Location.Length == 0)
        num30 = 7680;
      class8_2.method_3();
      class8_2.method_3();
      class8_2.method_3();
      int num31 = class8_2.method_3();
      int num32 = class8_2.method_3();
      if (num32 == 4)
      {
        SymmetricAlgorithm symmetricAlgorithm = Class5.smethod_7();
        symmetricAlgorithm.Mode = CipherMode.CBC;
        ICryptoTransform decryptor = symmetricAlgorithm.CreateDecryptor(rgbKey, rgbIV);
        Array.Clear((Array) rgbKey, 0, rgbKey.Length);
        MemoryStream memoryStream = new MemoryStream();
        CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Write);
        cryptoStream.Write(buffer1, 0, buffer1.Length);
        cryptoStream.FlushFinalBlock();
        memoryStream.ToArray();
        Array.Clear((Array) rgbIV, 0, rgbIV.Length);
        memoryStream.Close();
        cryptoStream.Close();
        class8_2.method_4();
        num31 = class8_2.method_3();
        num32 = class8_2.method_3();
      }
      if (num32 == 1)
      {
        IntPtr zero = IntPtr.Zero;
        IntPtr intptr_4_1 = Class5.smethod_24(56U, 1, (uint) Process.GetCurrentProcess().Id);
        IntPtr hinstance;
        if (IntPtr.Size == 4)
        {
          hinstance = Marshal.GetHINSTANCE(Class5.assembly_0.GetModules()[0]);
          Class5.int_4 = hinstance.ToInt32();
        }
        hinstance = Marshal.GetHINSTANCE(Class5.assembly_0.GetModules()[0]);
        Class5.long_0 = hinstance.ToInt64();
        IntPtr intptr_6 = IntPtr.Zero;
        for (int index = 0; index < num31; ++index)
        {
          IntPtr num33 = new IntPtr(Class5.long_0 + (long) class8_2.method_3() - (long) num30);
          if (Class5.smethod_23(num33, 4, 4, ref int_8_1) == 0)
            Class5.smethod_23(num33, 4, 8, ref int_8_1);
          if (IntPtr.Size == 4)
            Class5.smethod_22(intptr_4_1, num33, BitConverter.GetBytes(class8_2.method_3()), 4U, out intptr_6);
          else
            Class5.smethod_22(intptr_4_1, num33, BitConverter.GetBytes(class8_2.method_3()), 4U, out intptr_6);
          Class5.smethod_23(num33, 4, int_8_1, ref int_8_1);
        }
        while (class8_2.method_0().Position < class8_2.method_0().Length - 1L)
        {
          int num34 = class8_2.method_3();
          IntPtr intptr_4_2 = new IntPtr(Class5.long_0 + (long) num34 - (long) num30);
          int num35 = class8_2.method_3();
          if (Class5.smethod_23(intptr_4_2, num35 * 4, 4, ref int_8_1) == 0)
            Class5.smethod_23(intptr_4_2, num35 * 4, 8, ref int_8_1);
          for (int index = 0; index < num35; ++index)
            Marshal.WriteInt32(new IntPtr(intptr_4_2.ToInt64() + (long) (index * 4)), class8_2.method_3());
          Class5.smethod_23(intptr_4_2, num35 * 4, int_8_1, ref int_8_1);
        }
        Class5.smethod_25(intptr_4_1);
      }
      else
      {
        for (int index = 0; index < num31; ++index)
        {
          IntPtr num36 = new IntPtr(int64 + (long) class8_2.method_3() - (long) num30);
          if (Class5.smethod_23(num36, 4, 4, ref int_8_1) == 0)
            Class5.smethod_23(num36, 4, 8, ref int_8_1);
          Marshal.WriteInt32(num36, class8_2.method_3());
          Class5.smethod_23(num36, 4, int_8_1, ref int_8_1);
        }
        Class5.hashtable_0 = new Hashtable(class8_2.method_3() + 1);
        Class5.hashtable_0.Add((object) 0L, (object) new Class5.Struct3()
        {
          byte_0 = new byte[1]{ (byte) 42 },
          bool_0 = false
        });
        while (class8_2.method_0().Position < class8_2.method_0().Length - 1L)
        {
          int num37 = class8_2.method_3() - num30;
          int num38 = class8_2.method_3();
          bool flag = false;
          if (num38 >= 1879048192)
            flag = true;
          int int_0 = class8_2.method_3();
          byte[] numArray5 = class8_2.method_1(int_0);
          Class5.hashtable_0.Add((object) (int64 + (long) num37), (object) new Class5.Struct3()
          {
            byte_0 = numArray5,
            bool_0 = flag
          });
        }
        Class5.long_1 = Marshal.GetHINSTANCE(typeof (Class5).Assembly.GetModules()[0]).ToInt64();
        if (IntPtr.Size == 4)
          Class5.int_3 = Convert.ToInt32(Class5.long_1);
        string string_1_1 = Encoding.UTF8.GetString(new byte[12]
        {
          (byte) 109,
          (byte) 115,
          (byte) 99,
          (byte) 111,
          (byte) 114,
          (byte) 106,
          (byte) 105,
          (byte) 116,
          (byte) 46,
          (byte) 100,
          (byte) 108,
          (byte) 108
        });
        IntPtr intptr_4 = IntPtr.Zero;
        if (intptr_4 == IntPtr.Zero)
        {
          string_1_1 = Encoding.UTF8.GetString(new byte[10]
          {
            (byte) 99,
            (byte) 108,
            (byte) 114,
            (byte) 106,
            (byte) 105,
            (byte) 116,
            (byte) 46,
            (byte) 100,
            (byte) 108,
            (byte) 108
          });
          intptr_4 = Class5.LoadLibrary(string_1_1);
        }
        string string_1_2 = Encoding.UTF8.GetString(new byte[6]
        {
          (byte) 103,
          (byte) 101,
          (byte) 116,
          (byte) 74,
          (byte) 105,
          (byte) 116
        });
        IntPtr ptr = ((Class5.Delegate4) Class5.smethod_17(Class5.GetProcAddress(intptr_4, string_1_2), typeof (Class5.Delegate4)))();
        long num39 = IntPtr.Size != 4 ? Marshal.ReadInt64(ptr) : (long) Marshal.ReadInt32(ptr);
        Marshal.ReadIntPtr(ptr, 0);
        Class5.delegate3_1 = new Class5.Delegate3(Class5.smethod_14);
        IntPtr zero = IntPtr.Zero;
        IntPtr pointerForDelegate = Marshal.GetFunctionPointerForDelegate((Delegate) Class5.delegate3_1);
        long num40 = IntPtr.Size != 4 ? Marshal.ReadInt64(new IntPtr(num39)) : (long) Marshal.ReadInt32(new IntPtr(num39));
        Process currentProcess = Process.GetCurrentProcess();
        try
        {
          foreach (ProcessModule module in (ReadOnlyCollectionBase) currentProcess.Modules)
          {
            if (module.ModuleName == string_1_1 && (num40 < module.BaseAddress.ToInt64() || num40 > module.BaseAddress.ToInt64() + (long) module.ModuleMemorySize) && typeof (Class5).Assembly.EntryPoint != (MethodInfo) null)
              return;
          }
        }
        catch
        {
        }
        try
        {
          foreach (ProcessModule module in (ReadOnlyCollectionBase) currentProcess.Modules)
          {
            if (module.BaseAddress.ToInt64() == Class5.long_1)
              break;
          }
        }
        catch
        {
        }
        Class5.delegate3_0 = (Class5.Delegate3) null;
        try
        {
          Class5.delegate3_0 = (Class5.Delegate3) Class5.smethod_17(new IntPtr(num40), typeof (Class5.Delegate3));
        }
        catch
        {
          try
          {
            Class5.delegate3_0 = (Class5.Delegate3) Delegate.CreateDelegate(typeof (Class5.Delegate3), Class5.smethod_17(new IntPtr(num40), typeof (Class5.Delegate3)).Method);
          }
          catch
          {
          }
        }
        int int_8_2 = 0;
        if (typeof (Class5).Assembly.EntryPoint != (MethodInfo) null && typeof (Class5).Assembly.EntryPoint.GetParameters().Length == 2 && typeof (Class5).Assembly.Location != null && typeof (Class5).Assembly.Location.Length > 0)
          return;
        try
        {
          object obj = typeof (Class5).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue((object) typeof (Class5).Assembly.ManifestModule.ModuleHandle);
          if (obj is IntPtr num41)
            Class5.intptr_3 = num41;
          if (obj.GetType().ToString() == "System.Reflection.RuntimeModule")
            Class5.intptr_3 = (IntPtr) obj.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).GetValue(obj);
          MemoryStream memoryStream = new MemoryStream();
          memoryStream.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
          if (IntPtr.Size == 4)
            memoryStream.Write(BitConverter.GetBytes(Class5.intptr_3.ToInt32()), 0, 4);
          else
            memoryStream.Write(BitConverter.GetBytes(Class5.intptr_3.ToInt64()), 0, 8);
          memoryStream.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
          memoryStream.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
          memoryStream.Position = 0L;
          byte[] array = memoryStream.ToArray();
          memoryStream.Close();
          uint nativeSizeOfCode = 0;
          fixed (byte* numPtr = array)
          {
            int num42 = (int) Class5.delegate3_1(new IntPtr((void*) numPtr), new IntPtr((void*) numPtr), new IntPtr((void*) numPtr), 216669565U, new IntPtr((void*) numPtr), ref nativeSizeOfCode);
          }
        }
        catch
        {
        }
        RuntimeHelpers.PrepareDelegate((Delegate) Class5.delegate3_0);
        RuntimeHelpers.PrepareMethod(Class5.delegate3_0.Method.MethodHandle);
        RuntimeHelpers.PrepareDelegate((Delegate) Class5.delegate3_1);
        RuntimeHelpers.PrepareMethod(Class5.delegate3_1.Method.MethodHandle);
        byte[] numArray6;
        if (IntPtr.Size != 4)
          numArray6 = new byte[40]
          {
            (byte) 72,
            (byte) 184,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 73,
            (byte) 57,
            (byte) 64,
            (byte) 8,
            (byte) 116,
            (byte) 12,
            (byte) 72,
            (byte) 184,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            byte.MaxValue,
            (byte) 224,
            (byte) 72,
            (byte) 184,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            (byte) 0,
            byte.MaxValue,
            (byte) 224
          };
        else
          numArray6 = new byte[30]
          {
            (byte) 85,
            (byte) 139,
            (byte) 236,
            (byte) 139,
            (byte) 69,
            (byte) 16,
            (byte) 129,
            (byte) 120,
            (byte) 4,
            (byte) 125,
            (byte) 29,
            (byte) 234,
            (byte) 12,
            (byte) 116,
            (byte) 7,
            (byte) 184,
            (byte) 182,
            (byte) 177,
            (byte) 74,
            (byte) 6,
            (byte) 235,
            (byte) 5,
            (byte) 184,
            (byte) 182,
            (byte) 146,
            (byte) 64,
            (byte) 12,
            (byte) 93,
            byte.MaxValue,
            (byte) 224
          };
        IntPtr num43 = Class5.smethod_21(IntPtr.Zero, (uint) numArray6.Length, 4096U, 64U);
        byte[] source = numArray6;
        byte[] bytes1;
        byte[] bytes2;
        byte[] bytes3;
        if (IntPtr.Size == 4)
        {
          bytes1 = BitConverter.GetBytes(Class5.intptr_3.ToInt32());
          bytes2 = BitConverter.GetBytes(pointerForDelegate.ToInt32());
          bytes3 = BitConverter.GetBytes(Convert.ToInt32(num40));
        }
        else
        {
          bytes1 = BitConverter.GetBytes(Class5.intptr_3.ToInt64());
          bytes2 = BitConverter.GetBytes(pointerForDelegate.ToInt64());
          bytes3 = BitConverter.GetBytes(num40);
        }
        if (IntPtr.Size == 4)
        {
          source[9] = bytes1[0];
          source[10] = bytes1[1];
          source[11] = bytes1[2];
          source[12] = bytes1[3];
          source[16] = bytes3[0];
          source[17] = bytes3[1];
          source[18] = bytes3[2];
          source[19] = bytes3[3];
          source[23] = bytes2[0];
          source[24] = bytes2[1];
          source[25] = bytes2[2];
          source[26] = bytes2[3];
        }
        else
        {
          source[2] = bytes1[0];
          source[3] = bytes1[1];
          source[4] = bytes1[2];
          source[5] = bytes1[3];
          source[6] = bytes1[4];
          source[7] = bytes1[5];
          source[8] = bytes1[6];
          source[9] = bytes1[7];
          source[18] = bytes3[0];
          source[19] = bytes3[1];
          source[20] = bytes3[2];
          source[21] = bytes3[3];
          source[22] = bytes3[4];
          source[23] = bytes3[5];
          source[24] = bytes3[6];
          source[25] = bytes3[7];
          source[30] = bytes2[0];
          source[31] = bytes2[1];
          source[32] = bytes2[2];
          source[33] = bytes2[3];
          source[34] = bytes2[4];
          source[35] = bytes2[5];
          source[36] = bytes2[6];
          source[37] = bytes2[7];
        }
        Marshal.Copy(source, 0, num43, source.Length);
        Class5.bool_1 = false;
        Class5.smethod_23(new IntPtr(num39), IntPtr.Size, 64, ref int_8_2);
        Marshal.WriteIntPtr(new IntPtr(num39), num43);
        Class5.smethod_23(new IntPtr(num39), IntPtr.Size, int_8_2, ref int_8_2);
      }
    }
  }

  internal static object smethod_19(Assembly assembly_1)
  {
    try
    {
      if (File.Exists(assembly_1.Location))
        return (object) assembly_1.Location;
    }
    catch
    {
    }
    try
    {
      if (File.Exists(assembly_1.GetName().CodeBase.ToString().Replace("file:///", "")))
        return (object) assembly_1.GetName().CodeBase.ToString().Replace("file:///", "");
    }
    catch
    {
    }
    try
    {
      if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue((object) assembly_1, new object[0]).ToString()))
        return (object) assembly_1.GetType().GetProperty("Location").GetValue((object) assembly_1, new object[0]).ToString();
    }
    catch
    {
    }
    return (object) "";
  }

  [DllImport("kernel32")]
  public static extern IntPtr LoadLibrary(string string_1);

  [DllImport("kernel32", CharSet = CharSet.Ansi)]
  public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

  private static IntPtr smethod_20(IntPtr intptr_4, string string_1, uint uint_1)
  {
    if (Class5.delegate5_0 == null)
      Class5.delegate5_0 = (Class5.Delegate5) Marshal.GetDelegateForFunctionPointer(Class5.GetProcAddress(Class5.smethod_26(), "Find ".Trim() + "ResourceA"), typeof (Class5.Delegate5));
    return Class5.delegate5_0(intptr_4, string_1, uint_1);
  }

  private static IntPtr smethod_21(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
  {
    if (Class5.delegate6_0 == null)
      Class5.delegate6_0 = (Class5.Delegate6) Marshal.GetDelegateForFunctionPointer(Class5.GetProcAddress(Class5.smethod_26(), "Virtual ".Trim() + "Alloc"), typeof (Class5.Delegate6));
    return Class5.delegate6_0(intptr_4, uint_1, uint_2, uint_3);
  }

  private static int smethod_22(
    IntPtr intptr_4,
    IntPtr intptr_5,
    [In, Out] byte[] byte_2,
    uint uint_1,
    out IntPtr intptr_6)
  {
    if (Class5.delegate7_0 == null)
      Class5.delegate7_0 = (Class5.Delegate7) Marshal.GetDelegateForFunctionPointer(Class5.GetProcAddress(Class5.smethod_26(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof (Class5.Delegate7));
    return Class5.delegate7_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
  }

  private static int smethod_23(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
  {
    if (Class5.delegate8_0 == null)
      Class5.delegate8_0 = (Class5.Delegate8) Marshal.GetDelegateForFunctionPointer(Class5.GetProcAddress(Class5.smethod_26(), "Virtual ".Trim() + "Protect"), typeof (Class5.Delegate8));
    return Class5.delegate8_0(intptr_4, int_6, int_7, ref int_8);
  }

  private static IntPtr smethod_24(uint uint_1, int int_6, uint uint_2)
  {
    if (Class5.delegate9_0 == null)
      Class5.delegate9_0 = (Class5.Delegate9) Marshal.GetDelegateForFunctionPointer(Class5.GetProcAddress(Class5.smethod_26(), "Open ".Trim() + "Process"), typeof (Class5.Delegate9));
    return Class5.delegate9_0(uint_1, int_6, uint_2);
  }

  private static int smethod_25(IntPtr intptr_4)
  {
    if (Class5.delegate10_0 == null)
      Class5.delegate10_0 = (Class5.Delegate10) Marshal.GetDelegateForFunctionPointer(Class5.GetProcAddress(Class5.smethod_26(), "Close ".Trim() + "Handle"), typeof (Class5.Delegate10));
    return Class5.delegate10_0(intptr_4);
  }

  [SpecialName]
  private static IntPtr smethod_26()
  {
    if (Class5.intptr_1 == IntPtr.Zero)
      Class5.intptr_1 = Class5.LoadLibrary("kernel ".Trim() + "32.dll");
    return Class5.intptr_1;
  }

  private static byte[] smethod_27(string string_1)
  {
    byte[] buffer;
    using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
    {
      int offset = 0;
      int length = (int) fileStream.Length;
      buffer = new byte[length];
      int num;
      for (; length > 0; length -= num)
      {
        num = fileStream.Read(buffer, offset, length);
        offset += num;
      }
    }
    return buffer;
  }

  internal static byte[] smethod_28(MemoryStream memoryStream_0) => memoryStream_0.ToArray();

  private static byte[] smethod_29(byte[] byte_2)
  {
    Stream stream = (Stream) new MemoryStream();
    SymmetricAlgorithm symmetricAlgorithm = Class5.smethod_7();
    symmetricAlgorithm.Key = new byte[32]
    {
      (byte) 98,
      (byte) 17,
      (byte) 11,
      (byte) 123,
      (byte) 180,
      (byte) 141,
      (byte) 201,
      (byte) 238,
      (byte) 129,
      (byte) 142,
      (byte) 135,
      (byte) 230,
      (byte) 8,
      (byte) 69,
      (byte) 231,
      (byte) 130,
      (byte) 151,
      (byte) 31,
      (byte) 189,
      (byte) 253,
      (byte) 219,
      (byte) 180,
      (byte) 184,
      (byte) 30,
      (byte) 139,
      (byte) 195,
      (byte) 135,
      (byte) 117,
      (byte) 202,
      (byte) 75,
      (byte) 202,
      (byte) 151
    };
    symmetricAlgorithm.IV = new byte[16]
    {
      (byte) 167,
      (byte) 87,
      (byte) 12,
      (byte) 177,
      (byte) 27,
      (byte) 18,
      (byte) 222,
      (byte) 173,
      (byte) 61,
      (byte) 121,
      (byte) 171,
      (byte) 188,
      (byte) 122,
      (byte) 91,
      (byte) 94,
      (byte) 115
    };
    CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
    cryptoStream.Write(byte_2, 0, byte_2.Length);
    cryptoStream.Close();
    return Class5.smethod_28((MemoryStream) stream);
  }

  private byte[] method_1() => (byte[]) null;

  private byte[] method_2() => (byte[]) null;

  private byte[] method_3() => (byte[]) null;

  private byte[] method_4() => (byte[]) null;

  private byte[] method_5() => (byte[]) null;

  private byte[] method_6() => (byte[]) null;

  internal byte[] method_7()
  {
    int length = "{11111-22222-40001-00001}".Length;
    return new byte[2]{ (byte) 1, (byte) 2 };
  }

  internal byte[] method_8()
  {
    int length = "{11111-22222-40001-00002}".Length;
    return new byte[2]{ (byte) 1, (byte) 2 };
  }

  internal byte[] method_9() => (byte[]) null;

  internal byte[] method_10() => (byte[]) null;

  internal static bool smethod_30() => null == null;

  internal static object smethod_31() => (object) null;

  internal static bool smethod_32() => null == null;

  internal static object smethod_33() => (object) null;

  static int smethod_34() => 1;

  internal static IntPtr smethod_35(IntPtr intptr_4, int int_6)
  {
    return Marshal.ReadIntPtr(intptr_4, int_6);
  }

  internal static int smethod_36(IntPtr intptr_4, int int_6) => Marshal.ReadInt32(intptr_4, int_6);

  internal static long smethod_37(IntPtr intptr_4, int int_6) => Marshal.ReadInt64(intptr_4, int_6);

  internal static void smethod_38(IntPtr intptr_4, int int_6, IntPtr intptr_5)
  {
    Marshal.WriteIntPtr(intptr_4, int_6, intptr_5);
  }

  internal static void smethod_39(IntPtr intptr_4, int int_6, int int_7)
  {
    Marshal.WriteInt32(intptr_4, int_6, int_7);
  }

  internal static void smethod_40(IntPtr intptr_4, int int_6, long long_2)
  {
    Marshal.WriteInt64(intptr_4, int_6, long_2);
  }

  internal static IntPtr smethod_41(int int_6) => Marshal.AllocCoTaskMem(int_6);

  internal static void smethod_42(byte[] byte_2, int int_6, IntPtr intptr_4, int int_7)
  {
    Marshal.Copy(byte_2, int_6, intptr_4, int_7);
  }

  internal static void smethod_43() => Class5.smethod_16();

  internal static object smethod_44() => (object) Process.GetCurrentProcess();

  internal static object smethod_45(Process process_0) => (object) process_0.MainModule;

  internal static IntPtr smethod_46(ProcessModule processModule_0) => processModule_0.BaseAddress;

  internal static IntPtr smethod_47(IntPtr intptr_4, string string_1, uint uint_1)
  {
    return Class5.smethod_20(intptr_4, string_1, uint_1);
  }

  internal static bool smethod_48(IntPtr intptr_4, IntPtr intptr_5) => intptr_4 != intptr_5;

  internal static void smethod_49()
  {
  }

  internal static int smethod_50() => IntPtr.Size;

  internal static Type smethod_51(string string_1, bool bool_7) => Type.GetType(string_1, bool_7);

  internal static bool smethod_52(Type type_0, Type type_1) => type_0 != type_1;

  internal static object smethod_53(Process process_0) => (object) process_0.Modules;

  internal static object smethod_54(ReadOnlyCollectionBase readOnlyCollectionBase_0)
  {
    return (object) readOnlyCollectionBase_0.GetEnumerator();
  }

  internal static object smethod_55(IEnumerator ienumerator_0) => ienumerator_0.Current;

  internal static object smethod_56(ProcessModule processModule_0)
  {
    return (object) processModule_0.ModuleName;
  }

  internal static object smethod_57(string string_1) => (object) string_1.ToLower();

  internal static bool smethod_58(string string_1, string string_2) => string_1 == string_2;

  internal static object smethod_59(ProcessModule processModule_0)
  {
    return (object) processModule_0.FileVersionInfo;
  }

  internal static int smethod_60(FileVersionInfo fileVersionInfo_0)
  {
    return fileVersionInfo_0.ProductMajorPart;
  }

  internal static int smethod_61(FileVersionInfo fileVersionInfo_0)
  {
    return fileVersionInfo_0.ProductMinorPart;
  }

  internal static int smethod_62(FileVersionInfo fileVersionInfo_0)
  {
    return fileVersionInfo_0.ProductBuildPart;
  }

  internal static int smethod_63(FileVersionInfo fileVersionInfo_0)
  {
    return fileVersionInfo_0.ProductPrivatePart;
  }

  internal static bool smethod_64(Version version_0, Version version_1) => version_0 >= version_1;

  internal static bool smethod_65(Version version_0, Version version_1) => version_0 < version_1;

  internal static bool smethod_66(IEnumerator ienumerator_0) => ienumerator_0.MoveNext();

  internal static void smethod_67(IDisposable idisposable_0) => idisposable_0.Dispose();

  internal static object smethod_68(Assembly assembly_1, string string_1)
  {
    return (object) assembly_1.GetManifestResourceStream(string_1);
  }

  internal static object smethod_69(Class5.Class8 class8_0) => (object) class8_0.method_0();

  internal static void smethod_70(Stream stream_0, long long_2) => stream_0.Position = long_2;

  internal static long smethod_71(Stream stream_0) => stream_0.Length;

  internal static object smethod_72(Class5.Class8 class8_0, int int_6)
  {
    return (object) class8_0.method_1(int_6);
  }

  internal static void smethod_73(Array array_0) => Array.Reverse(array_0);

  internal static object smethod_74(Assembly assembly_1) => (object) assembly_1.GetName();

  internal static object smethod_75(AssemblyName assemblyName_0)
  {
    return (object) assemblyName_0.GetPublicKeyToken();
  }

  internal static void smethod_76(Array array_0, int int_6, int int_7)
  {
    Array.Clear(array_0, int_6, int_7);
  }

  internal static object smethod_77(Assembly assembly_1) => (object) assembly_1.GetModules();

  internal static IntPtr smethod_78(Module module_0) => Marshal.GetHINSTANCE(module_0);

  internal static object smethod_79(Assembly assembly_1) => (object) assembly_1.Location;

  internal static int smethod_80(string string_1) => string_1.Length;

  internal static int smethod_81(Class5.Class8 class8_0) => class8_0.method_3();

  internal static object smethod_82() => (object) Class5.smethod_7();

  internal static void smethod_83(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0)
  {
    symmetricAlgorithm_0.Mode = cipherMode_0;
  }

  internal static object smethod_84(
    SymmetricAlgorithm symmetricAlgorithm_0,
    byte[] byte_2,
    byte[] byte_3)
  {
    return (object) symmetricAlgorithm_0.CreateDecryptor(byte_2, byte_3);
  }

  internal static void smethod_85(Stream stream_0, byte[] byte_2, int int_6, int int_7)
  {
    stream_0.Write(byte_2, int_6, int_7);
  }

  internal static void smethod_86(CryptoStream cryptoStream_0) => cryptoStream_0.FlushFinalBlock();

  internal static object smethod_87(MemoryStream memoryStream_0)
  {
    return (object) memoryStream_0.ToArray();
  }

  internal static void smethod_88(Stream stream_0) => stream_0.Close();

  internal static void smethod_89(Class5.Class8 class8_0) => class8_0.method_4();

  internal static int smethod_90(Process process_0) => process_0.Id;

  internal static IntPtr smethod_91(uint uint_1, int int_6, uint uint_2)
  {
    return Class5.smethod_24(uint_1, int_6, uint_2);
  }

  internal static object smethod_92(int int_6) => (object) BitConverter.GetBytes(int_6);

  internal static long smethod_93(Stream stream_0) => stream_0.Position;

  internal static void smethod_94(IntPtr intptr_4, int int_6)
  {
    Marshal.WriteInt32(intptr_4, int_6);
  }

  internal static int smethod_95(IntPtr intptr_4) => Class5.smethod_25(intptr_4);

  internal static void smethod_96(Hashtable hashtable_1, object object_3, object object_4)
  {
    hashtable_1.Add(object_3, object_4);
  }

  internal static Type smethod_97(RuntimeTypeHandle runtimeTypeHandle_0)
  {
    return Type.GetTypeFromHandle(runtimeTypeHandle_0);
  }

  internal static int smethod_98(long long_2) => Convert.ToInt32(long_2);

  internal static object smethod_99() => (object) Encoding.UTF8;

  internal static object smethod_100(Encoding encoding_0, byte[] byte_2)
  {
    return (object) encoding_0.GetString(byte_2);
  }

  internal static bool smethod_101(IntPtr intptr_4, IntPtr intptr_5) => intptr_4 == intptr_5;

  internal static object smethod_102(IntPtr intptr_4, Type type_0)
  {
    return (object) Class5.smethod_17(intptr_4, type_0);
  }

  internal static IntPtr smethod_103(Class5.Delegate4 delegate4_0) => delegate4_0();

  internal static int smethod_104(IntPtr intptr_4) => Marshal.ReadInt32(intptr_4);

  internal static long smethod_105(IntPtr intptr_4) => Marshal.ReadInt64(intptr_4);

  internal static IntPtr smethod_106(Delegate delegate_0)
  {
    return Marshal.GetFunctionPointerForDelegate(delegate_0);
  }

  internal static int smethod_107(ProcessModule processModule_0)
  {
    return processModule_0.ModuleMemorySize;
  }

  internal static object smethod_108(Assembly assembly_1) => (object) assembly_1.EntryPoint;

  internal static bool smethod_109(MethodInfo methodInfo_0, MethodInfo methodInfo_1)
  {
    return methodInfo_0 != methodInfo_1;
  }

  internal static object smethod_110(Delegate delegate_0) => (object) delegate_0.Method;

  internal static object smethod_111(Type type_0, MethodInfo methodInfo_0)
  {
    return (object) Delegate.CreateDelegate(type_0, methodInfo_0);
  }

  internal static object smethod_112(MethodBase methodBase_0)
  {
    return (object) methodBase_0.GetParameters();
  }

  internal static object smethod_113(Assembly assembly_1) => (object) assembly_1.ManifestModule;

  internal static ModuleHandle smethod_114(Module module_0) => module_0.ModuleHandle;

  internal static Type smethod_115(object object_3) => object_3.GetType();

  internal static object smethod_116(FieldInfo fieldInfo_0, object object_3)
  {
    return fieldInfo_0.GetValue(object_3);
  }

  internal static object smethod_117(long long_2) => (object) BitConverter.GetBytes(long_2);

  internal static void smethod_118(Delegate delegate_0)
  {
    RuntimeHelpers.PrepareDelegate(delegate_0);
  }

  internal static RuntimeMethodHandle smethod_119(MethodBase methodBase_0)
  {
    return methodBase_0.MethodHandle;
  }

  internal static void smethod_120(RuntimeMethodHandle runtimeMethodHandle_0)
  {
    RuntimeHelpers.PrepareMethod(runtimeMethodHandle_0);
  }

  internal static void smethod_121(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
  {
    RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
  }

  internal static IntPtr smethod_122(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
  {
    return Class5.smethod_21(intptr_4, uint_1, uint_2, uint_3);
  }

  internal static void smethod_123(IntPtr intptr_4, IntPtr intptr_5)
  {
    Marshal.WriteIntPtr(intptr_4, intptr_5);
  }

  internal static bool smethod_124() => null == null;

  internal static object smethod_125() => (object) null;

  private delegate void Delegate2(object o);

  internal class Attribute0 : Attribute
  {
    public Attribute0(object object_0)
    {
    }

    internal class Class6<T>
    {
      internal static object object_0;

      internal static bool smethod_0() => Class5.Attribute0.Class6<T>.object_0 == null;

      internal static object smethod_1() => Class5.Attribute0.Class6<T>.object_0;
    }
  }

  internal class Class7
  {
    internal static string smethod_0(string string_0, string string_1)
    {
      byte[] bytes = Encoding.Unicode.GetBytes(string_0);
      byte[] numArray1 = new byte[32]
      {
        (byte) 82,
        (byte) 102,
        (byte) 104,
        (byte) 110,
        (byte) 32,
        (byte) 77,
        (byte) 24,
        (byte) 34,
        (byte) 118,
        (byte) 181,
        (byte) 51,
        (byte) 17,
        (byte) 18,
        (byte) 51,
        (byte) 12,
        (byte) 109,
        (byte) 10,
        (byte) 32,
        (byte) 77,
        (byte) 24,
        (byte) 34,
        (byte) 158,
        (byte) 161,
        (byte) 41,
        (byte) 97,
        (byte) 28,
        (byte) 118,
        (byte) 181,
        (byte) 5,
        (byte) 25,
        (byte) 1,
        (byte) 88
      };
      byte[] numArray2 = Class5.smethod_9(Encoding.Unicode.GetBytes(string_1));
      MemoryStream memoryStream = new MemoryStream();
      SymmetricAlgorithm symmetricAlgorithm = Class5.smethod_7();
      symmetricAlgorithm.Key = numArray1;
      symmetricAlgorithm.IV = numArray2;
      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
      cryptoStream.Write(bytes, 0, bytes.Length);
      cryptoStream.Close();
      return Convert.ToBase64String(memoryStream.ToArray());
    }
  }

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  internal delegate uint Delegate3(
    IntPtr classthis,
    IntPtr comp,
    IntPtr info,
    [MarshalAs(UnmanagedType.U4)] uint flags,
    IntPtr nativeEntry,
    ref uint nativeSizeOfCode);

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate IntPtr Delegate4();

  internal struct Struct3
  {
    internal bool bool_0;
    internal byte[] byte_0;
  }

  internal class Class8
  {
    private BinaryReader binaryReader_0;

    public Class8(Stream stream_0) => this.binaryReader_0 = new BinaryReader(stream_0);

    [SpecialName]
    internal Stream method_0() => this.binaryReader_0.BaseStream;

    internal byte[] method_1(int int_0) => this.binaryReader_0.ReadBytes(int_0);

    internal int method_2(byte[] byte_0, int int_0, int int_1)
    {
      return this.binaryReader_0.Read(byte_0, int_0, int_1);
    }

    internal int method_3() => this.binaryReader_0.ReadInt32();

    internal void method_4() => this.binaryReader_0.Close();
  }

  [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
  private delegate IntPtr Delegate5(IntPtr hModule, string lpName, uint lpType);

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate IntPtr Delegate6(
    IntPtr lpAddress,
    uint dwSize,
    uint flAllocationType,
    uint flProtect);

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate int Delegate7(
    IntPtr hProcess,
    IntPtr lpBaseAddress,
    [In, Out] byte[] buffer,
    uint size,
    out IntPtr lpNumberOfBytesWritten);

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate int Delegate8(
    IntPtr lpAddress,
    int dwSize,
    int flNewProtect,
    ref int lpflOldProtect);

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate IntPtr Delegate9(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate int Delegate10(IntPtr ptr);

  [Flags]
  private enum Enum0
  {
  }
}
