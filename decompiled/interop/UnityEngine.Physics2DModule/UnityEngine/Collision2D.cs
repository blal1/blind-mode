using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public class Collision2D : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Collider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContactCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReusedContacts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LegacyContacts;

	public unsafe int m_Collider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Collider);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Collider)) = value;
		}
	}

	public unsafe int m_OtherCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OtherCollider);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OtherCollider)) = value;
		}
	}

	public unsafe int m_Rigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Rigidbody);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Rigidbody)) = value;
		}
	}

	public unsafe int m_OtherRigidbody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OtherRigidbody);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OtherRigidbody)) = value;
		}
	}

	public unsafe Vector2 m_RelativeVelocity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RelativeVelocity);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RelativeVelocity)) = value;
		}
	}

	public unsafe int m_Enabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Enabled);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Enabled)) = value;
		}
	}

	public unsafe int m_ContactCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContactCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContactCount)) = value;
		}
	}

	public unsafe Il2CppStructArray<ContactPoint2D> m_ReusedContacts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReusedContacts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReusedContacts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ContactPoint2D> m_LegacyContacts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegacyContacts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ContactPoint2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegacyContacts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public Collider2D collider => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_Collider)).TryCast<Collider2D>();

	public Collider2D otherCollider => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_OtherCollider)).TryCast<Collider2D>();

	public Rigidbody2D rigidbody => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_Rigidbody)).TryCast<Rigidbody2D>();

	public Rigidbody2D otherRigidbody => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_OtherRigidbody)).TryCast<Rigidbody2D>();

	public Transform transform => (rigidbody != null) ? rigidbody.transform : collider.transform;

	public GameObject gameObject => (rigidbody != null) ? rigidbody.gameObject : collider.gameObject;

	public Vector2 relativeVelocity => m_RelativeVelocity;

	public bool enabled => m_Enabled == 1;

	public Il2CppStructArray<ContactPoint2D> contacts
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int contactCount => m_ContactCount;

	static Collision2D()
	{
		Il2CppClassPointerStore<Collision2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collision2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collision2D>.NativeClassPtr);
		NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Collider");
		NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherCollider");
		NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Rigidbody");
		NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_OtherRigidbody");
		NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_RelativeVelocity");
		NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_Enabled");
		NativeFieldInfoPtr_m_ContactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ContactCount");
		NativeFieldInfoPtr_m_ReusedContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_ReusedContacts");
		NativeFieldInfoPtr_m_LegacyContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Collision2D>.NativeClassPtr, "m_LegacyContacts");
	}

	public Collision2D(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Il2CppStructArray<ContactPoint2D> GetContacts_Internal()
	{
		return (m_LegacyContacts == null) ? m_ReusedContacts : m_LegacyContacts;
	}

	public ContactPoint2D GetContact(int index)
	{
		if (index < 0 || index >= m_ContactCount)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("Cannot get contact at index {0}. There are {1} contact(s).", (Il2CppSystem.Object)(object)index, (Il2CppSystem.Object)(object)m_ContactCount));
		}
		return ((Il2CppArrayBase<ContactPoint2D>)(object)GetContacts_Internal())[index];
	}

	public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
	{
		if (contacts == null)
		{
			throw new Il2CppSystem.NullReferenceException("Cannot get contacts as the provided array is NULL.");
		}
		int num = Mathf.Min(m_ContactCount, ((Il2CppArrayBase)contacts).Length);
		Il2CppSystem.Array.Copy((Il2CppSystem.Array)(object)GetContacts_Internal(), (Il2CppSystem.Array)(object)contacts, num);
		return num;
	}

	public int GetContacts(List<ContactPoint2D> contacts)
	{
		if (contacts == null)
		{
			throw new Il2CppSystem.NullReferenceException("Cannot get contacts as the provided list is NULL.");
		}
		contacts.Clear();
		Il2CppStructArray<ContactPoint2D> contacts_Internal = GetContacts_Internal();
		for (int i = 0; i < m_ContactCount; i++)
		{
			contacts.Add(((Il2CppArrayBase<ContactPoint2D>)(object)contacts_Internal)[i]);
		}
		return m_ContactCount;
	}
}
