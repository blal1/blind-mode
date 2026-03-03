using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509;

public class X509Stores : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__storePath;

	private static readonly System.IntPtr NativeFieldInfoPtr__newFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr__trusted;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TrustedRoot_Public_get_X509Store_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_X509Store_String_Boolean_0;

	public unsafe string _storePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storePath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__storePath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool _newFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newFormat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__newFormat)) = value;
		}
	}

	public unsafe X509Store _trusted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trusted);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Store>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__trusted)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe X509Store TrustedRoot
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 692636, RefRangeEnd = 692638, XrefRangeStart = 692624, XrefRangeEnd = 692636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TrustedRoot_Public_get_X509Store_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
		}
	}

	static X509Stores()
	{
		Il2CppClassPointerStore<X509Stores>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Stores");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Stores>.NativeClassPtr);
		NativeFieldInfoPtr__storePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, "_storePath");
		NativeFieldInfoPtr__newFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, "_newFormat");
		NativeFieldInfoPtr__trusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, "_trusted");
		NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_get_TrustedRoot_Public_get_X509Store_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_Open_Public_X509Store_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Stores>.NativeClassPtr, 100663527);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 692623, RefRangeEnd = 692624, XrefRangeStart = 692621, XrefRangeEnd = 692623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509Stores(string path, bool newFormat)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Stores>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newFormat;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 692644, RefRangeEnd = 692645, XrefRangeStart = 692638, XrefRangeEnd = 692644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509Store Open(string storeName, bool create)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &create;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_X509Store_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Store>(intPtr2) : null;
	}

	public X509Stores(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
