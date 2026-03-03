using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct FilteringSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderQueueRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ExcludeMotionVectorObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceAllMotionVectorObjects;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SortingLayerRange;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_forceAllMotionVectorObjects_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0;

	[FieldOffset(0)]
	public RenderQueueRange m_RenderQueueRange;

	[FieldOffset(8)]
	public int m_LayerMask;

	[FieldOffset(12)]
	public uint m_RenderingLayerMask;

	[FieldOffset(16)]
	public uint m_BatchLayerMask;

	[FieldOffset(20)]
	public int m_ExcludeMotionVectorObjects;

	[FieldOffset(24)]
	public int m_ForceAllMotionVectorObjects;

	[FieldOffset(28)]
	public SortingLayerRange m_SortingLayerRange;

	public unsafe RenderQueueRange renderQueueRange
	{
		[CallerCount(255)]
		[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderQueueRange*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_RenderQueueRange = value;
		}
	}

	public unsafe uint batchLayerMask
	{
		get
		{
			return m_BatchLayerMask;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool excludeMotionVectorObjects
	{
		get
		{
			return m_ExcludeMotionVectorObjects != 0;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool forceAllMotionVectorObjects
	{
		get
		{
			return m_ForceAllMotionVectorObjects != 0;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238318, RefRangeEnd = 1238322, XrefRangeStart = 1238318, XrefRangeEnd = 1238318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forceAllMotionVectorObjects_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public static FilteringSettings defaultValue => new FilteringSettings(new Il2CppSystem.Nullable<RenderQueueRange>(RenderQueueRange.all));

	public int layerMask
	{
		get
		{
			return m_LayerMask;
		}
		set
		{
			m_LayerMask = value;
		}
	}

	public uint renderingLayerMask
	{
		get
		{
			return m_RenderingLayerMask;
		}
		set
		{
			m_RenderingLayerMask = value;
		}
	}

	public SortingLayerRange sortingLayerRange
	{
		get
		{
			return m_SortingLayerRange;
		}
		set
		{
			m_SortingLayerRange = value;
		}
	}

	static FilteringSettings()
	{
		Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "FilteringSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_RenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_RenderQueueRange");
		NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_LayerMask");
		NativeFieldInfoPtr_m_RenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_RenderingLayerMask");
		NativeFieldInfoPtr_m_BatchLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_BatchLayerMask");
		NativeFieldInfoPtr_m_ExcludeMotionVectorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_ExcludeMotionVectorObjects");
		NativeFieldInfoPtr_m_ForceAllMotionVectorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_ForceAllMotionVectorObjects");
		NativeFieldInfoPtr_m_SortingLayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, "m_SortingLayerRange");
		NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668510);
		NativeMethodInfoPtr_get_renderQueueRange_Public_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668511);
		NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668512);
		NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668513);
		NativeMethodInfoPtr_set_forceAllMotionVectorObjects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668514);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668515);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668516);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668517);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100668518);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1238306, RefRangeEnd = 1238318, XrefRangeStart = 1238300, XrefRangeEnd = 1238306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FilteringSettings(Il2CppSystem.Nullable<RenderQueueRange> renderQueueRange = null, int layerMask = -1, uint renderingLayerMask = uint.MaxValue, int excludeMotionVectorObjects = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderQueueRange));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderingLayerMask;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &excludeMotionVectorObjects;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238325, RefRangeEnd = 1238327, XrefRangeStart = 1238322, XrefRangeEnd = 1238325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(FilteringSettings other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238327, XrefRangeEnd = 1238331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238331, XrefRangeEnd = 1238334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238334, XrefRangeEnd = 1238335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(FilteringSettings left, FilteringSettings right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(FilteringSettings**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(FilteringSettings left, FilteringSettings right)
	{
		return !left.Equals(right);
	}
}
