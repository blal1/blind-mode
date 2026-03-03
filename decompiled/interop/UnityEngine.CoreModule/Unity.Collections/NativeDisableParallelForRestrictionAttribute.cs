using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.Collections;

public sealed class NativeDisableParallelForRestrictionAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static NativeDisableParallelForRestrictionAttribute()
	{
		Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", "NativeDisableParallelForRestrictionAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr, 100663511);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeDisableParallelForRestrictionAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NativeDisableParallelForRestrictionAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
