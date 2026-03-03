using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Accessibility;

public static class AccessibilityNodeManager : Il2CppSystem.Object
{
	private delegate bool CreateNativeNodeDelegate(int id);

	private delegate void SetIsActiveDelegate(int id, bool isActive);

	private delegate void SetRoleDelegate(int id, AccessibilityRole role);

	private delegate void SetAllowsDirectInteractionDelegate(int id, bool allows);

	private delegate void SetStateDelegate(int id, AccessibilityState state);

	private delegate void SetParentDelegate(int id, int parentId, int index);

	private delegate bool GetIsFocusedDelegate(int id);

	private delegate void SetLanguageDelegate(int id, SystemLanguage language);

	private delegate bool CreateNativeNodeWithData_InjectedDelegate([In] System.IntPtr nodeData);

	private delegate void SetNodeData_InjectedDelegate(int id, [In] System.IntPtr nodeData);

	private delegate void SetLabel_InjectedDelegate(int id, System.IntPtr label);

	private delegate void SetValue_InjectedDelegate(int id, System.IntPtr value);

	private delegate void SetHint_InjectedDelegate(int id, System.IntPtr hint);

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyNativeNode_Internal_Static_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFrame_Internal_Static_Void_Int32_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChildren_Internal_Static_Void_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActions_Internal_Static_Void_Int32_Il2CppReferenceArray_1_AccessibilityAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InvokeFocusChanged_Internal_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InvokeSelected_Internal_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InvokeIncremented_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InvokeDecremented_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InvokeDismissed_Internal_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFrame_Injected_Private_Static_Void_Int32_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChildren_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;

	public const int k_InvalidNodeId = -1;

	private static readonly CreateNativeNodeDelegate CreateNativeNodeDelegateField;

	private static readonly SetIsActiveDelegate SetIsActiveDelegateField;

	private static readonly SetRoleDelegate SetRoleDelegateField;

	private static readonly SetAllowsDirectInteractionDelegate SetAllowsDirectInteractionDelegateField;

	private static readonly SetStateDelegate SetStateDelegateField;

	private static readonly SetParentDelegate SetParentDelegateField;

	private static readonly GetIsFocusedDelegate GetIsFocusedDelegateField;

	private static readonly SetLanguageDelegate SetLanguageDelegateField;

	private static readonly CreateNativeNodeWithData_InjectedDelegate CreateNativeNodeWithData_InjectedDelegateField;

	private static readonly SetNodeData_InjectedDelegate SetNodeData_InjectedDelegateField;

	private static readonly SetLabel_InjectedDelegate SetLabel_InjectedDelegateField;

	private static readonly SetValue_InjectedDelegate SetValue_InjectedDelegateField;

	private static readonly SetHint_InjectedDelegate SetHint_InjectedDelegateField;

	static AccessibilityNodeManager()
	{
		Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityNodeManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr);
		NativeMethodInfoPtr_DestroyNativeNode_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_SetFrame_Internal_Static_Void_Int32_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_SetChildren_Internal_Static_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_SetActions_Internal_Static_Void_Int32_Il2CppReferenceArray_1_AccessibilityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_Internal_InvokeFocusChanged_Internal_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_Internal_InvokeSelected_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_Internal_InvokeIncremented_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_Internal_InvokeDecremented_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_Internal_InvokeDismissed_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_SetFrame_Injected_Private_Static_Void_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_SetChildren_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeManager>.NativeClassPtr, 100663364);
		CreateNativeNodeDelegateField = IL2CPP.ResolveICall<CreateNativeNodeDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::CreateNativeNode");
		SetIsActiveDelegateField = IL2CPP.ResolveICall<SetIsActiveDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetIsActive");
		SetRoleDelegateField = IL2CPP.ResolveICall<SetRoleDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetRole");
		SetAllowsDirectInteractionDelegateField = IL2CPP.ResolveICall<SetAllowsDirectInteractionDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetAllowsDirectInteraction");
		SetStateDelegateField = IL2CPP.ResolveICall<SetStateDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetState");
		SetParentDelegateField = IL2CPP.ResolveICall<SetParentDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetParent");
		GetIsFocusedDelegateField = IL2CPP.ResolveICall<GetIsFocusedDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::GetIsFocused");
		SetLanguageDelegateField = IL2CPP.ResolveICall<SetLanguageDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetLanguage");
		CreateNativeNodeWithData_InjectedDelegateField = IL2CPP.ResolveICall<CreateNativeNodeWithData_InjectedDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::CreateNativeNodeWithData_Injected");
		SetNodeData_InjectedDelegateField = IL2CPP.ResolveICall<SetNodeData_InjectedDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetNodeData_Injected");
		SetLabel_InjectedDelegateField = IL2CPP.ResolveICall<SetLabel_InjectedDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetLabel_Injected");
		SetValue_InjectedDelegateField = IL2CPP.ResolveICall<SetValue_InjectedDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetValue_Injected");
		SetHint_InjectedDelegateField = IL2CPP.ResolveICall<SetHint_InjectedDelegate>("UnityEngine.Accessibility.AccessibilityNodeManager::SetHint_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147732, XrefRangeEnd = 1147734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyNativeNode(int id, int parentId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyNativeNode_Internal_Static_Void_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147734, XrefRangeEnd = 1147736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFrame(int id, Rect frame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrame_Internal_Static_Void_Int32_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147736, XrefRangeEnd = 1147745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetChildren(int id, Il2CppStructArray<int> childIds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)childIds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChildren_Internal_Static_Void_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147745, XrefRangeEnd = 1147747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActions(int id, Il2CppReferenceArray<AccessibilityAction> actions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)actions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActions_Internal_Static_Void_Int32_Il2CppReferenceArray_1_AccessibilityAction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147747, XrefRangeEnd = 1147760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_InvokeFocusChanged(int id, bool isNodeFocused)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isNodeFocused;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InvokeFocusChanged_Internal_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147760, XrefRangeEnd = 1147768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_InvokeSelected(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InvokeSelected_Internal_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147768, XrefRangeEnd = 1147776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_InvokeIncremented(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InvokeIncremented_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147776, XrefRangeEnd = 1147784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_InvokeDecremented(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InvokeDecremented_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147784, XrefRangeEnd = 1147792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_InvokeDismissed(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InvokeDismissed_Internal_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147792, XrefRangeEnd = 1147794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFrame_Injected(int id, [In] ref Rect frame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref frame);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrame_Injected_Private_Static_Void_Int32_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1147794, XrefRangeEnd = 1147796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetChildren_Injected(int id, ref ManagedSpanWrapper childIds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref childIds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChildren_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AccessibilityNodeManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool CreateNativeNode(int id)
	{
		return CreateNativeNodeDelegateField(id);
	}

	public static bool CreateNativeNodeWithData(AccessibilityNodeData nodeData)
	{
		return CreateNativeNodeWithData_Injected(ref nodeData);
	}

	public static void SetNodeData(int id, AccessibilityNodeData nodeData)
	{
		SetNodeData_Injected(id, ref nodeData);
	}

	public static void SetIsActive(int id, bool isActive)
	{
		SetIsActiveDelegateField(id, isActive);
	}

	public unsafe static void SetLabel(int id, string label)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(label, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(label);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetLabel_Injected(id, ref managedSpanWrapper);
					return;
				}
			}
			SetLabel_Injected(id, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void SetValue(int id, string value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetValue_Injected(id, ref managedSpanWrapper);
					return;
				}
			}
			SetValue_Injected(id, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void SetHint(int id, string hint)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(hint, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(hint);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetHint_Injected(id, ref managedSpanWrapper);
					return;
				}
			}
			SetHint_Injected(id, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void SetRole(int id, AccessibilityRole role)
	{
		SetRoleDelegateField(id, role);
	}

	public static void SetAllowsDirectInteraction(int id, bool allows)
	{
		SetAllowsDirectInteractionDelegateField(id, allows);
	}

	public static void SetState(int id, AccessibilityState state)
	{
		SetStateDelegateField(id, state);
	}

	public static void SetParent(int id, int parentId, [Optional] int index)
	{
		SetParentDelegateField(id, parentId, index);
	}

	public static bool GetIsFocused(int id)
	{
		return GetIsFocusedDelegateField(id);
	}

	public static void SetLanguage(int id, SystemLanguage language)
	{
		SetLanguageDelegateField(id, language);
	}

	public unsafe static bool CreateNativeNodeWithData_Injected([In] ref AccessibilityNodeData nodeData)
	{
		CreateNativeNodeWithData_InjectedDelegate createNativeNodeWithData_InjectedDelegateField = CreateNativeNodeWithData_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeData);
		return createNativeNodeWithData_InjectedDelegateField((nint)(&intPtr));
	}

	public unsafe static void SetNodeData_Injected(int id, [In] ref AccessibilityNodeData nodeData)
	{
		SetNodeData_InjectedDelegate setNodeData_InjectedDelegateField = SetNodeData_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nodeData);
		setNodeData_InjectedDelegateField(id, (nint)(&intPtr));
	}

	public unsafe static void SetLabel_Injected(int id, ref ManagedSpanWrapper label)
	{
		SetLabel_InjectedDelegateField(id, (nint)Unsafe.AsPointer(ref label));
	}

	public unsafe static void SetValue_Injected(int id, ref ManagedSpanWrapper value)
	{
		SetValue_InjectedDelegateField(id, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void SetHint_Injected(int id, ref ManagedSpanWrapper hint)
	{
		SetHint_InjectedDelegateField(id, (nint)Unsafe.AsPointer(ref hint));
	}
}
