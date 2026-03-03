using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR;

[StructLayout(LayoutKind.Explicit)]
public struct XRNodeState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableFields;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AngularVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Acceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AngularAcceleration;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Tracked;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UniqueID;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_uniqueID_Public_set_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_nodeType_Public_set_Void_XRNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_tracked_Public_set_Void_Boolean_0;

	[FieldOffset(0)]
	public XRNode m_Type;

	[FieldOffset(4)]
	public AvailableTrackingData m_AvailableFields;

	[FieldOffset(8)]
	public Vector3 m_Position;

	[FieldOffset(20)]
	public Quaternion m_Rotation;

	[FieldOffset(36)]
	public Vector3 m_Velocity;

	[FieldOffset(48)]
	public Vector3 m_AngularVelocity;

	[FieldOffset(60)]
	public Vector3 m_Acceleration;

	[FieldOffset(72)]
	public Vector3 m_AngularAcceleration;

	[FieldOffset(84)]
	public int m_Tracked;

	[FieldOffset(88)]
	public ulong m_UniqueID;

	public unsafe ulong uniqueID
	{
		get
		{
			return m_UniqueID;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uniqueID_Public_set_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe XRNode nodeType
	{
		get
		{
			return m_Type;
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_nodeType_Public_set_Void_XRNode_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool tracked
	{
		get
		{
			return m_Tracked == 1;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_tracked_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Vector3 position
	{
		set
		{
			m_Position = value;
			m_AvailableFields |= AvailableTrackingData.PositionAvailable;
		}
	}

	public Quaternion rotation
	{
		set
		{
			m_Rotation = value;
			m_AvailableFields |= AvailableTrackingData.RotationAvailable;
		}
	}

	public Vector3 velocity
	{
		set
		{
			m_Velocity = value;
			m_AvailableFields |= AvailableTrackingData.VelocityAvailable;
		}
	}

	public Vector3 angularVelocity
	{
		set
		{
			m_AngularVelocity = value;
			m_AvailableFields |= AvailableTrackingData.AngularVelocityAvailable;
		}
	}

	public Vector3 acceleration
	{
		set
		{
			m_Acceleration = value;
			m_AvailableFields |= AvailableTrackingData.AccelerationAvailable;
		}
	}

	public Vector3 angularAcceleration
	{
		set
		{
			m_AngularAcceleration = value;
			m_AvailableFields |= AvailableTrackingData.AngularAccelerationAvailable;
		}
	}

	static XRNodeState()
	{
		Il2CppClassPointerStore<XRNodeState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRNodeState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr);
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Type");
		NativeFieldInfoPtr_m_AvailableFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_AvailableFields");
		NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Position");
		NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Rotation");
		NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Velocity");
		NativeFieldInfoPtr_m_AngularVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_AngularVelocity");
		NativeFieldInfoPtr_m_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Acceleration");
		NativeFieldInfoPtr_m_AngularAcceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_AngularAcceleration");
		NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_Tracked");
		NativeFieldInfoPtr_m_UniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, "m_UniqueID");
		NativeMethodInfoPtr_set_uniqueID_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_set_nodeType_Public_set_Void_XRNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_set_tracked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, 100663300);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRNodeState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public bool TryGetPosition(out Vector3 position)
	{
		return TryGet(m_Position, AvailableTrackingData.PositionAvailable, out position);
	}

	public bool TryGetRotation(out Quaternion rotation)
	{
		return TryGet(m_Rotation, AvailableTrackingData.RotationAvailable, out rotation);
	}

	public bool TryGetVelocity(out Vector3 velocity)
	{
		return TryGet(m_Velocity, AvailableTrackingData.VelocityAvailable, out velocity);
	}

	public bool TryGetAngularVelocity(out Vector3 angularVelocity)
	{
		return TryGet(m_AngularVelocity, AvailableTrackingData.AngularVelocityAvailable, out angularVelocity);
	}

	public bool TryGetAcceleration(out Vector3 acceleration)
	{
		return TryGet(m_Acceleration, AvailableTrackingData.AccelerationAvailable, out acceleration);
	}

	public bool TryGetAngularAcceleration(out Vector3 angularAcceleration)
	{
		return TryGet(m_AngularAcceleration, AvailableTrackingData.AngularAccelerationAvailable, out angularAcceleration);
	}

	public bool TryGet(Vector3 inValue, AvailableTrackingData availabilityFlag, out Vector3 outValue)
	{
		if ((m_AvailableFields & availabilityFlag) > AvailableTrackingData.None)
		{
			outValue = inValue;
			return true;
		}
		outValue = Vector3.zero;
		return false;
	}

	public bool TryGet(Quaternion inValue, AvailableTrackingData availabilityFlag, out Quaternion outValue)
	{
		if ((m_AvailableFields & availabilityFlag) > AvailableTrackingData.None)
		{
			outValue = inValue;
			return true;
		}
		outValue = Quaternion.identity;
		return false;
	}
}
