using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

public static class ConsoleDriver : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_driver;

	private static readonly System.IntPtr NativeFieldInfoPtr_is_console;

	private static readonly System.IntPtr NativeFieldInfoPtr_called_isatty;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0;

	public unsafe static IConsoleDriver driver
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_driver, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_driver, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool is_console
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_is_console, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_is_console, (void*)(&value));
		}
	}

	public unsafe static bool called_isatty
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_called_isatty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_called_isatty, (void*)(&value));
		}
	}

	public unsafe static bool IsConsole
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 760118, RefRangeEnd = 760121, XrefRangeStart = 760095, XrefRangeEnd = 760118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ConsoleDriver()
	{
		Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleDriver");
		NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "driver");
		NativeFieldInfoPtr_is_console = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "is_console");
		NativeFieldInfoPtr_called_isatty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "called_isatty");
		NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667077);
		NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667078);
		NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667079);
		NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667080);
		NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667081);
		NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667082);
		NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667083);
		NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667084);
		NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667085);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760077, RefRangeEnd = 760078, XrefRangeStart = 760074, XrefRangeEnd = 760077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IConsoleDriver CreateNullConsoleDriver()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760082, RefRangeEnd = 760083, XrefRangeStart = 760078, XrefRangeEnd = 760082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IConsoleDriver CreateWindowsConsoleDriver()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 760087, RefRangeEnd = 760088, XrefRangeStart = 760083, XrefRangeEnd = 760087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IConsoleDriver CreateTermInfoDriver(string term)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760088, XrefRangeEnd = 760095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&intercept);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ConsoleKeyInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760121, XrefRangeEnd = 760122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Isatty(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalKeyAvailable(int ms_timeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ms_timeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760122, XrefRangeEnd = 760141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TtySetup(string keypadXmit, string teardown, out Il2CppStructArray<byte> control_characters, out int* address)
	{
		//IL_007d->IL007f: Incompatible stack types: I vs O
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(keypadXmit);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(teardown);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		control_characters = ((num5 == 0) ? null : new Il2CppStructArray<byte>((System.IntPtr)num5));
		nint num6 = num4;
		Unsafe.As<int*, object>(ref address) = ((num6 == 0) ? null : ((object)new int*((System.IntPtr)num6)));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760141, XrefRangeEnd = 760142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SetEcho(bool wantEcho)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wantEcho);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ConsoleDriver(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
