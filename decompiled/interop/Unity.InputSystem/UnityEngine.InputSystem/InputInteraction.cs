using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public static class InputInteraction : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Interactions;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueType_Public_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayName_Public_Static_String_Type_0;

	public unsafe static TypeTable s_Interactions
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TypeTable>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Interactions, (void*)intPtr);
			return new TypeTable(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypeTable>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Interactions, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	static InputInteraction()
	{
		Il2CppClassPointerStore<InputInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputInteraction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputInteraction>.NativeClassPtr);
		NativeFieldInfoPtr_s_Interactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputInteraction>.NativeClassPtr, "s_Interactions");
		NativeMethodInfoPtr_GetValueType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputInteraction>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_GetDisplayName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputInteraction>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_GetDisplayName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputInteraction>.NativeClassPtr, 100663601);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963558, XrefRangeEnd = 963573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetValueType(Il2CppSystem.Type interactionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueType_Public_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 963581, RefRangeEnd = 963582, XrefRangeStart = 963573, XrefRangeEnd = 963581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDisplayName(string interaction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(interaction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplayName_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 963600, RefRangeEnd = 963601, XrefRangeStart = 963582, XrefRangeEnd = 963600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDisplayName(Il2CppSystem.Type interactionType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)interactionType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplayName_Public_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public InputInteraction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
