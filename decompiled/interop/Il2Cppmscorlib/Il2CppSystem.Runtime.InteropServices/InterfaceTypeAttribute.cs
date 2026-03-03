using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class InterfaceTypeAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__val;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0;

	public unsafe ComInterfaceType _val
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__val);
			return *(ComInterfaceType*)num;
		}
		set
		{
			*(ComInterfaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__val)) = value;
		}
	}

	static InterfaceTypeAttribute()
	{
		Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "InterfaceTypeAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, "_val");
		NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr, 100671222);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InterfaceTypeAttribute(ComInterfaceType interfaceType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&interfaceType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ComInterfaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InterfaceTypeAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
