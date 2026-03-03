using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class InvalidImportException : Il2CppSystem.Exception
{
	static InvalidImportException()
	{
		Il2CppClassPointerStore<InvalidImportException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "InvalidImportException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvalidImportException>.NativeClassPtr);
	}

	public InvalidImportException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
