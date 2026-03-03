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
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.U2D;

public static class SpriteDataAccessExtensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0, Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0, Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate void SetVertexCount_InjectedDelegate(System.IntPtr sprite, int count);

	private delegate void SetBindPoseData_InjectedDelegate(System.IntPtr sprite, System.IntPtr src, int count);

	private delegate void SetIndicesData_InjectedDelegate(System.IntPtr sprite, System.IntPtr src, int count);

	private delegate void SetChannelData_InjectedDelegate(System.IntPtr sprite, VertexAttribute channel, System.IntPtr src);

	private delegate void SetBoneData_InjectedDelegate(System.IntPtr sprite, System.IntPtr src);

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindPoses_Public_Static_NativeArray_1_Matrix4x4_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBones_Public_Static_Il2CppReferenceArray_1_SpriteBone_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVertexAttribute_Public_Static_Boolean_Sprite_VertexAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindPoseInfo_Private_Static_SpriteChannelInfo_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoneInfo_Private_Static_Il2CppReferenceArray_1_SpriteBone_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimaryVertexStreamSize_Internal_Static_Int32_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVertexAttribute_Injected_Private_Static_Boolean_IntPtr_VertexAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBindPoseInfo_Injected_Private_Static_Void_IntPtr_byref_SpriteChannelInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_IntPtr_byref_SpriteChannelInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_IntPtr_VertexAttribute_byref_SpriteChannelInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoneInfo_Injected_Private_Static_Il2CppReferenceArray_1_SpriteBone_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimaryVertexStreamSize_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly SetVertexCount_InjectedDelegate SetVertexCount_InjectedDelegateField;

	private static readonly SetBindPoseData_InjectedDelegate SetBindPoseData_InjectedDelegateField;

	private static readonly SetIndicesData_InjectedDelegate SetIndicesData_InjectedDelegateField;

	private static readonly SetChannelData_InjectedDelegate SetChannelData_InjectedDelegateField;

	private static readonly SetBoneData_InjectedDelegate SetBoneData_InjectedDelegateField;

	static SpriteDataAccessExtensions()
	{
		Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", "SpriteDataAccessExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669004);
		NativeMethodInfoPtr_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669005);
		NativeMethodInfoPtr_GetBindPoses_Public_Static_NativeArray_1_Matrix4x4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669006);
		NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669007);
		NativeMethodInfoPtr_GetBones_Public_Static_Il2CppReferenceArray_1_SpriteBone_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669008);
		NativeMethodInfoPtr_HasVertexAttribute_Public_Static_Boolean_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669009);
		NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669010);
		NativeMethodInfoPtr_GetBindPoseInfo_Private_Static_SpriteChannelInfo_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669011);
		NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669012);
		NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669013);
		NativeMethodInfoPtr_GetBoneInfo_Private_Static_Il2CppReferenceArray_1_SpriteBone_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669014);
		NativeMethodInfoPtr_GetPrimaryVertexStreamSize_Internal_Static_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669015);
		NativeMethodInfoPtr_HasVertexAttribute_Injected_Private_Static_Boolean_IntPtr_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669016);
		NativeMethodInfoPtr_GetVertexCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669017);
		NativeMethodInfoPtr_GetBindPoseInfo_Injected_Private_Static_Void_IntPtr_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669018);
		NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_IntPtr_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669019);
		NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_IntPtr_VertexAttribute_byref_SpriteChannelInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669020);
		NativeMethodInfoPtr_GetBoneInfo_Injected_Private_Static_Il2CppReferenceArray_1_SpriteBone_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669021);
		NativeMethodInfoPtr_GetPrimaryVertexStreamSize_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteDataAccessExtensions>.NativeClassPtr, 100669022);
		SetVertexCount_InjectedDelegateField = IL2CPP.ResolveICall<SetVertexCount_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetVertexCount_Injected");
		SetBindPoseData_InjectedDelegateField = IL2CPP.ResolveICall<SetBindPoseData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBindPoseData_Injected");
		SetIndicesData_InjectedDelegateField = IL2CPP.ResolveICall<SetIndicesData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetIndicesData_Injected");
		SetChannelData_InjectedDelegateField = IL2CPP.ResolveICall<SetChannelData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetChannelData_Injected");
		SetBoneData_InjectedDelegateField = IL2CPP.ResolveICall<SetBoneData_InjectedDelegate>("UnityEngine.U2D.SpriteDataAccessExtensions::SetBoneData_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241431, RefRangeEnd = 1241432, XrefRangeStart = 1241399, XrefRangeEnd = 1241431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckAttributeTypeMatchesAndThrow<T>(VertexAttribute channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&channel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CheckAttributeTypeMatchesAndThrow_Private_Static_Void_VertexAttribute_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1241440, RefRangeEnd = 1241449, XrefRangeStart = 1241432, XrefRangeEnd = 1241440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeSlice<T> GetVertexAttribute<T>(this Sprite sprite, VertexAttribute channel) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(VertexAttribute**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetVertexAttribute_Public_Static_NativeSlice_1_T_Sprite_VertexAttribute_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<T>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241459, RefRangeEnd = 1241462, XrefRangeStart = 1241449, XrefRangeEnd = 1241459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<Matrix4x4> GetBindPoses(this Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindPoses_Public_Static_NativeArray_1_Matrix4x4_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<Matrix4x4>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241472, RefRangeEnd = 1241474, XrefRangeStart = 1241462, XrefRangeEnd = 1241472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<ushort> GetIndices(this Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndices_Public_Static_NativeArray_1_UInt16_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<ushort>(pointer);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241483, RefRangeEnd = 1241486, XrefRangeStart = 1241474, XrefRangeEnd = 1241483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<SpriteBone> GetBones(this Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBones_Public_Static_Il2CppReferenceArray_1_SpriteBone_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 1241495, RefRangeEnd = 1241533, XrefRangeStart = 1241486, XrefRangeEnd = 1241495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasVertexAttribute(this Sprite sprite, VertexAttribute channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(VertexAttribute**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVertexAttribute_Public_Static_Boolean_Sprite_VertexAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1241542, RefRangeEnd = 1241548, XrefRangeStart = 1241533, XrefRangeEnd = 1241542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetVertexCount(this Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241548, XrefRangeEnd = 1241554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SpriteChannelInfo GetBindPoseInfo(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindPoseInfo_Private_Static_SpriteChannelInfo_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteChannelInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241554, XrefRangeEnd = 1241560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SpriteChannelInfo GetIndicesInfo(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndicesInfo_Private_Static_SpriteChannelInfo_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteChannelInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1241566, RefRangeEnd = 1241567, XrefRangeStart = 1241560, XrefRangeEnd = 1241566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SpriteChannelInfo GetChannelInfo(Sprite sprite, VertexAttribute channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(VertexAttribute**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChannelInfo_Private_Static_SpriteChannelInfo_Sprite_VertexAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteChannelInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1241483, RefRangeEnd = 1241486, XrefRangeStart = 1241483, XrefRangeEnd = 1241486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<SpriteBone> GetBoneInfo(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoneInfo_Private_Static_Il2CppReferenceArray_1_SpriteBone_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241572, RefRangeEnd = 1241574, XrefRangeStart = 1241567, XrefRangeEnd = 1241572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrimaryVertexStreamSize(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimaryVertexStreamSize_Internal_Static_Int32_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241574, XrefRangeEnd = 1241576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasVertexAttribute_Injected(System.IntPtr sprite, VertexAttribute channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sprite);
		*(VertexAttribute**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVertexAttribute_Injected_Private_Static_Boolean_IntPtr_VertexAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241576, XrefRangeEnd = 1241578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetVertexCount_Injected(System.IntPtr sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241578, XrefRangeEnd = 1241580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetBindPoseInfo_Injected(System.IntPtr sprite, out SpriteChannelInfo ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sprite);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBindPoseInfo_Injected_Private_Static_Void_IntPtr_byref_SpriteChannelInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241580, XrefRangeEnd = 1241582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetIndicesInfo_Injected(System.IntPtr sprite, out SpriteChannelInfo ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sprite);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndicesInfo_Injected_Private_Static_Void_IntPtr_byref_SpriteChannelInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241582, XrefRangeEnd = 1241584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetChannelInfo_Injected(System.IntPtr sprite, VertexAttribute channel, out SpriteChannelInfo ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&sprite);
		*(VertexAttribute**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChannelInfo_Injected_Private_Static_Void_IntPtr_VertexAttribute_byref_SpriteChannelInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241584, XrefRangeEnd = 1241586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<SpriteBone> GetBoneInfo_Injected(System.IntPtr sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoneInfo_Injected_Private_Static_Il2CppReferenceArray_1_SpriteBone_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteBone>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241586, XrefRangeEnd = 1241588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrimaryVertexStreamSize_Injected(System.IntPtr sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimaryVertexStreamSize_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SpriteDataAccessExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void SetVertexAttribute<T>(Sprite sprite, VertexAttribute channel, NativeArray<T> src) where T : struct
	{
		CheckAttributeTypeMatchesAndThrow<T>(channel);
		SetChannelData(sprite, channel, src.GetUnsafeReadOnlyPtr());
	}

	public unsafe static void SetBindPoses(Sprite sprite, NativeArray<Matrix4x4> src)
	{
		//IL_000f: Expected O, but got Ref
		SetBindPoseData(sprite, src.GetUnsafeReadOnlyPtr(), ((NativeArray<Matrix4x4>)(&src)).Length);
	}

	public unsafe static void SetIndices(Sprite sprite, NativeArray<ushort> src)
	{
		//IL_000f: Expected O, but got Ref
		SetIndicesData(sprite, src.GetUnsafeReadOnlyPtr(), ((NativeArray<ushort>)(&src)).Length);
	}

	public static void SetBones(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
	{
		SetBoneData(sprite, src);
	}

	public static void SetVertexCount(Sprite sprite, int count)
	{
		if ((object)sprite == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(sprite);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		SetVertexCount_Injected(intPtr, count);
	}

	public unsafe static void SetBindPoseData(Sprite sprite, void* src, int count)
	{
		if ((object)sprite == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(sprite);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		SetBindPoseData_Injected(intPtr, src, count);
	}

	public unsafe static void SetIndicesData(Sprite sprite, void* src, int count)
	{
		if ((object)sprite == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(sprite);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		SetIndicesData_Injected(intPtr, src, count);
	}

	public unsafe static void SetChannelData(Sprite sprite, VertexAttribute channel, void* src)
	{
		if ((object)sprite == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(sprite);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		SetChannelData_Injected(intPtr, channel, src);
	}

	public static void SetBoneData(Sprite sprite, Il2CppReferenceArray<SpriteBone> src)
	{
		if ((object)sprite == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(sprite);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sprite, "sprite");
		}
		SetBoneData_Injected(intPtr, src);
	}

	public static void SetVertexCount_Injected(System.IntPtr sprite, int count)
	{
		SetVertexCount_InjectedDelegateField(sprite, count);
	}

	public unsafe static void SetBindPoseData_Injected(System.IntPtr sprite, void* src, int count)
	{
		SetBindPoseData_InjectedDelegateField(sprite, (nint)src, count);
	}

	public unsafe static void SetIndicesData_Injected(System.IntPtr sprite, void* src, int count)
	{
		SetIndicesData_InjectedDelegateField(sprite, (nint)src, count);
	}

	public unsafe static void SetChannelData_Injected(System.IntPtr sprite, VertexAttribute channel, void* src)
	{
		SetChannelData_InjectedDelegateField(sprite, channel, (nint)src);
	}

	public static void SetBoneData_Injected(System.IntPtr sprite, Il2CppReferenceArray<SpriteBone> src)
	{
		SetBoneData_InjectedDelegateField(sprite, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src));
	}
}
