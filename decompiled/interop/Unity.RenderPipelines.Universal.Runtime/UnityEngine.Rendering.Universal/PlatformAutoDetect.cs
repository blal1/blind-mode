using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class PlatformAutoDetect : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__isXRMobile_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isSwitch_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isSwitch2_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRunningOnPowerVRGPU;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isXRMobile_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isXRMobile_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isShaderAPIMobileDefined_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isShaderAPIMobileDefined_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSwitch_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isSwitch_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isSwitch2_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isSwitch2_Private_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShAutoDetect_Internal_Static_ShEvalMode_ShEvalMode_0;

	public unsafe static bool _isXRMobile_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isXRMobile_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isXRMobile_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool _isShaderAPIMobileDefined_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool _isSwitch_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isSwitch_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isSwitch_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool _isSwitch2_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__isSwitch2_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__isSwitch2_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool isRunningOnPowerVRGPU
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isRunningOnPowerVRGPU, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isRunningOnPowerVRGPU, (void*)(&value));
		}
	}

	public unsafe static bool isXRMobile
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108179, XrefRangeEnd = 1108183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isXRMobile_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108183, XrefRangeEnd = 1108187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isXRMobile_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool isShaderAPIMobileDefined
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108187, XrefRangeEnd = 1108191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isShaderAPIMobileDefined_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108191, XrefRangeEnd = 1108195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isShaderAPIMobileDefined_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool isSwitch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108195, XrefRangeEnd = 1108199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSwitch_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108199, XrefRangeEnd = 1108203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isSwitch_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool isSwitch2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108203, XrefRangeEnd = 1108207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isSwitch2_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108207, XrefRangeEnd = 1108211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isSwitch2_Private_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static PlatformAutoDetect()
	{
		Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PlatformAutoDetect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr);
		NativeFieldInfoPtr__isXRMobile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isXRMobile>k__BackingField");
		NativeFieldInfoPtr__isShaderAPIMobileDefined_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isShaderAPIMobileDefined>k__BackingField");
		NativeFieldInfoPtr__isSwitch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isSwitch>k__BackingField");
		NativeFieldInfoPtr__isSwitch2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "<isSwitch2>k__BackingField");
		NativeFieldInfoPtr_isRunningOnPowerVRGPU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, "isRunningOnPowerVRGPU");
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666117);
		NativeMethodInfoPtr_get_isXRMobile_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666118);
		NativeMethodInfoPtr_set_isXRMobile_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666119);
		NativeMethodInfoPtr_get_isShaderAPIMobileDefined_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666120);
		NativeMethodInfoPtr_set_isShaderAPIMobileDefined_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666121);
		NativeMethodInfoPtr_get_isSwitch_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666122);
		NativeMethodInfoPtr_set_isSwitch_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666123);
		NativeMethodInfoPtr_get_isSwitch2_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666124);
		NativeMethodInfoPtr_set_isSwitch2_Private_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666125);
		NativeMethodInfoPtr_ShAutoDetect_Internal_Static_ShEvalMode_ShEvalMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformAutoDetect>.NativeClassPtr, 100666126);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108178, RefRangeEnd = 1108179, XrefRangeStart = 1108150, XrefRangeEnd = 1108178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1108212, RefRangeEnd = 1108213, XrefRangeStart = 1108211, XrefRangeEnd = 1108212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ShEvalMode ShAutoDetect(ShEvalMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShAutoDetect_Internal_Static_ShEvalMode_ShEvalMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ShEvalMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PlatformAutoDetect(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
