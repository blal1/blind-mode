using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices;

public static class AsyncTaskCache : Object
{
	private sealed class MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0, Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_TrueTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_FalseTask;

	private static readonly System.IntPtr NativeFieldInfoPtr_Int32Tasks;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0;

	public unsafe static Task<bool> TrueTask
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TrueTask, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TrueTask, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Task<bool> FalseTask
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FalseTask, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FalseTask, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Task<int>> Int32Tasks
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Int32Tasks, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Int32Tasks, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AsyncTaskCache()
	{
		Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr);
		NativeFieldInfoPtr_TrueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "TrueTask");
		NativeFieldInfoPtr_FalseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "FalseTask");
		NativeFieldInfoPtr_Int32Tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, "Int32Tasks");
		NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100671480);
		NativeMethodInfoPtr_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskCache>.NativeClassPtr, 100671481);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 806677, XrefRangeEnd = 806689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Task<int>> CreateInt32Tasks()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInt32Tasks_Private_Static_Il2CppReferenceArray_1_Task_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Task<int>>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 806693, RefRangeEnd = 806694, XrefRangeStart = 806689, XrefRangeEnd = 806693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Task<TResult> CreateCacheableTask<TResult>(TResult result)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
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
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CreateCacheableTask_Internal_Static_Task_1_TResult_TResult_0<TResult>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
	}

	public AsyncTaskCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
