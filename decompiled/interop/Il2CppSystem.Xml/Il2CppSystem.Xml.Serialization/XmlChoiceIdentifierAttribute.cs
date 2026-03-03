using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Xml.Serialization;

public class XmlChoiceIdentifierAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_memberName;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MemberName_Public_get_String_0;

	public unsafe string memberName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memberName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memberName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string MemberName
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 915349, RefRangeEnd = 915359, XrefRangeStart = 915349, XrefRangeEnd = 915359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MemberName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static XmlChoiceIdentifierAttribute()
	{
		Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlChoiceIdentifierAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_memberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, "memberName");
		NativeMethodInfoPtr_get_MemberName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlChoiceIdentifierAttribute>.NativeClassPtr, 100665396);
	}

	public XmlChoiceIdentifierAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
