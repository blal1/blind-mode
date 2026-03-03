using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MarkPositionAdjustment
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_XPositionAdjustment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_YPositionAdjustment;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xPositionAdjustment_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_xPositionAdjustment_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_yPositionAdjustment_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_yPositionAdjustment_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

	[FieldOffset(0)]
	public float m_XPositionAdjustment;

	[FieldOffset(4)]
	public float m_YPositionAdjustment;

	public unsafe float xPositionAdjustment
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xPositionAdjustment_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1007806, RefRangeEnd = 1007828, XrefRangeStart = 1007806, XrefRangeEnd = 1007828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_xPositionAdjustment_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float yPositionAdjustment
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_yPositionAdjustment_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 968557, RefRangeEnd = 968572, XrefRangeStart = 968557, XrefRangeEnd = 968572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_yPositionAdjustment_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static MarkPositionAdjustment()
	{
		Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "MarkPositionAdjustment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr);
		NativeFieldInfoPtr_m_XPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, "m_XPositionAdjustment");
		NativeFieldInfoPtr_m_YPositionAdjustment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, "m_YPositionAdjustment");
		NativeMethodInfoPtr_get_xPositionAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_set_xPositionAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_get_yPositionAdjustment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_set_yPositionAdjustment_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, 100663323);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1023379, RefRangeEnd = 1023387, XrefRangeStart = 1023379, XrefRangeEnd = 1023387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MarkPositionAdjustment(float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkPositionAdjustment>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
