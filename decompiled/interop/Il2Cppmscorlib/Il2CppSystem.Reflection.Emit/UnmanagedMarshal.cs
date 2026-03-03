using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Reflection.Emit;

[System.Serializable]
public sealed class UnmanagedMarshal : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	static UnmanagedMarshal()
	{
		Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "UnmanagedMarshal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr, 100672560);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnmanagedMarshal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedMarshal>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnmanagedMarshal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
