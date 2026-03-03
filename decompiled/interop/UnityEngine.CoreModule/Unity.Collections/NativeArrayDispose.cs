using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Collections;

[StructLayout(LayoutKind.Explicit)]
public struct NativeArrayDispose
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocatorLabel;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	[FieldOffset(0)]
	public System.IntPtr m_Buffer;

	[FieldOffset(8)]
	public Allocator m_AllocatorLabel;

	static NativeArrayDispose()
	{
		Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeArrayDispose");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr);
		NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, "m_Buffer");
		NativeFieldInfoPtr_m_AllocatorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, "m_AllocatorLabel");
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, 100663574);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1165751, XrefRangeEnd = 1165753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArrayDispose>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
