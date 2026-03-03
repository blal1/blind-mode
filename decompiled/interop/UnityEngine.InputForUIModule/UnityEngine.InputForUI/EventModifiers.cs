using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputForUI;

[StructLayout(LayoutKind.Explicit)]
public struct EventModifiers
{
	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Modifiers")]
	[System.Flags]
	public enum Modifiers : uint
	{
		LeftShift = 1u,
		RightShift = 2u,
		Shift = 3u,
		LeftCtrl = 4u,
		RightCtrl = 8u,
		Ctrl = 0xCu,
		LeftAlt = 0x10u,
		RightAlt = 0x20u,
		Alt = 0x30u,
		LeftMeta = 0x40u,
		RightMeta = 0x80u,
		Meta = 0xC0u,
		CapsLock = 0x100u,
		Numlock = 0x200u,
		FunctionKey = 0x400u,
		Numeric = 0x800u
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__state;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPressed_Public_Boolean_Modifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isShiftPressed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCtrlPressed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isAltPressed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isMetaPressed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCapsLockEnabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isFunctionKeyPressed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isNumericPressed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPressed_Public_Void_Modifiers_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Private_Static_Void_byref_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public uint _state;

	public unsafe bool isShiftPressed
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251026, RefRangeEnd = 1251028, XrefRangeStart = 1251026, XrefRangeEnd = 1251026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isShiftPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isCtrlPressed
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251028, RefRangeEnd = 1251030, XrefRangeStart = 1251028, XrefRangeEnd = 1251028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCtrlPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isAltPressed
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251030, RefRangeEnd = 1251032, XrefRangeStart = 1251030, XrefRangeEnd = 1251030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isAltPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isMetaPressed
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1251032, RefRangeEnd = 1251034, XrefRangeStart = 1251032, XrefRangeEnd = 1251032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isMetaPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isCapsLockEnabled
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251034, RefRangeEnd = 1251035, XrefRangeStart = 1251034, XrefRangeEnd = 1251034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCapsLockEnabled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isFunctionKeyPressed
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251035, RefRangeEnd = 1251036, XrefRangeStart = 1251035, XrefRangeEnd = 1251035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isFunctionKeyPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isNumericPressed
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1251036, RefRangeEnd = 1251037, XrefRangeStart = 1251036, XrefRangeEnd = 1251036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isNumericPressed_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public bool isNumLockEnabled => IsPressed(Modifiers.Numlock);

	static EventModifiers()
	{
		Il2CppClassPointerStore<EventModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "EventModifiers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr);
		NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, "_state");
		NativeMethodInfoPtr_IsPressed_Public_Boolean_Modifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_get_isShiftPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_get_isCtrlPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_get_isAltPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_get_isMetaPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_get_isCapsLockEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_get_isFunctionKeyPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_get_isNumericPressed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_SetPressed_Public_Void_Modifiers_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_Append_Private_Static_Void_byref_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, 100663341);
	}

	[CallerCount(0)]
	public unsafe bool IsPressed(Modifiers mod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mod);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPressed_Public_Boolean_Modifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void SetPressed(Modifiers modifier, bool pressed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&modifier);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pressed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPressed_Public_Void_Modifiers_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713915, RefRangeEnd = 713916, XrefRangeStart = 713915, XrefRangeEnd = 713916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251037, XrefRangeEnd = 1251042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Append(ref string str, string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Append_Private_Static_Void_byref_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		str = IL2CPP.Il2CppStringToManaged(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251127, RefRangeEnd = 1251128, XrefRangeStart = 1251042, XrefRangeEnd = 1251127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventModifiers>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
