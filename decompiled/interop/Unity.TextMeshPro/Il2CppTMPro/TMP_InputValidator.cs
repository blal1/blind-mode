using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

namespace Il2CppTMPro;

[Serializable]
public class TMP_InputValidator : ScriptableObject
{
	private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Char_byref_String_byref_Int32_Char_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static TMP_InputValidator()
	{
		Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_InputValidator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr);
		NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Char_byref_String_byref_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr, 100664327);
	}

	[CallerCount(0)]
	public unsafe virtual char Validate(ref string text, ref int pos, char ch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref pos);
		*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &ch;
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Validate_Public_Abstract_Virtual_New_Char_byref_String_byref_Int32_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		text = IL2CPP.Il2CppStringToManaged(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 26528, RefRangeEnd = 26564, XrefRangeStart = 26528, XrefRangeEnd = 26564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_InputValidator()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_InputValidator>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_InputValidator(IntPtr pointer)
		: base(pointer)
	{
	}
}
