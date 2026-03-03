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
public struct ShowPhaseDataForAnalysis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_phase;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShowPhaseData_0;

	[FieldOffset(0)]
	public Engine.Phase phase;

	static ShowPhaseDataForAnalysis()
	{
		Il2CppClassPointerStore<ShowPhaseDataForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "ShowPhaseDataForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowPhaseDataForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowPhaseDataForAnalysis>.NativeClassPtr, "phase");
		NativeMethodInfoPtr__ctor_Public_Void_ShowPhaseData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowPhaseDataForAnalysis>.NativeClassPtr, 100665312);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowPhaseDataForAnalysis(ShowPhaseData showPhaseData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&showPhaseData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ShowPhaseData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowPhaseDataForAnalysis>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
