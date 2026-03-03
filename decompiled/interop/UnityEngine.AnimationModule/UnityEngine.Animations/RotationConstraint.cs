using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Animations;

public sealed class RotationConstraint : Behaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RotationConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAtRest_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAtRest_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationOffset_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationOffset_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAxis_Public_get_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAxis_Public_set_Void_Axis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_RotationConstraint_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_RotationConstraint_List_1_ConstraintSource_0;

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

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rotationAxis_Injected_Private_Static_Axis_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rotationAxis_Injected_Private_Static_Void_IntPtr_Axis_0;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161444, XrefRangeEnd = 1161449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161449, XrefRangeEnd = 1161454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe Vector3 rotationAtRest
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161454, XrefRangeEnd = 1161458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161458, XrefRangeEnd = 1161462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161462, XrefRangeEnd = 1161466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161466, XrefRangeEnd = 1161470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161470, XrefRangeEnd = 1161475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161475, XrefRangeEnd = 1161480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe virtual bool constraintActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161480, XrefRangeEnd = 1161485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161485, XrefRangeEnd = 1161490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161490, XrefRangeEnd = 1161495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161495, XrefRangeEnd = 1161500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161500, XrefRangeEnd = 1161509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static RotationConstraint()
	{
		Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "RotationConstraint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665059);
		NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RotationConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665060);
		NativeMethodInfoPtr_get_weight_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr_set_weight_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665062);
		NativeMethodInfoPtr_get_rotationAtRest_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665063);
		NativeMethodInfoPtr_set_rotationAtRest_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665064);
		NativeMethodInfoPtr_get_rotationOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665065);
		NativeMethodInfoPtr_set_rotationOffset_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665066);
		NativeMethodInfoPtr_get_rotationAxis_Public_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665067);
		NativeMethodInfoPtr_set_rotationAxis_Public_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665068);
		NativeMethodInfoPtr_get_constraintActive_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665069);
		NativeMethodInfoPtr_set_constraintActive_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665070);
		NativeMethodInfoPtr_get_locked_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665071);
		NativeMethodInfoPtr_set_locked_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665072);
		NativeMethodInfoPtr_get_sourceCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665073);
		NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_RotationConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665074);
		NativeMethodInfoPtr_GetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665075);
		NativeMethodInfoPtr_SetSources_Public_Virtual_Final_New_Void_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665076);
		NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_RotationConstraint_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665077);
		NativeMethodInfoPtr_AddSource_Public_Virtual_Final_New_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665078);
		NativeMethodInfoPtr_RemoveSource_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665079);
		NativeMethodInfoPtr_RemoveSourceInternal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665080);
		NativeMethodInfoPtr_GetSource_Public_Virtual_Final_New_ConstraintSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665081);
		NativeMethodInfoPtr_GetSourceInternal_Private_ConstraintSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665082);
		NativeMethodInfoPtr_SetSource_Public_Virtual_Final_New_Void_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665083);
		NativeMethodInfoPtr_SetSourceInternal_Private_Void_Int32_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665084);
		NativeMethodInfoPtr_ValidateSourceIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665085);
		NativeMethodInfoPtr_get_weight_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665086);
		NativeMethodInfoPtr_set_weight_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665087);
		NativeMethodInfoPtr_get_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665088);
		NativeMethodInfoPtr_set_rotationAtRest_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665089);
		NativeMethodInfoPtr_get_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_set_rotationOffset_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_get_rotationAxis_Injected_Private_Static_Axis_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665092);
		NativeMethodInfoPtr_set_rotationAxis_Injected_Private_Static_Void_IntPtr_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665093);
		NativeMethodInfoPtr_get_constraintActive_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665094);
		NativeMethodInfoPtr_set_constraintActive_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665095);
		NativeMethodInfoPtr_get_locked_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665096);
		NativeMethodInfoPtr_set_locked_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665097);
		NativeMethodInfoPtr_GetSourceCountInternal_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665098);
		NativeMethodInfoPtr_GetSources_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665099);
		NativeMethodInfoPtr_SetSourcesInternal_Injected_Private_Static_Void_IntPtr_List_1_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665100);
		NativeMethodInfoPtr_AddSource_Injected_Private_Static_Int32_IntPtr_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665101);
		NativeMethodInfoPtr_RemoveSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665102);
		NativeMethodInfoPtr_GetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665103);
		NativeMethodInfoPtr_SetSourceInternal_Injected_Private_Static_Void_IntPtr_Int32_byref_ConstraintSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr, 100665104);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161439, XrefRangeEnd = 1161442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RotationConstraint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotationConstraint>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161442, XrefRangeEnd = 1161444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Create(RotationConstraint self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_Void_RotationConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSourceCountInternal(RotationConstraint self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSourceCountInternal_Private_Static_Int32_RotationConstraint_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161509, XrefRangeEnd = 1161517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161517, XrefRangeEnd = 1161532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161532, XrefRangeEnd = 1161541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSourcesInternal(RotationConstraint self, List<ConstraintSource> sources)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sources);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSourcesInternal_Private_Static_Void_RotationConstraint_List_1_ConstraintSource_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161541, XrefRangeEnd = 1161545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161545, XrefRangeEnd = 1161551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161551, XrefRangeEnd = 1161556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161556, XrefRangeEnd = 1161561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161561, XrefRangeEnd = 1161565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161565, XrefRangeEnd = 1161570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161570, XrefRangeEnd = 1161574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1161586, RefRangeEnd = 1161589, XrefRangeStart = 1161574, XrefRangeEnd = 1161586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161589, XrefRangeEnd = 1161591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161591, XrefRangeEnd = 1161593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161593, XrefRangeEnd = 1161595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161595, XrefRangeEnd = 1161597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161597, XrefRangeEnd = 1161599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161599, XrefRangeEnd = 1161601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161601, XrefRangeEnd = 1161603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161603, XrefRangeEnd = 1161605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161605, XrefRangeEnd = 1161607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161607, XrefRangeEnd = 1161609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161609, XrefRangeEnd = 1161611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161611, XrefRangeEnd = 1161613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161613, XrefRangeEnd = 1161615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161615, XrefRangeEnd = 1161617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161617, XrefRangeEnd = 1161619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161619, XrefRangeEnd = 1161621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161621, XrefRangeEnd = 1161623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161623, XrefRangeEnd = 1161625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161625, XrefRangeEnd = 1161627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public RotationConstraint(IntPtr pointer)
		: base(pointer)
	{
	}
}
