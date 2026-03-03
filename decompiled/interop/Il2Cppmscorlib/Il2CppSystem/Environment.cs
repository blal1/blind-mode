using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem;

public static class Environment : Object
{
	[OriginalName("mscorlib.dll", "", "SpecialFolder")]
	public enum SpecialFolder
	{
		MyDocuments = 5,
		Desktop = 0,
		MyComputer = 17,
		Programs = 2,
		Personal = 5,
		Favorites = 6,
		Startup = 7,
		Recent = 8,
		SendTo = 9,
		StartMenu = 11,
		MyMusic = 13,
		DesktopDirectory = 16,
		Templates = 21,
		ApplicationData = 26,
		LocalApplicationData = 28,
		InternetCache = 32,
		Cookies = 33,
		History = 34,
		CommonApplicationData = 35,
		System = 37,
		ProgramFiles = 38,
		MyPictures = 39,
		CommonProgramFiles = 43,
		MyVideos = 14,
		NetworkShortcuts = 19,
		Fonts = 20,
		CommonStartMenu = 22,
		CommonPrograms = 23,
		CommonStartup = 24,
		CommonDesktopDirectory = 25,
		PrinterShortcuts = 27,
		Windows = 36,
		UserProfile = 40,
		SystemX86 = 41,
		ProgramFilesX86 = 42,
		CommonProgramFilesX86 = 44,
		CommonTemplates = 45,
		CommonDocuments = 46,
		CommonAdminTools = 47,
		AdminTools = 48,
		CommonMusic = 53,
		CommonPictures = 54,
		CommonVideos = 55,
		Resources = 56,
		LocalizedResources = 57,
		CommonOemLinks = 58,
		CDBurning = 59
	}

	[OriginalName("mscorlib.dll", "", "SpecialFolderOption")]
	public enum SpecialFolderOption
	{
		None = 0,
		DoNotVerify = 0x4000,
		Create = 0x8000
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_mono_corlib_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_nl;

	private static readonly System.IntPtr NativeFieldInfoPtr_os;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDirectory_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewLine_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemDirectory_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FailFast_Internal_Static_Void_String_Exception_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0;

	public unsafe static string mono_corlib_version
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mono_corlib_version, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mono_corlib_version, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string nl
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nl, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nl, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static OperatingSystem os
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_os, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_os, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string CurrentDirectory
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759036, RefRangeEnd = 759037, XrefRangeStart = 759035, XrefRangeEnd = 759036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentDirectory_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static int CurrentManagedThreadId
	{
		[CallerCount(241)]
		[CachedScanResults(RefRangeStart = 759040, RefRangeEnd = 759281, XrefRangeStart = 759037, XrefRangeEnd = 759040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool HasShutdownStarted
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 759282, RefRangeEnd = 759285, XrefRangeStart = 759281, XrefRangeEnd = 759282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string MachineName
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 759286, RefRangeEnd = 759289, XrefRangeStart = 759285, XrefRangeEnd = 759286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string NewLine
	{
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 759297, RefRangeEnd = 759369, XrefRangeStart = 759290, XrefRangeEnd = 759297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static PlatformID Platform
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759369, XrefRangeEnd = 759370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PlatformID*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static OperatingSystem OSVersion
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 759409, RefRangeEnd = 759417, XrefRangeStart = 759371, XrefRangeEnd = 759409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OperatingSystem>(intPtr2) : null;
		}
	}

	public unsafe static string StackTrace
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759437, XrefRangeEnd = 759442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string SystemDirectory
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759488, RefRangeEnd = 759489, XrefRangeStart = 759442, XrefRangeEnd = 759488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SystemDirectory_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static int TickCount
	{
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 759490, RefRangeEnd = 759531, XrefRangeStart = 759489, XrefRangeEnd = 759490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string UserDomainName
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 759286, RefRangeEnd = 759289, XrefRangeStart = 759286, XrefRangeEnd = 759289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string UserName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 759532, RefRangeEnd = 759533, XrefRangeStart = 759531, XrefRangeEnd = 759532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static int ProcessorCount
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 759728, RefRangeEnd = 759733, XrefRangeStart = 759727, XrefRangeEnd = 759728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool IsRunningOnWindows
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 759734, RefRangeEnd = 759742, XrefRangeStart = 759733, XrefRangeEnd = 759734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool IsUnix
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 759750, RefRangeEnd = 759753, XrefRangeStart = 759749, XrefRangeEnd = 759750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Environment()
	{
		Il2CppClassPointerStore<Environment>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Environment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Environment>.NativeClassPtr);
		NativeFieldInfoPtr_mono_corlib_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "mono_corlib_version");
		NativeFieldInfoPtr_nl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "nl");
		NativeFieldInfoPtr_os = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment>.NativeClassPtr, "os");
		NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667008);
		NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667009);
		NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667010);
		NativeMethodInfoPtr_get_CurrentDirectory_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667011);
		NativeMethodInfoPtr_get_CurrentManagedThreadId_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667012);
		NativeMethodInfoPtr_get_HasShutdownStarted_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667013);
		NativeMethodInfoPtr_get_MachineName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667014);
		NativeMethodInfoPtr_GetNewLine_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667015);
		NativeMethodInfoPtr_get_NewLine_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667016);
		NativeMethodInfoPtr_get_Platform_Internal_Static_get_PlatformID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667017);
		NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667018);
		NativeMethodInfoPtr_get_OSVersion_Public_Static_get_OperatingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667019);
		NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667020);
		NativeMethodInfoPtr_get_StackTrace_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667021);
		NativeMethodInfoPtr_get_SystemDirectory_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667022);
		NativeMethodInfoPtr_get_TickCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667023);
		NativeMethodInfoPtr_get_UserDomainName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667024);
		NativeMethodInfoPtr_get_UserName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667025);
		NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667026);
		NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667027);
		NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667028);
		NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667029);
		NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667030);
		NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667031);
		NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667032);
		NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667033);
		NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667034);
		NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667035);
		NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667036);
		NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667037);
		NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667038);
		NativeMethodInfoPtr_FailFast_Internal_Static_Void_String_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667039);
		NativeMethodInfoPtr_get_ProcessorCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667040);
		NativeMethodInfoPtr_get_IsRunningOnWindows_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667041);
		NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667042);
		NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667043);
		NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667044);
		NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667045);
		NativeMethodInfoPtr_get_IsUnix_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667046);
		NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment>.NativeClassPtr, 100667047);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceString(string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 758990, RefRangeEnd = 759025, XrefRangeStart = 758985, XrefRangeEnd = 758990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceString(string key, [Optional] Il2CppReferenceArray<Object> values)
	{
		if (values == null)
		{
			values = new Il2CppReferenceArray<Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759034, RefRangeEnd = 759035, XrefRangeStart = 759025, XrefRangeEnd = 759034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetResourceStringEncodingName(int codePage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codePage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResourceStringEncodingName_Internal_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759289, XrefRangeEnd = 759290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetNewLine()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewLine_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759370, XrefRangeEnd = 759371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetOSVersionString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOSVersionString_Internal_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759417, XrefRangeEnd = 759437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Version CreateVersionFromString(string info)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(info);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateVersionFromString_Internal_Static_Version_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Version>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759533, XrefRangeEnd = 759534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Exit(int exitCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&exitCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Exit_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759565, RefRangeEnd = 759566, XrefRangeStart = 759534, XrefRangeEnd = 759565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ExpandEnvironmentVariables(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandEnvironmentVariables_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759567, RefRangeEnd = 759569, XrefRangeStart = 759566, XrefRangeEnd = 759567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetCommandLineArgs()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCommandLineArgs_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759569, XrefRangeEnd = 759570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string internalGetEnvironmentVariable_native(System.IntPtr variable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&variable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetEnvironmentVariable_native_Internal_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 759576, RefRangeEnd = 759589, XrefRangeStart = 759570, XrefRangeEnd = 759576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string internalGetEnvironmentVariable(string variable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetEnvironmentVariable_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759590, RefRangeEnd = 759592, XrefRangeStart = 759589, XrefRangeEnd = 759590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetEnvironmentVariable(string variable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(variable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnvironmentVariable_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759592, XrefRangeEnd = 759601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hashtable GetEnvironmentVariablesNoCase()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnvironmentVariablesNoCase_Private_Static_Hashtable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 759605, RefRangeEnd = 759615, XrefRangeStart = 759601, XrefRangeEnd = 759605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFolderPath(SpecialFolder folder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&folder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759615, XrefRangeEnd = 759616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWindowsFolderPath(int folder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&folder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWindowsFolderPath_Private_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759616, XrefRangeEnd = 759620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&folder);
		*(SpecialFolderOption**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &option;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFolderPath_Public_Static_String_SpecialFolder_SpecialFolderOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759667, RefRangeEnd = 759668, XrefRangeStart = 759620, XrefRangeEnd = 759667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(config_dir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(home_dir);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fallback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadXdgUserDir_Private_Static_String_String_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759722, RefRangeEnd = 759724, XrefRangeStart = 759668, XrefRangeEnd = 759722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UnixGetFolderPath(SpecialFolder folder, SpecialFolderOption option)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&folder);
		*(SpecialFolderOption**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &option;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnixGetFolderPath_Internal_Static_String_SpecialFolder_SpecialFolderOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759725, RefRangeEnd = 759726, XrefRangeStart = 759724, XrefRangeEnd = 759725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FailFast(string message, Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FailFast_Public_Static_Void_String_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759726, XrefRangeEnd = 759727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FailFast(string message, Exception exception, string errorSource)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(errorSource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FailFast_Internal_Static_Void_String_Exception_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759742, XrefRangeEnd = 759743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetEnvironmentVariableNames()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnvironmentVariableNames_Private_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 759744, RefRangeEnd = 759745, XrefRangeStart = 759743, XrefRangeEnd = 759744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetMachineConfigPath()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMachineConfigPath_Internal_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759745, XrefRangeEnd = 759746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string internalGetHome()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_internalGetHome_Internal_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 759747, RefRangeEnd = 759749, XrefRangeStart = 759746, XrefRangeEnd = 759747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPageSize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPageSize_Internal_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 759761, RefRangeEnd = 759765, XrefRangeStart = 759753, XrefRangeEnd = 759761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStackTrace(Exception e, bool needFileInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &needFileInfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStackTrace_Internal_Static_String_Exception_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public static string GetResourceString(string key, params Object[] values)
	{
		return GetResourceString(key, new Il2CppReferenceArray<Object>(values));
	}

	public Environment(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
