using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ScriptableCullingParameters
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_CullingPlanes>e__FixedBuffer")]
	public struct _m_CullingPlanes_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _m_CullingPlanes_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.Rendering.ScriptableCullingParameters+<m_LayerFarCullDistances>e__FixedBuffer")]
	public struct _m_LayerFarCullDistances_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public float FixedElementField;

		static _m_LayerFarCullDistances_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "<m_LayerFarCullDistances>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_LayerFarCullDistances_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LODParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SceneMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewID;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LayerCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerFarCullDistances;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerCull;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Origin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowNearPlaneOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingOptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraProperties;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AccurateOcclusionThreshold;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaximumPortalCullingJobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CullingJobCountLowerLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CullingJobCountUpperLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StereoViewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StereoProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StereoSeparationDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maximumVisibleLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ConservativeEnclosingSphere;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NumIterationsEnclosingSphere;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public LODParameters m_LODParameters;

	[FieldOffset(28)]
	public _m_CullingPlanes_e__FixedBuffer m_CullingPlanes;

	[FieldOffset(188)]
	public int m_CullingPlaneCount;

	[FieldOffset(192)]
	public uint m_CullingMask;

	[FieldOffset(200)]
	public ulong m_SceneMask;

	[FieldOffset(208)]
	public ulong m_ViewID;

	[FieldOffset(216)]
	public _m_LayerFarCullDistances_e__FixedBuffer m_LayerFarCullDistances;

	[FieldOffset(344)]
	public int m_LayerCull;

	[FieldOffset(348)]
	public Matrix4x4 m_CullingMatrix;

	[FieldOffset(412)]
	public Vector3 m_Origin;

	[FieldOffset(424)]
	public float m_ShadowDistance;

	[FieldOffset(428)]
	public float m_ShadowNearPlaneOffset;

	[FieldOffset(432)]
	public CullingOptions m_CullingOptions;

	[FieldOffset(436)]
	public ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;

	[FieldOffset(440)]
	public CameraProperties m_CameraProperties;

	[FieldOffset(1436)]
	public float m_AccurateOcclusionThreshold;

	[FieldOffset(1440)]
	public int m_MaximumPortalCullingJobs;

	[FieldOffset(1444)]
	public Matrix4x4 m_StereoViewMatrix;

	[FieldOffset(1508)]
	public Matrix4x4 m_StereoProjectionMatrix;

	[FieldOffset(1572)]
	public float m_StereoSeparationDistance;

	[FieldOffset(1576)]
	public int m_maximumVisibleLights;

	[FieldOffset(1580)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_ConservativeEnclosingSphere;

	[FieldOffset(1584)]
	public int m_NumIterationsEnclosingSphere;

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

	public unsafe static int k_LayerCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LayerCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LayerCount, (void*)(&value));
		}
	}

	public unsafe static int layerCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_layerCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_layerCount, (void*)(&value));
		}
	}

	public unsafe static int k_CullingJobCountLowerLimit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CullingJobCountLowerLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CullingJobCountLowerLimit, (void*)(&value));
		}
	}

	public unsafe static int k_CullingJobCountUpperLimit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_CullingJobCountUpperLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_CullingJobCountUpperLimit, (void*)(&value));
		}
	}

	public unsafe int maximumVisibleLights
	{
		get
		{
			return m_maximumVisibleLights;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238044, RefRangeEnd = 1238046, XrefRangeStart = 1238044, XrefRangeEnd = 1238044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool conservativeEnclosingSphere
	{
		get
		{
			return m_ConservativeEnclosingSphere;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238046, RefRangeEnd = 1238047, XrefRangeStart = 1238046, XrefRangeEnd = 1238046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int numIterationsEnclosingSphere
	{
		get
		{
			return m_NumIterationsEnclosingSphere;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238047, RefRangeEnd = 1238048, XrefRangeStart = 1238047, XrefRangeEnd = 1238047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int cullingPlaneCount
	{
		[CallerCount(0)]
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
				throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("{0} was {1}, but must be at least 0 and less than {2}", "value", (Il2CppSystem.Object)(object)value, (Il2CppSystem.Object)(object)10));
			}
			m_CullingPlaneCount = value;
		}
	}

	public unsafe float shadowDistance
	{
		get
		{
			return m_ShadowDistance;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238048, RefRangeEnd = 1238049, XrefRangeStart = 1238048, XrefRangeEnd = 1238048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CullingOptions cullingOptions
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1238049, RefRangeEnd = 1238054, XrefRangeStart = 1238049, XrefRangeEnd = 1238049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CullingOptions*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 493394, RefRangeEnd = 493399, XrefRangeStart = 493394, XrefRangeEnd = 493399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
	{
		get
		{
			return m_ReflectionProbeSortingCriteria;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238054, RefRangeEnd = 1238055, XrefRangeStart = 1238054, XrefRangeEnd = 1238054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Matrix4x4 stereoViewMatrix
	{
		get
		{
			return m_StereoViewMatrix;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238055, RefRangeEnd = 1238056, XrefRangeStart = 1238055, XrefRangeEnd = 1238055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Matrix4x4 stereoProjectionMatrix
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1238056, RefRangeEnd = 1238058, XrefRangeStart = 1238056, XrefRangeEnd = 1238056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238058, RefRangeEnd = 1238059, XrefRangeStart = 1238058, XrefRangeEnd = 1238058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float stereoSeparationDistance
	{
		get
		{
			return m_StereoSeparationDistance;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1238059, RefRangeEnd = 1238060, XrefRangeStart = 1238059, XrefRangeEnd = 1238059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool isOrthographic
	{
		get
		{
			return m_LODParameters.isOrthographic;
		}
		set
		{
			m_LODParameters.isOrthographic = value;
		}
	}

	public LODParameters lodParameters
	{
		get
		{
			return m_LODParameters;
		}
		set
		{
			m_LODParameters = value;
		}
	}

	public uint cullingMask
	{
		get
		{
			return m_CullingMask;
		}
		set
		{
			m_CullingMask = value;
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

	public Vector3 origin
	{
		get
		{
			return m_Origin;
		}
		set
		{
			m_Origin = value;
		}
	}

	public float shadowNearPlaneOffset
	{
		get
		{
			return m_ShadowNearPlaneOffset;
		}
		set
		{
			m_ShadowNearPlaneOffset = value;
		}
	}

	public CameraProperties cameraProperties
	{
		get
		{
			return m_CameraProperties;
		}
		set
		{
			m_CameraProperties = value;
		}
	}

	public float accurateOcclusionThreshold
	{
		get
		{
			return m_AccurateOcclusionThreshold;
		}
		set
		{
			m_AccurateOcclusionThreshold = Mathf.Max(-1f, value);
		}
	}

	public int maximumPortalCullingJobs
	{
		get
		{
			return m_MaximumPortalCullingJobs;
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static int cullingJobsLowerLimit => 1;

	public static int cullingJobsUpperLimit => 16;

	static ScriptableCullingParameters()
	{
		Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "ScriptableCullingParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr);
		NativeFieldInfoPtr_m_LODParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LODParameters");
		NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_MaximumCullingPlaneCount");
		NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "maximumCullingPlaneCount");
		NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingPlanes");
		NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingPlaneCount");
		NativeFieldInfoPtr_m_CullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingMask");
		NativeFieldInfoPtr_m_SceneMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_SceneMask");
		NativeFieldInfoPtr_m_ViewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ViewID");
		NativeFieldInfoPtr_k_LayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_LayerCount");
		NativeFieldInfoPtr_layerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "layerCount");
		NativeFieldInfoPtr_m_LayerFarCullDistances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LayerFarCullDistances");
		NativeFieldInfoPtr_m_LayerCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_LayerCull");
		NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingMatrix");
		NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_Origin");
		NativeFieldInfoPtr_m_ShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ShadowDistance");
		NativeFieldInfoPtr_m_ShadowNearPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ShadowNearPlaneOffset");
		NativeFieldInfoPtr_m_CullingOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CullingOptions");
		NativeFieldInfoPtr_m_ReflectionProbeSortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ReflectionProbeSortingCriteria");
		NativeFieldInfoPtr_m_CameraProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_CameraProperties");
		NativeFieldInfoPtr_m_AccurateOcclusionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_AccurateOcclusionThreshold");
		NativeFieldInfoPtr_m_MaximumPortalCullingJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_MaximumPortalCullingJobs");
		NativeFieldInfoPtr_k_CullingJobCountLowerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_CullingJobCountLowerLimit");
		NativeFieldInfoPtr_k_CullingJobCountUpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "k_CullingJobCountUpperLimit");
		NativeFieldInfoPtr_m_StereoViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoViewMatrix");
		NativeFieldInfoPtr_m_StereoProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoProjectionMatrix");
		NativeFieldInfoPtr_m_StereoSeparationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_StereoSeparationDistance");
		NativeFieldInfoPtr_m_maximumVisibleLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_maximumVisibleLights");
		NativeFieldInfoPtr_m_ConservativeEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_ConservativeEnclosingSphere");
		NativeFieldInfoPtr_m_NumIterationsEnclosingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, "m_NumIterationsEnclosingSphere");
		NativeMethodInfoPtr_set_maximumVisibleLights_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668443);
		NativeMethodInfoPtr_set_conservativeEnclosingSphere_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668444);
		NativeMethodInfoPtr_set_numIterationsEnclosingSphere_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668445);
		NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668446);
		NativeMethodInfoPtr_set_shadowDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668447);
		NativeMethodInfoPtr_get_cullingOptions_Public_get_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668448);
		NativeMethodInfoPtr_set_cullingOptions_Public_set_Void_CullingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668449);
		NativeMethodInfoPtr_set_reflectionProbeSortingCriteria_Public_set_Void_ReflectionProbeSortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668450);
		NativeMethodInfoPtr_set_stereoViewMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668451);
		NativeMethodInfoPtr_get_stereoProjectionMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668452);
		NativeMethodInfoPtr_set_stereoProjectionMatrix_Public_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668453);
		NativeMethodInfoPtr_set_stereoSeparationDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668454);
		NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668455);
		NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668456);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668457);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668458);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, 100668459);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238060, RefRangeEnd = 1238062, XrefRangeStart = 1238060, XrefRangeEnd = 1238060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetLayerCullingDistance(int layerIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layerIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLayerCullingDistance_Public_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1238065, RefRangeEnd = 1238067, XrefRangeStart = 1238062, XrefRangeEnd = 1238065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Plane GetCullingPlane(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Plane*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1238085, RefRangeEnd = 1238086, XrefRangeStart = 1238067, XrefRangeEnd = 1238085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(ScriptableCullingParameters other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptableCullingParameters_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238086, XrefRangeEnd = 1238093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1238093, XrefRangeEnd = 1238112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptableCullingParameters>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void SetLayerCullingDistance(int layerIndex, float distance)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetCullingPlane(int index, Plane plane)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator ==(ScriptableCullingParameters left, ScriptableCullingParameters right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(ScriptableCullingParameters left, ScriptableCullingParameters right)
	{
		return !left.Equals(right);
	}
}
