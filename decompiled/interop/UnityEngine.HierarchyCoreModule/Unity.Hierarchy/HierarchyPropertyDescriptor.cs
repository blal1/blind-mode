using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Hierarchy;

[StructLayout(LayoutKind.Explicit)]
public struct HierarchyPropertyDescriptor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_HierarchyPropertyStorageType_0;

	[FieldOffset(0)]
	public int m_Size;

	[FieldOffset(4)]
	public HierarchyPropertyStorageType m_Type;

	public unsafe int Size
	{
		get
		{
			return m_Size;
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe HierarchyPropertyStorageType Type
	{
		get
		{
			return m_Type;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Type_Public_set_Void_HierarchyPropertyStorageType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HierarchyPropertyDescriptor()
	{
		Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyPropertyDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr, "m_Size");
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr, "m_Type");
		NativeMethodInfoPtr_set_Size_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_set_Type_Public_set_Void_HierarchyPropertyStorageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr, 100663491);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HierarchyPropertyDescriptor>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
