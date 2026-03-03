using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml;

public static class ValidateNames : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xmlCharType;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNameNoNamespaces_Internal_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SplitQName_Internal_Static_Void_String_byref_String_byref_String_0;

	public unsafe static XmlCharType xmlCharType
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_xmlCharType, (void*)intPtr);
			return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_xmlCharType, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	static ValidateNames()
	{
		Il2CppClassPointerStore<ValidateNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ValidateNames");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr);
		NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, "xmlCharType");
		NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664919);
		NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664920);
		NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664921);
		NativeMethodInfoPtr_IsNameNoNamespaces_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664922);
		NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664923);
		NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664924);
		NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664925);
		NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664926);
		NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664927);
		NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664928);
		NativeMethodInfoPtr_SplitQName_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidateNames>.NativeClassPtr, 100664929);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 910745, RefRangeEnd = 910746, XrefRangeStart = 910739, XrefRangeEnd = 910745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseNmtoken(string s, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNmtoken_Internal_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910746, XrefRangeEnd = 910753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseNmtokenNoNamespaces(string s, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNmtokenNoNamespaces_Internal_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 910759, RefRangeEnd = 910762, XrefRangeStart = 910753, XrefRangeEnd = 910759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseNameNoNamespaces(string s, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNameNoNamespaces_Internal_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 910766, RefRangeEnd = 910767, XrefRangeStart = 910762, XrefRangeEnd = 910766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsNameNoNamespaces(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNameNoNamespaces_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 910772, RefRangeEnd = 910782, XrefRangeStart = 910767, XrefRangeEnd = 910772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseNCName(string s, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910782, XrefRangeEnd = 910786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseNCName(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseNCName_Internal_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 910794, RefRangeEnd = 910796, XrefRangeStart = 910786, XrefRangeEnd = 910794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParseQName(string s, int offset, out int colonOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref colonOffset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseQName_Internal_Static_Int32_String_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 910820, RefRangeEnd = 910822, XrefRangeStart = 910796, XrefRangeEnd = 910820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ParseQNameThrow(string s, out string prefix, out string localName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseQNameThrow_Internal_Static_Void_String_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		prefix = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		localName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 910857, RefRangeEnd = 910858, XrefRangeStart = 910822, XrefRangeEnd = 910857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetStartChar;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetBadChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowInvalidName_Internal_Static_Void_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 910858, XrefRangeEnd = 910878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetStartChar;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offsetBadChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInvalidNameException_Internal_Static_Exception_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 910896, RefRangeEnd = 910898, XrefRangeStart = 910878, XrefRangeEnd = 910896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SplitQName(string name, out string prefix, out string lname)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SplitQName_Internal_Static_Void_String_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		prefix = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		lname = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
	}

	public ValidateNames(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
