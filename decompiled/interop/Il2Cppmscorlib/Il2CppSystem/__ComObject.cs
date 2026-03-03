using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public class __ComObject : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	static __ComObject()
	{
		Il2CppClassPointerStore<__ComObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__ComObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__ComObject>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__ComObject>.NativeClassPtr, 100667419);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765799, XrefRangeEnd = 765810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe __ComObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__ComObject>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public __ComObject(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
