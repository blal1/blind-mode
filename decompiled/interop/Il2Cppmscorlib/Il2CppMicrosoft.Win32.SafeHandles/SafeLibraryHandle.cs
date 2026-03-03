using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppMicrosoft.Win32.SafeHandles;

public sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

	static SafeLibraryHandle()
	{
		Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeLibraryHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr, 100663830);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 701111, RefRangeEnd = 701117, XrefRangeStart = 701110, XrefRangeEnd = 701111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeLibraryHandle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeLibraryHandle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701117, XrefRangeEnd = 701118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ReleaseHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SafeLibraryHandle(IntPtr pointer)
		: base(pointer)
	{
	}
}
