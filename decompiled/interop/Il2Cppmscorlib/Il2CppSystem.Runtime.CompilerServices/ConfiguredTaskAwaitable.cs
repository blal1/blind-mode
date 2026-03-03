using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class ConfiguredTaskAwaitable : ValueType
{
	public sealed class ConfiguredTaskAwaiter : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_task;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		public unsafe Task m_task
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_task);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_task)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool m_continueOnCapturedContext
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_continueOnCapturedContext);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
			}
		}

		public unsafe bool IsCompleted
		{
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 805809, RefRangeEnd = 805902, XrefRangeStart = 805809, XrefRangeEnd = 805902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ConfiguredTaskAwaiter()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "ConfiguredTaskAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr);
			NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
			NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
			NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671442);
			NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671443);
			NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671444);
			NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671445);
			NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671446);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 203432, RefRangeEnd = 203443, XrefRangeStart = 203432, XrefRangeEnd = 203443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &continueOnCapturedContext;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 806073, RefRangeEnd = 806075, XrefRangeStart = 806070, XrefRangeEnd = 806073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 806078, RefRangeEnd = 806079, XrefRangeStart = 806075, XrefRangeEnd = 806078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 805907, RefRangeEnd = 805964, XrefRangeStart = 805907, XrefRangeEnd = 805964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ConfiguredTaskAwaiter(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ConfiguredTaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0;

	public unsafe ConfiguredTaskAwaiter m_configuredTaskAwaiter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_configuredTaskAwaiter);
			return new ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static ConfiguredTaskAwaitable()
	{
		Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr);
		NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "m_configuredTaskAwaiter");
		NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100671440);
		NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100671441);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 806081, RefRangeEnd = 806085, XrefRangeStart = 806079, XrefRangeEnd = 806081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &continueOnCapturedContext;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfiguredTaskAwaiter GetAwaiter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ConfiguredTaskAwaiter(pointer);
	}

	public ConfiguredTaskAwaitable(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ConfiguredTaskAwaitable()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
	{
	}
}
public sealed class ConfiguredTaskAwaitable<TResult> : ValueType
{
	public sealed class ConfiguredTaskAwaiter : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_task;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;

		public unsafe Task<TResult> m_task
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_task);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_task)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool m_continueOnCapturedContext
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_continueOnCapturedContext);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
			}
		}

		public unsafe bool IsCompleted
		{
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 805809, RefRangeEnd = 805902, XrefRangeStart = 805809, XrefRangeEnd = 805902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static ConfiguredTaskAwaiter()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, "ConfiguredTaskAwaiter"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr);
			NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
			NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
			NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671449);
			NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671450);
			NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671451);
			NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, 100671452);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 203432, RefRangeEnd = 203443, XrefRangeStart = 203432, XrefRangeEnd = 203443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaiter(Task<TResult> task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &continueOnCapturedContext;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 806086, RefRangeEnd = 806088, XrefRangeStart = 806085, XrefRangeEnd = 806086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)continuation);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 806049, RefRangeEnd = 806070, XrefRangeStart = 806049, XrefRangeEnd = 806070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr2, false, true);
		}

		public ConfiguredTaskAwaiter(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ConfiguredTaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0;

	public unsafe ConfiguredTaskAwaiter m_configuredTaskAwaiter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_configuredTaskAwaiter);
			return new ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaiter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static ConfiguredTaskAwaitable()
	{
		Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr);
		NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, "m_configuredTaskAwaiter");
		NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, 100671447);
		NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr, 100671448);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 806091, RefRangeEnd = 806092, XrefRangeStart = 806088, XrefRangeEnd = 806091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfiguredTaskAwaitable(Task<TResult> task, bool continueOnCapturedContext)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)task);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &continueOnCapturedContext;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 732551, RefRangeEnd = 732556, XrefRangeStart = 732551, XrefRangeEnd = 732556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConfiguredTaskAwaiter GetAwaiter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ConfiguredTaskAwaiter(pointer);
	}

	public ConfiguredTaskAwaitable(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ConfiguredTaskAwaitable()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable<TResult>>.NativeClassPtr))
	{
	}
}
