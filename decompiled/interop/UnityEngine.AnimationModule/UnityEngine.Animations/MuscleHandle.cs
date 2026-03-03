using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct MuscleHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr__humanPartDof_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__dof_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_humanPartDof_Public_get_HumanPartDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_humanPartDof_Private_set_Void_HumanPartDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dof_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_dof_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BodyDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HeadDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_LegDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_ArmDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_FingerDof_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_muscleHandleCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMuscleHandles_Public_Static_Void_Il2CppStructArray_1_MuscleHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMuscleHandleCount_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMuscleHandles_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Injected_Private_Static_Void_byref_MuscleHandle_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public HumanPartDof _humanPartDof_k__BackingField;

	[FieldOffset(4)]
	public int _dof_k__BackingField;

	public unsafe HumanPartDof humanPartDof
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_humanPartDof_Public_get_HumanPartDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HumanPartDof*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_humanPartDof_Private_set_Void_HumanPartDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int dof
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dof_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_dof_Private_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string name
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162264, XrefRangeEnd = 1162265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static int muscleHandleCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162265, XrefRangeEnd = 1162267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_muscleHandleCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MuscleHandle()
	{
		Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "MuscleHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr);
		NativeFieldInfoPtr__humanPartDof_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, "<humanPartDof>k__BackingField");
		NativeFieldInfoPtr__dof_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, "<dof>k__BackingField");
		NativeMethodInfoPtr_get_humanPartDof_Public_get_HumanPartDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665246);
		NativeMethodInfoPtr_set_humanPartDof_Private_set_Void_HumanPartDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665247);
		NativeMethodInfoPtr_get_dof_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665248);
		NativeMethodInfoPtr_set_dof_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665249);
		NativeMethodInfoPtr__ctor_Public_Void_BodyDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665250);
		NativeMethodInfoPtr__ctor_Public_Void_HeadDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665251);
		NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_LegDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665252);
		NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_ArmDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665253);
		NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_FingerDof_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665254);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665255);
		NativeMethodInfoPtr_get_muscleHandleCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665256);
		NativeMethodInfoPtr_GetMuscleHandles_Public_Static_Void_Il2CppStructArray_1_MuscleHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665257);
		NativeMethodInfoPtr_GetName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665258);
		NativeMethodInfoPtr_GetMuscleHandleCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665259);
		NativeMethodInfoPtr_GetMuscleHandles_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665260);
		NativeMethodInfoPtr_GetName_Injected_Private_Static_Void_byref_MuscleHandle_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, 100665261);
	}

	[CallerCount(0)]
	public unsafe MuscleHandle(BodyDof bodyDof)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bodyDof);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BodyDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe MuscleHandle(HeadDof headDof)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&headDof);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HeadDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe MuscleHandle(HumanPartDof partDof, LegDof legDof)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&partDof);
		*(LegDof**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &legDof;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_LegDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe MuscleHandle(HumanPartDof partDof, ArmDof armDof)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&partDof);
		*(ArmDof**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &armDof;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_ArmDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe MuscleHandle(HumanPartDof partDof, FingerDof fingerDof)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&partDof);
		*(FingerDof**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fingerDof;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_HumanPartDof_FingerDof_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162267, XrefRangeEnd = 1162276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMuscleHandles([Out] Il2CppStructArray<MuscleHandle> muscleHandles)
	{
		//IL_0037: Expected native int or pointer, but got O
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMuscleHandles_Public_Static_Void_Il2CppStructArray_1_MuscleHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)muscleHandles, (num2 == 0) ? null : new Il2CppStructArray<MuscleHandle>((System.IntPtr)num2));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162281, RefRangeEnd = 1162282, XrefRangeStart = 1162276, XrefRangeEnd = 1162281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetName()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Private_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMuscleHandleCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMuscleHandleCount_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162282, XrefRangeEnd = 1162284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMuscleHandles_Injected(out BlittableArrayWrapper muscleHandles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref muscleHandles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMuscleHandles_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162284, XrefRangeEnd = 1162286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetName_Injected(ref MuscleHandle _unity_self, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Injected_Private_Static_Void_byref_MuscleHandle_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MuscleHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
