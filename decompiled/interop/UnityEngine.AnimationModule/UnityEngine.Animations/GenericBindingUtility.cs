using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Animations;

public static class GenericBindingUtility : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_ValidateIsCreated_Internal_Static_Void_NativeArray_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ValidateIsCreated_Internal_Static_Void_NativeArray_1_T_0, Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ValidateLengthMatch_Internal_Static_Void_NativeArray_1_T1_NativeArray_1_T2_0<T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ValidateLengthMatch_Internal_Static_Void_NativeArray_1_T1_NativeArray_1_T2_0, Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGenericBinding_Public_Static_Boolean_Object_String_GameObject_Boolean_byref_GenericBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGenericBindingForGameObject_Private_Static_Boolean_GameObject_String_GameObject_byref_GenericBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGenericBindingForComponent_Private_Static_Boolean_Component_String_GameObject_Boolean_byref_GenericBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimatableBindings_Public_Static_Il2CppStructArray_1_GenericBinding_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurveBindings_Public_Static_Il2CppStructArray_1_GenericBinding_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindProperties_Public_Static_Void_GameObject_NativeArray_1_GenericBinding_byref_NativeArray_1_BoundProperty_byref_NativeArray_1_BoundProperty_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BindProperties_Internal_Static_Void_GameObject_ptr_Void_Int32_ptr_Void_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnbindProperties_Public_Static_Void_NativeArray_1_BoundProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_UnbindProperties_Internal_Static_Void_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScatterFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScatterDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScatterFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScatterDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIsCreated_Internal_Static_Void_NativeArray_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateIndicesAreInRange_Internal_Static_Void_NativeArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateLengthMatch_Internal_Static_Void_NativeArray_1_T1_NativeArray_1_T2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGenericBindingForGameObject_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_byref_GenericBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGenericBindingForComponent_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_Boolean_byref_GenericBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimatableBindings_Injected_Private_Static_Il2CppStructArray_1_GenericBinding_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurveBindings_Injected_Private_Static_Il2CppStructArray_1_GenericBinding_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BindProperties_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_ptr_Void_ptr_Void_0;

	static GenericBindingUtility()
	{
		Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "GenericBindingUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr);
		NativeMethodInfoPtr_CreateGenericBinding_Public_Static_Boolean_Object_String_GameObject_Boolean_byref_GenericBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665159);
		NativeMethodInfoPtr_CreateGenericBindingForGameObject_Private_Static_Boolean_GameObject_String_GameObject_byref_GenericBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665160);
		NativeMethodInfoPtr_CreateGenericBindingForComponent_Private_Static_Boolean_Component_String_GameObject_Boolean_byref_GenericBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr_GetAnimatableBindings_Public_Static_Il2CppStructArray_1_GenericBinding_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665162);
		NativeMethodInfoPtr_GetCurveBindings_Public_Static_Il2CppStructArray_1_GenericBinding_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665163);
		NativeMethodInfoPtr_BindProperties_Public_Static_Void_GameObject_NativeArray_1_GenericBinding_byref_NativeArray_1_BoundProperty_byref_NativeArray_1_BoundProperty_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665164);
		NativeMethodInfoPtr_Internal_BindProperties_Internal_Static_Void_GameObject_ptr_Void_Int32_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665165);
		NativeMethodInfoPtr_UnbindProperties_Public_Static_Void_NativeArray_1_BoundProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665166);
		NativeMethodInfoPtr_Internal_UnbindProperties_Internal_Static_Void_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665167);
		NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665168);
		NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665169);
		NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665170);
		NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665171);
		NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665172);
		NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665173);
		NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665174);
		NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665175);
		NativeMethodInfoPtr_SetFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665176);
		NativeMethodInfoPtr_SetScatterFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665177);
		NativeMethodInfoPtr_SetDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665178);
		NativeMethodInfoPtr_SetScatterDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665179);
		NativeMethodInfoPtr_GetFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665180);
		NativeMethodInfoPtr_GetScatterFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665181);
		NativeMethodInfoPtr_GetDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665182);
		NativeMethodInfoPtr_GetScatterDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665183);
		NativeMethodInfoPtr_ValidateIsCreated_Internal_Static_Void_NativeArray_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665184);
		NativeMethodInfoPtr_ValidateIndicesAreInRange_Internal_Static_Void_NativeArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665185);
		NativeMethodInfoPtr_ValidateLengthMatch_Internal_Static_Void_NativeArray_1_T1_NativeArray_1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665186);
		NativeMethodInfoPtr_CreateGenericBindingForGameObject_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_byref_GenericBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665187);
		NativeMethodInfoPtr_CreateGenericBindingForComponent_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_Boolean_byref_GenericBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665188);
		NativeMethodInfoPtr_GetAnimatableBindings_Injected_Private_Static_Il2CppStructArray_1_GenericBinding_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665189);
		NativeMethodInfoPtr_GetCurveBindings_Injected_Private_Static_Il2CppStructArray_1_GenericBinding_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665190);
		NativeMethodInfoPtr_Internal_BindProperties_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_ptr_Void_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericBindingUtility>.NativeClassPtr, 100665191);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161815, XrefRangeEnd = 1161829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateGenericBinding(Object targetObject, string property, GameObject root, bool isObjectReference, out GenericBinding genericBinding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref genericBinding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGenericBinding_Public_Static_Boolean_Object_String_GameObject_Boolean_byref_GenericBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161829, XrefRangeEnd = 1161854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateGenericBindingForGameObject(GameObject gameObject, string property, GameObject root, out GenericBinding genericBinding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref genericBinding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGenericBindingForGameObject_Private_Static_Boolean_GameObject_String_GameObject_byref_GenericBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1161880, RefRangeEnd = 1161881, XrefRangeStart = 1161854, XrefRangeEnd = 1161880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateGenericBindingForComponent(Component component, string property, GameObject root, bool isObjectReference, out GenericBinding genericBinding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref genericBinding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGenericBindingForComponent_Private_Static_Boolean_Component_String_GameObject_Boolean_byref_GenericBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161881, XrefRangeEnd = 1161895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GenericBinding> GetAnimatableBindings(GameObject targetObject, GameObject root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)targetObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimatableBindings_Public_Static_Il2CppStructArray_1_GenericBinding_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GenericBinding>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161895, XrefRangeEnd = 1161904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GenericBinding> GetCurveBindings(AnimationClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurveBindings_Public_Static_Il2CppStructArray_1_GenericBinding_AnimationClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GenericBinding>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161904, XrefRangeEnd = 1161924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BindProperties(GameObject rootGameObject, NativeArray<GenericBinding> genericBindings, out NativeArray<BoundProperty> floatProperties, out NativeArray<BoundProperty> discreteProperties, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootGameObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)genericBindings));
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(Allocator**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindProperties_Public_Static_Void_GameObject_NativeArray_1_GenericBinding_byref_NativeArray_1_BoundProperty_byref_NativeArray_1_BoundProperty_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		floatProperties = ((num5 == 0) ? null : new NativeArray<BoundProperty>(num5));
		nint num6 = num4;
		discreteProperties = ((num6 == 0) ? null : new NativeArray<BoundProperty>(num6));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161924, XrefRangeEnd = 1161933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_BindProperties(GameObject gameObject, void* genericBindings, int genericBindingsCount, void* floatProperties, void* discreteProperties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gameObject);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = genericBindings;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &genericBindingsCount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = floatProperties;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = discreteProperties;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_BindProperties_Internal_Static_Void_GameObject_ptr_Void_Int32_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161933, XrefRangeEnd = 1161938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnbindProperties(NativeArray<BoundProperty> boundProperties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnbindProperties_Public_Static_Void_NativeArray_1_BoundProperty_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161938, XrefRangeEnd = 1161940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_UnbindProperties(void* boundProperties, int boundPropertiesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_UnbindProperties_Internal_Static_Void_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161940, XrefRangeEnd = 1161948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValues(NativeArray<BoundProperty> boundProperties, NativeArray<float> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161948, XrefRangeEnd = 1161959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValues(NativeArray<BoundProperty> boundProperties, NativeArray<int> indices, NativeArray<float> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)indices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161959, XrefRangeEnd = 1161967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValues(NativeArray<BoundProperty> boundProperties, NativeArray<int> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161967, XrefRangeEnd = 1161977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetValues(NativeArray<BoundProperty> boundProperties, NativeArray<int> indices, NativeArray<int> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)indices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161977, XrefRangeEnd = 1161985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetValues(NativeArray<BoundProperty> boundProperties, NativeArray<float> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161985, XrefRangeEnd = 1161996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetValues(NativeArray<BoundProperty> boundProperties, NativeArray<int> indices, NativeArray<float> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)indices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161996, XrefRangeEnd = 1162004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetValues(NativeArray<BoundProperty> boundProperties, NativeArray<int> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162004, XrefRangeEnd = 1162014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetValues(NativeArray<BoundProperty> boundProperties, NativeArray<int> indices, NativeArray<int> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundProperties));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)indices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)values));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValues_Public_Static_Void_NativeArray_1_BoundProperty_NativeArray_1_Int32_NativeArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162014, XrefRangeEnd = 1162016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFloatValues(void* boundProperties, int boundPropertiesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162016, XrefRangeEnd = 1162018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetScatterFloatValues(void* boundProperties, int boundPropertiesCount, void* indices, int indicesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = indices;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indicesCount;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScatterFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162018, XrefRangeEnd = 1162020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDiscreteValues(void* boundProperties, int boundPropertiesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162020, XrefRangeEnd = 1162022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetScatterDiscreteValues(void* boundProperties, int boundPropertiesCount, void* indices, int indicesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = indices;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indicesCount;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScatterDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162022, XrefRangeEnd = 1162024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetFloatValues(void* boundProperties, int boundPropertiesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162024, XrefRangeEnd = 1162026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetScatterFloatValues(void* boundProperties, int boundPropertiesCount, void* indices, int indicesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = indices;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indicesCount;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScatterFloatValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162026, XrefRangeEnd = 1162028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDiscreteValues(void* boundProperties, int boundPropertiesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162028, XrefRangeEnd = 1162030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetScatterDiscreteValues(void* boundProperties, int boundPropertiesCount, void* indices, int indicesCount, void* values, int valuesCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)boundProperties;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boundPropertiesCount;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = indices;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &indicesCount;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = values;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &valuesCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScatterDiscreteValues_Internal_Static_Void_ptr_Void_Int32_ptr_Void_Int32_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162030, XrefRangeEnd = 1162031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateIsCreated<T>(NativeArray<T> array) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ValidateIsCreated_Internal_Static_Void_NativeArray_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ValidateIndicesAreInRange(NativeArray<int> indices, int maxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)indices));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateIndicesAreInRange_Internal_Static_Void_NativeArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162031, XrefRangeEnd = 1162032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateLengthMatch<T1, T2>(NativeArray<T1> array1, NativeArray<T2> array2) where T1 : new() where T2 : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array1));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array2));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ValidateLengthMatch_Internal_Static_Void_NativeArray_1_T1_NativeArray_1_T2_0<T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162032, XrefRangeEnd = 1162034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateGenericBindingForGameObject_Injected(System.IntPtr gameObject, ref ManagedSpanWrapper property, System.IntPtr root, out GenericBinding genericBinding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&gameObject);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref genericBinding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGenericBindingForGameObject_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_byref_GenericBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162034, XrefRangeEnd = 1162036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateGenericBindingForComponent_Injected(System.IntPtr component, ref ManagedSpanWrapper property, System.IntPtr root, bool isObjectReference, out GenericBinding genericBinding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&component);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref genericBinding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGenericBindingForComponent_Injected_Private_Static_Boolean_IntPtr_byref_ManagedSpanWrapper_IntPtr_Boolean_byref_GenericBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162036, XrefRangeEnd = 1162038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GenericBinding> GetAnimatableBindings_Injected(System.IntPtr targetObject, System.IntPtr root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&targetObject);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &root;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimatableBindings_Injected_Private_Static_Il2CppStructArray_1_GenericBinding_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GenericBinding>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162038, XrefRangeEnd = 1162040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<GenericBinding> GetCurveBindings_Injected(System.IntPtr clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurveBindings_Injected_Private_Static_Il2CppStructArray_1_GenericBinding_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<GenericBinding>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162040, XrefRangeEnd = 1162042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_BindProperties_Injected(System.IntPtr gameObject, void* genericBindings, int genericBindingsCount, void* floatProperties, void* discreteProperties)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&gameObject);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = genericBindings;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &genericBindingsCount;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = floatProperties;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = discreteProperties;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_BindProperties_Injected_Private_Static_Void_IntPtr_ptr_Void_Int32_ptr_Void_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GenericBindingUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
