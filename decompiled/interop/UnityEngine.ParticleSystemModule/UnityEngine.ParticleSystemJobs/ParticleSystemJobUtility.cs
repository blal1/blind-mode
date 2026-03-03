using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.ParticleSystemJobs;

public static class ParticleSystemJobUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_CreateScheduleParams_Internal_Static_JobScheduleParameters_byref_T_ParticleSystem_JobHandle_IntPtr_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateScheduleParams_Internal_Static_JobScheduleParameters_byref_T_ParticleSystem_JobHandle_IntPtr_0, Il2CppClassPointerStore<ParticleSystemJobUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScheduleParams_Internal_Static_JobScheduleParameters_byref_T_ParticleSystem_JobHandle_IntPtr_0;

	static ParticleSystemJobUtility()
	{
		Il2CppClassPointerStore<ParticleSystemJobUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine.ParticleSystemJobs", "ParticleSystemJobUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemJobUtility>.NativeClassPtr);
		NativeMethodInfoPtr_CreateScheduleParams_Internal_Static_JobScheduleParameters_byref_T_ParticleSystem_JobHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobUtility>.NativeClassPtr, 100665036);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258438, XrefRangeEnd = 1258442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, ParticleSystem ps, JobHandle dependsOn, System.IntPtr jobReflectionData) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref jobData));
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		*(JobHandle**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dependsOn;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobReflectionData;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateScheduleParams_Internal_Static_JobScheduleParameters_byref_T_ParticleSystem_JobHandle_IntPtr_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<T, object>(ref jobData) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		return *(JobsUtility.JobScheduleParameters*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	public ParticleSystemJobUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
