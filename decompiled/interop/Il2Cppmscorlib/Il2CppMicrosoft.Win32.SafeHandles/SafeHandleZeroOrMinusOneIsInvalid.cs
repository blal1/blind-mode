using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppMicrosoft.Win32.SafeHandles;

public class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0;

	public unsafe override bool IsInvalid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 701173, XrefRangeEnd = 701174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static SafeHandleZeroOrMinusOneIsInvalid()
	{
		Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32.SafeHandles", "SafeHandleZeroOrMinusOneIsInvalid");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_get_IsInvalid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr, 100663849);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701172, RefRangeEnd = 701173, XrefRangeStart = 701171, XrefRangeEnd = 701172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeHandleZeroOrMinusOneIsInvalid>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&ownsHandle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SafeHandleZeroOrMinusOneIsInvalid(IntPtr pointer)
		: base(pointer)
	{
	}
}
