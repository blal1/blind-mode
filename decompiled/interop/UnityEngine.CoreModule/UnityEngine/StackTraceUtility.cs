using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Diagnostics;

namespace UnityEngine;

public static class StackTraceUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_projectFolder;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0;

	public unsafe static string projectFolder
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_projectFolder, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_projectFolder, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static StackTraceUtility()
	{
		Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "StackTraceUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr);
		NativeFieldInfoPtr_projectFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, "projectFolder");
		NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666470);
		NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666471);
		NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666472);
		NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTraceUtility>.NativeClassPtr, 100666473);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204067, XrefRangeEnd = 1204086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetProjectFolder(string folder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetProjectFolder_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204086, XrefRangeEnd = 1204103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ExtractStackTrace()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractStackTrace_Public_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204103, XrefRangeEnd = 1204157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExtractStringFromExceptionInternal(Il2CppSystem.Object exceptiono, out string message, out string stackTrace)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exceptiono);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractStringFromExceptionInternal_Internal_Static_Void_Object_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		message = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		stackTrace = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1204256, RefRangeEnd = 1204258, XrefRangeStart = 1204157, XrefRangeEnd = 1204256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ExtractFormattedStackTrace(StackTrace stackFrames)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stackFrames);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExtractFormattedStackTrace_Internal_Static_String_StackTrace_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public StackTraceUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static string ExtractStringFromException(Il2CppSystem.Object exception)
	{
		ExtractStringFromExceptionInternal(exception, out var message, out var stackTrace);
		return Il2CppSystem.String.Concat(message, "\n", stackTrace);
	}
}
