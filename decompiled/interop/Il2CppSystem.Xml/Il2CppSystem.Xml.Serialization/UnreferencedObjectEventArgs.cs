using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Serialization;

public class UnreferencedObjectEventArgs : EventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr_o;

	private static readonly System.IntPtr NativeFieldInfoPtr_id;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_String_0;

	public unsafe Object o
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_o);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_o)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static UnreferencedObjectEventArgs()
	{
		Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "UnreferencedObjectEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_o = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr, "o");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr, "id");
		NativeMethodInfoPtr__ctor_Public_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr, 100665297);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 914231, RefRangeEnd = 914232, XrefRangeStart = 914225, XrefRangeEnd = 914231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnreferencedObjectEventArgs(Object o, string id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnreferencedObjectEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UnreferencedObjectEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
