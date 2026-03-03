using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem;

public static class InputExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsInProgress_Public_Static_Boolean_InputActionPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEndedOrCanceled_Public_Static_Boolean_TouchPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActive_Public_Static_Boolean_TouchPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsModifierKey_Public_Static_Boolean_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTextInputKey_Public_Static_Boolean_Key_0;

	static InputExtensions()
	{
		Il2CppClassPointerStore<InputExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_IsInProgress_Public_Static_Boolean_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputExtensions>.NativeClassPtr, 100665933);
		NativeMethodInfoPtr_IsEndedOrCanceled_Public_Static_Boolean_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputExtensions>.NativeClassPtr, 100665934);
		NativeMethodInfoPtr_IsActive_Public_Static_Boolean_TouchPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputExtensions>.NativeClassPtr, 100665935);
		NativeMethodInfoPtr_IsModifierKey_Public_Static_Boolean_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputExtensions>.NativeClassPtr, 100665936);
		NativeMethodInfoPtr_IsTextInputKey_Public_Static_Boolean_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputExtensions>.NativeClassPtr, 100665937);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 345756, RefRangeEnd = 345770, XrefRangeStart = 345756, XrefRangeEnd = 345770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInProgress(this InputActionPhase phase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&phase);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInProgress_Public_Static_Boolean_InputActionPhase_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 993629, RefRangeEnd = 993632, XrefRangeStart = 993629, XrefRangeEnd = 993629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEndedOrCanceled(this TouchPhase phase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&phase);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEndedOrCanceled_Public_Static_Boolean_TouchPhase_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsActive(this TouchPhase phase)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&phase);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActive_Public_Static_Boolean_TouchPhase_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsModifierKey(this Key key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsModifierKey_Public_Static_Boolean_Key_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsTextInputKey(this Key key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTextInputKey_Public_Static_Boolean_Key_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
