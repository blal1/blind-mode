using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech;

public sealed class DictationRecognizer : Il2CppSystem.Object
{
	public sealed class DictationHypothesisDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

		static DictationHypothesisDelegate()
		{
			Il2CppClassPointerStore<DictationHypothesisDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesisDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationHypothesisDelegate>.NativeClassPtr, 100667031);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationHypothesisDelegate>.NativeClassPtr, 100667032);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictationHypothesisDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationHypothesisDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DictationHypothesisDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator DictationHypothesisDelegate(System.Action<string> P_0)
		{
			return DelegateSupport.ConvertDelegate<DictationHypothesisDelegate>((System.Delegate)P_0);
		}

		public static DictationHypothesisDelegate operator +(DictationHypothesisDelegate P_0, DictationHypothesisDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<DictationHypothesisDelegate>();
		}

		public static DictationHypothesisDelegate operator -(DictationHypothesisDelegate P_0, DictationHypothesisDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<DictationHypothesisDelegate>();
			}
			return (DictationHypothesisDelegate)obj;
		}
	}

	public sealed class DictationResultDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0;

		static DictationResultDelegate()
		{
			Il2CppClassPointerStore<DictationResultDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResultDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationResultDelegate>.NativeClassPtr, 100667033);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationResultDelegate>.NativeClassPtr, 100667034);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 576610, RefRangeEnd = 576618, XrefRangeStart = 576610, XrefRangeEnd = 576618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictationResultDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationResultDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(string text, ConfidenceLevel confidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			*(ConfidenceLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DictationResultDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator DictationResultDelegate(System.Action<string, ConfidenceLevel> P_0)
		{
			return DelegateSupport.ConvertDelegate<DictationResultDelegate>((System.Delegate)P_0);
		}

		public static DictationResultDelegate operator +(DictationResultDelegate P_0, DictationResultDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<DictationResultDelegate>();
		}

		public static DictationResultDelegate operator -(DictationResultDelegate P_0, DictationResultDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<DictationResultDelegate>();
			}
			return (DictationResultDelegate)obj;
		}
	}

	public sealed class DictationCompletedDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0;

		static DictationCompletedDelegate()
		{
			Il2CppClassPointerStore<DictationCompletedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationCompletedDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationCompletedDelegate>.NativeClassPtr, 100667035);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationCompletedDelegate>.NativeClassPtr, 100667036);
		}

		[CallerCount(392)]
		[CachedScanResults(RefRangeStart = 354265, RefRangeEnd = 354657, XrefRangeStart = 354265, XrefRangeEnd = 354657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictationCompletedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationCompletedDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(DictationCompletionCause cause)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&cause);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DictationCompletedDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator DictationCompletedDelegate(System.Action<DictationCompletionCause> P_0)
		{
			return DelegateSupport.ConvertDelegate<DictationCompletedDelegate>((System.Delegate)P_0);
		}

		public static DictationCompletedDelegate operator +(DictationCompletedDelegate P_0, DictationCompletedDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<DictationCompletedDelegate>();
		}

		public static DictationCompletedDelegate operator -(DictationCompletedDelegate P_0, DictationCompletedDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<DictationCompletedDelegate>();
			}
			return (DictationCompletedDelegate)obj;
		}
	}

	public sealed class DictationErrorHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0;

		static DictationErrorHandler()
		{
			Il2CppClassPointerStore<DictationErrorHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationErrorHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationErrorHandler>.NativeClassPtr, 100667037);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationErrorHandler>.NativeClassPtr, 100667038);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 576610, RefRangeEnd = 576618, XrefRangeStart = 576610, XrefRangeEnd = 576618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictationErrorHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictationErrorHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(string error, int hresult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hresult;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DictationErrorHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator DictationErrorHandler(System.Action<string, int> P_0)
		{
			return DelegateSupport.ConvertDelegate<DictationErrorHandler>((System.Delegate)P_0);
		}

		public static DictationErrorHandler operator +(DictationErrorHandler P_0, DictationErrorHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<DictationErrorHandler>();
		}

		public static DictationErrorHandler operator -(DictationErrorHandler P_0, DictationErrorHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<DictationErrorHandler>();
			}
			return (DictationErrorHandler)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Recognizer;

	private static readonly System.IntPtr NativeFieldInfoPtr_DictationHypothesis;

	private static readonly System.IntPtr NativeFieldInfoPtr_DictationResult;

	private static readonly System.IntPtr NativeFieldInfoPtr_DictationComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_DictationError;

	private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0;

	public unsafe System.IntPtr m_Recognizer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Recognizer);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Recognizer)) = value;
		}
	}

	public unsafe DictationHypothesisDelegate DictationHypothesis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationHypothesis);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DictationHypothesisDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationHypothesis)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DictationResultDelegate DictationResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationResult);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DictationResultDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationResult)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DictationCompletedDelegate DictationComplete
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationComplete);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DictationCompletedDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationComplete)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DictationErrorHandler DictationError
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationError);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DictationErrorHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DictationError)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DictationRecognizer()
	{
		Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "DictationRecognizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "m_Recognizer");
		NativeFieldInfoPtr_DictationHypothesis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationHypothesis");
		NativeFieldInfoPtr_DictationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationResult");
		NativeFieldInfoPtr_DictationComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationComplete");
		NativeFieldInfoPtr_DictationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, "DictationError");
		NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667027);
		NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667028);
		NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667029);
		NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictationRecognizer>.NativeClassPtr, 100667030);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222262, XrefRangeEnd = 1222264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DictationRecognizer_InvokeHypothesisGeneratedEvent(System.IntPtr keyword, int keywordLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&keyword);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keywordLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DictationRecognizer_InvokeHypothesisGeneratedEvent_Private_Void_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222264, XrefRangeEnd = 1222266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DictationRecognizer_InvokeResultGeneratedEvent(System.IntPtr keyword, int keywordLength, ConfidenceLevel minimumConfidence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&keyword);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &keywordLength;
		*(ConfidenceLevel**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &minimumConfidence;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DictationRecognizer_InvokeResultGeneratedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void DictationRecognizer_InvokeCompletedEvent(DictationCompletionCause cause)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cause);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DictationRecognizer_InvokeCompletedEvent_Private_Void_DictationCompletionCause_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void DictationRecognizer_InvokeErrorEvent(string error, int hresult)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hresult;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DictationRecognizer_InvokeErrorEvent_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DictationRecognizer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
