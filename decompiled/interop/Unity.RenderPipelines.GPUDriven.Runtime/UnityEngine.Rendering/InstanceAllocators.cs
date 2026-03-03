using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class InstanceAllocators : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceAlloc_MeshRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceAlloc_SpeedTree;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SharedInstanceAlloc;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceAllocator_Private_InstanceAllocator_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstanceHandlesLength_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstancesLength_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateInstance_Public_InstanceHandle_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeInstance_Public_Void_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateSharedInstance_Public_SharedInstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeSharedInstance_Public_Void_SharedInstanceHandle_0;

	public unsafe InstanceAllocator m_InstanceAlloc_MeshRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceAlloc_MeshRenderer);
			return new InstanceAllocator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceAllocator>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceAlloc_MeshRenderer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceAllocator>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InstanceAllocator m_InstanceAlloc_SpeedTree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceAlloc_SpeedTree);
			return new InstanceAllocator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceAllocator>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceAlloc_SpeedTree), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceAllocator>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InstanceAllocator m_SharedInstanceAlloc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SharedInstanceAlloc);
			return new InstanceAllocator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceAllocator>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SharedInstanceAlloc), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceAllocator>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static InstanceAllocators()
	{
		Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceAllocators");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr);
		NativeFieldInfoPtr_m_InstanceAlloc_MeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, "m_InstanceAlloc_MeshRenderer");
		NativeFieldInfoPtr_m_InstanceAlloc_SpeedTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, "m_InstanceAlloc_SpeedTree");
		NativeFieldInfoPtr_m_SharedInstanceAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, "m_SharedInstanceAlloc");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_GetInstanceAllocator_Private_InstanceAllocator_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_GetInstanceHandlesLength_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr_GetInstancesLength_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr_AllocateInstance_Public_InstanceHandle_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr_FreeInstance_Public_Void_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr_AllocateSharedInstance_Public_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663751);
		NativeMethodInfoPtr_FreeSharedInstance_Public_Void_SharedInstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, 100663752);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071932, XrefRangeEnd = 1071935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071953, RefRangeEnd = 1071954, XrefRangeStart = 1071935, XrefRangeEnd = 1071953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe InstanceAllocator GetInstanceAllocator(InstanceType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceAllocator_Private_InstanceAllocator_InstanceType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new InstanceAllocator(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071954, RefRangeEnd = 1071955, XrefRangeStart = 1071954, XrefRangeEnd = 1071954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInstanceHandlesLength(InstanceType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstanceHandlesLength_Public_Int32_InstanceType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071959, RefRangeEnd = 1071960, XrefRangeStart = 1071955, XrefRangeEnd = 1071959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInstancesLength(InstanceType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInstancesLength_Public_Int32_InstanceType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071968, RefRangeEnd = 1071970, XrefRangeStart = 1071960, XrefRangeEnd = 1071968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstanceHandle AllocateInstance(InstanceType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateInstance_Public_InstanceHandle_InstanceType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InstanceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1071980, RefRangeEnd = 1071983, XrefRangeStart = 1071970, XrefRangeEnd = 1071980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeInstance(InstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeInstance_Public_Void_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071987, RefRangeEnd = 1071988, XrefRangeStart = 1071983, XrefRangeEnd = 1071987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SharedInstanceHandle AllocateSharedInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateSharedInstance_Public_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SharedInstanceHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1071994, RefRangeEnd = 1071997, XrefRangeStart = 1071988, XrefRangeEnd = 1071994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeSharedInstance(SharedInstanceHandle instance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instance);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeSharedInstance_Public_Void_SharedInstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InstanceAllocators(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InstanceAllocators()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr))
	{
	}
}
