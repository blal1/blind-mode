using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering;

public class ProbeAdjustmentVolume : MonoBehaviour
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Shape")]
	public enum Shape
	{
		Box,
		Sphere
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Mode")]
	public enum Mode
	{
		InvalidateProbes = 0,
		OverrideValidityThreshold = 1,
		ApplyVirtualOffset = 2,
		OverrideVirtualOffsetSettings = 3,
		OverrideSkyDirection = 4,
		OverrideSampleCount = 5,
		OverrideRenderingLayerMask = 6,
		IntensityScale = 99
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "RenderingLayerMaskOperation")]
	public enum RenderingLayerMaskOperation
	{
		Override,
		Add,
		Remove
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Version")]
	public enum Version
	{
		Initial,
		Mode,
		Count
	}

	private static readonly IntPtr NativeFieldInfoPtr_shape;

	private static readonly IntPtr NativeFieldInfoPtr_size;

	private static readonly IntPtr NativeFieldInfoPtr_radius;

	private static readonly IntPtr NativeFieldInfoPtr_mode;

	private static readonly IntPtr NativeFieldInfoPtr_intensityScale;

	private static readonly IntPtr NativeFieldInfoPtr_overriddenDilationThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_virtualOffsetRotation;

	private static readonly IntPtr NativeFieldInfoPtr_virtualOffsetDistance;

	private static readonly IntPtr NativeFieldInfoPtr_geometryBias;

	private static readonly IntPtr NativeFieldInfoPtr_virtualOffsetThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_rayOriginBias;

	private static readonly IntPtr NativeFieldInfoPtr_skyDirection;

	private static readonly IntPtr NativeFieldInfoPtr_skyShadingDirectionRotation;

	private static readonly IntPtr NativeFieldInfoPtr_directSampleCount;

	private static readonly IntPtr NativeFieldInfoPtr_indirectSampleCount;

	private static readonly IntPtr NativeFieldInfoPtr_sampleCountMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_maxBounces;

	private static readonly IntPtr NativeFieldInfoPtr_skyOcclusionSampleCount;

	private static readonly IntPtr NativeFieldInfoPtr_skyOcclusionMaxBounces;

	private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMaskOperation;

	private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMask;

	private static readonly IntPtr NativeFieldInfoPtr_version;

	private static readonly IntPtr NativeFieldInfoPtr_invalidateProbes;

	private static readonly IntPtr NativeFieldInfoPtr_overrideDilationThreshold;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Shape shape
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shape);
			return *(Shape*)num;
		}
		set
		{
			*(Shape*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shape)) = value;
		}
	}

	public unsafe Vector3 size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_size)) = value;
		}
	}

	public unsafe float radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radius)) = value;
		}
	}

	public unsafe Mode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(Mode*)num;
		}
		set
		{
			*(Mode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = value;
		}
	}

	public unsafe float intensityScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensityScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intensityScale)) = value;
		}
	}

	public unsafe float overriddenDilationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overriddenDilationThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overriddenDilationThreshold)) = value;
		}
	}

	public unsafe Vector3 virtualOffsetRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualOffsetRotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualOffsetRotation)) = value;
		}
	}

	public unsafe float virtualOffsetDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualOffsetDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualOffsetDistance)) = value;
		}
	}

	public unsafe float geometryBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometryBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_geometryBias)) = value;
		}
	}

	public unsafe float virtualOffsetThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualOffsetThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_virtualOffsetThreshold)) = value;
		}
	}

	public unsafe float rayOriginBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayOriginBias);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rayOriginBias)) = value;
		}
	}

	public unsafe Vector3 skyDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyDirection)) = value;
		}
	}

	public unsafe Vector3 skyShadingDirectionRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyShadingDirectionRotation);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyShadingDirectionRotation)) = value;
		}
	}

	public unsafe int directSampleCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directSampleCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directSampleCount)) = value;
		}
	}

	public unsafe int indirectSampleCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectSampleCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectSampleCount)) = value;
		}
	}

	public unsafe int sampleCountMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleCountMultiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleCountMultiplier)) = value;
		}
	}

	public unsafe int maxBounces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBounces);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBounces)) = value;
		}
	}

	public unsafe int skyOcclusionSampleCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionSampleCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionSampleCount)) = value;
		}
	}

	public unsafe int skyOcclusionMaxBounces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionMaxBounces);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skyOcclusionMaxBounces)) = value;
		}
	}

	public unsafe RenderingLayerMaskOperation renderingLayerMaskOperation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMaskOperation);
			return *(RenderingLayerMaskOperation*)num;
		}
		set
		{
			*(RenderingLayerMaskOperation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMaskOperation)) = value;
		}
	}

	public unsafe byte renderingLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMask);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMask)) = value;
		}
	}

	public unsafe Version version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return *(Version*)num;
		}
		set
		{
			*(Version*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)) = value;
		}
	}

	public unsafe bool invalidateProbes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidateProbes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invalidateProbes)) = value;
		}
	}

	public unsafe bool overrideDilationThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDilationThreshold);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideDilationThreshold)) = value;
		}
	}

	static ProbeAdjustmentVolume()
	{
		Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeAdjustmentVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr);
		NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "shape");
		NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "size");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_intensityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "intensityScale");
		NativeFieldInfoPtr_overriddenDilationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "overriddenDilationThreshold");
		NativeFieldInfoPtr_virtualOffsetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "virtualOffsetRotation");
		NativeFieldInfoPtr_virtualOffsetDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "virtualOffsetDistance");
		NativeFieldInfoPtr_geometryBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "geometryBias");
		NativeFieldInfoPtr_virtualOffsetThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "virtualOffsetThreshold");
		NativeFieldInfoPtr_rayOriginBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "rayOriginBias");
		NativeFieldInfoPtr_skyDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "skyDirection");
		NativeFieldInfoPtr_skyShadingDirectionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "skyShadingDirectionRotation");
		NativeFieldInfoPtr_directSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "directSampleCount");
		NativeFieldInfoPtr_indirectSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "indirectSampleCount");
		NativeFieldInfoPtr_sampleCountMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "sampleCountMultiplier");
		NativeFieldInfoPtr_maxBounces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "maxBounces");
		NativeFieldInfoPtr_skyOcclusionSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "skyOcclusionSampleCount");
		NativeFieldInfoPtr_skyOcclusionMaxBounces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "skyOcclusionMaxBounces");
		NativeFieldInfoPtr_renderingLayerMaskOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "renderingLayerMaskOperation");
		NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "renderingLayerMask");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "version");
		NativeFieldInfoPtr_invalidateProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "invalidateProbes");
		NativeFieldInfoPtr_overrideDilationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, "overrideDilationThreshold");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, 100665268);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, 100665269);
		NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, 100665270);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr, 100665271);
	}

	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037629, RefRangeEnd = 1037630, XrefRangeStart = 1037622, XrefRangeEnd = 1037629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeAdjustmentVolume()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeAdjustmentVolume>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeAdjustmentVolume(IntPtr pointer)
		: base(pointer)
	{
	}
}
