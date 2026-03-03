using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Principal;

public class IPrincipal : Il2CppObjectBase
{
	static IPrincipal()
	{
		Il2CppClassPointerStore<IPrincipal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Principal", "IPrincipal");
	}

	public IPrincipal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
