using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public class ProbeVolumeScratchBufferPool : Il2CppSystem.Object
{
	public class ScratchBufferPool : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_chunkCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_pool;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScratchBufferPool_0;

		public unsafe int chunkCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chunkCount)) = value;
			}
		}

		public unsafe Stack<ProbeReferenceVolume.CellStreamingScratchBuffer> pool
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pool);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<ProbeReferenceVolume.CellStreamingScratchBuffer>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pool)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static ScratchBufferPool()
		{
			Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "ScratchBufferPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr);
			NativeFieldInfoPtr_chunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr, "chunkCount");
			NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr, "pool");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr, 100665869);
			NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr, 100665870);
			NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScratchBufferPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr, 100665871);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045150, XrefRangeEnd = 1045158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScratchBufferPool(int chunkCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&chunkCount);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045158, XrefRangeEnd = 1045227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScratchBufferPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScratchBufferPool>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual int CompareTo(ScratchBufferPool other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ScratchBufferPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public ScratchBufferPool(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.ProbeVolumeScratchBufferPool+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__26_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AllocateScratchBuffer_b__26_0_Internal_Boolean_ScratchBufferPool_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ReleaseScratchBuffer_b__27_0_Internal_Boolean_ScratchBufferPool_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ScratchBufferPool> __9__26_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ScratchBufferPool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__26_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Predicate<ScratchBufferPool> __9__27_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ScratchBufferPool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__26_0");
			NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665873);
			NativeMethodInfoPtr__AllocateScratchBuffer_b__26_0_Internal_Boolean_ScratchBufferPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665874);
			NativeMethodInfoPtr__ReleaseScratchBuffer_b__27_0_Internal_Boolean_ScratchBufferPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665875);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045227, XrefRangeEnd = 1045229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _AllocateScratchBuffer_b__26_0(ScratchBufferPool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AllocateScratchBuffer_b__26_0_Internal_Boolean_ScratchBufferPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045229, XrefRangeEnd = 1045231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ReleaseScratchBuffer_b__27_0(ScratchBufferPool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ReleaseScratchBuffer_b__27_0_Internal_Boolean_ScratchBufferPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__chunkSize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxChunkCount_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_L0Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_L1Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValiditySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValidityLayerCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_L2Size;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeOcclusionSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SkyOcclusionSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SkyShadingDirectionSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentlyAllocatedChunkCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pools;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Layouts;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ChunkCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_chunkSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_chunkSize_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxChunkCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_maxChunkCount_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allocatedMemory_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProbeVolumeBakingSet_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateScratchBufferLayout_Private_CellStreamingScratchBufferLayout_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateScratchBuffer_Private_CellStreamingScratchBuffer_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateScratchBuffer_Public_Boolean_Int32_byref_CellStreamingScratchBuffer_byref_CellStreamingScratchBufferLayout_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseScratchBuffer_Public_Void_CellStreamingScratchBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Public_Void_0;

	public unsafe int _chunkSize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkSize_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__chunkSize_k__BackingField)) = value;
		}
	}

	public unsafe int _maxChunkCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxChunkCount_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__maxChunkCount_k__BackingField)) = value;
		}
	}

	public unsafe int m_L0Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_L0Size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_L0Size)) = value;
		}
	}

	public unsafe int m_L1Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_L1Size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_L1Size)) = value;
		}
	}

	public unsafe int m_ValiditySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValiditySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValiditySize)) = value;
		}
	}

	public unsafe int m_ValidityLayerCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValidityLayerCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValidityLayerCount)) = value;
		}
	}

	public unsafe int m_L2Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_L2Size);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_L2Size)) = value;
		}
	}

	public unsafe int m_ProbeOcclusionSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOcclusionSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOcclusionSize)) = value;
		}
	}

	public unsafe int m_SkyOcclusionSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkyOcclusionSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkyOcclusionSize)) = value;
		}
	}

	public unsafe int m_SkyShadingDirectionSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkyShadingDirectionSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkyShadingDirectionSize)) = value;
		}
	}

	public unsafe int m_CurrentlyAllocatedChunkCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentlyAllocatedChunkCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentlyAllocatedChunkCount)) = value;
		}
	}

	public unsafe List<ScratchBufferPool> m_Pools
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pools);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ScratchBufferPool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pools)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, ProbeReferenceVolume.CellStreamingScratchBufferLayout> m_Layouts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Layouts);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ProbeReferenceVolume.CellStreamingScratchBufferLayout>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Layouts)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_ChunkCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ChunkCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ChunkCount, (void*)(&value));
		}
	}

	public unsafe int chunkSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_chunkSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_chunkSize_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int maxChunkCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxChunkCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_maxChunkCount_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int allocatedMemory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allocatedMemory_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ProbeVolumeScratchBufferPool()
	{
		Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolumeScratchBufferPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr);
		NativeFieldInfoPtr__chunkSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "<chunkSize>k__BackingField");
		NativeFieldInfoPtr__maxChunkCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "<maxChunkCount>k__BackingField");
		NativeFieldInfoPtr_m_L0Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_L0Size");
		NativeFieldInfoPtr_m_L1Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_L1Size");
		NativeFieldInfoPtr_m_ValiditySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_ValiditySize");
		NativeFieldInfoPtr_m_ValidityLayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_ValidityLayerCount");
		NativeFieldInfoPtr_m_L2Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_L2Size");
		NativeFieldInfoPtr_m_ProbeOcclusionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_ProbeOcclusionSize");
		NativeFieldInfoPtr_m_SkyOcclusionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_SkyOcclusionSize");
		NativeFieldInfoPtr_m_SkyShadingDirectionSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_SkyShadingDirectionSize");
		NativeFieldInfoPtr_m_CurrentlyAllocatedChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_CurrentlyAllocatedChunkCount");
		NativeFieldInfoPtr_m_Pools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_Pools");
		NativeFieldInfoPtr_m_Layouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "m_Layouts");
		NativeFieldInfoPtr_s_ChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, "s_ChunkCount");
		NativeMethodInfoPtr_get_chunkSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665858);
		NativeMethodInfoPtr_set_chunkSize_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665859);
		NativeMethodInfoPtr_get_maxChunkCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665860);
		NativeMethodInfoPtr_set_maxChunkCount_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665861);
		NativeMethodInfoPtr_get_allocatedMemory_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665862);
		NativeMethodInfoPtr__ctor_Public_Void_ProbeVolumeBakingSet_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665863);
		NativeMethodInfoPtr_GetOrCreateScratchBufferLayout_Private_CellStreamingScratchBufferLayout_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665864);
		NativeMethodInfoPtr_CreateScratchBuffer_Private_CellStreamingScratchBuffer_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665865);
		NativeMethodInfoPtr_AllocateScratchBuffer_Public_Boolean_Int32_byref_CellStreamingScratchBuffer_byref_CellStreamingScratchBufferLayout_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665866);
		NativeMethodInfoPtr_ReleaseScratchBuffer_Public_Void_CellStreamingScratchBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665867);
		NativeMethodInfoPtr_Cleanup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr, 100665868);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1045246, RefRangeEnd = 1045248, XrefRangeStart = 1045231, XrefRangeEnd = 1045246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeVolumeScratchBufferPool(ProbeVolumeBakingSet bakingSet, ProbeVolumeSHBands shBands)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolumeScratchBufferPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bakingSet);
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shBands;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ProbeVolumeBakingSet_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045257, RefRangeEnd = 1045258, XrefRangeStart = 1045248, XrefRangeEnd = 1045257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeReferenceVolume.CellStreamingScratchBufferLayout GetOrCreateScratchBufferLayout(int chunkCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&chunkCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateScratchBufferLayout_Private_CellStreamingScratchBufferLayout_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ProbeReferenceVolume.CellStreamingScratchBufferLayout*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045274, RefRangeEnd = 1045275, XrefRangeStart = 1045258, XrefRangeEnd = 1045274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeReferenceVolume.CellStreamingScratchBuffer CreateScratchBuffer(int chunkCount, bool allocateGraphicsBuffers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&chunkCount);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateGraphicsBuffers;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateScratchBuffer_Private_CellStreamingScratchBuffer_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeReferenceVolume.CellStreamingScratchBuffer>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1045321, RefRangeEnd = 1045322, XrefRangeStart = 1045275, XrefRangeEnd = 1045321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AllocateScratchBuffer(int chunkCount, out ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer, out ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, bool allocateGraphicsBuffers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&chunkCount);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref layout);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateGraphicsBuffers;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateScratchBuffer_Public_Boolean_Int32_byref_CellStreamingScratchBuffer_byref_CellStreamingScratchBufferLayout_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		scratchBuffer = ((num3 == 0) ? null : new ProbeReferenceVolume.CellStreamingScratchBuffer(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1045345, RefRangeEnd = 1045347, XrefRangeStart = 1045322, XrefRangeEnd = 1045345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReleaseScratchBuffer(ProbeReferenceVolume.CellStreamingScratchBuffer scratchBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scratchBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseScratchBuffer_Public_Void_CellStreamingScratchBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1045368, RefRangeEnd = 1045372, XrefRangeStart = 1045347, XrefRangeEnd = 1045368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeVolumeScratchBufferPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
