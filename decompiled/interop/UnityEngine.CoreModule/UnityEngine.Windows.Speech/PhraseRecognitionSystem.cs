using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech;

public static class PhraseRecognitionSystem : Il2CppSystem.Object
{
	public sealed class ErrorDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0;

		static ErrorDelegate()
		{
			Il2CppClassPointerStore<ErrorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "ErrorDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorDelegate>.NativeClassPtr, 100667019);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorDelegate>.NativeClassPtr, 100667020);
		}

		[CallerCount(392)]
		[CachedScanResults(RefRangeStart = 354265, RefRangeEnd = 354657, XrefRangeStart = 354265, XrefRangeEnd = 354657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ErrorDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(SpeechError errorCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&errorCode);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ErrorDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator ErrorDelegate(System.Action<SpeechError> P_0)
		{
			return DelegateSupport.ConvertDelegate<ErrorDelegate>((System.Delegate)P_0);
		}

		public static ErrorDelegate operator +(ErrorDelegate P_0, ErrorDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ErrorDelegate>();
		}

		public static ErrorDelegate operator -(ErrorDelegate P_0, ErrorDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ErrorDelegate>();
			}
			return (ErrorDelegate)obj;
		}
	}

	public sealed class StatusDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0;

		static StatusDelegate()
		{
			Il2CppClassPointerStore<StatusDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "StatusDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusDelegate>.NativeClassPtr, 100667021);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatusDelegate>.NativeClassPtr, 100667022);
		}

		[CallerCount(392)]
		[CachedScanResults(RefRangeStart = 354265, RefRangeEnd = 354657, XrefRangeStart = 354265, XrefRangeEnd = 354657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatusDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(SpeechSystemStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&status);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StatusDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator StatusDelegate(System.Action<SpeechSystemStatus> P_0)
		{
			return DelegateSupport.ConvertDelegate<StatusDelegate>((System.Delegate)P_0);
		}

		public static StatusDelegate operator +(StatusDelegate P_0, StatusDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<StatusDelegate>();
		}

		public static StatusDelegate operator -(StatusDelegate P_0, StatusDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<StatusDelegate>();
			}
			return (StatusDelegate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_OnError;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnStatusChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0;

	public unsafe static ErrorDelegate OnError
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnError, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ErrorDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnError, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static StatusDelegate OnStatusChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OnStatusChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StatusDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OnStatusChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PhraseRecognitionSystem()
	{
		Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognitionSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr);
		NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnError");
		NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnStatusChanged");
		NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100667017);
		NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100667018);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222230, XrefRangeEnd = 1222232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&errorCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222232, XrefRangeEnd = 1222234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&status);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PhraseRecognitionSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
