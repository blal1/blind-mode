using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Audio;

[StructLayout(LayoutKind.Explicit)]
public struct AudioPlayableOutput
{
	private delegate bool InternalGetEvaluateOnSeekDelegate(System.IntPtr output);

	private delegate System.IntPtr InternalGetTarget_InjectedDelegate(System.IntPtr output);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_AudioPlayableOutput_PlayableGraph_String_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_AudioPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AudioPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_AudioPlayableOutput_PlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTarget_Public_Void_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEvaluateOnSeek_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetEvaluateOnSeek_Private_Static_Void_byref_PlayableOutputHandle_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetTarget_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0;

	[FieldOffset(0)]
	public PlayableOutputHandle m_Handle;

	private static readonly InternalGetEvaluateOnSeekDelegate InternalGetEvaluateOnSeekDelegateField;

	private static readonly InternalGetTarget_InjectedDelegate InternalGetTarget_InjectedDelegateField;

	public unsafe static AudioPlayableOutput Null
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163697, XrefRangeEnd = 1163710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Null_Public_Static_get_AudioPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AudioPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AudioPlayableOutput()
	{
		Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Audio", "AudioPlayableOutput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_Create_Public_Static_AudioPlayableOutput_PlayableGraph_String_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_get_Null_Public_Static_get_AudioPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AudioPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_op_Explicit_Public_Static_AudioPlayableOutput_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_SetTarget_Public_Void_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_SetEvaluateOnSeek_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_InternalSetEvaluateOnSeek_Private_Static_Void_byref_PlayableOutputHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_InternalSetTarget_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, 100663464);
		InternalGetEvaluateOnSeekDelegateField = IL2CPP.ResolveICall<InternalGetEvaluateOnSeekDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetEvaluateOnSeek");
		InternalGetTarget_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetTarget_InjectedDelegate>("UnityEngine.Audio.AudioPlayableOutput::InternalGetTarget_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163687, RefRangeEnd = 1163688, XrefRangeStart = 1163672, XrefRangeEnd = 1163687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_AudioPlayableOutput_PlayableGraph_String_AudioSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AudioPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163688, XrefRangeEnd = 1163697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioPlayableOutput(PlayableOutputHandle handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(65)]
	[CachedScanResults(RefRangeStart = 1158071, RefRangeEnd = 1158136, XrefRangeStart = 1158071, XrefRangeEnd = 1158136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayableOutputHandle GetHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutputHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1158137, RefRangeEnd = 1158142, XrefRangeStart = 1158137, XrefRangeEnd = 1158142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator PlayableOutput(AudioPlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_AudioPlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163723, RefRangeEnd = 1163724, XrefRangeStart = 1163710, XrefRangeEnd = 1163723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static explicit operator AudioPlayableOutput(PlayableOutput output)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Explicit_Public_Static_AudioPlayableOutput_PlayableOutput_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(AudioPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163724, XrefRangeEnd = 1163729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTarget(AudioSource value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTarget_Public_Void_AudioSource_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163731, RefRangeEnd = 1163732, XrefRangeStart = 1163729, XrefRangeEnd = 1163731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEvaluateOnSeek(bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEvaluateOnSeek_Public_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetTarget_Private_Static_Void_byref_PlayableOutputHandle_AudioSource_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1163731, RefRangeEnd = 1163732, XrefRangeStart = 1163731, XrefRangeEnd = 1163732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetEvaluateOnSeek_Private_Static_Void_byref_PlayableOutputHandle_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163732, XrefRangeEnd = 1163734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalSetTarget_Injected(ref PlayableOutputHandle output, System.IntPtr target)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref output);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &target;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetTarget_Injected_Private_Static_Void_byref_PlayableOutputHandle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioPlayableOutput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public AudioSource GetTarget()
	{
		return InternalGetTarget(ref m_Handle);
	}

	public bool GetEvaluateOnSeek()
	{
		return InternalGetEvaluateOnSeek(ref m_Handle);
	}

	public static AudioSource InternalGetTarget(ref PlayableOutputHandle output)
	{
		return Unmarshal.UnmarshalUnityObject<AudioSource>(InternalGetTarget_Injected(ref output));
	}

	public unsafe static bool InternalGetEvaluateOnSeek(ref PlayableOutputHandle output)
	{
		return InternalGetEvaluateOnSeekDelegateField((nint)Unsafe.AsPointer(ref output));
	}

	public unsafe static System.IntPtr InternalGetTarget_Injected(ref PlayableOutputHandle output)
	{
		return InternalGetTarget_InjectedDelegateField((nint)Unsafe.AsPointer(ref output));
	}
}
