using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal.Internal;

public static class DeferredConfig : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__IsOpenGL_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsDX10_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpenGL_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpenGL_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDX10_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDX10_Internal_Static_set_Void_Boolean_0;

	public unsafe static bool _IsOpenGL_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__IsOpenGL_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__IsOpenGL_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool _IsDX10_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__IsDX10_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__IsDX10_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool IsOpenGL
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108290, XrefRangeEnd = 1108292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsOpenGL_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108292, XrefRangeEnd = 1108294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsOpenGL_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool IsDX10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108294, XrefRangeEnd = 1108296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDX10_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108296, XrefRangeEnd = 1108298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsDX10_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DeferredConfig()
	{
		Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "DeferredConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr);
		NativeFieldInfoPtr__IsOpenGL_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, "<IsOpenGL>k__BackingField");
		NativeFieldInfoPtr__IsDX10_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, "<IsDX10>k__BackingField");
		NativeMethodInfoPtr_get_IsOpenGL_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666145);
		NativeMethodInfoPtr_set_IsOpenGL_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666146);
		NativeMethodInfoPtr_get_IsDX10_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666147);
		NativeMethodInfoPtr_set_IsDX10_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeferredConfig>.NativeClassPtr, 100666148);
	}

	public DeferredConfig(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
