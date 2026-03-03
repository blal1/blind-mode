using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine;

namespace Il2Cpp;

public static class ParticleSystemExtension : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FixEmissionOnAwakeBug_Public_Static_Void_ParticleSystem_0;

	static ParticleSystemExtension()
	{
		Il2CppClassPointerStore<ParticleSystemExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ParticleSystemExtension");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemExtension>.NativeClassPtr);
		NativeMethodInfoPtr_FixEmissionOnAwakeBug_Public_Static_Void_ParticleSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemExtension>.NativeClassPtr, 100664148);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 39577, RefRangeEnd = 39579, XrefRangeStart = 39568, XrefRangeEnd = 39577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FixEmissionOnAwakeBug(this ParticleSystem ps)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ps);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixEmissionOnAwakeBug_Public_Static_Void_ParticleSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ParticleSystemExtension(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
