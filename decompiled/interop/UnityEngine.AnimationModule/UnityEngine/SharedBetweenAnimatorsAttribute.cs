using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public sealed class SharedBetweenAnimatorsAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static SharedBetweenAnimatorsAttribute()
	{
		Il2CppClassPointerStore<SharedBetweenAnimatorsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "SharedBetweenAnimatorsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedBetweenAnimatorsAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedBetweenAnimatorsAttribute>.NativeClassPtr, 100663300);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SharedBetweenAnimatorsAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedBetweenAnimatorsAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SharedBetweenAnimatorsAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
