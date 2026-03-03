using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Text;

public static class EncodingHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_utf8EncodingWithoutMarkers;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockobj;

	private static readonly System.IntPtr NativeFieldInfoPtr_i18nAssembly;

	private static readonly System.IntPtr NativeFieldInfoPtr_i18nDisabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0;

	public unsafe static Encoding utf8EncodingWithoutMarkers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_utf8EncodingWithoutMarkers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_utf8EncodingWithoutMarkers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object lockobj
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lockobj, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lockobj, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Assembly i18nAssembly
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_i18nAssembly, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_i18nAssembly, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool i18nDisabled
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_i18nDisabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_i18nDisabled, (void*)(&value));
		}
	}

	public unsafe static Encoding UTF8Unmarked
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 783169, RefRangeEnd = 783175, XrefRangeStart = 783137, XrefRangeEnd = 783169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
		}
	}

	static EncodingHelper()
	{
		Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr);
		NativeFieldInfoPtr_utf8EncodingWithoutMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "utf8EncodingWithoutMarkers");
		NativeFieldInfoPtr_lockobj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "lockobj");
		NativeFieldInfoPtr_i18nAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nAssembly");
		NativeFieldInfoPtr_i18nDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, "i18nDisabled");
		NativeMethodInfoPtr_get_UTF8Unmarked_Internal_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669054);
		NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669055);
		NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669056);
		NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingHelper>.NativeClassPtr, 100669057);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783176, RefRangeEnd = 783177, XrefRangeStart = 783175, XrefRangeEnd = 783176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string InternalCodePage(ref int code_page)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref code_page);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCodePage_Internal_Static_String_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 783193, RefRangeEnd = 783196, XrefRangeStart = 783177, XrefRangeEnd = 783193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Encoding GetDefaultEncoding()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultEncoding_Internal_Static_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783267, RefRangeEnd = 783268, XrefRangeStart = 783196, XrefRangeEnd = 783267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object InvokeI18N(string name, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeI18N_Internal_Static_Object_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	public static Object InvokeI18N(string name, params Object[] args)
	{
		return InvokeI18N(name, new Il2CppReferenceArray<Object>(args));
	}

	public EncodingHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
