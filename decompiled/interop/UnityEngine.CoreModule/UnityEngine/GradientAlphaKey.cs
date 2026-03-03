using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct GradientAlphaKey
{
	private static readonly System.IntPtr NativeFieldInfoPtr_alpha;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	[FieldOffset(0)]
	public float alpha;

	[FieldOffset(4)]
	public float time;

	static GradientAlphaKey()
	{
		Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GradientAlphaKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr);
		NativeFieldInfoPtr_alpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, "alpha");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, "time");
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, 100665624);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1023379, RefRangeEnd = 1023387, XrefRangeStart = 1023379, XrefRangeEnd = 1023387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GradientAlphaKey(float alpha, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&alpha);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GradientAlphaKey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
