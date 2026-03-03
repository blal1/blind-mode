using System;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public sealed class WaitForFixedUpdate : YieldInstruction
{
	static WaitForFixedUpdate()
	{
		Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitForFixedUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForFixedUpdate>.NativeClassPtr);
	}

	public WaitForFixedUpdate(IntPtr pointer)
		: base(pointer)
	{
	}
}
