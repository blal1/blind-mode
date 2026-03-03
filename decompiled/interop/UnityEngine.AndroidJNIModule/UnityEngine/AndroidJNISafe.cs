using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class AndroidJNISafe : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CheckException_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueDeleteGlobalRef_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushLocalFrame_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;

	static AndroidJNISafe()
	{
		Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNISafe");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr);
		NativeMethodInfoPtr_CheckException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_QueueDeleteGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_PushLocalFrame_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663560);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 1151103, RefRangeEnd = 1151206, XrefRangeStart = 1151099, XrefRangeEnd = 1151103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckException_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151206, XrefRangeEnd = 1151208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueDeleteGlobalRef(System.IntPtr globalref)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&globalref);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueDeleteGlobalRef_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151208, XrefRangeEnd = 1151210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteWeakGlobalRef(System.IntPtr globalref)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&globalref);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151212, RefRangeEnd = 1151214, XrefRangeStart = 1151210, XrefRangeEnd = 1151212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteLocalRef(System.IntPtr localref)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&localref);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1151218, RefRangeEnd = 1151223, XrefRangeStart = 1151214, XrefRangeEnd = 1151218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewString(string chars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151227, RefRangeEnd = 1151228, XrefRangeStart = 1151223, XrefRangeEnd = 1151227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetStringChars(System.IntPtr str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151228, XrefRangeEnd = 1151233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetObjectClass(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1151237, RefRangeEnd = 1151240, XrefRangeStart = 1151233, XrefRangeEnd = 1151237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetStaticMethodID(System.IntPtr clazz, string name, string sig)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sig);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1151244, RefRangeEnd = 1151247, XrefRangeStart = 1151240, XrefRangeEnd = 1151244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(System.IntPtr obj, string name, string sig)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sig);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151252, RefRangeEnd = 1151254, XrefRangeStart = 1151247, XrefRangeEnd = 1151252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FromReflectedMethod(System.IntPtr refMethod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&refMethod);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1151258, RefRangeEnd = 1151267, XrefRangeStart = 1151254, XrefRangeEnd = 1151258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindClass(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1151270, RefRangeEnd = 1151275, XrefRangeStart = 1151267, XrefRangeEnd = 1151270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PushLocalFrame(int capacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushLocalFrame_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151283, RefRangeEnd = 1151284, XrefRangeStart = 1151275, XrefRangeEnd = 1151283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151284, XrefRangeEnd = 1151287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1151295, RefRangeEnd = 1151309, XrefRangeStart = 1151287, XrefRangeEnd = 1151295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151316, RefRangeEnd = 1151318, XrefRangeStart = 1151309, XrefRangeEnd = 1151316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151326, RefRangeEnd = 1151328, XrefRangeStart = 1151318, XrefRangeEnd = 1151326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151336, RefRangeEnd = 1151338, XrefRangeStart = 1151328, XrefRangeEnd = 1151336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151346, RefRangeEnd = 1151348, XrefRangeStart = 1151338, XrefRangeEnd = 1151346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151356, RefRangeEnd = 1151358, XrefRangeStart = 1151348, XrefRangeEnd = 1151356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151366, RefRangeEnd = 1151368, XrefRangeStart = 1151358, XrefRangeEnd = 1151366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1151376, RefRangeEnd = 1151380, XrefRangeStart = 1151368, XrefRangeEnd = 1151376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151388, RefRangeEnd = 1151390, XrefRangeStart = 1151380, XrefRangeEnd = 1151388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1151398, RefRangeEnd = 1151401, XrefRangeStart = 1151390, XrefRangeEnd = 1151398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151409, RefRangeEnd = 1151410, XrefRangeStart = 1151401, XrefRangeEnd = 1151409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1151418, RefRangeEnd = 1151421, XrefRangeStart = 1151410, XrefRangeEnd = 1151418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151428, RefRangeEnd = 1151429, XrefRangeStart = 1151421, XrefRangeEnd = 1151428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151437, RefRangeEnd = 1151438, XrefRangeStart = 1151429, XrefRangeEnd = 1151437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151446, RefRangeEnd = 1151447, XrefRangeStart = 1151438, XrefRangeEnd = 1151446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151455, RefRangeEnd = 1151456, XrefRangeStart = 1151447, XrefRangeEnd = 1151455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151464, RefRangeEnd = 1151465, XrefRangeStart = 1151456, XrefRangeEnd = 1151464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151473, RefRangeEnd = 1151474, XrefRangeStart = 1151465, XrefRangeEnd = 1151473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151482, RefRangeEnd = 1151484, XrefRangeStart = 1151474, XrefRangeEnd = 1151482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151492, RefRangeEnd = 1151493, XrefRangeStart = 1151484, XrefRangeEnd = 1151492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151501, RefRangeEnd = 1151502, XrefRangeStart = 1151493, XrefRangeEnd = 1151501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151502, XrefRangeEnd = 1151507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<char> FromCharArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151507, XrefRangeEnd = 1151512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<double> FromDoubleArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151512, XrefRangeEnd = 1151517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<float> FromFloatArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151517, XrefRangeEnd = 1151522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<long> FromLongArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151522, XrefRangeEnd = 1151527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<short> FromShortArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151527, XrefRangeEnd = 1151531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> FromByteArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151531, XrefRangeEnd = 1151536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<sbyte> FromSByteArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151536, XrefRangeEnd = 1151540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<bool> FromBooleanArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151540, XrefRangeEnd = 1151545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> FromIntArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151550, RefRangeEnd = 1151552, XrefRangeStart = 1151545, XrefRangeEnd = 1151550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToObjectArray(Il2CppStructArray<System.IntPtr> array, System.IntPtr type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151557, RefRangeEnd = 1151558, XrefRangeStart = 1151552, XrefRangeEnd = 1151557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToCharArray(Il2CppStructArray<char> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151563, RefRangeEnd = 1151564, XrefRangeStart = 1151558, XrefRangeEnd = 1151563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToDoubleArray(Il2CppStructArray<double> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151569, RefRangeEnd = 1151570, XrefRangeStart = 1151564, XrefRangeEnd = 1151569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToFloatArray(Il2CppStructArray<float> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151575, RefRangeEnd = 1151576, XrefRangeStart = 1151570, XrefRangeEnd = 1151575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToLongArray(Il2CppStructArray<long> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151581, RefRangeEnd = 1151582, XrefRangeStart = 1151576, XrefRangeEnd = 1151581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToShortArray(Il2CppStructArray<short> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151594, RefRangeEnd = 1151595, XrefRangeStart = 1151582, XrefRangeEnd = 1151594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToByteArray(Il2CppStructArray<byte> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151600, RefRangeEnd = 1151601, XrefRangeStart = 1151595, XrefRangeEnd = 1151600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151612, RefRangeEnd = 1151613, XrefRangeStart = 1151601, XrefRangeEnd = 1151612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151618, RefRangeEnd = 1151619, XrefRangeStart = 1151613, XrefRangeEnd = 1151618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToIntArray(Il2CppStructArray<int> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151624, RefRangeEnd = 1151626, XrefRangeStart = 1151619, XrefRangeEnd = 1151624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetObjectArrayElement(System.IntPtr array, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1151631, RefRangeEnd = 1151635, XrefRangeStart = 1151626, XrefRangeEnd = 1151631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetArrayLength(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AndroidJNISafe(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void DeleteGlobalRef(System.IntPtr globalref)
	{
		if (globalref != Il2CppSystem.IntPtr.Zero)
		{
			AndroidJNI.DeleteGlobalRef(globalref);
		}
	}

	public static System.IntPtr NewStringUTF(string bytes)
	{
		try
		{
			return AndroidJNI.NewStringUTF(bytes);
		}
		finally
		{
			CheckException();
		}
	}

	public static string GetStringUTFChars(System.IntPtr str)
	{
		try
		{
			return AndroidJNI.GetStringUTFChars(str);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr GetFieldID(System.IntPtr clazz, string name, string sig)
	{
		try
		{
			return AndroidJNI.GetFieldID(clazz, name, sig);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr GetStaticFieldID(System.IntPtr clazz, string name, string sig)
	{
		try
		{
			return AndroidJNI.GetStaticFieldID(clazz, name, sig);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr FromReflectedField(System.IntPtr refField)
	{
		try
		{
			return AndroidJNI.FromReflectedField(refField);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return NewObject(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static void SetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID, System.IntPtr val)
	{
		try
		{
			AndroidJNI.SetStaticObjectField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID, string val)
	{
		try
		{
			AndroidJNI.SetStaticStringField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID, char val)
	{
		try
		{
			AndroidJNI.SetStaticCharField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID, double val)
	{
		try
		{
			AndroidJNI.SetStaticDoubleField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID, float val)
	{
		try
		{
			AndroidJNI.SetStaticFloatField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID, long val)
	{
		try
		{
			AndroidJNI.SetStaticLongField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID, short val)
	{
		try
		{
			AndroidJNI.SetStaticShortField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID, sbyte val)
	{
		try
		{
			AndroidJNI.SetStaticSByteField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID, bool val)
	{
		try
		{
			AndroidJNI.SetStaticBooleanField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID, int val)
	{
		try
		{
			AndroidJNI.SetStaticIntField(clazz, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticObjectField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static string GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticStringField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticCharField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticDoubleField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static float GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticFloatField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static long GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticLongField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static short GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticShortField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static sbyte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticSByteField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static bool GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticBooleanField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static int GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStaticIntField(clazz, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		CallStaticVoidMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		try
		{
			AndroidJNI.CallStaticVoidMethod(clazz, methodID, args);
		}
		finally
		{
			CheckException();
		}
	}

	public static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticStringMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticCharMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticDoubleMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticFloatMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticLongMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticShortMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticSByteMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticBooleanMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticIntMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static void SetObjectField(System.IntPtr obj, System.IntPtr fieldID, System.IntPtr val)
	{
		try
		{
			AndroidJNI.SetObjectField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetStringField(System.IntPtr obj, System.IntPtr fieldID, string val)
	{
		try
		{
			AndroidJNI.SetStringField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetCharField(System.IntPtr obj, System.IntPtr fieldID, char val)
	{
		try
		{
			AndroidJNI.SetCharField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetDoubleField(System.IntPtr obj, System.IntPtr fieldID, double val)
	{
		try
		{
			AndroidJNI.SetDoubleField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetFloatField(System.IntPtr obj, System.IntPtr fieldID, float val)
	{
		try
		{
			AndroidJNI.SetFloatField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetLongField(System.IntPtr obj, System.IntPtr fieldID, long val)
	{
		try
		{
			AndroidJNI.SetLongField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetShortField(System.IntPtr obj, System.IntPtr fieldID, short val)
	{
		try
		{
			AndroidJNI.SetShortField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetSByteField(System.IntPtr obj, System.IntPtr fieldID, sbyte val)
	{
		try
		{
			AndroidJNI.SetSByteField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetBooleanField(System.IntPtr obj, System.IntPtr fieldID, bool val)
	{
		try
		{
			AndroidJNI.SetBooleanField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static void SetIntField(System.IntPtr obj, System.IntPtr fieldID, int val)
	{
		try
		{
			AndroidJNI.SetIntField(obj, fieldID, val);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetObjectField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static string GetStringField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetStringField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static char GetCharField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetCharField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetDoubleField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static float GetFloatField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetFloatField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static long GetLongField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetLongField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static short GetShortField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetShortField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static sbyte GetSByteField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetSByteField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static bool GetBooleanField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetBooleanField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static int GetIntField(System.IntPtr obj, System.IntPtr fieldID)
	{
		try
		{
			return AndroidJNI.GetIntField(obj, fieldID);
		}
		finally
		{
			CheckException();
		}
	}

	public static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		CallVoidMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallObjectMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStringMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallCharMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallDoubleMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallFloatMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallLongMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallShortMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallSByteMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallBooleanMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallIntMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static Il2CppStructArray<System.IntPtr> FromObjectArray(System.IntPtr array)
	{
		try
		{
			return AndroidJNI.FromObjectArray(array);
		}
		finally
		{
			CheckException();
		}
	}

	public static System.IntPtr ToObjectArray(Il2CppStructArray<System.IntPtr> array)
	{
		try
		{
			return AndroidJNI.ToObjectArray(array);
		}
		finally
		{
			CheckException();
		}
	}
}
