using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct PropertySceneHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_valid;

	private static readonly System.IntPtr NativeFieldInfoPtr_handleIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsValid_Private_Void_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_AnimationStream_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_AnimationStream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Public_Void_AnimationStream_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasValidTransform_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBound_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatInternal_Private_Single_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntInternal_Private_Int32_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoolInternal_Private_Boolean_byref_AnimationStream_0;

	[FieldOffset(0)]
	public uint valid;

	[FieldOffset(4)]
	public int handleIndex;

	public unsafe bool createdByNative
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1159749, RefRangeEnd = 1159750, XrefRangeStart = 1159749, XrefRangeEnd = 1159750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasHandleIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PropertySceneHandle()
	{
		Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "PropertySceneHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr);
		NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, "valid");
		NativeFieldInfoPtr_handleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, "handleIndex");
		NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664783);
		NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664784);
		NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664785);
		NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664786);
		NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664787);
		NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664788);
		NativeMethodInfoPtr_CheckIsValid_Private_Void_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664789);
		NativeMethodInfoPtr_GetFloat_Public_Single_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664790);
		NativeMethodInfoPtr_SetFloat_Public_Void_AnimationStream_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664791);
		NativeMethodInfoPtr_GetInt_Public_Int32_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664792);
		NativeMethodInfoPtr_SetInt_Public_Void_AnimationStream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664793);
		NativeMethodInfoPtr_GetBool_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664794);
		NativeMethodInfoPtr_SetBool_Public_Void_AnimationStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664795);
		NativeMethodInfoPtr_HasValidTransform_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664796);
		NativeMethodInfoPtr_IsBound_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664797);
		NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664798);
		NativeMethodInfoPtr_GetFloatInternal_Private_Single_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664799);
		NativeMethodInfoPtr_GetIntInternal_Private_Int32_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664800);
		NativeMethodInfoPtr_GetBoolInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, 100664801);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160024, XrefRangeEnd = 1160025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1160028, RefRangeEnd = 1160030, XrefRangeStart = 1160025, XrefRangeEnd = 1160028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValidInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160030, XrefRangeEnd = 1160033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resolve(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160033, XrefRangeEnd = 1160034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsResolved(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1160037, RefRangeEnd = 1160041, XrefRangeStart = 1160034, XrefRangeEnd = 1160037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIsValid(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsValid_Private_Void_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160041, XrefRangeEnd = 1160044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloat(AnimationStream stream, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Public_Void_AnimationStream_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160044, XrefRangeEnd = 1160047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInt(AnimationStream stream, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Public_Void_AnimationStream_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160047, XrefRangeEnd = 1160050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBool(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBool(AnimationStream stream, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&stream);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBool_Public_Void_AnimationStream_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160050, XrefRangeEnd = 1160052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasValidTransform(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasValidTransform_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160052, XrefRangeEnd = 1160054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsBound(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBound_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160054, XrefRangeEnd = 1160056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResolveInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160056, XrefRangeEnd = 1160058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloatInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloatInternal_Private_Single_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160058, XrefRangeEnd = 1160060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetIntInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIntInternal_Private_Int32_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160060, XrefRangeEnd = 1160062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBoolInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoolInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PropertySceneHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
