using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VisibleReflectionProbe
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HdrData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Importance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextureId;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_importance_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public Bounds m_Bounds;

	[FieldOffset(24)]
	public Matrix4x4 m_LocalToWorldMatrix;

	[FieldOffset(88)]
	public Vector4 m_HdrData;

	[FieldOffset(104)]
	public Vector3 m_Center;

	[FieldOffset(116)]
	public float m_BlendDistance;

	[FieldOffset(120)]
	public int m_Importance;

	[FieldOffset(124)]
	public int m_BoxProjection;

	[FieldOffset(128)]
	public int m_InstanceId;

	[FieldOffset(132)]
	public int m_TextureId;

	public unsafe Texture texture
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240205, RefRangeEnd = 1240207, XrefRangeStart = 1240199, XrefRangeEnd = 1240205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_texture_Public_get_Texture_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
	}

	public unsafe ReflectionProbe reflectionProbe
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240213, RefRangeEnd = 1240216, XrefRangeStart = 1240207, XrefRangeEnd = 1240213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReflectionProbe>(intPtr2) : null;
		}
	}

	public unsafe Bounds bounds
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1240216, RefRangeEnd = 1240226, XrefRangeStart = 1240216, XrefRangeEnd = 1240216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Bounds = value;
		}
	}

	public unsafe Matrix4x4 localToWorldMatrix
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240226, RefRangeEnd = 1240229, XrefRangeStart = 1240226, XrefRangeEnd = 1240226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_LocalToWorldMatrix = value;
		}
	}

	public unsafe Vector4 hdrData
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1240229, RefRangeEnd = 1240231, XrefRangeStart = 1240229, XrefRangeEnd = 1240229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_HdrData = value;
		}
	}

	public unsafe float blendDistance
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240231, RefRangeEnd = 1240232, XrefRangeStart = 1240231, XrefRangeEnd = 1240231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_BlendDistance = value;
		}
	}

	public unsafe int importance
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1240232, RefRangeEnd = 1240235, XrefRangeStart = 1240232, XrefRangeEnd = 1240232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_importance_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Importance = value;
		}
	}

	public unsafe bool isBoxProjection
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1240239, RefRangeEnd = 1240240, XrefRangeStart = 1240235, XrefRangeEnd = 1240239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_BoxProjection = Il2CppSystem.Convert.ToInt32(value);
		}
	}

	public Vector3 center
	{
		get
		{
			return m_Center;
		}
		set
		{
			m_Center = value;
		}
	}

	static VisibleReflectionProbe()
	{
		Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VisibleReflectionProbe");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr);
		NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Bounds");
		NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_LocalToWorldMatrix");
		NativeFieldInfoPtr_m_HdrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_HdrData");
		NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Center");
		NativeFieldInfoPtr_m_BlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_BlendDistance");
		NativeFieldInfoPtr_m_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_Importance");
		NativeFieldInfoPtr_m_BoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_BoxProjection");
		NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_InstanceId");
		NativeFieldInfoPtr_m_TextureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, "m_TextureId");
		NativeMethodInfoPtr_get_texture_Public_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668831);
		NativeMethodInfoPtr_get_reflectionProbe_Public_get_ReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668832);
		NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668833);
		NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668834);
		NativeMethodInfoPtr_get_hdrData_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668835);
		NativeMethodInfoPtr_get_blendDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668836);
		NativeMethodInfoPtr_get_importance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668837);
		NativeMethodInfoPtr_get_isBoxProjection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668838);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668839);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668840);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100668841);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240243, RefRangeEnd = 1240244, XrefRangeStart = 1240240, XrefRangeEnd = 1240243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(VisibleReflectionProbe other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240244, XrefRangeEnd = 1240248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240248, XrefRangeEnd = 1240263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(VisibleReflectionProbe left, VisibleReflectionProbe right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(VisibleReflectionProbe left, VisibleReflectionProbe right)
	{
		return !left.Equals(right);
	}
}
