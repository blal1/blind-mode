using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Animations;

public sealed class AimConstraint : Behaviour
{
	[OriginalName("UnityEngine.AnimationModule.dll", "", "WorldUpType")]
	public enum WorldUpType
	{
		SceneUp,
		ObjectUp,
		ObjectRotationUp,
		Vector,
		None
	}

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_AimConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAtRest_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAtRest_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationOffset_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationOffset_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAxis_Public_get_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAxis_Public_set_Void_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_aimVector_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_aimVector_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_upVector_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_upVector_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldUpVector_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldUpVector_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldUpObject_Public_get_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldUpObject_Public_set_Void_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldUpType_Public_get_WorldUpType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldUpType_Public_set_Void_WorldUpType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_AimConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_AimConstraint_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddSource_Public_Virtual_Final_New_Int32_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveSourceInternal_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSource_Public_Virtual_Final_New_ConstraintSource_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSourceInternal_Private_ConstraintSource_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Virtual_Final_New_Void_Int32_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourceInternal_Private_Void_Int32_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidateSourceIndex_Private_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_weight_Injected_Private_Static_Single_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_weight_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_constraintActive_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_constraintActive_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_locked_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_locked_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAxis_Injected_Private_Static_Axis_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAxis_Injected_Private_Static_Void_IntPtr_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_aimVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_aimVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_upVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_upVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldUpVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldUpVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldUpObject_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldUpObject_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_worldUpType_Injected_Private_Static_WorldUpType_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_worldUpType_Injected_Private_Static_Void_IntPtr_WorldUpType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSourceCountInternal_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSources_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourcesInternal_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddSource_Injected_Private_Static_Int32_IntPtr_byref_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0;

	public unsafe virtual float weight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157771, XrefRangeEnd = 1157776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157776, XrefRangeEnd = 1157781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual bool constraintActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157781, XrefRangeEnd = 1157786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157786, XrefRangeEnd = 1157791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual bool locked
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157791, XrefRangeEnd = 1157796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157796, XrefRangeEnd = 1157801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 rotationAtRest
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157801, XrefRangeEnd = 1157805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationAtRest_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157805, XrefRangeEnd = 1157809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationAtRest_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 rotationOffset
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157809, XrefRangeEnd = 1157813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157813, XrefRangeEnd = 1157817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Axis rotationAxis
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157817, XrefRangeEnd = 1157822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Axis*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157822, XrefRangeEnd = 1157827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 aimVector
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157827, XrefRangeEnd = 1157831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aimVector_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157831, XrefRangeEnd = 1157835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aimVector_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 upVector
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157835, XrefRangeEnd = 1157839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upVector_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157839, XrefRangeEnd = 1157843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upVector_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 worldUpVector
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157843, XrefRangeEnd = 1157847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldUpVector_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157847, XrefRangeEnd = 1157851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldUpVector_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Transform worldUpObject
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157851, XrefRangeEnd = 1157859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldUpObject_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157859, XrefRangeEnd = 1157867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldUpObject_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe WorldUpType worldUpType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157867, XrefRangeEnd = 1157872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldUpType_Public_get_WorldUpType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(WorldUpType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157872, XrefRangeEnd = 1157877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldUpType_Public_set_Void_WorldUpType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual int sourceCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157877, XrefRangeEnd = 1157886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AimConstraint()
	{
		Il2CppClassPointerStore<AimConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AimConstraint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_AimConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664264);
		NativeMethodInfoPtr_get_rotationAtRest_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664265);
		NativeMethodInfoPtr_set_rotationAtRest_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664266);
		NativeMethodInfoPtr_get_rotationOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664267);
		NativeMethodInfoPtr_set_rotationOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664268);
		NativeMethodInfoPtr_get_rotationAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664269);
		NativeMethodInfoPtr_set_rotationAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664270);
		NativeMethodInfoPtr_get_aimVector_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664271);
		NativeMethodInfoPtr_set_aimVector_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664272);
		NativeMethodInfoPtr_get_upVector_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664273);
		NativeMethodInfoPtr_set_upVector_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664274);
		NativeMethodInfoPtr_get_worldUpVector_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664275);
		NativeMethodInfoPtr_set_worldUpVector_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664276);
		NativeMethodInfoPtr_get_worldUpObject_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664277);
		NativeMethodInfoPtr_set_worldUpObject_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664278);
		NativeMethodInfoPtr_get_worldUpType_Public_get_WorldUpType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664279);
		NativeMethodInfoPtr_set_worldUpType_Public_set_Void_WorldUpType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664280);
		NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664281);
		NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_AimConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664282);
		NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664283);
		NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664284);
		NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_AimConstraint_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664285);
		NativeMethodInfoPtr_AddSource_Public_Virtual_Final_New_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664286);
		NativeMethodInfoPtr_RemoveSource_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664287);
		NativeMethodInfoPtr_RemoveSourceInternal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664288);
		NativeMethodInfoPtr_GetSource_Public_Virtual_Final_New_ConstraintSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664289);
		NativeMethodInfoPtr_GetSourceInternal_Private_ConstraintSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664290);
		NativeMethodInfoPtr_SetSource_Public_Virtual_Final_New_Void_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664291);
		NativeMethodInfoPtr_SetSourceInternal_Private_Void_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664292);
		NativeMethodInfoPtr_ValidateSourceIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664293);
		NativeMethodInfoPtr_get_weight_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664294);
		NativeMethodInfoPtr_set_weight_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664295);
		NativeMethodInfoPtr_get_constraintActive_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664296);
		NativeMethodInfoPtr_set_constraintActive_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664297);
		NativeMethodInfoPtr_get_locked_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664298);
		NativeMethodInfoPtr_set_locked_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664299);
		NativeMethodInfoPtr_get_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664300);
		NativeMethodInfoPtr_set_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664301);
		NativeMethodInfoPtr_get_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664302);
		NativeMethodInfoPtr_set_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664303);
		NativeMethodInfoPtr_get_rotationAxis_Injected_Private_Static_Axis_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664304);
		NativeMethodInfoPtr_set_rotationAxis_Injected_Private_Static_Void_IntPtr_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664305);
		NativeMethodInfoPtr_get_aimVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664306);
		NativeMethodInfoPtr_set_aimVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664307);
		NativeMethodInfoPtr_get_upVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664308);
		NativeMethodInfoPtr_set_upVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664309);
		NativeMethodInfoPtr_get_worldUpVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664310);
		NativeMethodInfoPtr_set_worldUpVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664311);
		NativeMethodInfoPtr_get_worldUpObject_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664312);
		NativeMethodInfoPtr_set_worldUpObject_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664313);
		NativeMethodInfoPtr_get_worldUpType_Injected_Private_Static_WorldUpType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664314);
		NativeMethodInfoPtr_set_worldUpType_Injected_Private_Static_Void_IntPtr_WorldUpType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664315);
		NativeMethodInfoPtr_GetSourceCountInternal_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664316);
		NativeMethodInfoPtr_GetSources_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664317);
		NativeMethodInfoPtr_SetSourcesInternal_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664318);
		NativeMethodInfoPtr_AddSource_Injected_Private_Static_Int32_IntPtr_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_RemoveSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_GetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_SetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr, 100664322);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157766, XrefRangeEnd = 1157769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AimConstraint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AimConstraint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157769, XrefRangeEnd = 1157771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(AimConstraint self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_AimConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSourceCountInternal(AimConstraint self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_AimConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157886, XrefRangeEnd = 1157894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void GetSources(List<ConstraintSource> sources)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157894, XrefRangeEnd = 1157909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetSources(List<ConstraintSource> sources)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157909, XrefRangeEnd = 1157918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourcesInternal(AimConstraint self, List<ConstraintSource> sources)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_AimConstraint_List_1_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157918, XrefRangeEnd = 1157922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int AddSource(ConstraintSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source));
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSource_Public_Virtual_Final_New_Int32_ConstraintSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157922, XrefRangeEnd = 1157928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void RemoveSource(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSource_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157928, XrefRangeEnd = 1157933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSourceInternal(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSourceInternal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157933, XrefRangeEnd = 1157938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ConstraintSource GetSource(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSource_Public_Virtual_Final_New_ConstraintSource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ConstraintSource(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157938, XrefRangeEnd = 1157942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConstraintSource GetSourceInternal(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceInternal_Private_ConstraintSource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ConstraintSource(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157942, XrefRangeEnd = 1157947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetSource(int index, ConstraintSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&index);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source));
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSource_Public_Virtual_Final_New_Void_Int32_ConstraintSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157947, XrefRangeEnd = 1157951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSourceInternal(int index, ConstraintSource source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&index);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source));
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourceInternal_Private_Void_Int32_ConstraintSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1157963, RefRangeEnd = 1157966, XrefRangeStart = 1157951, XrefRangeEnd = 1157963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateSourceIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateSourceIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157966, XrefRangeEnd = 1157968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_weight_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_weight_Injected_Private_Static_Single_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157968, XrefRangeEnd = 1157970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_weight_Injected(IntPtr _unity_self, float value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_weight_Injected_Private_Static_Void_IntPtr_Single_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157970, XrefRangeEnd = 1157972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_constraintActive_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_constraintActive_Injected_Private_Static_Boolean_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157972, XrefRangeEnd = 1157974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_constraintActive_Injected(IntPtr _unity_self, bool value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_constraintActive_Injected_Private_Static_Void_IntPtr_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157974, XrefRangeEnd = 1157976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_locked_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_locked_Injected_Private_Static_Boolean_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157976, XrefRangeEnd = 1157978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_locked_Injected(IntPtr _unity_self, bool value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_locked_Injected_Private_Static_Void_IntPtr_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157978, XrefRangeEnd = 1157980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rotationAtRest_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157980, XrefRangeEnd = 1157982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rotationAtRest_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157982, XrefRangeEnd = 1157984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rotationOffset_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157984, XrefRangeEnd = 1157986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rotationOffset_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157986, XrefRangeEnd = 1157988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Axis get_rotationAxis_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationAxis_Injected_Private_Static_Axis_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Axis*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157988, XrefRangeEnd = 1157990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rotationAxis_Injected(IntPtr _unity_self, Axis value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(Axis**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotationAxis_Injected_Private_Static_Void_IntPtr_Axis_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157990, XrefRangeEnd = 1157992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_aimVector_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aimVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157992, XrefRangeEnd = 1157994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_aimVector_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_aimVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157994, XrefRangeEnd = 1157996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_upVector_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157996, XrefRangeEnd = 1157998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_upVector_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_upVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157998, XrefRangeEnd = 1158000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_worldUpVector_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldUpVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158000, XrefRangeEnd = 1158002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_worldUpVector_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldUpVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158002, XrefRangeEnd = 1158004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr get_worldUpObject_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldUpObject_Injected_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158004, XrefRangeEnd = 1158006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_worldUpObject_Injected(IntPtr _unity_self, IntPtr value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldUpObject_Injected_Private_Static_Void_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158006, XrefRangeEnd = 1158008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static WorldUpType get_worldUpType_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldUpType_Injected_Private_Static_WorldUpType_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(WorldUpType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158008, XrefRangeEnd = 1158010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_worldUpType_Injected(IntPtr _unity_self, WorldUpType value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(WorldUpType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_worldUpType_Injected_Private_Static_Void_IntPtr_WorldUpType_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158010, XrefRangeEnd = 1158012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSourceCountInternal_Injected(IntPtr self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceCountInternal_Injected_Private_Static_Int32_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158012, XrefRangeEnd = 1158014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSources_Injected(IntPtr _unity_self, List<ConstraintSource> sources)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSources_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158014, XrefRangeEnd = 1158016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourcesInternal_Injected(IntPtr self, List<ConstraintSource> sources)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourcesInternal_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158016, XrefRangeEnd = 1158018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddSource_Injected(IntPtr _unity_self, [In] ref ConstraintSource source)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddSource_Injected_Private_Static_Int32_IntPtr_byref_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158018, XrefRangeEnd = 1158020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveSourceInternal_Injected(IntPtr _unity_self, int index)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158020, XrefRangeEnd = 1158022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSourceInternal_Injected(IntPtr _unity_self, int index, out ConstraintSource ret)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		ret = ((num3 == 0) ? null : new ConstraintSource(num3));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158022, XrefRangeEnd = 1158024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourceInternal_Injected(IntPtr _unity_self, int index, [In] ref ConstraintSource source)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AimConstraint(IntPtr pointer)
		: base(pointer)
	{
	}
}
