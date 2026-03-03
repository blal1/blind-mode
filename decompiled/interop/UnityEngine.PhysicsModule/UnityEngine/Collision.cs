using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public class Collision : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Header;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pair;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flipped;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyContacts;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Flipped_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_contacts_Public_get_Il2CppStructArray_1_ContactPoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_ContactPairHeader_byref_ContactPair_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reuse_Internal_Void_byref_ContactPairHeader_byref_ContactPair_0;

	public unsafe ContactPairHeader m_Header
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Header);
			return *(ContactPairHeader*)num;
		}
		set
		{
			*(ContactPairHeader*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Header)) = value;
		}
	}

	public unsafe ContactPair m_Pair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pair);
			return *(ContactPair*)num;
		}
		set
		{
			*(ContactPair*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pair)) = value;
		}
	}

	public unsafe bool m_Flipped
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flipped);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flipped)) = value;
		}
	}

	public unsafe Il2CppStructArray<ContactPoint> m_LegacyContacts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegacyContacts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegacyContacts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool Flipped
	{
		get
		{
			return m_Flipped;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Flipped_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<ContactPoint> contacts
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259146, RefRangeEnd = 1259147, XrefRangeStart = 1259141, XrefRangeEnd = 1259146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_contacts_Public_get_Il2CppStructArray_1_ContactPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint>>(intPtr2) : null;
		}
	}

	public Vector3 impulse
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Vector3 relativeVelocity
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Rigidbody rigidbody => ((Il2CppObjectBase)body).TryCast<Rigidbody>();

	public ArticulationBody articulationBody => ((Il2CppObjectBase)body).TryCast<ArticulationBody>();

	public Component body
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Collider collider
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Transform transform => (rigidbody != null) ? rigidbody.transform : collider.transform;

	public GameObject gameObject => (body != null) ? body.gameObject : collider.gameObject;

	public int contactCount
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Vector3 impactForceSum => Vector3.zero;

	public Vector3 frictionForceSum => Vector3.zero;

	public Component other => (body != null) ? body : collider;

	static Collision()
	{
		Il2CppClassPointerStore<Collision>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collision");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision>.NativeClassPtr);
		NativeFieldInfoPtr_m_Header = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Header");
		NativeFieldInfoPtr_m_Pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Pair");
		NativeFieldInfoPtr_m_Flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_Flipped");
		NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision>.NativeClassPtr, "m_LegacyContacts");
		NativeMethodInfoPtr_set_Flipped_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_get_contacts_Public_get_Il2CppStructArray_1_ContactPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr__ctor_Internal_Void_byref_ContactPairHeader_byref_ContactPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_Reuse_Internal_Void_byref_ContactPairHeader_byref_ContactPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collision>.NativeClassPtr, 100663303);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259147, XrefRangeEnd = 1259150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Collision()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collision>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259162, RefRangeEnd = 1259163, XrefRangeStart = 1259150, XrefRangeEnd = 1259162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Collision([In] ref ContactPairHeader header, [In] ref ContactPair pair, bool flipped)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collision>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref header);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pair);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flipped;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_ContactPairHeader_byref_ContactPair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259163, XrefRangeEnd = 1259164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reuse([In] ref ContactPairHeader header, [In] ref ContactPair pair)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref header);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pair);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reuse_Internal_Void_byref_ContactPairHeader_byref_ContactPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Collision(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ContactPoint GetContact(int index)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetContacts(Il2CppStructArray<ContactPoint> contacts)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetContacts(List<ContactPoint> contacts)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public virtual IEnumerator GetEnumerator()
	{
		return ((Il2CppSystem.Array)(object)contacts).GetEnumerator();
	}
}
