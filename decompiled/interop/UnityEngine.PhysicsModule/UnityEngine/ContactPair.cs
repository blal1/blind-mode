using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ContactPair
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColliderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherColliderID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StartPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NbPoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Events;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ImpulseSum;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_collider_Public_get_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_otherCollider_Public_get_Collider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCollisionEnter_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCollisionExit_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCollisionStay_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasRemovedCollider_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractContactsArray_Internal_Int32_Il2CppStructArray_1_ContactPoint_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContactPoint_Public_byref_ContactPairPoint_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetContactPoint_Internal_Internal_ptr_ContactPairPoint_Int32_0;

	[FieldOffset(0)]
	public readonly int m_ColliderID;

	[FieldOffset(4)]
	public readonly int m_OtherColliderID;

	[FieldOffset(8)]
	public readonly System.IntPtr m_StartPtr;

	[FieldOffset(16)]
	public readonly uint m_NbPoints;

	[FieldOffset(20)]
	public readonly CollisionPairFlags m_Flags;

	[FieldOffset(22)]
	public readonly CollisionPairEventFlags m_Events;

	[FieldOffset(24)]
	public readonly Vector3 m_ImpulseSum;

	public const uint c_InvalidFaceIndex = uint.MaxValue;

	public unsafe Collider collider
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259723, RefRangeEnd = 1259724, XrefRangeStart = 1259722, XrefRangeEnd = 1259723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_collider_Public_get_Collider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}
	}

	public unsafe Collider otherCollider
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259725, RefRangeEnd = 1259726, XrefRangeStart = 1259724, XrefRangeEnd = 1259725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_otherCollider_Public_get_Collider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
		}
	}

	public unsafe bool isCollisionEnter
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCollisionEnter_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isCollisionExit
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCollisionExit_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isCollisionStay
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCollisionStay_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasRemovedCollider
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasRemovedCollider_Internal_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int colliderInstanceID => m_ColliderID;

	public int otherColliderInstanceID => m_OtherColliderID;

	public int contactCount => (int)m_NbPoints;

	public Vector3 impulseSum => m_ImpulseSum;

	public int ColliderInstanceID => colliderInstanceID;

	public int OtherColliderInstanceID => otherColliderInstanceID;

	public Collider Collider => collider;

	public Collider OtherCollider => otherCollider;

	public int ContactCount => contactCount;

	public Vector3 ImpulseSum => impulseSum;

	public bool IsCollisionEnter => isCollisionEnter;

	public bool IsCollisionExit => isCollisionExit;

	public bool IsCollisionStay => isCollisionStay;

	static ContactPair()
	{
		Il2CppClassPointerStore<ContactPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ContactPair");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPair>.NativeClassPtr);
		NativeFieldInfoPtr_m_ColliderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_ColliderID");
		NativeFieldInfoPtr_m_OtherColliderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_OtherColliderID");
		NativeFieldInfoPtr_m_StartPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_StartPtr");
		NativeFieldInfoPtr_m_NbPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_NbPoints");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_Flags");
		NativeFieldInfoPtr_m_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_Events");
		NativeFieldInfoPtr_m_ImpulseSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, "m_ImpulseSum");
		NativeMethodInfoPtr_get_collider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_get_otherCollider_Public_get_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_get_isCollisionEnter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_get_isCollisionExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_isCollisionStay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_get_hasRemovedCollider_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_ExtractContactsArray_Internal_Int32_Il2CppStructArray_1_ContactPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_GetContactPoint_Public_byref_ContactPairPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_GetContactPoint_Internal_Internal_ptr_ContactPairPoint_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, 100663409);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259732, RefRangeEnd = 1259733, XrefRangeStart = 1259726, XrefRangeEnd = 1259732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ExtractContactsArray(Il2CppStructArray<ContactPoint> managedContainer, bool flipped)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)managedContainer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flipped;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractContactsArray_Internal_Int32_Il2CppStructArray_1_ContactPoint_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259733, XrefRangeEnd = 1259734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ref ContactPairPoint GetContactPoint(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContactPoint_Public_byref_ContactPairPoint_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(ContactPairPoint*)intPtr2;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1259735, RefRangeEnd = 1259738, XrefRangeStart = 1259734, XrefRangeEnd = 1259735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContactPairPoint* GetContactPoint_Internal(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetContactPoint_Internal_Internal_ptr_ContactPairPoint_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (ContactPairPoint*)result;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPair>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public int ExtractContacts(List<ContactPoint> managedContainer, bool flipped)
	{
		int num = (int)Il2CppSystem.Math.Min(managedContainer.Capacity, m_NbPoints);
		managedContainer.Clear();
		for (int i = 0; i < num; i++)
		{
			ref ContactPairPoint contactPoint = ref GetContactPoint(i);
			ContactPoint contactPoint2 = default(ContactPoint);
			contactPoint2.m_Point = contactPoint.position;
			contactPoint2.m_Impulse = contactPoint.impulse;
			contactPoint2.m_Separation = contactPoint.separation;
			ContactPoint item = contactPoint2;
			if (flipped)
			{
				item.m_Normal = -contactPoint.normal;
				item.m_ThisColliderInstanceID = m_OtherColliderID;
				item.m_OtherColliderInstanceID = m_ColliderID;
			}
			else
			{
				item.m_Normal = contactPoint.normal;
				item.m_ThisColliderInstanceID = m_ColliderID;
				item.m_OtherColliderInstanceID = m_OtherColliderID;
			}
			managedContainer.Add(item);
		}
		return num;
	}

	public unsafe void CopyToNativeArray(NativeArray<ContactPairPoint> buffer)
	{
		//IL_0008: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		int num = Mathf.Min(((NativeArray<ContactPairPoint>)(&buffer)).Length, contactCount);
		for (int i = 0; i < num; i++)
		{
			((NativeArray<ContactPairPoint>)(&buffer))[i] = GetContactPoint(i);
		}
	}

	public unsafe uint GetContactPointFaceIndex(int contactIndex)
	{
		uint internalFaceIndex = GetContactPoint_Internal(contactIndex)->m_InternalFaceIndex0;
		uint internalFaceIndex2 = GetContactPoint_Internal(contactIndex)->m_InternalFaceIndex1;
		if (internalFaceIndex != uint.MaxValue)
		{
			return Physics.TranslateTriangleIndexFromID(m_ColliderID, internalFaceIndex);
		}
		if (internalFaceIndex2 != uint.MaxValue)
		{
			return Physics.TranslateTriangleIndexFromID(m_OtherColliderID, internalFaceIndex2);
		}
		return uint.MaxValue;
	}
}
