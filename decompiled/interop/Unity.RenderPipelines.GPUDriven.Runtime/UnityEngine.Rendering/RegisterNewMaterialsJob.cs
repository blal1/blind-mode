using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class RegisterNewMaterialsJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchMaterialHashMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialHashMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeArray<int> instanceIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIDs);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialDatas);
			return new NativeArray<GPUDrivenPackedMaterialData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<BatchMaterialID> batchIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchIDs);
			return new NativeArray<BatchMaterialID>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BatchMaterialID>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BatchMaterialID>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, BatchMaterialID>.ParallelWriter batchMaterialHashMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchMaterialHashMap);
			return new NativeParallelHashMap<int, BatchMaterialID>.ParallelWriter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMaterialID>.ParallelWriter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchMaterialHashMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMaterialID>.ParallelWriter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ParallelWriter packedMaterialHashMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialHashMap);
			return new NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ParallelWriter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ParallelWriter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialHashMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUDrivenPackedMaterialData>.ParallelWriter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static RegisterNewMaterialsJob()
	{
		Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RegisterNewMaterialsJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr);
		NativeFieldInfoPtr_instanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr, "instanceIDs");
		NativeFieldInfoPtr_packedMaterialDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr, "packedMaterialDatas");
		NativeFieldInfoPtr_batchIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr, "batchIDs");
		NativeFieldInfoPtr_batchMaterialHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr, "batchMaterialHashMap");
		NativeFieldInfoPtr_packedMaterialHashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr, "packedMaterialHashMap");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr, 100663612);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070247, XrefRangeEnd = 1070253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RegisterNewMaterialsJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RegisterNewMaterialsJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterNewMaterialsJob>.NativeClassPtr))
	{
	}
}
