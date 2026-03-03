using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppIonic.Zlib;

public class ZlibException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	static ZlibException()
	{
		Il2CppClassPointerStore<ZlibException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ionic.Zlib", "ZlibException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZlibException>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibException>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZlibException>.NativeClassPtr, 100664307);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41405, XrefRangeEnd = 41409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ZlibException()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZlibException>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 41413, RefRangeEnd = 41418, XrefRangeStart = 41409, XrefRangeEnd = 41413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ZlibException(string s)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZlibException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ZlibException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
