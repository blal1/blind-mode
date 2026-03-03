using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSpine.Unity;

public class SpineAnimation : SpineAttributeBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_0;

	static SpineAnimation()
	{
		Il2CppClassPointerStore<SpineAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SpineAnimation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineAnimation>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAnimation>.NativeClassPtr, 100664122);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857808, XrefRangeEnd = 857818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineAnimation(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false, bool avoidGenericMenu = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineAnimation>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(startsWith);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dataField);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &includeNone;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &fallbackToTextField;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &avoidGenericMenu;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpineAnimation(IntPtr pointer)
		: base(pointer)
	{
	}
}
