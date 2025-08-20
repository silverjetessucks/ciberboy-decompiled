using System;
using System.Reflection;

internal class Class4
{
  internal static Module module_0 = typeof (Class4).Assembly.ManifestModule;

  internal static void rBqnUwTdmu(int typemdt)
  {
    Type type = Class4.module_0.ResolveType(33554432 + typemdt);
    foreach (FieldInfo field in type.GetFields())
    {
      MethodInfo method = (MethodInfo) Class4.module_0.ResolveMethod(field.MetadataToken + 100663296);
      field.SetValue((object) null, (object) (MulticastDelegate) Delegate.CreateDelegate(type, method));
    }
  }

  internal delegate void Delegate1(object o);
}
