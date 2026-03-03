using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class SilhouettePlaneCache : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Slot
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

		private static readonly System.IntPtr NativeFieldInfoPtr_planeCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUsedFrameIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool isActive;

		[FieldOffset(4)]
		public int viewInstanceID;

		[FieldOffset(8)]
		public int planeCount;

		[FieldOffset(12)]
		public int lastUsedFrameIndex;

		static Slot()
		{
			Il2CppClassPointerStore<Slot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, "Slot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Slot>.NativeClassPtr);
			NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slot>.NativeClassPtr, "isActive");
			NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slot>.NativeClassPtr, "viewInstanceID");
			NativeFieldInfoPtr_planeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slot>.NativeClassPtr, "planeCount");
			NativeFieldInfoPtr_lastUsedFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Slot>.NativeClassPtr, "lastUsedFrameIndex");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Slot>.NativeClassPtr, 100663975);
		}

		[CallerCount(0)]
		public unsafe Slot(int viewInstanceID, int planeCount, int frameIndex)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&viewInstanceID);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &planeCount;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Slot>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SubviewIDToIndexMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SlotFreeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Slots;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PlaneStorage;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Int32_NativeArray_1_Plane_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeUnusedSlots_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_Plane_Int32_0;

	public unsafe NativeParallelHashMap<int, int> m_SubviewIDToIndexMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubviewIDToIndexMap);
			return new NativeParallelHashMap<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SubviewIDToIndexMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int> m_SlotFreeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SlotFreeList);
			return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SlotFreeList), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<Slot> m_Slots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Slots);
			return new NativeList<Slot>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Slot>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Slots), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Slot>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<Plane> m_PlaneStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlaneStorage);
			return new NativeList<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Plane>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PlaneStorage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Plane>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static SilhouettePlaneCache()
	{
		Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "SilhouettePlaneCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr);
		NativeFieldInfoPtr_m_SubviewIDToIndexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, "m_SubviewIDToIndexMap");
		NativeFieldInfoPtr_m_SlotFreeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, "m_SlotFreeList");
		NativeFieldInfoPtr_m_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, "m_Slots");
		NativeFieldInfoPtr_m_PlaneStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, "m_PlaneStorage");
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_Update_Public_Void_Int32_NativeArray_1_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_FreeUnusedSlots_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, 100663974);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074360, RefRangeEnd = 1074361, XrefRangeStart = 1074344, XrefRangeEnd = 1074360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074361, XrefRangeEnd = 1074373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074431, RefRangeEnd = 1074432, XrefRangeStart = 1074373, XrefRangeEnd = 1074431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(int viewInstanceID, NativeArray<Plane> planes, int frameIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&viewInstanceID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)planes));
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Void_Int32_NativeArray_1_Plane_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074448, RefRangeEnd = 1074449, XrefRangeStart = 1074432, XrefRangeEnd = 1074448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeUnusedSlots(int frameIndex, int maximumAge)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frameIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maximumAge;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeUnusedSlots_Public_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074461, RefRangeEnd = 1074462, XrefRangeStart = 1074449, XrefRangeEnd = 1074461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<Plane> GetSubArray(int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSubArray_Public_NativeArray_1_Plane_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<Plane>(pointer);
	}

	public SilhouettePlaneCache(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SilhouettePlaneCache()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr))
	{
	}
}
