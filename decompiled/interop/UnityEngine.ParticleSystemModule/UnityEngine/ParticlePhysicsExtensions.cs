using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine;

public static class ParticlePhysicsExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionEvents_Public_Static_Int32_ParticleSystem_GameObject_Il2CppStructArray_1_ParticleCollisionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeCollisionEventSize_Public_Static_Int32_ParticleSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionEvents_Public_Static_Int32_ParticleSystem_GameObject_List_1_ParticleCollisionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerParticles_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerParticles_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_byref_ColliderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTriggerParticles_Public_Static_Void_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTriggerParticles_Public_Static_Void_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_0;

	static ParticlePhysicsExtensions()
	{
		Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticlePhysicsExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetCollisionEvents_Public_Static_Int32_ParticleSystem_GameObject_Il2CppStructArray_1_ParticleCollisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664768);
		NativeMethodInfoPtr_GetSafeCollisionEventSize_Public_Static_Int32_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664769);
		NativeMethodInfoPtr_GetCollisionEvents_Public_Static_Int32_ParticleSystem_GameObject_List_1_ParticleCollisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664770);
		NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664771);
		NativeMethodInfoPtr_GetTriggerParticles_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664772);
		NativeMethodInfoPtr_GetTriggerParticles_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_byref_ColliderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664773);
		NativeMethodInfoPtr_SetTriggerParticles_Public_Static_Void_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664774);
		NativeMethodInfoPtr_SetTriggerParticles_Public_Static_Void_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePhysicsExtensions>.NativeClassPtr, 100664775);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256923, XrefRangeEnd = 1256940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCollisionEvents(this ParticleSystem ps, GameObject go, Il2CppStructArray<ParticleCollisionEvent> collisionEvents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collisionEvents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionEvents_Public_Static_Int32_ParticleSystem_GameObject_Il2CppStructArray_1_ParticleCollisionEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256940, XrefRangeEnd = 1256949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSafeCollisionEventSize(this ParticleSystem ps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeCollisionEventSize_Public_Static_Int32_ParticleSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256949, XrefRangeEnd = 1256950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCollisionEvents(this ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collisionEvents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionEvents_Public_Static_Int32_ParticleSystem_GameObject_List_1_ParticleCollisionEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256950, XrefRangeEnd = 1256959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSafeTriggerParticlesSize(this ParticleSystem ps, ParticleSystemTriggerEventType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(ParticleSystemTriggerEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256959, XrefRangeEnd = 1256960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(ParticleSystemTriggerEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerParticles_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256960, XrefRangeEnd = 1256973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles, out ParticleSystem.ColliderData colliderData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(ParticleSystemTriggerEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerParticles_Public_Static_Int32_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_byref_ColliderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		colliderData = ((num3 == 0) ? null : new ParticleSystem.ColliderData(num3));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256973, XrefRangeEnd = 1256995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles, int offset, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(ParticleSystemTriggerEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTriggerParticles_Public_Static_Void_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256995, XrefRangeEnd = 1256997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTriggerParticles(this ParticleSystem ps, ParticleSystemTriggerEventType type, List<ParticleSystem.Particle> particles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(ParticleSystemTriggerEventType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTriggerParticles_Public_Static_Void_ParticleSystem_ParticleSystemTriggerEventType_List_1_Particle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ParticlePhysicsExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
