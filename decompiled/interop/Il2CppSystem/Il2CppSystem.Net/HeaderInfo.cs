using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class HeaderInfo : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsRequestRestricted;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsResponseRestricted;

	private static readonly System.IntPtr NativeFieldInfoPtr_Parser;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeaderName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AllowMultiValues;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0;

	public unsafe bool IsRequestRestricted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsRequestRestricted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsRequestRestricted)) = value;
		}
	}

	public unsafe bool IsResponseRestricted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsResponseRestricted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsResponseRestricted)) = value;
		}
	}

	public unsafe HeaderParser Parser
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parser);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HeaderParser>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Parser)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string HeaderName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeaderName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeaderName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool AllowMultiValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowMultiValues);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AllowMultiValues)) = value;
		}
	}

	static HeaderInfo()
	{
		Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HeaderInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr);
		NativeFieldInfoPtr_IsRequestRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsRequestRestricted");
		NativeFieldInfoPtr_IsResponseRestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "IsResponseRestricted");
		NativeFieldInfoPtr_Parser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "Parser");
		NativeFieldInfoPtr_HeaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "HeaderName");
		NativeFieldInfoPtr_AllowMultiValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, "AllowMultiValues");
		NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr, 100666291);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 888937, XrefRangeEnd = 888940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeaderInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requestRestricted;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &responseRestricted;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &multi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_Boolean_Boolean_HeaderParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HeaderInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
