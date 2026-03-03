using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

public sealed class LinkInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_hashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkIdFirstCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkIdLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkTextfirstCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkTextLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LinkIdString;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LinkTextString;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLinkId_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLinkText_Public_String_TextInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLinkId_Public_String_0;

	public unsafe int hashCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCode)) = value;
		}
	}

	public unsafe int linkIdFirstCharacterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkIdFirstCharacterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkIdFirstCharacterIndex)) = value;
		}
	}

	public unsafe int linkIdLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkIdLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkIdLength)) = value;
		}
	}

	public unsafe int linkTextfirstCharacterIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkTextfirstCharacterIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkTextfirstCharacterIndex)) = value;
		}
	}

	public unsafe int linkTextLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkTextLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkTextLength)) = value;
		}
	}

	public unsafe Il2CppStructArray<char> linkId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkId);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_linkId)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_LinkIdString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LinkIdString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LinkIdString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_LinkTextString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LinkTextString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LinkTextString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static LinkInfo()
	{
		Il2CppClassPointerStore<LinkInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "LinkInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr);
		NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "hashCode");
		NativeFieldInfoPtr_linkIdFirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkIdFirstCharacterIndex");
		NativeFieldInfoPtr_linkIdLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkIdLength");
		NativeFieldInfoPtr_linkTextfirstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkTextfirstCharacterIndex");
		NativeFieldInfoPtr_linkTextLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkTextLength");
		NativeFieldInfoPtr_linkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "linkId");
		NativeFieldInfoPtr_m_LinkIdString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "m_LinkIdString");
		NativeFieldInfoPtr_m_LinkTextString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, "m_LinkTextString");
		NativeMethodInfoPtr_SetLinkId_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_GetLinkText_Public_String_TextInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_GetLinkId_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr, 100663371);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274836, XrefRangeEnd = 1274844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLinkId(Il2CppStructArray<char> text, int startIndex, int length)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLinkId_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1274850, RefRangeEnd = 1274854, XrefRangeStart = 1274844, XrefRangeEnd = 1274850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLinkText(TextInfo textInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinkText_Public_String_TextInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1274857, RefRangeEnd = 1274862, XrefRangeStart = 1274854, XrefRangeEnd = 1274857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetLinkId()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLinkId_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public LinkInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LinkInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LinkInfo>.NativeClassPtr))
	{
	}
}
