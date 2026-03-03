using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class BuildDrawListsJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_batchHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatches;

	private static readonly System.IntPtr NativeFieldInfoPtr_internalDrawIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstanceIndices;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementCounter_Private_Static_Int32_ptr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeParallelHashMap<DrawKey, int> batchHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchHash);
			return new NativeParallelHashMap<DrawKey, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<DrawKey, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<DrawKey, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawInstance> drawInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstances);
			return new NativeList<DrawInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawInstance>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawInstance>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawBatch> drawBatches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBatches);
			return new NativeList<DrawBatch>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawBatch>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBatches), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawBatch>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> internalDrawIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalDrawIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_internalDrawIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> drawInstanceIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstanceIndices);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstanceIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static BuildDrawListsJob()
	{
		Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "BuildDrawListsJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr);
		NativeFieldInfoPtr_batchHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, "batchHash");
		NativeFieldInfoPtr_drawInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, "drawInstances");
		NativeFieldInfoPtr_drawBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, "drawBatches");
		NativeFieldInfoPtr_internalDrawIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, "internalDrawIndex");
		NativeFieldInfoPtr_drawInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, "drawInstanceIndices");
		NativeMethodInfoPtr_IncrementCounter_Private_Static_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr, 100663606);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070155, RefRangeEnd = 1070156, XrefRangeStart = 1070153, XrefRangeEnd = 1070155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IncrementCounter(int* counter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)counter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IncrementCounter_Private_Static_Int32_ptr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070156, XrefRangeEnd = 1070169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BuildDrawListsJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BuildDrawListsJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildDrawListsJob>.NativeClassPtr))
	{
	}
}
