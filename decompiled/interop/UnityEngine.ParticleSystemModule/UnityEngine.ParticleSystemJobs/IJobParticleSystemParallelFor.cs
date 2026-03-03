using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.ParticleSystemJobs;

public class IJobParticleSystemParallelFor : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_ParticleSystemJobData_Int32_0;

	static IJobParticleSystemParallelFor()
	{
		Il2CppClassPointerStore<IJobParticleSystemParallelFor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine.ParticleSystemJobs", "IJobParticleSystemParallelFor");
		NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_ParticleSystemJobData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParticleSystemParallelFor>.NativeClassPtr, 100665028);
	}

	[CallerCount(0)]
	public unsafe virtual void Execute(ParticleSystemJobData jobData, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)jobData));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_ParticleSystemJobData_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IJobParticleSystemParallelFor(IntPtr pointer)
		: base(pointer)
	{
	}
}
