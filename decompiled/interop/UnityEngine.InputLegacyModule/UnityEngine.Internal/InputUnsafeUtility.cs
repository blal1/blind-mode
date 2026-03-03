using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Internal;

public static class InputUnsafeUtility : Il2CppSystem.Object
{
	private delegate bool GetKeyString_InjectedDelegate(System.IntPtr name);

	private delegate bool GetKeyUpString_InjectedDelegate(System.IntPtr name);

	private delegate bool GetKeyDownString_InjectedDelegate(System.IntPtr name);

	private delegate bool GetButtonUp_InjectedDelegate(System.IntPtr buttonName);

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyUpString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeyDownString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Internal_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Internal_Static_Single_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Internal_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButton__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Internal_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown__Unmanaged_Internal_Static_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonUp__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxis_Injected_Private_Static_Single_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisRaw_Injected_Private_Static_Single_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0;

	private static readonly GetKeyString_InjectedDelegate GetKeyString_InjectedDelegateField;

	private static readonly GetKeyUpString_InjectedDelegate GetKeyUpString_InjectedDelegateField;

	private static readonly GetKeyDownString_InjectedDelegate GetKeyDownString_InjectedDelegateField;

	private static readonly GetButtonUp_InjectedDelegate GetButtonUp_InjectedDelegateField;

	static InputUnsafeUtility()
	{
		Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine.Internal", "InputUnsafeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr);
		NativeMethodInfoPtr_GetKeyString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_GetKeyUpString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_GetKeyDownString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_GetAxis_Internal_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_GetAxis__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_GetAxisRaw_Internal_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_GetAxisRaw__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_GetButton_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_GetButton__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_GetButtonDown_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_GetButtonDown__Unmanaged_Internal_Static_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_GetButtonUp__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_GetAxis_Injected_Private_Static_Single_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_GetAxisRaw_Injected_Private_Static_Single_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_GetButton_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_GetButtonDown_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputUnsafeUtility>.NativeClassPtr, 100663380);
		GetKeyString_InjectedDelegateField = IL2CPP.ResolveICall<GetKeyString_InjectedDelegate>("UnityEngine.Internal.InputUnsafeUtility::GetKeyString_Injected");
		GetKeyUpString_InjectedDelegateField = IL2CPP.ResolveICall<GetKeyUpString_InjectedDelegate>("UnityEngine.Internal.InputUnsafeUtility::GetKeyUpString_Injected");
		GetKeyDownString_InjectedDelegateField = IL2CPP.ResolveICall<GetKeyDownString_InjectedDelegate>("UnityEngine.Internal.InputUnsafeUtility::GetKeyDownString_Injected");
		GetButtonUp_InjectedDelegateField = IL2CPP.ResolveICall<GetButtonUp_InjectedDelegate>("UnityEngine.Internal.InputUnsafeUtility::GetButtonUp_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253075, XrefRangeEnd = 1253077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyString__Unmanaged(byte* name, int nameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253077, XrefRangeEnd = 1253079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyUpString__Unmanaged(byte* name, int nameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyUpString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253079, XrefRangeEnd = 1253081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetKeyDownString__Unmanaged(byte* name, int nameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)name;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeyDownString__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253095, RefRangeEnd = 1253096, XrefRangeStart = 1253081, XrefRangeEnd = 1253095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxis(string axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxis_Internal_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253096, XrefRangeEnd = 1253098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxis__Unmanaged(byte* axisName, int axisNameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)axisName;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisNameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxis__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253112, RefRangeEnd = 1253113, XrefRangeStart = 1253098, XrefRangeEnd = 1253112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxisRaw(string axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisRaw_Internal_Static_Single_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253113, XrefRangeEnd = 1253115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)axisName;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axisNameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisRaw__Unmanaged_Internal_Static_Single_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253129, RefRangeEnd = 1253130, XrefRangeStart = 1253115, XrefRangeEnd = 1253129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButton(string buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButton_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253130, XrefRangeEnd = 1253132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buttonName;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonNameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButton__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253146, RefRangeEnd = 1253147, XrefRangeStart = 1253132, XrefRangeEnd = 1253146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButtonDown(string buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(buttonName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253147, XrefRangeEnd = 1253149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buttonName;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonNameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown__Unmanaged_Internal_Static_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253149, XrefRangeEnd = 1253151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)buttonName;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buttonNameLen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonUp__Unmanaged_Internal_Static_Boolean_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253151, XrefRangeEnd = 1253153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxis_Injected(ref ManagedSpanWrapper axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxis_Injected_Private_Static_Single_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253153, XrefRangeEnd = 1253155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref axisName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAxisRaw_Injected_Private_Static_Single_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253155, XrefRangeEnd = 1253157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButton_Injected(ref ManagedSpanWrapper buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref buttonName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButton_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253157, XrefRangeEnd = 1253159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref buttonName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetButtonDown_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InputUnsafeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static bool GetKeyString(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetKeyString_Injected(ref managedSpanWrapper);
				}
			}
			return GetKeyString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static bool GetKeyUpString(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetKeyUpString_Injected(ref managedSpanWrapper);
				}
			}
			return GetKeyUpString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static bool GetKeyDownString(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetKeyDownString_Injected(ref managedSpanWrapper);
				}
			}
			return GetKeyDownString_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static bool GetButtonUp(string buttonName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(buttonName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(buttonName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetButtonUp_Injected(ref managedSpanWrapper);
				}
			}
			return GetButtonUp_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static bool GetKeyString_Injected(ref ManagedSpanWrapper name)
	{
		return GetKeyString_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static bool GetKeyUpString_Injected(ref ManagedSpanWrapper name)
	{
		return GetKeyUpString_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static bool GetKeyDownString_Injected(ref ManagedSpanWrapper name)
	{
		return GetKeyDownString_InjectedDelegateField((nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static bool GetButtonUp_Injected(ref ManagedSpanWrapper buttonName)
	{
		return GetButtonUp_InjectedDelegateField((nint)Unsafe.AsPointer(ref buttonName));
	}
}
