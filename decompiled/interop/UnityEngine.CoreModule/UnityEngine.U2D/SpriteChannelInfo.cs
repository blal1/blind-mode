using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D;

[StructLayout(LayoutKind.Explicit)]
public struct SpriteChannelInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Offset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Stride;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offset_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stride_Public_get_Int32_0;

	[FieldOffset(0)]
	public System.IntPtr m_Buffer;

	[FieldOffset(8)]
	public int m_Count;

	[FieldOffset(12)]
	public int m_Offset;

	[FieldOffset(16)]
	public int m_Stride;

	public unsafe void* buffer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1241398, RefRangeEnd = 1241399, XrefRangeStart = 1241397, XrefRangeEnd = 1241398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
		set
		{
			m_Buffer = (System.IntPtr)value;
		}
	}

	public unsafe int count
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1153890, RefRangeEnd = 1153936, XrefRangeStart = 1153890, XrefRangeEnd = 1153936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_count_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Count = value;
		}
	}

	public unsafe int offset
	{
		[CallerCount(115)]
		[CachedScanResults(RefRangeStart = 1165832, RefRangeEnd = 1165947, XrefRangeStart = 1165832, XrefRangeEnd = 1165947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offset_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Offset = value;
		}
	}

	public unsafe int stride
	{
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 1167244, RefRangeEnd = 1167304, XrefRangeStart = 1167244, XrefRangeEnd = 1167304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stride_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Stride = value;
		}
	}

	static SpriteChannelInfo()
	{
		Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteChannelInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Buffer");
		NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Count");
		NativeFieldInfoPtr_m_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Offset");
		NativeFieldInfoPtr_m_Stride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, "m_Stride");
		NativeMethodInfoPtr_get_buffer_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100669000);
		NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100669001);
		NativeMethodInfoPtr_get_offset_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100669002);
		NativeMethodInfoPtr_get_stride_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, 100669003);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteChannelInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
