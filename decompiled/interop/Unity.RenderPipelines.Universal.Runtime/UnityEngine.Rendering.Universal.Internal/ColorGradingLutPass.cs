using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class ColorGradingLutPass : ScriptableRenderPass
{
	public class PassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeFieldInfoPtr_postProcessingData;

		private static readonly System.IntPtr NativeFieldInfoPtr_lutBuilderLdr;

		private static readonly System.IntPtr NativeFieldInfoPtr_lutBuilderHdr;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowColorGradingACESHDR;

		private static readonly System.IntPtr NativeFieldInfoPtr_internalLut;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe UniversalCameraData cameraData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe UniversalPostProcessingData postProcessingData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalPostProcessingData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessingData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material lutBuilderLdr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutBuilderLdr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutBuilderLdr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Material lutBuilderHdr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutBuilderHdr);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lutBuilderHdr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool allowColorGradingACESHDR
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowColorGradingACESHDR);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowColorGradingACESHDR)) = value;
			}
		}

		public unsafe TextureHandle internalLut
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalLut);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalLut)) = value;
			}
		}

		static PassData()
		{
			Il2CppClassPointerStore<PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "PassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassData>.NativeClassPtr);
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "cameraData");
			NativeFieldInfoPtr_postProcessingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "postProcessingData");
			NativeFieldInfoPtr_lutBuilderLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "lutBuilderLdr");
			NativeFieldInfoPtr_lutBuilderHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "lutBuilderHdr");
			NativeFieldInfoPtr_allowColorGradingACESHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "allowColorGradingACESHDR");
			NativeFieldInfoPtr_internalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "internalLut");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100666311);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class ShaderConstants : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__Lut_Params;

		private static readonly System.IntPtr NativeFieldInfoPtr__ColorBalance;

		private static readonly System.IntPtr NativeFieldInfoPtr__ColorFilter;

		private static readonly System.IntPtr NativeFieldInfoPtr__ChannelMixerRed;

		private static readonly System.IntPtr NativeFieldInfoPtr__ChannelMixerGreen;

		private static readonly System.IntPtr NativeFieldInfoPtr__ChannelMixerBlue;

		private static readonly System.IntPtr NativeFieldInfoPtr__HueSatCon;

		private static readonly System.IntPtr NativeFieldInfoPtr__Lift;

		private static readonly System.IntPtr NativeFieldInfoPtr__Gamma;

		private static readonly System.IntPtr NativeFieldInfoPtr__Gain;

		private static readonly System.IntPtr NativeFieldInfoPtr__Shadows;

		private static readonly System.IntPtr NativeFieldInfoPtr__Midtones;

		private static readonly System.IntPtr NativeFieldInfoPtr__Highlights;

		private static readonly System.IntPtr NativeFieldInfoPtr__ShaHiLimits;

		private static readonly System.IntPtr NativeFieldInfoPtr__SplitShadows;

		private static readonly System.IntPtr NativeFieldInfoPtr__SplitHighlights;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveMaster;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveRed;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveGreen;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveBlue;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveHueVsHue;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveHueVsSat;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveLumVsSat;

		private static readonly System.IntPtr NativeFieldInfoPtr__CurveSatVsSat;

		public unsafe static int _Lut_Params
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Lut_Params, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Lut_Params, (void*)(&value));
			}
		}

		public unsafe static int _ColorBalance
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ColorBalance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ColorBalance, (void*)(&value));
			}
		}

		public unsafe static int _ColorFilter
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ColorFilter, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ColorFilter, (void*)(&value));
			}
		}

		public unsafe static int _ChannelMixerRed
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ChannelMixerRed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ChannelMixerRed, (void*)(&value));
			}
		}

		public unsafe static int _ChannelMixerGreen
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ChannelMixerGreen, (void*)(&value));
			}
		}

		public unsafe static int _ChannelMixerBlue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ChannelMixerBlue, (void*)(&value));
			}
		}

		public unsafe static int _HueSatCon
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__HueSatCon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__HueSatCon, (void*)(&value));
			}
		}

		public unsafe static int _Lift
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Lift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Lift, (void*)(&value));
			}
		}

		public unsafe static int _Gamma
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Gamma, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Gamma, (void*)(&value));
			}
		}

		public unsafe static int _Gain
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Gain, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Gain, (void*)(&value));
			}
		}

		public unsafe static int _Shadows
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Shadows, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Shadows, (void*)(&value));
			}
		}

		public unsafe static int _Midtones
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Midtones, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Midtones, (void*)(&value));
			}
		}

		public unsafe static int _Highlights
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Highlights, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Highlights, (void*)(&value));
			}
		}

		public unsafe static int _ShaHiLimits
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ShaHiLimits, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ShaHiLimits, (void*)(&value));
			}
		}

		public unsafe static int _SplitShadows
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SplitShadows, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SplitShadows, (void*)(&value));
			}
		}

		public unsafe static int _SplitHighlights
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SplitHighlights, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SplitHighlights, (void*)(&value));
			}
		}

		public unsafe static int _CurveMaster
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveMaster, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveMaster, (void*)(&value));
			}
		}

		public unsafe static int _CurveRed
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveRed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveRed, (void*)(&value));
			}
		}

		public unsafe static int _CurveGreen
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveGreen, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveGreen, (void*)(&value));
			}
		}

		public unsafe static int _CurveBlue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveBlue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveBlue, (void*)(&value));
			}
		}

		public unsafe static int _CurveHueVsHue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveHueVsHue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveHueVsHue, (void*)(&value));
			}
		}

		public unsafe static int _CurveHueVsSat
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveHueVsSat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveHueVsSat, (void*)(&value));
			}
		}

		public unsafe static int _CurveLumVsSat
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveLumVsSat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveLumVsSat, (void*)(&value));
			}
		}

		public unsafe static int _CurveSatVsSat
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CurveSatVsSat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CurveSatVsSat, (void*)(&value));
			}
		}

		static ShaderConstants()
		{
			Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "ShaderConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr);
			NativeFieldInfoPtr__Lut_Params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Lut_Params");
			NativeFieldInfoPtr__ColorBalance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ColorBalance");
			NativeFieldInfoPtr__ColorFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ColorFilter");
			NativeFieldInfoPtr__ChannelMixerRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ChannelMixerRed");
			NativeFieldInfoPtr__ChannelMixerGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ChannelMixerGreen");
			NativeFieldInfoPtr__ChannelMixerBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ChannelMixerBlue");
			NativeFieldInfoPtr__HueSatCon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_HueSatCon");
			NativeFieldInfoPtr__Lift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Lift");
			NativeFieldInfoPtr__Gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Gamma");
			NativeFieldInfoPtr__Gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Gain");
			NativeFieldInfoPtr__Shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Shadows");
			NativeFieldInfoPtr__Midtones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Midtones");
			NativeFieldInfoPtr__Highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_Highlights");
			NativeFieldInfoPtr__ShaHiLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_ShaHiLimits");
			NativeFieldInfoPtr__SplitShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_SplitShadows");
			NativeFieldInfoPtr__SplitHighlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_SplitHighlights");
			NativeFieldInfoPtr__CurveMaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveMaster");
			NativeFieldInfoPtr__CurveRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveRed");
			NativeFieldInfoPtr__CurveGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveGreen");
			NativeFieldInfoPtr__CurveBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveBlue");
			NativeFieldInfoPtr__CurveHueVsHue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveHueVsHue");
			NativeFieldInfoPtr__CurveHueVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveHueVsSat");
			NativeFieldInfoPtr__CurveLumVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveLumVsSat");
			NativeFieldInfoPtr__CurveSatVsSat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderConstants>.NativeClassPtr, "_CurveSatVsSat");
		}

		public ShaderConstants(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Render_b__14_0_Internal_Void_PassData_RasterGraphContext_0;

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

		public unsafe static BaseRenderFunc<PassData, RasterGraphContext> __9__14_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__14_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__14_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666314);
			NativeMethodInfoPtr__Render_b__14_0_Internal_Void_PassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666315);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110749, XrefRangeEnd = 1110755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Render_b__14_0(PassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Render_b__14_0_Internal_Void_PassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LutBuilderLdr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LutBuilderHdr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HdrLutFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LdrLutFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalLut;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowColorGradingACESHDR;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_PostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_UniversalPostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecutePass_Private_Static_Void_RasterCommandBuffer_PassData_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_ContextContainer_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Material_Shader_0;

	public unsafe Material m_LutBuilderLdr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LutBuilderLdr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LutBuilderLdr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_LutBuilderHdr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LutBuilderHdr);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LutBuilderHdr)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsFormat m_HdrLutFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HdrLutFormat);
			return *(GraphicsFormat*)num;
		}
		set
		{
			*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HdrLutFormat)) = value;
		}
	}

	public unsafe GraphicsFormat m_LdrLutFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LdrLutFormat);
			return *(GraphicsFormat*)num;
		}
		set
		{
			*(GraphicsFormat*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LdrLutFormat)) = value;
		}
	}

	public unsafe PassData m_PassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PassData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_InternalLut
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalLut);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalLut)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_AllowColorGradingACESHDR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowColorGradingACESHDR);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowColorGradingACESHDR)) = value;
		}
	}

	static ColorGradingLutPass()
	{
		Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "ColorGradingLutPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr);
		NativeFieldInfoPtr_m_LutBuilderLdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_LutBuilderLdr");
		NativeFieldInfoPtr_m_LutBuilderHdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_LutBuilderHdr");
		NativeFieldInfoPtr_m_HdrLutFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_HdrLutFormat");
		NativeFieldInfoPtr_m_LdrLutFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_LdrLutFormat");
		NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_PassData");
		NativeFieldInfoPtr_m_InternalLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_InternalLut");
		NativeFieldInfoPtr_m_AllowColorGradingACESHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, "m_AllowColorGradingACESHDR");
		NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666302);
		NativeMethodInfoPtr_Setup_Public_Void_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666303);
		NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_PostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666304);
		NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_UniversalPostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666305);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666306);
		NativeMethodInfoPtr_ExecutePass_Private_Static_Void_RasterCommandBuffer_PassData_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666307);
		NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_ContextContainer_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666308);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666309);
		NativeMethodInfoPtr_Method_Internal_Static_Material_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr, 100666310);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1110790, RefRangeEnd = 1110791, XrefRangeStart = 1110755, XrefRangeEnd = 1110790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ColorGradingLutPass(RenderPassEvent evt, PostProcessData data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorGradingLutPass>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&evt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_PostProcessData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110791, XrefRangeEnd = 1110792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup([In] ref RTHandle internalLut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalLut);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		internalLut = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110792, XrefRangeEnd = 1110794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureDescriptor([In] ref PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)postProcessingData);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filterMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_PostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110794, XrefRangeEnd = 1110795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConfigureDescriptor([In] ref UniversalPostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)postProcessingData);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref descriptor);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filterMode);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDescriptor_Public_Void_byref_UniversalPostProcessingData_byref_RenderTextureDescriptor_byref_FilterMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		postProcessingData = ((intPtr4 == (System.IntPtr)0) ? null : new UniversalPostProcessingData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110795, XrefRangeEnd = 1110821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110959, RefRangeEnd = 1110961, XrefRangeStart = 1110821, XrefRangeEnd = 1110959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecutePass(RasterCommandBuffer cmd, PassData passData, RTHandle internalLutTarget)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalLutTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecutePass_Private_Static_Void_RasterCommandBuffer_PassData_RTHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1111017, RefRangeEnd = 1111018, XrefRangeStart = 1110961, XrefRangeEnd = 1111017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render(RenderGraph renderGraph, ContextContainer frameData, out TextureHandle internalColorLut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref internalColorLut);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_ContextContainer_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1111023, RefRangeEnd = 1111025, XrefRangeStart = 1111018, XrefRangeEnd = 1111023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1111039, RefRangeEnd = 1111041, XrefRangeStart = 1111025, XrefRangeEnd = 1111039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material Method_Internal_Static_Material_Shader_0(Shader shader)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Material_Shader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	public ColorGradingLutPass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
