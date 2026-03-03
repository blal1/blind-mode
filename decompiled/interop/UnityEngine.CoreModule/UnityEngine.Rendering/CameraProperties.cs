using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CameraProperties
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<layerCullDistances>e__FixedBuffer")]
	public struct _layerCullDistances_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public float FixedElementField;

		static _layerCullDistances_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_layerCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<layerCullDistances>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_layerCullDistances_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_layerCullDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_layerCullDistances_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_CameraCullPlanes>e__FixedBuffer")]
	public struct _m_CameraCullPlanes_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _m_CameraCullPlanes_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_CameraCullPlanes>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_CameraCullPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.CameraProperties+<m_ShadowCullPlanes>e__FixedBuffer")]
	public struct _m_ShadowCullPlanes_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _m_ShadowCullPlanes_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "<m_ShadowCullPlanes>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_ShadowCullPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_NumLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewDir;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionNear;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionFar;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraNear;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraFar;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraAspect;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraToWorld;

	private static readonly System.IntPtr NativeFieldInfoPtr_actualWorldToClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraClipToWorld;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraWorldToClip;

	private static readonly System.IntPtr NativeFieldInfoPtr_implicitProjection;

	private static readonly System.IntPtr NativeFieldInfoPtr_stereoWorldToClipLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_stereoWorldToClipRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldToCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_up;

	private static readonly System.IntPtr NativeFieldInfoPtr_right;

	private static readonly System.IntPtr NativeFieldInfoPtr_transformDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraEuler;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_farPlaneWorldSpaceLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_PlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowCullPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraCullPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseFarDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowCullCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerCullDistances;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerCullSpherical;

	private static readonly System.IntPtr NativeFieldInfoPtr_coreCameraValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraType;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionIsOblique;

	private static readonly System.IntPtr NativeFieldInfoPtr_isImplicitProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_useInteractiveLightBakingData;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public Rect screenRect;

	[FieldOffset(16)]
	public Vector3 viewDir;

	[FieldOffset(28)]
	public float projectionNear;

	[FieldOffset(32)]
	public float projectionFar;

	[FieldOffset(36)]
	public float cameraNear;

	[FieldOffset(40)]
	public float cameraFar;

	[FieldOffset(44)]
	public float cameraAspect;

	[FieldOffset(48)]
	public Matrix4x4 cameraToWorld;

	[FieldOffset(112)]
	public Matrix4x4 actualWorldToClip;

	[FieldOffset(176)]
	public Matrix4x4 cameraClipToWorld;

	[FieldOffset(240)]
	public Matrix4x4 cameraWorldToClip;

	[FieldOffset(304)]
	public Matrix4x4 implicitProjection;

	[FieldOffset(368)]
	public Matrix4x4 stereoWorldToClipLeft;

	[FieldOffset(432)]
	public Matrix4x4 stereoWorldToClipRight;

	[FieldOffset(496)]
	public Matrix4x4 worldToCamera;

	[FieldOffset(560)]
	public Vector3 up;

	[FieldOffset(572)]
	public Vector3 right;

	[FieldOffset(584)]
	public Vector3 transformDirection;

	[FieldOffset(596)]
	public Vector3 cameraEuler;

	[FieldOffset(608)]
	public Vector3 velocity;

	[FieldOffset(620)]
	public float farPlaneWorldSpaceLength;

	[FieldOffset(624)]
	public uint rendererCount;

	[FieldOffset(628)]
	public _m_ShadowCullPlanes_e__FixedBuffer m_ShadowCullPlanes;

	[FieldOffset(724)]
	public _m_CameraCullPlanes_e__FixedBuffer m_CameraCullPlanes;

	[FieldOffset(820)]
	public float baseFarDistance;

	[FieldOffset(824)]
	public Vector3 shadowCullCenter;

	[FieldOffset(836)]
	public _layerCullDistances_e__FixedBuffer layerCullDistances;

	[FieldOffset(964)]
	public int layerCullSpherical;

	[FieldOffset(968)]
	public CoreCameraValues coreCameraValues;

	[FieldOffset(980)]
	public uint cameraType;

	[FieldOffset(984)]
	public int projectionIsOblique;

	[FieldOffset(988)]
	public int isImplicitProjectionMatrix;

	[FieldOffset(992)]
	[MarshalAs(UnmanagedType.U1)]
	public bool useInteractiveLightBakingData;

	public unsafe static int k_NumLayers
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_NumLayers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_NumLayers, (void*)(&value));
		}
	}

	public unsafe static int k_PlaneCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_PlaneCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_PlaneCount, (void*)(&value));
		}
	}

	static CameraProperties()
	{
		Il2CppClassPointerStore<CameraProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CameraProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr);
		NativeFieldInfoPtr_k_NumLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "k_NumLayers");
		NativeFieldInfoPtr_screenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "screenRect");
		NativeFieldInfoPtr_viewDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "viewDir");
		NativeFieldInfoPtr_projectionNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionNear");
		NativeFieldInfoPtr_projectionFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionFar");
		NativeFieldInfoPtr_cameraNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraNear");
		NativeFieldInfoPtr_cameraFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraFar");
		NativeFieldInfoPtr_cameraAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraAspect");
		NativeFieldInfoPtr_cameraToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraToWorld");
		NativeFieldInfoPtr_actualWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "actualWorldToClip");
		NativeFieldInfoPtr_cameraClipToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraClipToWorld");
		NativeFieldInfoPtr_cameraWorldToClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraWorldToClip");
		NativeFieldInfoPtr_implicitProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "implicitProjection");
		NativeFieldInfoPtr_stereoWorldToClipLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "stereoWorldToClipLeft");
		NativeFieldInfoPtr_stereoWorldToClipRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "stereoWorldToClipRight");
		NativeFieldInfoPtr_worldToCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "worldToCamera");
		NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "up");
		NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "right");
		NativeFieldInfoPtr_transformDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "transformDirection");
		NativeFieldInfoPtr_cameraEuler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraEuler");
		NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "velocity");
		NativeFieldInfoPtr_farPlaneWorldSpaceLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "farPlaneWorldSpaceLength");
		NativeFieldInfoPtr_rendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "rendererCount");
		NativeFieldInfoPtr_k_PlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "k_PlaneCount");
		NativeFieldInfoPtr_m_ShadowCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "m_ShadowCullPlanes");
		NativeFieldInfoPtr_m_CameraCullPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "m_CameraCullPlanes");
		NativeFieldInfoPtr_baseFarDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "baseFarDistance");
		NativeFieldInfoPtr_shadowCullCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "shadowCullCenter");
		NativeFieldInfoPtr_layerCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "layerCullDistances");
		NativeFieldInfoPtr_layerCullSpherical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "layerCullSpherical");
		NativeFieldInfoPtr_coreCameraValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "coreCameraValues");
		NativeFieldInfoPtr_cameraType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "cameraType");
		NativeFieldInfoPtr_projectionIsOblique = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "projectionIsOblique");
		NativeFieldInfoPtr_isImplicitProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "isImplicitProjectionMatrix");
		NativeFieldInfoPtr_useInteractiveLightBakingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, "useInteractiveLightBakingData");
		NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668438);
		NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668439);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668440);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668441);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, 100668442);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1237957, RefRangeEnd = 1237960, XrefRangeStart = 1237957, XrefRangeEnd = 1237957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Plane GetShadowCullingPlane(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowCullingPlane_Public_Plane_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Plane*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1237960, RefRangeEnd = 1237963, XrefRangeStart = 1237960, XrefRangeEnd = 1237960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Plane GetCameraCullingPlane(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraCullingPlane_Public_Plane_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Plane*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237993, RefRangeEnd = 1237994, XrefRangeStart = 1237963, XrefRangeEnd = 1237993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(CameraProperties other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraProperties_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237994, XrefRangeEnd = 1237998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1238043, RefRangeEnd = 1238044, XrefRangeStart = 1237998, XrefRangeEnd = 1238043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraProperties>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void SetShadowCullingPlane(int index, Plane plane)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetCameraCullingPlane(int index, Plane plane)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator ==(CameraProperties left, CameraProperties right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(CameraProperties left, CameraProperties right)
	{
		return !left.Equals(right);
	}
}
