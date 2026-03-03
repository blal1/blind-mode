using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

public static class InputTracking : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.XRModule.dll", "", "TrackingStateEventType")]
	public enum TrackingStateEventType
	{
		NodeAdded,
		NodeRemoved,
		TrackingAcquired,
		TrackingLost
	}

	private delegate void RecenterDelegate();

	private delegate bool get_disablePositionalTrackingDelegate();

	private delegate void set_disablePositionalTrackingDelegate(bool value);

	private delegate ulong GetDeviceIdAtXRNodeDelegate(XRNode node);

	private delegate void GetLocalPosition_InjectedDelegate(XRNode node, [Out] System.IntPtr ret);

	private delegate void GetLocalRotation_InjectedDelegate(XRNode node, [Out] System.IntPtr ret);

	private delegate void GetNodeName_InjectedDelegate(ulong uniqueId, [Out] System.IntPtr ret);

	private delegate void GetNodeStates_Internal_InjectedDelegate(System.IntPtr nodeStates);

	private delegate void GetDeviceIdsAtXRNode_Internal_InjectedDelegate(XRNode node, System.IntPtr deviceIds);

	private static readonly System.IntPtr NativeFieldInfoPtr_trackingAcquired;

	private static readonly System.IntPtr NativeFieldInfoPtr_trackingLost;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeAdded;

	private static readonly System.IntPtr NativeFieldInfoPtr_nodeRemoved;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeTrackingEvent_Private_Static_Void_TrackingStateEventType_XRNode_Int64_Boolean_0;

	private static readonly RecenterDelegate RecenterDelegateField;

	private static readonly get_disablePositionalTrackingDelegate get_disablePositionalTrackingDelegateField;

	private static readonly set_disablePositionalTrackingDelegate set_disablePositionalTrackingDelegateField;

	private static readonly GetDeviceIdAtXRNodeDelegate GetDeviceIdAtXRNodeDelegateField;

	private static readonly GetLocalPosition_InjectedDelegate GetLocalPosition_InjectedDelegateField;

	private static readonly GetLocalRotation_InjectedDelegate GetLocalRotation_InjectedDelegateField;

	private static readonly GetNodeName_InjectedDelegate GetNodeName_InjectedDelegateField;

	private static readonly GetNodeStates_Internal_InjectedDelegate GetNodeStates_Internal_InjectedDelegateField;

	private static readonly GetDeviceIdsAtXRNode_Internal_InjectedDelegate GetDeviceIdsAtXRNode_Internal_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<XRNodeState> trackingAcquired
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trackingAcquired, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRNodeState>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trackingAcquired, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<XRNodeState> trackingLost
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_trackingLost, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRNodeState>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_trackingLost, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<XRNodeState> nodeAdded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nodeAdded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRNodeState>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nodeAdded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<XRNodeState> nodeRemoved
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nodeRemoved, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<XRNodeState>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nodeRemoved, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static bool disablePositionalTracking
	{
		get
		{
			return get_disablePositionalTrackingDelegateField();
		}
		set
		{
			set_disablePositionalTrackingDelegateField(value);
		}
	}

	static InputTracking()
	{
		Il2CppClassPointerStore<InputTracking>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputTracking");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputTracking>.NativeClassPtr);
		NativeFieldInfoPtr_trackingAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "trackingAcquired");
		NativeFieldInfoPtr_trackingLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "trackingLost");
		NativeFieldInfoPtr_nodeAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "nodeAdded");
		NativeFieldInfoPtr_nodeRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, "nodeRemoved");
		NativeMethodInfoPtr_InvokeTrackingEvent_Private_Static_Void_TrackingStateEventType_XRNode_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputTracking>.NativeClassPtr, 100663297);
		RecenterDelegateField = IL2CPP.ResolveICall<RecenterDelegate>("UnityEngine.XR.InputTracking::Recenter");
		get_disablePositionalTrackingDelegateField = IL2CPP.ResolveICall<get_disablePositionalTrackingDelegate>("UnityEngine.XR.InputTracking::get_disablePositionalTracking");
		set_disablePositionalTrackingDelegateField = IL2CPP.ResolveICall<set_disablePositionalTrackingDelegate>("UnityEngine.XR.InputTracking::set_disablePositionalTracking");
		GetDeviceIdAtXRNodeDelegateField = IL2CPP.ResolveICall<GetDeviceIdAtXRNodeDelegate>("UnityEngine.XR.InputTracking::GetDeviceIdAtXRNode");
		GetLocalPosition_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalPosition_InjectedDelegate>("UnityEngine.XR.InputTracking::GetLocalPosition_Injected");
		GetLocalRotation_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalRotation_InjectedDelegate>("UnityEngine.XR.InputTracking::GetLocalRotation_Injected");
		GetNodeName_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeName_InjectedDelegate>("UnityEngine.XR.InputTracking::GetNodeName_Injected");
		GetNodeStates_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetNodeStates_Internal_InjectedDelegate>("UnityEngine.XR.InputTracking::GetNodeStates_Internal_Injected");
		GetDeviceIdsAtXRNode_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetDeviceIdsAtXRNode_Internal_InjectedDelegate>("UnityEngine.XR.InputTracking::GetDeviceIdsAtXRNode_Internal_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411009, XrefRangeEnd = 1411017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTrackingEvent(TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&eventType);
		*(XRNode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nodeType;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &uniqueID;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &tracked;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeTrackingEvent_Private_Static_Void_TrackingStateEventType_XRNode_Int64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputTracking(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_trackingAcquired(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_trackingAcquired(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_trackingLost(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_trackingLost(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_nodeAdded(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_nodeAdded(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_nodeRemoved(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_nodeRemoved(Il2CppSystem.Action<XRNodeState> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Vector3 GetLocalPosition(XRNode node)
	{
		GetLocalPosition_Injected(node, out var ret);
		return ret;
	}

	public static Quaternion GetLocalRotation(XRNode node)
	{
		GetLocalRotation_Injected(node, out var ret);
		return ret;
	}

	public static void Recenter()
	{
		RecenterDelegateField();
	}

	public static string GetNodeName(ulong uniqueId)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetNodeName_Injected(uniqueId, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static void GetNodeStates(List<XRNodeState> nodeStates)
	{
		if (nodeStates == null)
		{
			throw new Il2CppSystem.ArgumentNullException("nodeStates");
		}
		nodeStates.Clear();
		GetNodeStates_Internal(nodeStates);
	}

	public static void GetNodeStates_Internal(List<XRNodeState> nodeStates)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static ulong GetDeviceIdAtXRNode(XRNode node)
	{
		return GetDeviceIdAtXRNodeDelegateField(node);
	}

	public static void GetDeviceIdsAtXRNode_Internal(XRNode node, List<ulong> deviceIds)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void GetLocalPosition_Injected(XRNode node, out Vector3 ret)
	{
		GetLocalPosition_InjectedDelegateField(node, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetLocalRotation_Injected(XRNode node, out Quaternion ret)
	{
		GetLocalRotation_InjectedDelegateField(node, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetNodeName_Injected(ulong uniqueId, out ManagedSpanWrapper ret)
	{
		GetNodeName_InjectedDelegateField(uniqueId, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetNodeStates_Internal_Injected(ref BlittableListWrapper nodeStates)
	{
		GetNodeStates_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref nodeStates));
	}

	public unsafe static void GetDeviceIdsAtXRNode_Internal_Injected(XRNode node, ref BlittableListWrapper deviceIds)
	{
		GetDeviceIdsAtXRNode_Internal_InjectedDelegateField(node, (nint)Unsafe.AsPointer(ref deviceIds));
	}
}
