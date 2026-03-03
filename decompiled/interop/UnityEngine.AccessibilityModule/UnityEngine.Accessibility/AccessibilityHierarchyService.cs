using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Accessibility;

public class AccessibilityHierarchyService : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hierarchy_Internal_get_AccessibilityHierarchy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveActiveHierarchy_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNode_Internal_Boolean_Int32_byref_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRootNodes_Internal_List_1_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetNodeAt_Internal_Boolean_Single_Single_byref_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AccessibilityHierarchy m_Hierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityHierarchy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe AccessibilityHierarchy hierarchy
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hierarchy_Internal_get_AccessibilityHierarchy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityHierarchy>(intPtr2) : null;
		}
		set
		{
			if (value == null)
			{
				RemoveActiveHierarchy(notifyScreenChanged: true);
				return;
			}
			RemoveActiveHierarchy(notifyScreenChanged: false);
			m_Hierarchy = value;
			m_Hierarchy.AllocateNative();
			AssistiveSupport.notificationDispatcher.SendScreenChanged();
		}
	}

	static AccessibilityHierarchyService()
	{
		Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityHierarchyService");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr);
		NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, "m_Hierarchy");
		NativeMethodInfoPtr_get_hierarchy_Internal_get_AccessibilityHierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_RemoveActiveHierarchy_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_TryGetNode_Internal_Boolean_Int32_byref_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_GetRootNodes_Internal_List_1_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_TryGetNodeAt_Internal_Boolean_Single_Single_byref_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr, 100663434);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148165, XrefRangeEnd = 1148177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148177, XrefRangeEnd = 1148189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveActiveHierarchy(bool notifyScreenChanged)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&notifyScreenChanged);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveActiveHierarchy_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148189, XrefRangeEnd = 1148190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetNode(int id, out AccessibilityNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetNode_Internal_Boolean_Int32_byref_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		node = ((num3 == 0) ? null : new AccessibilityNode(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe List<AccessibilityNode> GetRootNodes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRootNodes_Internal_List_1_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AccessibilityNode>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148190, XrefRangeEnd = 1148194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetNodeAt(float x, float y, out AccessibilityNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetNodeAt_Internal_Boolean_Single_Single_byref_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		node = ((num3 == 0) ? null : new AccessibilityNode(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AccessibilityHierarchyService()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessibilityHierarchyService>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AccessibilityHierarchyService(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
