using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct TouchscreenState
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.LowLevel.TouchscreenState+<primaryTouchData>e__FixedBuffer")]
	public struct _primaryTouchData_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _primaryTouchData_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_primaryTouchData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, "<primaryTouchData>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_primaryTouchData_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_primaryTouchData_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_primaryTouchData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.LowLevel.TouchscreenState+<touchData>e__FixedBuffer")]
	public struct _touchData_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _touchData_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_touchData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, "<touchData>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_touchData_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_touchData_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_touchData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxTouches;

	private static readonly System.IntPtr NativeFieldInfoPtr_primaryTouchData;

	private static readonly System.IntPtr NativeFieldInfoPtr_kTouchDataOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_touchData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_primaryTouch_Public_get_ptr_TouchState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_touches_Public_get_ptr_TouchState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public _primaryTouchData_e__FixedBuffer primaryTouchData;

	[FieldOffset(56)]
	public _touchData_e__FixedBuffer touchData;

	public unsafe static int MaxTouches
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxTouches, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxTouches, (void*)(&value));
		}
	}

	public unsafe static int kTouchDataOffset
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kTouchDataOffset, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kTouchDataOffset, (void*)(&value));
		}
	}

	public unsafe static FourCC Format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008111, XrefRangeEnd = 1008112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TouchState* primaryTouch
	{
		[CallerCount(1403)]
		[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryTouch_Public_get_ptr_TouchState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (TouchState*)result;
		}
	}

	public unsafe TouchState* touches
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1008112, RefRangeEnd = 1008120, XrefRangeStart = 1008112, XrefRangeEnd = 1008112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touches_Public_get_ptr_TouchState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (TouchState*)result;
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008120, XrefRangeEnd = 1008121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TouchscreenState()
	{
		Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "TouchscreenState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr);
		NativeFieldInfoPtr_MaxTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, "MaxTouches");
		NativeFieldInfoPtr_primaryTouchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, "primaryTouchData");
		NativeFieldInfoPtr_kTouchDataOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, "kTouchDataOffset");
		NativeFieldInfoPtr_touchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, "touchData");
		NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, 100667437);
		NativeMethodInfoPtr_get_primaryTouch_Public_get_ptr_TouchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, 100667438);
		NativeMethodInfoPtr_get_touches_Public_get_ptr_TouchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, 100667439);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, 100667440);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TouchscreenState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
