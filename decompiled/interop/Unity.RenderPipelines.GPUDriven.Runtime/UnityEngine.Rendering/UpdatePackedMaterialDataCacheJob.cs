using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class UpdatePackedMaterialDataCacheJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_materialIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_packedMaterialHash;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMaterial_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

	public unsafe NativeArray<int>.ReadOnly materialIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDs);
			return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<GPUDrivenPackedMaterialData>.ReadOnly packedMaterialDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialDatas);
			return new NativeArray<GPUDrivenPackedMaterialData>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialDatas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUDrivenPackedMaterialData>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, GPUDrivenPackedMaterialData> packedMaterialHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialHash);
			return new NativeParallelHashMap<int, GPUDrivenPackedMaterialData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUDrivenPackedMaterialData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packedMaterialHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUDrivenPackedMaterialData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static UpdatePackedMaterialDataCacheJob()
	{
		Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "UpdatePackedMaterialDataCacheJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr);
		NativeFieldInfoPtr_materialIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr, "materialIDs");
		NativeFieldInfoPtr_packedMaterialDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr, "packedMaterialDatas");
		NativeFieldInfoPtr_packedMaterialHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr, "packedMaterialHash");
		NativeMethodInfoPtr_ProcessMaterial_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr, 100663617);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070327, RefRangeEnd = 1070328, XrefRangeStart = 1070318, XrefRangeEnd = 1070327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessMaterial(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMaterial_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070330, RefRangeEnd = 1070331, XrefRangeStart = 1070328, XrefRangeEnd = 1070330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UpdatePackedMaterialDataCacheJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public UpdatePackedMaterialDataCacheJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdatePackedMaterialDataCacheJob>.NativeClassPtr))
	{
	}
}
