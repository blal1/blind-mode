using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ContactPoint
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Point;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Impulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ThisColliderInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherColliderInstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Separation;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_point_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

	[FieldOffset(0)]
	public Vector3 m_Point;

	[FieldOffset(12)]
	public Vector3 m_Normal;

	[FieldOffset(24)]
	public Vector3 m_Impulse;

	[FieldOffset(36)]
	public int m_ThisColliderInstanceID;

	[FieldOffset(40)]
	public int m_OtherColliderInstanceID;

	[FieldOffset(44)]
	public float m_Separation;

	public unsafe Vector3 point
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_point_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 normal
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1157010, RefRangeEnd = 1157013, XrefRangeStart = 1157010, XrefRangeEnd = 1157013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public Vector3 impulse => m_Impulse;

	public Collider thisCollider => Physics.GetColliderByInstanceID(m_ThisColliderInstanceID);

	public Collider otherCollider => Physics.GetColliderByInstanceID(m_OtherColliderInstanceID);

	public float separation => m_Separation;

	static ContactPoint()
	{
		Il2CppClassPointerStore<ContactPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr);
		NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Point");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_Impulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Impulse");
		NativeFieldInfoPtr_m_ThisColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_ThisColliderInstanceID");
		NativeFieldInfoPtr_m_OtherColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_OtherColliderInstanceID");
		NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, "m_Separation");
		NativeMethodInfoPtr_get_point_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, 100663298);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
