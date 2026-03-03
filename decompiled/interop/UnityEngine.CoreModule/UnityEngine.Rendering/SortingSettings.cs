using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SortingSettings
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldToCameraMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Criteria;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DistanceMetric;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public Matrix4x4 m_WorldToCameraMatrix;

	[FieldOffset(64)]
	public Vector3 m_CameraPosition;

	[FieldOffset(76)]
	public Vector3 m_CustomAxis;

	[FieldOffset(88)]
	public SortingCriteria m_Criteria;

	[FieldOffset(92)]
	public DistanceMetric m_DistanceMetric;

	public unsafe SortingCriteria criteria
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SortingCriteria*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 293993, RefRangeEnd = 293998, XrefRangeStart = 293993, XrefRangeEnd = 293998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Matrix4x4 worldToCameraMatrix
	{
		get
		{
			return m_WorldToCameraMatrix;
		}
		set
		{
			m_WorldToCameraMatrix = value;
		}
	}

	public Vector3 cameraPosition
	{
		get
		{
			return m_CameraPosition;
		}
		set
		{
			m_CameraPosition = value;
		}
	}

	public Vector3 customAxis
	{
		get
		{
			return m_CustomAxis;
		}
		set
		{
			m_CustomAxis = value;
		}
	}

	public DistanceMetric distanceMetric
	{
		get
		{
			return m_DistanceMetric;
		}
		set
		{
			m_DistanceMetric = value;
		}
	}

	static SortingSettings()
	{
		Il2CppClassPointerStore<SortingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SortingSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_WorldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_WorldToCameraMatrix");
		NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_CameraPosition");
		NativeFieldInfoPtr_m_CustomAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_CustomAxis");
		NativeFieldInfoPtr_m_Criteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_Criteria");
		NativeFieldInfoPtr_m_DistanceMetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, "m_DistanceMetric");
		NativeMethodInfoPtr__ctor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668755);
		NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668756);
		NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668757);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668758);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668759);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100668760);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1239816, RefRangeEnd = 1239821, XrefRangeStart = 1239805, XrefRangeEnd = 1239816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SortingSettings(Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Camera_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239823, RefRangeEnd = 1239825, XrefRangeStart = 1239821, XrefRangeEnd = 1239823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(SortingSettings other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239825, XrefRangeEnd = 1239829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1239836, RefRangeEnd = 1239838, XrefRangeStart = 1239829, XrefRangeEnd = 1239836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(SortingSettings left, SortingSettings right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(SortingSettings left, SortingSettings right)
	{
		return !left.Equals(right);
	}
}
