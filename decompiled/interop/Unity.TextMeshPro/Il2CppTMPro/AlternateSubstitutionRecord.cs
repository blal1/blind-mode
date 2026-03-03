using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct AlternateSubstitutionRecord
{
	static AlternateSubstitutionRecord()
	{
		Il2CppClassPointerStore<AlternateSubstitutionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "AlternateSubstitutionRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlternateSubstitutionRecord>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AlternateSubstitutionRecord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
