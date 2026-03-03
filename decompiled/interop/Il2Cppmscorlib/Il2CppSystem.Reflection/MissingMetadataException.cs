using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Reflection;

public sealed class MissingMetadataException : TypeAccessException
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static MissingMetadataException()
	{
		Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "MissingMetadataException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr, 100672055);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 809829, RefRangeEnd = 809830, XrefRangeStart = 809828, XrefRangeEnd = 809829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissingMetadataException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMetadataException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MissingMetadataException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
