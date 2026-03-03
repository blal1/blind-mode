using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class AsyncValueTaskMethodBuilder : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__methodBuilder;

	private static readonly System.IntPtr NativeFieldInfoPtr__haveResult;

	private static readonly System.IntPtr NativeFieldInfoPtr__useBuilder;

	public unsafe AsyncTaskMethodBuilder _methodBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__methodBuilder);
			return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__methodBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool _haveResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__haveResult);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__haveResult)) = value;
		}
	}

	public unsafe bool _useBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useBuilder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useBuilder)) = value;
		}
	}

	static AsyncValueTaskMethodBuilder()
	{
		Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncValueTaskMethodBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr);
		NativeFieldInfoPtr__methodBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, "_methodBuilder");
		NativeFieldInfoPtr__haveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, "_haveResult");
		NativeFieldInfoPtr__useBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr, "_useBuilder");
	}

	public AsyncValueTaskMethodBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AsyncValueTaskMethodBuilder()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder>.NativeClassPtr))
	{
	}
}
public sealed class AsyncValueTaskMethodBuilder<TResult> : ValueType
{
	private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncValueTaskMethodBuilder<TResult>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__methodBuilder;

	private static readonly System.IntPtr NativeFieldInfoPtr__result;

	private static readonly System.IntPtr NativeFieldInfoPtr__haveResult;

	private static readonly System.IntPtr NativeFieldInfoPtr__useBuilder;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_1_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Public_Void_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Task_Public_get_ValueTask_1_TResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

	public unsafe AsyncTaskMethodBuilder<TResult> _methodBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__methodBuilder);
			return new AsyncTaskMethodBuilder<TResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__methodBuilder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TResult _result
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__result);
			return IL2CPP.PointerToValueGeneric<TResult>((System.IntPtr)num, true, false);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__result);
			System.Type typeFromHandle = typeof(TResult);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					object obj = value;
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null));
					if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						System.IntPtr intPtr2 = intPtr;
						// IL cpblk instruction
						System.Runtime.CompilerServices.Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
					}
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(value as string));
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.Write((void*)num2, value);
			}
		}
	}

	public unsafe bool _haveResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__haveResult);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__haveResult)) = value;
		}
	}

	public unsafe bool _useBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useBuilder);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useBuilder)) = value;
		}
	}

	public unsafe ValueTask<TResult> Task
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 805566, RefRangeEnd = 805568, XrefRangeStart = 805555, XrefRangeEnd = 805566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Task_Public_get_ValueTask_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTask<TResult>(pointer);
		}
	}

	static AsyncValueTaskMethodBuilder()
	{
		Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncValueTaskMethodBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr);
		NativeFieldInfoPtr__methodBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_methodBuilder");
		NativeFieldInfoPtr__result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_result");
		NativeFieldInfoPtr__haveResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_haveResult");
		NativeFieldInfoPtr__useBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, "_useBuilder");
		NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671364);
		NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671365);
		NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671366);
		NativeMethodInfoPtr_SetResult_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671367);
		NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671368);
		NativeMethodInfoPtr_get_Task_Public_get_ValueTask_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671369);
		NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr, 100671370);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805504, RefRangeEnd = 805506, XrefRangeStart = 805504, XrefRangeEnd = 805504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncValueTaskMethodBuilder<TResult> Create()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AsyncValueTaskMethodBuilder_1_TResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new AsyncValueTaskMethodBuilder<TResult>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805506, XrefRangeEnd = 805511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start<TStateMachine>(ref TStateMachine stateMachine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TStateMachine>.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr4 == (System.IntPtr)0) ? ((TStateMachine)null) : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805548, RefRangeEnd = 805549, XrefRangeStart = 805511, XrefRangeEnd = 805548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stateMachine);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805549, RefRangeEnd = 805550, XrefRangeStart = 805549, XrefRangeEnd = 805549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetResult(TResult result)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TResult reference;
		if (!typeof(TResult).IsValueType)
		{
			object obj = result;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref result;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResult_Public_Void_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805550, XrefRangeEnd = 805555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetException(Exception exception)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805568, XrefRangeEnd = 805589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine));
		*(System.IntPtr**)num = &intPtr2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(AsyncValueTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<TAwaiter, object>(ref awaiter) = ((intPtr5 == (System.IntPtr)0) ? ((TAwaiter)null) : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
		System.IntPtr intPtr6 = intPtr2;
		System.Runtime.CompilerServices.Unsafe.As<TStateMachine, object>(ref stateMachine) = ((intPtr6 == (System.IntPtr)0) ? ((TStateMachine)null) : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
	}

	public AsyncValueTaskMethodBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AsyncValueTaskMethodBuilder()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncValueTaskMethodBuilder<TResult>>.NativeClassPtr))
	{
	}
}
