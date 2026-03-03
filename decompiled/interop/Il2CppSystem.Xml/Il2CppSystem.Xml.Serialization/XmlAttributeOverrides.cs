using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization;

public class XmlAttributeOverrides : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_overrides;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0;

	public unsafe Hashtable overrides
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrides);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrides)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe XmlAttributes this[Type type]
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 915406, RefRangeEnd = 915413, XrefRangeStart = 915397, XrefRangeEnd = 915406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr2) : null;
		}
	}

	public unsafe XmlAttributes this[Type type, string member]
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 915421, RefRangeEnd = 915423, XrefRangeStart = 915413, XrefRangeEnd = 915421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(member);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<XmlAttributes>(intPtr2) : null;
		}
	}

	static XmlAttributeOverrides()
	{
		Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlAttributeOverrides");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr);
		NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, "overrides");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100665375);
		NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100665376);
		NativeMethodInfoPtr_get_Item_Public_get_XmlAttributes_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100665377);
		NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr, 100665378);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 915396, RefRangeEnd = 915397, XrefRangeStart = 915390, XrefRangeEnd = 915396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XmlAttributeOverrides()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttributeOverrides>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 915423, XrefRangeEnd = 915429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypeMember GetKey(Type type, string member)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(member);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Private_TypeMember_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TypeMember>(intPtr2) : null;
	}

	public XmlAttributeOverrides(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
