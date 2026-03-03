using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech;

public sealed class PhraseRecognizedEventArgs : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_confidence;

	private static readonly System.IntPtr NativeFieldInfoPtr_semanticMeanings;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_phraseStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_phraseDuration;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0;

	public unsafe ConfidenceLevel confidence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confidence);
			return *(ConfidenceLevel*)num;
		}
		set
		{
			*(ConfidenceLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_confidence)) = value;
		}
	}

	public unsafe Il2CppReferenceArray<SemanticMeaning> semanticMeanings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_semanticMeanings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SemanticMeaning>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_semanticMeanings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppSystem.DateTime phraseStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phraseStartTime);
			return *(Il2CppSystem.DateTime*)num;
		}
		set
		{
			*(Il2CppSystem.DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phraseStartTime)) = value;
		}
	}

	public unsafe Il2CppSystem.TimeSpan phraseDuration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phraseDuration);
			return *(Il2CppSystem.TimeSpan*)num;
		}
		set
		{
			*(Il2CppSystem.TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_phraseDuration)) = value;
		}
	}

	static PhraseRecognizedEventArgs()
	{
		Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognizedEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr_confidence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "confidence");
		NativeFieldInfoPtr_semanticMeanings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "semanticMeanings");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "text");
		NativeFieldInfoPtr_phraseStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseStartTime");
		NativeFieldInfoPtr_phraseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, "phraseDuration");
		NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr, 100667039);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1222266, XrefRangeEnd = 1222268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PhraseRecognizedEventArgs(string text, ConfidenceLevel confidence, Il2CppReferenceArray<SemanticMeaning> semanticMeanings, Il2CppSystem.DateTime phraseStartTime, Il2CppSystem.TimeSpan phraseDuration)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(ConfidenceLevel**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &confidence;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)semanticMeanings);
		*(Il2CppSystem.DateTime**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &phraseStartTime;
		*(Il2CppSystem.TimeSpan**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &phraseDuration;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_ConfidenceLevel_Il2CppReferenceArray_1_SemanticMeaning_DateTime_TimeSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PhraseRecognizedEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PhraseRecognizedEventArgs()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognizedEventArgs>.NativeClassPtr))
	{
	}
}
