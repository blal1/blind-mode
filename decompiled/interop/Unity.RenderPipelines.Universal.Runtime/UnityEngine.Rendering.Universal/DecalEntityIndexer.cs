using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

public class DecalEntityIndexer : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DecalEntityItem
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_chunkIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_arrayIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_version;

		[FieldOffset(0)]
		public int chunkIndex;

		[FieldOffset(4)]
		public int arrayIndex;

		[FieldOffset(8)]
		public int version;

		static DecalEntityItem()
		{
			Il2CppClassPointerStore<DecalEntityItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, "DecalEntityItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityItem>.NativeClassPtr);
			NativeFieldInfoPtr_chunkIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityItem>.NativeClassPtr, "chunkIndex");
			NativeFieldInfoPtr_arrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityItem>.NativeClassPtr, "arrayIndex");
			NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityItem>.NativeClassPtr, "version");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalEntityItem>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Entities;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeIndices;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetItem_Public_DecalEntityItem_DecalEntity_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateIndex_Public_Void_DecalEntity_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemapChunkIndices_Public_Void_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<DecalEntityItem> m_Entities
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Entities);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DecalEntityItem>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Entities)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Queue<int> m_FreeIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeIndices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Queue<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DecalEntityIndexer()
	{
		Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DecalEntityIndexer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, "m_Entities");
		NativeFieldInfoPtr_m_FreeIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, "m_FreeIndices");
		NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664098);
		NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664099);
		NativeMethodInfoPtr_GetItem_Public_DecalEntityItem_DecalEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664100);
		NativeMethodInfoPtr_UpdateIndex_Public_Void_DecalEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664101);
		NativeMethodInfoPtr_RemapChunkIndices_Public_Void_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664102);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664103);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr, 100664104);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1081785, RefRangeEnd = 1081788, XrefRangeStart = 1081781, XrefRangeEnd = 1081785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid(DecalEntity decalEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&decalEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1081797, RefRangeEnd = 1081798, XrefRangeStart = 1081788, XrefRangeEnd = 1081797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&arrayIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &chunkIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDecalEntity_Public_DecalEntity_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DecalEntity*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081798, XrefRangeEnd = 1081807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyDecalEntity(DecalEntity decalEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&decalEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyDecalEntity_Public_Void_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081807, XrefRangeEnd = 1081810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalEntityItem GetItem(DecalEntity decalEntity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&decalEntity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItem_Public_DecalEntityItem_DecalEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DecalEntityItem*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081810, XrefRangeEnd = 1081816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateIndex(DecalEntity decalEntity, int newArrayIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&decalEntity);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newArrayIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateIndex_Public_Void_DecalEntity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081816, XrefRangeEnd = 1081829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemapChunkIndices(List<int> remaper)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)remaper);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemapChunkIndices_Public_Void_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081829, XrefRangeEnd = 1081834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1081834, XrefRangeEnd = 1081849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecalEntityIndexer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalEntityIndexer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DecalEntityIndexer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
