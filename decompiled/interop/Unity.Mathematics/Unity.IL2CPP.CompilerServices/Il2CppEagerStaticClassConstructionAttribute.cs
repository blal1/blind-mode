using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.IL2CPP.CompilerServices;

public class Il2CppEagerStaticClassConstructionAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static Il2CppEagerStaticClassConstructionAttribute()
	{
		Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Mathematics.dll", "Unity.IL2CPP.CompilerServices", "Il2CppEagerStaticClassConstructionAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr, 100663297);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppEagerStaticClassConstructionAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Il2CppEagerStaticClassConstructionAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
