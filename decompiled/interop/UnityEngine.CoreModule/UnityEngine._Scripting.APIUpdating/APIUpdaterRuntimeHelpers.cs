using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine._Scripting.APIUpdating;

public class APIUpdaterRuntimeHelpers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;

	static APIUpdaterRuntimeHelpers()
	{
		Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine._Scripting.APIUpdating", "APIUpdaterRuntimeHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100666948);
		NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100666949);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221898, XrefRangeEnd = 1221911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMovedFromAttributeDataForType(Il2CppSystem.Type sourceType, out string assembly, out string nsp, out string klass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceType);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		assembly = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		nsp = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		klass = IL2CPP.Il2CppStringToManaged((System.IntPtr)num6);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221911, XrefRangeEnd = 1221944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetObsoleteTypeRedirection(Il2CppSystem.Type sourceType, out string assemblyName, out string nsp, out string className)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceType);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		assemblyName = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		nsp = IL2CPP.Il2CppStringToManaged((System.IntPtr)num4);
		className = IL2CPP.Il2CppStringToManaged((System.IntPtr)num6);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public APIUpdaterRuntimeHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
