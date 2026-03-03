using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct MarkupAttribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_NameHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueLength;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NameHashCode_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_NameHashCode_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueHashCode_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ValueHashCode_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueStartIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ValueStartIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueLength_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ValueLength_Public_set_Void_Int32_0;

	[FieldOffset(0)]
	public int m_NameHashCode;

	[FieldOffset(4)]
	public int m_ValueHashCode;

	[FieldOffset(8)]
	public int m_ValueStartIndex;

	[FieldOffset(12)]
	public int m_ValueLength;

	public unsafe int NameHashCode
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NameHashCode_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NameHashCode_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int ValueHashCode
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ValueHashCode_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ValueHashCode_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int ValueStartIndex
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ValueStartIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ValueStartIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int ValueLength
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ValueLength_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 376360, RefRangeEnd = 376363, XrefRangeStart = 376360, XrefRangeEnd = 376363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ValueLength_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static MarkupAttribute()
	{
		Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "MarkupAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_NameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, "m_NameHashCode");
		NativeFieldInfoPtr_m_ValueHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, "m_ValueHashCode");
		NativeFieldInfoPtr_m_ValueStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, "m_ValueStartIndex");
		NativeFieldInfoPtr_m_ValueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, "m_ValueLength");
		NativeMethodInfoPtr_get_NameHashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_set_NameHashCode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_get_ValueHashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_set_ValueHashCode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_get_ValueStartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_set_ValueStartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_get_ValueLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_set_ValueLength_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, 100665009);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkupAttribute>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
