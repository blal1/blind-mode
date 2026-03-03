using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public static class XRGraphicsAutomatedTests : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__enabled_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_running;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_activatedFromCommandLine_Private_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OverrideLayout_Internal_Static_Void_XRLayout_Camera_0;

	public unsafe static bool _enabled_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__enabled_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__enabled_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static bool running
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_running, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_running, (void*)(&value));
		}
	}

	public unsafe static bool activatedFromCommandLine
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_activatedFromCommandLine_Private_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool enabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055344, XrefRangeEnd = 1055348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XRGraphicsAutomatedTests()
	{
		Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "XRGraphicsAutomatedTests");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr);
		NativeFieldInfoPtr__enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, "<enabled>k__BackingField");
		NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, "running");
		NativeMethodInfoPtr_get_activatedFromCommandLine_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, 100667059);
		NativeMethodInfoPtr_OverrideLayout_Internal_Static_Void_XRLayout_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, 100667060);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1055348, XrefRangeEnd = 1055390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OverrideLayout(XRLayout layout, Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layout);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OverrideLayout_Internal_Static_Void_XRLayout_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRGraphicsAutomatedTests(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
