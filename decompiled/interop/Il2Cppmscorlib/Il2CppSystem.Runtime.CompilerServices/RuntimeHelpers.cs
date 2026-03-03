using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices;

public static class RuntimeHelpers : Object
{
	private sealed class MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0, Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SufficientExecutionStack_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureSufficientExecutionStack_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnsureSufficientExecutionStack_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0;

	public unsafe static int OffsetToStringData
	{
		[CallerCount(117)]
		[CachedScanResults(RefRangeStart = 807354, RefRangeEnd = 807471, XrefRangeStart = 807353, XrefRangeEnd = 807354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RuntimeHelpers()
	{
		Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671532);
		NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671533);
		NativeMethodInfoPtr_get_OffsetToStringData_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671534);
		NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671535);
		NativeMethodInfoPtr_SufficientExecutionStack_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671536);
		NativeMethodInfoPtr_EnsureSufficientExecutionStack_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671537);
		NativeMethodInfoPtr_TryEnsureSufficientExecutionStack_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671538);
		NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671539);
		NativeMethodInfoPtr_IsReferenceOrContainsReferences_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeHelpers>.NativeClassPtr, 100671540);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807135, XrefRangeEnd = 807136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeArray(Array array, System.IntPtr fldHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fldHandle;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeArray_Private_Static_Void_Array_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(211)]
	[CachedScanResults(RefRangeStart = 807142, RefRangeEnd = 807353, XrefRangeStart = 807136, XrefRangeEnd = 807142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(RuntimeFieldHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fldHandle;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeArray_Public_Static_Void_Array_RuntimeFieldHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 255142, RefRangeEnd = 255156, XrefRangeStart = 255142, XrefRangeEnd = 255156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHashCode(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804554, RefRangeEnd = 804555, XrefRangeStart = 804554, XrefRangeEnd = 804555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SufficientExecutionStack()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SufficientExecutionStack_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 807472, RefRangeEnd = 807474, XrefRangeStart = 807471, XrefRangeEnd = 807472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureSufficientExecutionStack()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureSufficientExecutionStack_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804554, RefRangeEnd = 804555, XrefRangeStart = 804554, XrefRangeEnd = 804555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryEnsureSufficientExecutionStack()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnsureSufficientExecutionStack_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrepareConstrainedRegions()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareConstrainedRegions_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807474, XrefRangeEnd = 807480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsReferenceOrContainsReferences<T>()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IsReferenceOrContainsReferences_Public_Static_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RuntimeHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
