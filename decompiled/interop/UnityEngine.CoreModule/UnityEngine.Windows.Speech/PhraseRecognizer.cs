using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech;

public class PhraseRecognizer : Il2CppSystem.Object
{
	public sealed class PhraseRecognizedDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0;

		static PhraseRecognizedDelegate()
		{
			Il2CppClassPointerStore<PhraseRecognizedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "PhraseRecognizedDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedDelegate>.NativeClassPtr, 100667025);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedDelegate>.NativeClassPtr, 100667026);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 856722, RefRangeEnd = 856723, XrefRangeStart = 856722, XrefRangeEnd = 856723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhraseRecognizedDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhraseRecognizedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhraseRecognizedEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PhraseRecognizedDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator PhraseRecognizedDelegate(System.Action<PhraseRecognizedEventArgs> P_0)
		{
			return DelegateSupport.ConvertDelegate<PhraseRecognizedDelegate>((System.Delegate)P_0);
		}

		public static PhraseRecognizedDelegate operator +(PhraseRecognizedDelegate P_0, PhraseRecognizedDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<PhraseRecognizedDelegate>();
		}

		public static PhraseRecognizedDelegate operator -(PhraseRecognizedDelegate P_0, PhraseRecognizedDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PhraseRecognizedDelegate>();
			}
			return (PhraseRecognizedDelegate)obj;
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Recognizer;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnPhraseRecognized;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0;

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

	public unsafe PhraseRecognizedDelegate OnPhraseRecognized
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPhraseRecognized);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PhraseRecognizedDelegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnPhraseRecognized)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PhraseRecognizer()
	{
		Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Recognizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "m_Recognizer");
		NativeFieldInfoPtr_OnPhraseRecognized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, "OnPhraseRecognized");
		NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100667023);
		NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizer>.NativeClassPtr, 100667024);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222234, XrefRangeEnd = 1222246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokePhraseRecognizedEvent(System.IntPtr rawText, int rawTextLength, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, long phraseStartFileTime, long phraseDurationTicks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&rawText);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rawTextLength;
		*(ConfidenceLevel**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)semanticMeanings);
		*(long**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &phraseStartFileTime;
		*(long**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &phraseDurationTicks;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokePhraseRecognizedEvent_Private_Void_IntPtr_Int32_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222246, XrefRangeEnd = 1222262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<SemanticMeaning> MarshalSemanticMeaning(System.IntPtr keys, System.IntPtr values, System.IntPtr valueSizes, int valueCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&keys);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &values;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &valueSizes;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valueCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalSemanticMeaning_Private_Static_Il2CppReferenceArray_1_SemanticMeaning_IntPtr_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr2) : null;
	}

	public PhraseRecognizer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
