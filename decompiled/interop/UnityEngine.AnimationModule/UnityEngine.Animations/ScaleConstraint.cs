using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Animations;

public sealed class ScaleConstraint : Behaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_ScaleConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scaleAtRest_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scaleAtRest_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scaleOffset_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scaleOffset_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scalingAxis_Public_get_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scalingAxis_Public_set_Void_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_ScaleConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_ScaleConstraint_List_1_ConstraintSource_0;

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

	private static readonly IntPtr NativeMethodInfoPtr_get_scaleAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scaleAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scaleOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scaleOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_scalingAxis_Injected_Private_Static_Axis_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scalingAxis_Injected_Private_Static_Void_IntPtr_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_constraintActive_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_constraintActive_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_locked_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_locked_Injected_Private_Static_Void_IntPtr_Boolean_0;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161632, XrefRangeEnd = 1161637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161637, XrefRangeEnd = 1161642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe Vector3 scaleAtRest
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161642, XrefRangeEnd = 1161646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleAtRest_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161646, XrefRangeEnd = 1161650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleAtRest_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 scaleOffset
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161650, XrefRangeEnd = 1161654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161654, XrefRangeEnd = 1161658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleOffset_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Axis scalingAxis
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161658, XrefRangeEnd = 1161663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scalingAxis_Public_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Axis*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161663, XrefRangeEnd = 1161668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scalingAxis_Public_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual bool constraintActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161668, XrefRangeEnd = 1161673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161673, XrefRangeEnd = 1161678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161678, XrefRangeEnd = 1161683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161683, XrefRangeEnd = 1161688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe virtual int sourceCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161688, XrefRangeEnd = 1161697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static ScaleConstraint()
	{
		Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "ScaleConstraint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665105);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_ScaleConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665106);
		NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665107);
		NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665108);
		NativeMethodInfoPtr_get_scaleAtRest_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665109);
		NativeMethodInfoPtr_set_scaleAtRest_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665110);
		NativeMethodInfoPtr_get_scaleOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665111);
		NativeMethodInfoPtr_set_scaleOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665112);
		NativeMethodInfoPtr_get_scalingAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665113);
		NativeMethodInfoPtr_set_scalingAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665114);
		NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665115);
		NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665116);
		NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665118);
		NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665119);
		NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_ScaleConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665120);
		NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665121);
		NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665122);
		NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_ScaleConstraint_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665123);
		NativeMethodInfoPtr_AddSource_Public_Virtual_Final_New_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_RemoveSource_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_RemoveSourceInternal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_GetSource_Public_Virtual_Final_New_ConstraintSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_GetSourceInternal_Private_ConstraintSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665128);
		NativeMethodInfoPtr_SetSource_Public_Virtual_Final_New_Void_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr_SetSourceInternal_Private_Void_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665130);
		NativeMethodInfoPtr_ValidateSourceIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_get_weight_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_set_weight_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_get_scaleAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr_set_scaleAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665135);
		NativeMethodInfoPtr_get_scaleOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665136);
		NativeMethodInfoPtr_set_scaleOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665137);
		NativeMethodInfoPtr_get_scalingAxis_Injected_Private_Static_Axis_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665138);
		NativeMethodInfoPtr_set_scalingAxis_Injected_Private_Static_Void_IntPtr_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665139);
		NativeMethodInfoPtr_get_constraintActive_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665140);
		NativeMethodInfoPtr_set_constraintActive_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665141);
		NativeMethodInfoPtr_get_locked_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665142);
		NativeMethodInfoPtr_set_locked_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665143);
		NativeMethodInfoPtr_GetSourceCountInternal_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665144);
		NativeMethodInfoPtr_GetSources_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665145);
		NativeMethodInfoPtr_SetSourcesInternal_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665146);
		NativeMethodInfoPtr_AddSource_Injected_Private_Static_Int32_IntPtr_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665147);
		NativeMethodInfoPtr_RemoveSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665148);
		NativeMethodInfoPtr_GetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665149);
		NativeMethodInfoPtr_SetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr, 100665150);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161627, XrefRangeEnd = 1161630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScaleConstraint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleConstraint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161630, XrefRangeEnd = 1161632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(ScaleConstraint self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_ScaleConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSourceCountInternal(ScaleConstraint self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_ScaleConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161697, XrefRangeEnd = 1161705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161705, XrefRangeEnd = 1161720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161720, XrefRangeEnd = 1161729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourcesInternal(ScaleConstraint self, List<ConstraintSource> sources)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_ScaleConstraint_List_1_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161729, XrefRangeEnd = 1161733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161733, XrefRangeEnd = 1161739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161739, XrefRangeEnd = 1161744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161744, XrefRangeEnd = 1161749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161749, XrefRangeEnd = 1161753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161753, XrefRangeEnd = 1161758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161758, XrefRangeEnd = 1161762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1161774, RefRangeEnd = 1161777, XrefRangeStart = 1161762, XrefRangeEnd = 1161774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161777, XrefRangeEnd = 1161779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161779, XrefRangeEnd = 1161781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161781, XrefRangeEnd = 1161783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_scaleAtRest_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161783, XrefRangeEnd = 1161785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_scaleAtRest_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161785, XrefRangeEnd = 1161787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_scaleOffset_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161787, XrefRangeEnd = 1161789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_scaleOffset_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161789, XrefRangeEnd = 1161791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Axis get_scalingAxis_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scalingAxis_Injected_Private_Static_Axis_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Axis*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161791, XrefRangeEnd = 1161793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_scalingAxis_Injected(IntPtr _unity_self, Axis value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(Axis**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scalingAxis_Injected_Private_Static_Void_IntPtr_Axis_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161793, XrefRangeEnd = 1161795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161795, XrefRangeEnd = 1161797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161797, XrefRangeEnd = 1161799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161799, XrefRangeEnd = 1161801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161801, XrefRangeEnd = 1161803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161803, XrefRangeEnd = 1161805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161805, XrefRangeEnd = 1161807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161807, XrefRangeEnd = 1161809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161809, XrefRangeEnd = 1161811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161811, XrefRangeEnd = 1161813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161813, XrefRangeEnd = 1161815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public ScaleConstraint(IntPtr pointer)
		: base(pointer)
	{
	}
}
