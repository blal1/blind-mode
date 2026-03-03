using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

public sealed class BuddyAllocator : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Header
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_branchingOrder;

		private static readonly System.IntPtr NativeFieldInfoPtr_levelCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_allocationCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_freeAllocationIdsCount;

		[FieldOffset(0)]
		public int branchingOrder;

		[FieldOffset(4)]
		public int levelCount;

		[FieldOffset(8)]
		public int allocationCount;

		[FieldOffset(12)]
		public int freeAllocationIdsCount;

		static Header()
		{
			Il2CppClassPointerStore<Header>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "Header");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Header>.NativeClassPtr);
			NativeFieldInfoPtr_branchingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "branchingOrder");
			NativeFieldInfoPtr_levelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "levelCount");
			NativeFieldInfoPtr_allocationCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "allocationCount");
			NativeFieldInfoPtr_freeAllocationIdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Header>.NativeClassPtr, "freeAllocationIdsCount");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Header>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0, Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0, Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveFreeMaskCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeMasksStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeMaskIndicesStorage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Allocator;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_header_Private_get_byref_Header_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_freeMaskCounts_Private_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_freeMasksStorage_Private_get_NativeArray_1_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeMasks_Private_NativeArray_1_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_freeMaskIndicesStorage_Private_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeMaskIndices_Private_NativeArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_levelCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_byref_BuddyAllocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Void_BuddyAllocation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LevelOffset_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LevelLength_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LevelOffset64_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LevelLength64_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignForward_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrAdd_Private_Static_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pow2_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Pow2N_Private_Static_Int32_Int32_Int32_0;

	public unsafe void* m_Data
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data);
			return *(void**)num;
		}
		set
		{
			*(void**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Data)) = value;
		}
	}

	public unsafe Il2CppSystem.ValueTuple<int, int> m_ActiveFreeMaskCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveFreeMaskCounts);
			return new Il2CppSystem.ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveFreeMaskCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.ValueTuple<int, int> m_FreeMasksStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeMasksStorage);
			return new Il2CppSystem.ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeMasksStorage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.ValueTuple<int, int> m_FreeMaskIndicesStorage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeMaskIndicesStorage);
			return new Il2CppSystem.ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeMaskIndicesStorage), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Allocator m_Allocator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Allocator);
			return *(Allocator*)num;
		}
		set
		{
			*(Allocator*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Allocator)) = value;
		}
	}

	public unsafe ref Header header
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1088312, RefRangeEnd = 1088314, XrefRangeStart = 1088311, XrefRangeEnd = 1088312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_header_Private_get_byref_Header_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return ref *(Header*)intPtr2;
		}
	}

	public unsafe NativeArray<int> freeMaskCounts
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088314, XrefRangeEnd = 1088317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_freeMaskCounts_Private_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	public unsafe NativeArray<ulong> freeMasksStorage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088317, XrefRangeEnd = 1088320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_freeMasksStorage_Private_get_NativeArray_1_UInt64_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<ulong>(pointer);
		}
	}

	public unsafe NativeArray<int> freeMaskIndicesStorage
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088332, XrefRangeEnd = 1088335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_freeMaskIndicesStorage_Private_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	public unsafe int levelCount
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1088347, RefRangeEnd = 1088351, XrefRangeStart = 1088346, XrefRangeEnd = 1088347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_levelCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BuddyAllocator()
	{
		Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "BuddyAllocator");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr);
		NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_Data");
		NativeFieldInfoPtr_m_ActiveFreeMaskCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_ActiveFreeMaskCounts");
		NativeFieldInfoPtr_m_FreeMasksStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_FreeMasksStorage");
		NativeFieldInfoPtr_m_FreeMaskIndicesStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_FreeMaskIndicesStorage");
		NativeFieldInfoPtr_m_Allocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, "m_Allocator");
		NativeMethodInfoPtr_get_header_Private_get_byref_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664738);
		NativeMethodInfoPtr_get_freeMaskCounts_Private_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664739);
		NativeMethodInfoPtr_get_freeMasksStorage_Private_get_NativeArray_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664740);
		NativeMethodInfoPtr_FreeMasks_Private_NativeArray_1_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664741);
		NativeMethodInfoPtr_get_freeMaskIndicesStorage_Private_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664742);
		NativeMethodInfoPtr_FreeMaskIndices_Private_NativeArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664743);
		NativeMethodInfoPtr_get_levelCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664744);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664745);
		NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_byref_BuddyAllocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664746);
		NativeMethodInfoPtr_Free_Public_Void_BuddyAllocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664747);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664748);
		NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664749);
		NativeMethodInfoPtr_LevelOffset_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664750);
		NativeMethodInfoPtr_LevelLength_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664751);
		NativeMethodInfoPtr_LevelOffset64_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664752);
		NativeMethodInfoPtr_LevelLength64_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664753);
		NativeMethodInfoPtr_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664754);
		NativeMethodInfoPtr_AlignForward_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664755);
		NativeMethodInfoPtr_PtrAdd_Private_Static_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664756);
		NativeMethodInfoPtr_Pow2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664757);
		NativeMethodInfoPtr_Pow2N_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr, 100664758);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1088328, RefRangeEnd = 1088332, XrefRangeStart = 1088320, XrefRangeEnd = 1088328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<ulong> FreeMasks(int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeMasks_Private_NativeArray_1_UInt64_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<ulong>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1088343, RefRangeEnd = 1088346, XrefRangeStart = 1088335, XrefRangeEnd = 1088343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<int> FreeMaskIndices(int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeMaskIndices_Private_NativeArray_1_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088366, RefRangeEnd = 1088367, XrefRangeStart = 1088351, XrefRangeEnd = 1088366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BuddyAllocator(int levelCount, int branchingOrder, Allocator allocator = Allocator.Persistent)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&levelCount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &branchingOrder;
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Allocator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088377, RefRangeEnd = 1088378, XrefRangeStart = 1088367, XrefRangeEnd = 1088377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryAllocate(int requestedLevel, out BuddyAllocation allocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&requestedLevel);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allocation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAllocate_Public_Boolean_Int32_byref_BuddyAllocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1088389, RefRangeEnd = 1088391, XrefRangeStart = 1088378, XrefRangeEnd = 1088389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Free(BuddyAllocation allocation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&allocation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Free_Public_Void_BuddyAllocation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088392, RefRangeEnd = 1088393, XrefRangeStart = 1088391, XrefRangeEnd = 1088392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1088396, RefRangeEnd = 1088404, XrefRangeStart = 1088393, XrefRangeEnd = 1088396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<T> GetNativeArray<T>(int offset, int length) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_Int32_Int32_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<T>(pointer);
	}

	[CallerCount(0)]
	public unsafe static int LevelOffset(int level, int branchingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &branchingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelOffset_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int LevelLength(int level, int branchingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &branchingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelLength_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int LevelOffset64(int level, int branchingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &branchingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelOffset64_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int LevelLength64(int level, int branchingOrder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&level);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &branchingOrder;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LevelLength64_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1088410, RefRangeEnd = 1088412, XrefRangeStart = 1088404, XrefRangeEnd = 1088410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&length);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dataSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AllocateRange_Private_Static_ValueTuple_2_Int32_Int32_Int32_byref_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<int, int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088412, RefRangeEnd = 1088413, XrefRangeStart = 1088412, XrefRangeEnd = 1088412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AlignForward(int offset, int alignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&offset);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignForward_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088416, RefRangeEnd = 1088417, XrefRangeStart = 1088413, XrefRangeEnd = 1088416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* PtrAdd(void* ptr, int bytes)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)ptr;
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrAdd_Private_Static_ptr_Void_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(0)]
	public unsafe static int Pow2(int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pow2_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int Pow2N(int x, int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Pow2N_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BuddyAllocator(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BuddyAllocator()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuddyAllocator>.NativeClassPtr))
	{
	}
}
