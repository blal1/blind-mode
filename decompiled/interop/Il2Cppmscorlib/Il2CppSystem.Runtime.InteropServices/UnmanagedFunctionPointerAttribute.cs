using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class UnmanagedFunctionPointerAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_callingConvention;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0;

	public unsafe CallingConvention m_callingConvention
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_callingConvention);
			return *(CallingConvention*)num;
		}
		set
		{
			*(CallingConvention*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_callingConvention)) = value;
		}
	}

	static UnmanagedFunctionPointerAttribute()
	{
		Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "UnmanagedFunctionPointerAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_callingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, "m_callingConvention");
		NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr, 100671221);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnmanagedFunctionPointerAttribute(CallingConvention callingConvention)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnmanagedFunctionPointerAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&callingConvention);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CallingConvention_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnmanagedFunctionPointerAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
