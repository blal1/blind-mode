using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public static class TimeUtility : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("UnityEngine.Timeline.TimeUtility+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__19_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__19_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseTimeCode_b__19_0_Internal_Boolean_Char_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseTimeCode_b__19_1_Internal_Boolean_Char_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ParseTimeSeconds_b__20_0_Internal_Boolean_Char_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<char, bool> __9__19_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<char, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__19_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<char, bool> __9__19_1
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<char, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__19_1, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Func<char, bool> __9__20_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<char, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__19_0");
			NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__19_1");
			NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664195);
			NativeMethodInfoPtr__ParseTimeCode_b__19_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664196);
			NativeMethodInfoPtr__ParseTimeCode_b__19_1_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664197);
			NativeMethodInfoPtr__ParseTimeSeconds_b__20_0_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664198);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142287, XrefRangeEnd = 1142290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ParseTimeCode_b__19_0(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseTimeCode_b__19_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe bool _ParseTimeCode_b__19_1(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseTimeCode_b__19_1_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ParseTimeSeconds_b__20_0(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&c);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ParseTimeSeconds_b__20_0_Internal_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kTimeEpsilon;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFrameRateEpsilon;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds;

	private static readonly System.IntPtr NativeFieldInfoPtr_kFrameRateRounding;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateFrameRate_Private_Static_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFrames_Public_Static_Int32_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToExactFrames_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromFrames_Public_Static_Double_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromFrames_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEpsilon_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousFrame_Public_Static_Int32_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextFrame_Public_Static_Int32_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousFrameTime_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextFrameTime_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundToFrame_Public_Static_Double_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeAsFrames_Public_Static_String_Double_Double_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TimeAsTimeCode_Public_Static_String_Double_Double_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeCode_Public_Static_Double_String_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ParseTimeSeconds_Public_Static_Double_String_Double_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimationClipLength_Public_Static_Double_AnimationClip_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveChar_Private_Static_String_String_Func_2_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestFrameRate_Public_Static_FrameRate_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFrameRate_Public_Static_FrameRate_StandardFrameRates_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToStandardFrameRate_Internal_Static_Boolean_FrameRate_byref_StandardFrameRates_0;

	public unsafe static double kTimeEpsilon
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kTimeEpsilon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kTimeEpsilon, (void*)(&value));
		}
	}

	public unsafe static double kFrameRateEpsilon
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFrameRateEpsilon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFrameRateEpsilon, (void*)(&value));
		}
	}

	public unsafe static double k_MaxTimelineDurationInSeconds
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds, (void*)(&value));
		}
	}

	public unsafe static double kFrameRateRounding
	{
		get
		{
			Unsafe.SkipInit(out double result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kFrameRateRounding, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kFrameRateRounding, (void*)(&value));
		}
	}

	static TimeUtility()
	{
		Il2CppClassPointerStore<TimeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "TimeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr);
		NativeFieldInfoPtr_kTimeEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "kTimeEpsilon");
		NativeFieldInfoPtr_kFrameRateEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "kFrameRateEpsilon");
		NativeFieldInfoPtr_k_MaxTimelineDurationInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "k_MaxTimelineDurationInSeconds");
		NativeFieldInfoPtr_kFrameRateRounding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, "kFrameRateRounding");
		NativeMethodInfoPtr_ValidateFrameRate_Private_Static_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664171);
		NativeMethodInfoPtr_ToFrames_Public_Static_Int32_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664172);
		NativeMethodInfoPtr_ToExactFrames_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664173);
		NativeMethodInfoPtr_FromFrames_Public_Static_Double_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664174);
		NativeMethodInfoPtr_FromFrames_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664175);
		NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664176);
		NativeMethodInfoPtr_GetEpsilon_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664177);
		NativeMethodInfoPtr_PreviousFrame_Public_Static_Int32_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664178);
		NativeMethodInfoPtr_NextFrame_Public_Static_Int32_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664179);
		NativeMethodInfoPtr_PreviousFrameTime_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664180);
		NativeMethodInfoPtr_NextFrameTime_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664181);
		NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664182);
		NativeMethodInfoPtr_RoundToFrame_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664183);
		NativeMethodInfoPtr_TimeAsFrames_Public_Static_String_Double_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664184);
		NativeMethodInfoPtr_TimeAsTimeCode_Public_Static_String_Double_Double_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664185);
		NativeMethodInfoPtr_ParseTimeCode_Public_Static_Double_String_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664186);
		NativeMethodInfoPtr_ParseTimeSeconds_Public_Static_Double_String_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664187);
		NativeMethodInfoPtr_GetAnimationClipLength_Public_Static_Double_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664188);
		NativeMethodInfoPtr_RemoveChar_Private_Static_String_String_Func_2_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664189);
		NativeMethodInfoPtr_GetClosestFrameRate_Public_Static_FrameRate_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664190);
		NativeMethodInfoPtr_ToFrameRate_Public_Static_FrameRate_StandardFrameRates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664191);
		NativeMethodInfoPtr_ToStandardFrameRate_Internal_Static_Boolean_FrameRate_byref_StandardFrameRates_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtility>.NativeClassPtr, 100664192);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1142294, RefRangeEnd = 1142309, XrefRangeStart = 1142290, XrefRangeEnd = 1142294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateFrameRate(double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateFrameRate_Private_Static_Void_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1142327, RefRangeEnd = 1142333, XrefRangeStart = 1142309, XrefRangeEnd = 1142327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToFrames(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFrames_Public_Static_Int32_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142333, XrefRangeEnd = 1142337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToExactFrames(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToExactFrames_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142337, XrefRangeEnd = 1142341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double FromFrames(int frames, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frames);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromFrames_Public_Static_Double_Int32_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142341, XrefRangeEnd = 1142345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double FromFrames(double frames, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&frames);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromFrames_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1142367, RefRangeEnd = 1142369, XrefRangeStart = 1142345, XrefRangeEnd = 1142367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OnFrameBoundary(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1142377, RefRangeEnd = 1142379, XrefRangeStart = 1142369, XrefRangeEnd = 1142377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double GetEpsilon(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEpsilon_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142379, XrefRangeEnd = 1142387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PreviousFrame(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousFrame_Public_Static_Int32_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142387, XrefRangeEnd = 1142391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NextFrame(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextFrame_Public_Static_Int32_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142391, XrefRangeEnd = 1142406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double PreviousFrameTime(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousFrameTime_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142406, XrefRangeEnd = 1142417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double NextFrameTime(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextFrameTime_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142417, XrefRangeEnd = 1142435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OnFrameBoundary(double time, double frameRate, double epsilon)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &epsilon;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFrameBoundary_Public_Static_Boolean_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142435, XrefRangeEnd = 1142444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double RoundToFrame(double time, double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundToFrame_Public_Static_Double_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142444, XrefRangeEnd = 1142455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TimeAsFrames(double timeValue, double frameRate, string format = "F2")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&timeValue);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeAsFrames_Public_Static_String_Double_Double_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142455, XrefRangeEnd = 1142519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2")
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&timeValue);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TimeAsTimeCode_Public_Static_String_Double_Double_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142519, XrefRangeEnd = 1142586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ParseTimeCode(string timeCode, double frameRate, double defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(timeCode);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeCode_Public_Static_Double_String_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142586, XrefRangeEnd = 1142627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ParseTimeSeconds(string timeCode, double frameRate, double defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(timeCode);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frameRate;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseTimeSeconds_Public_Static_Double_String_Double_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1142643, RefRangeEnd = 1142646, XrefRangeStart = 1142627, XrefRangeEnd = 1142643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double GetAnimationClipLength(AnimationClip clip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)clip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAnimationClipLength_Public_Static_Double_AnimationClip_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1142648, RefRangeEnd = 1142649, XrefRangeStart = 1142646, XrefRangeEnd = 1142648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string RemoveChar(string str, Il2CppSystem.Func<char, bool> charToRemoveFunc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)charToRemoveFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveChar_Private_Static_String_String_Func_2_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142649, XrefRangeEnd = 1142662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FrameRate GetClosestFrameRate(double frameRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frameRate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClosestFrameRate_Public_Static_FrameRate_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FrameRate*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1142666, RefRangeEnd = 1142667, XrefRangeStart = 1142662, XrefRangeEnd = 1142666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FrameRate ToFrameRate(StandardFrameRates enumValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enumValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFrameRate_Public_Static_FrameRate_StandardFrameRates_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FrameRate*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142667, XrefRangeEnd = 1142709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ToStandardFrameRate(FrameRate rate, out StandardFrameRates standard)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rate);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref standard);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToStandardFrameRate_Internal_Static_Boolean_FrameRate_byref_StandardFrameRates_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TimeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
