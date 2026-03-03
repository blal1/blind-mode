using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct EarlyUpdate
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PollPlayerConnection
	{
		static PollPlayerConnection()
		{
			Il2CppClassPointerStore<PollPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollPlayerConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollPlayerConnection>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PollPlayerConnection>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PollHtcsPlayerConnection
	{
		static PollHtcsPlayerConnection()
		{
			Il2CppClassPointerStore<PollHtcsPlayerConnection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PollHtcsPlayerConnection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PollHtcsPlayerConnection>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PollHtcsPlayerConnection>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct GpuTimestamp
	{
		static GpuTimestamp()
		{
			Il2CppClassPointerStore<GpuTimestamp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "GpuTimestamp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GpuTimestamp>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GpuTimestamp>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AnalyticsCoreStatsUpdate
	{
		static AnalyticsCoreStatsUpdate()
		{
			Il2CppClassPointerStore<AnalyticsCoreStatsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "AnalyticsCoreStatsUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsCoreStatsUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnalyticsCoreStatsUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UnityWebRequestUpdate
	{
		static UnityWebRequestUpdate()
		{
			Il2CppClassPointerStore<UnityWebRequestUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UnityWebRequestUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequestUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityWebRequestUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateStreamingManager
	{
		static UpdateStreamingManager()
		{
			Il2CppClassPointerStore<UpdateStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateStreamingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateStreamingManager>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateStreamingManager>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ExecuteMainThreadJobs
	{
		static ExecuteMainThreadJobs()
		{
			Il2CppClassPointerStore<ExecuteMainThreadJobs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ExecuteMainThreadJobs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecuteMainThreadJobs>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExecuteMainThreadJobs>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ProcessMouseInWindow
	{
		static ProcessMouseInWindow()
		{
			Il2CppClassPointerStore<ProcessMouseInWindow>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessMouseInWindow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessMouseInWindow>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProcessMouseInWindow>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ClearIntermediateRenderers
	{
		static ClearIntermediateRenderers()
		{
			Il2CppClassPointerStore<ClearIntermediateRenderers>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearIntermediateRenderers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearIntermediateRenderers>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClearIntermediateRenderers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ClearLines
	{
		static ClearLines()
		{
			Il2CppClassPointerStore<ClearLines>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ClearLines");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearLines>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClearLines>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PresentBeforeUpdate
	{
		static PresentBeforeUpdate()
		{
			Il2CppClassPointerStore<PresentBeforeUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PresentBeforeUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentBeforeUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresentBeforeUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ResetFrameStatsAfterPresent
	{
		static ResetFrameStatsAfterPresent()
		{
			Il2CppClassPointerStore<ResetFrameStatsAfterPresent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ResetFrameStatsAfterPresent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResetFrameStatsAfterPresent>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResetFrameStatsAfterPresent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateAsyncReadbackManager
	{
		static UpdateAsyncReadbackManager()
		{
			Il2CppClassPointerStore<UpdateAsyncReadbackManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncReadbackManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateAsyncReadbackManager>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateAsyncReadbackManager>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateTextureStreamingManager
	{
		static UpdateTextureStreamingManager()
		{
			Il2CppClassPointerStore<UpdateTextureStreamingManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateTextureStreamingManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTextureStreamingManager>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateTextureStreamingManager>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdatePreloading
	{
		static UpdatePreloading()
		{
			Il2CppClassPointerStore<UpdatePreloading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdatePreloading");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePreloading>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdatePreloading>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateContentLoading
	{
		static UpdateContentLoading()
		{
			Il2CppClassPointerStore<UpdateContentLoading>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateContentLoading");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateContentLoading>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateContentLoading>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateAsyncInstantiate
	{
		static UpdateAsyncInstantiate()
		{
			Il2CppClassPointerStore<UpdateAsyncInstantiate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateAsyncInstantiate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateAsyncInstantiate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateAsyncInstantiate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RendererNotifyInvisible
	{
		static RendererNotifyInvisible()
		{
			Il2CppClassPointerStore<RendererNotifyInvisible>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "RendererNotifyInvisible");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererNotifyInvisible>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererNotifyInvisible>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PlayerCleanupCachedData
	{
		static PlayerCleanupCachedData()
		{
			Il2CppClassPointerStore<PlayerCleanupCachedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PlayerCleanupCachedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCleanupCachedData>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerCleanupCachedData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateMainGameViewRect
	{
		static UpdateMainGameViewRect()
		{
			Il2CppClassPointerStore<UpdateMainGameViewRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateMainGameViewRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateMainGameViewRect>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateMainGameViewRect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateCanvasRectTransform
	{
		static UpdateCanvasRectTransform()
		{
			Il2CppClassPointerStore<UpdateCanvasRectTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateCanvasRectTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCanvasRectTransform>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateCanvasRectTransform>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateInputManager
	{
		static UpdateInputManager()
		{
			Il2CppClassPointerStore<UpdateInputManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateInputManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateInputManager>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateInputManager>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ProcessRemoteInput
	{
		static ProcessRemoteInput()
		{
			Il2CppClassPointerStore<ProcessRemoteInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ProcessRemoteInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProcessRemoteInput>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProcessRemoteInput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct XRUpdate
	{
		static XRUpdate()
		{
			Il2CppClassPointerStore<XRUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "XRUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ScriptRunDelayedStartupFrame
	{
		static ScriptRunDelayedStartupFrame()
		{
			Il2CppClassPointerStore<ScriptRunDelayedStartupFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ScriptRunDelayedStartupFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunDelayedStartupFrame>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptRunDelayedStartupFrame>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateKinect
	{
		static UpdateKinect()
		{
			Il2CppClassPointerStore<UpdateKinect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "UpdateKinect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateKinect>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateKinect>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DeliverIosPlatformEvents
	{
		static DeliverIosPlatformEvents()
		{
			Il2CppClassPointerStore<DeliverIosPlatformEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DeliverIosPlatformEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliverIosPlatformEvents>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeliverIosPlatformEvents>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DispatchEventQueueEvents
	{
		static DispatchEventQueueEvents()
		{
			Il2CppClassPointerStore<DispatchEventQueueEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "DispatchEventQueueEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DispatchEventQueueEvents>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DispatchEventQueueEvents>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Physics2DEarlyUpdate
	{
		static Physics2DEarlyUpdate()
		{
			Il2CppClassPointerStore<Physics2DEarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "Physics2DEarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2DEarlyUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Physics2DEarlyUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PhysicsResetInterpolatedTransformPosition
	{
		static PhysicsResetInterpolatedTransformPosition()
		{
			Il2CppClassPointerStore<PhysicsResetInterpolatedTransformPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PhysicsResetInterpolatedTransformPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsResetInterpolatedTransformPosition>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsResetInterpolatedTransformPosition>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SpriteAtlasManagerUpdate
	{
		static SpriteAtlasManagerUpdate()
		{
			Il2CppClassPointerStore<SpriteAtlasManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "SpriteAtlasManagerUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlasManagerUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpriteAtlasManagerUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct TangoUpdate
	{
		static TangoUpdate()
		{
			Il2CppClassPointerStore<TangoUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "TangoUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TangoUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TangoUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ARCoreUpdate
	{
		static ARCoreUpdate()
		{
			Il2CppClassPointerStore<ARCoreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "ARCoreUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ARCoreUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ARCoreUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PerformanceAnalyticsUpdate
	{
		static PerformanceAnalyticsUpdate()
		{
			Il2CppClassPointerStore<PerformanceAnalyticsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "PerformanceAnalyticsUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerformanceAnalyticsUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerformanceAnalyticsUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct TilemapRendererEarlyUpdate
	{
		static TilemapRendererEarlyUpdate()
		{
			Il2CppClassPointerStore<TilemapRendererEarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, "TilemapRendererEarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilemapRendererEarlyUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TilemapRendererEarlyUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public struct ProfilerStartFrame
	{
	}

	static EarlyUpdate()
	{
		Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "EarlyUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EarlyUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
