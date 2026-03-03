using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct EnableIMECompositionCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ImeEnabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_imeEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_EnableIMECompositionCommand_Boolean_0;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte m_ImeEnabled;

	public unsafe static int kSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
		}
	}

	public unsafe static FourCC Type
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007863, XrefRangeEnd = 1007864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool imeEnabled
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imeEnabled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007864, XrefRangeEnd = 1007865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EnableIMECompositionCommand()
	{
		Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "EnableIMECompositionCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr);
		NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, "kSize");
		NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, "baseCommand");
		NativeFieldInfoPtr_m_ImeEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, "m_ImeEnabled");
		NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, 100667306);
		NativeMethodInfoPtr_get_imeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, 100667307);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, 100667308);
		NativeMethodInfoPtr_Create_Public_Static_EnableIMECompositionCommand_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, 100667309);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007866, RefRangeEnd = 1007867, XrefRangeStart = 1007865, XrefRangeEnd = 1007866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static EnableIMECompositionCommand Create(bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_EnableIMECompositionCommand_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(EnableIMECompositionCommand*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EnableIMECompositionCommand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
