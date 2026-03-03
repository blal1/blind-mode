using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSpine.Unity;

public class SpineSkin : SpineAttributeBase
{
	private static readonly IntPtr NativeFieldInfoPtr_defaultAsEmptyString;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_Boolean_0;

	public unsafe bool defaultAsEmptyString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultAsEmptyString);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultAsEmptyString)) = value;
		}
	}

	static SpineSkin()
	{
		Il2CppClassPointerStore<SpineSkin>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SpineSkin");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineSkin>.NativeClassPtr);
		NativeFieldInfoPtr_defaultAsEmptyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineSkin>.NativeClassPtr, "defaultAsEmptyString");
		NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineSkin>.NativeClassPtr, 100664127);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857828, XrefRangeEnd = 857838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineSkin(string startsWith = "", string dataField = "", bool includeNone = false, bool fallbackToTextField = false, bool defaultAsEmptyString = false, bool avoidGenericMenu = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineSkin>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(startsWith);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dataField);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &includeNone;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &fallbackToTextField;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &defaultAsEmptyString;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &avoidGenericMenu;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpineSkin(IntPtr pointer)
		: base(pointer)
	{
	}
}
