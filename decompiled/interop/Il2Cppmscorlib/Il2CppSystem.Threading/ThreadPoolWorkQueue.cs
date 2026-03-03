using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public sealed class ThreadPoolWorkQueue : Object
{
	public class SparseArray<T> : Object where T : class
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_array;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Add_Internal_Int32_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Internal_Void_T_0;

		public unsafe Il2CppArrayBase<T> m_array
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_array);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_array)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppArrayBase<T> Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 771195, RefRangeEnd = 771196, XrefRangeStart = 771194, XrefRangeEnd = 771195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
			}
		}

		static SparseArray()
		{
			Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "SparseArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr);
			NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr, "m_array");
			NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr, 100667949);
			NativeMethodInfoPtr_get_Current_Internal_get_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr, 100667950);
			NativeMethodInfoPtr_Add_Internal_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr, 100667951);
			NativeMethodInfoPtr_Remove_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr, 100667952);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771189, XrefRangeEnd = 771194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SparseArray(int initialSize)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparseArray<T>>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&initialSize);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 771215, RefRangeEnd = 771216, XrefRangeStart = 771196, XrefRangeEnd = 771215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Add(T e)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = e;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref e;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Internal_Int32_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 771229, RefRangeEnd = 771230, XrefRangeStart = 771216, XrefRangeEnd = 771229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T e)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref T reference;
			if (!typeof(T).IsValueType)
			{
				T val = e;
				reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
			}
			else
			{
				reference = ref e;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SparseArray(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class WorkStealingQueue : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_array;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_mask;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_headIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_tailIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_foreignLock;

		private static readonly System.IntPtr NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> m_array
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_array);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_array)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int m_mask
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_mask);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_mask)) = value;
			}
		}

		public unsafe int m_headIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_headIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_headIndex)) = value;
			}
		}

		public unsafe int m_tailIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tailIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_tailIndex)) = value;
			}
		}

		public unsafe SpinLock m_foreignLock
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_foreignLock);
				return *(SpinLock*)num;
			}
			set
			{
				*(SpinLock*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_foreignLock)) = value;
			}
		}

		static WorkStealingQueue()
		{
			Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "WorkStealingQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr);
			NativeFieldInfoPtr_m_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, "m_array");
			NativeFieldInfoPtr_m_mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, "m_mask");
			NativeFieldInfoPtr_m_headIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, "m_headIndex");
			NativeFieldInfoPtr_m_tailIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, "m_tailIndex");
			NativeFieldInfoPtr_m_foreignLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, "m_foreignLock");
			NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, 100667953);
			NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, 100667954);
			NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, 100667955);
			NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, 100667956);
			NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, 100667957);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr, 100667958);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 771298, RefRangeEnd = 771299, XrefRangeStart = 771230, XrefRangeEnd = 771298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPush(IThreadPoolWorkItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalPush_Public_Void_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 771326, RefRangeEnd = 771328, XrefRangeStart = 771299, XrefRangeEnd = 771326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalFindAndPop(IThreadPoolWorkItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalFindAndPop_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 771369, RefRangeEnd = 771370, XrefRangeStart = 771328, XrefRangeEnd = 771369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalPop(out IThreadPoolWorkItem obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			nint num = 0;
			*ptr = (nint)(&num);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalPop_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num2 = num;
			obj = ((num2 == 0) ? null : new IThreadPoolWorkItem(num2));
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771370, XrefRangeEnd = 771371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			nint num = 0;
			*ptr = (nint)(&num);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref missedSteal);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySteal_Public_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num2 = num;
			obj = ((num2 == 0) ? null : new IThreadPoolWorkItem(num2));
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 771406, RefRangeEnd = 771408, XrefRangeStart = 771371, XrefRangeEnd = 771406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			nint num = 0;
			*ptr = (nint)(&num);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref missedSteal);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &millisecondsTimeout;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrySteal_Private_Boolean_byref_IThreadPoolWorkItem_byref_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num2 = num;
			obj = ((num2 == 0) ? null : new IThreadPoolWorkItem(num2));
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771408, XrefRangeEnd = 771418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorkStealingQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorkStealingQueue>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public WorkStealingQueue(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class QueueSegment : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

		private static readonly System.IntPtr NativeFieldInfoPtr_indexes;

		private static readonly System.IntPtr NativeFieldInfoPtr_Next;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0;

		public unsafe Il2CppReferenceArray<IThreadPoolWorkItem> nodes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IThreadPoolWorkItem>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int indexes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexes);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indexes)) = value;
			}
		}

		public unsafe QueueSegment Next
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QueueSegment>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static QueueSegment()
		{
			Il2CppClassPointerStore<QueueSegment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "QueueSegment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr);
			NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, "nodes");
			NativeFieldInfoPtr_indexes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, "indexes");
			NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, "Next");
			NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, 100667959);
			NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, 100667960);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, 100667961);
			NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, 100667962);
			NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, 100667963);
			NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr, 100667964);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771418, XrefRangeEnd = 771419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetIndexes(out int upper, out int lower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref upper);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lower);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndexes_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771419, XrefRangeEnd = 771421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)Unsafe.AsPointer(ref prevUpper);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newUpper;
			*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref prevLower);
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &newLower;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareExchangeIndexes_Private_Boolean_byref_Int32_Int32_byref_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771421, XrefRangeEnd = 771426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QueueSegment()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueueSegment>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771426, XrefRangeEnd = 771427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUsedUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsedUp_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771427, XrefRangeEnd = 771432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnqueue(IThreadPoolWorkItem node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnqueue_Public_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771432, XrefRangeEnd = 771448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDequeue(out IThreadPoolWorkItem node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			nint num = 0;
			*ptr = (nint)(&num);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryDequeue_Public_Boolean_byref_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num2 = num;
			node = ((num2 == 0) ? null : new IThreadPoolWorkItem(num2));
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public QueueSegment(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_queueHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_queueTail;

	private static readonly System.IntPtr NativeFieldInfoPtr_allThreadQueues;

	private static readonly System.IntPtr NativeFieldInfoPtr_numOutstandingThreadRequests;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0;

	public unsafe QueueSegment queueHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queueHead);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QueueSegment>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queueHead)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe QueueSegment queueTail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queueTail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<QueueSegment>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queueTail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SparseArray<WorkStealingQueue> allThreadQueues
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_allThreadQueues, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparseArray<WorkStealingQueue>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_allThreadQueues, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int numOutstandingThreadRequests
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numOutstandingThreadRequests);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numOutstandingThreadRequests)) = value;
		}
	}

	static ThreadPoolWorkQueue()
	{
		Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPoolWorkQueue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr);
		NativeFieldInfoPtr_queueHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueHead");
		NativeFieldInfoPtr_queueTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "queueTail");
		NativeFieldInfoPtr_allThreadQueues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "allThreadQueues");
		NativeFieldInfoPtr_numOutstandingThreadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, "numOutstandingThreadRequests");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667940);
		NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667941);
		NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667942);
		NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667943);
		NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667944);
		NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667945);
		NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667946);
		NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr, 100667947);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771448, XrefRangeEnd = 771461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThreadPoolWorkQueue()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolWorkQueue>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771461, XrefRangeEnd = 771474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureCurrentThreadHasQueue_Public_ThreadPoolWorkQueueThreadLocals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ThreadPoolWorkQueueThreadLocals>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 771483, RefRangeEnd = 771487, XrefRangeStart = 771474, XrefRangeEnd = 771483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureThreadRequested()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureThreadRequested_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771487, XrefRangeEnd = 771490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MarkThreadRequestSatisfied()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkThreadRequestSatisfied_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771490, XrefRangeEnd = 771522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &forceGlobal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Enqueue_Public_Void_IThreadPoolWorkItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771522, XrefRangeEnd = 771526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LocalFindAndPop(IThreadPoolWorkItem callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalFindAndPop_Internal_Boolean_IThreadPoolWorkItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 771526, XrefRangeEnd = 771560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tl);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref missedSteal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dequeue_Public_Void_ThreadPoolWorkQueueThreadLocals_byref_IThreadPoolWorkItem_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		callback = ((num3 == 0) ? null : new IThreadPoolWorkItem(num3));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 771605, RefRangeEnd = 771606, XrefRangeStart = 771560, XrefRangeEnd = 771605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Dispatch()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispatch_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ThreadPoolWorkQueue(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
