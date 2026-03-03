using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ContactPoint2D
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Point;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RelativeVelocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Friction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bounciness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Separation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NormalImpulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TangentImpulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Collider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Rigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OtherRigidbody;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;

	[FieldOffset(0)]
	public Vector2 m_Point;

	[FieldOffset(8)]
	public Vector2 m_Normal;

	[FieldOffset(16)]
	public Vector2 m_RelativeVelocity;

	[FieldOffset(24)]
	public float m_Friction;

	[FieldOffset(28)]
	public float m_Bounciness;

	[FieldOffset(32)]
	public float m_Separation;

	[FieldOffset(36)]
	public float m_NormalImpulse;

	[FieldOffset(40)]
	public float m_TangentImpulse;

	[FieldOffset(44)]
	public int m_Collider;

	[FieldOffset(48)]
	public int m_OtherCollider;

	[FieldOffset(52)]
	public int m_Rigidbody;

	[FieldOffset(56)]
	public int m_OtherRigidbody;

	[FieldOffset(60)]
	public int m_Enabled;

	public Vector2 point => m_Point;

	public Vector2 normal => m_Normal;

	public float separation => m_Separation;

	public float normalImpulse => m_NormalImpulse;

	public float tangentImpulse => m_TangentImpulse;

	public Vector2 relativeVelocity => m_RelativeVelocity;

	public float friction => m_Friction;

	public float bounciness => m_Bounciness;

	public Collider2D collider => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_Collider)).TryCast<Collider2D>();

	public Collider2D otherCollider => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_OtherCollider)).TryCast<Collider2D>();

	public Rigidbody2D rigidbody => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_Rigidbody)).TryCast<Rigidbody2D>();

	public Rigidbody2D otherRigidbody => ((Il2CppObjectBase)Object.FindObjectFromInstanceID(m_OtherRigidbody)).TryCast<Rigidbody2D>();

	public bool enabled => m_Enabled == 1;

	static ContactPoint2D()
	{
		Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "ContactPoint2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr);
		NativeFieldInfoPtr_m_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Point");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_RelativeVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_RelativeVelocity");
		NativeFieldInfoPtr_m_Friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Friction");
		NativeFieldInfoPtr_m_Bounciness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Bounciness");
		NativeFieldInfoPtr_m_Separation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Separation");
		NativeFieldInfoPtr_m_NormalImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_NormalImpulse");
		NativeFieldInfoPtr_m_TangentImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_TangentImpulse");
		NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Collider");
		NativeFieldInfoPtr_m_OtherCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherCollider");
		NativeFieldInfoPtr_m_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Rigidbody");
		NativeFieldInfoPtr_m_OtherRigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_OtherRigidbody");
		NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, "m_Enabled");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ContactPoint2D>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
