using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShadowSplitData
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.ShadowSplitData+<m_CullingPlanes>e__FixedBuffer")]
	public struct _m_CullingPlanes_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _m_CullingPlanes_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingSphere;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingNearPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMatrix;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public int m_CullingPlaneCount;

	[FieldOffset(4)]
	public _m_CullingPlanes_e__FixedBuffer m_CullingPlanes;

	[FieldOffset(164)]
	public Vector4 m_CullingSphere;

	[FieldOffset(180)]
	public float m_ShadowCascadeBlendCullingFactor;

	[FieldOffset(184)]
	public float m_CullingNearPlane;

	[FieldOffset(188)]
	public Matrix4x4 m_CullingMatrix;

	public unsafe static int k_MaximumCullingPlaneCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*)(&value));
		}
	}

	public unsafe static int maximumCullingPlaneCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maximumCullingPlaneCount, (void*)(&value));
		}
	}

	public unsafe int cullingPlaneCount
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value < 0 || value > 10)
			{
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Value should range from {0} to ShadowSplitData.maximumCullingPlaneCount ({1}), but was {2}.", (Il2CppSystem.Object)(object)0, (Il2CppSystem.Object)(object)10, (Il2CppSystem.Object)(object)value));
			}
			m_CullingPlaneCount = value;
		}
	}

	public unsafe Vector4 cullingSphere
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239767, RefRangeEnd = 1239769, XrefRangeStart = 1239767, XrefRangeEnd = 1239767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_CullingSphere = value;
		}
	}

	public unsafe float shadowCascadeBlendCullingFactor
	{
		get
		{
			return m_ShadowCascadeBlendCullingFactor;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239769, RefRangeEnd = 1239771, XrefRangeStart = 1239769, XrefRangeEnd = 1239769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Matrix4x4 cullingMatrix
	{
		get
		{
			return m_CullingMatrix;
		}
		set
		{
			m_CullingMatrix = value;
		}
	}

	public float cullingNearPlane
	{
		get
		{
			return m_CullingNearPlane;
		}
		set
		{
			m_CullingNearPlane = value;
		}
	}

	static ShadowSplitData()
	{
		Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ShadowSplitData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr);
		NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "k_MaximumCullingPlaneCount");
		NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "maximumCullingPlaneCount");
		NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingPlaneCount");
		NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingPlanes");
		NativeFieldInfoPtr_m_CullingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingSphere");
		NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_ShadowCascadeBlendCullingFactor");
		NativeFieldInfoPtr_m_CullingNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingNearPlane");
		NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "m_CullingMatrix");
		NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668743);
		NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668744);
		NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668745);
		NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668746);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668747);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668748);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100668749);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239774, RefRangeEnd = 1239776, XrefRangeStart = 1239771, XrefRangeEnd = 1239774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Plane GetCullingPlane(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Plane*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239789, RefRangeEnd = 1239791, XrefRangeStart = 1239776, XrefRangeEnd = 1239789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(ShadowSplitData other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239791, XrefRangeEnd = 1239797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239801, RefRangeEnd = 1239802, XrefRangeStart = 1239797, XrefRangeEnd = 1239801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void SetCullingPlane(int index, Plane plane)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator ==(ShadowSplitData left, ShadowSplitData right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ShadowSplitData left, ShadowSplitData right)
	{
		return !left.Equals(right);
	}
}
