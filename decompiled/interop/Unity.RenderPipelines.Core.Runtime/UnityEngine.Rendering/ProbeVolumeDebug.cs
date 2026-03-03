using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public class ProbeVolumeDebug : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawProbes;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBricks;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawCells;

	private static readonly System.IntPtr NativeFieldInfoPtr_realtimeSubdivision;

	private static readonly System.IntPtr NativeFieldInfoPtr_subdivisionCellUpdatePerFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_subdivisionDelayInSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeShading;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_subdivisionViewCullingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeCullingDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxSubdivToVisualize;

	private static readonly System.IntPtr NativeFieldInfoPtr_minSubdivToVisualize;

	private static readonly System.IntPtr NativeFieldInfoPtr_exposureCompensation;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawProbeSamplingDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_probeSamplingDebugSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugWithSamplingNoise;

	private static readonly System.IntPtr NativeFieldInfoPtr_samplingRenderingLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawVirtualOffsetPush;

	private static readonly System.IntPtr NativeFieldInfoPtr_offsetSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_freezeStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayCellStreamingScore;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIndexFragmentation;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherStateIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_verboseStreamingLog;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugStreaming;

	private static readonly System.IntPtr NativeFieldInfoPtr_autoDrawProbes;

	private static readonly System.IntPtr NativeFieldInfoPtr_isolationProbeDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ActiveAdjustmentVolumes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__GetReset_b__32_0_Private_Void_0;

	public unsafe bool drawProbes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawProbes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawProbes)) = value;
		}
	}

	public unsafe bool drawBricks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBricks);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBricks)) = value;
		}
	}

	public unsafe bool drawCells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawCells);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawCells)) = value;
		}
	}

	public unsafe bool realtimeSubdivision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realtimeSubdivision);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_realtimeSubdivision)) = value;
		}
	}

	public unsafe int subdivisionCellUpdatePerFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisionCellUpdatePerFrame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisionCellUpdatePerFrame)) = value;
		}
	}

	public unsafe float subdivisionDelayInSeconds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisionDelayInSeconds);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisionDelayInSeconds)) = value;
		}
	}

	public unsafe DebugProbeShadingMode probeShading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeShading);
			return *(DebugProbeShadingMode*)num;
		}
		set
		{
			*(DebugProbeShadingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeShading)) = value;
		}
	}

	public unsafe float probeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSize)) = value;
		}
	}

	public unsafe float subdivisionViewCullingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisionViewCullingDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subdivisionViewCullingDistance)) = value;
		}
	}

	public unsafe float probeCullingDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeCullingDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeCullingDistance)) = value;
		}
	}

	public unsafe int maxSubdivToVisualize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSubdivToVisualize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSubdivToVisualize)) = value;
		}
	}

	public unsafe int minSubdivToVisualize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSubdivToVisualize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minSubdivToVisualize)) = value;
		}
	}

	public unsafe float exposureCompensation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposureCompensation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposureCompensation)) = value;
		}
	}

	public unsafe bool drawProbeSamplingDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawProbeSamplingDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawProbeSamplingDebug)) = value;
		}
	}

	public unsafe float probeSamplingDebugSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeSamplingDebugSize)) = value;
		}
	}

	public unsafe bool debugWithSamplingNoise
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugWithSamplingNoise);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugWithSamplingNoise)) = value;
		}
	}

	public unsafe uint samplingRenderingLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samplingRenderingLayer);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samplingRenderingLayer)) = value;
		}
	}

	public unsafe bool drawVirtualOffsetPush
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawVirtualOffsetPush);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawVirtualOffsetPush)) = value;
		}
	}

	public unsafe float offsetSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offsetSize)) = value;
		}
	}

	public unsafe bool freezeStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezeStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_freezeStreaming)) = value;
		}
	}

	public unsafe bool displayCellStreamingScore
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayCellStreamingScore);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayCellStreamingScore)) = value;
		}
	}

	public unsafe bool displayIndexFragmentation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayIndexFragmentation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayIndexFragmentation)) = value;
		}
	}

	public unsafe int otherStateIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherStateIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_otherStateIndex)) = value;
		}
	}

	public unsafe bool verboseStreamingLog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verboseStreamingLog);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verboseStreamingLog)) = value;
		}
	}

	public unsafe bool debugStreaming
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugStreaming);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugStreaming)) = value;
		}
	}

	public unsafe bool autoDrawProbes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoDrawProbes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoDrawProbes)) = value;
		}
	}

	public unsafe bool isolationProbeDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isolationProbeDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isolationProbeDebug)) = value;
		}
	}

	public unsafe byte visibleLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLayers);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleLayers)) = value;
		}
	}

	public unsafe static Vector3 currentOffset
	{
		get
		{
			Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentOffset, (void*)(&value));
		}
	}

	public unsafe static int s_ActiveAdjustmentVolumes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ActiveAdjustmentVolumes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ActiveAdjustmentVolumes, (void*)(&value));
		}
	}

	static ProbeVolumeDebug()
	{
		Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeDebug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr);
		NativeFieldInfoPtr_drawProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawProbes");
		NativeFieldInfoPtr_drawBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawBricks");
		NativeFieldInfoPtr_drawCells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawCells");
		NativeFieldInfoPtr_realtimeSubdivision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "realtimeSubdivision");
		NativeFieldInfoPtr_subdivisionCellUpdatePerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "subdivisionCellUpdatePerFrame");
		NativeFieldInfoPtr_subdivisionDelayInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "subdivisionDelayInSeconds");
		NativeFieldInfoPtr_probeShading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeShading");
		NativeFieldInfoPtr_probeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeSize");
		NativeFieldInfoPtr_subdivisionViewCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "subdivisionViewCullingDistance");
		NativeFieldInfoPtr_probeCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeCullingDistance");
		NativeFieldInfoPtr_maxSubdivToVisualize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "maxSubdivToVisualize");
		NativeFieldInfoPtr_minSubdivToVisualize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "minSubdivToVisualize");
		NativeFieldInfoPtr_exposureCompensation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "exposureCompensation");
		NativeFieldInfoPtr_drawProbeSamplingDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawProbeSamplingDebug");
		NativeFieldInfoPtr_probeSamplingDebugSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "probeSamplingDebugSize");
		NativeFieldInfoPtr_debugWithSamplingNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "debugWithSamplingNoise");
		NativeFieldInfoPtr_samplingRenderingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "samplingRenderingLayer");
		NativeFieldInfoPtr_drawVirtualOffsetPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "drawVirtualOffsetPush");
		NativeFieldInfoPtr_offsetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "offsetSize");
		NativeFieldInfoPtr_freezeStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "freezeStreaming");
		NativeFieldInfoPtr_displayCellStreamingScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "displayCellStreamingScore");
		NativeFieldInfoPtr_displayIndexFragmentation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "displayIndexFragmentation");
		NativeFieldInfoPtr_otherStateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "otherStateIndex");
		NativeFieldInfoPtr_verboseStreamingLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "verboseStreamingLog");
		NativeFieldInfoPtr_debugStreaming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "debugStreaming");
		NativeFieldInfoPtr_autoDrawProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "autoDrawProbes");
		NativeFieldInfoPtr_isolationProbeDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "isolationProbeDebug");
		NativeFieldInfoPtr_visibleLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "visibleLayers");
		NativeFieldInfoPtr_currentOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "currentOffset");
		NativeFieldInfoPtr_s_ActiveAdjustmentVolumes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, "s_ActiveAdjustmentVolumes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100665740);
		NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100665741);
		NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100665742);
		NativeMethodInfoPtr__GetReset_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr, 100665743);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1043857, RefRangeEnd = 1043858, XrefRangeStart = 1043856, XrefRangeEnd = 1043857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeVolumeDebug()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeDebug>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1043858, XrefRangeEnd = 1043864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Action GetReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReset_Public_Virtual_Final_New_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe void _GetReset_b__32_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetReset_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeVolumeDebug(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
