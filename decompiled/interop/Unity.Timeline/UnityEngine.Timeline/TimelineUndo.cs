using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.Timeline;

public static class TimelineUndo : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_undoEnabled_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushDestroyUndo_Public_Static_Void_TimelineAsset_Object_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushUndo_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushUndo_Public_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCreatedObjectUndo_Public_Static_Void_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UndoName_Internal_Static_String_String_0;

	public unsafe static bool undoEnabled
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_undoEnabled_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TimelineUndo()
	{
		Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimelineUndo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr);
		NativeMethodInfoPtr_get_undoEnabled_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_PushDestroyUndo_Public_Static_Void_TimelineAsset_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_PushUndo_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_PushUndo_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664168);
		NativeMethodInfoPtr_RegisterCreatedObjectUndo_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_UndoName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineUndo>.NativeClassPtr, 100664170);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1142272, RefRangeEnd = 1142284, XrefRangeStart = 1142265, XrefRangeEnd = 1142272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timeline);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thingToDirty);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectToDestroy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushDestroyUndo_Public_Static_Void_TimelineAsset_Object_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushUndo(Il2CppReferenceArray<Object> thingsToDirty, string operation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thingsToDirty);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(operation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushUndo_Public_Static_Void_Il2CppReferenceArray_1_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushUndo(Object thingToDirty, string operation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thingToDirty);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(operation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushUndo_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterCreatedObjectUndo(Object thingCreated, string operation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)thingCreated);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(operation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCreatedObjectUndo_Public_Static_Void_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142284, XrefRangeEnd = 1142287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string UndoName(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoName_Internal_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public TimelineUndo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
