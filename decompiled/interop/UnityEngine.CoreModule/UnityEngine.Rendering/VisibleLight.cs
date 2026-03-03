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
public struct VisibleLight
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FinalColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScreenRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Range;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpotAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_light_Public_get_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightType_Public_get_LightType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_finalColor_Public_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public LightType m_LightType;

	[FieldOffset(4)]
	public Color m_FinalColor;

	[FieldOffset(20)]
	public Rect m_ScreenRect;

	[FieldOffset(36)]
	public Matrix4x4 m_LocalToWorldMatrix;

	[FieldOffset(100)]
	public float m_Range;

	[FieldOffset(104)]
	public float m_SpotAngle;

	[FieldOffset(108)]
	public int m_InstanceId;

	[FieldOffset(112)]
	public VisibleLightFlags m_Flags;

	public unsafe Light light
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1240093, RefRangeEnd = 1240129, XrefRangeStart = 1240087, XrefRangeEnd = 1240093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_light_Public_get_Light_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
		}
	}

	public unsafe LightType lightType
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightType_Public_get_LightType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LightType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_LightType = value;
		}
	}

	public unsafe Color finalColor
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1240129, RefRangeEnd = 1240145, XrefRangeStart = 1240129, XrefRangeEnd = 1240129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_finalColor_Public_get_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_FinalColor = value;
		}
	}

	public unsafe Matrix4x4 localToWorldMatrix
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1240145, RefRangeEnd = 1240158, XrefRangeStart = 1240145, XrefRangeEnd = 1240145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe float range
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1240158, RefRangeEnd = 1240173, XrefRangeStart = 1240158, XrefRangeEnd = 1240158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_range_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Range = value;
		}
	}

	public unsafe float spotAngle
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1240173, RefRangeEnd = 1240180, XrefRangeStart = 1240173, XrefRangeEnd = 1240173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_SpotAngle = value;
		}
	}

	public Rect screenRect
	{
		get
		{
			return m_ScreenRect;
		}
		set
		{
			m_ScreenRect = value;
		}
	}

	public bool intersectsNearPlane
	{
		get
		{
			return (m_Flags & VisibleLightFlags.IntersectsNearPlane) > (VisibleLightFlags)0;
		}
		set
		{
			if (value)
			{
				m_Flags |= VisibleLightFlags.IntersectsNearPlane;
			}
			else
			{
				m_Flags &= ~VisibleLightFlags.IntersectsNearPlane;
			}
		}
	}

	public bool intersectsFarPlane
	{
		get
		{
			return (m_Flags & VisibleLightFlags.IntersectsFarPlane) > (VisibleLightFlags)0;
		}
		set
		{
			if (value)
			{
				m_Flags |= VisibleLightFlags.IntersectsFarPlane;
			}
			else
			{
				m_Flags &= ~VisibleLightFlags.IntersectsFarPlane;
			}
		}
	}

	public bool forcedVisible => (m_Flags & VisibleLightFlags.ForcedVisible) > (VisibleLightFlags)0;

	static VisibleLight()
	{
		Il2CppClassPointerStore<VisibleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "VisibleLight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr);
		NativeFieldInfoPtr_m_LightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_LightType");
		NativeFieldInfoPtr_m_FinalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_FinalColor");
		NativeFieldInfoPtr_m_ScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_ScreenRect");
		NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_LocalToWorldMatrix");
		NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_Range");
		NativeFieldInfoPtr_m_SpotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_SpotAngle");
		NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_InstanceId");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, "m_Flags");
		NativeMethodInfoPtr_get_light_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668822);
		NativeMethodInfoPtr_get_lightType_Public_get_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668823);
		NativeMethodInfoPtr_get_finalColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668824);
		NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668825);
		NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668826);
		NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668827);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668828);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668829);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100668830);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240189, RefRangeEnd = 1240190, XrefRangeStart = 1240180, XrefRangeEnd = 1240189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(VisibleLight other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240190, XrefRangeEnd = 1240194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240194, XrefRangeEnd = 1240199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(VisibleLight left, VisibleLight right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(VisibleLight left, VisibleLight right)
	{
		return !left.Equals(right);
	}
}
