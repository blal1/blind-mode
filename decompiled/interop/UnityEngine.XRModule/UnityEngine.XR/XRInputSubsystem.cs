using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor>
{
	public new static class BindingsMarshaller
	{
	}

	private delegate uint GetIndex_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool TryRecenter_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool TrySetTrackingOriginMode_InjectedDelegate(System.IntPtr _unity_self, TrackingOriginModeFlags origin);

	private delegate TrackingOriginModeFlags GetTrackingOriginMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate TrackingOriginModeFlags GetSupportedTrackingOriginModes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool TryGetBoundaryPoints_AsList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr boundaryPoints);

	private delegate void TryGetDeviceIds_AsList_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr deviceIds);

	private static readonly System.IntPtr NativeFieldInfoPtr_trackingOriginUpdated;

	private static readonly System.IntPtr NativeFieldInfoPtr_boundaryChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly GetIndex_InjectedDelegate GetIndex_InjectedDelegateField;

	private static readonly TryRecenter_InjectedDelegate TryRecenter_InjectedDelegateField;

	private static readonly TrySetTrackingOriginMode_InjectedDelegate TrySetTrackingOriginMode_InjectedDelegateField;

	private static readonly GetTrackingOriginMode_InjectedDelegate GetTrackingOriginMode_InjectedDelegateField;

	private static readonly GetSupportedTrackingOriginModes_InjectedDelegate GetSupportedTrackingOriginModes_InjectedDelegateField;

	private static readonly TryGetBoundaryPoints_AsList_InjectedDelegate TryGetBoundaryPoints_AsList_InjectedDelegateField;

	private static readonly TryGetDeviceIds_AsList_InjectedDelegate TryGetDeviceIds_AsList_InjectedDelegateField;

	public unsafe Il2CppSystem.Action<XRInputSubsystem> trackingOriginUpdated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackingOriginUpdated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRInputSubsystem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trackingOriginUpdated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<XRInputSubsystem> boundaryChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundaryChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRInputSubsystem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundaryChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static XRInputSubsystem()
	{
		Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr);
		NativeFieldInfoPtr_trackingOriginUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, "trackingOriginUpdated");
		NativeFieldInfoPtr_boundaryChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, "boundaryChanged");
		NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr, 100663376);
		GetIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetIndex_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::GetIndex_Injected");
		TryRecenter_InjectedDelegateField = IL2CPP.ResolveICall<TryRecenter_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::TryRecenter_Injected");
		TrySetTrackingOriginMode_InjectedDelegateField = IL2CPP.ResolveICall<TrySetTrackingOriginMode_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::TrySetTrackingOriginMode_Injected");
		GetTrackingOriginMode_InjectedDelegateField = IL2CPP.ResolveICall<GetTrackingOriginMode_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::GetTrackingOriginMode_Injected");
		GetSupportedTrackingOriginModes_InjectedDelegateField = IL2CPP.ResolveICall<GetSupportedTrackingOriginModes_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::GetSupportedTrackingOriginModes_Injected");
		TryGetBoundaryPoints_AsList_InjectedDelegateField = IL2CPP.ResolveICall<TryGetBoundaryPoints_AsList_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::TryGetBoundaryPoints_AsList_Injected");
		TryGetDeviceIds_AsList_InjectedDelegateField = IL2CPP.ResolveICall<TryGetDeviceIds_AsList_InjectedDelegate>("UnityEngine.XR.XRInputSubsystem::TryGetDeviceIds_AsList_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411255, XrefRangeEnd = 1411261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTrackingOriginUpdatedEvent(System.IntPtr internalPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&internalPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeTrackingOriginUpdatedEvent_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411261, XrefRangeEnd = 1411267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBoundaryChangedEvent(System.IntPtr internalPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&internalPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeBoundaryChangedEvent_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411267, XrefRangeEnd = 1411270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRInputSubsystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRInputSubsystem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public uint GetIndex()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetIndex_Injected(intPtr);
	}

	public bool TryRecenter()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryRecenter_Injected(intPtr);
	}

	public bool TryGetInputDevices(List<InputDevice> devices)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool TrySetTrackingOriginMode(TrackingOriginModeFlags origin)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TrySetTrackingOriginMode_Injected(intPtr, origin);
	}

	public TrackingOriginModeFlags GetTrackingOriginMode()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTrackingOriginMode_Injected(intPtr);
	}

	public TrackingOriginModeFlags GetSupportedTrackingOriginModes()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSupportedTrackingOriginModes_Injected(intPtr);
	}

	public bool TryGetBoundaryPoints(List<Vector3> boundaryPoints)
	{
		if (boundaryPoints == null)
		{
			throw new Il2CppSystem.ArgumentNullException("boundaryPoints");
		}
		return TryGetBoundaryPoints_AsList(boundaryPoints);
	}

	public bool TryGetBoundaryPoints_AsList(List<Vector3> boundaryPoints)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_trackingOriginUpdated(Il2CppSystem.Action<XRInputSubsystem> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_trackingOriginUpdated(Il2CppSystem.Action<XRInputSubsystem> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_boundaryChanged(Il2CppSystem.Action<XRInputSubsystem> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_boundaryChanged(Il2CppSystem.Action<XRInputSubsystem> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void TryGetDeviceIds_AsList(List<ulong> deviceIds)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static uint GetIndex_Injected(System.IntPtr _unity_self)
	{
		return GetIndex_InjectedDelegateField(_unity_self);
	}

	public static bool TryRecenter_Injected(System.IntPtr _unity_self)
	{
		return TryRecenter_InjectedDelegateField(_unity_self);
	}

	public static bool TrySetTrackingOriginMode_Injected(System.IntPtr _unity_self, TrackingOriginModeFlags origin)
	{
		return TrySetTrackingOriginMode_InjectedDelegateField(_unity_self, origin);
	}

	public static TrackingOriginModeFlags GetTrackingOriginMode_Injected(System.IntPtr _unity_self)
	{
		return GetTrackingOriginMode_InjectedDelegateField(_unity_self);
	}

	public static TrackingOriginModeFlags GetSupportedTrackingOriginModes_Injected(System.IntPtr _unity_self)
	{
		return GetSupportedTrackingOriginModes_InjectedDelegateField(_unity_self);
	}

	public unsafe static bool TryGetBoundaryPoints_AsList_Injected(System.IntPtr _unity_self, ref BlittableListWrapper boundaryPoints)
	{
		return TryGetBoundaryPoints_AsList_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref boundaryPoints));
	}

	public unsafe static void TryGetDeviceIds_AsList_Injected(System.IntPtr _unity_self, ref BlittableListWrapper deviceIds)
	{
		TryGetDeviceIds_AsList_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref deviceIds));
	}
}
