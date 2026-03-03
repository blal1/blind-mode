using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Hierarchy;

public sealed class HierarchyPropertyUnmanaged<T> : Il2CppSystem.ValueType where T : new()
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Property;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_byref_HierarchyPropertyId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_byref_HierarchyNode_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_T_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyPropertyUnmanaged_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unity_Hierarchy_IHierarchyProperty_T__GetValue_Private_Virtual_Final_New_T_byref_HierarchyNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unity_Hierarchy_IHierarchyProperty_T__SetValue_Private_Virtual_Final_New_Void_byref_HierarchyNode_T_0;

	public unsafe Hierarchy m_Hierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hierarchy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HierarchyPropertyId m_Property
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Property);
			return *(HierarchyPropertyId*)num;
		}
		set
		{
			*(HierarchyPropertyId*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Property)) = value;
		}
	}

	public bool IsCreated
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static HierarchyPropertyUnmanaged()
	{
		Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyPropertyUnmanaged`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr);
		NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, "m_Hierarchy");
		NativeFieldInfoPtr_m_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, "m_Property");
		NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_byref_HierarchyPropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_SetValue_Public_Void_byref_HierarchyNode_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_GetValue_Public_T_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyPropertyUnmanaged_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_Unity_Hierarchy_IHierarchyProperty_T__GetValue_Private_Virtual_Final_New_T_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_Unity_Hierarchy_IHierarchyProperty_T__SetValue_Private_Virtual_Final_New_Void_byref_HierarchyNode_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr, 100663360);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242904, RefRangeEnd = 1242905, XrefRangeStart = 1242901, XrefRangeEnd = 1242904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyPropertyUnmanaged(Hierarchy hierarchy, [In] ref HierarchyPropertyId property)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchy);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_byref_HierarchyPropertyId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242905, XrefRangeEnd = 1242907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetValue([In] ref HierarchyNode node, T value)
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_byref_HierarchyNode_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242907, XrefRangeEnd = 1242910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetValue([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_T_byref_HierarchyNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(HierarchyPropertyUnmanaged<T> other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)other));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyPropertyUnmanaged_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242910, XrefRangeEnd = 1242911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242911, XrefRangeEnd = 1242918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242918, XrefRangeEnd = 1242935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242935, XrefRangeEnd = 1242942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual T Unity_Hierarchy_IHierarchyProperty_T__GetValue([In] ref HierarchyNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unity_Hierarchy_IHierarchyProperty_T__GetValue_Private_Virtual_Final_New_T_byref_HierarchyNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242942, XrefRangeEnd = 1242944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Unity_Hierarchy_IHierarchyProperty_T__SetValue([In] ref HierarchyNode node, T value)
	{
		//IL_005a->IL005d: Incompatible stack types: I vs Ref
		//IL_004d->IL005d: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref node);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unity_Hierarchy_IHierarchyProperty_T__SetValue_Private_Virtual_Final_New_Void_byref_HierarchyNode_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HierarchyPropertyUnmanaged(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HierarchyPropertyUnmanaged()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyPropertyUnmanaged<T>>.NativeClassPtr))
	{
	}

	public void ClearValue([In] ref HierarchyNode node)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator ==([In] ref HierarchyPropertyUnmanaged<T> lhs, [In] ref HierarchyPropertyUnmanaged<T> rhs)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool operator !=([In] ref HierarchyPropertyUnmanaged<T> lhs, [In] ref HierarchyPropertyUnmanaged<T> rhs)
	{
		return !((ref lhs) == (ref rhs));
	}

	public T Unity_002EHierarchy_002EIHierarchyProperty_003CT_003E_002EGetValue([In] ref HierarchyNode node)
	{
		return GetValue(ref node);
	}

	public void Unity_002EHierarchy_002EIHierarchyProperty_003CT_003E_002ESetValue([In] ref HierarchyNode node, T value)
	{
		SetValue(ref node, value);
	}

	public void Unity_002EHierarchy_002EIHierarchyProperty_003CT_003E_002EClearValue([In] ref HierarchyNode node)
	{
		ClearValue(ref node);
	}
}
