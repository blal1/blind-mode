using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct PropertyStreamHandle
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatorBindingsVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_handleIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueArrayIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_bindType;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSameVersionAsStream_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasValueArrayIndex_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasBindType_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_animatorBindingsVersion_Private_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsResolvedInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsValidAndResolve_Private_Void_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_AnimationStream_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_AnimationStream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Public_Void_AnimationStream_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadMask_Public_Boolean_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatInternal_Private_Single_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatInternal_Private_Void_byref_AnimationStream_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIntInternal_Private_Int32_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIntInternal_Private_Void_byref_AnimationStream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBoolInternal_Private_Boolean_byref_AnimationStream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoolInternal_Private_Void_byref_AnimationStream_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReadMaskInternal_Private_Boolean_byref_AnimationStream_0;

	[FieldOffset(0)]
	public uint m_AnimatorBindingsVersion;

	[FieldOffset(4)]
	public int handleIndex;

	[FieldOffset(8)]
	public int valueArrayIndex;

	[FieldOffset(12)]
	public int bindType;

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

	public unsafe bool hasValueArrayIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasValueArrayIndex_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasBindType
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasBindType_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint animatorBindingsVersion
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_animatorBindingsVersion_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static PropertyStreamHandle()
	{
		Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "PropertyStreamHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr);
		NativeFieldInfoPtr_m_AnimatorBindingsVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, "m_AnimatorBindingsVersion");
		NativeFieldInfoPtr_handleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, "handleIndex");
		NativeFieldInfoPtr_valueArrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, "valueArrayIndex");
		NativeFieldInfoPtr_bindType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, "bindType");
		NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664720);
		NativeMethodInfoPtr_IsValidInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664721);
		NativeMethodInfoPtr_get_createdByNative_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664722);
		NativeMethodInfoPtr_IsSameVersionAsStream_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664723);
		NativeMethodInfoPtr_get_hasHandleIndex_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664724);
		NativeMethodInfoPtr_get_hasValueArrayIndex_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664725);
		NativeMethodInfoPtr_get_hasBindType_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664726);
		NativeMethodInfoPtr_set_animatorBindingsVersion_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664727);
		NativeMethodInfoPtr_get_animatorBindingsVersion_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664728);
		NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664729);
		NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664730);
		NativeMethodInfoPtr_IsResolvedInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664731);
		NativeMethodInfoPtr_CheckIsValidAndResolve_Private_Void_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664732);
		NativeMethodInfoPtr_GetFloat_Public_Single_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664733);
		NativeMethodInfoPtr_SetFloat_Public_Void_AnimationStream_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664734);
		NativeMethodInfoPtr_GetInt_Public_Int32_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664735);
		NativeMethodInfoPtr_SetInt_Public_Void_AnimationStream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664736);
		NativeMethodInfoPtr_GetBool_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664737);
		NativeMethodInfoPtr_SetBool_Public_Void_AnimationStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664738);
		NativeMethodInfoPtr_GetReadMask_Public_Boolean_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664739);
		NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664740);
		NativeMethodInfoPtr_GetFloatInternal_Private_Single_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664741);
		NativeMethodInfoPtr_SetFloatInternal_Private_Void_byref_AnimationStream_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664742);
		NativeMethodInfoPtr_GetIntInternal_Private_Int32_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664743);
		NativeMethodInfoPtr_SetIntInternal_Private_Void_byref_AnimationStream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664744);
		NativeMethodInfoPtr_GetBoolInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664745);
		NativeMethodInfoPtr_SetBoolInternal_Private_Void_byref_AnimationStream_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664746);
		NativeMethodInfoPtr_GetReadMaskInternal_Private_Boolean_byref_AnimationStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, 100664747);
	}

	[CallerCount(0)]
	public unsafe bool IsValid(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
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
	public unsafe bool IsSameVersionAsStream(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameVersionAsStream_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159899, XrefRangeEnd = 1159900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resolve(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resolve_Public_Void_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsResolved(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsResolved_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe bool IsResolvedInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsResolvedInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1159903, RefRangeEnd = 1159911, XrefRangeStart = 1159900, XrefRangeEnd = 1159903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckIsValidAndResolve(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckIsValidAndResolve_Private_Void_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159911, XrefRangeEnd = 1159914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetFloat(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFloat_Public_Single_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159914, XrefRangeEnd = 1159917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159917, XrefRangeEnd = 1159920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetInt(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInt_Public_Int32_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159920, XrefRangeEnd = 1159923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159923, XrefRangeEnd = 1159926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBool(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBool_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159926, XrefRangeEnd = 1159929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159929, XrefRangeEnd = 1159932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetReadMask(AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadMask_Public_Boolean_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159932, XrefRangeEnd = 1159934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResolveInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolveInternal_Private_Void_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159934, XrefRangeEnd = 1159936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159936, XrefRangeEnd = 1159938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloatInternal(ref AnimationStream stream, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloatInternal_Private_Void_byref_AnimationStream_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159938, XrefRangeEnd = 1159940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159940, XrefRangeEnd = 1159942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIntInternal(ref AnimationStream stream, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIntInternal_Private_Void_byref_AnimationStream_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159942, XrefRangeEnd = 1159944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetBoolInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBoolInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159944, XrefRangeEnd = 1159946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBoolInternal(ref AnimationStream stream, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoolInternal_Private_Void_byref_AnimationStream_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159946, XrefRangeEnd = 1159948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetReadMaskInternal(ref AnimationStream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReadMaskInternal_Private_Boolean_byref_AnimationStream_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PropertyStreamHandle>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
