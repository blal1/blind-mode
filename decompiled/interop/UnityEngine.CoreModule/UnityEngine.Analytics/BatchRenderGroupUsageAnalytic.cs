using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Analytics;

[Serializable]
public class BatchRenderGroupUsageAnalytic : AnalyticsEventBase
{
	private static readonly IntPtr NativeFieldInfoPtr_maxBRGInstance;

	private static readonly IntPtr NativeFieldInfoPtr_maxMeshCount;

	private static readonly IntPtr NativeFieldInfoPtr_maxMaterialCount;

	private static readonly IntPtr NativeFieldInfoPtr_maxDrawCommandBatch;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateBatchRenderGroupUsageAnalytic_Public_Static_BatchRenderGroupUsageAnalytic_0;

	public unsafe int maxBRGInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBRGInstance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBRGInstance)) = value;
		}
	}

	public unsafe int maxMeshCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMeshCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMeshCount)) = value;
		}
	}

	public unsafe int maxMaterialCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMaterialCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxMaterialCount)) = value;
		}
	}

	public unsafe int maxDrawCommandBatch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDrawCommandBatch);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDrawCommandBatch)) = value;
		}
	}

	static BatchRenderGroupUsageAnalytic()
	{
		Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", "BatchRenderGroupUsageAnalytic");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr);
		NativeFieldInfoPtr_maxBRGInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, "maxBRGInstance");
		NativeFieldInfoPtr_maxMeshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, "maxMeshCount");
		NativeFieldInfoPtr_maxMaterialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, "maxMaterialCount");
		NativeFieldInfoPtr_maxDrawCommandBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, "maxDrawCommandBatch");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, 100667626);
		NativeMethodInfoPtr_CreateBatchRenderGroupUsageAnalytic_Public_Static_BatchRenderGroupUsageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, 100667627);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231648, XrefRangeEnd = 1231655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BatchRenderGroupUsageAnalytic()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231655, XrefRangeEnd = 1231665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBatchRenderGroupUsageAnalytic_Public_Static_BatchRenderGroupUsageAnalytic_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BatchRenderGroupUsageAnalytic>(intPtr2) : null;
	}

	public BatchRenderGroupUsageAnalytic(IntPtr pointer)
		: base(pointer)
	{
	}
}
