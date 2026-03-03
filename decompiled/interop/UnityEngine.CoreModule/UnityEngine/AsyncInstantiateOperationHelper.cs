using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class AsyncInstantiateOperationHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateAsyncInstantiateOperationResultArray_Public_Static_Il2CppReferenceArray_1_Object_AsyncInstantiateOperation_Int32_0;

	static AsyncInstantiateOperationHelper()
	{
		Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AsyncInstantiateOperationHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr);
		NativeMethodInfoPtr_CreateAsyncInstantiateOperationResultArray_Public_Static_Il2CppReferenceArray_1_Object_AsyncInstantiateOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncInstantiateOperationHelper>.NativeClassPtr, 100666151);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185870, XrefRangeEnd = 1185871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Object> CreateAsyncInstantiateOperationResultArray(AsyncInstantiateOperation op, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)op);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateAsyncInstantiateOperationResultArray_Public_Static_Il2CppReferenceArray_1_Object_AsyncInstantiateOperation_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
	}

	public AsyncInstantiateOperationHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
