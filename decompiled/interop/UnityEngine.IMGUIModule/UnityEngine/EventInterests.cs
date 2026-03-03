using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct EventInterests
{
	private static readonly System.IntPtr NativeFieldInfoPtr__wantsMouseMove_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__wantsMouseEnterLeaveWindow_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__wantsLessLayoutEvents_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wantsMouseMove_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_wantsMouseEnterLeaveWindow_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _wantsMouseMove_k__BackingField;

	[FieldOffset(1)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _wantsMouseEnterLeaveWindow_k__BackingField;

	[FieldOffset(2)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _wantsLessLayoutEvents_k__BackingField;

	public unsafe bool wantsMouseMove
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 720416, RefRangeEnd = 720506, XrefRangeStart = 720416, XrefRangeEnd = 720506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 745346, RefRangeEnd = 745347, XrefRangeStart = 745346, XrefRangeEnd = 745347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wantsMouseMove_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool wantsMouseEnterLeaveWindow
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 968653, RefRangeEnd = 968654, XrefRangeStart = 968653, XrefRangeEnd = 968654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_wantsMouseEnterLeaveWindow_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool wantsLessLayoutEvents
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 766084, RefRangeEnd = 766085, XrefRangeStart = 766084, XrefRangeEnd = 766085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_wantsLessLayoutEvents_k__BackingField = value;
		}
	}

	static EventInterests()
	{
		Il2CppClassPointerStore<EventInterests>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "EventInterests");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventInterests>.NativeClassPtr);
		NativeFieldInfoPtr__wantsMouseMove_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsMouseMove>k__BackingField");
		NativeFieldInfoPtr__wantsMouseEnterLeaveWindow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsMouseEnterLeaveWindow>k__BackingField");
		NativeFieldInfoPtr__wantsLessLayoutEvents_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, "<wantsLessLayoutEvents>k__BackingField");
		NativeMethodInfoPtr_get_wantsMouseMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_set_wantsMouseMove_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_get_wantsMouseEnterLeaveWindow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_set_wantsMouseEnterLeaveWindow_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_get_wantsLessLayoutEvents_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, 100663392);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1244875, RefRangeEnd = 1244876, XrefRangeStart = 1244875, XrefRangeEnd = 1244875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WantsEvent(EventType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WantsEvent_Public_Boolean_EventType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1244877, RefRangeEnd = 1244878, XrefRangeStart = 1244876, XrefRangeEnd = 1244877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WantsLayoutPass(EventType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WantsLayoutPass_Public_Boolean_EventType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventInterests>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
