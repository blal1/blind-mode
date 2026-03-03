using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml;

public class IDtdAttributeListInfo : Il2CppObjectBase
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;

	public unsafe virtual bool HasNonCDataAttributes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static IDtdAttributeListInfo()
	{
		Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "IDtdAttributeListInfo");
		NativeMethodInfoPtr_get_HasNonCDataAttributes_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDtdAttributeListInfo>.NativeClassPtr, 100663323);
	}

	[CallerCount(0)]
	public unsafe virtual IDtdAttributeInfo LookupAttribute(string prefix, string localName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(localName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LookupAttribute_Public_Abstract_Virtual_New_IDtdAttributeInfo_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LookupDefaultAttributes_Public_Abstract_Virtual_New_IEnumerable_1_IDtdDefaultAttributeInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr2) : null;
	}

	public IDtdAttributeListInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
