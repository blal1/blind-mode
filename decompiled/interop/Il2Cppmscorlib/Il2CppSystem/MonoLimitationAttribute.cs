using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public class MonoLimitationAttribute : MonoTODOAttribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static MonoLimitationAttribute()
	{
		Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoLimitationAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr, 100666578);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoLimitationAttribute(string comment)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoLimitationAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(comment);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MonoLimitationAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
