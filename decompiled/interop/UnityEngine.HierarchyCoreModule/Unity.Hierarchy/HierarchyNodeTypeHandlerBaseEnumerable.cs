using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Buffers;

namespace Unity.Hierarchy;

public sealed class HierarchyNodeTypeHandlerBaseEnumerable : Il2CppSystem.ValueType
{
	public sealed class Enumerator : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Handlers;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_HierarchyNodeTypeHandlerBase_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

		public unsafe IMemoryOwner<System.IntPtr> m_Handlers
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Handlers);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMemoryOwner<System.IntPtr>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Handlers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_Count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Count);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		public unsafe int m_Index
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		public unsafe HierarchyNodeTypeHandlerBase Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242886, XrefRangeEnd = 1242900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_HierarchyNodeTypeHandlerBase_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyNodeTypeHandlerBase>(intPtr2) : null;
			}
		}

		static Enumerator()
		{
			Il2CppClassPointerStore<Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr, "Enumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerator>.NativeClassPtr);
			NativeFieldInfoPtr_m_Handlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Handlers");
			NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Count");
			NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Index");
			NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663348);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663349);
			NativeMethodInfoPtr_get_Current_Public_get_HierarchyNodeTypeHandlerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663350);
			NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663351);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242878, RefRangeEnd = 1242880, XrefRangeStart = 1242850, XrefRangeEnd = 1242878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Enumerator(Hierarchy hierarchy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchy);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242884, RefRangeEnd = 1242886, XrefRangeStart = 1242880, XrefRangeEnd = 1242884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public Enumerator(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Enumerator()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerator>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0;

	public unsafe Hierarchy m_Hierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hierarchy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static HierarchyNodeTypeHandlerBaseEnumerable()
	{
		Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyNodeTypeHandlerBaseEnumerable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr, "m_Hierarchy");
		NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr, 100663347);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyNodeTypeHandlerBaseEnumerable(Hierarchy hierarchy)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hierarchy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Hierarchy_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242900, XrefRangeEnd = 1242901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Enumerator(pointer);
	}

	public HierarchyNodeTypeHandlerBaseEnumerable(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HierarchyNodeTypeHandlerBaseEnumerable()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyNodeTypeHandlerBaseEnumerable>.NativeClassPtr))
	{
	}
}
