using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace Il2CppTMPro;

public class TMP_UpdateManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayoutQueueLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LayoutRebuildQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GraphicQueueLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GraphicRebuildQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalUpdateLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InternalUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingUpdateLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingUpdateQueue;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoRebuilds_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0;

	public unsafe static TMP_UpdateManager s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<int> m_LayoutQueueLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutQueueLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutQueueLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Text> m_LayoutRebuildQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutRebuildQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LayoutRebuildQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<int> m_GraphicQueueLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicQueueLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicQueueLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Text> m_GraphicRebuildQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicRebuildQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GraphicRebuildQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<int> m_InternalUpdateLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalUpdateLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalUpdateLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Text> m_InternalUpdateQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalUpdateQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InternalUpdateQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<int> m_CullingUpdateLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingUpdateLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingUpdateLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<TMP_Text> m_CullingUpdateQueue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingUpdateQueue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TMP_Text>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingUpdateQueue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilerMarker k_RegisterTextObjectForUpdateMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_UnregisterTextObjectForUpdateMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker, (void*)(&value));
		}
	}

	public unsafe static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker
	{
		get
		{
			Unsafe.SkipInit(out ProfilerMarker result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker, (void*)(&value));
		}
	}

	public unsafe static TMP_UpdateManager instance
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1134615, RefRangeEnd = 1134623, XrefRangeStart = 1134601, XrefRangeEnd = 1134615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_UpdateManager>(intPtr2) : null;
		}
	}

	static TMP_UpdateManager()
	{
		Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_UpdateManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_LayoutQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutQueueLookup");
		NativeFieldInfoPtr_m_LayoutRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_LayoutRebuildQueue");
		NativeFieldInfoPtr_m_GraphicQueueLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicQueueLookup");
		NativeFieldInfoPtr_m_GraphicRebuildQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_GraphicRebuildQueue");
		NativeFieldInfoPtr_m_InternalUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateLookup");
		NativeFieldInfoPtr_m_InternalUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_InternalUpdateQueue");
		NativeFieldInfoPtr_m_CullingUpdateLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateLookup");
		NativeFieldInfoPtr_m_CullingUpdateQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "m_CullingUpdateQueue");
		NativeFieldInfoPtr_k_RegisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextObjectForUpdateMarker");
		NativeFieldInfoPtr_k_RegisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForGraphicRebuildMarker");
		NativeFieldInfoPtr_k_RegisterTextElementForCullingUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_RegisterTextElementForCullingUpdateMarker");
		NativeFieldInfoPtr_k_UnregisterTextObjectForUpdateMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextObjectForUpdateMarker");
		NativeFieldInfoPtr_k_UnregisterTextElementForGraphicRebuildMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, "k_UnregisterTextElementForGraphicRebuildMarker");
		NativeMethodInfoPtr_get_instance_Private_Static_get_TMP_UpdateManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665084);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665085);
		NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665086);
		NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665087);
		NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665088);
		NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665089);
		NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665092);
		NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665093);
		NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665094);
		NativeMethodInfoPtr_DoRebuilds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665095);
		NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665096);
		NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665097);
		NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665098);
		NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665099);
		NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr, 100665100);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1134675, RefRangeEnd = 1134676, XrefRangeStart = 1134623, XrefRangeEnd = 1134675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_UpdateManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_UpdateManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1134690, RefRangeEnd = 1134694, XrefRangeStart = 1134676, XrefRangeEnd = 1134690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterTextObjectForUpdate(TMP_Text textObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134694, XrefRangeEnd = 1134704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalRegisterTextObjectForUpdate(TMP_Text textObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1134718, RefRangeEnd = 1134719, XrefRangeStart = 1134704, XrefRangeEnd = 1134718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterTextElementForLayoutRebuild(TMP_Text element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTextElementForLayoutRebuild_Public_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134719, XrefRangeEnd = 1134729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalRegisterTextElementForLayoutRebuild(TMP_Text element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1134743, RefRangeEnd = 1134744, XrefRangeStart = 1134729, XrefRangeEnd = 1134743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterTextElementForGraphicRebuild(TMP_Text element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTextElementForGraphicRebuild_Public_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134744, XrefRangeEnd = 1134754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalRegisterTextElementForGraphicRebuild(TMP_Text element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134754, XrefRangeEnd = 1134768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RegisterTextElementForCullingUpdate(TMP_Text element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTextElementForCullingUpdate_Public_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134768, XrefRangeEnd = 1134778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalRegisterTextElementForCullingUpdate(TMP_Text element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalRegisterTextElementForCullingUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134778, XrefRangeEnd = 1134779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCameraPreCull()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCameraPreCull_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1134804, RefRangeEnd = 1134805, XrefRangeStart = 1134779, XrefRangeEnd = 1134804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoRebuilds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoRebuilds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1134838, RefRangeEnd = 1134844, XrefRangeStart = 1134805, XrefRangeEnd = 1134838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnRegisterTextObjectForUpdate(TMP_Text textObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterTextObjectForUpdate_Internal_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1134872, RefRangeEnd = 1134874, XrefRangeStart = 1134844, XrefRangeEnd = 1134872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnRegisterTextElementForRebuild(TMP_Text element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnRegisterTextElementForRebuild_Public_Static_Void_TMP_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134874, XrefRangeEnd = 1134882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnRegisterTextElementForGraphicRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134882, XrefRangeEnd = 1134890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)element);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnRegisterTextElementForLayoutRebuild_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134890, XrefRangeEnd = 1134898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textObject);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnRegisterTextObjectForUpdate_Private_Void_TMP_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_UpdateManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
