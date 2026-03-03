using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Unity.Hierarchy;

[StructLayout(LayoutKind.Explicit)]
public struct HierarchyPropertyId
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Null;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_byref_HierarchyPropertyId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_HierarchyPropertyId_byref_HierarchyPropertyId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyPropertyId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public readonly int m_Id;

	public const int k_HierarchyPropertyIdNull = 0;

	public unsafe static HierarchyPropertyId s_Null
	{
		get
		{
			Unsafe.SkipInit(out HierarchyPropertyId result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Null, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Null, (void*)(&value));
		}
	}

	public unsafe static ref HierarchyPropertyId Null
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1243400, RefRangeEnd = 1243401, XrefRangeStart = 1243398, XrefRangeEnd = 1243400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_byref_HierarchyPropertyId_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(HierarchyPropertyId*)intPtr2;
		}
	}

	public unsafe int Id
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static HierarchyPropertyId()
	{
		Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyPropertyId");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr);
		NativeFieldInfoPtr_s_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, "s_Null");
		NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, "m_Id");
		NativeMethodInfoPtr_get_Null_Public_Static_get_byref_HierarchyPropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_HierarchyPropertyId_byref_HierarchyPropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyPropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, 100663499);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 713915, RefRangeEnd = 713916, XrefRangeStart = 713915, XrefRangeEnd = 713916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyPropertyId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1243379, RefRangeEnd = 1243381, XrefRangeStart = 1243379, XrefRangeEnd = 1243381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==([In] ref HierarchyPropertyId lhs, [In] ref HierarchyPropertyId rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref lhs);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_byref_HierarchyPropertyId_byref_HierarchyPropertyId_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(HierarchyPropertyId other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HierarchyPropertyId_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243413, RefRangeEnd = 1243414, XrefRangeStart = 1243401, XrefRangeEnd = 1243413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1243414, XrefRangeEnd = 1243417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1243397, RefRangeEnd = 1243398, XrefRangeStart = 1243397, XrefRangeEnd = 1243398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HierarchyPropertyId>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=([In] ref HierarchyPropertyId lhs, [In] ref HierarchyPropertyId rhs)
	{
		return !((ref lhs) == (ref rhs));
	}
}
