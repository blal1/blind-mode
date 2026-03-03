using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine.Bindings;

namespace UnityEngine.Animations;

public static class AnimatorJobExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_AddJobDependency_Public_Static_Void_Animator_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindStreamTransform_Public_Static_TransformStreamHandle_Animator_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindStreamProperty_Public_Static_PropertyStreamHandle_Animator_Transform_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindCustomStreamProperty_Public_Static_PropertyStreamHandle_Animator_String_CustomStreamPropertyType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindStreamProperty_Public_Static_PropertyStreamHandle_Animator_Transform_Type_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindSceneTransform_Public_Static_TransformSceneHandle_Animator_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindSceneProperty_Public_Static_PropertySceneHandle_Animator_Transform_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BindSceneProperty_Public_Static_PropertySceneHandle_Animator_Transform_Type_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenAnimationStream_Public_Static_Boolean_Animator_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseAnimationStream_Public_Static_Void_Animator_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAllStreamHandles_Public_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveAllSceneHandles_Public_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnbindAllHandles_Internal_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnbindAllStreamHandles_Public_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnbindAllSceneHandles_Public_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalAddJobDependency_Private_Static_Void_Animator_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindStreamTransform_Private_Static_Void_Animator_Transform_byref_TransformStreamHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindStreamProperty_Private_Static_Void_Animator_Transform_Type_String_Boolean_byref_PropertyStreamHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindCustomStreamProperty_Private_Static_Void_Animator_String_CustomStreamPropertyType_byref_PropertyStreamHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindSceneTransform_Private_Static_Void_Animator_Transform_byref_TransformSceneHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindSceneProperty_Private_Static_Void_Animator_Transform_Type_String_Boolean_byref_PropertySceneHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalOpenAnimationStream_Private_Static_Boolean_Animator_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCloseAnimationStream_Private_Static_Void_Animator_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalResolveAllStreamHandles_Private_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalResolveAllSceneHandles_Private_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnbindAllStreamHandles_Private_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnbindAllSceneHandles_Private_Static_Void_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalAddJobDependency_Injected_Private_Static_Void_IntPtr_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindStreamTransform_Injected_Private_Static_Void_IntPtr_IntPtr_byref_TransformStreamHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindStreamProperty_Injected_Private_Static_Void_IntPtr_IntPtr_Type_byref_ManagedSpanWrapper_Boolean_byref_PropertyStreamHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindCustomStreamProperty_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CustomStreamPropertyType_byref_PropertyStreamHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindSceneTransform_Injected_Private_Static_Void_IntPtr_IntPtr_byref_TransformSceneHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBindSceneProperty_Injected_Private_Static_Void_IntPtr_IntPtr_Type_byref_ManagedSpanWrapper_Boolean_byref_PropertySceneHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalOpenAnimationStream_Injected_Private_Static_Boolean_IntPtr_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCloseAnimationStream_Injected_Private_Static_Void_IntPtr_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalResolveAllStreamHandles_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalResolveAllSceneHandles_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnbindAllStreamHandles_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalUnbindAllSceneHandles_Injected_Private_Static_Void_IntPtr_0;

	static AnimatorJobExtensions()
	{
		Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimatorJobExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_AddJobDependency_Public_Static_Void_Animator_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664948);
		NativeMethodInfoPtr_BindStreamTransform_Public_Static_TransformStreamHandle_Animator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664949);
		NativeMethodInfoPtr_BindStreamProperty_Public_Static_PropertyStreamHandle_Animator_Transform_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664950);
		NativeMethodInfoPtr_BindCustomStreamProperty_Public_Static_PropertyStreamHandle_Animator_String_CustomStreamPropertyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664951);
		NativeMethodInfoPtr_BindStreamProperty_Public_Static_PropertyStreamHandle_Animator_Transform_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664952);
		NativeMethodInfoPtr_BindSceneTransform_Public_Static_TransformSceneHandle_Animator_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664953);
		NativeMethodInfoPtr_BindSceneProperty_Public_Static_PropertySceneHandle_Animator_Transform_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664954);
		NativeMethodInfoPtr_BindSceneProperty_Public_Static_PropertySceneHandle_Animator_Transform_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664955);
		NativeMethodInfoPtr_OpenAnimationStream_Public_Static_Boolean_Animator_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664956);
		NativeMethodInfoPtr_CloseAnimationStream_Public_Static_Void_Animator_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664957);
		NativeMethodInfoPtr_ResolveAllStreamHandles_Public_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664958);
		NativeMethodInfoPtr_ResolveAllSceneHandles_Public_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664959);
		NativeMethodInfoPtr_UnbindAllHandles_Internal_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664960);
		NativeMethodInfoPtr_UnbindAllStreamHandles_Public_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664961);
		NativeMethodInfoPtr_UnbindAllSceneHandles_Public_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664962);
		NativeMethodInfoPtr_InternalAddJobDependency_Private_Static_Void_Animator_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664963);
		NativeMethodInfoPtr_InternalBindStreamTransform_Private_Static_Void_Animator_Transform_byref_TransformStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664964);
		NativeMethodInfoPtr_InternalBindStreamProperty_Private_Static_Void_Animator_Transform_Type_String_Boolean_byref_PropertyStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664965);
		NativeMethodInfoPtr_InternalBindCustomStreamProperty_Private_Static_Void_Animator_String_CustomStreamPropertyType_byref_PropertyStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664966);
		NativeMethodInfoPtr_InternalBindSceneTransform_Private_Static_Void_Animator_Transform_byref_TransformSceneHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664967);
		NativeMethodInfoPtr_InternalBindSceneProperty_Private_Static_Void_Animator_Transform_Type_String_Boolean_byref_PropertySceneHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664968);
		NativeMethodInfoPtr_InternalOpenAnimationStream_Private_Static_Boolean_Animator_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664969);
		NativeMethodInfoPtr_InternalCloseAnimationStream_Private_Static_Void_Animator_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664970);
		NativeMethodInfoPtr_InternalResolveAllStreamHandles_Private_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664971);
		NativeMethodInfoPtr_InternalResolveAllSceneHandles_Private_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664972);
		NativeMethodInfoPtr_InternalUnbindAllStreamHandles_Private_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664973);
		NativeMethodInfoPtr_InternalUnbindAllSceneHandles_Private_Static_Void_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664974);
		NativeMethodInfoPtr_InternalAddJobDependency_Injected_Private_Static_Void_IntPtr_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664975);
		NativeMethodInfoPtr_InternalBindStreamTransform_Injected_Private_Static_Void_IntPtr_IntPtr_byref_TransformStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664976);
		NativeMethodInfoPtr_InternalBindStreamProperty_Injected_Private_Static_Void_IntPtr_IntPtr_Type_byref_ManagedSpanWrapper_Boolean_byref_PropertyStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664977);
		NativeMethodInfoPtr_InternalBindCustomStreamProperty_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CustomStreamPropertyType_byref_PropertyStreamHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664978);
		NativeMethodInfoPtr_InternalBindSceneTransform_Injected_Private_Static_Void_IntPtr_IntPtr_byref_TransformSceneHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664979);
		NativeMethodInfoPtr_InternalBindSceneProperty_Injected_Private_Static_Void_IntPtr_IntPtr_Type_byref_ManagedSpanWrapper_Boolean_byref_PropertySceneHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_InternalOpenAnimationStream_Injected_Private_Static_Boolean_IntPtr_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_InternalCloseAnimationStream_Injected_Private_Static_Void_IntPtr_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_InternalResolveAllStreamHandles_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_InternalResolveAllSceneHandles_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_InternalUnbindAllStreamHandles_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr_InternalUnbindAllSceneHandles_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorJobExtensions>.NativeClassPtr, 100664986);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160942, XrefRangeEnd = 1160948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddJobDependency(this Animator animator, JobHandle jobHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(JobHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobHandle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddJobDependency_Public_Static_Void_Animator_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160948, XrefRangeEnd = 1160962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TransformStreamHandle BindStreamTransform(this Animator animator, Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindStreamTransform_Public_Static_TransformStreamHandle_Animator_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TransformStreamHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160962, XrefRangeEnd = 1160963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, Il2CppSystem.Type type, string property)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindStreamProperty_Public_Static_PropertyStreamHandle_Animator_Transform_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PropertyStreamHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160963, XrefRangeEnd = 1160964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyStreamHandle BindCustomStreamProperty(this Animator animator, string property, CustomStreamPropertyType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(CustomStreamPropertyType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindCustomStreamProperty_Public_Static_PropertyStreamHandle_Animator_String_CustomStreamPropertyType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PropertyStreamHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160964, XrefRangeEnd = 1160965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyStreamHandle BindStreamProperty(this Animator animator, Transform transform, Il2CppSystem.Type type, string property, bool isObjectReference)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindStreamProperty_Public_Static_PropertyStreamHandle_Animator_Transform_Type_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PropertyStreamHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160965, XrefRangeEnd = 1160979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TransformSceneHandle BindSceneTransform(this Animator animator, Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindSceneTransform_Public_Static_TransformSceneHandle_Animator_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TransformSceneHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160979, XrefRangeEnd = 1160980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, Il2CppSystem.Type type, string property)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindSceneProperty_Public_Static_PropertySceneHandle_Animator_Transform_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PropertySceneHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160980, XrefRangeEnd = 1160981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertySceneHandle BindSceneProperty(this Animator animator, Transform transform, Il2CppSystem.Type type, string property, bool isObjectReference)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BindSceneProperty_Public_Static_PropertySceneHandle_Animator_Transform_Type_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PropertySceneHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160981, XrefRangeEnd = 1160990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OpenAnimationStream(this Animator animator, ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenAnimationStream_Public_Static_Boolean_Animator_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160990, XrefRangeEnd = 1160999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CloseAnimationStream(this Animator animator, ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseAnimationStream_Public_Static_Void_Animator_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160999, XrefRangeEnd = 1161008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResolveAllStreamHandles(this Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveAllStreamHandles_Public_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161008, XrefRangeEnd = 1161017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResolveAllSceneHandles(this Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveAllSceneHandles_Public_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161017, XrefRangeEnd = 1161032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnbindAllHandles(this Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnbindAllHandles_Internal_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161032, XrefRangeEnd = 1161041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnbindAllStreamHandles(this Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnbindAllStreamHandles_Public_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161041, XrefRangeEnd = 1161050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnbindAllSceneHandles(this Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnbindAllSceneHandles_Public_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161050, XrefRangeEnd = 1161056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalAddJobDependency(Animator animator, JobHandle jobHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(JobHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &jobHandle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalAddJobDependency_Private_Static_Void_Animator_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161056, XrefRangeEnd = 1161071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindStreamTransform(Animator animator, Transform transform, out TransformStreamHandle transformStreamHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transformStreamHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindStreamTransform_Private_Static_Void_Animator_Transform_byref_TransformStreamHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1161103, RefRangeEnd = 1161105, XrefRangeStart = 1161071, XrefRangeEnd = 1161103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindStreamProperty(Animator animator, Transform transform, Il2CppSystem.Type type, string property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref propertyStreamHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindStreamProperty_Private_Static_Void_Animator_Transform_Type_String_Boolean_byref_PropertyStreamHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1161128, RefRangeEnd = 1161129, XrefRangeStart = 1161105, XrefRangeEnd = 1161128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindCustomStreamProperty(Animator animator, string property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(CustomStreamPropertyType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &propertyType;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref propertyStreamHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindCustomStreamProperty_Private_Static_Void_Animator_String_CustomStreamPropertyType_byref_PropertyStreamHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161129, XrefRangeEnd = 1161144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindSceneTransform(Animator animator, Transform transform, out TransformSceneHandle transformSceneHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transformSceneHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindSceneTransform_Private_Static_Void_Animator_Transform_byref_TransformSceneHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1161176, RefRangeEnd = 1161178, XrefRangeStart = 1161144, XrefRangeEnd = 1161176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindSceneProperty(Animator animator, Transform transform, Il2CppSystem.Type type, string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(property);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref propertySceneHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindSceneProperty_Private_Static_Void_Animator_Transform_Type_String_Boolean_byref_PropertySceneHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalOpenAnimationStream(Animator animator, ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalOpenAnimationStream_Private_Static_Boolean_Animator_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalCloseAnimationStream(Animator animator, ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCloseAnimationStream_Private_Static_Void_Animator_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalResolveAllStreamHandles(Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalResolveAllStreamHandles_Private_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalResolveAllSceneHandles(Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalResolveAllSceneHandles_Private_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalUnbindAllStreamHandles(Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnbindAllStreamHandles_Private_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalUnbindAllSceneHandles(Animator animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnbindAllSceneHandles_Private_Static_Void_Animator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161178, XrefRangeEnd = 1161180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalAddJobDependency_Injected(System.IntPtr animator, [In] ref JobHandle jobHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref jobHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalAddJobDependency_Injected_Private_Static_Void_IntPtr_byref_JobHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161180, XrefRangeEnd = 1161182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindStreamTransform_Injected(System.IntPtr animator, System.IntPtr transform, out TransformStreamHandle transformStreamHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&animator);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transformStreamHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindStreamTransform_Injected_Private_Static_Void_IntPtr_IntPtr_byref_TransformStreamHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161182, XrefRangeEnd = 1161184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindStreamProperty_Injected(System.IntPtr animator, System.IntPtr transform, Il2CppSystem.Type type, ref ManagedSpanWrapper property, bool isObjectReference, out PropertyStreamHandle propertyStreamHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&animator);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref propertyStreamHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindStreamProperty_Injected_Private_Static_Void_IntPtr_IntPtr_Type_byref_ManagedSpanWrapper_Boolean_byref_PropertyStreamHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161184, XrefRangeEnd = 1161186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindCustomStreamProperty_Injected(System.IntPtr animator, ref ManagedSpanWrapper property, CustomStreamPropertyType propertyType, out PropertyStreamHandle propertyStreamHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(CustomStreamPropertyType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &propertyType;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref propertyStreamHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindCustomStreamProperty_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_CustomStreamPropertyType_byref_PropertyStreamHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161186, XrefRangeEnd = 1161188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindSceneTransform_Injected(System.IntPtr animator, System.IntPtr transform, out TransformSceneHandle transformSceneHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&animator);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref transformSceneHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindSceneTransform_Injected_Private_Static_Void_IntPtr_IntPtr_byref_TransformSceneHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161188, XrefRangeEnd = 1161190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalBindSceneProperty_Injected(System.IntPtr animator, System.IntPtr transform, Il2CppSystem.Type type, ref ManagedSpanWrapper property, bool isObjectReference, out PropertySceneHandle propertySceneHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&animator);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transform;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref property);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isObjectReference;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref propertySceneHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBindSceneProperty_Injected_Private_Static_Void_IntPtr_IntPtr_Type_byref_ManagedSpanWrapper_Boolean_byref_PropertySceneHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161190, XrefRangeEnd = 1161192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalOpenAnimationStream_Injected(System.IntPtr animator, ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalOpenAnimationStream_Injected_Private_Static_Boolean_IntPtr_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161192, XrefRangeEnd = 1161194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalCloseAnimationStream_Injected(System.IntPtr animator, ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&animator);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalCloseAnimationStream_Injected_Private_Static_Void_IntPtr_byref_AnimationStream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161194, XrefRangeEnd = 1161196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalResolveAllStreamHandles_Injected(System.IntPtr animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalResolveAllStreamHandles_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161196, XrefRangeEnd = 1161198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalResolveAllSceneHandles_Injected(System.IntPtr animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalResolveAllSceneHandles_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161198, XrefRangeEnd = 1161200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalUnbindAllStreamHandles_Injected(System.IntPtr animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnbindAllStreamHandles_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161200, XrefRangeEnd = 1161202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalUnbindAllSceneHandles_Injected(System.IntPtr animator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&animator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalUnbindAllSceneHandles_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimatorJobExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
