using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Audio;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class AudioClip : AudioResource
{
	public sealed class PCMReaderCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0;

		static PCMReaderCallback()
		{
			Il2CppClassPointerStore<PCMReaderCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMReaderCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCMReaderCallback>.NativeClassPtr, 100663322);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCMReaderCallback>.NativeClassPtr, 100663323);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PCMReaderCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCMReaderCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(Il2CppStructArray<float> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PCMReaderCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator PCMReaderCallback(System.Action<Il2CppStructArray<float>> P_0)
		{
			return DelegateSupport.ConvertDelegate<PCMReaderCallback>((System.Delegate)P_0);
		}

		public static PCMReaderCallback operator +(PCMReaderCallback P_0, PCMReaderCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<PCMReaderCallback>();
		}

		public static PCMReaderCallback operator -(PCMReaderCallback P_0, PCMReaderCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PCMReaderCallback>();
			}
			return (PCMReaderCallback)obj;
		}
	}

	public sealed class PCMSetPositionCallback : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		static PCMSetPositionCallback()
		{
			Il2CppClassPointerStore<PCMSetPositionCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "PCMSetPositionCallback");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCMSetPositionCallback>.NativeClassPtr, 100663324);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCMSetPositionCallback>.NativeClassPtr, 100663325);
		}

		[CallerCount(392)]
		[CachedScanResults(RefRangeStart = 354265, RefRangeEnd = 354657, XrefRangeStart = 354265, XrefRangeEnd = 354657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PCMSetPositionCallback(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCMSetPositionCallback>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&position);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PCMSetPositionCallback(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator PCMSetPositionCallback(System.Action<int> P_0)
		{
			return DelegateSupport.ConvertDelegate<PCMSetPositionCallback>((System.Delegate)P_0);
		}

		public static PCMSetPositionCallback operator +(PCMSetPositionCallback P_0, PCMSetPositionCallback P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<PCMSetPositionCallback>();
		}

		public static PCMSetPositionCallback operator -(PCMSetPositionCallback P_0, PCMSetPositionCallback P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PCMSetPositionCallback>();
			}
			return (PCMSetPositionCallback)obj;
		}
	}

	private delegate bool GetData_InjectedDelegate(System.IntPtr clip, System.IntPtr data, int samplesOffset);

	private delegate bool SetData_InjectedDelegate(System.IntPtr clip, System.IntPtr data, int samplesOffset);

	private delegate System.IntPtr Construct_Internal_InjectedDelegate();

	private delegate void GetName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void CreateUserSound_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, int lengthSamples, int channels, int frequency, bool stream);

	private delegate int get_channels_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isReadyToPlay_InjectedDelegate(System.IntPtr _unity_self);

	private delegate AudioClipLoadType get_loadType_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_ambisonic_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_loadInBackground_InjectedDelegate(System.IntPtr _unity_self);

	private delegate AudioDataLoadState get_loadState_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PCMReaderCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PCMSetPositionCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_samples_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frequency_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAudioData_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAudioData_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_preloadAudioData_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_samples_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frequency_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAudioData_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAudioData_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_preloadAudioData_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly GetData_InjectedDelegate GetData_InjectedDelegateField;

	private static readonly SetData_InjectedDelegate SetData_InjectedDelegateField;

	private static readonly Construct_Internal_InjectedDelegate Construct_Internal_InjectedDelegateField;

	private static readonly GetName_InjectedDelegate GetName_InjectedDelegateField;

	private static readonly CreateUserSound_InjectedDelegate CreateUserSound_InjectedDelegateField;

	private static readonly get_channels_InjectedDelegate get_channels_InjectedDelegateField;

	private static readonly get_isReadyToPlay_InjectedDelegate get_isReadyToPlay_InjectedDelegateField;

	private static readonly get_loadType_InjectedDelegate get_loadType_InjectedDelegateField;

	private static readonly get_ambisonic_InjectedDelegate get_ambisonic_InjectedDelegateField;

	private static readonly get_loadInBackground_InjectedDelegate get_loadInBackground_InjectedDelegateField;

	private static readonly get_loadState_InjectedDelegate get_loadState_InjectedDelegateField;

	public unsafe PCMReaderCallback m_PCMReaderCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PCMReaderCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PCMReaderCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PCMReaderCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe PCMSetPositionCallback m_PCMSetPositionCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PCMSetPositionCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PCMSetPositionCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PCMSetPositionCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float length
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1162841, RefRangeEnd = 1162844, XrefRangeStart = 1162836, XrefRangeEnd = 1162841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int samples
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1162849, RefRangeEnd = 1162852, XrefRangeStart = 1162844, XrefRangeEnd = 1162849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_samples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int frequency
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162857, RefRangeEnd = 1162858, XrefRangeStart = 1162852, XrefRangeEnd = 1162857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frequency_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool preloadAudioData
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1162875, RefRangeEnd = 1162877, XrefRangeStart = 1162870, XrefRangeEnd = 1162875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preloadAudioData_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int channels
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_channels_Injected(intPtr);
		}
	}

	public bool isReadyToPlay
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isReadyToPlay_Injected(intPtr);
		}
	}

	public AudioClipLoadType loadType
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loadType_Injected(intPtr);
		}
	}

	public bool ambisonic
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_ambisonic_Injected(intPtr);
		}
	}

	public bool loadInBackground
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loadInBackground_Injected(intPtr);
		}
	}

	public AudioDataLoadState loadState
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loadState_Injected(intPtr);
		}
	}

	static AudioClip()
	{
		Il2CppClassPointerStore<AudioClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioClip>.NativeClassPtr);
		NativeFieldInfoPtr_m_PCMReaderCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMReaderCallback");
		NativeFieldInfoPtr_m_PCMSetPositionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, "m_PCMSetPositionCallback");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_get_length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_get_samples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_get_frequency_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_LoadAudioData_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_UnloadAudioData_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_get_preloadAudioData_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_get_length_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_get_samples_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_frequency_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_LoadAudioData_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_UnloadAudioData_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_get_preloadAudioData_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioClip>.NativeClassPtr, 100663321);
		GetData_InjectedDelegateField = IL2CPP.ResolveICall<GetData_InjectedDelegate>("UnityEngine.AudioClip::GetData_Injected");
		SetData_InjectedDelegateField = IL2CPP.ResolveICall<SetData_InjectedDelegate>("UnityEngine.AudioClip::SetData_Injected");
		Construct_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Construct_Internal_InjectedDelegate>("UnityEngine.AudioClip::Construct_Internal_Injected");
		GetName_InjectedDelegateField = IL2CPP.ResolveICall<GetName_InjectedDelegate>("UnityEngine.AudioClip::GetName_Injected");
		CreateUserSound_InjectedDelegateField = IL2CPP.ResolveICall<CreateUserSound_InjectedDelegate>("UnityEngine.AudioClip::CreateUserSound_Injected");
		get_channels_InjectedDelegateField = IL2CPP.ResolveICall<get_channels_InjectedDelegate>("UnityEngine.AudioClip::get_channels_Injected");
		get_isReadyToPlay_InjectedDelegateField = IL2CPP.ResolveICall<get_isReadyToPlay_InjectedDelegate>("UnityEngine.AudioClip::get_isReadyToPlay_Injected");
		get_loadType_InjectedDelegateField = IL2CPP.ResolveICall<get_loadType_InjectedDelegate>("UnityEngine.AudioClip::get_loadType_Injected");
		get_ambisonic_InjectedDelegateField = IL2CPP.ResolveICall<get_ambisonic_InjectedDelegate>("UnityEngine.AudioClip::get_ambisonic_Injected");
		get_loadInBackground_InjectedDelegateField = IL2CPP.ResolveICall<get_loadInBackground_InjectedDelegate>("UnityEngine.AudioClip::get_loadInBackground_Injected");
		get_loadState_InjectedDelegateField = IL2CPP.ResolveICall<get_loadState_InjectedDelegate>("UnityEngine.AudioClip::get_loadState_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162830, XrefRangeEnd = 1162836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioClip>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162863, RefRangeEnd = 1162864, XrefRangeStart = 1162858, XrefRangeEnd = 1162863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool LoadAudioData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAudioData_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1162869, RefRangeEnd = 1162870, XrefRangeStart = 1162864, XrefRangeEnd = 1162869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UnloadAudioData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadAudioData_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void InvokePCMReaderCallback_Internal(Il2CppStructArray<float> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokePCMReaderCallback_Internal_Private_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void InvokePCMSetPositionCallback_Internal(int position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokePCMSetPositionCallback_Internal_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162877, XrefRangeEnd = 1162879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_length_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162879, XrefRangeEnd = 1162881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_samples_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_samples_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162881, XrefRangeEnd = 1162883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_frequency_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frequency_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162883, XrefRangeEnd = 1162885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadAudioData_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAudioData_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162885, XrefRangeEnd = 1162887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UnloadAudioData_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnloadAudioData_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162887, XrefRangeEnd = 1162889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_preloadAudioData_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_preloadAudioData_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AudioClip(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static bool GetData(AudioClip clip, Il2CppSystem.Span<float> data, int samplesOffset)
	{
		//IL_002d: Expected O, but got Ref
		//IL_0039: Expected O, but got Ref
		if ((object)clip == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(clip, "clip");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(clip);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(clip, "clip");
		}
		Il2CppSystem.Span<float> span = data;
		bool data_Injected;
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			data_Injected = GetData_Injected(intPtr, ref data2, samplesOffset);
		}
		return data_Injected;
	}

	public unsafe static bool SetData(AudioClip clip, Il2CppSystem.ReadOnlySpan<float> data, int samplesOffset)
	{
		//IL_002d: Expected O, but got Ref
		//IL_0039: Expected O, but got Ref
		if ((object)clip == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(clip, "clip");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(clip);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(clip, "clip");
		}
		Il2CppSystem.ReadOnlySpan<float> readOnlySpan = data;
		bool result;
		fixed (float* begin = &((Il2CppSystem.ReadOnlySpan<float>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<float>)(&readOnlySpan)).Length);
			result = SetData_Injected(intPtr, ref data2, samplesOffset);
		}
		return result;
	}

	public static AudioClip Construct_Internal()
	{
		return Unmarshal.UnmarshalUnityObject<AudioClip>(Construct_Internal_Injected());
	}

	public new string GetName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetName_Injected(intPtr, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					CreateUserSound_Injected(intPtr, ref managedSpanWrapper, lengthSamples, channels, frequency, stream);
					return;
				}
			}
			CreateUserSound_Injected(intPtr, ref managedSpanWrapper, lengthSamples, channels, frequency, stream);
		}
		finally
		{
		}
	}

	public bool GetData(Il2CppSystem.Span<float> data, int offsetSamples)
	{
		if (channels <= 0)
		{
			Debug.Log(Il2CppSystem.String.Concat("AudioClip.GetData failed; AudioClip ", GetName(), " contains no data"));
			return false;
		}
		return GetData(this, data, offsetSamples);
	}

	public bool GetData(Il2CppStructArray<float> data, int offsetSamples)
	{
		if (channels <= 0)
		{
			Debug.Log(Il2CppSystem.String.Concat("AudioClip.GetData failed; AudioClip ", GetName(), " contains no data"));
			return false;
		}
		return GetData(this, ((Il2CppArrayBase<float>)(object)data).AsSpan<float>(), offsetSamples);
	}

	public bool SetData(Il2CppStructArray<float> data, int offsetSamples)
	{
		if (channels <= 0)
		{
			Debug.Log(Il2CppSystem.String.Concat("AudioClip.SetData failed; AudioClip ", GetName(), " contains no data"));
			return false;
		}
		if (offsetSamples < 0 || offsetSamples >= samples)
		{
			throw new Il2CppSystem.ArgumentException("AudioClip.SetData failed; invalid offsetSamples");
		}
		if (data == null || ((Il2CppArrayBase)data).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("AudioClip.SetData failed; invalid data");
		}
		return SetData(this, ((Il2CppArrayBase<float>)(object)data).AsSpan<float>(), offsetSamples);
	}

	public unsafe bool SetData(Il2CppSystem.ReadOnlySpan<float> data, int offsetSamples)
	{
		//IL_005a: Expected O, but got Ref
		if (channels <= 0)
		{
			Debug.Log(Il2CppSystem.String.Concat("AudioClip.SetData failed; AudioClip ", GetName(), " contains no data"));
			return false;
		}
		if (offsetSamples < 0 || offsetSamples >= samples)
		{
			throw new Il2CppSystem.ArgumentException("AudioClip.SetData failed; invalid offsetSamples");
		}
		if (((Il2CppSystem.ReadOnlySpan<float>)(&data)).Length == 0)
		{
			throw new Il2CppSystem.ArgumentException("AudioClip.SetData failed; invalid data");
		}
		return SetData(this, data, offsetSamples);
	}

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
	{
		return Create(name, lengthSamples, channels, frequency, stream);
	}

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback)
	{
		return Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
	}

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback)
	{
		return Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, pcmsetpositioncallback);
	}

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream)
	{
		return Create(name, lengthSamples, channels, frequency, stream, null, null);
	}

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback)
	{
		return Create(name, lengthSamples, channels, frequency, stream, pcmreadercallback, null);
	}

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback)
	{
		if (name == null)
		{
			throw new Il2CppSystem.NullReferenceException();
		}
		if (lengthSamples <= 0)
		{
			throw new Il2CppSystem.ArgumentException("Length of created clip must be larger than 0");
		}
		if (channels <= 0)
		{
			throw new Il2CppSystem.ArgumentException("Number of channels in created clip must be greater than 0");
		}
		if (frequency <= 0)
		{
			throw new Il2CppSystem.ArgumentException("Frequency in created clip must be greater than 0");
		}
		AudioClip audioClip = Construct_Internal();
		if ((object)pcmreadercallback != null)
		{
			audioClip.add_m_PCMReaderCallback(pcmreadercallback);
		}
		if ((object)pcmsetpositioncallback != null)
		{
			audioClip.add_m_PCMSetPositionCallback(pcmsetpositioncallback);
		}
		audioClip.CreateUserSound(name, lengthSamples, channels, frequency, stream);
		return audioClip;
	}

	[SpecialName]
	public void add_m_PCMReaderCallback(PCMReaderCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_m_PCMReaderCallback(PCMReaderCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_m_PCMSetPositionCallback(PCMSetPositionCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_m_PCMSetPositionCallback(PCMSetPositionCallback value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static bool GetData_Injected(System.IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset)
	{
		return GetData_InjectedDelegateField(clip, (nint)Unsafe.AsPointer(ref data), samplesOffset);
	}

	public unsafe static bool SetData_Injected(System.IntPtr clip, ref ManagedSpanWrapper data, int samplesOffset)
	{
		return SetData_InjectedDelegateField(clip, (nint)Unsafe.AsPointer(ref data), samplesOffset);
	}

	public static System.IntPtr Construct_Internal_Injected()
	{
		return Construct_Internal_InjectedDelegateField();
	}

	public new unsafe static void GetName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		GetName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CreateUserSound_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, int lengthSamples, int channels, int frequency, bool stream)
	{
		CreateUserSound_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name), lengthSamples, channels, frequency, stream);
	}

	public static int get_channels_Injected(System.IntPtr _unity_self)
	{
		return get_channels_InjectedDelegateField(_unity_self);
	}

	public static bool get_isReadyToPlay_Injected(System.IntPtr _unity_self)
	{
		return get_isReadyToPlay_InjectedDelegateField(_unity_self);
	}

	public static AudioClipLoadType get_loadType_Injected(System.IntPtr _unity_self)
	{
		return get_loadType_InjectedDelegateField(_unity_self);
	}

	public static bool get_ambisonic_Injected(System.IntPtr _unity_self)
	{
		return get_ambisonic_InjectedDelegateField(_unity_self);
	}

	public static bool get_loadInBackground_Injected(System.IntPtr _unity_self)
	{
		return get_loadInBackground_InjectedDelegateField(_unity_self);
	}

	public static AudioDataLoadState get_loadState_Injected(System.IntPtr _unity_self)
	{
		return get_loadState_InjectedDelegateField(_unity_self);
	}
}
