using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

public sealed class UniversalRenderer : ScriptableRenderer
{
	public new static class Profiling : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_k_Name;

		private static readonly System.IntPtr NativeFieldInfoPtr_createCameraRenderTarget;

		public unsafe static string k_Name
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_Name, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_Name, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static ProfilingSampler createCameraRenderTarget
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_createCameraRenderTarget, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_createCameraRenderTarget, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static Profiling()
		{
			Il2CppClassPointerStore<Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "Profiling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiling>.NativeClassPtr);
			NativeFieldInfoPtr_k_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "k_Name");
			NativeFieldInfoPtr_createCameraRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "createCameraRenderTarget");
		}

		public Profiling(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RenderPassInputSummary
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_requiresDepthTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresDepthPrepass;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresNormalsTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresColorTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresColorTextureCreated;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresMotionVectors;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresDepthNormalAtEvent;

		private static readonly System.IntPtr NativeFieldInfoPtr_requiresDepthTextureEarliestEvent;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requiresDepthTexture;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requiresDepthPrepass;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requiresNormalsTexture;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requiresColorTexture;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requiresColorTextureCreated;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.U1)]
		public bool requiresMotionVectors;

		[FieldOffset(8)]
		public RenderPassEvent requiresDepthNormalAtEvent;

		[FieldOffset(12)]
		public RenderPassEvent requiresDepthTextureEarliestEvent;

		static RenderPassInputSummary()
		{
			Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "RenderPassInputSummary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr);
			NativeFieldInfoPtr_requiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresDepthTexture");
			NativeFieldInfoPtr_requiresDepthPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresDepthPrepass");
			NativeFieldInfoPtr_requiresNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresNormalsTexture");
			NativeFieldInfoPtr_requiresColorTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresColorTexture");
			NativeFieldInfoPtr_requiresColorTextureCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresColorTextureCreated");
			NativeFieldInfoPtr_requiresMotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresMotionVectors");
			NativeFieldInfoPtr_requiresDepthNormalAtEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresDepthNormalAtEvent");
			NativeFieldInfoPtr_requiresDepthTextureEarliestEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, "requiresDepthTextureEarliestEvent");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderPassInputSummary>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class CopyToDebugTexturePassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_src;

		private static readonly System.IntPtr NativeFieldInfoPtr_dest;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle src
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_src)) = value;
			}
		}

		public unsafe TextureHandle dest
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dest);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dest)) = value;
			}
		}

		static CopyToDebugTexturePassData()
		{
			Il2CppClassPointerStore<CopyToDebugTexturePassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "CopyToDebugTexturePassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyToDebugTexturePassData>.NativeClassPtr);
			NativeFieldInfoPtr_src = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyToDebugTexturePassData>.NativeClassPtr, "src");
			NativeFieldInfoPtr_dest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyToDebugTexturePassData>.NativeClassPtr, "dest");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyToDebugTexturePassData>.NativeClassPtr, 100665869);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyToDebugTexturePassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyToDebugTexturePassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CopyToDebugTexturePassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "DepthCopySchedule")]
	public enum DepthCopySchedule
	{
		DuringPrepass,
		AfterPrepass,
		AfterGBuffer,
		AfterOpaques,
		AfterSkybox,
		AfterTransparents,
		None
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "ColorCopySchedule")]
	public enum ColorCopySchedule
	{
		AfterSkybox,
		None
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct TextureCopySchedules
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_depth;

		private static readonly System.IntPtr NativeFieldInfoPtr_color;

		[FieldOffset(0)]
		public DepthCopySchedule depth;

		[FieldOffset(4)]
		public ColorCopySchedule color;

		static TextureCopySchedules()
		{
			Il2CppClassPointerStore<TextureCopySchedules>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "TextureCopySchedules");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureCopySchedules>.NativeClassPtr);
			NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCopySchedules>.NativeClassPtr, "depth");
			NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureCopySchedules>.NativeClassPtr, "color");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureCopySchedules>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.UniversalRenderer+<>c")]
	public new sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__115_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__115_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__144_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__199_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__115_0_Internal_Boolean_ScriptableRenderPass_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__115_1_Internal_Boolean_ScriptableRenderPass_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__BlitEmptyTexture_b__144_0_Internal_Void_CopyToDebugTexturePassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OnAfterRendering_b__199_0_Internal_Boolean_ScriptableRenderPass_0;

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

		public unsafe static Il2CppSystem.Predicate<ScriptableRenderPass> __9__115_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__115_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ScriptableRenderPass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__115_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ScriptableRenderPass> __9__115_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__115_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ScriptableRenderPass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__115_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<CopyToDebugTexturePassData, RasterGraphContext> __9__144_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__144_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<CopyToDebugTexturePassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__144_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ScriptableRenderPass> __9__199_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__199_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ScriptableRenderPass>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__199_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__115_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__115_0");
			NativeFieldInfoPtr___9__115_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__115_1");
			NativeFieldInfoPtr___9__144_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__144_0");
			NativeFieldInfoPtr___9__199_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__199_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665871);
			NativeMethodInfoPtr__Setup_b__115_0_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665872);
			NativeMethodInfoPtr__Setup_b__115_1_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665873);
			NativeMethodInfoPtr__BlitEmptyTexture_b__144_0_Internal_Void_CopyToDebugTexturePassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665874);
			NativeMethodInfoPtr__OnAfterRendering_b__199_0_Internal_Boolean_ScriptableRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665875);
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
		public unsafe bool _Setup_b__115_0(ScriptableRenderPass x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Setup_b__115_0_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _Setup_b__115_1(ScriptableRenderPass x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Setup_b__115_1_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101982, XrefRangeEnd = 1101990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _BlitEmptyTexture_b__144_0(CopyToDebugTexturePassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__BlitEmptyTexture_b__144_0_Internal_Void_CopyToDebugTexturePassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _OnAfterRendering_b__199_0(ScriptableRenderPass x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnAfterRendering_b__199_0_Internal_Boolean_ScriptableRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FinalBlitPassQueueOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DepthNormalsOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Clustering;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthPrepass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthNormalPrepass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrimedDepthCopyPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionVectorPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MainLightShadowCasterPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GBufferPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GBufferCopyDepthPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeferredPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderOpaqueForwardPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawSkyboxPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CopyDepthPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CopyColorPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransparentSettingsPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderTransparentForwardPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnRenderObjectCallbackPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FinalBlitPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CapturePass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_XROcclusionMeshPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_XRCopyDepthPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_XRDepthMotionPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawOffscreenUIPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawOverlayUIPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HistoryRawColorCopyPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HistoryRawDepthCopyPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorBufferSystem;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveCameraColorAttachment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorFrontBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveCameraDepthAttachment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraDepthAttachment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetColorHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetDepthHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalsTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DecalLayersTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OpaqueColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionVectorColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionVectorDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForwardLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeferredLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthPrimingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CopyDepthMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraDepthAttachmentFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraDepthTextureFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthPrimingRecommended;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultStencilState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightCookieManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IntermediateTextureMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VulkanEnablePreTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlitMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlitHDRMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SamplingMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StencilDeferredMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraMotionVecMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PostProcessPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr__opaqueLayerMask_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__transparentLayerMask_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__shadowTransparentReceive_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugBlitMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphCameraColorHandles;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentColorHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderGraphDebugTextureHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RequiresRenderingLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayersEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayersMaskSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayerProvidesRenderObjectPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayerProvidesByDepthNormalPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayersTextureName;

	private static readonly System.IntPtr NativeFieldInfoPtr__CameraTargetAttachmentAName;

	private static readonly System.IntPtr NativeFieldInfoPtr__CameraTargetAttachmentBName;

	private static readonly System.IntPtr NativeFieldInfoPtr__SingleCameraTargetAttachmentName;

	private static readonly System.IntPtr NativeFieldInfoPtr__CameraDepthAttachmentName;

	private static readonly System.IntPtr NativeFieldInfoPtr__CameraColorUpscaled;

	private static readonly System.IntPtr NativeFieldInfoPtr__CameraColorAfterPostProcessingName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedGPUOcclusionUnsupportedMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RequiresIntermediateAttachments;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMotionVectors_FamOrAssem_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsCameraOpaque_FamOrAssem_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsCameraNormals_FamOrAssem_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingModeRequested_Internal_get_RenderingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingModeActual_Internal_get_RenderingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_accurateGbufferNormals_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorGradingLut_Internal_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deferredLights_Internal_get_DeferredLights_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_opaqueLayerMask_Internal_get_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_opaqueLayerMask_Internal_set_Void_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_transparentLayerMask_Internal_get_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_transparentLayerMask_Internal_set_Void_LayerMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shadowTransparentReceive_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowTransparentReceive_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraDepthTextureFormat_Internal_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cameraDepthAttachmentFormat_Internal_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UniversalRendererData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFinalPassDebug_Private_Void_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDepthPrimingEnabled_Private_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWebGL_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGLESDevice_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGLDevice_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasActiveRenderFeatures_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasPassesRequiringIntermediateTexture_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupVFXCameraBuffer_Private_Void_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRawColorDepthHistory_Private_Void_UniversalCameraData_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnqueueDeferred_Private_Void_RenderTextureDescriptor_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCameraRenderTarget_Private_Void_ScriptableRenderContext_byref_RenderTextureDescriptor_CommandBuffer_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlatformRequiresExplicitMsaaResolve_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequiresIntermediateColorTexture_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanCopyDepth_Private_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsNativeRenderPassRendergraphCompiler_Internal_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebugHandlerRequireDepthPass_Private_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDebugTexture_Private_Void_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateUVRect_Private_Rect_UniversalCameraData_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateUVRect_Private_Rect_UniversalCameraData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CorrectForTextureAspectRatio_Private_Void_byref_Single_byref_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderGraphFinalPassDebug_Private_Void_RenderGraph_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAfterPostRenderGraphFinalPassDebug_Private_Void_RenderGraph_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitToDebugTexture_Private_Void_RenderGraph_TextureHandle_TextureHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlitEmptyTexture_Private_Void_RenderGraph_TextureHandle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentRenderGraphCameraColorHandle_Private_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nextRenderGraphCameraColorHandle_Private_get_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanupRenderGraphResources_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderGraphTexture_Public_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_FilterMode_TextureWrapMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderGraphTexture_Internal_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_Color_FilterMode_TextureWrapMode_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldApplyPostProcessing_Private_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraHasPostProcessingWithDepth_Private_Boolean_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequiresIntermediateAttachments_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraHistory_Private_Void_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderGraphCameraRenderTargets_Private_Void_RenderGraph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderingLayers_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderGraphLights_Internal_Void_RenderGraph_UniversalRenderingData_UniversalCameraData_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderRawColorDepthHistory_Private_Void_RenderGraph_UniversalCameraData_UniversalResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginRenderGraphFrame_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_Void_RenderGraph_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndRenderGraphFrame_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsGPUOcclusion_Public_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnOffscreenDepthTextureRendering_Private_Void_RenderGraph_ScriptableRenderContext_UniversalResourceData_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeRendering_Private_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceOccluders_Private_Void_RenderGraph_UniversalCameraData_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceOcclusionTest_Private_Void_RenderGraph_UniversalCameraData_OcclusionTest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordCustomPassesWithDepthCopyAndMotion_Private_Void_RenderGraph_UniversalResourceData_RenderPassEvent_RenderPassEvent_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllowPartialDepthNormalsPrepass_Private_Boolean_Boolean_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateDepthCopySchedule_Private_DepthCopySchedule_RenderPassEvent_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTextureCopySchedules_Private_TextureCopySchedules_UniversalCameraData_RenderPassInputSummary_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDepthToDepthTexture_Private_Void_RenderGraph_UniversalResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMotionVectors_Private_Void_RenderGraph_UniversalResourceData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteScheduledDepthCopyWithMotion_Private_Void_RenderGraph_UniversalResourceData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnMainRendering_Private_Void_RenderGraph_ScriptableRenderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterRendering_Private_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireDepthPrepass_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequireDepthTexture_Private_Boolean_UniversalCameraData_Boolean_byref_RenderPassInputSummary_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderingLayersGlobalTextures_Internal_Void_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCameraDepthCopyTexture_Private_Void_RenderGraph_RenderTextureDescriptor_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMotionVectorTextures_Private_Void_RenderGraph_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCameraNormalsTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderingLayersTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAfterPostProcessTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DepthNormalPrepassRender_Private_Void_RenderGraph_RenderPassInputSummary_TextureHandle_UInt32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref_TextureDesc_PDM_0;

	public unsafe static int k_FinalBlitPassQueueOffset
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_FinalBlitPassQueueOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_FinalBlitPassQueueOffset, (void*)(&value));
		}
	}

	public unsafe static int k_AfterFinalBlitPassQueueOffset
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset, (void*)(&value));
		}
	}

	public unsafe static List<ShaderTagId> k_DepthNormalsOnly
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DepthNormalsOnly, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ShaderTagId>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DepthNormalsOnly, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_Clustering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Clustering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Clustering)) = value;
		}
	}

	public unsafe DepthOnlyPass m_DepthPrepass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrepass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DepthOnlyPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrepass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DepthNormalOnlyPass m_DepthNormalPrepass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthNormalPrepass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DepthNormalOnlyPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthNormalPrepass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyDepthPass m_PrimedDepthCopyPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrimedDepthCopyPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrimedDepthCopyPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MotionVectorRenderPass m_MotionVectorPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectorPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MotionVectorRenderPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectorPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MainLightShadowCasterPass m_MainLightShadowCasterPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightShadowCasterPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MainLightShadowCasterPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MainLightShadowCasterPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdditionalLightsShadowCasterPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GBufferPass m_GBufferPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GBufferPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GBufferPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GBufferPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyDepthPass m_GBufferCopyDepthPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GBufferCopyDepthPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GBufferCopyDepthPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeferredPass m_DeferredPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeferredPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeferredPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeferredPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawObjectsPass m_RenderOpaqueForwardOnlyPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawObjectsPass m_RenderOpaqueForwardPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderOpaqueForwardPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderOpaqueForwardPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawObjectsWithRenderingLayersPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawSkyboxPass m_DrawSkyboxPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawSkyboxPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawSkyboxPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawSkyboxPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyDepthPass m_CopyDepthPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyColorPass m_CopyColorPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyColorPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyColorPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyColorPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TransparentSettingsPass m_TransparentSettingsPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransparentSettingsPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TransparentSettingsPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransparentSettingsPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawObjectsPass m_RenderTransparentForwardPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderTransparentForwardPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawObjectsPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderTransparentForwardPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnRenderObjectCallbackPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InvokeOnRenderObjectCallbackPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnRenderObjectCallbackPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FinalBlitPass m_FinalBlitPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalBlitPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FinalBlitPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalBlitPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CapturePass m_CapturePass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CapturePass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CapturePass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CapturePass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XROcclusionMeshPass m_XROcclusionMeshPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XROcclusionMeshPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XROcclusionMeshPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XROcclusionMeshPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyDepthPass m_XRCopyDepthPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XRCopyDepthPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XRCopyDepthPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XRDepthMotionPass m_XRDepthMotionPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XRDepthMotionPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<XRDepthMotionPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_XRDepthMotionPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawScreenSpaceUIPass m_DrawOffscreenUIPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawOffscreenUIPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawOffscreenUIPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DrawScreenSpaceUIPass m_DrawOverlayUIPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawOverlayUIPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DrawScreenSpaceUIPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawOverlayUIPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyColorPass m_HistoryRawColorCopyPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HistoryRawColorCopyPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyColorPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HistoryRawColorCopyPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CopyDepthPass m_HistoryRawDepthCopyPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HistoryRawDepthCopyPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CopyDepthPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HistoryRawDepthCopyPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTargetBufferSystem m_ColorBufferSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorBufferSystem);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTargetBufferSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorBufferSystem)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_ActiveCameraColorAttachment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveCameraColorAttachment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveCameraColorAttachment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_ColorFrontBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorFrontBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorFrontBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_ActiveCameraDepthAttachment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveCameraDepthAttachment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveCameraDepthAttachment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_CameraDepthAttachment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthAttachment);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthAttachment)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_CameraDepthAttachment_D3d_11
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_TargetColorHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetColorHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetColorHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_TargetDepthHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetDepthHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetDepthHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_DepthTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_NormalsTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NormalsTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NormalsTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_DecalLayersTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalLayersTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DecalLayersTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_OpaqueColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpaqueColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OpaqueColor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_MotionVectorColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectorColor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectorColor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_MotionVectorDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectorDepth);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionVectorDepth)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ForwardLights m_ForwardLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForwardLights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForwardLights>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForwardLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeferredLights m_DeferredLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeferredLights);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeferredLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderingMode m_RenderingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingMode);
			return *(RenderingMode*)num;
		}
		set
		{
			*(RenderingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingMode)) = value;
		}
	}

	public unsafe DepthPrimingMode m_DepthPrimingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrimingMode);
			return *(DepthPrimingMode*)num;
		}
		set
		{
			*(DepthPrimingMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrimingMode)) = value;
		}
	}

	public unsafe CopyDepthMode m_CopyDepthMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthMode);
			return *(CopyDepthMode*)num;
		}
		set
		{
			*(CopyDepthMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CopyDepthMode)) = value;
		}
	}

	public unsafe DepthFormat m_CameraDepthAttachmentFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthAttachmentFormat);
			return *(DepthFormat*)num;
		}
		set
		{
			*(DepthFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthAttachmentFormat)) = value;
		}
	}

	public unsafe DepthFormat m_CameraDepthTextureFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthTextureFormat);
			return *(DepthFormat*)num;
		}
		set
		{
			*(DepthFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraDepthTextureFormat)) = value;
		}
	}

	public unsafe bool m_DepthPrimingRecommended
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrimingRecommended);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthPrimingRecommended)) = value;
		}
	}

	public unsafe StencilState m_DefaultStencilState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultStencilState);
			return *(StencilState*)num;
		}
		set
		{
			*(StencilState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DefaultStencilState)) = value;
		}
	}

	public unsafe LightCookieManager m_LightCookieManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IntermediateTextureMode m_IntermediateTextureMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntermediateTextureMode);
			return *(IntermediateTextureMode*)num;
		}
		set
		{
			*(IntermediateTextureMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IntermediateTextureMode)) = value;
		}
	}

	public unsafe bool m_VulkanEnablePreTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VulkanEnablePreTransform);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VulkanEnablePreTransform)) = value;
		}
	}

	public unsafe Material m_BlitMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlitMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlitMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_BlitHDRMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlitHDRMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlitHDRMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_SamplingMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SamplingMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SamplingMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_StencilDeferredMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StencilDeferredMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StencilDeferredMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_CameraMotionVecMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraMotionVecMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraMotionVecMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PostProcessPasses m_PostProcessPasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostProcessPasses);
			return new PostProcessPasses(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PostProcessPasses), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe LayerMask _opaqueLayerMask_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opaqueLayerMask_k__BackingField);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__opaqueLayerMask_k__BackingField)) = value;
		}
	}

	public unsafe LayerMask _transparentLayerMask_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transparentLayerMask_k__BackingField);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transparentLayerMask_k__BackingField)) = value;
		}
	}

	public unsafe bool _shadowTransparentReceive_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shadowTransparentReceive_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shadowTransparentReceive_k__BackingField)) = value;
		}
	}

	public unsafe Material m_DebugBlitMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugBlitMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugBlitMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<RTHandle> m_RenderGraphCameraColorHandles
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_RenderGraphCameraColorHandles, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_RenderGraphCameraColorHandles, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static RTHandle m_RenderGraphCameraDepthHandle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int m_CurrentColorHandle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CurrentColorHandle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CurrentColorHandle, (void*)(&value));
		}
	}

	public unsafe static RTHandle m_RenderGraphDebugTextureHandle
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_RenderGraphDebugTextureHandle, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_RenderGraphDebugTextureHandle, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_RequiresRenderingLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequiresRenderingLayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequiresRenderingLayer)) = value;
		}
	}

	public unsafe RenderingLayerUtils.Event m_RenderingLayersEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayersEvent);
			return *(RenderingLayerUtils.Event*)num;
		}
		set
		{
			*(RenderingLayerUtils.Event*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayersEvent)) = value;
		}
	}

	public unsafe RenderingLayerUtils.MaskSize m_RenderingLayersMaskSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayersMaskSize);
			return *(RenderingLayerUtils.MaskSize*)num;
		}
		set
		{
			*(RenderingLayerUtils.MaskSize*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayersMaskSize)) = value;
		}
	}

	public unsafe bool m_RenderingLayerProvidesRenderObjectPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayerProvidesRenderObjectPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayerProvidesRenderObjectPass)) = value;
		}
	}

	public unsafe bool m_RenderingLayerProvidesByDepthNormalPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayerProvidesByDepthNormalPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayerProvidesByDepthNormalPass)) = value;
		}
	}

	public unsafe string m_RenderingLayersTextureName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayersTextureName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RenderingLayersTextureName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CameraTargetAttachmentAName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CameraTargetAttachmentAName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CameraTargetAttachmentAName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CameraTargetAttachmentBName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CameraTargetAttachmentBName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CameraTargetAttachmentBName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _SingleCameraTargetAttachmentName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SingleCameraTargetAttachmentName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SingleCameraTargetAttachmentName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CameraDepthAttachmentName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CameraDepthAttachmentName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CameraDepthAttachmentName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CameraColorUpscaled
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CameraColorUpscaled, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CameraColorUpscaled, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string _CameraColorAfterPostProcessingName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CameraColorAfterPostProcessingName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CameraColorAfterPostProcessingName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool m_IssuedGPUOcclusionUnsupportedMsg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedGPUOcclusionUnsupportedMsg);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedGPUOcclusionUnsupportedMsg)) = value;
		}
	}

	public unsafe static bool m_RequiresIntermediateAttachments
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_RequiresIntermediateAttachments, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_RequiresIntermediateAttachments, (void*)(&value));
		}
	}

	public unsafe RenderingMode renderingModeRequested
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingModeRequested_Internal_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RenderingMode renderingModeActual
	{
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 1101993, RefRangeEnd = 1102023, XrefRangeStart = 1101990, XrefRangeEnd = 1101993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingModeActual_Internal_get_RenderingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool accurateGbufferNormals
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1102023, RefRangeEnd = 1102026, XrefRangeStart = 1102023, XrefRangeEnd = 1102023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_accurateGbufferNormals_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe DepthPrimingMode depthPrimingMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DepthPrimingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ColorGradingLutPass colorGradingLutPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ColorGradingLutPass>(intPtr2) : null;
		}
	}

	public unsafe PostProcessPass postProcessPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr2) : null;
		}
	}

	public unsafe PostProcessPass finalPostProcessPass
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr2) : null;
		}
	}

	public unsafe RTHandle colorGradingLut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorGradingLut_Internal_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe DeferredLights deferredLights
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deferredLights_Internal_get_DeferredLights_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DeferredLights>(intPtr2) : null;
		}
	}

	public unsafe LayerMask opaqueLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_opaqueLayerMask_Internal_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_opaqueLayerMask_Internal_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe LayerMask transparentLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_transparentLayerMask_Internal_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LayerMask*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_transparentLayerMask_Internal_set_Void_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool shadowTransparentReceive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shadowTransparentReceive_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shadowTransparentReceive_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GraphicsFormat cameraDepthTextureFormat
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1102027, RefRangeEnd = 1102028, XrefRangeStart = 1102026, XrefRangeEnd = 1102027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepthTextureFormat_Internal_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe GraphicsFormat cameraDepthAttachmentFormat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102028, XrefRangeEnd = 1102029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cameraDepthAttachmentFormat_Internal_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe override bool supportsNativeRenderPassRendergraphCompiler
	{
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsNativeRenderPassRendergraphCompiler_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe RTHandle currentRenderGraphCameraColorHandle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1103062, RefRangeEnd = 1103063, XrefRangeStart = 1103056, XrefRangeEnd = 1103062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentRenderGraphCameraColorHandle_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe RTHandle nextRenderGraphCameraColorHandle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103063, XrefRangeEnd = 1103075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nextRenderGraphCameraColorHandle_Private_get_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
	}

	public unsafe override bool supportsGPUOcclusion
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103473, XrefRangeEnd = 1103480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsGPUOcclusion_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static UniversalRenderer()
	{
		Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "UniversalRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr);
		NativeFieldInfoPtr_k_FinalBlitPassQueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_FinalBlitPassQueueOffset");
		NativeFieldInfoPtr_k_AfterFinalBlitPassQueueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_AfterFinalBlitPassQueueOffset");
		NativeFieldInfoPtr_k_DepthNormalsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "k_DepthNormalsOnly");
		NativeFieldInfoPtr_m_Clustering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_Clustering");
		NativeFieldInfoPtr_m_DepthPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthPrepass");
		NativeFieldInfoPtr_m_DepthNormalPrepass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthNormalPrepass");
		NativeFieldInfoPtr_m_PrimedDepthCopyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_PrimedDepthCopyPass");
		NativeFieldInfoPtr_m_MotionVectorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MotionVectorPass");
		NativeFieldInfoPtr_m_MainLightShadowCasterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MainLightShadowCasterPass");
		NativeFieldInfoPtr_m_AdditionalLightsShadowCasterPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_AdditionalLightsShadowCasterPass");
		NativeFieldInfoPtr_m_GBufferPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_GBufferPass");
		NativeFieldInfoPtr_m_GBufferCopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_GBufferCopyDepthPass");
		NativeFieldInfoPtr_m_DeferredPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DeferredPass");
		NativeFieldInfoPtr_m_RenderOpaqueForwardOnlyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderOpaqueForwardOnlyPass");
		NativeFieldInfoPtr_m_RenderOpaqueForwardPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderOpaqueForwardPass");
		NativeFieldInfoPtr_m_RenderOpaqueForwardWithRenderingLayersPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderOpaqueForwardWithRenderingLayersPass");
		NativeFieldInfoPtr_m_DrawSkyboxPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DrawSkyboxPass");
		NativeFieldInfoPtr_m_CopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyDepthPass");
		NativeFieldInfoPtr_m_CopyColorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyColorPass");
		NativeFieldInfoPtr_m_TransparentSettingsPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_TransparentSettingsPass");
		NativeFieldInfoPtr_m_RenderTransparentForwardPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderTransparentForwardPass");
		NativeFieldInfoPtr_m_OnRenderObjectCallbackPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_OnRenderObjectCallbackPass");
		NativeFieldInfoPtr_m_FinalBlitPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_FinalBlitPass");
		NativeFieldInfoPtr_m_CapturePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CapturePass");
		NativeFieldInfoPtr_m_XROcclusionMeshPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_XROcclusionMeshPass");
		NativeFieldInfoPtr_m_XRCopyDepthPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_XRCopyDepthPass");
		NativeFieldInfoPtr_m_XRDepthMotionPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_XRDepthMotionPass");
		NativeFieldInfoPtr_m_DrawOffscreenUIPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DrawOffscreenUIPass");
		NativeFieldInfoPtr_m_DrawOverlayUIPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DrawOverlayUIPass");
		NativeFieldInfoPtr_m_HistoryRawColorCopyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_HistoryRawColorCopyPass");
		NativeFieldInfoPtr_m_HistoryRawDepthCopyPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_HistoryRawDepthCopyPass");
		NativeFieldInfoPtr_m_ColorBufferSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ColorBufferSystem");
		NativeFieldInfoPtr_m_ActiveCameraColorAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ActiveCameraColorAttachment");
		NativeFieldInfoPtr_m_ColorFrontBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ColorFrontBuffer");
		NativeFieldInfoPtr_m_ActiveCameraDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ActiveCameraDepthAttachment");
		NativeFieldInfoPtr_m_CameraDepthAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraDepthAttachment");
		NativeFieldInfoPtr_m_CameraDepthAttachment_D3d_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraDepthAttachment_D3d_11");
		NativeFieldInfoPtr_m_TargetColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_TargetColorHandle");
		NativeFieldInfoPtr_m_TargetDepthHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_TargetDepthHandle");
		NativeFieldInfoPtr_m_DepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthTexture");
		NativeFieldInfoPtr_m_NormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_NormalsTexture");
		NativeFieldInfoPtr_m_DecalLayersTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DecalLayersTexture");
		NativeFieldInfoPtr_m_OpaqueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_OpaqueColor");
		NativeFieldInfoPtr_m_MotionVectorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MotionVectorColor");
		NativeFieldInfoPtr_m_MotionVectorDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_MotionVectorDepth");
		NativeFieldInfoPtr_m_ForwardLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_ForwardLights");
		NativeFieldInfoPtr_m_DeferredLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DeferredLights");
		NativeFieldInfoPtr_m_RenderingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingMode");
		NativeFieldInfoPtr_m_DepthPrimingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthPrimingMode");
		NativeFieldInfoPtr_m_CopyDepthMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CopyDepthMode");
		NativeFieldInfoPtr_m_CameraDepthAttachmentFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraDepthAttachmentFormat");
		NativeFieldInfoPtr_m_CameraDepthTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraDepthTextureFormat");
		NativeFieldInfoPtr_m_DepthPrimingRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DepthPrimingRecommended");
		NativeFieldInfoPtr_m_DefaultStencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DefaultStencilState");
		NativeFieldInfoPtr_m_LightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_LightCookieManager");
		NativeFieldInfoPtr_m_IntermediateTextureMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_IntermediateTextureMode");
		NativeFieldInfoPtr_m_VulkanEnablePreTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_VulkanEnablePreTransform");
		NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_BlitMaterial");
		NativeFieldInfoPtr_m_BlitHDRMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_BlitHDRMaterial");
		NativeFieldInfoPtr_m_SamplingMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_SamplingMaterial");
		NativeFieldInfoPtr_m_StencilDeferredMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_StencilDeferredMaterial");
		NativeFieldInfoPtr_m_CameraMotionVecMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CameraMotionVecMaterial");
		NativeFieldInfoPtr_m_PostProcessPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_PostProcessPasses");
		NativeFieldInfoPtr__opaqueLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "<opaqueLayerMask>k__BackingField");
		NativeFieldInfoPtr__transparentLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "<transparentLayerMask>k__BackingField");
		NativeFieldInfoPtr__shadowTransparentReceive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "<shadowTransparentReceive>k__BackingField");
		NativeFieldInfoPtr_m_DebugBlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_DebugBlitMaterial");
		NativeFieldInfoPtr_m_RenderGraphCameraColorHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderGraphCameraColorHandles");
		NativeFieldInfoPtr_m_RenderGraphCameraDepthHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderGraphCameraDepthHandle");
		NativeFieldInfoPtr_m_CurrentColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_CurrentColorHandle");
		NativeFieldInfoPtr_m_RenderGraphDebugTextureHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderGraphDebugTextureHandle");
		NativeFieldInfoPtr_m_RequiresRenderingLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RequiresRenderingLayer");
		NativeFieldInfoPtr_m_RenderingLayersEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingLayersEvent");
		NativeFieldInfoPtr_m_RenderingLayersMaskSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingLayersMaskSize");
		NativeFieldInfoPtr_m_RenderingLayerProvidesRenderObjectPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingLayerProvidesRenderObjectPass");
		NativeFieldInfoPtr_m_RenderingLayerProvidesByDepthNormalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingLayerProvidesByDepthNormalPass");
		NativeFieldInfoPtr_m_RenderingLayersTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RenderingLayersTextureName");
		NativeFieldInfoPtr__CameraTargetAttachmentAName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "_CameraTargetAttachmentAName");
		NativeFieldInfoPtr__CameraTargetAttachmentBName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "_CameraTargetAttachmentBName");
		NativeFieldInfoPtr__SingleCameraTargetAttachmentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "_SingleCameraTargetAttachmentName");
		NativeFieldInfoPtr__CameraDepthAttachmentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "_CameraDepthAttachmentName");
		NativeFieldInfoPtr__CameraColorUpscaled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "_CameraColorUpscaled");
		NativeFieldInfoPtr__CameraColorAfterPostProcessingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "_CameraColorAfterPostProcessingName");
		NativeFieldInfoPtr_m_IssuedGPUOcclusionUnsupportedMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_IssuedGPUOcclusionUnsupportedMsg");
		NativeFieldInfoPtr_m_RequiresIntermediateAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, "m_RequiresIntermediateAttachments");
		NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665766);
		NativeMethodInfoPtr_SupportsMotionVectors_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665767);
		NativeMethodInfoPtr_SupportsCameraOpaque_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665768);
		NativeMethodInfoPtr_SupportsCameraNormals_FamOrAssem_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_get_renderingModeRequested_Internal_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665770);
		NativeMethodInfoPtr_get_renderingModeActual_Internal_get_RenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_get_accurateGbufferNormals_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665772);
		NativeMethodInfoPtr_get_depthPrimingMode_Public_get_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665773);
		NativeMethodInfoPtr_set_depthPrimingMode_Public_set_Void_DepthPrimingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665774);
		NativeMethodInfoPtr_get_colorGradingLutPass_Internal_get_ColorGradingLutPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665775);
		NativeMethodInfoPtr_get_postProcessPass_Internal_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665776);
		NativeMethodInfoPtr_get_finalPostProcessPass_Internal_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665777);
		NativeMethodInfoPtr_get_colorGradingLut_Internal_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665778);
		NativeMethodInfoPtr_get_deferredLights_Internal_get_DeferredLights_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665779);
		NativeMethodInfoPtr_get_opaqueLayerMask_Internal_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665780);
		NativeMethodInfoPtr_set_opaqueLayerMask_Internal_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665781);
		NativeMethodInfoPtr_get_transparentLayerMask_Internal_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665782);
		NativeMethodInfoPtr_set_transparentLayerMask_Internal_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665783);
		NativeMethodInfoPtr_get_shadowTransparentReceive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665784);
		NativeMethodInfoPtr_set_shadowTransparentReceive_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665785);
		NativeMethodInfoPtr_get_cameraDepthTextureFormat_Internal_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665786);
		NativeMethodInfoPtr_get_cameraDepthAttachmentFormat_Internal_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665787);
		NativeMethodInfoPtr__ctor_Public_Void_UniversalRendererData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665788);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665789);
		NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665790);
		NativeMethodInfoPtr_SetupFinalPassDebug_Private_Void_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665791);
		NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665792);
		NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665793);
		NativeMethodInfoPtr_IsDepthPrimingEnabled_Private_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665794);
		NativeMethodInfoPtr_IsWebGL_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665795);
		NativeMethodInfoPtr_IsGLESDevice_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665796);
		NativeMethodInfoPtr_IsGLDevice_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr_HasActiveRenderFeatures_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665798);
		NativeMethodInfoPtr_HasPassesRequiringIntermediateTexture_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665799);
		NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665800);
		NativeMethodInfoPtr_SetupVFXCameraBuffer_Private_Void_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665801);
		NativeMethodInfoPtr_SetupRawColorDepthHistory_Private_Void_UniversalCameraData_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665802);
		NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665803);
		NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665804);
		NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665805);
		NativeMethodInfoPtr_EnqueueDeferred_Private_Void_RenderTextureDescriptor_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665806);
		NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665807);
		NativeMethodInfoPtr_CreateCameraRenderTarget_Private_Void_ScriptableRenderContext_byref_RenderTextureDescriptor_CommandBuffer_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665808);
		NativeMethodInfoPtr_PlatformRequiresExplicitMsaaResolve_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665809);
		NativeMethodInfoPtr_RequiresIntermediateColorTexture_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665810);
		NativeMethodInfoPtr_CanCopyDepth_Private_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665811);
		NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_get_supportsNativeRenderPassRendergraphCompiler_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_DebugHandlerRequireDepthPass_Private_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_CreateDebugTexture_Private_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_CalculateUVRect_Private_Rect_UniversalCameraData_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_CalculateUVRect_Private_Rect_UniversalCameraData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_CorrectForTextureAspectRatio_Private_Void_byref_Single_byref_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_SetupRenderGraphFinalPassDebug_Private_Void_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_SetupAfterPostRenderGraphFinalPassDebug_Private_Void_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_BlitToDebugTexture_Private_Void_RenderGraph_TextureHandle_TextureHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_BlitEmptyTexture_Private_Void_RenderGraph_TextureHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_get_currentRenderGraphCameraColorHandle_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr_get_nextRenderGraphCameraColorHandle_Private_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665827);
		NativeMethodInfoPtr_CleanupRenderGraphResources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665828);
		NativeMethodInfoPtr_CreateRenderGraphTexture_Public_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_FilterMode_TextureWrapMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665829);
		NativeMethodInfoPtr_CreateRenderGraphTexture_Internal_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_Color_FilterMode_TextureWrapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665830);
		NativeMethodInfoPtr_ShouldApplyPostProcessing_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665831);
		NativeMethodInfoPtr_CameraHasPostProcessingWithDepth_Private_Boolean_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665832);
		NativeMethodInfoPtr_RequiresIntermediateAttachments_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665833);
		NativeMethodInfoPtr_UpdateCameraHistory_Private_Void_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665834);
		NativeMethodInfoPtr_CreateRenderGraphCameraRenderTargets_Private_Void_RenderGraph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665835);
		NativeMethodInfoPtr_SetupRenderingLayers_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665836);
		NativeMethodInfoPtr_SetupRenderGraphLights_Internal_Void_RenderGraph_UniversalRenderingData_UniversalCameraData_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665837);
		NativeMethodInfoPtr_RenderRawColorDepthHistory_Private_Void_RenderGraph_UniversalCameraData_UniversalResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665838);
		NativeMethodInfoPtr_OnBeginRenderGraphFrame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665839);
		NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_Void_RenderGraph_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665840);
		NativeMethodInfoPtr_OnEndRenderGraphFrame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665841);
		NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665842);
		NativeMethodInfoPtr_get_supportsGPUOcclusion_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665843);
		NativeMethodInfoPtr_OnOffscreenDepthTextureRendering_Private_Void_RenderGraph_ScriptableRenderContext_UniversalResourceData_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665844);
		NativeMethodInfoPtr_OnBeforeRendering_Private_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665845);
		NativeMethodInfoPtr_UpdateInstanceOccluders_Private_Void_RenderGraph_UniversalCameraData_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665846);
		NativeMethodInfoPtr_InstanceOcclusionTest_Private_Void_RenderGraph_UniversalCameraData_OcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665847);
		NativeMethodInfoPtr_RecordCustomPassesWithDepthCopyAndMotion_Private_Void_RenderGraph_UniversalResourceData_RenderPassEvent_RenderPassEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665848);
		NativeMethodInfoPtr_AllowPartialDepthNormalsPrepass_Private_Boolean_Boolean_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665849);
		NativeMethodInfoPtr_CalculateDepthCopySchedule_Private_DepthCopySchedule_RenderPassEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665850);
		NativeMethodInfoPtr_CalculateTextureCopySchedules_Private_TextureCopySchedules_UniversalCameraData_RenderPassInputSummary_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665851);
		NativeMethodInfoPtr_CopyDepthToDepthTexture_Private_Void_RenderGraph_UniversalResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665852);
		NativeMethodInfoPtr_RenderMotionVectors_Private_Void_RenderGraph_UniversalResourceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665853);
		NativeMethodInfoPtr_ExecuteScheduledDepthCopyWithMotion_Private_Void_RenderGraph_UniversalResourceData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665854);
		NativeMethodInfoPtr_OnMainRendering_Private_Void_RenderGraph_ScriptableRenderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665855);
		NativeMethodInfoPtr_OnAfterRendering_Private_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665856);
		NativeMethodInfoPtr_RequireDepthPrepass_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665857);
		NativeMethodInfoPtr_RequireDepthTexture_Private_Boolean_UniversalCameraData_Boolean_byref_RenderPassInputSummary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665858);
		NativeMethodInfoPtr_SetRenderingLayersGlobalTextures_Internal_Void_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665859);
		NativeMethodInfoPtr_CreateCameraDepthCopyTexture_Private_Void_RenderGraph_RenderTextureDescriptor_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665860);
		NativeMethodInfoPtr_CreateMotionVectorTextures_Private_Void_RenderGraph_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665861);
		NativeMethodInfoPtr_CreateCameraNormalsTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665862);
		NativeMethodInfoPtr_CreateRenderingLayersTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665863);
		NativeMethodInfoPtr_CreateAfterPostProcessTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665864);
		NativeMethodInfoPtr_DepthNormalPrepassRender_Private_Void_RenderGraph_RenderPassInputSummary_TextureHandle_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665865);
		NativeMethodInfoPtr_Method_Internal_Static_Void_byref_TextureDesc_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr, 100665867);
	}

	[CallerCount(0)]
	public unsafe override int SupportedCameraStackingTypes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportedCameraStackingTypes_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool SupportsMotionVectors()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMotionVectors_FamOrAssem_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool SupportsCameraOpaque()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsCameraOpaque_FamOrAssem_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool SupportsCameraNormals()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsCameraNormals_FamOrAssem_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102338, RefRangeEnd = 1102339, XrefRangeStart = 1102029, XrefRangeEnd = 1102338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UniversalRenderer(UniversalRendererData data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UniversalRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UniversalRendererData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102339, XrefRangeEnd = 1102389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102389, XrefRangeEnd = 1102402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReleaseRenderTargets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102402, XrefRangeEnd = 1102423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupFinalPassDebug(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFinalPassDebug_Private_Void_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1102431, RefRangeEnd = 1102436, XrefRangeStart = 1102423, XrefRangeEnd = 1102431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOffscreenDepthTexture(ref CameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_byref_CameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102436, XrefRangeEnd = 1102440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOffscreenDepthTexture(UniversalCameraData cameraData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOffscreenDepthTexture_Public_Static_Boolean_UniversalCameraData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1102451, RefRangeEnd = 1102459, XrefRangeStart = 1102440, XrefRangeEnd = 1102451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsDepthPrimingEnabled(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDepthPrimingEnabled_Private_Boolean_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsWebGL()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWebGL_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102459, XrefRangeEnd = 1102460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGLESDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGLESDevice_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1096611, RefRangeEnd = 1096613, XrefRangeStart = 1096611, XrefRangeEnd = 1096613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGLDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGLDevice_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102471, RefRangeEnd = 1102472, XrefRangeStart = 1102460, XrefRangeEnd = 1102471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasActiveRenderFeatures()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasActiveRenderFeatures_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102483, RefRangeEnd = 1102484, XrefRangeStart = 1102472, XrefRangeEnd = 1102483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasPassesRequiringIntermediateTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasPassesRequiringIntermediateTexture_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102484, XrefRangeEnd = 1102571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102599, RefRangeEnd = 1102600, XrefRangeStart = 1102571, XrefRangeEnd = 1102599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupVFXCameraBuffer(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupVFXCameraBuffer_Private_Void_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102600, XrefRangeEnd = 1102638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRawColorDepthHistory(UniversalCameraData cameraData, ref RenderTextureDescriptor cameraTargetDescriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cameraTargetDescriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRawColorDepthHistory_Private_Void_UniversalCameraData_byref_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102638, XrefRangeEnd = 1102661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupLights_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102661, XrefRangeEnd = 1102715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref cullingParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupCullingParameters_Public_Virtual_Void_byref_ScriptableCullingParameters_byref_CameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102715, XrefRangeEnd = 1102719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishRendering(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinishRendering_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102719, XrefRangeEnd = 1102727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnqueueDeferred(RenderTextureDescriptor cameraTargetDescriptor, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&cameraTargetDescriptor);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasDepthPrepass;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasNormalPrepass;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasRenderingLayerPrepass;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyMainShadow;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyAdditionalShadow;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnqueueDeferred_Private_Void_RenderTextureDescriptor_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1102747, RefRangeEnd = 1102749, XrefRangeStart = 1102727, XrefRangeEnd = 1102747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderPassInputSummary GetRenderPassInputs(bool isTemporalAAEnabled, bool postProcessingEnabled, bool isSceneViewCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&isTemporalAAEnabled);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &postProcessingEnabled;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSceneViewCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderPassInputs_Private_RenderPassInputSummary_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderPassInputSummary*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102749, XrefRangeEnd = 1102811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateCameraRenderTarget(ScriptableRenderContext context, ref RenderTextureDescriptor descriptor, CommandBuffer cmd, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCameraRenderTarget_Private_Void_ScriptableRenderContext_byref_RenderTextureDescriptor_CommandBuffer_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1102816, RefRangeEnd = 1102818, XrefRangeStart = 1102811, XrefRangeEnd = 1102816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PlatformRequiresExplicitMsaaResolve()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlatformRequiresExplicitMsaaResolve_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102835, RefRangeEnd = 1102836, XrefRangeStart = 1102818, XrefRangeEnd = 1102835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequiresIntermediateColorTexture(UniversalCameraData cameraData, ref RenderPassInputSummary renderPassInputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPassInputs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequiresIntermediateColorTexture_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1102845, RefRangeEnd = 1102849, XrefRangeStart = 1102836, XrefRangeEnd = 1102845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanCopyDepth(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanCopyDepth_Private_Boolean_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102849, XrefRangeEnd = 1102865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SwapColorBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapColorBuffer_Internal_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102865, XrefRangeEnd = 1102867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraColorFrontBuffer_Internal_Virtual_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102867, XrefRangeEnd = 1102869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraColorBackBuffer_Internal_Virtual_RTHandle_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102869, XrefRangeEnd = 1102871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EnableSwapBufferMSAA(bool enable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableSwapBufferMSAA_Internal_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102871, XrefRangeEnd = 1102874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DebugHandlerRequireDepthPass(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebugHandlerRequireDepthPass_Private_Boolean_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1102887, RefRangeEnd = 1102889, XrefRangeStart = 1102874, XrefRangeEnd = 1102887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateDebugTexture(RenderTextureDescriptor descriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&descriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDebugTexture_Private_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe Rect CalculateUVRect(UniversalCameraData cameraData, float width, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateUVRect_Private_Rect_UniversalCameraData_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1102889, XrefRangeEnd = 1102890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rect CalculateUVRect(UniversalCameraData cameraData, int textureHeightPercent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureHeightPercent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateUVRect_Private_Rect_UniversalCameraData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void CorrectForTextureAspectRatio(ref float width, ref float height, float sourceWidth, float sourceHeight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref width);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref height);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceWidth;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CorrectForTextureAspectRatio_Private_Void_byref_Single_byref_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102962, RefRangeEnd = 1102963, XrefRangeStart = 1102890, XrefRangeEnd = 1102962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderGraphFinalPassDebug_Private_Void_RenderGraph_ContextContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1102985, RefRangeEnd = 1102986, XrefRangeStart = 1102963, XrefRangeEnd = 1102985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAfterPostRenderGraphFinalPassDebug(RenderGraph renderGraph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAfterPostRenderGraphFinalPassDebug_Private_Void_RenderGraph_ContextContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1103013, RefRangeEnd = 1103017, XrefRangeStart = 1102986, XrefRangeEnd = 1103013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlitToDebugTexture(RenderGraph renderGraph, TextureHandle source, TextureHandle destination, bool isSourceTextureColor = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &source;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSourceTextureColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitToDebugTexture_Private_Void_RenderGraph_TextureHandle_TextureHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103055, RefRangeEnd = 1103056, XrefRangeStart = 1103017, XrefRangeEnd = 1103055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlitEmptyTexture(RenderGraph renderGraph, TextureHandle destination, string passName = "Copy To Debug Texture")
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(TextureHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(passName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlitEmptyTexture_Private_Void_RenderGraph_TextureHandle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103075, XrefRangeEnd = 1103092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanupRenderGraphResources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanupRenderGraphResources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(41)]
	[CachedScanResults(RefRangeStart = 1103101, RefRangeEnd = 1103142, XrefRangeStart = 1103092, XrefRangeEnd = 1103101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &desc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		*(FilterMode**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderGraphTexture_Public_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_FilterMode_TextureWrapMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1103151, RefRangeEnd = 1103154, XrefRangeStart = 1103142, XrefRangeEnd = 1103151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextureHandle CreateRenderGraphTexture(RenderGraph renderGraph, RenderTextureDescriptor desc, string name, bool clear, Color color, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, bool discardOnLastUse = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &desc;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &clear;
		*(Color**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(FilterMode**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &filterMode;
		*(TextureWrapMode**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &wrapMode;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &discardOnLastUse;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderGraphTexture_Internal_Static_TextureHandle_RenderGraph_RenderTextureDescriptor_String_Boolean_Color_FilterMode_TextureWrapMode_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool ShouldApplyPostProcessing(bool postProcessEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&postProcessEnabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldApplyPostProcessing_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103154, XrefRangeEnd = 1103155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CameraHasPostProcessingWithDepth(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraHasPostProcessingWithDepth_Private_Boolean_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103174, RefRangeEnd = 1103175, XrefRangeStart = 1103155, XrefRangeEnd = 1103174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequiresIntermediateAttachments(UniversalCameraData cameraData, ref RenderPassInputSummary renderPassInputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPassInputs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequiresIntermediateAttachments_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103181, RefRangeEnd = 1103182, XrefRangeStart = 1103175, XrefRangeEnd = 1103181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraHistory(UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraHistory_Private_Void_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103373, RefRangeEnd = 1103374, XrefRangeStart = 1103182, XrefRangeEnd = 1103373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderGraphCameraRenderTargets(RenderGraph renderGraph, bool isCameraTargetOffscreenDepth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCameraTargetOffscreenDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderGraphCameraRenderTargets_Private_Void_RenderGraph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103374, XrefRangeEnd = 1103376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderingLayers(int msaaSamples)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&msaaSamples);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderingLayers_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103376, XrefRangeEnd = 1103379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderGraphLights_Internal_Void_RenderGraph_UniversalRenderingData_UniversalCameraData_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103420, RefRangeEnd = 1103421, XrefRangeStart = 1103379, XrefRangeEnd = 1103420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderRawColorDepthHistory(RenderGraph renderGraph, UniversalCameraData cameraData, UniversalResourceData resourceData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderRawColorDepthHistory_Private_Void_RenderGraph_UniversalCameraData_UniversalResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103421, XrefRangeEnd = 1103426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnBeginRenderGraphFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginRenderGraphFrame_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103426, XrefRangeEnd = 1103466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRecordRenderGraph_Internal_Virtual_Void_RenderGraph_ScriptableRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103466, XrefRangeEnd = 1103471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnEndRenderGraphFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndRenderGraphFrame_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103471, XrefRangeEnd = 1103473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnFinishRenderGraphRendering(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFinishRenderGraphRendering_Internal_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103480, XrefRangeEnd = 1103521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnOffscreenDepthTextureRendering(RenderGraph renderGraph, ScriptableRenderContext context, UniversalResourceData resourceData, UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnOffscreenDepthTextureRendering_Private_Void_RenderGraph_ScriptableRenderContext_UniversalResourceData_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103551, RefRangeEnd = 1103552, XrefRangeStart = 1103521, XrefRangeEnd = 1103551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeforeRendering(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeRendering_Private_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1103575, RefRangeEnd = 1103577, XrefRangeStart = 1103552, XrefRangeEnd = 1103575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceOccluders(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle depthTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceOccluders_Private_Void_RenderGraph_UniversalCameraData_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1103591, RefRangeEnd = 1103595, XrefRangeStart = 1103577, XrefRangeEnd = 1103591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InstanceOcclusionTest(RenderGraph renderGraph, UniversalCameraData cameraData, OcclusionTest occlusionTest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(OcclusionTest**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &occlusionTest;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceOcclusionTest_Private_Void_RenderGraph_UniversalCameraData_OcclusionTest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103595, XrefRangeEnd = 1103600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RecordCustomPassesWithDepthCopyAndMotion(RenderGraph renderGraph, UniversalResourceData resourceData, RenderPassEvent earliestDepthReadEvent, RenderPassEvent currentEvent, bool renderMotionVectors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &earliestDepthReadEvent;
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &currentEvent;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMotionVectors;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RecordCustomPassesWithDepthCopyAndMotion_Private_Void_RenderGraph_UniversalResourceData_RenderPassEvent_RenderPassEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool AllowPartialDepthNormalsPrepass(bool isDeferred, RenderPassEvent requiresDepthNormalEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isDeferred);
		*(RenderPassEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresDepthNormalEvent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllowPartialDepthNormalsPrepass_Private_Boolean_Boolean_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe DepthCopySchedule CalculateDepthCopySchedule(RenderPassEvent earliestDepthReadEvent, bool hasFullPrepass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&earliestDepthReadEvent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFullPrepass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateDepthCopySchedule_Private_DepthCopySchedule_RenderPassEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DepthCopySchedule*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103613, RefRangeEnd = 1103614, XrefRangeStart = 1103600, XrefRangeEnd = 1103613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureCopySchedules CalculateTextureCopySchedules(UniversalCameraData cameraData, RenderPassInputSummary renderPassInputs, bool isDeferred, bool requiresDepthPrepass, bool hasFullPrepass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(RenderPassInputSummary**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderPassInputs;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDeferred;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresDepthPrepass;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasFullPrepass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTextureCopySchedules_Private_TextureCopySchedules_UniversalCameraData_RenderPassInputSummary_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureCopySchedules*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1103619, RefRangeEnd = 1103627, XrefRangeStart = 1103614, XrefRangeEnd = 1103619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyDepthToDepthTexture(RenderGraph renderGraph, UniversalResourceData resourceData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDepthToDepthTexture_Private_Void_RenderGraph_UniversalResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1103631, RefRangeEnd = 1103638, XrefRangeStart = 1103627, XrefRangeEnd = 1103631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderMotionVectors(RenderGraph renderGraph, UniversalResourceData resourceData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMotionVectors_Private_Void_RenderGraph_UniversalResourceData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103638, XrefRangeEnd = 1103640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExecuteScheduledDepthCopyWithMotion(RenderGraph renderGraph, UniversalResourceData resourceData, bool renderMotionVectors)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMotionVectors;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteScheduledDepthCopyWithMotion_Private_Void_RenderGraph_UniversalResourceData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103812, RefRangeEnd = 1103813, XrefRangeStart = 1103640, XrefRangeEnd = 1103812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMainRendering(RenderGraph renderGraph, ScriptableRenderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnMainRendering_Private_Void_RenderGraph_ScriptableRenderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103987, RefRangeEnd = 1103988, XrefRangeStart = 1103813, XrefRangeEnd = 1103987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAfterRendering(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterRendering_Private_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1103993, RefRangeEnd = 1103994, XrefRangeStart = 1103988, XrefRangeEnd = 1103993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequireDepthPrepass(UniversalCameraData cameraData, ref RenderPassInputSummary renderPassInputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPassInputs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireDepthPrepass_Private_Boolean_UniversalCameraData_byref_RenderPassInputSummary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103994, XrefRangeEnd = 1104003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool RequireDepthTexture(UniversalCameraData cameraData, bool requiresDepthPrepass, ref RenderPassInputSummary renderPassInputs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiresDepthPrepass;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPassInputs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequireDepthTexture_Private_Boolean_UniversalCameraData_Boolean_byref_RenderPassInputSummary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1104022, RefRangeEnd = 1104024, XrefRangeStart = 1104003, XrefRangeEnd = 1104022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRenderingLayersGlobalTextures(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRenderingLayersGlobalTextures_Internal_Void_RenderGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104048, RefRangeEnd = 1104049, XrefRangeStart = 1104024, XrefRangeEnd = 1104048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateCameraDepthCopyTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor, bool isDepthTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptor;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDepthTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCameraDepthCopyTexture_Private_Void_RenderGraph_RenderTextureDescriptor_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104084, RefRangeEnd = 1104085, XrefRangeStart = 1104049, XrefRangeEnd = 1104084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMotionVectorTextures(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMotionVectorTextures_Private_Void_RenderGraph_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104118, RefRangeEnd = 1104119, XrefRangeStart = 1104085, XrefRangeEnd = 1104118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateCameraNormalsTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateCameraNormalsTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104152, RefRangeEnd = 1104153, XrefRangeStart = 1104119, XrefRangeEnd = 1104152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderingLayersTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderingLayersTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104175, RefRangeEnd = 1104176, XrefRangeStart = 1104153, XrefRangeEnd = 1104175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateAfterPostProcessTexture(RenderGraph renderGraph, RenderTextureDescriptor descriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &descriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAfterPostProcessTexture_Private_Void_RenderGraph_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1104190, RefRangeEnd = 1104191, XrefRangeStart = 1104176, XrefRangeEnd = 1104190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DepthNormalPrepassRender(RenderGraph renderGraph, RenderPassInputSummary renderPassInputs, TextureHandle depthTarget, uint batchLayerMask, bool setGlobalDepth, bool setGlobalTextures)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(RenderPassInputSummary**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderPassInputs;
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthTarget;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &batchLayerMask;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &setGlobalDepth;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &setGlobalTextures;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DepthNormalPrepassRender_Private_Void_RenderGraph_RenderPassInputSummary_TextureHandle_UInt32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Method_Internal_Static_Void_byref_TextureDesc_PDM_0(ref TextureDesc desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Void_byref_TextureDesc_PDM_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UniversalRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
