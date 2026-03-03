using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RTHandleStaticHelpers
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_RTHandleWrapper;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRTHandleStaticWrapper_Public_Static_Void_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRTHandleUserManagedWrapper_Public_Static_Void_byref_RTHandle_RenderTargetIdentifier_0;

	public unsafe static RTHandle s_RTHandleWrapper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RTHandleWrapper, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RTHandleWrapper, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RTHandleStaticHelpers()
	{
		Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandleStaticHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr);
		NativeFieldInfoPtr_s_RTHandleWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, "s_RTHandleWrapper");
		NativeMethodInfoPtr_SetRTHandleStaticWrapper_Public_Static_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, 100666141);
		NativeMethodInfoPtr_SetRTHandleUserManagedWrapper_Public_Static_Void_byref_RTHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, 100666142);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1048078, RefRangeEnd = 1048084, XrefRangeStart = 1048073, XrefRangeEnd = 1048078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRTHandleStaticWrapper(RenderTargetIdentifier rtId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rtId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRTHandleStaticWrapper_Public_Static_Void_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1048086, RefRangeEnd = 1048090, XrefRangeStart = 1048084, XrefRangeEnd = 1048086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRTHandleUserManagedWrapper(ref RTHandle rtWrapper, RenderTargetIdentifier rtId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rtWrapper);
		*ptr = (nint)(&intPtr);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rtId;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRTHandleUserManagedWrapper_Public_Static_Void_byref_RTHandle_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		rtWrapper = ((intPtr4 == (System.IntPtr)0) ? null : new RTHandle(intPtr4));
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
