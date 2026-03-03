using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct TextEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_character;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_ptr_TextEvent_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_TextEvent_Int32_Char_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_TextEvent_Int32_Int32_Double_0;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public int character;

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

	static TextEvent()
	{
		Il2CppClassPointerStore<TextEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "TextEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_baseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, "baseEvent");
		NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, "character");
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, 100667681);
		NativeMethodInfoPtr_From_Public_Static_ptr_TextEvent_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, 100667682);
		NativeMethodInfoPtr_Create_Public_Static_TextEvent_Int32_Char_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, 100667683);
		NativeMethodInfoPtr_Create_Public_Static_TextEvent_Int32_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, 100667684);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009254, XrefRangeEnd = 1009258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextEvent* From(InputEventPtr eventPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_ptr_TextEvent_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (TextEvent*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009259, RefRangeEnd = 1009260, XrefRangeStart = 1009258, XrefRangeEnd = 1009259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextEvent Create(int deviceId, char character, double time = -1.0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&deviceId);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &character;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_TextEvent_Int32_Char_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009260, XrefRangeEnd = 1009261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextEvent Create(int deviceId, int character, double time = -1.0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&deviceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &character;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_TextEvent_Int32_Int32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
