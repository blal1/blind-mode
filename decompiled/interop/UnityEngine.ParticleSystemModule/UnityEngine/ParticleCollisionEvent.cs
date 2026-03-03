using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ParticleCollisionEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Intersection;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Velocity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColliderInstanceID;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_intersection_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colliderComponent_Public_get_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToColliderComponent_Private_Static_Component_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToColliderComponent_Injected_Private_Static_IntPtr_Int32_0;

	[FieldOffset(0)]
	public Vector3 m_Intersection;

	[FieldOffset(12)]
	public Vector3 m_Normal;

	[FieldOffset(24)]
	public Vector3 m_Velocity;

	[FieldOffset(36)]
	public int m_ColliderInstanceID;

	public unsafe Vector3 intersection
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1154376, RefRangeEnd = 1154380, XrefRangeStart = 1154376, XrefRangeEnd = 1154380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_intersection_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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

	public unsafe Vector3 velocity
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Component colliderComponent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257954, XrefRangeEnd = 1257959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colliderComponent_Public_get_Component_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
		}
	}

	static ParticleCollisionEvent()
	{
		Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleCollisionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr);
		NativeFieldInfoPtr_m_Intersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, "m_Intersection");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_Velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, "m_Velocity");
		NativeFieldInfoPtr_m_ColliderInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, "m_ColliderInstanceID");
		NativeMethodInfoPtr_get_intersection_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, 100664915);
		NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, 100664916);
		NativeMethodInfoPtr_get_velocity_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, 100664917);
		NativeMethodInfoPtr_get_colliderComponent_Public_get_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, 100664918);
		NativeMethodInfoPtr_InstanceIDToColliderComponent_Private_Static_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, 100664919);
		NativeMethodInfoPtr_InstanceIDToColliderComponent_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, 100664920);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257959, XrefRangeEnd = 1257964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Component InstanceIDToColliderComponent(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDToColliderComponent_Private_Static_Component_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1257964, XrefRangeEnd = 1257966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr InstanceIDToColliderComponent_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceIDToColliderComponent_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleCollisionEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
