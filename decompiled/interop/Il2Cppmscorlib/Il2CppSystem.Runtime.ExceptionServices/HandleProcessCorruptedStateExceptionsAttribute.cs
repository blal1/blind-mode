using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.ExceptionServices;

public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static HandleProcessCorruptedStateExceptionsAttribute()
	{
		Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "HandleProcessCorruptedStateExceptionsAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr, 100671351);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HandleProcessCorruptedStateExceptionsAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandleProcessCorruptedStateExceptionsAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HandleProcessCorruptedStateExceptionsAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
