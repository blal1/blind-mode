using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public static class ValidationHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EmptyArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidMethodChars;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidParamChars;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0;

	public unsafe static Il2CppStringArray EmptyArray
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EmptyArray, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EmptyArray, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> InvalidMethodChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidMethodChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidMethodChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> InvalidParamChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidParamChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidParamChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ValidationHelper()
	{
		Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ValidationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr);
		NativeFieldInfoPtr_EmptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "EmptyArray");
		NativeFieldInfoPtr_InvalidMethodChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidMethodChars");
		NativeFieldInfoPtr_InvalidParamChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, "InvalidParamChars");
		NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100666143);
		NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100666144);
		NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationHelper>.NativeClassPtr, 100666145);
	}

	[CallerCount(0)]
	public unsafe static string MakeStringNull(string stringValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeStringNull_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 887726, RefRangeEnd = 887729, XrefRangeStart = 887726, XrefRangeEnd = 887726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBlankString(string stringValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(stringValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlankString_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 884962, RefRangeEnd = 884963, XrefRangeStart = 884962, XrefRangeEnd = 884963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ValidateTcpPort(int port)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&port);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTcpPort_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ValidationHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
