using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ParticleSystemExtensionsImpl : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeCollisionEventSize_Internal_Static_Int32_ParticleSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionEventsDeprecated_Internal_Static_Int32_ParticleSystem_GameObject_Il2CppStructArray_1_ParticleCollisionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Internal_Static_Int32_ParticleSystem_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionEvents_Internal_Static_Int32_ParticleSystem_GameObject_List_1_ParticleCollisionEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerParticles_Internal_Static_Int32_ParticleSystem_Int32_List_1_Particle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerParticlesWithData_Internal_Static_Int32_ParticleSystem_Int32_List_1_Particle_byref_ColliderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTriggerParticles_Internal_Static_Void_ParticleSystem_Int32_List_1_Particle_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeCollisionEventSize_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionEventsDeprecated_Injected_Private_Static_Int32_IntPtr_IntPtr_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Injected_Private_Static_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionEvents_Injected_Private_Static_Int32_IntPtr_IntPtr_byref_BlittableListWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerParticles_Injected_Private_Static_Int32_IntPtr_Int32_byref_BlittableListWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTriggerParticlesWithData_Injected_Private_Static_Int32_IntPtr_Int32_byref_BlittableListWrapper_byref_ColliderData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTriggerParticles_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableListWrapper_Int32_Int32_0;

	static ParticleSystemExtensionsImpl()
	{
		Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine", "ParticleSystemExtensionsImpl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr);
		NativeMethodInfoPtr_GetSafeCollisionEventSize_Internal_Static_Int32_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664921);
		NativeMethodInfoPtr_GetCollisionEventsDeprecated_Internal_Static_Int32_ParticleSystem_GameObject_Il2CppStructArray_1_ParticleCollisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664922);
		NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Internal_Static_Int32_ParticleSystem_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664923);
		NativeMethodInfoPtr_GetCollisionEvents_Internal_Static_Int32_ParticleSystem_GameObject_List_1_ParticleCollisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664924);
		NativeMethodInfoPtr_GetTriggerParticles_Internal_Static_Int32_ParticleSystem_Int32_List_1_Particle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664925);
		NativeMethodInfoPtr_GetTriggerParticlesWithData_Internal_Static_Int32_ParticleSystem_Int32_List_1_Particle_byref_ColliderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664926);
		NativeMethodInfoPtr_SetTriggerParticles_Internal_Static_Void_ParticleSystem_Int32_List_1_Particle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664927);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664928);
		NativeMethodInfoPtr_GetSafeCollisionEventSize_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664929);
		NativeMethodInfoPtr_GetCollisionEventsDeprecated_Injected_Private_Static_Int32_IntPtr_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664930);
		NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Injected_Private_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664931);
		NativeMethodInfoPtr_GetCollisionEvents_Injected_Private_Static_Int32_IntPtr_IntPtr_byref_BlittableListWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664932);
		NativeMethodInfoPtr_GetTriggerParticles_Injected_Private_Static_Int32_IntPtr_Int32_byref_BlittableListWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664933);
		NativeMethodInfoPtr_GetTriggerParticlesWithData_Injected_Private_Static_Int32_IntPtr_Int32_byref_BlittableListWrapper_byref_ColliderData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664934);
		NativeMethodInfoPtr_SetTriggerParticles_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableListWrapper_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr, 100664935);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSafeCollisionEventSize(ParticleSystem ps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeCollisionEventSize_Internal_Static_Int32_ParticleSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1257982, RefRangeEnd = 1257983, XrefRangeStart = 1257966, XrefRangeEnd = 1257982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCollisionEventsDeprecated(ParticleSystem ps, GameObject go, [Out] Il2CppStructArray<ParticleCollisionEvent> collisionEvents)
	{
		//IL_005d: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionEventsDeprecated_Internal_Static_Int32_ParticleSystem_GameObject_Il2CppStructArray_1_ParticleCollisionEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		Unsafe.Write((void*)(nint)collisionEvents, (num3 == 0) ? null : new Il2CppStructArray<ParticleCollisionEvent>((System.IntPtr)num3));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSafeTriggerParticlesSize(ParticleSystem ps, int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Internal_Static_Int32_ParticleSystem_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258009, RefRangeEnd = 1258010, XrefRangeStart = 1257983, XrefRangeEnd = 1258009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCollisionEvents(ParticleSystem ps, GameObject go, List<ParticleCollisionEvent> collisionEvents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)go);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collisionEvents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionEvents_Internal_Static_Int32_ParticleSystem_GameObject_List_1_ParticleCollisionEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258032, RefRangeEnd = 1258033, XrefRangeStart = 1258010, XrefRangeEnd = 1258032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerParticles_Internal_Static_Int32_ParticleSystem_Int32_List_1_Particle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258055, RefRangeEnd = 1258056, XrefRangeStart = 1258033, XrefRangeEnd = 1258055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriggerParticlesWithData(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles, ref ParticleSystem.ColliderData colliderData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)colliderData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerParticlesWithData_Internal_Static_Int32_ParticleSystem_Int32_List_1_Particle_byref_ColliderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1258078, RefRangeEnd = 1258080, XrefRangeStart = 1258056, XrefRangeEnd = 1258078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTriggerParticles(ParticleSystem ps, int type, List<ParticleSystem.Particle> particles, int offset, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particles);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTriggerParticles_Internal_Static_Void_ParticleSystem_Int32_List_1_Particle_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleSystemExtensionsImpl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystemExtensionsImpl>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258080, XrefRangeEnd = 1258082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSafeCollisionEventSize_Injected(System.IntPtr ps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ps);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeCollisionEventSize_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258082, XrefRangeEnd = 1258084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCollisionEventsDeprecated_Injected(System.IntPtr ps, System.IntPtr go, out BlittableArrayWrapper collisionEvents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ps);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &go;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref collisionEvents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionEventsDeprecated_Injected_Private_Static_Int32_IntPtr_IntPtr_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258084, XrefRangeEnd = 1258086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSafeTriggerParticlesSize_Injected(System.IntPtr ps, int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSafeTriggerParticlesSize_Injected_Private_Static_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258086, XrefRangeEnd = 1258088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCollisionEvents_Injected(System.IntPtr ps, System.IntPtr go, ref BlittableListWrapper collisionEvents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ps);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &go;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref collisionEvents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionEvents_Injected_Private_Static_Int32_IntPtr_IntPtr_byref_BlittableListWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258088, XrefRangeEnd = 1258090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriggerParticles_Injected(System.IntPtr ps, int type, ref BlittableListWrapper particles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref particles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerParticles_Injected_Private_Static_Int32_IntPtr_Int32_byref_BlittableListWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258090, XrefRangeEnd = 1258092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTriggerParticlesWithData_Injected(System.IntPtr ps, int type, ref BlittableListWrapper particles, ref ParticleSystem.ColliderData colliderData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref particles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)colliderData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTriggerParticlesWithData_Injected_Private_Static_Int32_IntPtr_Int32_byref_BlittableListWrapper_byref_ColliderData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258092, XrefRangeEnd = 1258094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetTriggerParticles_Injected(System.IntPtr ps, int type, ref BlittableListWrapper particles, int offset, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&ps);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref particles);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTriggerParticles_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableListWrapper_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ParticleSystemExtensionsImpl(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
