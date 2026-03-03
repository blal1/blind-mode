using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class FtpMethodInfo : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Method;

	private static readonly System.IntPtr NativeFieldInfoPtr_Operation;

	private static readonly System.IntPtr NativeFieldInfoPtr_Flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_HttpCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_knownMethodInfo;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_FtpOperation_FtpMethodFlags_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFlag_Internal_Boolean_FtpMethodFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCommandOnly_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUpload_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDownload_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldParseForResponseUri_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfo_Internal_Static_FtpMethodInfo_String_0;

	public unsafe string Method
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Method);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Method)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe FtpOperation Operation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Operation);
			return *(FtpOperation*)num;
		}
		set
		{
			*(FtpOperation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Operation)) = value;
		}
	}

	public unsafe FtpMethodFlags Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags);
			return *(FtpMethodFlags*)num;
		}
		set
		{
			*(FtpMethodFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flags)) = value;
		}
	}

	public unsafe string HttpCommand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HttpCommand);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HttpCommand)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Il2CppReferenceArray<FtpMethodInfo> s_knownMethodInfo
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_knownMethodInfo, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FtpMethodInfo>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_knownMethodInfo, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool IsCommandOnly
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCommandOnly_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsUpload
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsUpload_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool IsDownload
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDownload_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool ShouldParseForResponseUri
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShouldParseForResponseUri_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static FtpMethodInfo()
	{
		Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "FtpMethodInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr);
		NativeFieldInfoPtr_Method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "Method");
		NativeFieldInfoPtr_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "Operation");
		NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "Flags");
		NativeFieldInfoPtr_HttpCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "HttpCommand");
		NativeFieldInfoPtr_s_knownMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, "s_knownMethodInfo");
		NativeMethodInfoPtr__ctor_Internal_Void_String_FtpOperation_FtpMethodFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666011);
		NativeMethodInfoPtr_HasFlag_Internal_Boolean_FtpMethodFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666012);
		NativeMethodInfoPtr_get_IsCommandOnly_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666013);
		NativeMethodInfoPtr_get_IsUpload_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666014);
		NativeMethodInfoPtr_get_IsDownload_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666015);
		NativeMethodInfoPtr_get_ShouldParseForResponseUri_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666016);
		NativeMethodInfoPtr_GetMethodInfo_Internal_Static_FtpMethodInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr, 100666017);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 886671, XrefRangeEnd = 886674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FtpMethodInfo(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FtpMethodInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
		*(FtpOperation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &operation;
		*(FtpMethodFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(httpCommand);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_FtpOperation_FtpMethodFlags_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool HasFlag(FtpMethodFlags flags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&flags);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFlag_Internal_Boolean_FtpMethodFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 886685, RefRangeEnd = 886687, XrefRangeStart = 886674, XrefRangeEnd = 886685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FtpMethodInfo GetMethodInfo(string method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodInfo_Internal_Static_FtpMethodInfo_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FtpMethodInfo>(intPtr2) : null;
	}

	public FtpMethodInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
