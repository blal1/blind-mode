using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class DebugHandler : Il2CppSystem.Object
{
	public class DebugFinalValidationPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isFinalPass;

		private static readonly System.IntPtr NativeFieldInfoPtr_resolveFinalTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_isActiveForCamera;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasDebugRenderTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugRenderTargetHandle;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugTexturePropertyId;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugRenderTargetPixelRect;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugRenderTargetSupportsStereo;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugRenderTargetRangeRemap;

		private static readonly System.IntPtr NativeFieldInfoPtr_debugFontTextureHandle;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderingSettings;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool isFinalPass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFinalPass);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFinalPass)) = value;
			}
		}

		public unsafe bool resolveFinalTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveFinalTarget);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resolveFinalTarget)) = value;
			}
		}

		public unsafe bool isActiveForCamera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActiveForCamera);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActiveForCamera)) = value;
			}
		}

		public unsafe bool hasDebugRenderTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDebugRenderTarget);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasDebugRenderTarget)) = value;
			}
		}

		public unsafe TextureHandle debugRenderTargetHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetHandle);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetHandle)) = value;
			}
		}

		public unsafe int debugTexturePropertyId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugTexturePropertyId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugTexturePropertyId)) = value;
			}
		}

		public unsafe Vector4 debugRenderTargetPixelRect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetPixelRect);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetPixelRect)) = value;
			}
		}

		public unsafe int debugRenderTargetSupportsStereo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetSupportsStereo);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetSupportsStereo)) = value;
			}
		}

		public unsafe Vector4 debugRenderTargetRangeRemap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetRangeRemap);
				return *(Vector4*)num;
			}
			set
			{
				*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugRenderTargetRangeRemap)) = value;
			}
		}

		public unsafe TextureHandle debugFontTextureHandle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFontTextureHandle);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugFontTextureHandle)) = value;
			}
		}

		public unsafe DebugDisplaySettingsRendering renderingSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DebugFinalValidationPassData()
		{
			Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "DebugFinalValidationPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr);
			NativeFieldInfoPtr_isFinalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "isFinalPass");
			NativeFieldInfoPtr_resolveFinalTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "resolveFinalTarget");
			NativeFieldInfoPtr_isActiveForCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "isActiveForCamera");
			NativeFieldInfoPtr_hasDebugRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "hasDebugRenderTarget");
			NativeFieldInfoPtr_debugRenderTargetHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "debugRenderTargetHandle");
			NativeFieldInfoPtr_debugTexturePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "debugTexturePropertyId");
			NativeFieldInfoPtr_debugRenderTargetPixelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "debugRenderTargetPixelRect");
			NativeFieldInfoPtr_debugRenderTargetSupportsStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "debugRenderTargetSupportsStereo");
			NativeFieldInfoPtr_debugRenderTargetRangeRemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "debugRenderTargetRangeRemap");
			NativeFieldInfoPtr_debugFontTextureHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "debugFontTextureHandle");
			NativeFieldInfoPtr_renderingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, "renderingSettings");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr, 100663890);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugFinalValidationPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugFinalValidationPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DebugFinalValidationPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DebugSetupPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isActiveForCamera;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderingSettings;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightingSettings;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool isActiveForCamera
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActiveForCamera);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActiveForCamera)) = value;
			}
		}

		public unsafe DebugDisplaySettingsMaterial materialSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DebugDisplaySettingsRendering renderingSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe DebugDisplaySettingsLighting lightingSettings
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingSettings);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightingSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static DebugSetupPassData()
		{
			Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "DebugSetupPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr);
			NativeFieldInfoPtr_isActiveForCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr, "isActiveForCamera");
			NativeFieldInfoPtr_materialSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr, "materialSettings");
			NativeFieldInfoPtr_renderingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr, "renderingSettings");
			NativeFieldInfoPtr_lightingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr, "lightingSettings");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr, 100663891);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugSetupPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugSetupPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DebugSetupPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.DebugHandler+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__101_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__106_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateShaderGlobalPropertiesForFinalValidationPass_b__101_0_Internal_Void_DebugFinalValidationPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Setup_b__106_0_Internal_Void_DebugSetupPassData_RasterGraphContext_0;

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

		public unsafe static BaseRenderFunc<DebugFinalValidationPassData, RasterGraphContext> __9__101_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<DebugFinalValidationPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__101_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<DebugSetupPassData, RasterGraphContext> __9__106_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__106_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<DebugSetupPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__106_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__101_0");
			NativeFieldInfoPtr___9__106_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__106_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663893);
			NativeMethodInfoPtr__UpdateShaderGlobalPropertiesForFinalValidationPass_b__101_0_Internal_Void_DebugFinalValidationPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663894);
			NativeMethodInfoPtr__Setup_b__106_0_Internal_Void_DebugSetupPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663895);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079603, XrefRangeEnd = 1079607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateShaderGlobalPropertiesForFinalValidationPass_b__101_0(DebugFinalValidationPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateShaderGlobalPropertiesForFinalValidationPass_b__101_0_Internal_Void_DebugFinalValidationPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Setup_b__106_0(DebugSetupPassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Setup_b__106_0_Internal_Void_DebugSetupPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugCurrentRealTimeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugColorPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugTexturePropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugFontId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugTextureDisplayRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugRenderTargetRangeRemap;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMaterialModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugVertexAttributeModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMaterialValidationModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMipInfoModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMipMapStatusModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMipMapShowStatusCodeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMipMapOpacityId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMipMapRecentlyUpdatedCooldownId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMipMapTerrainTextureModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugSceneOverrideModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugFullScreenModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidationModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugMaxPixelCost;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugLightingModeId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ValidationChannelsId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RangeMinimumId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RangeMaximumId;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DebugSetupSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DebugFinalValidationSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DebugSetupPassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DebugFinalValidationPassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReplacementMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HDRDebugViewMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HDRDebugViewPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugScreenColorHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugScreenDepthHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RuntimeTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasDebugRenderTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugRenderTargetPixelRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugRenderTargetRangeRemap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugRenderTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugFontTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_debugDisplayConstant;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugDisplaySettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsActiveModeUnsupportedForDeferred_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ReplacementMaterial_Internal_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugDisplaySettings_Internal_get_UniversalRenderPipelineDebugDisplaySettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugScreenColorHandle_Internal_get_byref_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugScreenDepthHandle_Internal_get_byref_RTHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrDebugViewPass_Internal_get_HDRDebugViewPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HDRDebugViewIsActive_Internal_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDebugScreenTexture_Internal_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsScreenClearNeeded_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRenderPassSupported_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stpDebugViewIndex_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActiveForCamera_Internal_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureColorDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureDepthDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_GraphicsFormat_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupShaderProperties_Internal_Void_RasterCommandBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDebugRenderTarget_Internal_Void_RTHandle_Rect_Boolean_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetDebugRenderTarget_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDebugFinalValidationPassData_Private_DebugFinalValidationPassData_DebugFinalValidationPassData_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Private_Static_Void_RasterCommandBuffer_DebugFinalValidationPassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_CommandBuffer_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_RenderGraph_UniversalCameraData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitDebugSetupPassData_Private_DebugSetupPassData_DebugSetupPassData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Private_Static_Void_RasterCommandBuffer_DebugSetupPassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Internal_Void_CommandBuffer_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Internal_Void_RenderGraph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_DebugRendererLists_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_DebugRendererLists_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

	public unsafe static int k_DebugColorInvalidModePropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugCurrentRealTimeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugCurrentRealTimeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugCurrentRealTimeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugColorPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugColorPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugColorPropertyId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugTexturePropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugTexturePropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugTexturePropertyId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugFontId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugFontId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugFontId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugTextureNoStereoPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugTextureDisplayRect
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugTextureDisplayRect, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugTextureDisplayRect, (void*)(&value));
		}
	}

	public unsafe static int k_DebugRenderTargetSupportsStereo
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo, (void*)(&value));
		}
	}

	public unsafe static int k_DebugRenderTargetRangeRemap
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugRenderTargetRangeRemap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugRenderTargetRangeRemap, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMaterialModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMaterialModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMaterialModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugVertexAttributeModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugVertexAttributeModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugVertexAttributeModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMaterialValidationModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMaterialValidationModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMaterialValidationModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMipInfoModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMipInfoModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMipInfoModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMipMapStatusModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMipMapStatusModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMipMapStatusModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMipMapShowStatusCodeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMipMapShowStatusCodeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMipMapShowStatusCodeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMipMapOpacityId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMipMapOpacityId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMipMapOpacityId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMipMapRecentlyUpdatedCooldownId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMipMapRecentlyUpdatedCooldownId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMipMapRecentlyUpdatedCooldownId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMipMapTerrainTextureModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMipMapTerrainTextureModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMipMapTerrainTextureModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugSceneOverrideModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugSceneOverrideModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugSceneOverrideModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugFullScreenModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugFullScreenModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugFullScreenModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidationModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidationModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidationModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateBelowMinThresholdColorPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateAboveMaxThresholdColorPropertyId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugMaxPixelCost
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugMaxPixelCost, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugMaxPixelCost, (void*)(&value));
		}
	}

	public unsafe static int k_DebugLightingModeId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugLightingModeId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugLightingModeId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugLightingFeatureFlagsId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateAlbedoMinLuminanceId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateAlbedoMaxLuminanceId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateAlbedoSaturationToleranceId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateAlbedoHueToleranceId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateAlbedoCompareColorId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateMetallicMinValueId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId, (void*)(&value));
		}
	}

	public unsafe static int k_DebugValidateMetallicMaxValueId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId, (void*)(&value));
		}
	}

	public unsafe static int k_ValidationChannelsId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ValidationChannelsId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ValidationChannelsId, (void*)(&value));
		}
	}

	public unsafe static int k_RangeMinimumId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RangeMinimumId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RangeMinimumId, (void*)(&value));
		}
	}

	public unsafe static int k_RangeMaximumId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RangeMaximumId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RangeMaximumId, (void*)(&value));
		}
	}

	public unsafe static ProfilingSampler s_DebugSetupSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DebugSetupSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DebugSetupSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler s_DebugFinalValidationSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DebugFinalValidationSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DebugFinalValidationSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DebugSetupPassData s_DebugSetupPassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_DebugSetupPassData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugSetupPassData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_DebugSetupPassData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DebugFinalValidationPassData s_DebugFinalValidationPassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_DebugFinalValidationPassData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugFinalValidationPassData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_DebugFinalValidationPassData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_ReplacementMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReplacementMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReplacementMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_HDRDebugViewMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDRDebugViewMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDRDebugViewMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HDRDebugViewPass m_HDRDebugViewPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDRDebugViewPass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDRDebugViewPass>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDRDebugViewPass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_DebugScreenColorHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScreenColorHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScreenColorHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_DebugScreenDepthHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScreenDepthHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugScreenDepthHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalRenderPipelineRuntimeTextures m_RuntimeTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RuntimeTextures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineRuntimeTextures>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RuntimeTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_HasDebugRenderTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasDebugRenderTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasDebugRenderTarget)) = value;
		}
	}

	public unsafe bool m_DebugRenderTargetSupportsStereo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo)) = value;
		}
	}

	public unsafe Vector4 m_DebugRenderTargetPixelRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTargetPixelRect);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTargetPixelRect)) = value;
		}
	}

	public unsafe Vector4 m_DebugRenderTargetRangeRemap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTargetRangeRemap);
			return *(Vector4*)num;
		}
		set
		{
			*(Vector4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTargetRangeRemap)) = value;
		}
	}

	public unsafe RTHandle m_DebugRenderTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderTarget)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_DebugFontTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFontTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugFontTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_debugDisplayConstant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_debugDisplayConstant);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_debugDisplayConstant)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugDisplaySettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineDebugDisplaySettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugDisplaySettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DebugDisplaySettingsLighting LightingSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr2) : null;
		}
	}

	public unsafe DebugDisplaySettingsMaterial MaterialSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr2) : null;
		}
	}

	public unsafe DebugDisplaySettingsRendering RenderingSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr2) : null;
		}
	}

	public unsafe virtual bool AreAnySettingsActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079607, XrefRangeEnd = 1079608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual bool IsPostProcessingAllowed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079608, XrefRangeEnd = 1079609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual bool IsLightingActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079609, XrefRangeEnd = 1079610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsActiveModeUnsupportedForDeferred
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079610, RefRangeEnd = 1079611, XrefRangeStart = 1079610, XrefRangeEnd = 1079610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsActiveModeUnsupportedForDeferred_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Material ReplacementMaterial
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReplacementMaterial_Internal_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
	}

	public unsafe UniversalRenderPipelineDebugDisplaySettings DebugDisplaySettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugDisplaySettings_Internal_get_UniversalRenderPipelineDebugDisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderPipelineDebugDisplaySettings>(intPtr2) : null;
		}
	}

	public unsafe ref RTHandle DebugScreenColorHandle
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1008112, RefRangeEnd = 1008120, XrefRangeStart = 1008112, XrefRangeEnd = 1008120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugScreenColorHandle_Internal_get_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(RTHandle*)intPtr2;
		}
	}

	public unsafe ref RTHandle DebugScreenDepthHandle
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 962396, RefRangeEnd = 962420, XrefRangeStart = 962396, XrefRangeEnd = 962420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DebugScreenDepthHandle_Internal_get_byref_RTHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(RTHandle*)intPtr2;
		}
	}

	public unsafe HDRDebugViewPass hdrDebugViewPass
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDebugViewPass_Internal_get_HDRDebugViewPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDRDebugViewPass>(intPtr2) : null;
		}
	}

	public unsafe bool IsScreenClearNeeded
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1079627, RefRangeEnd = 1079631, XrefRangeStart = 1079627, XrefRangeEnd = 1079627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsScreenClearNeeded_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsRenderPassSupported
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRenderPassSupported_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int stpDebugViewIndex
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079631, RefRangeEnd = 1079632, XrefRangeStart = 1079631, XrefRangeEnd = 1079631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stpDebugViewIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DebugHandler()
	{
		Il2CppClassPointerStore<DebugHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr);
		NativeFieldInfoPtr_k_DebugColorInvalidModePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugColorInvalidModePropertyId");
		NativeFieldInfoPtr_k_DebugCurrentRealTimeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugCurrentRealTimeId");
		NativeFieldInfoPtr_k_DebugColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugColorPropertyId");
		NativeFieldInfoPtr_k_DebugTexturePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugTexturePropertyId");
		NativeFieldInfoPtr_k_DebugFontId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugFontId");
		NativeFieldInfoPtr_k_DebugTextureNoStereoPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugTextureNoStereoPropertyId");
		NativeFieldInfoPtr_k_DebugTextureDisplayRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugTextureDisplayRect");
		NativeFieldInfoPtr_k_DebugRenderTargetSupportsStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugRenderTargetSupportsStereo");
		NativeFieldInfoPtr_k_DebugRenderTargetRangeRemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugRenderTargetRangeRemap");
		NativeFieldInfoPtr_k_DebugMaterialModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMaterialModeId");
		NativeFieldInfoPtr_k_DebugVertexAttributeModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugVertexAttributeModeId");
		NativeFieldInfoPtr_k_DebugMaterialValidationModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMaterialValidationModeId");
		NativeFieldInfoPtr_k_DebugMipInfoModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipInfoModeId");
		NativeFieldInfoPtr_k_DebugMipMapStatusModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipMapStatusModeId");
		NativeFieldInfoPtr_k_DebugMipMapShowStatusCodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipMapShowStatusCodeId");
		NativeFieldInfoPtr_k_DebugMipMapOpacityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipMapOpacityId");
		NativeFieldInfoPtr_k_DebugMipMapRecentlyUpdatedCooldownId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipMapRecentlyUpdatedCooldownId");
		NativeFieldInfoPtr_k_DebugMipMapTerrainTextureModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMipMapTerrainTextureModeId");
		NativeFieldInfoPtr_k_DebugSceneOverrideModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugSceneOverrideModeId");
		NativeFieldInfoPtr_k_DebugFullScreenModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugFullScreenModeId");
		NativeFieldInfoPtr_k_DebugValidationModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidationModeId");
		NativeFieldInfoPtr_k_DebugValidateBelowMinThresholdColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateBelowMinThresholdColorPropertyId");
		NativeFieldInfoPtr_k_DebugValidateAboveMaxThresholdColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAboveMaxThresholdColorPropertyId");
		NativeFieldInfoPtr_k_DebugMaxPixelCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugMaxPixelCost");
		NativeFieldInfoPtr_k_DebugLightingModeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugLightingModeId");
		NativeFieldInfoPtr_k_DebugLightingFeatureFlagsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugLightingFeatureFlagsId");
		NativeFieldInfoPtr_k_DebugValidateAlbedoMinLuminanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoMinLuminanceId");
		NativeFieldInfoPtr_k_DebugValidateAlbedoMaxLuminanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoMaxLuminanceId");
		NativeFieldInfoPtr_k_DebugValidateAlbedoSaturationToleranceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoSaturationToleranceId");
		NativeFieldInfoPtr_k_DebugValidateAlbedoHueToleranceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoHueToleranceId");
		NativeFieldInfoPtr_k_DebugValidateAlbedoCompareColorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateAlbedoCompareColorId");
		NativeFieldInfoPtr_k_DebugValidateMetallicMinValueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateMetallicMinValueId");
		NativeFieldInfoPtr_k_DebugValidateMetallicMaxValueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_DebugValidateMetallicMaxValueId");
		NativeFieldInfoPtr_k_ValidationChannelsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_ValidationChannelsId");
		NativeFieldInfoPtr_k_RangeMinimumId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_RangeMinimumId");
		NativeFieldInfoPtr_k_RangeMaximumId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "k_RangeMaximumId");
		NativeFieldInfoPtr_s_DebugSetupSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "s_DebugSetupSampler");
		NativeFieldInfoPtr_s_DebugFinalValidationSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "s_DebugFinalValidationSampler");
		NativeFieldInfoPtr_s_DebugSetupPassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "s_DebugSetupPassData");
		NativeFieldInfoPtr_s_DebugFinalValidationPassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "s_DebugFinalValidationPassData");
		NativeFieldInfoPtr_m_ReplacementMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_ReplacementMaterial");
		NativeFieldInfoPtr_m_HDRDebugViewMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_HDRDebugViewMaterial");
		NativeFieldInfoPtr_m_HDRDebugViewPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_HDRDebugViewPass");
		NativeFieldInfoPtr_m_DebugScreenColorHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugScreenColorHandle");
		NativeFieldInfoPtr_m_DebugScreenDepthHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugScreenDepthHandle");
		NativeFieldInfoPtr_m_RuntimeTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_RuntimeTextures");
		NativeFieldInfoPtr_m_HasDebugRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_HasDebugRenderTarget");
		NativeFieldInfoPtr_m_DebugRenderTargetSupportsStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTargetSupportsStereo");
		NativeFieldInfoPtr_m_DebugRenderTargetPixelRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTargetPixelRect");
		NativeFieldInfoPtr_m_DebugRenderTargetRangeRemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTargetRangeRemap");
		NativeFieldInfoPtr_m_DebugRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugRenderTarget");
		NativeFieldInfoPtr_m_DebugFontTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugFontTexture");
		NativeFieldInfoPtr_m_debugDisplayConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_debugDisplayConstant");
		NativeFieldInfoPtr_m_DebugDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, "m_DebugDisplaySettings");
		NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_get_AreAnySettingsActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_get_IsPostProcessingAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_get_IsLightingActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_get_IsActiveModeUnsupportedForDeferred_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663856);
		NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_get_ReplacementMaterial_Internal_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_get_DebugDisplaySettings_Internal_get_UniversalRenderPipelineDebugDisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_get_DebugScreenColorHandle_Internal_get_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_get_DebugScreenDepthHandle_Internal_get_byref_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr_get_hdrDebugViewPass_Internal_get_HDRDebugViewPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr_HDRDebugViewIsActive_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663863);
		NativeMethodInfoPtr_WriteToDebugScreenTexture_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_get_IsScreenClearNeeded_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_get_IsRenderPassSupported_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_get_stpDebugViewIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_IsActiveForCamera_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_ConfigureColorDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_ConfigureDepthDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_GraphicsFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_SetupShaderProperties_Internal_Void_RasterCommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663875);
		NativeMethodInfoPtr_SetDebugRenderTarget_Internal_Void_RTHandle_Rect_Boolean_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_ResetDebugRenderTarget_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_InitDebugFinalValidationPassData_Private_DebugFinalValidationPassData_DebugFinalValidationPassData_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Private_Static_Void_RasterCommandBuffer_DebugFinalValidationPassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_CommandBuffer_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_RenderGraph_UniversalCameraData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_InitDebugSetupPassData_Private_DebugSetupPassData_DebugSetupPassData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_Setup_Private_Static_Void_RasterCommandBuffer_DebugSetupPassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_Setup_Internal_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_Setup_Internal_Void_RenderGraph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_DebugRendererLists_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_DebugRendererLists_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr, 100663888);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079612, RefRangeEnd = 1079614, XrefRangeStart = 1079611, XrefRangeEnd = 1079612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool TryGetScreenClearColor(ref Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetScreenClearColor_Public_Virtual_Final_New_Boolean_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1079614, RefRangeEnd = 1079627, XrefRangeStart = 1079614, XrefRangeEnd = 1079614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HDRDebugViewIsActive(bool resolveFinalTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resolveFinalTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HDRDebugViewIsActive_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1079614, RefRangeEnd = 1079627, XrefRangeStart = 1079614, XrefRangeEnd = 1079627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WriteToDebugScreenTexture(bool resolveFinalTarget)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resolveFinalTarget);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteToDebugScreenTexture_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079632, XrefRangeEnd = 1079704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugHandler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugHandler>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079715, RefRangeEnd = 1079716, XrefRangeStart = 1079704, XrefRangeEnd = 1079715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1079716, RefRangeEnd = 1079729, XrefRangeStart = 1079716, XrefRangeEnd = 1079716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsActiveForCamera(bool isPreviewCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isPreviewCamera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActiveForCamera_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1079729, RefRangeEnd = 1079734, XrefRangeStart = 1079729, XrefRangeEnd = 1079729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref debugFullScreenMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1079734, RefRangeEnd = 1079738, XrefRangeStart = 1079734, XrefRangeEnd = 1079734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetFullscreenDebugMode(out DebugFullScreenMode debugFullScreenMode, out int textureHeightPercent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref debugFullScreenMode);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textureHeightPercent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetFullscreenDebugMode_Internal_Boolean_byref_DebugFullScreenMode_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1079741, RefRangeEnd = 1079745, XrefRangeStart = 1079738, XrefRangeEnd = 1079741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureColorDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref descriptor);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureColorDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079749, RefRangeEnd = 1079751, XrefRangeStart = 1079745, XrefRangeEnd = 1079749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConfigureDepthDescriptorForDebugScreen(ref RenderTextureDescriptor descriptor, GraphicsFormat depthStencilFormat, int cameraWidth, int cameraHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref descriptor);
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthStencilFormat;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraWidth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConfigureDepthDescriptorForDebugScreen_Internal_Static_Void_byref_RenderTextureDescriptor_GraphicsFormat_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079751, XrefRangeEnd = 1079807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupShaderProperties(RasterCommandBuffer cmd, int passIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &passIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupShaderProperties_Internal_Void_RasterCommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1079808, RefRangeEnd = 1079811, XrefRangeStart = 1079807, XrefRangeEnd = 1079808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDebugRenderTarget(RTHandle renderTarget, Rect displayRect, bool supportsStereo, Vector4 dataRangeRemap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderTarget);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &displayRect;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportsStereo;
		*(Vector4**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataRangeRemap;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDebugRenderTarget_Internal_Void_RTHandle_Rect_Boolean_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 180372, RefRangeEnd = 180373, XrefRangeStart = 180372, XrefRangeEnd = 180373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDebugRenderTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetDebugRenderTarget_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1079834, RefRangeEnd = 1079835, XrefRangeStart = 1079811, XrefRangeEnd = 1079834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugFinalValidationPassData InitDebugFinalValidationPassData(DebugFinalValidationPassData passData, UniversalCameraData cameraData, bool isFinalPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFinalPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDebugFinalValidationPassData_Private_DebugFinalValidationPassData_DebugFinalValidationPassData_UniversalCameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugFinalValidationPassData>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1079865, RefRangeEnd = 1079867, XrefRangeStart = 1079835, XrefRangeEnd = 1079865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateShaderGlobalPropertiesForFinalValidationPass(RasterCommandBuffer cmd, DebugFinalValidationPassData data)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Private_Static_Void_RasterCommandBuffer_DebugFinalValidationPassData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079867, XrefRangeEnd = 1079888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateShaderGlobalPropertiesForFinalValidationPass(CommandBuffer cmd, UniversalCameraData cameraData, bool isFinalPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFinalPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_CommandBuffer_UniversalCameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079888, XrefRangeEnd = 1079973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateShaderGlobalPropertiesForFinalValidationPass(RenderGraph renderGraph, UniversalCameraData cameraData, bool isFinalPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFinalPass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateShaderGlobalPropertiesForFinalValidationPass_Internal_Void_RenderGraph_UniversalCameraData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079973, XrefRangeEnd = 1079977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugSetupPassData InitDebugSetupPassData(DebugSetupPassData passData, bool isPreviewCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passData);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPreviewCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitDebugSetupPassData_Private_DebugSetupPassData_DebugSetupPassData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugSetupPassData>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079977, XrefRangeEnd = 1080026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Setup(RasterCommandBuffer cmd, DebugSetupPassData passData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Private_Static_Void_RasterCommandBuffer_DebugSetupPassData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(CommandBuffer cmd, bool isPreviewCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPreviewCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Internal_Void_CommandBuffer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080026, XrefRangeEnd = 1080070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(RenderGraph renderGraph, bool isPreviewCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPreviewCamera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Internal_Void_RenderGraph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080070, XrefRangeEnd = 1080072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Render(RenderGraph renderGraph, UniversalCameraData cameraData, TextureHandle srcColor, TextureHandle overlayTexture, TextureHandle dstColor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(TextureHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcColor;
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &overlayTexture;
		*(TextureHandle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Internal_Void_RenderGraph_UniversalCameraData_TextureHandle_TextureHandle_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1080077, RefRangeEnd = 1080079, XrefRangeStart = 1080072, XrefRangeEnd = 1080077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugRendererLists CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderStateBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_DebugRendererLists_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugRendererLists>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080079, XrefRangeEnd = 1080084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugRendererLists CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderStateBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_DebugRendererLists_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugRendererLists>(intPtr2) : null;
	}

	public DebugHandler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
