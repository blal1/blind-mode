using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class ControllerColliderHit : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Controller;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Collider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Point;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MoveDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MoveLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Push;

	public unsafe CharacterController m_Controller
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Controller);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Controller)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Collider m_Collider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Collider);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Collider)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Vector3 m_Point
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Point);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Point)) = value;
		}
	}

	public unsafe Vector3 m_Normal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Normal);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Normal)) = value;
		}
	}

	public unsafe Vector3 m_MoveDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveDirection);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveDirection)) = value;
		}
	}

	public unsafe float m_MoveLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveLength)) = value;
		}
	}

	public unsafe int m_Push
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Push);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Push)) = value;
		}
	}

	public CharacterController controller => m_Controller;

	public Collider collider => m_Collider;

	public Rigidbody rigidbody => m_Collider.attachedRigidbody;

	public GameObject gameObject => m_Collider.gameObject;

	public Transform transform => m_Collider.transform;

	public Vector3 point => m_Point;

	public Vector3 normal => m_Normal;

	public Vector3 moveDirection => m_MoveDirection;

	public float moveLength => m_MoveLength;

	public bool push
	{
		get
		{
			return m_Push != 0;
		}
		set
		{
			m_Push = (value ? 1 : 0);
		}
	}

	static ControllerColliderHit()
	{
		Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ControllerColliderHit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr);
		NativeFieldInfoPtr_m_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Controller");
		NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Collider");
		NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Point");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_MoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_MoveDirection");
		NativeFieldInfoPtr_m_MoveLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_MoveLength");
		NativeFieldInfoPtr_m_Push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerColliderHit>.NativeClassPtr, "m_Push");
	}

	public ControllerColliderHit(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
