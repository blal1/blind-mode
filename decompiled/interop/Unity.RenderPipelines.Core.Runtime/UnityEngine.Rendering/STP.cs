using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public static class STP : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PerViewConfig
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_currentProj;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastProj;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastLastProj;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentView;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastView;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastLastView;

		[FieldOffset(0)]
		public Matrix4x4 currentProj;

		[FieldOffset(64)]
		public Matrix4x4 lastProj;

		[FieldOffset(128)]
		public Matrix4x4 lastLastProj;

		[FieldOffset(192)]
		public Matrix4x4 currentView;

		[FieldOffset(256)]
		public Matrix4x4 lastView;

		[FieldOffset(320)]
		public Matrix4x4 lastLastView;

		static PerViewConfig()
		{
			Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "PerViewConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr);
			NativeFieldInfoPtr_currentProj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, "currentProj");
			NativeFieldInfoPtr_lastProj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, "lastProj");
			NativeFieldInfoPtr_lastLastProj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, "lastLastProj");
			NativeFieldInfoPtr_currentView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, "currentView");
			NativeFieldInfoPtr_lastView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, "lastView");
			NativeFieldInfoPtr_lastLastView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, "lastLastView");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerViewConfig>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class Config : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_noiseTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputStencil;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugView;

		private static readonly System.IntPtr NativeFieldInfoPtr_destination;

		private static readonly System.IntPtr NativeFieldInfoPtr_historyContext;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableHwDrs;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableTexArray;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableMotionScaling;

		private static readonly System.IntPtr NativeFieldInfoPtr_nearPlane;

		private static readonly System.IntPtr NativeFieldInfoPtr_farPlane;

		private static readonly System.IntPtr NativeFieldInfoPtr_frameIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasValidHistory;

		private static readonly System.IntPtr NativeFieldInfoPtr_stencilMask;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugViewIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastDeltaTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentImageSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorImageSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_outputImageSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_numActiveViews;

		private static readonly System.IntPtr NativeFieldInfoPtr_perViewConfigs;

		public unsafe Texture2D noiseTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe TextureHandle inputColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputColor);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputColor)) = value;
			}
		}

		public unsafe TextureHandle inputDepth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDepth);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDepth)) = value;
			}
		}

		public unsafe TextureHandle inputMotion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMotion);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMotion)) = value;
			}
		}

		public unsafe TextureHandle inputStencil
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputStencil);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputStencil)) = value;
			}
		}

		public unsafe TextureHandle debugView
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView)) = value;
			}
		}

		public unsafe TextureHandle destination
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destination)) = value;
			}
		}

		public unsafe HistoryContext historyContext
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_historyContext);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HistoryContext>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_historyContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool enableHwDrs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHwDrs);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableHwDrs)) = value;
			}
		}

		public unsafe bool enableTexArray
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTexArray);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableTexArray)) = value;
			}
		}

		public unsafe bool enableMotionScaling
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMotionScaling);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableMotionScaling)) = value;
			}
		}

		public unsafe float nearPlane
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearPlane);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nearPlane)) = value;
			}
		}

		public unsafe float farPlane
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farPlane);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_farPlane)) = value;
			}
		}

		public unsafe int frameIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frameIndex)) = value;
			}
		}

		public unsafe bool hasValidHistory
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasValidHistory);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasValidHistory)) = value;
			}
		}

		public unsafe int stencilMask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilMask);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stencilMask)) = value;
			}
		}

		public unsafe int debugViewIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugViewIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugViewIndex)) = value;
			}
		}

		public unsafe float deltaTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_deltaTime)) = value;
			}
		}

		public unsafe float lastDeltaTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDeltaTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastDeltaTime)) = value;
			}
		}

		public unsafe Vector2Int currentImageSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentImageSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentImageSize)) = value;
			}
		}

		public unsafe Vector2Int priorImageSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorImageSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorImageSize)) = value;
			}
		}

		public unsafe Vector2Int outputImageSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputImageSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputImageSize)) = value;
			}
		}

		public unsafe int numActiveViews
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numActiveViews);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numActiveViews)) = value;
			}
		}

		public unsafe Il2CppStructArray<PerViewConfig> perViewConfigs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perViewConfigs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PerViewConfig>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perViewConfigs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Config()
		{
			Il2CppClassPointerStore<Config>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "Config");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Config>.NativeClassPtr);
			NativeFieldInfoPtr_noiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "noiseTexture");
			NativeFieldInfoPtr_inputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "inputColor");
			NativeFieldInfoPtr_inputDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "inputDepth");
			NativeFieldInfoPtr_inputMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "inputMotion");
			NativeFieldInfoPtr_inputStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "inputStencil");
			NativeFieldInfoPtr_debugView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "debugView");
			NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "destination");
			NativeFieldInfoPtr_historyContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "historyContext");
			NativeFieldInfoPtr_enableHwDrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "enableHwDrs");
			NativeFieldInfoPtr_enableTexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "enableTexArray");
			NativeFieldInfoPtr_enableMotionScaling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "enableMotionScaling");
			NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "nearPlane");
			NativeFieldInfoPtr_farPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "farPlane");
			NativeFieldInfoPtr_frameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "frameIndex");
			NativeFieldInfoPtr_hasValidHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "hasValidHistory");
			NativeFieldInfoPtr_stencilMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "stencilMask");
			NativeFieldInfoPtr_debugViewIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "debugViewIndex");
			NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "deltaTime");
			NativeFieldInfoPtr_lastDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "lastDeltaTime");
			NativeFieldInfoPtr_currentImageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "currentImageSize");
			NativeFieldInfoPtr_priorImageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "priorImageSize");
			NativeFieldInfoPtr_outputImageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "outputImageSize");
			NativeFieldInfoPtr_numActiveViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "numActiveViews");
			NativeFieldInfoPtr_perViewConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Config>.NativeClassPtr, "perViewConfigs");
		}

		public Config(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Config()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Config>.NativeClassPtr))
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "HistoryTextureType")]
	public enum HistoryTextureType
	{
		DepthMotion,
		Luma,
		Convergence,
		Feedback,
		Count
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct HistoryUpdateInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_preUpscaleSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_postUpscaleSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_useHwDrs;

		private static readonly System.IntPtr NativeFieldInfoPtr_useTexArray;

		[FieldOffset(0)]
		public Vector2Int preUpscaleSize;

		[FieldOffset(8)]
		public Vector2Int postUpscaleSize;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.U1)]
		public bool useHwDrs;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.U1)]
		public bool useTexArray;

		static HistoryUpdateInfo()
		{
			Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "HistoryUpdateInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr);
			NativeFieldInfoPtr_preUpscaleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr, "preUpscaleSize");
			NativeFieldInfoPtr_postUpscaleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr, "postUpscaleSize");
			NativeFieldInfoPtr_useHwDrs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr, "useHwDrs");
			NativeFieldInfoPtr_useTexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr, "useTexArray");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HistoryUpdateInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class HistoryContext : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_textures;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_hash;

		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Boolean_byref_HistoryUpdateInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentHistoryTexture_Internal_RTHandle_HistoryTextureType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousHistoryTexture_Internal_RTHandle_HistoryTextureType_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppReferenceArray<RTHandle> m_textures
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textures);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_textures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Hash128 m_hash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_hash);
				return *(Hash128*)num;
			}
			set
			{
				*(Hash128*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_hash)) = value;
			}
		}

		static HistoryContext()
		{
			Il2CppClassPointerStore<HistoryContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "HistoryContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr);
			NativeFieldInfoPtr_m_textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, "m_textures");
			NativeFieldInfoPtr_m_hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, "m_hash");
			NativeMethodInfoPtr_Update_Public_Boolean_byref_HistoryUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, 100666076);
			NativeMethodInfoPtr_GetCurrentHistoryTexture_Internal_RTHandle_HistoryTextureType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, 100666077);
			NativeMethodInfoPtr_GetPreviousHistoryTexture_Internal_RTHandle_HistoryTextureType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, 100666078);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, 100666079);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr, 100666080);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047068, RefRangeEnd = 1047069, XrefRangeStart = 1047019, XrefRangeEnd = 1047068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Update(ref HistoryUpdateInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref info);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Boolean_byref_HistoryUpdateInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe RTHandle GetCurrentHistoryTexture(HistoryTextureType historyType, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&historyType);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentHistoryTexture_Internal_RTHandle_HistoryTextureType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}

		[CallerCount(0)]
		public unsafe RTHandle GetPreviousHistoryTexture(HistoryTextureType historyType, int frameIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&historyType);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreviousHistoryTexture_Internal_RTHandle_HistoryTextureType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047073, RefRangeEnd = 1047074, XrefRangeStart = 1047069, XrefRangeEnd = 1047073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1047080, RefRangeEnd = 1047081, XrefRangeStart = 1047074, XrefRangeEnd = 1047080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HistoryContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HistoryContext>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public HistoryContext(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "StpSetupPerViewConstants")]
	public enum StpSetupPerViewConstants
	{
		Count = 8
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct StpConstantBufferData
	{
		[StructLayout(LayoutKind.Explicit)]
		[ObfuscatedName("UnityEngine.Rendering.STP+StpConstantBufferData+<_StpSetupPerViewConstants>e__FixedBuffer")]
		public struct __StpSetupPerViewConstants_e__FixedBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

			[FieldOffset(0)]
			public float FixedElementField;

			static __StpSetupPerViewConstants_e__FixedBuffer()
			{
				Il2CppClassPointerStore<__StpSetupPerViewConstants_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "<_StpSetupPerViewConstants>e__FixedBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__StpSetupPerViewConstants_e__FixedBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__StpSetupPerViewConstants_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
			}

			public unsafe Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<__StpSetupPerViewConstants_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr__StpCommonConstant;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupConstants0;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupConstants1;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupConstants2;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupConstants3;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupConstants4;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupConstants5;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpSetupPerViewConstants;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpDilConstants0;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpTaaConstants0;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpTaaConstants1;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpTaaConstants2;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpTaaConstants3;

		[FieldOffset(0)]
		public Vector4 _StpCommonConstant;

		[FieldOffset(16)]
		public Vector4 _StpSetupConstants0;

		[FieldOffset(32)]
		public Vector4 _StpSetupConstants1;

		[FieldOffset(48)]
		public Vector4 _StpSetupConstants2;

		[FieldOffset(64)]
		public Vector4 _StpSetupConstants3;

		[FieldOffset(80)]
		public Vector4 _StpSetupConstants4;

		[FieldOffset(96)]
		public Vector4 _StpSetupConstants5;

		[FieldOffset(112)]
		public __StpSetupPerViewConstants_e__FixedBuffer _StpSetupPerViewConstants;

		[FieldOffset(368)]
		public Vector4 _StpDilConstants0;

		[FieldOffset(384)]
		public Vector4 _StpTaaConstants0;

		[FieldOffset(400)]
		public Vector4 _StpTaaConstants1;

		[FieldOffset(416)]
		public Vector4 _StpTaaConstants2;

		[FieldOffset(432)]
		public Vector4 _StpTaaConstants3;

		static StpConstantBufferData()
		{
			Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "StpConstantBufferData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr);
			NativeFieldInfoPtr__StpCommonConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpCommonConstant");
			NativeFieldInfoPtr__StpSetupConstants0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupConstants0");
			NativeFieldInfoPtr__StpSetupConstants1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupConstants1");
			NativeFieldInfoPtr__StpSetupConstants2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupConstants2");
			NativeFieldInfoPtr__StpSetupConstants3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupConstants3");
			NativeFieldInfoPtr__StpSetupConstants4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupConstants4");
			NativeFieldInfoPtr__StpSetupConstants5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupConstants5");
			NativeFieldInfoPtr__StpSetupPerViewConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpSetupPerViewConstants");
			NativeFieldInfoPtr__StpDilConstants0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpDilConstants0");
			NativeFieldInfoPtr__StpTaaConstants0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpTaaConstants0");
			NativeFieldInfoPtr__StpTaaConstants1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpTaaConstants1");
			NativeFieldInfoPtr__StpTaaConstants2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpTaaConstants2");
			NativeFieldInfoPtr__StpTaaConstants3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, "_StpTaaConstants3");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StpConstantBufferData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public static class ShaderResources : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__StpConstantBufferData;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpBlueNoiseIn;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpDebugOut;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpInputColor;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpInputDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpInputMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpInputStencil;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpIntermediateColor;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpIntermediateConvergence;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpIntermediateWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpPriorLuma;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpLuma;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpPriorDepthMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpDepthMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpPriorFeedback;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpFeedback;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpPriorConvergence;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpConvergence;

		private static readonly System.IntPtr NativeFieldInfoPtr__StpOutput;

		public unsafe static int _StpConstantBufferData
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpConstantBufferData, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpConstantBufferData, (void*)(&value));
			}
		}

		public unsafe static int _StpBlueNoiseIn
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpBlueNoiseIn, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpBlueNoiseIn, (void*)(&value));
			}
		}

		public unsafe static int _StpDebugOut
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpDebugOut, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpDebugOut, (void*)(&value));
			}
		}

		public unsafe static int _StpInputColor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpInputColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpInputColor, (void*)(&value));
			}
		}

		public unsafe static int _StpInputDepth
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpInputDepth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpInputDepth, (void*)(&value));
			}
		}

		public unsafe static int _StpInputMotion
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpInputMotion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpInputMotion, (void*)(&value));
			}
		}

		public unsafe static int _StpInputStencil
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpInputStencil, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpInputStencil, (void*)(&value));
			}
		}

		public unsafe static int _StpIntermediateColor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpIntermediateColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpIntermediateColor, (void*)(&value));
			}
		}

		public unsafe static int _StpIntermediateConvergence
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpIntermediateConvergence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpIntermediateConvergence, (void*)(&value));
			}
		}

		public unsafe static int _StpIntermediateWeights
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpIntermediateWeights, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpIntermediateWeights, (void*)(&value));
			}
		}

		public unsafe static int _StpPriorLuma
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpPriorLuma, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpPriorLuma, (void*)(&value));
			}
		}

		public unsafe static int _StpLuma
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpLuma, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpLuma, (void*)(&value));
			}
		}

		public unsafe static int _StpPriorDepthMotion
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpPriorDepthMotion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpPriorDepthMotion, (void*)(&value));
			}
		}

		public unsafe static int _StpDepthMotion
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpDepthMotion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpDepthMotion, (void*)(&value));
			}
		}

		public unsafe static int _StpPriorFeedback
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpPriorFeedback, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpPriorFeedback, (void*)(&value));
			}
		}

		public unsafe static int _StpFeedback
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpFeedback, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpFeedback, (void*)(&value));
			}
		}

		public unsafe static int _StpPriorConvergence
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpPriorConvergence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpPriorConvergence, (void*)(&value));
			}
		}

		public unsafe static int _StpConvergence
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpConvergence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpConvergence, (void*)(&value));
			}
		}

		public unsafe static int _StpOutput
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__StpOutput, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__StpOutput, (void*)(&value));
			}
		}

		static ShaderResources()
		{
			Il2CppClassPointerStore<ShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "ShaderResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr);
			NativeFieldInfoPtr__StpConstantBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpConstantBufferData");
			NativeFieldInfoPtr__StpBlueNoiseIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpBlueNoiseIn");
			NativeFieldInfoPtr__StpDebugOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpDebugOut");
			NativeFieldInfoPtr__StpInputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpInputColor");
			NativeFieldInfoPtr__StpInputDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpInputDepth");
			NativeFieldInfoPtr__StpInputMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpInputMotion");
			NativeFieldInfoPtr__StpInputStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpInputStencil");
			NativeFieldInfoPtr__StpIntermediateColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpIntermediateColor");
			NativeFieldInfoPtr__StpIntermediateConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpIntermediateConvergence");
			NativeFieldInfoPtr__StpIntermediateWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpIntermediateWeights");
			NativeFieldInfoPtr__StpPriorLuma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpPriorLuma");
			NativeFieldInfoPtr__StpLuma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpLuma");
			NativeFieldInfoPtr__StpPriorDepthMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpPriorDepthMotion");
			NativeFieldInfoPtr__StpDepthMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpDepthMotion");
			NativeFieldInfoPtr__StpPriorFeedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpPriorFeedback");
			NativeFieldInfoPtr__StpFeedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpFeedback");
			NativeFieldInfoPtr__StpPriorConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpPriorConvergence");
			NativeFieldInfoPtr__StpConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpConvergence");
			NativeFieldInfoPtr__StpOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderResources>.NativeClassPtr, "_StpOutput");
		}

		public ShaderResources(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ShaderKeywords : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_EnableDebugMode;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnableLargeKernel;

		private static readonly System.IntPtr NativeFieldInfoPtr_EnableStencilResponsive;

		private static readonly System.IntPtr NativeFieldInfoPtr_DisableTexture2DXArray;

		public unsafe static string EnableDebugMode
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnableDebugMode, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnableDebugMode, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string EnableLargeKernel
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnableLargeKernel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnableLargeKernel, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string EnableStencilResponsive
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnableStencilResponsive, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnableStencilResponsive, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string DisableTexture2DXArray
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DisableTexture2DXArray, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static ShaderKeywords()
		{
			Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "ShaderKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
			NativeFieldInfoPtr_EnableDebugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "EnableDebugMode");
			NativeFieldInfoPtr_EnableLargeKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "EnableLargeKernel");
			NativeFieldInfoPtr_EnableStencilResponsive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "EnableStencilResponsive");
			NativeFieldInfoPtr_DisableTexture2DXArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "DisableTexture2DXArray");
		}

		public ShaderKeywords(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public class RuntimeResources : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_setupCS;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_preTaaCS;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_taaCS;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_version_Public_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_setupCS_Public_get_ComputeShader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_setupCS_Public_set_Void_ComputeShader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_preTaaCS_Public_get_ComputeShader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_preTaaCS_Public_set_Void_ComputeShader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_taaCS_Public_get_ComputeShader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_taaCS_Public_set_Void_ComputeShader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ComputeShader m_setupCS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_setupCS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_setupCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeShader m_preTaaCS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_preTaaCS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_preTaaCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeShader m_taaCS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_taaCS);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_taaCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe virtual int version
		{
			[CallerCount(146)]
			[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe ComputeShader setupCS
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_setupCS_Public_get_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047081, XrefRangeEnd = 1047086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_setupCS_Public_set_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ComputeShader preTaaCS
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preTaaCS_Public_get_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047086, XrefRangeEnd = 1047091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_preTaaCS_Public_set_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe ComputeShader taaCS
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_taaCS_Public_get_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047091, XrefRangeEnd = 1047096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_taaCS_Public_set_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static RuntimeResources()
		{
			Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "RuntimeResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr);
			NativeFieldInfoPtr_m_setupCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "m_setupCS");
			NativeFieldInfoPtr_m_preTaaCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "m_preTaaCS");
			NativeFieldInfoPtr_m_taaCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, "m_taaCS");
			NativeMethodInfoPtr_get_version_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666083);
			NativeMethodInfoPtr_get_setupCS_Public_get_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666084);
			NativeMethodInfoPtr_set_setupCS_Public_set_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666085);
			NativeMethodInfoPtr_get_preTaaCS_Public_get_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666086);
			NativeMethodInfoPtr_set_preTaaCS_Public_set_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666087);
			NativeMethodInfoPtr_get_taaCS_Public_get_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666088);
			NativeMethodInfoPtr_set_taaCS_Public_set_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666089);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr, 100666090);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeResources()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeResources>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public RuntimeResources(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "ProfileId")]
	public enum ProfileId
	{
		StpSetup,
		StpPreTaa,
		StpTaa
	}

	public class SetupData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cs;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_dispatchSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_constantBufferData;

		private static readonly System.IntPtr NativeFieldInfoPtr_noiseTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugView;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputStencil;

		private static readonly System.IntPtr NativeFieldInfoPtr_intermediateColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_intermediateConvergence;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorDepthMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorLuma;

		private static readonly System.IntPtr NativeFieldInfoPtr_luma;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorFeedback;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorConvergence;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ComputeShader cs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int kernelIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelIndex)) = value;
			}
		}

		public unsafe int viewCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount)) = value;
			}
		}

		public unsafe Vector2Int dispatchSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dispatchSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dispatchSize)) = value;
			}
		}

		public unsafe StpConstantBufferData constantBufferData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBufferData);
				return *(StpConstantBufferData*)num;
			}
			set
			{
				*(StpConstantBufferData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBufferData)) = value;
			}
		}

		public unsafe TextureHandle noiseTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture)) = value;
			}
		}

		public unsafe TextureHandle debugView
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView)) = value;
			}
		}

		public unsafe TextureHandle inputColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputColor);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputColor)) = value;
			}
		}

		public unsafe TextureHandle inputDepth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDepth);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputDepth)) = value;
			}
		}

		public unsafe TextureHandle inputMotion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMotion);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputMotion)) = value;
			}
		}

		public unsafe TextureHandle inputStencil
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputStencil);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputStencil)) = value;
			}
		}

		public unsafe TextureHandle intermediateColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateColor);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateColor)) = value;
			}
		}

		public unsafe TextureHandle intermediateConvergence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateConvergence);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateConvergence)) = value;
			}
		}

		public unsafe TextureHandle priorDepthMotion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorDepthMotion);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorDepthMotion)) = value;
			}
		}

		public unsafe TextureHandle depthMotion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthMotion);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthMotion)) = value;
			}
		}

		public unsafe TextureHandle priorLuma
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorLuma);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorLuma)) = value;
			}
		}

		public unsafe TextureHandle luma
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luma);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luma)) = value;
			}
		}

		public unsafe TextureHandle priorFeedback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorFeedback);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorFeedback)) = value;
			}
		}

		public unsafe TextureHandle priorConvergence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorConvergence);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorConvergence)) = value;
			}
		}

		static SetupData()
		{
			Il2CppClassPointerStore<SetupData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "SetupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupData>.NativeClassPtr);
			NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "cs");
			NativeFieldInfoPtr_kernelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "kernelIndex");
			NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "viewCount");
			NativeFieldInfoPtr_dispatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "dispatchSize");
			NativeFieldInfoPtr_constantBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "constantBufferData");
			NativeFieldInfoPtr_noiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "noiseTexture");
			NativeFieldInfoPtr_debugView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "debugView");
			NativeFieldInfoPtr_inputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "inputColor");
			NativeFieldInfoPtr_inputDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "inputDepth");
			NativeFieldInfoPtr_inputMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "inputMotion");
			NativeFieldInfoPtr_inputStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "inputStencil");
			NativeFieldInfoPtr_intermediateColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "intermediateColor");
			NativeFieldInfoPtr_intermediateConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "intermediateConvergence");
			NativeFieldInfoPtr_priorDepthMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "priorDepthMotion");
			NativeFieldInfoPtr_depthMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "depthMotion");
			NativeFieldInfoPtr_priorLuma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "priorLuma");
			NativeFieldInfoPtr_luma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "luma");
			NativeFieldInfoPtr_priorFeedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "priorFeedback");
			NativeFieldInfoPtr_priorConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupData>.NativeClassPtr, "priorConvergence");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupData>.NativeClassPtr, 100666091);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SetupData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PreTaaData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cs;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_dispatchSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_noiseTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugView;

		private static readonly System.IntPtr NativeFieldInfoPtr_intermediateConvergence;

		private static readonly System.IntPtr NativeFieldInfoPtr_intermediateWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr_luma;

		private static readonly System.IntPtr NativeFieldInfoPtr_convergence;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ComputeShader cs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int kernelIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelIndex)) = value;
			}
		}

		public unsafe int viewCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount)) = value;
			}
		}

		public unsafe Vector2Int dispatchSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dispatchSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dispatchSize)) = value;
			}
		}

		public unsafe TextureHandle noiseTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture)) = value;
			}
		}

		public unsafe TextureHandle debugView
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView)) = value;
			}
		}

		public unsafe TextureHandle intermediateConvergence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateConvergence);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateConvergence)) = value;
			}
		}

		public unsafe TextureHandle intermediateWeights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateWeights);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateWeights)) = value;
			}
		}

		public unsafe TextureHandle luma
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luma);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_luma)) = value;
			}
		}

		public unsafe TextureHandle convergence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convergence);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convergence)) = value;
			}
		}

		static PreTaaData()
		{
			Il2CppClassPointerStore<PreTaaData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "PreTaaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr);
			NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "cs");
			NativeFieldInfoPtr_kernelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "kernelIndex");
			NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "viewCount");
			NativeFieldInfoPtr_dispatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "dispatchSize");
			NativeFieldInfoPtr_noiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "noiseTexture");
			NativeFieldInfoPtr_debugView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "debugView");
			NativeFieldInfoPtr_intermediateConvergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "intermediateConvergence");
			NativeFieldInfoPtr_intermediateWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "intermediateWeights");
			NativeFieldInfoPtr_luma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "luma");
			NativeFieldInfoPtr_convergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, "convergence");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr, 100666092);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PreTaaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreTaaData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PreTaaData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TaaData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cs;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_dispatchSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_noiseTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugView;

		private static readonly System.IntPtr NativeFieldInfoPtr_intermediateColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_intermediateWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr_priorFeedback;

		private static readonly System.IntPtr NativeFieldInfoPtr_depthMotion;

		private static readonly System.IntPtr NativeFieldInfoPtr_convergence;

		private static readonly System.IntPtr NativeFieldInfoPtr_feedback;

		private static readonly System.IntPtr NativeFieldInfoPtr_output;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe ComputeShader cs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int kernelIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelIndex)) = value;
			}
		}

		public unsafe int viewCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewCount)) = value;
			}
		}

		public unsafe Vector2Int dispatchSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dispatchSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dispatchSize)) = value;
			}
		}

		public unsafe TextureHandle noiseTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noiseTexture)) = value;
			}
		}

		public unsafe TextureHandle debugView
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugView)) = value;
			}
		}

		public unsafe TextureHandle intermediateColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateColor);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateColor)) = value;
			}
		}

		public unsafe TextureHandle intermediateWeights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateWeights);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intermediateWeights)) = value;
			}
		}

		public unsafe TextureHandle priorFeedback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorFeedback);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priorFeedback)) = value;
			}
		}

		public unsafe TextureHandle depthMotion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthMotion);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthMotion)) = value;
			}
		}

		public unsafe TextureHandle convergence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convergence);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_convergence)) = value;
			}
		}

		public unsafe TextureHandle feedback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feedback);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_feedback)) = value;
			}
		}

		public unsafe TextureHandle output
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_output);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_output)) = value;
			}
		}

		static TaaData()
		{
			Il2CppClassPointerStore<TaaData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "TaaData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaData>.NativeClassPtr);
			NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "cs");
			NativeFieldInfoPtr_kernelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "kernelIndex");
			NativeFieldInfoPtr_viewCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "viewCount");
			NativeFieldInfoPtr_dispatchSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "dispatchSize");
			NativeFieldInfoPtr_noiseTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "noiseTexture");
			NativeFieldInfoPtr_debugView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "debugView");
			NativeFieldInfoPtr_intermediateColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "intermediateColor");
			NativeFieldInfoPtr_intermediateWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "intermediateWeights");
			NativeFieldInfoPtr_priorFeedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "priorFeedback");
			NativeFieldInfoPtr_depthMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "depthMotion");
			NativeFieldInfoPtr_convergence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "convergence");
			NativeFieldInfoPtr_feedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "feedback");
			NativeFieldInfoPtr_output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaData>.NativeClassPtr, "output");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaData>.NativeClassPtr, 100666093);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaaData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaaData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TaaData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.STP+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__38_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__38_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__38_2;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__38_0_Internal_Void_SetupData_ComputeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__38_1_Internal_Void_PreTaaData_ComputeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Execute_b__38_2_Internal_Void_TaaData_ComputeGraphContext_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<SetupData, ComputeGraphContext> __9__38_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SetupData, ComputeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__38_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<PreTaaData, ComputeGraphContext> __9__38_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__38_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PreTaaData, ComputeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__38_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<TaaData, ComputeGraphContext> __9__38_2
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__38_2, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<TaaData, ComputeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__38_2, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<STP>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__38_0");
			NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__38_1");
			NativeFieldInfoPtr___9__38_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__38_2");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666095);
			NativeMethodInfoPtr__Execute_b__38_0_Internal_Void_SetupData_ComputeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666096);
			NativeMethodInfoPtr__Execute_b__38_1_Internal_Void_PreTaaData_ComputeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666097);
			NativeMethodInfoPtr__Execute_b__38_2_Internal_Void_TaaData_ComputeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666098);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047096, XrefRangeEnd = 1047153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Execute_b__38_0(SetupData data, ComputeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Execute_b__38_0_Internal_Void_SetupData_ComputeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047153, XrefRangeEnd = 1047184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Execute_b__38_1(PreTaaData data, ComputeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Execute_b__38_1_Internal_Void_PreTaaData_ComputeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047184, XrefRangeEnd = 1047221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Execute_b__38_2(TaaData data, ComputeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Execute_b__38_2_Internal_Void_TaaData_ComputeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kNumDebugViews;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DebugViewDescriptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DebugViewIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxPerViewConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PerViewConfigs;

	private static readonly System.IntPtr NativeFieldInfoPtr_kNumHistoryTextureTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_kTotalSetupViewConstantsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_kQualcommVendorId;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Jit16_Public_Static_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugViewDescriptions_Public_Static_get_Il2CppReferenceArray_1_GUIContent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_debugViewIndices_Public_Static_get_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_perViewConfigs_Public_Static_get_Il2CppStructArray_1_PerViewConfig_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_perViewConfigs_Public_Static_set_Void_Il2CppStructArray_1_PerViewConfig_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHistoryHash_Private_Static_Hash128_byref_HistoryUpdateInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateConvergenceTextureSize_Private_Static_Vector2Int_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateMotionScale_Private_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractRotation_Private_Static_Matrix4x4_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackVector2ToInt_Private_Static_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopulateConstantData_Private_Static_Void_byref_Config_byref_StpConstantBufferData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseTexture_Private_Static_TextureHandle_IBaseRenderGraphBuilder_TextureHandle_AccessFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_TextureHandle_RenderGraph_byref_Config_0;

	public unsafe static int kNumDebugViews
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kNumDebugViews, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kNumDebugViews, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<GUIContent> s_DebugViewDescriptions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DebugViewDescriptions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DebugViewDescriptions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> s_DebugViewIndices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DebugViewIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DebugViewIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int kMaxPerViewConfigs
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxPerViewConfigs, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxPerViewConfigs, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<PerViewConfig> s_PerViewConfigs
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PerViewConfigs, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PerViewConfig>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PerViewConfigs, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int kNumHistoryTextureTypes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kNumHistoryTextureTypes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kNumHistoryTextureTypes, (void*)(&value));
		}
	}

	public unsafe static int kTotalSetupViewConstantsCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kTotalSetupViewConstantsCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kTotalSetupViewConstantsCount, (void*)(&value));
		}
	}

	public unsafe static int kQualcommVendorId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kQualcommVendorId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kQualcommVendorId, (void*)(&value));
		}
	}

	public unsafe static Il2CppReferenceArray<GUIContent> debugViewDescriptions
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047227, XrefRangeEnd = 1047231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugViewDescriptions_Public_Static_get_Il2CppReferenceArray_1_GUIContent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GUIContent>>(intPtr2) : null;
		}
	}

	public unsafe static Il2CppStructArray<int> debugViewIndices
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047231, XrefRangeEnd = 1047235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_debugViewIndices_Public_Static_get_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
	}

	public unsafe static Il2CppStructArray<PerViewConfig> perViewConfigs
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047235, XrefRangeEnd = 1047239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_perViewConfigs_Public_Static_get_Il2CppStructArray_1_PerViewConfig_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<PerViewConfig>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047239, XrefRangeEnd = 1047245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_perViewConfigs_Public_Static_set_Void_Il2CppStructArray_1_PerViewConfig_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static STP()
	{
		Il2CppClassPointerStore<STP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "STP");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<STP>.NativeClassPtr);
		NativeFieldInfoPtr_kNumDebugViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "kNumDebugViews");
		NativeFieldInfoPtr_s_DebugViewDescriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "s_DebugViewDescriptions");
		NativeFieldInfoPtr_s_DebugViewIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "s_DebugViewIndices");
		NativeFieldInfoPtr_kMaxPerViewConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "kMaxPerViewConfigs");
		NativeFieldInfoPtr_s_PerViewConfigs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "s_PerViewConfigs");
		NativeFieldInfoPtr_kNumHistoryTextureTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "kNumHistoryTextureTypes");
		NativeFieldInfoPtr_kTotalSetupViewConstantsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "kTotalSetupViewConstantsCount");
		NativeFieldInfoPtr_kQualcommVendorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<STP>.NativeClassPtr, "kQualcommVendorId");
		NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666061);
		NativeMethodInfoPtr_Jit16_Public_Static_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666062);
		NativeMethodInfoPtr_get_debugViewDescriptions_Public_Static_get_Il2CppReferenceArray_1_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666063);
		NativeMethodInfoPtr_get_debugViewIndices_Public_Static_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666064);
		NativeMethodInfoPtr_get_perViewConfigs_Public_Static_get_Il2CppStructArray_1_PerViewConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666065);
		NativeMethodInfoPtr_set_perViewConfigs_Public_Static_set_Void_Il2CppStructArray_1_PerViewConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666066);
		NativeMethodInfoPtr_ComputeHistoryHash_Private_Static_Hash128_byref_HistoryUpdateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666067);
		NativeMethodInfoPtr_CalculateConvergenceTextureSize_Private_Static_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666068);
		NativeMethodInfoPtr_CalculateMotionScale_Private_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666069);
		NativeMethodInfoPtr_ExtractRotation_Private_Static_Matrix4x4_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666070);
		NativeMethodInfoPtr_PackVector2ToInt_Private_Static_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666071);
		NativeMethodInfoPtr_PopulateConstantData_Private_Static_Void_byref_Config_byref_StpConstantBufferData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666072);
		NativeMethodInfoPtr_UseTexture_Private_Static_TextureHandle_IBaseRenderGraphBuilder_TextureHandle_AccessFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666073);
		NativeMethodInfoPtr_Execute_Public_Static_TextureHandle_RenderGraph_byref_Config_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<STP>.NativeClassPtr, 100666074);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1047223, RefRangeEnd = 1047224, XrefRangeStart = 1047221, XrefRangeEnd = 1047223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSupported()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSupported_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1047226, RefRangeEnd = 1047227, XrefRangeStart = 1047224, XrefRangeEnd = 1047226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 Jit16(int frameIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Jit16_Public_Static_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047245, XrefRangeEnd = 1047255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hash128 ComputeHistoryHash(ref HistoryUpdateInfo info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHistoryHash_Private_Static_Hash128_byref_HistoryUpdateInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Hash128*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1047260, RefRangeEnd = 1047262, XrefRangeStart = 1047255, XrefRangeEnd = 1047260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2Int CalculateConvergenceTextureSize(Vector2Int historyTextureSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&historyTextureSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateConvergenceTextureSize_Private_Static_Vector2Int_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047262, XrefRangeEnd = 1047264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalculateMotionScale(float deltaTime, float lastDeltaTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&deltaTime);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lastDeltaTime;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateMotionScale_Private_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047264, XrefRangeEnd = 1047268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 ExtractRotation(Matrix4x4 input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractRotation_Private_Static_Matrix4x4_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047268, XrefRangeEnd = 1047270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PackVector2ToInt(Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackVector2ToInt_Private_Static_Int32_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1047357, RefRangeEnd = 1047358, XrefRangeStart = 1047270, XrefRangeEnd = 1047357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PopulateConstantData(ref Config config, ref StpConstantBufferData constants)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)config);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref constants);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopulateConstantData_Private_Static_Void_byref_Config_byref_StpConstantBufferData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1047361, RefRangeEnd = 1047368, XrefRangeStart = 1047358, XrefRangeEnd = 1047361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureHandle UseTexture(IBaseRenderGraphBuilder builder, TextureHandle texture, AccessFlags flags = AccessFlags.Read)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &texture;
		*(AccessFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseTexture_Private_Static_TextureHandle_IBaseRenderGraphBuilder_TextureHandle_AccessFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1047715, RefRangeEnd = 1047716, XrefRangeStart = 1047368, XrefRangeEnd = 1047715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureHandle Execute(RenderGraph renderGraph, ref Config config)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)config);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Static_TextureHandle_RenderGraph_byref_Config_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public STP(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
