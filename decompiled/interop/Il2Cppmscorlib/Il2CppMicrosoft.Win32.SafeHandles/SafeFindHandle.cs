using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppMicrosoft.Win32.SafeHandles;

public class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

	static SafeFindHandle()
	{
		Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeFindHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr, 100663845);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 701111, RefRangeEnd = 701117, XrefRangeStart = 701111, XrefRangeEnd = 701117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeFindHandle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeFindHandle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701166, XrefRangeEnd = 701170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ReleaseHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SafeFindHandle(IntPtr pointer)
		: base(pointer)
	{
	}
}
