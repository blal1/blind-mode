using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine.Animations;

public static class AnimationSceneHandleUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ValidateAndGetArrayCount_Internal_Static_Int32_byref_AnimationStream_NativeArray_1_T0_NativeArray_1_T1_0<T0, T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ValidateAndGetArrayCount_Internal_Static_Int32_byref_AnimationStream_NativeArray_1_T0_NativeArray_1_T1_0, Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadInts_Public_Static_Void_AnimationStream_NativeArray_1_PropertySceneHandle_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadFloats_Public_Static_Void_AnimationStream_NativeArray_1_PropertySceneHandle_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateAndGetArrayCount_Internal_Static_Int32_byref_AnimationStream_NativeArray_1_T0_NativeArray_1_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadSceneIntsInternal_Private_Static_Void_byref_AnimationStream_ptr_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadSceneFloatsInternal_Private_Static_Void_byref_AnimationStream_ptr_Void_ptr_Void_Int32_0;

	static AnimationSceneHandleUtility()
	{
		Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationSceneHandleUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr);
		NativeMethodInfoPtr_ReadInts_Public_Static_Void_AnimationStream_NativeArray_1_PropertySceneHandle_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr, 100664802);
		NativeMethodInfoPtr_ReadFloats_Public_Static_Void_AnimationStream_NativeArray_1_PropertySceneHandle_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr, 100664803);
		NativeMethodInfoPtr_ValidateAndGetArrayCount_Internal_Static_Int32_byref_AnimationStream_NativeArray_1_T0_NativeArray_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr, 100664804);
		NativeMethodInfoPtr_ReadSceneIntsInternal_Private_Static_Void_byref_AnimationStream_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr, 100664805);
		NativeMethodInfoPtr_ReadSceneFloatsInternal_Private_Static_Void_byref_AnimationStream_ptr_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationSceneHandleUtility>.NativeClassPtr, 100664806);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160062, XrefRangeEnd = 1160073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadInts(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<int> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&stream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)handles));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadInts_Public_Static_Void_AnimationStream_NativeArray_1_PropertySceneHandle_NativeArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160073, XrefRangeEnd = 1160084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadFloats(AnimationStream stream, NativeArray<PropertySceneHandle> handles, NativeArray<float> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&stream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)handles));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadFloats_Public_Static_Void_AnimationStream_NativeArray_1_PropertySceneHandle_NativeArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1160086, RefRangeEnd = 1160092, XrefRangeStart = 1160084, XrefRangeEnd = 1160086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ValidateAndGetArrayCount<T0, T1>(ref AnimationStream stream, NativeArray<T0> handles, NativeArray<T1> buffer) where T0 : new() where T1 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)handles));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ValidateAndGetArrayCount_Internal_Static_Int32_byref_AnimationStream_NativeArray_1_T0_NativeArray_1_T1_0<T0, T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160092, XrefRangeEnd = 1160094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadSceneIntsInternal(ref AnimationStream stream, void* propertySceneHandles, void* intBuffer, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = propertySceneHandles;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = intBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadSceneIntsInternal_Private_Static_Void_byref_AnimationStream_ptr_Void_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160094, XrefRangeEnd = 1160096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReadSceneFloatsInternal(ref AnimationStream stream, void* propertySceneHandles, void* floatBuffer, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = propertySceneHandles;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = floatBuffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadSceneFloatsInternal_Private_Static_Void_byref_AnimationStream_ptr_Void_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationSceneHandleUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
