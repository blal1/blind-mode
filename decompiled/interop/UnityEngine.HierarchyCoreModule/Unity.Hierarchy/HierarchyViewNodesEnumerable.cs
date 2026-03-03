using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Unity.Hierarchy;

public sealed class HierarchyViewNodesEnumerable : Il2CppSystem.ValueType
{
	public sealed class Predicate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0;

		static Predicate()
		{
			Il2CppClassPointerStore<Predicate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, "Predicate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Predicate>.NativeClassPtr, 100663365);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Predicate>.NativeClassPtr, 100663366);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242944, XrefRangeEnd = 1242948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Predicate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Predicate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual bool Invoke([In] ref HierarchyNode node, HierarchyNodeFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref node);
			*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_HierarchyNode_HierarchyNodeFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public Predicate(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class Enumerator : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_HierarchyFlattened;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Predicate;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NodesPtr;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_NodesCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Version;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewNodesEnumerable_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_byref_HierarchyNode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfVersionChanged_Private_Void_0;

		public unsafe HierarchyFlattened m_HierarchyFlattened
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyFlattened);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyFlattened>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyFlattened)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Predicate m_Predicate
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Predicate);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Predicate>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Predicate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe HierarchyNodeFlags m_Flags
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
				return *(HierarchyNodeFlags*)num;
			}
			set
			{
				*(HierarchyNodeFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		public unsafe HierarchyFlattenedNode* m_NodesPtr
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesPtr);
				return *(HierarchyFlattenedNode**)num;
			}
			set
			{
				*(HierarchyFlattenedNode**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesPtr)) = value;
			}
		}

		public unsafe int m_NodesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NodesCount)) = value;
			}
		}

		public unsafe int m_Version
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version)) = value;
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

		public unsafe ref HierarchyNode Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242951, XrefRangeEnd = 1242952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_byref_HierarchyNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return ref *(HierarchyNode*)intPtr2;
			}
		}

		static Enumerator()
		{
			Il2CppClassPointerStore<Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, "Enumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerator>.NativeClassPtr);
			NativeFieldInfoPtr_m_HierarchyFlattened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_HierarchyFlattened");
			NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Predicate");
			NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Flags");
			NativeFieldInfoPtr_m_NodesPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_NodesPtr");
			NativeFieldInfoPtr_m_NodesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_NodesCount");
			NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Version");
			NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "m_Index");
			NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewNodesEnumerable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663367);
			NativeMethodInfoPtr_get_Current_Public_get_byref_HierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663368);
			NativeMethodInfoPtr_MoveNext_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663369);
			NativeMethodInfoPtr_ThrowIfVersionChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100663370);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242948, XrefRangeEnd = 1242951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Enumerator(HierarchyViewNodesEnumerable enumerable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)enumerable));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewNodesEnumerable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242952, XrefRangeEnd = 1242953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1242953, RefRangeEnd = 1242955, XrefRangeStart = 1242953, XrefRangeEnd = 1242953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfVersionChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfVersionChanged_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
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

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HierarchyViewModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Predicate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewModel_HierarchyNodeFlags_Predicate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0;

	public unsafe HierarchyViewModel m_HierarchyViewModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyViewModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HierarchyViewModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HierarchyViewModel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Predicate m_Predicate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Predicate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Predicate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Predicate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HierarchyNodeFlags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(HierarchyNodeFlags*)num;
		}
		set
		{
			*(HierarchyNodeFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	static HierarchyViewNodesEnumerable()
	{
		Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "Unity.Hierarchy", "HierarchyViewNodesEnumerable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr);
		NativeFieldInfoPtr_m_HierarchyViewModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, "m_HierarchyViewModel");
		NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, "m_Predicate");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, "m_Flags");
		NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewModel_HierarchyNodeFlags_Predicate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr, 100663364);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242955, XrefRangeEnd = 1242957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HierarchyViewNodesEnumerable(HierarchyViewModel viewModel, HierarchyNodeFlags flags, Predicate predicate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)viewModel);
		*(HierarchyNodeFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_HierarchyViewModel_HierarchyNodeFlags_Predicate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1242960, RefRangeEnd = 1242961, XrefRangeStart = 1242957, XrefRangeEnd = 1242960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Enumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_Enumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Enumerator(pointer);
	}

	public HierarchyViewNodesEnumerable(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HierarchyViewNodesEnumerable()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HierarchyViewNodesEnumerable>.NativeClassPtr))
	{
	}
}
