using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Buffers;

public sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
{
	[OriginalName("mscorlib.dll", "", "MemoryPressure")]
	public enum MemoryPressure
	{
		Low,
		Medium,
		High
	}

	public sealed class PerCoreLockedStacks : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__perCoreStacks;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryPush_Public_Void_Il2CppArrayBase_1_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_Boolean_UInt32_Int32_MemoryPressure_T_Il2CppStructArray_1_Int32_0;

		public unsafe Il2CppReferenceArray<LockedStack> _perCoreStacks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__perCoreStacks);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LockedStack>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__perCoreStacks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static PerCoreLockedStacks()
		{
			Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "PerCoreLockedStacks"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr);
			NativeFieldInfoPtr__perCoreStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr, "_perCoreStacks");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr, 100674360);
			NativeMethodInfoPtr_TryPush_Public_Void_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr, 100674361);
			NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr, 100674362);
			NativeMethodInfoPtr_Trim_Public_Boolean_UInt32_Int32_MemoryPressure_T_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr, 100674363);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 833311, RefRangeEnd = 833313, XrefRangeStart = 833247, XrefRangeEnd = 833311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PerCoreLockedStacks()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PerCoreLockedStacks>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833313, XrefRangeEnd = 833319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryPush(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPush_Public_Void_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833319, XrefRangeEnd = 833326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> TryPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 833328, RefRangeEnd = 833329, XrefRangeStart = 833326, XrefRangeEnd = 833328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Trim(uint tickCount, int id, MemoryPressure pressure, Il2CppStructArray<int> bucketSizes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&tickCount);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
			*(MemoryPressure**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pressure;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bucketSizes);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_Boolean_UInt32_Int32_MemoryPressure_T_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public PerCoreLockedStacks(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class LockedStack : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__arrays;

		private static readonly System.IntPtr NativeFieldInfoPtr__count;

		private static readonly System.IntPtr NativeFieldInfoPtr__firstStackItemMS;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryPush_Public_Boolean_Il2CppArrayBase_1_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_Void_UInt32_Int32_MemoryPressure_T_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppReferenceArray<Il2CppArrayBase<T>> _arrays
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arrays);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppArrayBase<T>>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__arrays)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int _count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__count)) = value;
			}
		}

		public unsafe uint _firstStackItemMS
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__firstStackItemMS);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__firstStackItemMS)) = value;
			}
		}

		static LockedStack()
		{
			Il2CppClassPointerStore<LockedStack>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "LockedStack"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockedStack>.NativeClassPtr);
			NativeFieldInfoPtr__arrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, "_arrays");
			NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, "_count");
			NativeFieldInfoPtr__firstStackItemMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, "_firstStackItemMS");
			NativeMethodInfoPtr_TryPush_Public_Boolean_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, 100674364);
			NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, 100674365);
			NativeMethodInfoPtr_Trim_Public_Void_UInt32_Int32_MemoryPressure_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, 100674366);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockedStack>.NativeClassPtr, 100674367);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833329, XrefRangeEnd = 833336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPush(Il2CppArrayBase<T> array)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPush_Public_Boolean_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833336, XrefRangeEnd = 833339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppArrayBase<T> TryPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryPop_Public_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 833353, RefRangeEnd = 833354, XrefRangeStart = 833339, XrefRangeEnd = 833353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trim(uint tickCount, int id, MemoryPressure pressure, int bucketSize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&tickCount);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
			*(MemoryPressure**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pressure;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bucketSize;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_Void_UInt32_Int32_MemoryPressure_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 833358, RefRangeEnd = 833362, XrefRangeStart = 833354, XrefRangeEnd = 833358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockedStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockedStack>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public LockedStack(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__bucketArraySizes;

	private static readonly System.IntPtr NativeFieldInfoPtr__buckets;

	private static readonly System.IntPtr NativeFieldInfoPtr_t_tlsBuckets;

	private static readonly System.IntPtr NativeFieldInfoPtr__callbackCreated;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_trimBuffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_allTlsBuckets;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreatePerCoreLockedStacks_Private_PerCoreLockedStacks_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rent_Public_Virtual_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Return_Public_Virtual_Void_Il2CppArrayBase_1_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trim_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Gen2GcCallbackFunc_Private_Static_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMemoryPressure_Private_Static_MemoryPressure_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTrimBuffers_Private_Static_Boolean_0;

	public unsafe Il2CppStructArray<int> _bucketArraySizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bucketArraySizes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bucketArraySizes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<PerCoreLockedStacks> _buckets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buckets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PerCoreLockedStacks>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__buckets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppArrayBase<T>> t_tlsBuckets
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_t_tlsBuckets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppArrayBase<T>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_t_tlsBuckets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _callbackCreated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callbackCreated);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callbackCreated)) = value;
		}
	}

	public unsafe static bool s_trimBuffers
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_trimBuffers, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_trimBuffers, (void*)(&value));
		}
	}

	public unsafe static Il2CppSystem.Runtime.CompilerServices.ConditionalWeakTable<Il2CppReferenceArray<Il2CppArrayBase<T>>, Object> s_allTlsBuckets
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_allTlsBuckets, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Runtime.CompilerServices.ConditionalWeakTable<Il2CppReferenceArray<Il2CppArrayBase<T>>, Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_allTlsBuckets, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int Id
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833380, XrefRangeEnd = 833397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static TlsOverPerCoreLockedStacksArrayPool()
	{
		Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Buffers", "TlsOverPerCoreLockedStacksArrayPool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr);
		NativeFieldInfoPtr__bucketArraySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "_bucketArraySizes");
		NativeFieldInfoPtr__buckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "_buckets");
		NativeFieldInfoPtr_t_tlsBuckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "t_tlsBuckets");
		NativeFieldInfoPtr__callbackCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "_callbackCreated");
		NativeFieldInfoPtr_s_trimBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "s_trimBuffers");
		NativeFieldInfoPtr_s_allTlsBuckets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, "s_allTlsBuckets");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674350);
		NativeMethodInfoPtr_CreatePerCoreLockedStacks_Private_PerCoreLockedStacks_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674351);
		NativeMethodInfoPtr_get_Id_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674352);
		NativeMethodInfoPtr_Rent_Public_Virtual_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674353);
		NativeMethodInfoPtr_Return_Public_Virtual_Void_Il2CppArrayBase_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674354);
		NativeMethodInfoPtr_Trim_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674355);
		NativeMethodInfoPtr_Gen2GcCallbackFunc_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674356);
		NativeMethodInfoPtr_GetMemoryPressure_Private_Static_MemoryPressure_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674357);
		NativeMethodInfoPtr_GetTrimBuffers_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr, 100674358);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 833375, RefRangeEnd = 833376, XrefRangeStart = 833362, XrefRangeEnd = 833375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TlsOverPerCoreLockedStacksArrayPool()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsOverPerCoreLockedStacksArrayPool<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833376, XrefRangeEnd = 833380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&bucketIndex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreatePerCoreLockedStacks_Private_PerCoreLockedStacks_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PerCoreLockedStacks>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833397, XrefRangeEnd = 833410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppArrayBase<T> Rent(int minimumLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&minimumLength);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rent_Public_Virtual_Il2CppArrayBase_1_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833410, XrefRangeEnd = 833429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Return(Il2CppArrayBase<T> array, bool clearArray = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearArray;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Return_Public_Virtual_Void_Il2CppArrayBase_1_T_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 833487, RefRangeEnd = 833488, XrefRangeStart = 833429, XrefRangeEnd = 833487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Trim()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trim_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833488, XrefRangeEnd = 833519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Gen2GcCallbackFunc(Object target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Gen2GcCallbackFunc_Private_Static_Boolean_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 833519, XrefRangeEnd = 833523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MemoryPressure GetMemoryPressure()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMemoryPressure_Private_Static_MemoryPressure_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MemoryPressure*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetTrimBuffers()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTrimBuffers_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TlsOverPerCoreLockedStacksArrayPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
