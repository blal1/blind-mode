using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct InputDeviceCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kBaseCommandSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseCommandSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_GenericFailure;

	private static readonly System.IntPtr NativeFieldInfoPtr_GenericSuccess;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeInBytes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_payloadSizeInBytes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_payloadPtr_Public_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FourCC_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateNative_Public_Static_NativeArray_1_Byte_FourCC_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public FourCC type;

	[FieldOffset(4)]
	public int sizeInBytes;

	public unsafe static int kBaseCommandSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kBaseCommandSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kBaseCommandSize, (void*)(&value));
		}
	}

	public unsafe static int BaseCommandSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaseCommandSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaseCommandSize, (void*)(&value));
		}
	}

	public unsafe static long GenericFailure
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GenericFailure, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GenericFailure, (void*)(&value));
		}
	}

	public unsafe static long GenericSuccess
	{
		get
		{
			Unsafe.SkipInit(out long result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GenericSuccess, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GenericSuccess, (void*)(&value));
		}
	}

	public unsafe int payloadSizeInBytes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1007890, RefRangeEnd = 1007891, XrefRangeStart = 1007890, XrefRangeEnd = 1007890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_payloadSizeInBytes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe void* payloadPtr
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1007891, RefRangeEnd = 1007894, XrefRangeStart = 1007891, XrefRangeEnd = 1007891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_payloadPtr_Public_get_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(146)]
		[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputDeviceCommand()
	{
		Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputDeviceCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr);
		NativeFieldInfoPtr_kBaseCommandSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, "kBaseCommandSize");
		NativeFieldInfoPtr_BaseCommandSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, "BaseCommandSize");
		NativeFieldInfoPtr_GenericFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, "GenericFailure");
		NativeFieldInfoPtr_GenericSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, "GenericSuccess");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, "type");
		NativeFieldInfoPtr_sizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, "sizeInBytes");
		NativeMethodInfoPtr_get_payloadSizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, 100667322);
		NativeMethodInfoPtr_get_payloadPtr_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, 100667323);
		NativeMethodInfoPtr__ctor_Public_Void_FourCC_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, 100667324);
		NativeMethodInfoPtr_AllocateNative_Public_Static_NativeArray_1_Byte_FourCC_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, 100667325);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, 100667326);
	}

	[CallerCount(230)]
	[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputDeviceCommand(FourCC type, int sizeInBytes = 8)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FourCC_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1007900, RefRangeEnd = 1007902, XrefRangeStart = 1007894, XrefRangeEnd = 1007900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<byte> AllocateNative(FourCC type, int payloadSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &payloadSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateNative_Public_Static_NativeArray_1_Byte_FourCC_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDeviceCommand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
