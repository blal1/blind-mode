using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

[StructLayout(LayoutKind.Explicit)]
public struct AnimationOffsetPlayable
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NullPlayable;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationOffsetPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AnimationOffsetPlayable_PlayableGraph_Vector3_Quaternion_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Vector3_Quaternion_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationOffsetPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationOffsetPlayable_Playable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotation_Public_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotation_Public_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_Vector3_Quaternion_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionInternal_Private_Static_Vector3_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionInternal_Private_Static_Void_byref_PlayableHandle_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationInternal_Private_Static_Quaternion_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationInternal_Private_Static_Void_byref_PlayableHandle_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_Vector3_byref_Quaternion_byref_PlayableHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositionInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRotationInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotationInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Quaternion_0;

	[FieldOffset(0)]
	public PlayableHandle m_Handle;

	public unsafe static AnimationOffsetPlayable m_NullPlayable
	{
		get
		{
			Unsafe.SkipInit(out AnimationOffsetPlayable result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_NullPlayable, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_NullPlayable, (void*)(&value));
		}
	}

	public unsafe static AnimationOffsetPlayable Null
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158957, XrefRangeEnd = 1158961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationOffsetPlayable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AnimationOffsetPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AnimationOffsetPlayable()
	{
		Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "AnimationOffsetPlayable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_Handle");
		NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, "m_NullPlayable");
		NativeMethodInfoPtr_get_Null_Public_Static_get_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664512);
		NativeMethodInfoPtr_Create_Public_Static_AnimationOffsetPlayable_PlayableGraph_Vector3_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664513);
		NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Vector3_Quaternion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664514);
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664515);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664516);
		NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664517);
		NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationOffsetPlayable_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664518);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664519);
		NativeMethodInfoPtr_GetPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664520);
		NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664521);
		NativeMethodInfoPtr_GetRotation_Public_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664522);
		NativeMethodInfoPtr_SetRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664523);
		NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_Vector3_Quaternion_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664524);
		NativeMethodInfoPtr_GetPositionInternal_Private_Static_Vector3_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664525);
		NativeMethodInfoPtr_SetPositionInternal_Private_Static_Void_byref_PlayableHandle_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664526);
		NativeMethodInfoPtr_GetRotationInternal_Private_Static_Quaternion_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664527);
		NativeMethodInfoPtr_SetRotationInternal_Private_Static_Void_byref_PlayableHandle_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664528);
		NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_Vector3_byref_Quaternion_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664530);
		NativeMethodInfoPtr_GetPositionInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664531);
		NativeMethodInfoPtr_SetPositionInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664532);
		NativeMethodInfoPtr_GetRotationInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664533);
		NativeMethodInfoPtr_SetRotationInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, 100664534);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1158991, RefRangeEnd = 1158994, XrefRangeStart = 1158961, XrefRangeEnd = 1158991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AnimationOffsetPlayable_PlayableGraph_Vector3_Quaternion_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationOffsetPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1158994, XrefRangeEnd = 1159012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_Vector3_Quaternion_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159012, XrefRangeEnd = 1159021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationOffsetPlayable(PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1159025, RefRangeEnd = 1159028, XrefRangeStart = 1159021, XrefRangeEnd = 1159025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Playable(AnimationOffsetPlayable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_AnimationOffsetPlayable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159028, XrefRangeEnd = 1159041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator AnimationOffsetPlayable(Playable playable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&playable);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_AnimationOffsetPlayable_Playable_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AnimationOffsetPlayable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159041, XrefRangeEnd = 1159049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(AnimationOffsetPlayable other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationOffsetPlayable_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159049, XrefRangeEnd = 1159057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPosition()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosition_Public_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159057, XrefRangeEnd = 1159065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Public_Void_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159065, XrefRangeEnd = 1159073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion GetRotation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotation_Public_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159073, XrefRangeEnd = 1159081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRotation(Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotation_Public_Void_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159081, XrefRangeEnd = 1159086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&graph);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		*(Quaternion**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandleInternal_Private_Static_Boolean_PlayableGraph_Vector3_Quaternion_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159086, XrefRangeEnd = 1159091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetPositionInternal(ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionInternal_Private_Static_Vector3_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159091, XrefRangeEnd = 1159096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPositionInternal(ref PlayableHandle handle, Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionInternal_Private_Static_Void_byref_PlayableHandle_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159096, XrefRangeEnd = 1159101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetRotationInternal(ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationInternal_Private_Static_Quaternion_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159101, XrefRangeEnd = 1159106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRotationInternal(ref PlayableHandle handle, Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationInternal_Private_Static_Void_byref_PlayableHandle_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159106, XrefRangeEnd = 1159108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CreateHandleInternal_Injected([In] ref PlayableGraph graph, [In] ref Vector3 position, [In] ref Quaternion rotation, ref PlayableHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref graph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateHandleInternal_Injected_Private_Static_Boolean_byref_PlayableGraph_byref_Vector3_byref_Quaternion_byref_PlayableHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159108, XrefRangeEnd = 1159110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPositionInternal_Injected(ref PlayableHandle handle, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositionInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159110, XrefRangeEnd = 1159112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPositionInternal_Injected(ref PlayableHandle handle, [In] ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159112, XrefRangeEnd = 1159114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRotationInternal_Injected(ref PlayableHandle handle, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRotationInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1159114, XrefRangeEnd = 1159116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetRotationInternal_Injected(ref PlayableHandle handle, [In] ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotationInternal_Injected_Private_Static_Void_byref_PlayableHandle_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimationOffsetPlayable>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
