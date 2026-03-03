using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AttachmentIndexArray
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Emtpy;

	private static readonly System.IntPtr NativeFieldInfoPtr_a0;

	private static readonly System.IntPtr NativeFieldInfoPtr_a1;

	private static readonly System.IntPtr NativeFieldInfoPtr_a2;

	private static readonly System.IntPtr NativeFieldInfoPtr_a3;

	private static readonly System.IntPtr NativeFieldInfoPtr_a4;

	private static readonly System.IntPtr NativeFieldInfoPtr_a5;

	private static readonly System.IntPtr NativeFieldInfoPtr_a6;

	private static readonly System.IntPtr NativeFieldInfoPtr_a7;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeAttachments;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

	[FieldOffset(0)]
	public int a0;

	[FieldOffset(4)]
	public int a1;

	[FieldOffset(8)]
	public int a2;

	[FieldOffset(12)]
	public int a3;

	[FieldOffset(16)]
	public int a4;

	[FieldOffset(20)]
	public int a5;

	[FieldOffset(24)]
	public int a6;

	[FieldOffset(28)]
	public int a7;

	[FieldOffset(32)]
	public int activeAttachments;

	public const int MaxAttachments = 8;

	public unsafe static AttachmentIndexArray Emtpy
	{
		get
		{
			Unsafe.SkipInit(out AttachmentIndexArray result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Emtpy, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Emtpy, (void*)(&value));
		}
	}

	public unsafe int this[int index]
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1237878, RefRangeEnd = 1237884, XrefRangeStart = 1237878, XrefRangeEnd = 1237878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1237884, RefRangeEnd = 1237888, XrefRangeStart = 1237884, XrefRangeEnd = 1237884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&index);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int Length
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1156529, RefRangeEnd = 1156553, XrefRangeStart = 1156529, XrefRangeEnd = 1156553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Length_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AttachmentIndexArray()
	{
		Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AttachmentIndexArray");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr);
		NativeFieldInfoPtr_Emtpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "Emtpy");
		NativeFieldInfoPtr_a0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a0");
		NativeFieldInfoPtr_a1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a1");
		NativeFieldInfoPtr_a2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a2");
		NativeFieldInfoPtr_a3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a3");
		NativeFieldInfoPtr_a4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a4");
		NativeFieldInfoPtr_a5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a5");
		NativeFieldInfoPtr_a6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a6");
		NativeFieldInfoPtr_a7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "a7");
		NativeFieldInfoPtr_activeAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, "activeAttachments");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100668424);
		NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100668425);
		NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100668426);
		NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100668427);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237876, RefRangeEnd = 1237878, XrefRangeStart = 1237876, XrefRangeEnd = 1237876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AttachmentIndexArray(int numAttachments)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numAttachments);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
