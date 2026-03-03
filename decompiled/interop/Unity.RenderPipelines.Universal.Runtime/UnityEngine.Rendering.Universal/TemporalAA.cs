using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public static class TemporalAA : Il2CppSystem.Object
{
	public static class ShaderConstants : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__TaaAccumulationTex;

		private static readonly System.IntPtr NativeFieldInfoPtr__TaaMotionVectorTex;

		private static readonly System.IntPtr NativeFieldInfoPtr__TaaFilterWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr__TaaFrameInfluence;

		private static readonly System.IntPtr NativeFieldInfoPtr__TaaVarianceClampScale;

		private static readonly System.IntPtr NativeFieldInfoPtr__CameraDepthTexture;

		public unsafe static int _TaaAccumulationTex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TaaAccumulationTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TaaAccumulationTex, (void*)(&value));
			}
		}

		public unsafe static int _TaaMotionVectorTex
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TaaMotionVectorTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TaaMotionVectorTex, (void*)(&value));
			}
		}

		public unsafe static int _TaaFilterWeights
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TaaFilterWeights, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TaaFilterWeights, (void*)(&value));
			}
		}

		public unsafe static int _TaaFrameInfluence
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TaaFrameInfluence, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TaaFrameInfluence, (void*)(&value));
			}
		}

		public unsafe static int _TaaVarianceClampScale
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TaaVarianceClampScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TaaVarianceClampScale, (void*)(&value));
			}
		}

		public unsafe static int _CameraDepthTexture
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CameraDepthTexture, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CameraDepthTexture, (void*)(&value));
			}
		}

		static ShaderConstants()
		{
			Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "ShaderConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr);
			NativeFieldInfoPtr__TaaAccumulationTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TaaAccumulationTex");
			NativeFieldInfoPtr__TaaMotionVectorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TaaMotionVectorTex");
			NativeFieldInfoPtr__TaaFilterWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TaaFilterWeights");
			NativeFieldInfoPtr__TaaFrameInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TaaFrameInfluence");
			NativeFieldInfoPtr__TaaVarianceClampScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_TaaVarianceClampScale");
			NativeFieldInfoPtr__CameraDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CameraDepthTexture");
		}

		public ShaderConstants(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ShaderKeywords : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE;

		public unsafe static string TAA_LOW_PRECISION_SOURCE
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static ShaderKeywords()
		{
			Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "ShaderKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
			NativeFieldInfoPtr_TAA_LOW_PRECISION_SOURCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "TAA_LOW_PRECISION_SOURCE");
		}

		public ShaderKeywords(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct Settings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Quality;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameInfluence;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_JitterScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_MipBias;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_VarianceClampScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ContrastAdaptiveSharpening;

		private static readonly System.IntPtr NativeFieldInfoPtr_resetHistoryFrames;

		private static readonly System.IntPtr NativeFieldInfoPtr_jitterFrameCountOffset;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_quality_Public_get_TemporalAAQuality_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_quality_Public_set_Void_TemporalAAQuality_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_baseBlendFactor_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_baseBlendFactor_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_jitterScale_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_jitterScale_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_mipBias_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_mipBias_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_varianceClampScale_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_varianceClampScale_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_contrastAdaptiveSharpening_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_contrastAdaptiveSharpening_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Settings_0;

		[FieldOffset(0)]
		public TemporalAAQuality m_Quality;

		[FieldOffset(4)]
		public float m_FrameInfluence;

		[FieldOffset(8)]
		public float m_JitterScale;

		[FieldOffset(12)]
		public float m_MipBias;

		[FieldOffset(16)]
		public float m_VarianceClampScale;

		[FieldOffset(20)]
		public float m_ContrastAdaptiveSharpening;

		[FieldOffset(24)]
		[System.NonSerialized]
		public int resetHistoryFrames;

		[FieldOffset(28)]
		[System.NonSerialized]
		public int jitterFrameCountOffset;

		public unsafe TemporalAAQuality quality
		{
			[CallerCount(175)]
			[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_quality_Public_get_TemporalAAQuality_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(TemporalAAQuality*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_quality_Public_set_Void_TemporalAAQuality_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float baseBlendFactor
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_baseBlendFactor_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_baseBlendFactor_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float jitterScale
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_jitterScale_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1100218, RefRangeEnd = 1100219, XrefRangeStart = 1100218, XrefRangeEnd = 1100218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_jitterScale_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float mipBias
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mipBias_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mipBias_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float varianceClampScale
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_varianceClampScale_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_varianceClampScale_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		public unsafe float contrastAdaptiveSharpening
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_contrastAdaptiveSharpening_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
			[CallerCount(0)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_contrastAdaptiveSharpening_Public_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}
		}

		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			NativeFieldInfoPtr_m_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_Quality");
			NativeFieldInfoPtr_m_FrameInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_FrameInfluence");
			NativeFieldInfoPtr_m_JitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_JitterScale");
			NativeFieldInfoPtr_m_MipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_MipBias");
			NativeFieldInfoPtr_m_VarianceClampScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_VarianceClampScale");
			NativeFieldInfoPtr_m_ContrastAdaptiveSharpening = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_ContrastAdaptiveSharpening");
			NativeFieldInfoPtr_resetHistoryFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "resetHistoryFrames");
			NativeFieldInfoPtr_jitterFrameCountOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "jitterFrameCountOffset");
			NativeMethodInfoPtr_get_quality_Public_get_TemporalAAQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665583);
			NativeMethodInfoPtr_set_quality_Public_set_Void_TemporalAAQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665584);
			NativeMethodInfoPtr_get_baseBlendFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665585);
			NativeMethodInfoPtr_set_baseBlendFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665586);
			NativeMethodInfoPtr_get_jitterScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665587);
			NativeMethodInfoPtr_set_jitterScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665588);
			NativeMethodInfoPtr_get_mipBias_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665589);
			NativeMethodInfoPtr_set_mipBias_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665590);
			NativeMethodInfoPtr_get_varianceClampScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665591);
			NativeMethodInfoPtr_set_varianceClampScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665592);
			NativeMethodInfoPtr_get_contrastAdaptiveSharpening_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665593);
			NativeMethodInfoPtr_set_contrastAdaptiveSharpening_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665594);
			NativeMethodInfoPtr_Create_Public_Static_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665595);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1100219, RefRangeEnd = 1100220, XrefRangeStart = 1100219, XrefRangeEnd = 1100219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Settings Create()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Settings*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Settings>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class JitterFunc : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_byref_Vector2_byref_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_byref_Vector2_byref_Boolean_AsyncCallback_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Vector2_byref_Boolean_IAsyncResult_0;

		static JitterFunc()
		{
			Il2CppClassPointerStore<JitterFunc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "JitterFunc");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitterFunc>.NativeClassPtr, 100665596);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_byref_Vector2_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitterFunc>.NativeClassPtr, 100665597);
			NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_byref_Vector2_byref_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitterFunc>.NativeClassPtr, 100665598);
			NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Vector2_byref_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JitterFunc>.NativeClassPtr, 100665599);
		}

		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1100223, RefRangeEnd = 1100246, XrefRangeStart = 1100220, XrefRangeEnd = 1100223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JitterFunc(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JitterFunc>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(int frameIndex, out Vector2 jitter, out bool allowScaling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&frameIndex);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref jitter);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allowScaling);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_byref_Vector2_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100246, XrefRangeEnd = 1100254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppSystem.IAsyncResult BeginInvoke(int frameIndex, out Vector2 jitter, out bool allowScaling, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&frameIndex);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref jitter);
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allowScaling);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_byref_Vector2_byref_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100254, XrefRangeEnd = 1100255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndInvoke(out Vector2 jitter, out bool allowScaling, Il2CppSystem.IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)Unsafe.AsPointer(ref jitter);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allowScaling);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_Vector2_byref_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public JitterFunc(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class TaaPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dstTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcColorTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcDepthTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcMotionVectorTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcTaaAccumTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_passIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_taaFrameInfluence;

		private static readonly System.IntPtr NativeFieldInfoPtr_taaVarianceClampScale;

		private static readonly System.IntPtr NativeFieldInfoPtr_taaFilterWeights;

		private static readonly System.IntPtr NativeFieldInfoPtr_taaLowPrecisionSource;

		private static readonly System.IntPtr NativeFieldInfoPtr_taaAlphaOutput;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe TextureHandle dstTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dstTex);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dstTex)) = value;
			}
		}

		public unsafe TextureHandle srcColorTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcColorTex);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcColorTex)) = value;
			}
		}

		public unsafe TextureHandle srcDepthTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcDepthTex);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcDepthTex)) = value;
			}
		}

		public unsafe TextureHandle srcMotionVectorTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcMotionVectorTex);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcMotionVectorTex)) = value;
			}
		}

		public unsafe TextureHandle srcTaaAccumTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcTaaAccumTex);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcTaaAccumTex)) = value;
			}
		}

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int passIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passIndex)) = value;
			}
		}

		public unsafe float taaFrameInfluence
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaFrameInfluence);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaFrameInfluence)) = value;
			}
		}

		public unsafe float taaVarianceClampScale
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaVarianceClampScale);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaVarianceClampScale)) = value;
			}
		}

		public unsafe Il2CppStructArray<float> taaFilterWeights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaFilterWeights);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaFilterWeights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool taaLowPrecisionSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaLowPrecisionSource);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaLowPrecisionSource)) = value;
			}
		}

		public unsafe bool taaAlphaOutput
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaAlphaOutput);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_taaAlphaOutput)) = value;
			}
		}

		static TaaPassData()
		{
			Il2CppClassPointerStore<TaaPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "TaaPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr);
			NativeFieldInfoPtr_dstTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "dstTex");
			NativeFieldInfoPtr_srcColorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "srcColorTex");
			NativeFieldInfoPtr_srcDepthTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "srcDepthTex");
			NativeFieldInfoPtr_srcMotionVectorTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "srcMotionVectorTex");
			NativeFieldInfoPtr_srcTaaAccumTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "srcTaaAccumTex");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_passIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "passIndex");
			NativeFieldInfoPtr_taaFrameInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "taaFrameInfluence");
			NativeFieldInfoPtr_taaVarianceClampScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "taaVarianceClampScale");
			NativeFieldInfoPtr_taaFilterWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "taaFilterWeights");
			NativeFieldInfoPtr_taaLowPrecisionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "taaLowPrecisionSource");
			NativeFieldInfoPtr_taaAlphaOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, "taaAlphaOutput");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr, 100665600);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaaPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaaPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public TaaPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.TemporalAA+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__17_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Render_b__17_0_Internal_Void_TaaPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Render_b__17_1_Internal_Void_TaaPassData_RasterGraphContext_0;

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

		public unsafe static BaseRenderFunc<TaaPassData, RasterGraphContext> __9__17_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<TaaPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__17_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<TaaPassData, RasterGraphContext> __9__17_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<TaaPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__17_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__17_0");
			NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__17_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665602);
			NativeMethodInfoPtr__Render_b__17_0_Internal_Void_TaaPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665603);
			NativeMethodInfoPtr__Render_b__17_1_Internal_Void_TaaPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665604);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100255, XrefRangeEnd = 1100298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Render_b__17_0(TaaPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Render_b__17_0_Internal_Void_TaaPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100298, XrefRangeEnd = 1100308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Render_b__17_1(TaaPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Render_b__17_1_Internal_Void_TaaPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_JitterFunc;

	private static readonly System.IntPtr NativeFieldInfoPtr_taaFilterOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_taaFilterWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_AccumulationFormatList;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_warnCounter;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTaaFrameIndex_Internal_Static_Int32_byref_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateJitterMatrix_Internal_Static_Matrix4x4_UniversalCameraData_JitterFunc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateJitter_Internal_Static_Void_Int32_byref_Vector2_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFilterWeights_Internal_Static_Il2CppStructArray_1_Single_byref_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TemporalAADescFromCameraDesc_Internal_Static_RenderTextureDescriptor_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAndWarn_Internal_Static_String_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecutePass_Internal_Static_Void_CommandBuffer_Material_byref_CameraData_RTHandle_RTHandle_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_Material_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0;

	public unsafe static JitterFunc s_JitterFunc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_JitterFunc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<JitterFunc>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_JitterFunc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<Vector2> taaFilterOffsets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_taaFilterOffsets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_taaFilterOffsets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<float> taaFilterWeights
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_taaFilterWeights, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_taaFilterWeights, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<GraphicsFormat> AccumulationFormatList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AccumulationFormatList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AccumulationFormatList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static uint s_warnCounter
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_warnCounter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_warnCounter, (void*)(&value));
		}
	}

	static TemporalAA()
	{
		Il2CppClassPointerStore<TemporalAA>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TemporalAA");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr);
		NativeFieldInfoPtr_s_JitterFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "s_JitterFunc");
		NativeFieldInfoPtr_taaFilterOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "taaFilterOffsets");
		NativeFieldInfoPtr_taaFilterWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "taaFilterWeights");
		NativeFieldInfoPtr_AccumulationFormatList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "AccumulationFormatList");
		NativeFieldInfoPtr_s_warnCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, "s_warnCounter");
		NativeMethodInfoPtr_CalculateTaaFrameIndex_Internal_Static_Int32_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665572);
		NativeMethodInfoPtr_CalculateJitterMatrix_Internal_Static_Matrix4x4_UniversalCameraData_JitterFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665573);
		NativeMethodInfoPtr_CalculateJitter_Internal_Static_Void_Int32_byref_Vector2_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665574);
		NativeMethodInfoPtr_CalculateFilterWeights_Internal_Static_Il2CppStructArray_1_Single_byref_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665575);
		NativeMethodInfoPtr_TemporalAADescFromCameraDesc_Internal_Static_RenderTextureDescriptor_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665576);
		NativeMethodInfoPtr_ValidateAndWarn_Internal_Static_String_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665577);
		NativeMethodInfoPtr_ExecutePass_Internal_Static_Void_CommandBuffer_Material_byref_CameraData_RTHandle_RTHandle_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665578);
		NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_Material_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporalAA>.NativeClassPtr, 100665579);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100308, XrefRangeEnd = 1100309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateTaaFrameIndex(ref Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTaaFrameIndex_Internal_Static_Int32_byref_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100317, RefRangeEnd = 1100318, XrefRangeStart = 1100309, XrefRangeEnd = 1100317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 CalculateJitterMatrix(UniversalCameraData cameraData, JitterFunc jitterFunc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)jitterFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateJitterMatrix_Internal_Static_Matrix4x4_UniversalCameraData_JitterFunc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100318, XrefRangeEnd = 1100320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateJitter(int frameIndex, out Vector2 jitter, out bool allowScaling)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&frameIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref jitter);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allowScaling);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateJitter_Internal_Static_Void_Int32_byref_Vector2_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1100338, RefRangeEnd = 1100340, XrefRangeStart = 1100320, XrefRangeEnd = 1100338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> CalculateFilterWeights(ref Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFilterWeights_Internal_Static_Il2CppStructArray_1_Single_byref_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100363, RefRangeEnd = 1100364, XrefRangeStart = 1100340, XrefRangeEnd = 1100363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTextureDescriptor TemporalAADescFromCameraDesc(ref RenderTextureDescriptor cameraDesc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref cameraDesc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TemporalAADescFromCameraDesc_Internal_Static_RenderTextureDescriptor_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1100403, RefRangeEnd = 1100405, XrefRangeStart = 1100364, XrefRangeEnd = 1100403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ValidateAndWarn(UniversalCameraData cameraData, bool isSTPRequested = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSTPRequested;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateAndWarn_Internal_Static_String_UniversalCameraData_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1100474, RefRangeEnd = 1100475, XrefRangeStart = 1100405, XrefRangeEnd = 1100474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taaMaterial);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)motionVectors);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecutePass_Internal_Static_Void_CommandBuffer_Material_byref_CameraData_RTHandle_RTHandle_RenderTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1100577, RefRangeEnd = 1100579, XrefRangeStart = 1100475, XrefRangeEnd = 1100577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Render(RenderGraph renderGraph, Material taaMaterial, UniversalCameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)taaMaterial);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref srcColor);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref srcDepth);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref srcMotionVectors);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dstColor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_Material_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TemporalAA(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
