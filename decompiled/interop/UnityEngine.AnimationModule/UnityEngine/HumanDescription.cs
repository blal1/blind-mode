using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public sealed class HumanDescription : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_human;

	private static readonly System.IntPtr NativeFieldInfoPtr_skeleton;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ArmTwist;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForeArmTwist;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpperLegTwist;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LegTwist;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ArmStretch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LegStretch;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FeetSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlobalScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RootMotionBoneName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasTranslationDoF;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasExtraRoot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SkeletonHasParents;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upperArmTwist_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_upperArmTwist_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lowerArmTwist_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lowerArmTwist_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upperLegTwist_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_upperLegTwist_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lowerLegTwist_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lowerLegTwist_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_armStretch_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_armStretch_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_legStretch_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_legStretch_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_feetSpacing_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_feetSpacing_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasTranslationDoF_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasTranslationDoF_Public_set_Void_Boolean_0;

	public unsafe Il2CppReferenceArray<HumanBone> human
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HumanBone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_human)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<SkeletonBone> skeleton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skeleton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SkeletonBone>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skeleton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_ArmTwist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ArmTwist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ArmTwist)) = value;
		}
	}

	public unsafe float m_ForeArmTwist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForeArmTwist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForeArmTwist)) = value;
		}
	}

	public unsafe float m_UpperLegTwist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpperLegTwist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpperLegTwist)) = value;
		}
	}

	public unsafe float m_LegTwist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegTwist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegTwist)) = value;
		}
	}

	public unsafe float m_ArmStretch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ArmStretch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ArmStretch)) = value;
		}
	}

	public unsafe float m_LegStretch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegStretch);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LegStretch)) = value;
		}
	}

	public unsafe float m_FeetSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FeetSpacing);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FeetSpacing)) = value;
		}
	}

	public unsafe float m_GlobalScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalScale)) = value;
		}
	}

	public unsafe string m_RootMotionBoneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootMotionBoneName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootMotionBoneName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool m_HasTranslationDoF
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasTranslationDoF);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasTranslationDoF)) = value;
		}
	}

	public unsafe bool m_HasExtraRoot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasExtraRoot);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HasExtraRoot)) = value;
		}
	}

	public unsafe bool m_SkeletonHasParents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkeletonHasParents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkeletonHasParents)) = value;
		}
	}

	public unsafe float upperArmTwist
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1153382, RefRangeEnd = 1153405, XrefRangeStart = 1153382, XrefRangeEnd = 1153405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upperArmTwist_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355316, RefRangeEnd = 355317, XrefRangeStart = 355316, XrefRangeEnd = 355317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upperArmTwist_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float lowerArmTwist
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1154286, RefRangeEnd = 1154293, XrefRangeStart = 1154286, XrefRangeEnd = 1154293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lowerArmTwist_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 355317, RefRangeEnd = 355318, XrefRangeStart = 355317, XrefRangeEnd = 355318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lowerArmTwist_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float upperLegTwist
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1154293, RefRangeEnd = 1154355, XrefRangeStart = 1154293, XrefRangeEnd = 1154355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upperLegTwist_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110624, RefRangeEnd = 110625, XrefRangeStart = 110624, XrefRangeEnd = 110625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upperLegTwist_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float lowerLegTwist
	{
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1156476, RefRangeEnd = 1156529, XrefRangeStart = 1156476, XrefRangeEnd = 1156529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lowerLegTwist_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340116, RefRangeEnd = 340118, XrefRangeStart = 340116, XrefRangeEnd = 340118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lowerLegTwist_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float armStretch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_armStretch_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_armStretch_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float legStretch
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1157013, RefRangeEnd = 1157023, XrefRangeStart = 1157013, XrefRangeEnd = 1157023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_legStretch_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_legStretch_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float feetSpacing
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1157023, RefRangeEnd = 1157048, XrefRangeStart = 1157023, XrefRangeEnd = 1157023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_feetSpacing_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_feetSpacing_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasTranslationDoF
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasTranslationDoF_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasTranslationDoF_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HumanDescription()
	{
		Il2CppClassPointerStore<HumanDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanDescription");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr);
		NativeFieldInfoPtr_human = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "human");
		NativeFieldInfoPtr_skeleton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "skeleton");
		NativeFieldInfoPtr_m_ArmTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_ArmTwist");
		NativeFieldInfoPtr_m_ForeArmTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_ForeArmTwist");
		NativeFieldInfoPtr_m_UpperLegTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_UpperLegTwist");
		NativeFieldInfoPtr_m_LegTwist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_LegTwist");
		NativeFieldInfoPtr_m_ArmStretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_ArmStretch");
		NativeFieldInfoPtr_m_LegStretch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_LegStretch");
		NativeFieldInfoPtr_m_FeetSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_FeetSpacing");
		NativeFieldInfoPtr_m_GlobalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_GlobalScale");
		NativeFieldInfoPtr_m_RootMotionBoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_RootMotionBoneName");
		NativeFieldInfoPtr_m_HasTranslationDoF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_HasTranslationDoF");
		NativeFieldInfoPtr_m_HasExtraRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_HasExtraRoot");
		NativeFieldInfoPtr_m_SkeletonHasParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, "m_SkeletonHasParents");
		NativeMethodInfoPtr_get_upperArmTwist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_set_upperArmTwist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_get_lowerArmTwist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_set_lowerArmTwist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_get_upperLegTwist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr_set_upperLegTwist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664104);
		NativeMethodInfoPtr_get_lowerLegTwist_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664105);
		NativeMethodInfoPtr_set_lowerLegTwist_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664106);
		NativeMethodInfoPtr_get_armStretch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664107);
		NativeMethodInfoPtr_set_armStretch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664108);
		NativeMethodInfoPtr_get_legStretch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664109);
		NativeMethodInfoPtr_set_legStretch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664110);
		NativeMethodInfoPtr_get_feetSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_set_feetSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_get_hasTranslationDoF_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr_set_hasTranslationDoF_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr, 100664114);
	}

	public HumanDescription(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HumanDescription()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanDescription>.NativeClassPtr))
	{
	}
}
