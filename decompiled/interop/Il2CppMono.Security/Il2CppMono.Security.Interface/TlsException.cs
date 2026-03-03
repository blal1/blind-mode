using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface;

public sealed class TlsException : Il2CppSystem.Exception
{
	private static readonly System.IntPtr NativeFieldInfoPtr_alert;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Alert_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0;

	public unsafe Alert alert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alert);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Alert>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alert)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TlsException()
	{
		Il2CppClassPointerStore<TlsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "TlsException");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsException>.NativeClassPtr);
		NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsException>.NativeClassPtr, "alert");
		NativeMethodInfoPtr__ctor_Public_Void_Alert_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663678);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693637, XrefRangeEnd = 693641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TlsException(Alert alert)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)alert);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Alert_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 693646, RefRangeEnd = 693649, XrefRangeStart = 693641, XrefRangeEnd = 693646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TlsException(Alert alert, string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)alert);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 693657, RefRangeEnd = 693659, XrefRangeStart = 693649, XrefRangeEnd = 693657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TlsException(AlertDescription description)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&description);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693659, XrefRangeEnd = 693664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TlsException(AlertDescription description, string message)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&description);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(message);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TlsException(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
