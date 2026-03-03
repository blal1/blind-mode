using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI;

public class CanvasUpdateRegistry : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PerformingLayoutUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PerformingGraphicUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingUpdateProfilerString;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SortLayoutFunction;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0;

	public unsafe static CanvasUpdateRegistry s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_PerformingLayoutUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerformingLayoutUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerformingLayoutUpdate)) = value;
		}
	}

	public unsafe bool m_PerformingGraphicUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerformingGraphicUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerformingGraphicUpdate)) = value;
		}
	}

	public unsafe Il2CppStringArray m_CanvasUpdateProfilerStrings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string m_CullingUpdateProfilerString
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_CullingUpdateProfilerString, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_CullingUpdateProfilerString, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe IndexedSet<ICanvasElement> m_LayoutRebuildQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutRebuildQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutRebuildQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IndexedSet<ICanvasElement> m_GraphicRebuildQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicRebuildQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IndexedSet<ICanvasElement>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicRebuildQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Comparison<ICanvasElement> s_SortLayoutFunction
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SortLayoutFunction, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ICanvasElement>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SortLayoutFunction, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CanvasUpdateRegistry instance
	{
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1285629, RefRangeEnd = 1285651, XrefRangeStart = 1285615, XrefRangeEnd = 1285629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasUpdateRegistry>(intPtr2) : null;
		}
	}

	static CanvasUpdateRegistry()
	{
		Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "CanvasUpdateRegistry");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_PerformingLayoutUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingLayoutUpdate");
		NativeFieldInfoPtr_m_PerformingGraphicUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_PerformingGraphicUpdate");
		NativeFieldInfoPtr_m_CanvasUpdateProfilerStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CanvasUpdateProfilerStrings");
		NativeFieldInfoPtr_m_CullingUpdateProfilerString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_CullingUpdateProfilerString");
		NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_LayoutRebuildQueue");
		NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "m_GraphicRebuildQueue");
		NativeFieldInfoPtr_s_SortLayoutFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, "s_SortLayoutFunction");
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_get_instance_Public_Static_get_CanvasUpdateRegistry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_PerformUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr, 100663349);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285614, RefRangeEnd = 1285615, XrefRangeStart = 1285573, XrefRangeEnd = 1285614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CanvasUpdateRegistry()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasUpdateRegistry>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285656, RefRangeEnd = 1285658, XrefRangeStart = 1285651, XrefRangeEnd = 1285656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ObjectValidForUpdate(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ObjectValidForUpdate_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1285684, RefRangeEnd = 1285685, XrefRangeStart = 1285658, XrefRangeEnd = 1285684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanInvalidItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanInvalidItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285685, XrefRangeEnd = 1285758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285768, RefRangeEnd = 1285770, XrefRangeStart = 1285758, XrefRangeEnd = 1285768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ParentCount(Transform child)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)child);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParentCount_Private_Static_Int32_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285770, XrefRangeEnd = 1285780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SortLayoutList(ICanvasElement x, ICanvasElement y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)y);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SortLayoutList_Private_Static_Int32_ICanvasElement_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1285786, RefRangeEnd = 1285789, XrefRangeStart = 1285780, XrefRangeEnd = 1285786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCanvasElementForLayoutRebuild_Public_Static_Void_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285795, RefRangeEnd = 1285797, XrefRangeStart = 1285789, XrefRangeEnd = 1285795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryRegisterCanvasElementForLayoutRebuild_Public_Static_Boolean_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285803, RefRangeEnd = 1285805, XrefRangeStart = 1285797, XrefRangeEnd = 1285803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRegisterCanvasElementForLayoutRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1285811, RefRangeEnd = 1285829, XrefRangeStart = 1285805, XrefRangeEnd = 1285811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterCanvasElementForGraphicRebuild_Public_Static_Void_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285829, XrefRangeEnd = 1285835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryRegisterCanvasElementForGraphicRebuild_Public_Static_Boolean_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1285845, RefRangeEnd = 1285850, XrefRangeStart = 1285835, XrefRangeEnd = 1285845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRegisterCanvasElementForGraphicRebuild_Private_Boolean_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1285901, RefRangeEnd = 1285906, XrefRangeStart = 1285850, XrefRangeEnd = 1285901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnRegisterCanvasElementForRebuild(ICanvasElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1285947, RefRangeEnd = 1285949, XrefRangeStart = 1285906, XrefRangeEnd = 1285947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableCanvasElementForRebuild(ICanvasElement element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableCanvasElementForRebuild_Public_Static_Void_ICanvasElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285949, XrefRangeEnd = 1285967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnRegisterCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285967, XrefRangeEnd = 1285985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnRegisterCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285985, XrefRangeEnd = 1286003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDisableCanvasElementForLayoutRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1286003, XrefRangeEnd = 1286021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDisableCanvasElementForGraphicRebuild_Private_Void_ICanvasElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1286025, RefRangeEnd = 1286036, XrefRangeStart = 1286021, XrefRangeEnd = 1286025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRebuildingLayout()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRebuildingLayout_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1286040, RefRangeEnd = 1286043, XrefRangeStart = 1286036, XrefRangeEnd = 1286040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRebuildingGraphics()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRebuildingGraphics_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public CanvasUpdateRegistry(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
