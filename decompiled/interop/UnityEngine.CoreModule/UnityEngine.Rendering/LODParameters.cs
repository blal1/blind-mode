using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct LODParameters
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOrthographic;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FieldOfView;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OrthoSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPixelHeight;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orthoSize_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public int m_IsOrthographic;

	[FieldOffset(4)]
	public Vector3 m_CameraPosition;

	[FieldOffset(16)]
	public float m_FieldOfView;

	[FieldOffset(20)]
	public float m_OrthoSize;

	[FieldOffset(24)]
	public int m_CameraPixelHeight;

	public unsafe bool isOrthographic
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238339, RefRangeEnd = 1238341, XrefRangeStart = 1238335, XrefRangeEnd = 1238339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_IsOrthographic = Il2CppSystem.Convert.ToInt32(value);
		}
	}

	public unsafe Vector3 cameraPosition
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238341, RefRangeEnd = 1238342, XrefRangeStart = 1238341, XrefRangeEnd = 1238341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraPosition_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_CameraPosition = value;
		}
	}

	public unsafe float fieldOfView
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1153382, RefRangeEnd = 1153405, XrefRangeStart = 1153382, XrefRangeEnd = 1153405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_FieldOfView = value;
		}
	}

	public unsafe float orthoSize
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1154286, RefRangeEnd = 1154293, XrefRangeStart = 1154286, XrefRangeEnd = 1154293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orthoSize_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_OrthoSize = value;
		}
	}

	public int cameraPixelHeight
	{
		get
		{
			return m_CameraPixelHeight;
		}
		set
		{
			m_CameraPixelHeight = value;
		}
	}

	static LODParameters()
	{
		Il2CppClassPointerStore<LODParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "LODParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODParameters>.NativeClassPtr);
		NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_IsOrthographic");
		NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPosition");
		NativeFieldInfoPtr_m_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_FieldOfView");
		NativeFieldInfoPtr_m_OrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_OrthoSize");
		NativeFieldInfoPtr_m_CameraPixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, "m_CameraPixelHeight");
		NativeMethodInfoPtr_get_isOrthographic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668519);
		NativeMethodInfoPtr_get_cameraPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668520);
		NativeMethodInfoPtr_get_fieldOfView_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668521);
		NativeMethodInfoPtr_get_orthoSize_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668522);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668523);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668524);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100668525);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238344, RefRangeEnd = 1238345, XrefRangeStart = 1238342, XrefRangeEnd = 1238344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(LODParameters other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238345, XrefRangeEnd = 1238349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1238354, RefRangeEnd = 1238355, XrefRangeStart = 1238349, XrefRangeEnd = 1238354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(LODParameters left, LODParameters right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(LODParameters left, LODParameters right)
	{
		return !left.Equals(right);
	}
}
