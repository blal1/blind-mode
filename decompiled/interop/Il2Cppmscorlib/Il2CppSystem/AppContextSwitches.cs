using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem;

public static class AppContextSwitches : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoAsyncCurrentCulture;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnforceJapaneseEraYearRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing;

	public unsafe static bool SetActorAsReferenceWhenCopyingClaimsIdentity
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity, (void*)(&value));
		}
	}

	public unsafe static bool NoAsyncCurrentCulture
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoAsyncCurrentCulture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoAsyncCurrentCulture, (void*)(&value));
		}
	}

	public unsafe static bool EnforceJapaneseEraYearRanges
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnforceJapaneseEraYearRanges, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnforceJapaneseEraYearRanges, (void*)(&value));
		}
	}

	public unsafe static bool FormatJapaneseFirstYearAsANumber
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber, (void*)(&value));
		}
	}

	public unsafe static bool EnforceLegacyJapaneseDateParsing
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing, (void*)(&value));
		}
	}

	static AppContextSwitches()
	{
		Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppContextSwitches");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr);
		NativeFieldInfoPtr_SetActorAsReferenceWhenCopyingClaimsIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "SetActorAsReferenceWhenCopyingClaimsIdentity");
		NativeFieldInfoPtr_NoAsyncCurrentCulture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "NoAsyncCurrentCulture");
		NativeFieldInfoPtr_EnforceJapaneseEraYearRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "EnforceJapaneseEraYearRanges");
		NativeFieldInfoPtr_FormatJapaneseFirstYearAsANumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "FormatJapaneseFirstYearAsANumber");
		NativeFieldInfoPtr_EnforceLegacyJapaneseDateParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppContextSwitches>.NativeClassPtr, "EnforceLegacyJapaneseDateParsing");
	}

	public AppContextSwitches(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
