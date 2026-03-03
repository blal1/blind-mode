using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization;

[System.Serializable]
public class CodePageDataItem : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_dataIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_uiFamilyCodePage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_webName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_sep;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_WebName_Public_get_String_0;

	public unsafe int m_dataIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_dataIndex)) = value;
		}
	}

	public unsafe int m_uiFamilyCodePage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_uiFamilyCodePage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_uiFamilyCodePage)) = value;
		}
	}

	public unsafe string m_webName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_webName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_webName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe uint m_flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_flags);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_flags)) = value;
		}
	}

	public unsafe static Il2CppStructArray<char> sep
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sep, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sep, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string WebName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 820163, RefRangeEnd = 820164, XrefRangeStart = 820149, XrefRangeEnd = 820163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WebName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static CodePageDataItem()
	{
		Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "CodePageDataItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr);
		NativeFieldInfoPtr_m_dataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_dataIndex");
		NativeFieldInfoPtr_m_uiFamilyCodePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_uiFamilyCodePage");
		NativeFieldInfoPtr_m_webName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_webName");
		NativeFieldInfoPtr_m_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "m_flags");
		NativeFieldInfoPtr_sep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, "sep");
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673195);
		NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673196);
		NativeMethodInfoPtr_get_WebName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr, 100673197);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 820146, RefRangeEnd = 820147, XrefRangeStart = 820140, XrefRangeEnd = 820146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CodePageDataItem(int dataIndex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodePageDataItem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dataIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 820147, XrefRangeEnd = 820149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateString(string pStrings, uint index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(pStrings);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateString_Internal_Static_String_String_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public CodePageDataItem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
