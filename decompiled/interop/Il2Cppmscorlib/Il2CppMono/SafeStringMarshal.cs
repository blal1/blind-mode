using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppMono;

public sealed class SafeStringMarshal : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_str;

	private static readonly System.IntPtr NativeFieldInfoPtr_marshaled_string;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToUtf8_icall_Private_Static_IntPtr_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe string str
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_str)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe System.IntPtr marshaled_string
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marshaled_string);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_marshaled_string)) = value;
		}
	}

	public unsafe System.IntPtr Value
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 696619, RefRangeEnd = 696626, XrefRangeStart = 696618, XrefRangeEnd = 696619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SafeStringMarshal()
	{
		Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "SafeStringMarshal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr);
		NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, "str");
		NativeFieldInfoPtr_marshaled_string = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, "marshaled_string");
		NativeMethodInfoPtr_StringToUtf8_icall_Private_Static_IntPtr_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_get_Value_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr, 100663413);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696609, XrefRangeEnd = 696610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr StringToUtf8_icall(ref string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToUtf8_icall_Private_Static_IntPtr_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		str = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696610, XrefRangeEnd = 696611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr StringToUtf8(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToUtf8_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696611, XrefRangeEnd = 696612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GFree(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GFree_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 696613, RefRangeEnd = 696618, XrefRangeStart = 696612, XrefRangeEnd = 696613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SafeStringMarshal(string str)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 696627, RefRangeEnd = 696641, XrefRangeStart = 696626, XrefRangeEnd = 696627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SafeStringMarshal(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SafeStringMarshal()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringMarshal>.NativeClassPtr))
	{
	}
}
