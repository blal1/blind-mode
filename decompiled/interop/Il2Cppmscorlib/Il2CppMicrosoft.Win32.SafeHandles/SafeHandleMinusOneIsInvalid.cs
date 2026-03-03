using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles;

public class SafeHandleMinusOneIsInvalid : SafeHandle
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

	public unsafe override bool IsInvalid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701177, XrefRangeEnd = 701178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SafeHandleMinusOneIsInvalid()
	{
		Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleMinusOneIsInvalid");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr, 100663851);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701176, RefRangeEnd = 701177, XrefRangeStart = 701174, XrefRangeEnd = 701176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeHandleMinusOneIsInvalid(bool ownsHandle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandleMinusOneIsInvalid>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&ownsHandle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SafeHandleMinusOneIsInvalid(IntPtr pointer)
		: base(pointer)
	{
	}
}
