using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public class Win32NetworkInterface : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_fixedInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MultiByteToWideChar_Private_Static_Int32_UInt32_UInt32_ptr_Byte_Int32_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_ptr_Byte_0;

	public unsafe static Win32_FIXED_INFO fixedInfo
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_fixedInfo, (void*)intPtr);
			return new Win32_FIXED_INFO(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_FIXED_INFO>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_fixedInfo, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static bool initialized
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initialized, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initialized, (void*)(&value));
		}
	}

	public unsafe static Win32_FIXED_INFO FixedInfo
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 897356, RefRangeEnd = 897357, XrefRangeStart = 897328, XrefRangeEnd = 897356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Win32_FIXED_INFO(pointer);
		}
	}

	static Win32NetworkInterface()
	{
		Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32NetworkInterface");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr);
		NativeFieldInfoPtr_fixedInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "fixedInfo");
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, "initialized");
		NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100667140);
		NativeMethodInfoPtr_MultiByteToWideChar_Private_Static_Int32_UInt32_UInt32_ptr_Byte_Int32_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100667141);
		NativeMethodInfoPtr_get_FixedInfo_Public_Static_get_Win32_FIXED_INFO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100667142);
		NativeMethodInfoPtr_Method_Internal_Static_String_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32NetworkInterface>.NativeClassPtr, 100667143);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897320, XrefRangeEnd = 897323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNetworkParams(System.IntPtr ptr, ref int size)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref size);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNetworkParams_Private_Static_Int32_IntPtr_byref_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 897326, RefRangeEnd = 897328, XrefRangeStart = 897323, XrefRangeEnd = 897326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MultiByteToWideChar(uint CodePage, uint dwFlags, byte* lpMultiByteStr, int cbMultiByte, char* lpWideCharStr, int cchWideChar)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&CodePage);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dwFlags;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = lpMultiByteStr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cbMultiByte;
		*(char**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = lpWideCharStr;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &cchWideChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MultiByteToWideChar_Private_Static_Int32_UInt32_UInt32_ptr_Byte_Int32_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 897365, RefRangeEnd = 897368, XrefRangeStart = 897357, XrefRangeEnd = 897365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Method_Internal_Static_String_ptr_Byte_0(byte* bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)bytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_String_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public Win32NetworkInterface(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
