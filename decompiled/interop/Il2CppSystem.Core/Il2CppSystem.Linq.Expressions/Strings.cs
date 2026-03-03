using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Linq.Expressions;

public static class Strings : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_String_Object_0;

	static Strings()
	{
		Il2CppClassPointerStore<Strings>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Strings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Strings>.NativeClassPtr);
		NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Strings>.NativeClassPtr, 100663616);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861673, XrefRangeEnd = 861680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ExtensionNodeMustOverrideProperty(Object p0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p0);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_String_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Strings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
