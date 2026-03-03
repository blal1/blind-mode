using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net;

public class InternalException : SystemException
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	static InternalException()
	{
		Il2CppClassPointerStore<InternalException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "InternalException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalException>.NativeClassPtr, 100666137);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783269, RefRangeEnd = 783270, XrefRangeStart = 783269, XrefRangeEnd = 783270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InternalException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InternalException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
