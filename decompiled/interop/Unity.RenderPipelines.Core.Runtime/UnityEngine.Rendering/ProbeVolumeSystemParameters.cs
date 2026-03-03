using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class ProbeVolumeSystemParameters : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_memoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_blendingMemoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_shBands;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportScenarios;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportScenarioBlending;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportGPUStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportDiskStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeDebugShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeSamplingDebugShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeSamplingDebugTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeSamplingDebugMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetDebugShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_fragmentationDebugShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_scenarioBlendingShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_streamingUploadShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneData;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportsRuntimeDebug;

	public unsafe ProbeVolumeTextureMemoryBudget memoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryBudget);
			return *(ProbeVolumeTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memoryBudget)) = value;
		}
	}

	public unsafe ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingMemoryBudget);
			return *(ProbeVolumeBlendingTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeBlendingTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blendingMemoryBudget)) = value;
		}
	}

	public unsafe ProbeVolumeSHBands shBands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shBands);
			return *(ProbeVolumeSHBands*)num;
		}
		set
		{
			*(ProbeVolumeSHBands*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shBands)) = value;
		}
	}

	public unsafe bool supportScenarios
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportScenarios);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportScenarios)) = value;
		}
	}

	public unsafe bool supportScenarioBlending
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportScenarioBlending);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportScenarioBlending)) = value;
		}
	}

	public unsafe bool supportGPUStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportGPUStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportGPUStreaming)) = value;
		}
	}

	public unsafe bool supportDiskStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDiskStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDiskStreaming)) = value;
		}
	}

	public unsafe Shader probeDebugShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeDebugShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeDebugShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Shader probeSamplingDebugShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Texture probeSamplingDebugTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mesh probeSamplingDebugMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Shader offsetDebugShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetDebugShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetDebugShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Shader fragmentationDebugShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragmentationDebugShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fragmentationDebugShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeShader scenarioBlendingShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenarioBlendingShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scenarioBlendingShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeShader streamingUploadShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streamingUploadShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_streamingUploadShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeSceneData sceneData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeVolumeSceneData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool supportsRuntimeDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsRuntimeDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportsRuntimeDebug)) = value;
		}
	}

	static ProbeVolumeSystemParameters()
	{
		Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeSystemParameters");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr);
		NativeFieldInfoPtr_memoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "memoryBudget");
		NativeFieldInfoPtr_blendingMemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "blendingMemoryBudget");
		NativeFieldInfoPtr_shBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "shBands");
		NativeFieldInfoPtr_supportScenarios = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportScenarios");
		NativeFieldInfoPtr_supportScenarioBlending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportScenarioBlending");
		NativeFieldInfoPtr_supportGPUStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportGPUStreaming");
		NativeFieldInfoPtr_supportDiskStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportDiskStreaming");
		NativeFieldInfoPtr_probeDebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "probeDebugShader");
		NativeFieldInfoPtr_probeSamplingDebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "probeSamplingDebugShader");
		NativeFieldInfoPtr_probeSamplingDebugTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "probeSamplingDebugTexture");
		NativeFieldInfoPtr_probeSamplingDebugMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "probeSamplingDebugMesh");
		NativeFieldInfoPtr_offsetDebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "offsetDebugShader");
		NativeFieldInfoPtr_fragmentationDebugShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "fragmentationDebugShader");
		NativeFieldInfoPtr_scenarioBlendingShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "scenarioBlendingShader");
		NativeFieldInfoPtr_streamingUploadShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "streamingUploadShader");
		NativeFieldInfoPtr_sceneData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "sceneData");
		NativeFieldInfoPtr_supportsRuntimeDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr, "supportsRuntimeDebug");
	}

	public ProbeVolumeSystemParameters(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ProbeVolumeSystemParameters()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeSystemParameters>.NativeClassPtr))
	{
	}
}
