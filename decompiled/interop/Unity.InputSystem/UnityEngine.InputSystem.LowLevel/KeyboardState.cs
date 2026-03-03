using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct KeyboardState
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.LowLevel.KeyboardState+<keys>e__FixedBuffer")]
	public struct _keys_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _keys_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_keys_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, "<keys>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_keys_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_keys_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_keys_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kSizeInBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_kSizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_keys;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStructArray_1_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Key_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Internal_Boolean_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Press_Public_Void_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public _keys_e__FixedBuffer keys;

	public unsafe static int kSizeInBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSizeInBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSizeInBits, (void*)(&value));
		}
	}

	public unsafe static int kSizeInBytes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSizeInBytes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSizeInBytes, (void*)(&value));
		}
	}

	public unsafe static FourCC Format
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008014, RefRangeEnd = 1008015, XrefRangeStart = 1008013, XrefRangeEnd = 1008014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008029, XrefRangeEnd = 1008030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static KeyboardState()
	{
		Il2CppClassPointerStore<KeyboardState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "KeyboardState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr);
		NativeFieldInfoPtr_kSizeInBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, "kSizeInBits");
		NativeFieldInfoPtr_kSizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, "kSizeInBytes");
		NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, "keys");
		NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667390);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667391);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStructArray_1_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667392);
		NativeMethodInfoPtr_Set_Public_Void_Key_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667393);
		NativeMethodInfoPtr_Get_Internal_Boolean_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667394);
		NativeMethodInfoPtr_Press_Public_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667395);
		NativeMethodInfoPtr_Release_Public_Void_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667396);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, 100667397);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008015, XrefRangeEnd = 1008018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyboardState([Optional] Il2CppStructArray<Key> pressedKeys)
	{
		if (pressedKeys == null)
		{
			pressedKeys = new Il2CppStructArray<Key>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pressedKeys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Key_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008018, XrefRangeEnd = 1008022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyboardState(bool IMESelected, [Optional] Il2CppStructArray<Key> pressedKeys)
	{
		if (pressedKeys == null)
		{
			pressedKeys = new Il2CppStructArray<Key>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&IMESelected);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)pressedKeys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Il2CppStructArray_1_Key_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1008023, RefRangeEnd = 1008025, XrefRangeStart = 1008022, XrefRangeEnd = 1008023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set(Key key, bool state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Key_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008026, RefRangeEnd = 1008027, XrefRangeStart = 1008025, XrefRangeEnd = 1008026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Get(Key key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Internal_Boolean_Key_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008027, XrefRangeEnd = 1008028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Press(Key key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Press_Public_Void_Key_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008028, XrefRangeEnd = 1008029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release(Key key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_Key_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public KeyboardState(params Key[] pressedKeys)
		: this(new Il2CppStructArray<Key>(pressedKeys))
	{
	}

	public KeyboardState(bool IMESelected, params Key[] pressedKeys)
		: this(IMESelected, new Il2CppStructArray<Key>(pressedKeys))
	{
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyboardState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
