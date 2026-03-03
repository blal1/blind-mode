using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GlyphAnchorPoint
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_XCoordinate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_YCoordinate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xCoordinate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_xCoordinate_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_yCoordinate_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_yCoordinate_Public_set_Void_Single_0;

	[FieldOffset(0)]
	public float m_XCoordinate;

	[FieldOffset(4)]
	public float m_YCoordinate;

	public unsafe float xCoordinate
	{
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 1167165, RefRangeEnd = 1167244, XrefRangeStart = 1167165, XrefRangeEnd = 1167244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xCoordinate_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_xCoordinate_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float yCoordinate
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153875, XrefRangeStart = 1153785, XrefRangeEnd = 1153875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_yCoordinate_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_yCoordinate_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static GlyphAnchorPoint()
	{
		Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphAnchorPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr);
		NativeFieldInfoPtr_m_XCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, "m_XCoordinate");
		NativeFieldInfoPtr_m_YCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, "m_YCoordinate");
		NativeMethodInfoPtr_get_xCoordinate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_set_xCoordinate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_get_yCoordinate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_set_yCoordinate_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, 100663459);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphAnchorPoint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
