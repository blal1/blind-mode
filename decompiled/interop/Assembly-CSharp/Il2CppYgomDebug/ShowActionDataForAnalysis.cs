using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppYgomGame.Duel;

namespace Il2CppYgomDebug;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct ShowActionDataForAnalysis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_datal;

	private static readonly System.IntPtr NativeFieldInfoPtr_datar;

	private static readonly System.IntPtr NativeFieldInfoPtr_datac;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowActionData_0;

	[FieldOffset(0)]
	public LogDataSideForAnalysis datal;

	[FieldOffset(8)]
	public LogDataSideForAnalysis datar;

	[FieldOffset(16)]
	public LogDataCenterForAnalysis datac;

	static ShowActionDataForAnalysis()
	{
		Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "ShowActionDataForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_datal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr, "datal");
		NativeFieldInfoPtr_datar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr, "datar");
		NativeFieldInfoPtr_datac = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr, "datac");
		NativeMethodInfoPtr__ctor_Public_Void_ShowActionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr, 100665281);
	}

	[CallerCount(0)]
	public unsafe ShowActionDataForAnalysis(ShowActionData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShowActionData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowActionDataForAnalysis>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
