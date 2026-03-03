using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct IMECompositionEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kIMECharBufferSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_compositionString;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IMECompositionEvent_Int32_String_Double_0;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public IMECompositionString compositionString;

	public unsafe static int kIMECharBufferSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kIMECharBufferSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kIMECharBufferSize, (void*)(&value));
		}
	}

	public unsafe static int Type
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Type, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Type, (void*)(&value));
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static IMECompositionEvent()
	{
		Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "IMECompositionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr);
		NativeFieldInfoPtr_kIMECharBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "kIMECharBufferSize");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_baseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "baseEvent");
		NativeFieldInfoPtr_compositionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "compositionString");
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100667476);
		NativeMethodInfoPtr_Create_Public_Static_IMECompositionEvent_Int32_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100667477);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008198, XrefRangeEnd = 1008205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMECompositionEvent Create(int deviceId, string compositionString, double time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&deviceId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(compositionString);
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_IMECompositionEvent_Int32_String_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IMECompositionEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
