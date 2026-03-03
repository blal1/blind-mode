using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.ParticleSystemJobs;

public sealed class ParticleSystemJobData : Il2CppSystem.ValueType
{
	private sealed class MethodInfoStoreGeneric_CreateNativeArray_Internal_NativeArray_1_T_ptr_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateNativeArray_Internal_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__count_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__positions_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__velocities_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__axisOfRotations_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rotations_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rotationalSpeeds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__sizes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__startColors_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__aliveTimePercent_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__inverseStartLifetimes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__randomSeeds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__customData1_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__customData2_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__meshIndices_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_positions_Public_get_ParticleSystemNativeArray3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_velocities_Public_get_ParticleSystemNativeArray3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_axisOfRotations_Public_get_ParticleSystemNativeArray3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotations_Public_get_ParticleSystemNativeArray3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotationalSpeeds_Public_get_ParticleSystemNativeArray3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sizes_Public_get_ParticleSystemNativeArray3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_startColors_Public_get_NativeArray_1_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aliveTimePercent_Public_get_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_inverseStartLifetimes_Public_get_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_randomSeeds_Public_get_NativeArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_customData1_Public_get_ParticleSystemNativeArray4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_customData2_Public_get_ParticleSystemNativeArray4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_meshIndices_Public_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_NativeParticleData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNativeArray_Internal_NativeArray_1_T_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNativeArray3_Internal_ParticleSystemNativeArray3_byref_Array3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateNativeArray4_Internal_ParticleSystemNativeArray4_byref_Array4_Int32_0;

	public unsafe int _count_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count_k__BackingField)) = value;
		}
	}

	public unsafe ParticleSystemNativeArray3 _positions_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__positions_k__BackingField);
			return new ParticleSystemNativeArray3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__positions_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray3 _velocities_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__velocities_k__BackingField);
			return new ParticleSystemNativeArray3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__velocities_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray3 _axisOfRotations_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisOfRotations_k__BackingField);
			return new ParticleSystemNativeArray3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__axisOfRotations_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray3 _rotations_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rotations_k__BackingField);
			return new ParticleSystemNativeArray3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rotations_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray3 _rotationalSpeeds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rotationalSpeeds_k__BackingField);
			return new ParticleSystemNativeArray3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rotationalSpeeds_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray3 _sizes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizes_k__BackingField);
			return new ParticleSystemNativeArray3(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__sizes_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray3>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Color32> _startColors_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startColors_k__BackingField);
			return new NativeArray<Color32>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Color32>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startColors_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Color32>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> _aliveTimePercent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aliveTimePercent_k__BackingField);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__aliveTimePercent_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> _inverseStartLifetimes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inverseStartLifetimes_k__BackingField);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__inverseStartLifetimes_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<uint> _randomSeeds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__randomSeeds_k__BackingField);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__randomSeeds_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray4 _customData1_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customData1_k__BackingField);
			return new ParticleSystemNativeArray4(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray4>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customData1_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray4>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ParticleSystemNativeArray4 _customData2_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customData2_k__BackingField);
			return new ParticleSystemNativeArray4(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemNativeArray4>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__customData2_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParticleSystemNativeArray4>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> _meshIndices_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshIndices_k__BackingField);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__meshIndices_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int count
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ParticleSystemNativeArray3 positions
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_positions_Public_get_ParticleSystemNativeArray3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray3(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray3 velocities
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_velocities_Public_get_ParticleSystemNativeArray3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray3(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray3 axisOfRotations
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_axisOfRotations_Public_get_ParticleSystemNativeArray3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray3(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray3 rotations
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotations_Public_get_ParticleSystemNativeArray3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray3(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray3 rotationalSpeeds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotationalSpeeds_Public_get_ParticleSystemNativeArray3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray3(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray3 sizes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizes_Public_get_ParticleSystemNativeArray3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray3(pointer);
		}
	}

	public unsafe NativeArray<Color32> startColors
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startColors_Public_get_NativeArray_1_Color32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<Color32>(pointer);
		}
	}

	public unsafe NativeArray<float> aliveTimePercent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aliveTimePercent_Public_get_NativeArray_1_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<float>(pointer);
		}
	}

	public unsafe NativeArray<float> inverseStartLifetimes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_inverseStartLifetimes_Public_get_NativeArray_1_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<float>(pointer);
		}
	}

	public unsafe NativeArray<uint> randomSeeds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_randomSeeds_Public_get_NativeArray_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<uint>(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray4 customData1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_customData1_Public_get_ParticleSystemNativeArray4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray4(pointer);
		}
	}

	public unsafe ParticleSystemNativeArray4 customData2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_customData2_Public_get_ParticleSystemNativeArray4_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ParticleSystemNativeArray4(pointer);
		}
	}

	public unsafe NativeArray<int> meshIndices
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_meshIndices_Public_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	static ParticleSystemJobData()
	{
		Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine.ParticleSystemJobs", "ParticleSystemJobData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr);
		NativeFieldInfoPtr__count_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<count>k__BackingField");
		NativeFieldInfoPtr__positions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<positions>k__BackingField");
		NativeFieldInfoPtr__velocities_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<velocities>k__BackingField");
		NativeFieldInfoPtr__axisOfRotations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<axisOfRotations>k__BackingField");
		NativeFieldInfoPtr__rotations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<rotations>k__BackingField");
		NativeFieldInfoPtr__rotationalSpeeds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<rotationalSpeeds>k__BackingField");
		NativeFieldInfoPtr__sizes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<sizes>k__BackingField");
		NativeFieldInfoPtr__startColors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<startColors>k__BackingField");
		NativeFieldInfoPtr__aliveTimePercent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<aliveTimePercent>k__BackingField");
		NativeFieldInfoPtr__inverseStartLifetimes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<inverseStartLifetimes>k__BackingField");
		NativeFieldInfoPtr__randomSeeds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<randomSeeds>k__BackingField");
		NativeFieldInfoPtr__customData1_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<customData1>k__BackingField");
		NativeFieldInfoPtr__customData2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<customData2>k__BackingField");
		NativeFieldInfoPtr__meshIndices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, "<meshIndices>k__BackingField");
		NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665045);
		NativeMethodInfoPtr_get_positions_Public_get_ParticleSystemNativeArray3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665046);
		NativeMethodInfoPtr_get_velocities_Public_get_ParticleSystemNativeArray3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665047);
		NativeMethodInfoPtr_get_axisOfRotations_Public_get_ParticleSystemNativeArray3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665048);
		NativeMethodInfoPtr_get_rotations_Public_get_ParticleSystemNativeArray3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665049);
		NativeMethodInfoPtr_get_rotationalSpeeds_Public_get_ParticleSystemNativeArray3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665050);
		NativeMethodInfoPtr_get_sizes_Public_get_ParticleSystemNativeArray3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665051);
		NativeMethodInfoPtr_get_startColors_Public_get_NativeArray_1_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665052);
		NativeMethodInfoPtr_get_aliveTimePercent_Public_get_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665053);
		NativeMethodInfoPtr_get_inverseStartLifetimes_Public_get_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665054);
		NativeMethodInfoPtr_get_randomSeeds_Public_get_NativeArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665055);
		NativeMethodInfoPtr_get_customData1_Public_get_ParticleSystemNativeArray4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665056);
		NativeMethodInfoPtr_get_customData2_Public_get_ParticleSystemNativeArray4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665057);
		NativeMethodInfoPtr_get_meshIndices_Public_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665058);
		NativeMethodInfoPtr__ctor_Internal_Void_byref_NativeParticleData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665059);
		NativeMethodInfoPtr_CreateNativeArray_Internal_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665060);
		NativeMethodInfoPtr_CreateNativeArray3_Internal_ParticleSystemNativeArray3_byref_Array3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr_CreateNativeArray4_Internal_ParticleSystemNativeArray4_byref_Array4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr, 100665062);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1258475, RefRangeEnd = 1258478, XrefRangeStart = 1258452, XrefRangeEnd = 1258475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleSystemJobData(ref NativeParticleData nativeData)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref nativeData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_NativeParticleData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1238146, RefRangeEnd = 1238160, XrefRangeStart = 1238146, XrefRangeEnd = 1238160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> CreateNativeArray<T>(void* src, int count) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)src;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateNativeArray_Internal_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1258485, RefRangeEnd = 1258491, XrefRangeStart = 1258478, XrefRangeEnd = 1258485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleSystemNativeArray3 CreateNativeArray3(ref NativeParticleData.Array3 ptrs, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref ptrs);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNativeArray3_Internal_ParticleSystemNativeArray3_byref_Array3_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ParticleSystemNativeArray3(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1258500, RefRangeEnd = 1258502, XrefRangeStart = 1258491, XrefRangeEnd = 1258500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleSystemNativeArray4 CreateNativeArray4(ref NativeParticleData.Array4 ptrs, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref ptrs);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateNativeArray4_Internal_ParticleSystemNativeArray4_byref_Array4_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ParticleSystemNativeArray4(pointer);
	}

	public ParticleSystemJobData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ParticleSystemJobData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSystemJobData>.NativeClassPtr))
	{
	}
}
