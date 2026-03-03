using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Pool;

public class IPool : Il2CppObjectBase
{
	static IPool()
	{
		Il2CppClassPointerStore<IPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Pool", "IPool");
	}

	public IPool(IntPtr pointer)
		: base(pointer)
	{
	}
}
