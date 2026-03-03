using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.HID;

public static class HIDSupport : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct HIDPageUsage
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_page;

		private static readonly System.IntPtr NativeFieldInfoPtr_usage;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UsagePage_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GenericDesktop_0;

		[FieldOffset(0)]
		public HID.UsagePage page;

		[FieldOffset(4)]
		public int usage;

		static HIDPageUsage()
		{
			Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HIDSupport>.NativeClassPtr, "HIDPageUsage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr);
			NativeFieldInfoPtr_page = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr, "page");
			NativeFieldInfoPtr_usage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr, "usage");
			NativeMethodInfoPtr__ctor_Public_Void_UsagePage_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr, 100667070);
			NativeMethodInfoPtr__ctor_Public_Void_GenericDesktop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr, 100667071);
		}

		[CallerCount(230)]
		[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HIDPageUsage(HID.UsagePage page, int usage)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&page);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UsagePage_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe HIDPageUsage(HID.GenericDesktop usage)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&usage);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GenericDesktop_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HIDPageUsage>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SupportedHIDUsages;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportedHIDUsages_Public_Static_get_ReadOnlyArray_1_HIDPageUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_supportedHIDUsages_Public_Static_set_Void_ReadOnlyArray_1_HIDPageUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	public unsafe static Il2CppStructArray<HIDPageUsage> s_SupportedHIDUsages
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SupportedHIDUsages, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<HIDPageUsage>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SupportedHIDUsages, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ReadOnlyArray<HIDPageUsage> supportedHIDUsages
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1006166, RefRangeEnd = 1006167, XrefRangeStart = 1006161, XrefRangeEnd = 1006166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportedHIDUsages_Public_Static_get_ReadOnlyArray_1_HIDPageUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<HIDPageUsage>(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1006167, XrefRangeEnd = 1006202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_supportedHIDUsages_Public_Static_set_Void_ReadOnlyArray_1_HIDPageUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HIDSupport()
	{
		Il2CppClassPointerStore<HIDSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.HID", "HIDSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HIDSupport>.NativeClassPtr);
		NativeFieldInfoPtr_s_SupportedHIDUsages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HIDSupport>.NativeClassPtr, "s_SupportedHIDUsages");
		NativeMethodInfoPtr_get_supportedHIDUsages_Public_Static_get_ReadOnlyArray_1_HIDPageUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDSupport>.NativeClassPtr, 100667067);
		NativeMethodInfoPtr_set_supportedHIDUsages_Public_Static_set_Void_ReadOnlyArray_1_HIDPageUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDSupport>.NativeClassPtr, 100667068);
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HIDSupport>.NativeClassPtr, 100667069);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1006224, RefRangeEnd = 1006226, XrefRangeStart = 1006202, XrefRangeEnd = 1006224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HIDSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
