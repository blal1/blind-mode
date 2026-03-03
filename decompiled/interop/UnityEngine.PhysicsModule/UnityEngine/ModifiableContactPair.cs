using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ModifiableContactPair
{
	private delegate uint TranslateTriangleIndexDelegate(System.IntPtr shapePtr, uint rawIndex);

	private delegate int ResolveShapeToInstanceIDDelegate(System.IntPtr shapePtr);

	private delegate int ResolveActorToInstanceIDDelegate(System.IntPtr actorPtr);

	private delegate void GetActorLinearVelocity_InjectedDelegate(System.IntPtr actorPtr, [Out] System.IntPtr ret);

	private delegate void GetActorAngularVelocity_InjectedDelegate(System.IntPtr actorPtr, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_actor;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherActor;

	private static readonly System.IntPtr NativeFieldInfoPtr_shape;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherShape;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_otherPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_numContacts;

	private static readonly System.IntPtr NativeFieldInfoPtr_contacts;

	[FieldOffset(0)]
	public System.IntPtr actor;

	[FieldOffset(8)]
	public System.IntPtr otherActor;

	[FieldOffset(16)]
	public System.IntPtr shape;

	[FieldOffset(24)]
	public System.IntPtr otherShape;

	[FieldOffset(32)]
	public Quaternion rotation;

	[FieldOffset(48)]
	public Vector3 position;

	[FieldOffset(60)]
	public Quaternion otherRotation;

	[FieldOffset(76)]
	public Vector3 otherPosition;

	[FieldOffset(88)]
	public int numContacts;

	[FieldOffset(96)]
	public System.IntPtr contacts;

	private static readonly TranslateTriangleIndexDelegate TranslateTriangleIndexDelegateField;

	private static readonly ResolveShapeToInstanceIDDelegate ResolveShapeToInstanceIDDelegateField;

	private static readonly ResolveActorToInstanceIDDelegate ResolveActorToInstanceIDDelegateField;

	private static readonly GetActorLinearVelocity_InjectedDelegate GetActorLinearVelocity_InjectedDelegateField;

	private static readonly GetActorAngularVelocity_InjectedDelegate GetActorAngularVelocity_InjectedDelegateField;

	public int colliderInstanceID => ResolveShapeToInstanceID(shape);

	public int otherColliderInstanceID => ResolveShapeToInstanceID(otherShape);

	public int bodyInstanceID => ResolveActorToInstanceID(actor);

	public int otherBodyInstanceID => ResolveActorToInstanceID(otherActor);

	public Vector3 bodyVelocity => GetActorLinearVelocity(actor);

	public Vector3 bodyAngularVelocity => GetActorAngularVelocity(actor);

	public Vector3 otherBodyVelocity => GetActorLinearVelocity(otherActor);

	public Vector3 otherBodyAngularVelocity => GetActorAngularVelocity(otherActor);

	public int contactCount => numContacts;

	static ModifiableContactPair()
	{
		Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "ModifiableContactPair");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr);
		NativeFieldInfoPtr_actor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "actor");
		NativeFieldInfoPtr_otherActor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherActor");
		NativeFieldInfoPtr_shape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "shape");
		NativeFieldInfoPtr_otherShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherShape");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "rotation");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "position");
		NativeFieldInfoPtr_otherRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherRotation");
		NativeFieldInfoPtr_otherPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "otherPosition");
		NativeFieldInfoPtr_numContacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "numContacts");
		NativeFieldInfoPtr_contacts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, "contacts");
		TranslateTriangleIndexDelegateField = IL2CPP.ResolveICall<TranslateTriangleIndexDelegate>("UnityEngine.ModifiableContactPair::TranslateTriangleIndex");
		ResolveShapeToInstanceIDDelegateField = IL2CPP.ResolveICall<ResolveShapeToInstanceIDDelegate>("UnityEngine.ModifiableContactPair::ResolveShapeToInstanceID");
		ResolveActorToInstanceIDDelegateField = IL2CPP.ResolveICall<ResolveActorToInstanceIDDelegate>("UnityEngine.ModifiableContactPair::ResolveActorToInstanceID");
		GetActorLinearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetActorLinearVelocity_InjectedDelegate>("UnityEngine.ModifiableContactPair::GetActorLinearVelocity_Injected");
		GetActorAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetActorAngularVelocity_InjectedDelegate>("UnityEngine.ModifiableContactPair::GetActorAngularVelocity_Injected");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifiableContactPair>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static uint TranslateTriangleIndex(System.IntPtr shapePtr, uint rawIndex)
	{
		return TranslateTriangleIndexDelegateField(shapePtr, rawIndex);
	}

	public static int ResolveShapeToInstanceID(System.IntPtr shapePtr)
	{
		return ResolveShapeToInstanceIDDelegateField(shapePtr);
	}

	public static int ResolveActorToInstanceID(System.IntPtr actorPtr)
	{
		return ResolveActorToInstanceIDDelegateField(actorPtr);
	}

	public static Vector3 GetActorLinearVelocity(System.IntPtr actorPtr)
	{
		GetActorLinearVelocity_Injected(actorPtr, out var ret);
		return ret;
	}

	public static Vector3 GetActorAngularVelocity(System.IntPtr actorPtr)
	{
		GetActorAngularVelocity_Injected(actorPtr, out var ret);
		return ret;
	}

	public Vector3 GetPoint(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetPoint(int i, Vector3 v)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Vector3 GetNormal(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetNormal(int i, Vector3 normal)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public float GetSeparation(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetSeparation(int i, float separation)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Vector3 GetTargetVelocity(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetTargetVelocity(int i, Vector3 velocity)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public float GetBounciness(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetBounciness(int i, float bounciness)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public float GetStaticFriction(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetStaticFriction(int i, float staticFriction)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public float GetDynamicFriction(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetDynamicFriction(int i, float dynamicFriction)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public float GetMaxImpulse(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void SetMaxImpulse(int i, float value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void IgnoreContact(int i)
	{
		SetMaxImpulse(i, 0f);
	}

	public uint GetFaceIndex(int i)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void GetActorLinearVelocity_Injected(System.IntPtr actorPtr, out Vector3 ret)
	{
		GetActorLinearVelocity_InjectedDelegateField(actorPtr, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetActorAngularVelocity_Injected(System.IntPtr actorPtr, out Vector3 ret)
	{
		GetActorAngularVelocity_InjectedDelegateField(actorPtr, (nint)Unsafe.AsPointer(ref ret));
	}
}
