using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.LowLevel;

public class PlayerLoop : Il2CppSystem.Object
{
	private delegate System.IntPtr GetDefaultPlayerLoopInternalDelegate();

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0;

	private static readonly GetDefaultPlayerLoopInternalDelegate GetDefaultPlayerLoopInternalDelegateField;

	static PlayerLoop()
	{
		Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr);
		NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100667286);
		NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100667287);
		NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100667288);
		NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100667289);
		NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100667290);
		NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100667291);
		GetDefaultPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<GetDefaultPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1228611, RefRangeEnd = 1228613, XrefRangeStart = 1228608, XrefRangeEnd = 1228611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerLoopSystem GetCurrentPlayerLoop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayerLoopSystem(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1228625, RefRangeEnd = 1228627, XrefRangeStart = 1228613, XrefRangeEnd = 1228625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlayerLoop(PlayerLoopSystem loop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)loop));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1228641, RefRangeEnd = 1228643, XrefRangeStart = 1228627, XrefRangeEnd = 1228641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sys));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalSys);
		*(System.IntPtr**)num = &intPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		internalSys = ((intPtr4 == (System.IntPtr)0) ? null : new List<PlayerLoopSystemInternal>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1228663, RefRangeEnd = 1228665, XrefRangeStart = 1228643, XrefRangeEnd = 1228663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayerLoopSystem InternalToPlayerLoopSystem(Il2CppReferenceArray<PlayerLoopSystemInternal> internalSys, ref int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)internalSys);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new PlayerLoopSystem(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228665, XrefRangeEnd = 1228667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<PlayerLoopSystemInternal> GetCurrentPlayerLoopInternal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228667, XrefRangeEnd = 1228669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPlayerLoopInternal(Il2CppReferenceArray<PlayerLoopSystemInternal> loop)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)loop);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PlayerLoop(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static PlayerLoopSystem GetDefaultPlayerLoop()
	{
		Il2CppReferenceArray<PlayerLoopSystemInternal> defaultPlayerLoopInternal = GetDefaultPlayerLoopInternal();
		int offset = 0;
		return InternalToPlayerLoopSystem(defaultPlayerLoopInternal, ref offset);
	}

	public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetDefaultPlayerLoopInternal()
	{
		System.IntPtr intPtr = GetDefaultPlayerLoopInternalDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(intPtr) : null;
	}
}
