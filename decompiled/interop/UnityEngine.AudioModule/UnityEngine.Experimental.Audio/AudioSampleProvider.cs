using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Experimental.Audio;

public class AudioSampleProvider : Il2CppSystem.Object
{
	public sealed class SampleFramesHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0;

		static SampleFramesHandler()
		{
			Il2CppClassPointerStore<SampleFramesHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "SampleFramesHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFramesHandler>.NativeClassPtr, 100663408);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleFramesHandler>.NativeClassPtr, 100663409);
		}

		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 81254, RefRangeEnd = 81275, XrefRangeStart = 81254, XrefRangeEnd = 81275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SampleFramesHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SampleFramesHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
			*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sampleFrameCount;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioSampleProvider_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SampleFramesHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator SampleFramesHandler(System.Action<AudioSampleProvider, uint> P_0)
		{
			return DelegateSupport.ConvertDelegate<SampleFramesHandler>((System.Delegate)P_0);
		}

		public static SampleFramesHandler operator +(SampleFramesHandler P_0, SampleFramesHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<SampleFramesHandler>();
		}

		public static SampleFramesHandler operator -(SampleFramesHandler P_0, SampleFramesHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<SampleFramesHandler>();
			}
			return (SampleFramesHandler)obj;
		}
	}

	private delegate uint InternalCreateSampleProviderDelegate(ushort channelCount, uint sampleRate);

	private delegate void InternalRemoveDelegate(uint providerId);

	private delegate void InternalGetFormatInfoDelegate(uint providerId, [Out] System.IntPtr chCount, [Out] System.IntPtr sRate);

	private delegate System.IntPtr InternalGetScriptingPtrDelegate(uint providerId);

	private delegate void InternalSetScriptingPtrDelegate(uint providerId, System.IntPtr provider);

	private delegate bool InternalIsValidDelegate(uint providerId);

	private delegate uint InternalGetMaxSampleFrameCountDelegate(uint providerId);

	private delegate uint InternalGetAvailableSampleFrameCountDelegate(uint providerId);

	private delegate uint InternalGetFreeSampleFrameCountDelegate(uint providerId);

	private delegate uint InternalGetFreeSampleFrameCountLowThresholdDelegate(uint providerId);

	private delegate void InternalSetFreeSampleFrameCountLowThresholdDelegate(uint providerId, uint sampleFrameCount);

	private delegate bool InternalGetEnableSampleFramesAvailableEventsDelegate(uint providerId);

	private delegate void InternalSetEnableSampleFramesAvailableEventsDelegate(uint providerId, bool enable);

	private delegate void InternalSetSampleFramesAvailableNativeHandlerDelegate(uint providerId, System.IntPtr handler, System.IntPtr userData);

	private delegate void InternalClearSampleFramesAvailableNativeHandlerDelegate(uint providerId);

	private delegate void InternalSetSampleFramesOverflowNativeHandlerDelegate(uint providerId, System.IntPtr handler, System.IntPtr userData);

	private delegate void InternalClearSampleFramesOverflowNativeHandlerDelegate(uint providerId);

	private delegate bool InternalGetEnableSilencePaddingDelegate(uint id);

	private delegate void InternalSetEnableSilencePaddingDelegate(uint id, bool enabled);

	private delegate System.IntPtr InternalGetConsumeSampleFramesNativeFunctionPtrDelegate();

	private delegate uint InternalQueueSampleFramesDelegate(uint id, System.IntPtr interleavedSampleFrames, uint sampleFrameCount);

	private static readonly System.IntPtr NativeFieldInfoPtr_sampleFramesAvailable;

	private static readonly System.IntPtr NativeFieldInfoPtr_sampleFramesOverflow;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0;

	private static readonly InternalCreateSampleProviderDelegate InternalCreateSampleProviderDelegateField;

	private static readonly InternalRemoveDelegate InternalRemoveDelegateField;

	private static readonly InternalGetFormatInfoDelegate InternalGetFormatInfoDelegateField;

	private static readonly InternalGetScriptingPtrDelegate InternalGetScriptingPtrDelegateField;

	private static readonly InternalSetScriptingPtrDelegate InternalSetScriptingPtrDelegateField;

	private static readonly InternalIsValidDelegate InternalIsValidDelegateField;

	private static readonly InternalGetMaxSampleFrameCountDelegate InternalGetMaxSampleFrameCountDelegateField;

	private static readonly InternalGetAvailableSampleFrameCountDelegate InternalGetAvailableSampleFrameCountDelegateField;

	private static readonly InternalGetFreeSampleFrameCountDelegate InternalGetFreeSampleFrameCountDelegateField;

	private static readonly InternalGetFreeSampleFrameCountLowThresholdDelegate InternalGetFreeSampleFrameCountLowThresholdDelegateField;

	private static readonly InternalSetFreeSampleFrameCountLowThresholdDelegate InternalSetFreeSampleFrameCountLowThresholdDelegateField;

	private static readonly InternalGetEnableSampleFramesAvailableEventsDelegate InternalGetEnableSampleFramesAvailableEventsDelegateField;

	private static readonly InternalSetEnableSampleFramesAvailableEventsDelegate InternalSetEnableSampleFramesAvailableEventsDelegateField;

	private static readonly InternalSetSampleFramesAvailableNativeHandlerDelegate InternalSetSampleFramesAvailableNativeHandlerDelegateField;

	private static readonly InternalClearSampleFramesAvailableNativeHandlerDelegate InternalClearSampleFramesAvailableNativeHandlerDelegateField;

	private static readonly InternalSetSampleFramesOverflowNativeHandlerDelegate InternalSetSampleFramesOverflowNativeHandlerDelegateField;

	private static readonly InternalClearSampleFramesOverflowNativeHandlerDelegate InternalClearSampleFramesOverflowNativeHandlerDelegateField;

	private static readonly InternalGetEnableSilencePaddingDelegate InternalGetEnableSilencePaddingDelegateField;

	private static readonly InternalSetEnableSilencePaddingDelegate InternalSetEnableSilencePaddingDelegateField;

	private static readonly InternalGetConsumeSampleFramesNativeFunctionPtrDelegate InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField;

	private static readonly InternalQueueSampleFramesDelegate InternalQueueSampleFramesDelegateField;

	public unsafe SampleFramesHandler sampleFramesAvailable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleFramesAvailable);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SampleFramesHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleFramesAvailable)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SampleFramesHandler sampleFramesOverflow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleFramesOverflow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SampleFramesHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sampleFramesOverflow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public uint id
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public ushort trackIndex
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public Object owner
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool valid => InternalIsValid(id);

	public ushort channelCount
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public uint sampleRate
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public uint maxSampleFrameCount => InternalGetMaxSampleFrameCount(id);

	public uint availableSampleFrameCount => InternalGetAvailableSampleFrameCount(id);

	public uint freeSampleFrameCount => InternalGetFreeSampleFrameCount(id);

	public uint freeSampleFrameCountLowThreshold
	{
		get
		{
			return InternalGetFreeSampleFrameCountLowThreshold(id);
		}
		set
		{
			InternalSetFreeSampleFrameCountLowThreshold(id, value);
		}
	}

	public bool enableSampleFramesAvailableEvents
	{
		get
		{
			return InternalGetEnableSampleFramesAvailableEvents(id);
		}
		set
		{
			InternalSetEnableSampleFramesAvailableEvents(id, value);
		}
	}

	public bool enableSilencePadding
	{
		get
		{
			return InternalGetEnableSilencePadding(id);
		}
		set
		{
			InternalSetEnableSilencePadding(id, value);
		}
	}

	static AudioSampleProvider()
	{
		Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine.Experimental.Audio", "AudioSampleProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr);
		NativeFieldInfoPtr_sampleFramesAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesAvailable");
		NativeFieldInfoPtr_sampleFramesOverflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, "sampleFramesOverflow");
		NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSampleProvider>.NativeClassPtr, 100663407);
		InternalCreateSampleProviderDelegateField = IL2CPP.ResolveICall<InternalCreateSampleProviderDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalCreateSampleProvider");
		InternalRemoveDelegateField = IL2CPP.ResolveICall<InternalRemoveDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalRemove");
		InternalGetFormatInfoDelegateField = IL2CPP.ResolveICall<InternalGetFormatInfoDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFormatInfo");
		InternalGetScriptingPtrDelegateField = IL2CPP.ResolveICall<InternalGetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetScriptingPtr");
		InternalSetScriptingPtrDelegateField = IL2CPP.ResolveICall<InternalSetScriptingPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetScriptingPtr");
		InternalIsValidDelegateField = IL2CPP.ResolveICall<InternalIsValidDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalIsValid");
		InternalGetMaxSampleFrameCountDelegateField = IL2CPP.ResolveICall<InternalGetMaxSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetMaxSampleFrameCount");
		InternalGetAvailableSampleFrameCountDelegateField = IL2CPP.ResolveICall<InternalGetAvailableSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetAvailableSampleFrameCount");
		InternalGetFreeSampleFrameCountDelegateField = IL2CPP.ResolveICall<InternalGetFreeSampleFrameCountDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCount");
		InternalGetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<InternalGetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetFreeSampleFrameCountLowThreshold");
		InternalSetFreeSampleFrameCountLowThresholdDelegateField = IL2CPP.ResolveICall<InternalSetFreeSampleFrameCountLowThresholdDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetFreeSampleFrameCountLowThreshold");
		InternalGetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<InternalGetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSampleFramesAvailableEvents");
		InternalSetEnableSampleFramesAvailableEventsDelegateField = IL2CPP.ResolveICall<InternalSetEnableSampleFramesAvailableEventsDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSampleFramesAvailableEvents");
		InternalSetSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<InternalSetSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesAvailableNativeHandler");
		InternalClearSampleFramesAvailableNativeHandlerDelegateField = IL2CPP.ResolveICall<InternalClearSampleFramesAvailableNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesAvailableNativeHandler");
		InternalSetSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<InternalSetSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetSampleFramesOverflowNativeHandler");
		InternalClearSampleFramesOverflowNativeHandlerDelegateField = IL2CPP.ResolveICall<InternalClearSampleFramesOverflowNativeHandlerDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalClearSampleFramesOverflowNativeHandler");
		InternalGetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<InternalGetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetEnableSilencePadding");
		InternalSetEnableSilencePaddingDelegateField = IL2CPP.ResolveICall<InternalSetEnableSilencePaddingDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalSetEnableSilencePadding");
		InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField = IL2CPP.ResolveICall<InternalGetConsumeSampleFramesNativeFunctionPtrDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalGetConsumeSampleFramesNativeFunctionPtr");
		InternalQueueSampleFramesDelegateField = IL2CPP.ResolveICall<InternalQueueSampleFramesDelegate>("UnityEngine.Experimental.Audio.AudioSampleProvider::InternalQueueSampleFrames");
	}

	[CallerCount(0)]
	public unsafe void InvokeSampleFramesAvailable(int sampleFrameCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sampleFrameCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSampleFramesAvailable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void InvokeSampleFramesOverflow(int droppedSampleFrameCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&droppedSampleFrameCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSampleFramesOverflow_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AudioSampleProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static AudioSampleProvider Lookup(uint providerId, Object ownerObj, ushort trackIndex)
	{
		AudioSampleProvider audioSampleProvider = InternalGetScriptingPtr(providerId);
		if (audioSampleProvider != null || !InternalIsValid(providerId))
		{
			return audioSampleProvider;
		}
		return new AudioSampleProvider(providerId, ownerObj, trackIndex);
	}

	public static AudioSampleProvider Create(ushort channelCount, uint sampleRate)
	{
		uint num = InternalCreateSampleProvider(channelCount, sampleRate);
		if (!InternalIsValid(num))
		{
			return null;
		}
		return new AudioSampleProvider(num, (Object)null, (ushort)0);
	}

	~AudioSampleProvider()
	{
		owner = null;
		Dispose();
	}

	public void Dispose()
	{
		if (id != 0)
		{
			InternalSetScriptingPtr(id, null);
			if (owner == null)
			{
				InternalRemove(id);
			}
			id = 0u;
		}
		Il2CppSystem.GC.SuppressFinalize(this);
	}

	public uint ConsumeSampleFrames(NativeArray<float> sampleFrames)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe uint QueueSampleFrames(NativeArray<float> sampleFrames)
	{
		//IL_002a: Expected O, but got Ref
		if (channelCount == 0)
		{
			return 0u;
		}
		return InternalQueueSampleFrames(id, (System.IntPtr)sampleFrames.GetUnsafeReadOnlyPtr(), (uint)(((NativeArray<float>)(&sampleFrames)).Length / channelCount));
	}

	[SpecialName]
	public void add_sampleFramesAvailable(SampleFramesHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_sampleFramesAvailable(SampleFramesHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_sampleFramesOverflow(SampleFramesHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_sampleFramesOverflow(SampleFramesHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ClearSampleFramesAvailableNativeHandler()
	{
		InternalClearSampleFramesAvailableNativeHandler(id);
	}

	public void ClearSampleFramesOverflowNativeHandler()
	{
		InternalClearSampleFramesOverflowNativeHandler(id);
	}

	public static uint InternalCreateSampleProvider(ushort channelCount, uint sampleRate)
	{
		return InternalCreateSampleProviderDelegateField(channelCount, sampleRate);
	}

	public static void InternalRemove(uint providerId)
	{
		InternalRemoveDelegateField(providerId);
	}

	public unsafe static void InternalGetFormatInfo(uint providerId, out ushort chCount, out uint sRate)
	{
		InternalGetFormatInfoDelegateField(providerId, (nint)Unsafe.AsPointer(ref chCount), (nint)Unsafe.AsPointer(ref sRate));
	}

	public static AudioSampleProvider InternalGetScriptingPtr(uint providerId)
	{
		System.IntPtr intPtr = InternalGetScriptingPtrDelegateField(providerId);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSampleProvider>(intPtr) : null;
	}

	public static void InternalSetScriptingPtr(uint providerId, AudioSampleProvider provider)
	{
		InternalSetScriptingPtrDelegateField(providerId, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider));
	}

	public static bool InternalIsValid(uint providerId)
	{
		return InternalIsValidDelegateField(providerId);
	}

	public static uint InternalGetMaxSampleFrameCount(uint providerId)
	{
		return InternalGetMaxSampleFrameCountDelegateField(providerId);
	}

	public static uint InternalGetAvailableSampleFrameCount(uint providerId)
	{
		return InternalGetAvailableSampleFrameCountDelegateField(providerId);
	}

	public static uint InternalGetFreeSampleFrameCount(uint providerId)
	{
		return InternalGetFreeSampleFrameCountDelegateField(providerId);
	}

	public static uint InternalGetFreeSampleFrameCountLowThreshold(uint providerId)
	{
		return InternalGetFreeSampleFrameCountLowThresholdDelegateField(providerId);
	}

	public static void InternalSetFreeSampleFrameCountLowThreshold(uint providerId, uint sampleFrameCount)
	{
		InternalSetFreeSampleFrameCountLowThresholdDelegateField(providerId, sampleFrameCount);
	}

	public static bool InternalGetEnableSampleFramesAvailableEvents(uint providerId)
	{
		return InternalGetEnableSampleFramesAvailableEventsDelegateField(providerId);
	}

	public static void InternalSetEnableSampleFramesAvailableEvents(uint providerId, bool enable)
	{
		InternalSetEnableSampleFramesAvailableEventsDelegateField(providerId, enable);
	}

	public static void InternalSetSampleFramesAvailableNativeHandler(uint providerId, System.IntPtr handler, System.IntPtr userData)
	{
		InternalSetSampleFramesAvailableNativeHandlerDelegateField(providerId, handler, userData);
	}

	public static void InternalClearSampleFramesAvailableNativeHandler(uint providerId)
	{
		InternalClearSampleFramesAvailableNativeHandlerDelegateField(providerId);
	}

	public static void InternalSetSampleFramesOverflowNativeHandler(uint providerId, System.IntPtr handler, System.IntPtr userData)
	{
		InternalSetSampleFramesOverflowNativeHandlerDelegateField(providerId, handler, userData);
	}

	public static void InternalClearSampleFramesOverflowNativeHandler(uint providerId)
	{
		InternalClearSampleFramesOverflowNativeHandlerDelegateField(providerId);
	}

	public static bool InternalGetEnableSilencePadding(uint id)
	{
		return InternalGetEnableSilencePaddingDelegateField(id);
	}

	public static void InternalSetEnableSilencePadding(uint id, bool enabled)
	{
		InternalSetEnableSilencePaddingDelegateField(id, enabled);
	}

	public static System.IntPtr InternalGetConsumeSampleFramesNativeFunctionPtr()
	{
		return InternalGetConsumeSampleFramesNativeFunctionPtrDelegateField();
	}

	public static uint InternalQueueSampleFrames(uint id, System.IntPtr interleavedSampleFrames, uint sampleFrameCount)
	{
		return InternalQueueSampleFramesDelegateField(id, interleavedSampleFrames, sampleFrameCount);
	}
}
