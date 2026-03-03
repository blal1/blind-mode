using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class ComDefaultInterfaceAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__val;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	public unsafe Type _val
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__val);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__val)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ComDefaultInterfaceAttribute()
	{
		Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComDefaultInterfaceAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, "_val");
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr, 100671223);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComDefaultInterfaceAttribute(Type defaultInterface)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComDefaultInterfaceAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultInterface);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ComDefaultInterfaceAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
