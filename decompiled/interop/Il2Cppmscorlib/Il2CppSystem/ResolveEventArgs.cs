using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public class ResolveEventArgs : EventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Name_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RequestingAssembly_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0;

	public unsafe string _Name_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Name_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Assembly _RequestingAssembly_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequestingAssembly_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequestingAssembly_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ResolveEventArgs()
	{
		Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ResolveEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "<Name>k__BackingField");
		NativeFieldInfoPtr__RequestingAssembly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, "<RequestingAssembly>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100665656);
		NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr, 100665657);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 737487, RefRangeEnd = 737488, XrefRangeStart = 737482, XrefRangeEnd = 737487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResolveEventArgs(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 737494, RefRangeEnd = 737495, XrefRangeStart = 737488, XrefRangeEnd = 737494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ResolveEventArgs(string name, Assembly requestingAssembly)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResolveEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)requestingAssembly);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ResolveEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
