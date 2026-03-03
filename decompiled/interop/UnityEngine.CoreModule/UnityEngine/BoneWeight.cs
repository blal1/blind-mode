using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct BoneWeight
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight0;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight2;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight3;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex0;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex2;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex3;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weight0_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weight1_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weight2_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_weight3_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0;

	[FieldOffset(0)]
	public float m_Weight0;

	[FieldOffset(4)]
	public float m_Weight1;

	[FieldOffset(8)]
	public float m_Weight2;

	[FieldOffset(12)]
	public float m_Weight3;

	[FieldOffset(16)]
	public int m_BoneIndex0;

	[FieldOffset(20)]
	public int m_BoneIndex1;

	[FieldOffset(24)]
	public int m_BoneIndex2;

	[FieldOffset(28)]
	public int m_BoneIndex3;

	public unsafe float weight0
	{
		[CallerCount(79)]
		[CachedScanResults(RefRangeStart = 1167165, RefRangeEnd = 1167244, XrefRangeStart = 1167165, XrefRangeEnd = 1167244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight0_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Weight0 = value;
		}
	}

	public unsafe float weight1
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 1153785, RefRangeEnd = 1153875, XrefRangeStart = 1153785, XrefRangeEnd = 1153875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight1_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Weight1 = value;
		}
	}

	public unsafe float weight2
	{
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1161205, RefRangeEnd = 1161251, XrefRangeStart = 1161205, XrefRangeEnd = 1161251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight2_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Weight2 = value;
		}
	}

	public unsafe float weight3
	{
		[CallerCount(40)]
		[CachedScanResults(RefRangeStart = 1154246, RefRangeEnd = 1154286, XrefRangeStart = 1154246, XrefRangeEnd = 1154286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight3_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Weight3 = value;
		}
	}

	public unsafe int boneIndex0
	{
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 1167244, RefRangeEnd = 1167304, XrefRangeStart = 1167244, XrefRangeEnd = 1167304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_BoneIndex0 = value;
		}
	}

	public unsafe int boneIndex1
	{
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 1165127, RefRangeEnd = 1165216, XrefRangeStart = 1165127, XrefRangeEnd = 1165216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_BoneIndex1 = value;
		}
	}

	public unsafe int boneIndex2
	{
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1156433, RefRangeEnd = 1156476, XrefRangeStart = 1156433, XrefRangeEnd = 1156476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_BoneIndex2 = value;
		}
	}

	public unsafe int boneIndex3
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1154355, RefRangeEnd = 1154368, XrefRangeStart = 1154355, XrefRangeEnd = 1154368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_BoneIndex3 = value;
		}
	}

	static BoneWeight()
	{
		Il2CppClassPointerStore<BoneWeight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoneWeight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr);
		NativeFieldInfoPtr_m_Weight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight0");
		NativeFieldInfoPtr_m_Weight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight1");
		NativeFieldInfoPtr_m_Weight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight2");
		NativeFieldInfoPtr_m_Weight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_Weight3");
		NativeFieldInfoPtr_m_BoneIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex0");
		NativeFieldInfoPtr_m_BoneIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex1");
		NativeFieldInfoPtr_m_BoneIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex2");
		NativeFieldInfoPtr_m_BoneIndex3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, "m_BoneIndex3");
		NativeMethodInfoPtr_get_weight0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_get_weight1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_get_weight2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665092);
		NativeMethodInfoPtr_get_weight3_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665093);
		NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665094);
		NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665095);
		NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665096);
		NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665097);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665098);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665099);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100665100);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179320, XrefRangeEnd = 1179328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1179328, XrefRangeEnd = 1179332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1179336, RefRangeEnd = 1179337, XrefRangeStart = 1179332, XrefRangeEnd = 1179336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(BoneWeight other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
	{
		return lhs.boneIndex0 == rhs.boneIndex0 && lhs.boneIndex1 == rhs.boneIndex1 && lhs.boneIndex2 == rhs.boneIndex2 && lhs.boneIndex3 == rhs.boneIndex3 && new Vector4(lhs.weight0, lhs.weight1, lhs.weight2, lhs.weight3) == new Vector4(rhs.weight0, rhs.weight1, rhs.weight2, rhs.weight3);
	}

	public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
	{
		return !(lhs == rhs);
	}
}
