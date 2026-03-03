using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct QueryEnabledStateCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnabled;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_QueryEnabledStateCommand_0;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isEnabled;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007910, XrefRangeEnd = 1007911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007911, XrefRangeEnd = 1007912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static QueryEnabledStateCommand()
	{
		Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "QueryEnabledStateCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr);
		NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, "kSize");
		NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, "baseCommand");
		NativeFieldInfoPtr_isEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, "isEnabled");
		NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, 100667333);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, 100667334);
		NativeMethodInfoPtr_Create_Public_Static_QueryEnabledStateCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, 100667335);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1007913, RefRangeEnd = 1007915, XrefRangeStart = 1007912, XrefRangeEnd = 1007913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static QueryEnabledStateCommand Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_QueryEnabledStateCommand_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(QueryEnabledStateCommand*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QueryEnabledStateCommand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
