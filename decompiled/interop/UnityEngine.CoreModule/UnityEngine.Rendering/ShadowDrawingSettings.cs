using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShadowDrawingSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingResults;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseRenderingLayerMaskTest;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectsFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProjectionType;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public CullingResults m_CullingResults;

	[FieldOffset(16)]
	public int m_LightIndex;

	[FieldOffset(20)]
	public int m_SplitIndex;

	[FieldOffset(24)]
	public int m_UseRenderingLayerMaskTest;

	[FieldOffset(28)]
	public uint m_BatchLayerMask;

	[FieldOffset(32)]
	public ShadowSplitData m_SplitData;

	[FieldOffset(284)]
	public ShadowObjectsFilter m_ObjectsFilter;

	[FieldOffset(288)]
	public BatchCullingProjectionType m_ProjectionType;

	public unsafe bool useRenderingLayerMaskTest
	{
		get
		{
			return m_UseRenderingLayerMaskTest != 0;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1238318, RefRangeEnd = 1238322, XrefRangeStart = 1238318, XrefRangeEnd = 1238322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public CullingResults cullingResults
	{
		get
		{
			return m_CullingResults;
		}
		set
		{
			m_CullingResults = value;
		}
	}

	public int lightIndex
	{
		get
		{
			return m_LightIndex;
		}
		set
		{
			m_LightIndex = value;
		}
	}

	public int splitIndex
	{
		get
		{
			return m_SplitIndex;
		}
		set
		{
			m_SplitIndex = value;
		}
	}

	public uint batchLayerMask
	{
		get
		{
			return m_BatchLayerMask;
		}
		set
		{
			m_BatchLayerMask = value;
		}
	}

	public ShadowSplitData splitData
	{
		get
		{
			return m_SplitData;
		}
		set
		{
			m_SplitData = value;
		}
	}

	public ShadowObjectsFilter objectsFilter
	{
		get
		{
			return m_ObjectsFilter;
		}
		set
		{
			m_ObjectsFilter = value;
		}
	}

	public BatchCullingProjectionType projectionType
	{
		get
		{
			return m_ProjectionType;
		}
		set
		{
			m_ProjectionType = value;
		}
	}

	static ShadowDrawingSettings()
	{
		Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowDrawingSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_CullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_CullingResults");
		NativeFieldInfoPtr_m_LightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_LightIndex");
		NativeFieldInfoPtr_m_SplitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_SplitIndex");
		NativeFieldInfoPtr_m_UseRenderingLayerMaskTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_UseRenderingLayerMaskTest");
		NativeFieldInfoPtr_m_BatchLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_BatchLayerMask");
		NativeFieldInfoPtr_m_SplitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_SplitData");
		NativeFieldInfoPtr_m_ObjectsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_ObjectsFilter");
		NativeFieldInfoPtr_m_ProjectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, "m_ProjectionType");
		NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668738);
		NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668739);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668740);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668741);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100668742);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239740, RefRangeEnd = 1239743, XrefRangeStart = 1239735, XrefRangeEnd = 1239740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShadowDrawingSettings(CullingResults cullingResults, int lightIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cullingResults);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239757, RefRangeEnd = 1239758, XrefRangeStart = 1239743, XrefRangeEnd = 1239757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(ShadowDrawingSettings other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239758, XrefRangeEnd = 1239762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239762, XrefRangeEnd = 1239767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(ShadowDrawingSettings left, ShadowDrawingSettings right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ShadowDrawingSettings left, ShadowDrawingSettings right)
	{
		return !left.Equals(right);
	}
}
