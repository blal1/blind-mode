using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class AndroidJNI : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct JStringBinding
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_javaString;

		private static readonly System.IntPtr NativeFieldInfoPtr_chars;

		private static readonly System.IntPtr NativeFieldInfoPtr_length;

		private static readonly System.IntPtr NativeFieldInfoPtr_ownsRef;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		[FieldOffset(0)]
		public System.IntPtr javaString;

		[FieldOffset(8)]
		public System.IntPtr chars;

		[FieldOffset(16)]
		public int length;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.U1)]
		public bool ownsRef;

		static JStringBinding()
		{
			Il2CppClassPointerStore<JStringBinding>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, "JStringBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr);
			NativeFieldInfoPtr_javaString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, "javaString");
			NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, "chars");
			NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, "length");
			NativeFieldInfoPtr_ownsRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, "ownsRef");
			NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, 100663503);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, 100663504);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150605, XrefRangeEnd = 1150607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150607, XrefRangeEnd = 1150609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JStringBinding>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate System.IntPtr GetJavaVMDelegate();

	private delegate int AttachCurrentThreadDelegate();

	private delegate int DetachCurrentThreadDelegate();

	private delegate void InvokeAttachedDelegate(System.IntPtr action);

	private delegate int GetVersionDelegate();

	private delegate System.IntPtr FromReflectedFieldDelegate(System.IntPtr refField);

	private delegate System.IntPtr ToReflectedMethodDelegate(System.IntPtr clazz, System.IntPtr methodID, bool isStatic);

	private delegate System.IntPtr ToReflectedFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, bool isStatic);

	private delegate System.IntPtr GetSuperclassDelegate(System.IntPtr clazz);

	private delegate bool IsAssignableFromDelegate(System.IntPtr clazz1, System.IntPtr clazz2);

	private delegate int ThrowDelegate(System.IntPtr obj);

	private delegate void ExceptionDescribeDelegate();

	private delegate void DeleteGlobalRefDelegate(System.IntPtr obj);

	private delegate uint GetQueueGlobalRefsCountDelegate();

	private delegate void CleanQueueGlobalRefsDelegate();

	private delegate int EnsureLocalCapacityDelegate(int capacity);

	private delegate System.IntPtr AllocObjectDelegate(System.IntPtr clazz);

	private delegate bool IsInstanceOfDelegate(System.IntPtr obj, System.IntPtr clazz);

	private delegate int GetStringLengthDelegate(System.IntPtr str);

	private delegate int GetStringUTFLengthDelegate(System.IntPtr str);

	private delegate System.IntPtr GetObjectFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate bool GetBooleanFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate sbyte GetSByteFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate char GetCharFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate short GetShortFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate int GetIntFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate long GetLongFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate float GetFloatFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate double GetDoubleFieldDelegate(System.IntPtr obj, System.IntPtr fieldID);

	private delegate void SetObjectFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, System.IntPtr val);

	private delegate void SetBooleanFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, bool val);

	private delegate void SetSByteFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, sbyte val);

	private delegate void SetCharFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, char val);

	private delegate void SetShortFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, short val);

	private delegate void SetIntFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, int val);

	private delegate void SetLongFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, long val);

	private delegate void SetFloatFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, float val);

	private delegate void SetDoubleFieldDelegate(System.IntPtr obj, System.IntPtr fieldID, double val);

	private delegate void CallStaticVoidMethodUnsafeDelegate(System.IntPtr clazz, System.IntPtr methodID, System.IntPtr args);

	private delegate System.IntPtr GetStaticObjectFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate bool GetStaticBooleanFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate sbyte GetStaticSByteFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate char GetStaticCharFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate short GetStaticShortFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate int GetStaticIntFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate long GetStaticLongFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate float GetStaticFloatFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate double GetStaticDoubleFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID);

	private delegate void SetStaticObjectFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, System.IntPtr val);

	private delegate void SetStaticBooleanFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, bool val);

	private delegate void SetStaticSByteFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, sbyte val);

	private delegate void SetStaticCharFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, char val);

	private delegate void SetStaticShortFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, short val);

	private delegate void SetStaticIntFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, int val);

	private delegate void SetStaticLongFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, long val);

	private delegate void SetStaticFloatFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, float val);

	private delegate void SetStaticDoubleFieldDelegate(System.IntPtr clazz, System.IntPtr fieldID, double val);

	private delegate System.IntPtr NewBooleanArrayDelegate(int size);

	private delegate System.IntPtr NewSByteArrayDelegate(int size);

	private delegate System.IntPtr NewCharArrayDelegate(int size);

	private delegate System.IntPtr NewShortArrayDelegate(int size);

	private delegate System.IntPtr NewIntArrayDelegate(int size);

	private delegate System.IntPtr NewLongArrayDelegate(int size);

	private delegate System.IntPtr NewFloatArrayDelegate(int size);

	private delegate System.IntPtr NewDoubleArrayDelegate(int size);

	private delegate bool GetBooleanArrayElementDelegate(System.IntPtr array, int index);

	private delegate sbyte GetSByteArrayElementDelegate(System.IntPtr array, int index);

	private delegate char GetCharArrayElementDelegate(System.IntPtr array, int index);

	private delegate short GetShortArrayElementDelegate(System.IntPtr array, int index);

	private delegate int GetIntArrayElementDelegate(System.IntPtr array, int index);

	private delegate long GetLongArrayElementDelegate(System.IntPtr array, int index);

	private delegate float GetFloatArrayElementDelegate(System.IntPtr array, int index);

	private delegate double GetDoubleArrayElementDelegate(System.IntPtr array, int index);

	private delegate void SetBooleanArrayElementDelegate(System.IntPtr array, int index, bool val);

	private delegate void SetSByteArrayElementDelegate(System.IntPtr array, int index, sbyte val);

	private delegate void SetCharArrayElementDelegate(System.IntPtr array, int index, char val);

	private delegate void SetShortArrayElementDelegate(System.IntPtr array, int index, short val);

	private delegate void SetIntArrayElementDelegate(System.IntPtr array, int index, int val);

	private delegate void SetLongArrayElementDelegate(System.IntPtr array, int index, long val);

	private delegate void SetFloatArrayElementDelegate(System.IntPtr array, int index, float val);

	private delegate void SetDoubleArrayElementDelegate(System.IntPtr array, int index, double val);

	private delegate System.IntPtr NewDirectByteBufferDelegate(System.IntPtr buffer, long capacity);

	private delegate System.IntPtr GetDirectBufferAddressDelegate(System.IntPtr buffer);

	private delegate long GetDirectBufferCapacityDelegate(System.IntPtr buffer);

	private delegate System.IntPtr RegisterNativesAllocateDelegate(int length);

	private delegate int RegisterNativesAndFreeDelegate(System.IntPtr clazz, System.IntPtr natives, int n);

	private delegate int UnregisterNativesDelegate(System.IntPtr clazz);

	private delegate int ThrowNew_InjectedDelegate(System.IntPtr clazz, System.IntPtr message);

	private delegate void FatalError_InjectedDelegate(System.IntPtr message);

	private delegate System.IntPtr GetFieldID_InjectedDelegate(System.IntPtr clazz, System.IntPtr name, System.IntPtr sig);

	private delegate System.IntPtr GetStaticFieldID_InjectedDelegate(System.IntPtr clazz, System.IntPtr name, System.IntPtr sig);

	private delegate System.IntPtr NewString_InjectedDelegate(System.IntPtr chars);

	private delegate System.IntPtr NewStringUTF_InjectedDelegate(System.IntPtr bytes);

	private delegate void GetStringUTFChars_InjectedDelegate(System.IntPtr str, [Out] System.IntPtr ret);

	private delegate void GetStringFieldInternal_InjectedDelegate(System.IntPtr obj, System.IntPtr fieldID, [Out] System.IntPtr ret);

	private delegate void SetStringField_InjectedDelegate(System.IntPtr obj, System.IntPtr fieldID, System.IntPtr val);

	private delegate void GetStaticStringFieldInternal_InjectedDelegate(System.IntPtr clazz, System.IntPtr fieldID, [Out] System.IntPtr ret);

	private delegate void SetStaticStringField_InjectedDelegate(System.IntPtr clazz, System.IntPtr fieldID, System.IntPtr val);

	private delegate void FromObjectArray_InjectedDelegate(System.IntPtr array, [Out] System.IntPtr ret);

	private delegate void RegisterNativesSet_InjectedDelegate(System.IntPtr natives, int idx, System.IntPtr name, System.IntPtr signature, System.IntPtr fnPtr);

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseStringChars_Private_Static_Void_JStringBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueDeleteGlobalRef_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSameObject_Public_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewObjectA_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringCharsInternal_Private_Static_JStringBinding_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStringMethodUnsafeInternal_Private_Static_JStringBinding_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallVoidMethodUnsafe_Public_Static_Void_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticStringMethodUnsafeInternal_Private_Static_JStringBinding_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToBooleanArray_Private_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_ptr_SByte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_ptr_Int16_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_ptr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_ptr_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_ptr_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_ptr_Double_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_ptr_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseStringChars_Injected_Private_Static_Void_byref_JStringBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindClass_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodID_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStaticMethodID_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewStringFromStr_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStringCharsInternal_Injected_Private_Static_Void_IntPtr_byref_JStringBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStringMethodUnsafeInternal_Injected_Private_Static_Void_IntPtr_IntPtr_ptr_jvalue_byref_JStringBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallStaticStringMethodUnsafeInternal_Injected_Private_Static_Void_IntPtr_IntPtr_ptr_jvalue_byref_JStringBinding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToBooleanArray_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToByteArray_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromBooleanArray_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromByteArray_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0;

	private static readonly GetJavaVMDelegate GetJavaVMDelegateField;

	private static readonly AttachCurrentThreadDelegate AttachCurrentThreadDelegateField;

	private static readonly DetachCurrentThreadDelegate DetachCurrentThreadDelegateField;

	private static readonly InvokeAttachedDelegate InvokeAttachedDelegateField;

	private static readonly GetVersionDelegate GetVersionDelegateField;

	private static readonly FromReflectedFieldDelegate FromReflectedFieldDelegateField;

	private static readonly ToReflectedMethodDelegate ToReflectedMethodDelegateField;

	private static readonly ToReflectedFieldDelegate ToReflectedFieldDelegateField;

	private static readonly GetSuperclassDelegate GetSuperclassDelegateField;

	private static readonly IsAssignableFromDelegate IsAssignableFromDelegateField;

	private static readonly ThrowDelegate ThrowDelegateField;

	private static readonly ExceptionDescribeDelegate ExceptionDescribeDelegateField;

	private static readonly DeleteGlobalRefDelegate DeleteGlobalRefDelegateField;

	private static readonly GetQueueGlobalRefsCountDelegate GetQueueGlobalRefsCountDelegateField;

	private static readonly CleanQueueGlobalRefsDelegate CleanQueueGlobalRefsDelegateField;

	private static readonly EnsureLocalCapacityDelegate EnsureLocalCapacityDelegateField;

	private static readonly AllocObjectDelegate AllocObjectDelegateField;

	private static readonly IsInstanceOfDelegate IsInstanceOfDelegateField;

	private static readonly GetStringLengthDelegate GetStringLengthDelegateField;

	private static readonly GetStringUTFLengthDelegate GetStringUTFLengthDelegateField;

	private static readonly GetObjectFieldDelegate GetObjectFieldDelegateField;

	private static readonly GetBooleanFieldDelegate GetBooleanFieldDelegateField;

	private static readonly GetSByteFieldDelegate GetSByteFieldDelegateField;

	private static readonly GetCharFieldDelegate GetCharFieldDelegateField;

	private static readonly GetShortFieldDelegate GetShortFieldDelegateField;

	private static readonly GetIntFieldDelegate GetIntFieldDelegateField;

	private static readonly GetLongFieldDelegate GetLongFieldDelegateField;

	private static readonly GetFloatFieldDelegate GetFloatFieldDelegateField;

	private static readonly GetDoubleFieldDelegate GetDoubleFieldDelegateField;

	private static readonly SetObjectFieldDelegate SetObjectFieldDelegateField;

	private static readonly SetBooleanFieldDelegate SetBooleanFieldDelegateField;

	private static readonly SetSByteFieldDelegate SetSByteFieldDelegateField;

	private static readonly SetCharFieldDelegate SetCharFieldDelegateField;

	private static readonly SetShortFieldDelegate SetShortFieldDelegateField;

	private static readonly SetIntFieldDelegate SetIntFieldDelegateField;

	private static readonly SetLongFieldDelegate SetLongFieldDelegateField;

	private static readonly SetFloatFieldDelegate SetFloatFieldDelegateField;

	private static readonly SetDoubleFieldDelegate SetDoubleFieldDelegateField;

	private static readonly CallStaticVoidMethodUnsafeDelegate CallStaticVoidMethodUnsafeDelegateField;

	private static readonly GetStaticObjectFieldDelegate GetStaticObjectFieldDelegateField;

	private static readonly GetStaticBooleanFieldDelegate GetStaticBooleanFieldDelegateField;

	private static readonly GetStaticSByteFieldDelegate GetStaticSByteFieldDelegateField;

	private static readonly GetStaticCharFieldDelegate GetStaticCharFieldDelegateField;

	private static readonly GetStaticShortFieldDelegate GetStaticShortFieldDelegateField;

	private static readonly GetStaticIntFieldDelegate GetStaticIntFieldDelegateField;

	private static readonly GetStaticLongFieldDelegate GetStaticLongFieldDelegateField;

	private static readonly GetStaticFloatFieldDelegate GetStaticFloatFieldDelegateField;

	private static readonly GetStaticDoubleFieldDelegate GetStaticDoubleFieldDelegateField;

	private static readonly SetStaticObjectFieldDelegate SetStaticObjectFieldDelegateField;

	private static readonly SetStaticBooleanFieldDelegate SetStaticBooleanFieldDelegateField;

	private static readonly SetStaticSByteFieldDelegate SetStaticSByteFieldDelegateField;

	private static readonly SetStaticCharFieldDelegate SetStaticCharFieldDelegateField;

	private static readonly SetStaticShortFieldDelegate SetStaticShortFieldDelegateField;

	private static readonly SetStaticIntFieldDelegate SetStaticIntFieldDelegateField;

	private static readonly SetStaticLongFieldDelegate SetStaticLongFieldDelegateField;

	private static readonly SetStaticFloatFieldDelegate SetStaticFloatFieldDelegateField;

	private static readonly SetStaticDoubleFieldDelegate SetStaticDoubleFieldDelegateField;

	private static readonly NewBooleanArrayDelegate NewBooleanArrayDelegateField;

	private static readonly NewSByteArrayDelegate NewSByteArrayDelegateField;

	private static readonly NewCharArrayDelegate NewCharArrayDelegateField;

	private static readonly NewShortArrayDelegate NewShortArrayDelegateField;

	private static readonly NewIntArrayDelegate NewIntArrayDelegateField;

	private static readonly NewLongArrayDelegate NewLongArrayDelegateField;

	private static readonly NewFloatArrayDelegate NewFloatArrayDelegateField;

	private static readonly NewDoubleArrayDelegate NewDoubleArrayDelegateField;

	private static readonly GetBooleanArrayElementDelegate GetBooleanArrayElementDelegateField;

	private static readonly GetSByteArrayElementDelegate GetSByteArrayElementDelegateField;

	private static readonly GetCharArrayElementDelegate GetCharArrayElementDelegateField;

	private static readonly GetShortArrayElementDelegate GetShortArrayElementDelegateField;

	private static readonly GetIntArrayElementDelegate GetIntArrayElementDelegateField;

	private static readonly GetLongArrayElementDelegate GetLongArrayElementDelegateField;

	private static readonly GetFloatArrayElementDelegate GetFloatArrayElementDelegateField;

	private static readonly GetDoubleArrayElementDelegate GetDoubleArrayElementDelegateField;

	private static readonly SetBooleanArrayElementDelegate SetBooleanArrayElementDelegateField;

	private static readonly SetSByteArrayElementDelegate SetSByteArrayElementDelegateField;

	private static readonly SetCharArrayElementDelegate SetCharArrayElementDelegateField;

	private static readonly SetShortArrayElementDelegate SetShortArrayElementDelegateField;

	private static readonly SetIntArrayElementDelegate SetIntArrayElementDelegateField;

	private static readonly SetLongArrayElementDelegate SetLongArrayElementDelegateField;

	private static readonly SetFloatArrayElementDelegate SetFloatArrayElementDelegateField;

	private static readonly SetDoubleArrayElementDelegate SetDoubleArrayElementDelegateField;

	private static readonly NewDirectByteBufferDelegate NewDirectByteBufferDelegateField;

	private static readonly GetDirectBufferAddressDelegate GetDirectBufferAddressDelegateField;

	private static readonly GetDirectBufferCapacityDelegate GetDirectBufferCapacityDelegateField;

	private static readonly RegisterNativesAllocateDelegate RegisterNativesAllocateDelegateField;

	private static readonly RegisterNativesAndFreeDelegate RegisterNativesAndFreeDelegateField;

	private static readonly UnregisterNativesDelegate UnregisterNativesDelegateField;

	private static readonly ThrowNew_InjectedDelegate ThrowNew_InjectedDelegateField;

	private static readonly FatalError_InjectedDelegate FatalError_InjectedDelegateField;

	private static readonly GetFieldID_InjectedDelegate GetFieldID_InjectedDelegateField;

	private static readonly GetStaticFieldID_InjectedDelegate GetStaticFieldID_InjectedDelegateField;

	private static readonly NewString_InjectedDelegate NewString_InjectedDelegateField;

	private static readonly NewStringUTF_InjectedDelegate NewStringUTF_InjectedDelegateField;

	private static readonly GetStringUTFChars_InjectedDelegate GetStringUTFChars_InjectedDelegateField;

	private static readonly GetStringFieldInternal_InjectedDelegate GetStringFieldInternal_InjectedDelegateField;

	private static readonly SetStringField_InjectedDelegate SetStringField_InjectedDelegateField;

	private static readonly GetStaticStringFieldInternal_InjectedDelegate GetStaticStringFieldInternal_InjectedDelegateField;

	private static readonly SetStaticStringField_InjectedDelegate SetStaticStringField_InjectedDelegateField;

	private static readonly FromObjectArray_InjectedDelegate FromObjectArray_InjectedDelegateField;

	private static readonly RegisterNativesSet_InjectedDelegate RegisterNativesSet_InjectedDelegateField;

	static AndroidJNI()
	{
		Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr);
		NativeMethodInfoPtr_ReleaseStringChars_Private_Static_Void_JStringBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_QueueDeleteGlobalRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_IsSameObject_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_NewObjectA_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_GetStringCharsInternal_Private_Static_JStringBinding_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_CallStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_CallStringMethodUnsafeInternal_Private_Static_JStringBinding_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_CallObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_CallIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_CallBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_CallShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_CallSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_CallCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_CallFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_CallDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_CallLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_CallVoidMethod_Public_Static_Void_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_CallVoidMethodUnsafe_Public_Static_Void_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_CallStaticStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_CallStaticStringMethodUnsafeInternal_Private_Static_JStringBinding_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_CallStaticObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_CallStaticIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_CallStaticBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_CallStaticShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_CallStaticSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_CallStaticCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_CallStaticFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_CallStaticDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_CallStaticLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_ConvertToBooleanArray_Private_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_ptr_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_ptr_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_ptr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_ptr_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_ptr_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_ptr_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_ptr_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_ReleaseStringChars_Injected_Private_Static_Void_byref_JStringBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_FindClass_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_GetMethodID_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_GetStaticMethodID_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_NewStringFromStr_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_GetStringCharsInternal_Injected_Private_Static_Void_IntPtr_byref_JStringBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_CallStringMethodUnsafeInternal_Injected_Private_Static_Void_IntPtr_IntPtr_ptr_jvalue_byref_JStringBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_CallStaticStringMethodUnsafeInternal_Injected_Private_Static_Void_IntPtr_IntPtr_ptr_jvalue_byref_JStringBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_ConvertToBooleanArray_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_ToByteArray_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_FromBooleanArray_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_FromByteArray_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663502);
		GetJavaVMDelegateField = IL2CPP.ResolveICall<GetJavaVMDelegate>("UnityEngine.AndroidJNI::GetJavaVM");
		AttachCurrentThreadDelegateField = IL2CPP.ResolveICall<AttachCurrentThreadDelegate>("UnityEngine.AndroidJNI::AttachCurrentThread");
		DetachCurrentThreadDelegateField = IL2CPP.ResolveICall<DetachCurrentThreadDelegate>("UnityEngine.AndroidJNI::DetachCurrentThread");
		InvokeAttachedDelegateField = IL2CPP.ResolveICall<InvokeAttachedDelegate>("UnityEngine.AndroidJNI::InvokeAttached");
		GetVersionDelegateField = IL2CPP.ResolveICall<GetVersionDelegate>("UnityEngine.AndroidJNI::GetVersion");
		FromReflectedFieldDelegateField = IL2CPP.ResolveICall<FromReflectedFieldDelegate>("UnityEngine.AndroidJNI::FromReflectedField");
		ToReflectedMethodDelegateField = IL2CPP.ResolveICall<ToReflectedMethodDelegate>("UnityEngine.AndroidJNI::ToReflectedMethod");
		ToReflectedFieldDelegateField = IL2CPP.ResolveICall<ToReflectedFieldDelegate>("UnityEngine.AndroidJNI::ToReflectedField");
		GetSuperclassDelegateField = IL2CPP.ResolveICall<GetSuperclassDelegate>("UnityEngine.AndroidJNI::GetSuperclass");
		IsAssignableFromDelegateField = IL2CPP.ResolveICall<IsAssignableFromDelegate>("UnityEngine.AndroidJNI::IsAssignableFrom");
		ThrowDelegateField = IL2CPP.ResolveICall<ThrowDelegate>("UnityEngine.AndroidJNI::Throw");
		ExceptionDescribeDelegateField = IL2CPP.ResolveICall<ExceptionDescribeDelegate>("UnityEngine.AndroidJNI::ExceptionDescribe");
		DeleteGlobalRefDelegateField = IL2CPP.ResolveICall<DeleteGlobalRefDelegate>("UnityEngine.AndroidJNI::DeleteGlobalRef");
		GetQueueGlobalRefsCountDelegateField = IL2CPP.ResolveICall<GetQueueGlobalRefsCountDelegate>("UnityEngine.AndroidJNI::GetQueueGlobalRefsCount");
		CleanQueueGlobalRefsDelegateField = IL2CPP.ResolveICall<CleanQueueGlobalRefsDelegate>("UnityEngine.AndroidJNI::CleanQueueGlobalRefs");
		EnsureLocalCapacityDelegateField = IL2CPP.ResolveICall<EnsureLocalCapacityDelegate>("UnityEngine.AndroidJNI::EnsureLocalCapacity");
		AllocObjectDelegateField = IL2CPP.ResolveICall<AllocObjectDelegate>("UnityEngine.AndroidJNI::AllocObject");
		IsInstanceOfDelegateField = IL2CPP.ResolveICall<IsInstanceOfDelegate>("UnityEngine.AndroidJNI::IsInstanceOf");
		GetStringLengthDelegateField = IL2CPP.ResolveICall<GetStringLengthDelegate>("UnityEngine.AndroidJNI::GetStringLength");
		GetStringUTFLengthDelegateField = IL2CPP.ResolveICall<GetStringUTFLengthDelegate>("UnityEngine.AndroidJNI::GetStringUTFLength");
		GetObjectFieldDelegateField = IL2CPP.ResolveICall<GetObjectFieldDelegate>("UnityEngine.AndroidJNI::GetObjectField");
		GetBooleanFieldDelegateField = IL2CPP.ResolveICall<GetBooleanFieldDelegate>("UnityEngine.AndroidJNI::GetBooleanField");
		GetSByteFieldDelegateField = IL2CPP.ResolveICall<GetSByteFieldDelegate>("UnityEngine.AndroidJNI::GetSByteField");
		GetCharFieldDelegateField = IL2CPP.ResolveICall<GetCharFieldDelegate>("UnityEngine.AndroidJNI::GetCharField");
		GetShortFieldDelegateField = IL2CPP.ResolveICall<GetShortFieldDelegate>("UnityEngine.AndroidJNI::GetShortField");
		GetIntFieldDelegateField = IL2CPP.ResolveICall<GetIntFieldDelegate>("UnityEngine.AndroidJNI::GetIntField");
		GetLongFieldDelegateField = IL2CPP.ResolveICall<GetLongFieldDelegate>("UnityEngine.AndroidJNI::GetLongField");
		GetFloatFieldDelegateField = IL2CPP.ResolveICall<GetFloatFieldDelegate>("UnityEngine.AndroidJNI::GetFloatField");
		GetDoubleFieldDelegateField = IL2CPP.ResolveICall<GetDoubleFieldDelegate>("UnityEngine.AndroidJNI::GetDoubleField");
		SetObjectFieldDelegateField = IL2CPP.ResolveICall<SetObjectFieldDelegate>("UnityEngine.AndroidJNI::SetObjectField");
		SetBooleanFieldDelegateField = IL2CPP.ResolveICall<SetBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetBooleanField");
		SetSByteFieldDelegateField = IL2CPP.ResolveICall<SetSByteFieldDelegate>("UnityEngine.AndroidJNI::SetSByteField");
		SetCharFieldDelegateField = IL2CPP.ResolveICall<SetCharFieldDelegate>("UnityEngine.AndroidJNI::SetCharField");
		SetShortFieldDelegateField = IL2CPP.ResolveICall<SetShortFieldDelegate>("UnityEngine.AndroidJNI::SetShortField");
		SetIntFieldDelegateField = IL2CPP.ResolveICall<SetIntFieldDelegate>("UnityEngine.AndroidJNI::SetIntField");
		SetLongFieldDelegateField = IL2CPP.ResolveICall<SetLongFieldDelegate>("UnityEngine.AndroidJNI::SetLongField");
		SetFloatFieldDelegateField = IL2CPP.ResolveICall<SetFloatFieldDelegate>("UnityEngine.AndroidJNI::SetFloatField");
		SetDoubleFieldDelegateField = IL2CPP.ResolveICall<SetDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetDoubleField");
		CallStaticVoidMethodUnsafeDelegateField = IL2CPP.ResolveICall<CallStaticVoidMethodUnsafeDelegate>("UnityEngine.AndroidJNI::CallStaticVoidMethodUnsafe");
		GetStaticObjectFieldDelegateField = IL2CPP.ResolveICall<GetStaticObjectFieldDelegate>("UnityEngine.AndroidJNI::GetStaticObjectField");
		GetStaticBooleanFieldDelegateField = IL2CPP.ResolveICall<GetStaticBooleanFieldDelegate>("UnityEngine.AndroidJNI::GetStaticBooleanField");
		GetStaticSByteFieldDelegateField = IL2CPP.ResolveICall<GetStaticSByteFieldDelegate>("UnityEngine.AndroidJNI::GetStaticSByteField");
		GetStaticCharFieldDelegateField = IL2CPP.ResolveICall<GetStaticCharFieldDelegate>("UnityEngine.AndroidJNI::GetStaticCharField");
		GetStaticShortFieldDelegateField = IL2CPP.ResolveICall<GetStaticShortFieldDelegate>("UnityEngine.AndroidJNI::GetStaticShortField");
		GetStaticIntFieldDelegateField = IL2CPP.ResolveICall<GetStaticIntFieldDelegate>("UnityEngine.AndroidJNI::GetStaticIntField");
		GetStaticLongFieldDelegateField = IL2CPP.ResolveICall<GetStaticLongFieldDelegate>("UnityEngine.AndroidJNI::GetStaticLongField");
		GetStaticFloatFieldDelegateField = IL2CPP.ResolveICall<GetStaticFloatFieldDelegate>("UnityEngine.AndroidJNI::GetStaticFloatField");
		GetStaticDoubleFieldDelegateField = IL2CPP.ResolveICall<GetStaticDoubleFieldDelegate>("UnityEngine.AndroidJNI::GetStaticDoubleField");
		SetStaticObjectFieldDelegateField = IL2CPP.ResolveICall<SetStaticObjectFieldDelegate>("UnityEngine.AndroidJNI::SetStaticObjectField");
		SetStaticBooleanFieldDelegateField = IL2CPP.ResolveICall<SetStaticBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetStaticBooleanField");
		SetStaticSByteFieldDelegateField = IL2CPP.ResolveICall<SetStaticSByteFieldDelegate>("UnityEngine.AndroidJNI::SetStaticSByteField");
		SetStaticCharFieldDelegateField = IL2CPP.ResolveICall<SetStaticCharFieldDelegate>("UnityEngine.AndroidJNI::SetStaticCharField");
		SetStaticShortFieldDelegateField = IL2CPP.ResolveICall<SetStaticShortFieldDelegate>("UnityEngine.AndroidJNI::SetStaticShortField");
		SetStaticIntFieldDelegateField = IL2CPP.ResolveICall<SetStaticIntFieldDelegate>("UnityEngine.AndroidJNI::SetStaticIntField");
		SetStaticLongFieldDelegateField = IL2CPP.ResolveICall<SetStaticLongFieldDelegate>("UnityEngine.AndroidJNI::SetStaticLongField");
		SetStaticFloatFieldDelegateField = IL2CPP.ResolveICall<SetStaticFloatFieldDelegate>("UnityEngine.AndroidJNI::SetStaticFloatField");
		SetStaticDoubleFieldDelegateField = IL2CPP.ResolveICall<SetStaticDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetStaticDoubleField");
		NewBooleanArrayDelegateField = IL2CPP.ResolveICall<NewBooleanArrayDelegate>("UnityEngine.AndroidJNI::NewBooleanArray");
		NewSByteArrayDelegateField = IL2CPP.ResolveICall<NewSByteArrayDelegate>("UnityEngine.AndroidJNI::NewSByteArray");
		NewCharArrayDelegateField = IL2CPP.ResolveICall<NewCharArrayDelegate>("UnityEngine.AndroidJNI::NewCharArray");
		NewShortArrayDelegateField = IL2CPP.ResolveICall<NewShortArrayDelegate>("UnityEngine.AndroidJNI::NewShortArray");
		NewIntArrayDelegateField = IL2CPP.ResolveICall<NewIntArrayDelegate>("UnityEngine.AndroidJNI::NewIntArray");
		NewLongArrayDelegateField = IL2CPP.ResolveICall<NewLongArrayDelegate>("UnityEngine.AndroidJNI::NewLongArray");
		NewFloatArrayDelegateField = IL2CPP.ResolveICall<NewFloatArrayDelegate>("UnityEngine.AndroidJNI::NewFloatArray");
		NewDoubleArrayDelegateField = IL2CPP.ResolveICall<NewDoubleArrayDelegate>("UnityEngine.AndroidJNI::NewDoubleArray");
		GetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<GetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::GetBooleanArrayElement");
		GetSByteArrayElementDelegateField = IL2CPP.ResolveICall<GetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::GetSByteArrayElement");
		GetCharArrayElementDelegateField = IL2CPP.ResolveICall<GetCharArrayElementDelegate>("UnityEngine.AndroidJNI::GetCharArrayElement");
		GetShortArrayElementDelegateField = IL2CPP.ResolveICall<GetShortArrayElementDelegate>("UnityEngine.AndroidJNI::GetShortArrayElement");
		GetIntArrayElementDelegateField = IL2CPP.ResolveICall<GetIntArrayElementDelegate>("UnityEngine.AndroidJNI::GetIntArrayElement");
		GetLongArrayElementDelegateField = IL2CPP.ResolveICall<GetLongArrayElementDelegate>("UnityEngine.AndroidJNI::GetLongArrayElement");
		GetFloatArrayElementDelegateField = IL2CPP.ResolveICall<GetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::GetFloatArrayElement");
		GetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<GetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::GetDoubleArrayElement");
		SetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<SetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::SetBooleanArrayElement");
		SetSByteArrayElementDelegateField = IL2CPP.ResolveICall<SetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::SetSByteArrayElement");
		SetCharArrayElementDelegateField = IL2CPP.ResolveICall<SetCharArrayElementDelegate>("UnityEngine.AndroidJNI::SetCharArrayElement");
		SetShortArrayElementDelegateField = IL2CPP.ResolveICall<SetShortArrayElementDelegate>("UnityEngine.AndroidJNI::SetShortArrayElement");
		SetIntArrayElementDelegateField = IL2CPP.ResolveICall<SetIntArrayElementDelegate>("UnityEngine.AndroidJNI::SetIntArrayElement");
		SetLongArrayElementDelegateField = IL2CPP.ResolveICall<SetLongArrayElementDelegate>("UnityEngine.AndroidJNI::SetLongArrayElement");
		SetFloatArrayElementDelegateField = IL2CPP.ResolveICall<SetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::SetFloatArrayElement");
		SetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<SetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::SetDoubleArrayElement");
		NewDirectByteBufferDelegateField = IL2CPP.ResolveICall<NewDirectByteBufferDelegate>("UnityEngine.AndroidJNI::NewDirectByteBuffer");
		GetDirectBufferAddressDelegateField = IL2CPP.ResolveICall<GetDirectBufferAddressDelegate>("UnityEngine.AndroidJNI::GetDirectBufferAddress");
		GetDirectBufferCapacityDelegateField = IL2CPP.ResolveICall<GetDirectBufferCapacityDelegate>("UnityEngine.AndroidJNI::GetDirectBufferCapacity");
		RegisterNativesAllocateDelegateField = IL2CPP.ResolveICall<RegisterNativesAllocateDelegate>("UnityEngine.AndroidJNI::RegisterNativesAllocate");
		RegisterNativesAndFreeDelegateField = IL2CPP.ResolveICall<RegisterNativesAndFreeDelegate>("UnityEngine.AndroidJNI::RegisterNativesAndFree");
		UnregisterNativesDelegateField = IL2CPP.ResolveICall<UnregisterNativesDelegate>("UnityEngine.AndroidJNI::UnregisterNatives");
		ThrowNew_InjectedDelegateField = IL2CPP.ResolveICall<ThrowNew_InjectedDelegate>("UnityEngine.AndroidJNI::ThrowNew_Injected");
		FatalError_InjectedDelegateField = IL2CPP.ResolveICall<FatalError_InjectedDelegate>("UnityEngine.AndroidJNI::FatalError_Injected");
		GetFieldID_InjectedDelegateField = IL2CPP.ResolveICall<GetFieldID_InjectedDelegate>("UnityEngine.AndroidJNI::GetFieldID_Injected");
		GetStaticFieldID_InjectedDelegateField = IL2CPP.ResolveICall<GetStaticFieldID_InjectedDelegate>("UnityEngine.AndroidJNI::GetStaticFieldID_Injected");
		NewString_InjectedDelegateField = IL2CPP.ResolveICall<NewString_InjectedDelegate>("UnityEngine.AndroidJNI::NewString_Injected");
		NewStringUTF_InjectedDelegateField = IL2CPP.ResolveICall<NewStringUTF_InjectedDelegate>("UnityEngine.AndroidJNI::NewStringUTF_Injected");
		GetStringUTFChars_InjectedDelegateField = IL2CPP.ResolveICall<GetStringUTFChars_InjectedDelegate>("UnityEngine.AndroidJNI::GetStringUTFChars_Injected");
		GetStringFieldInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetStringFieldInternal_InjectedDelegate>("UnityEngine.AndroidJNI::GetStringFieldInternal_Injected");
		SetStringField_InjectedDelegateField = IL2CPP.ResolveICall<SetStringField_InjectedDelegate>("UnityEngine.AndroidJNI::SetStringField_Injected");
		GetStaticStringFieldInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetStaticStringFieldInternal_InjectedDelegate>("UnityEngine.AndroidJNI::GetStaticStringFieldInternal_Injected");
		SetStaticStringField_InjectedDelegateField = IL2CPP.ResolveICall<SetStaticStringField_InjectedDelegate>("UnityEngine.AndroidJNI::SetStaticStringField_Injected");
		FromObjectArray_InjectedDelegateField = IL2CPP.ResolveICall<FromObjectArray_InjectedDelegate>("UnityEngine.AndroidJNI::FromObjectArray_Injected");
		RegisterNativesSet_InjectedDelegateField = IL2CPP.ResolveICall<RegisterNativesSet_InjectedDelegate>("UnityEngine.AndroidJNI::RegisterNativesSet_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150609, XrefRangeEnd = 1150611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseStringChars(JStringBinding str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseStringChars_Private_Static_Void_JStringBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150611, XrefRangeEnd = 1150612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeAction(Il2CppSystem.Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150626, RefRangeEnd = 1150627, XrefRangeStart = 1150612, XrefRangeEnd = 1150626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindClass(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150627, XrefRangeEnd = 1150629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FromReflectedMethod(System.IntPtr refMethod)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&refMethod);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150629, XrefRangeEnd = 1150631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ExceptionOccurred()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150631, XrefRangeEnd = 1150633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExceptionClear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1150635, RefRangeEnd = 1150638, XrefRangeStart = 1150633, XrefRangeEnd = 1150635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PushLocalFrame(int capacity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushLocalFrame_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 1150640, RefRangeEnd = 1150691, XrefRangeStart = 1150638, XrefRangeEnd = 1150640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr PopLocalFrame(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopLocalFrame_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150691, XrefRangeEnd = 1150693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewGlobalRef(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150693, XrefRangeEnd = 1150695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueDeleteGlobalRef(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueDeleteGlobalRef_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150695, XrefRangeEnd = 1150697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewWeakGlobalRef(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150697, XrefRangeEnd = 1150699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteWeakGlobalRef(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150699, XrefRangeEnd = 1150701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewLocalRef(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150701, XrefRangeEnd = 1150703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteLocalRef(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1150705, RefRangeEnd = 1150707, XrefRangeStart = 1150703, XrefRangeEnd = 1150705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSameObject(System.IntPtr obj1, System.IntPtr obj2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&obj1);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &obj2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSameObject_Public_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150707, XrefRangeEnd = 1150712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150712, XrefRangeEnd = 1150714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewObjectA(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewObjectA_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150714, XrefRangeEnd = 1150716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetObjectClass(System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150739, RefRangeEnd = 1150740, XrefRangeStart = 1150716, XrefRangeEnd = 1150739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID(System.IntPtr clazz, string name, string sig)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sig);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1150763, RefRangeEnd = 1150764, XrefRangeStart = 1150740, XrefRangeEnd = 1150763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150764, XrefRangeEnd = 1150765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewString(string chars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1150779, RefRangeEnd = 1150781, XrefRangeStart = 1150765, XrefRangeEnd = 1150779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewStringFromStr(string chars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1150791, RefRangeEnd = 1150793, XrefRangeStart = 1150781, XrefRangeEnd = 1150791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150793, XrefRangeEnd = 1150795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JStringBinding GetStringCharsInternal(System.IntPtr str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringCharsInternal_Private_Static_JStringBinding_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JStringBinding*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150795, XrefRangeEnd = 1150801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CallStringMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150801, XrefRangeEnd = 1150805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1150815, RefRangeEnd = 1150818, XrefRangeStart = 1150805, XrefRangeEnd = 1150815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CallStringMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150818, XrefRangeEnd = 1150820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JStringBinding CallStringMethodUnsafeInternal(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStringMethodUnsafeInternal_Private_Static_JStringBinding_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JStringBinding*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150820, XrefRangeEnd = 1150825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150825, XrefRangeEnd = 1150827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CallObjectMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150827, XrefRangeEnd = 1150832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150832, XrefRangeEnd = 1150834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CallIntMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150834, XrefRangeEnd = 1150839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150839, XrefRangeEnd = 1150841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CallBooleanMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150841, XrefRangeEnd = 1150846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150846, XrefRangeEnd = 1150848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short CallShortMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150848, XrefRangeEnd = 1150853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150853, XrefRangeEnd = 1150855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte CallSByteMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150855, XrefRangeEnd = 1150860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150860, XrefRangeEnd = 1150862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char CallCharMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150862, XrefRangeEnd = 1150867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150867, XrefRangeEnd = 1150869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CallFloatMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150869, XrefRangeEnd = 1150874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150874, XrefRangeEnd = 1150876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CallDoubleMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150876, XrefRangeEnd = 1150881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150881, XrefRangeEnd = 1150883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CallLongMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150883, XrefRangeEnd = 1150888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150888, XrefRangeEnd = 1150890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallVoidMethodUnsafe(System.IntPtr obj, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallVoidMethodUnsafe_Public_Static_Void_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150890, XrefRangeEnd = 1150896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CallStaticStringMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150896, XrefRangeEnd = 1150900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1150910, RefRangeEnd = 1150913, XrefRangeStart = 1150900, XrefRangeEnd = 1150910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CallStaticStringMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150913, XrefRangeEnd = 1150915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static JStringBinding CallStaticStringMethodUnsafeInternal(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticStringMethodUnsafeInternal_Private_Static_JStringBinding_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JStringBinding*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150915, XrefRangeEnd = 1150920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150920, XrefRangeEnd = 1150922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CallStaticObjectMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150922, XrefRangeEnd = 1150927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150927, XrefRangeEnd = 1150929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CallStaticIntMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150929, XrefRangeEnd = 1150934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150934, XrefRangeEnd = 1150936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CallStaticBooleanMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150936, XrefRangeEnd = 1150941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150941, XrefRangeEnd = 1150943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short CallStaticShortMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150943, XrefRangeEnd = 1150948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150948, XrefRangeEnd = 1150950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static sbyte CallStaticSByteMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150950, XrefRangeEnd = 1150955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150955, XrefRangeEnd = 1150957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char CallStaticCharMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150957, XrefRangeEnd = 1150962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150962, XrefRangeEnd = 1150964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CallStaticFloatMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150964, XrefRangeEnd = 1150969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150969, XrefRangeEnd = 1150971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double CallStaticDoubleMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150971, XrefRangeEnd = 1150976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150976, XrefRangeEnd = 1150978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long CallStaticLongMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150978, XrefRangeEnd = 1150987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ConvertToBooleanArray(Il2CppStructArray<bool> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToBooleanArray_Private_Static_IntPtr_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static System.IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150987, XrefRangeEnd = 1150996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToByteArray(Il2CppStructArray<byte> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150996, XrefRangeEnd = 1150999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1150999, XrefRangeEnd = 1151001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToSByteArray(sbyte* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_ptr_SByte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151001, XrefRangeEnd = 1151004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToCharArray(Il2CppStructArray<char> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151004, XrefRangeEnd = 1151006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToCharArray(char* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151006, XrefRangeEnd = 1151009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToShortArray(Il2CppStructArray<short> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151009, XrefRangeEnd = 1151011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToShortArray(short* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_ptr_Int16_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151011, XrefRangeEnd = 1151014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToIntArray(Il2CppStructArray<int> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151014, XrefRangeEnd = 1151016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToIntArray(int* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_ptr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151016, XrefRangeEnd = 1151019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToLongArray(Il2CppStructArray<long> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151019, XrefRangeEnd = 1151021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToLongArray(long* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_ptr_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151021, XrefRangeEnd = 1151024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToFloatArray(Il2CppStructArray<float> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151024, XrefRangeEnd = 1151026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToFloatArray(float* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_ptr_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151026, XrefRangeEnd = 1151029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToDoubleArray(Il2CppStructArray<double> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151029, XrefRangeEnd = 1151031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToDoubleArray(double* array, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_ptr_Double_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151031, XrefRangeEnd = 1151033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToObjectArray(System.IntPtr* array, int length, System.IntPtr arrayClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)array;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayClass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_ptr_IntPtr_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151033, XrefRangeEnd = 1151036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToObjectArray(Il2CppStructArray<System.IntPtr> array, System.IntPtr arrayClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &arrayClass;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151042, RefRangeEnd = 1151043, XrefRangeStart = 1151036, XrefRangeEnd = 1151042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<bool> FromBooleanArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151049, RefRangeEnd = 1151050, XrefRangeStart = 1151043, XrefRangeEnd = 1151049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151050, XrefRangeEnd = 1151052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151052, XrefRangeEnd = 1151054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151054, XrefRangeEnd = 1151056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151056, XrefRangeEnd = 1151058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> FromIntArray(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151058, XrefRangeEnd = 1151060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151060, XrefRangeEnd = 1151062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151062, XrefRangeEnd = 1151064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151064, XrefRangeEnd = 1151066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetArrayLength(System.IntPtr array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151066, XrefRangeEnd = 1151068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewObjectArray(int size, System.IntPtr clazz, System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&size);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clazz;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &obj;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1151070, RefRangeEnd = 1151072, XrefRangeStart = 1151068, XrefRangeEnd = 1151070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1151074, RefRangeEnd = 1151075, XrefRangeStart = 1151072, XrefRangeEnd = 1151074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetObjectArrayElement(System.IntPtr array, int index, System.IntPtr obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &obj;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151075, XrefRangeEnd = 1151077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReleaseStringChars_Injected([In] ref JStringBinding str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseStringChars_Injected_Private_Static_Void_byref_JStringBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151077, XrefRangeEnd = 1151079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindClass_Injected(ref ManagedSpanWrapper name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindClass_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151079, XrefRangeEnd = 1151081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetMethodID_Injected(System.IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sig);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethodID_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151081, XrefRangeEnd = 1151083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetStaticMethodID_Injected(System.IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&clazz);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref sig);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStaticMethodID_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151083, XrefRangeEnd = 1151085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr NewStringFromStr_Injected(ref ManagedSpanWrapper chars)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref chars);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewStringFromStr_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151085, XrefRangeEnd = 1151087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetStringCharsInternal_Injected(System.IntPtr str, out JStringBinding ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&str);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStringCharsInternal_Injected_Private_Static_Void_IntPtr_byref_JStringBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151087, XrefRangeEnd = 1151089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallStringMethodUnsafeInternal_Injected(System.IntPtr obj, System.IntPtr methodID, jvalue* args, out JStringBinding ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&obj);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStringMethodUnsafeInternal_Injected_Private_Static_Void_IntPtr_IntPtr_ptr_jvalue_byref_JStringBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151089, XrefRangeEnd = 1151091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallStaticStringMethodUnsafeInternal_Injected(System.IntPtr clazz, System.IntPtr methodID, jvalue* args, out JStringBinding ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&clazz);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodID;
		*(jvalue**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = args;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallStaticStringMethodUnsafeInternal_Injected_Private_Static_Void_IntPtr_IntPtr_ptr_jvalue_byref_JStringBinding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151091, XrefRangeEnd = 1151093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ConvertToBooleanArray_Injected(ref ManagedSpanWrapper array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToBooleanArray_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151093, XrefRangeEnd = 1151095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr ToByteArray_Injected(ref ManagedSpanWrapper array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToByteArray_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151095, XrefRangeEnd = 1151097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FromBooleanArray_Injected(System.IntPtr array, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromBooleanArray_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151097, XrefRangeEnd = 1151099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FromByteArray_Injected(System.IntPtr array, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromByteArray_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AndroidJNI(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr GetJavaVM()
	{
		return GetJavaVMDelegateField();
	}

	public static int AttachCurrentThread()
	{
		return AttachCurrentThreadDelegateField();
	}

	public static int DetachCurrentThread()
	{
		return DetachCurrentThreadDelegateField();
	}

	public static void InvokeAttached(Il2CppSystem.Action action)
	{
		InvokeAttachedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action));
	}

	public static int GetVersion()
	{
		return GetVersionDelegateField();
	}

	public static System.IntPtr FromReflectedField(System.IntPtr refField)
	{
		return FromReflectedFieldDelegateField(refField);
	}

	public static System.IntPtr ToReflectedMethod(System.IntPtr clazz, System.IntPtr methodID, bool isStatic)
	{
		return ToReflectedMethodDelegateField(clazz, methodID, isStatic);
	}

	public static System.IntPtr ToReflectedField(System.IntPtr clazz, System.IntPtr fieldID, bool isStatic)
	{
		return ToReflectedFieldDelegateField(clazz, fieldID, isStatic);
	}

	public static System.IntPtr GetSuperclass(System.IntPtr clazz)
	{
		return GetSuperclassDelegateField(clazz);
	}

	public static bool IsAssignableFrom(System.IntPtr clazz1, System.IntPtr clazz2)
	{
		return IsAssignableFromDelegateField(clazz1, clazz2);
	}

	public static int Throw(System.IntPtr obj)
	{
		return ThrowDelegateField(obj);
	}

	public unsafe static int ThrowNew(System.IntPtr clazz, string message)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(message);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return ThrowNew_Injected(clazz, ref managedSpanWrapper);
				}
			}
			return ThrowNew_Injected(clazz, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void ExceptionDescribe()
	{
		ExceptionDescribeDelegateField();
	}

	public unsafe static void FatalError(string message)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(message);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					FatalError_Injected(ref managedSpanWrapper);
					return;
				}
			}
			FatalError_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void DeleteGlobalRef(System.IntPtr obj)
	{
		DeleteGlobalRefDelegateField(obj);
	}

	public static uint GetQueueGlobalRefsCount()
	{
		return GetQueueGlobalRefsCountDelegateField();
	}

	public static void CleanQueueGlobalRefs()
	{
		CleanQueueGlobalRefsDelegateField();
	}

	public static int EnsureLocalCapacity(int capacity)
	{
		return EnsureLocalCapacityDelegateField(capacity);
	}

	public static System.IntPtr AllocObject(System.IntPtr clazz)
	{
		return AllocObjectDelegateField(clazz);
	}

	public static System.IntPtr NewObject(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return NewObject(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static bool IsInstanceOf(System.IntPtr obj, System.IntPtr clazz)
	{
		return IsInstanceOfDelegateField(obj, clazz);
	}

	public unsafe static System.IntPtr GetFieldID(System.IntPtr clazz, string name, string sig)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//The blocks IL_002a, IL_0037, IL_0045, IL_0053, IL_0058 are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper name2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					name2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(sig, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(sig);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return GetFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
						}
					}
					return GetFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
				}
			}
			name2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(sig, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(sig);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return GetFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
				}
			}
			return GetFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static System.IntPtr GetStaticFieldID(System.IntPtr clazz, string name, string sig)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//The blocks IL_002a, IL_0037, IL_0045, IL_0053, IL_0058 are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper name2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					name2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(sig, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(sig);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return GetStaticFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
						}
					}
					return GetStaticFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
				}
			}
			name2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(sig, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(sig);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return GetStaticFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
				}
			}
			return GetStaticFieldID_Injected(clazz, ref name2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static System.IntPtr NewString(Il2CppStructArray<char> chars)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<char> span);
		((Il2CppSystem.Span<char>)(&span))._002Ector((Il2CppArrayBase<char>)(object)chars);
		System.IntPtr result;
		fixed (char* begin = &((Il2CppSystem.Span<char>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper chars2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<char>)(&span)).Length);
			result = NewString_Injected(ref chars2);
		}
		return result;
	}

	public unsafe static System.IntPtr NewStringUTF(string bytes)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(bytes, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(bytes);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return NewStringUTF_Injected(ref managedSpanWrapper);
				}
			}
			return NewStringUTF_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static int GetStringLength(System.IntPtr str)
	{
		return GetStringLengthDelegateField(str);
	}

	public static int GetStringUTFLength(System.IntPtr str)
	{
		return GetStringUTFLengthDelegateField(str);
	}

	public static string GetStringUTFChars(System.IntPtr str)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetStringUTFChars_Injected(str, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static System.IntPtr CallObjectMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallObjectMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static int CallIntMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallIntMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static bool CallBooleanMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallBooleanMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static short CallShortMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallShortMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static byte CallByteMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return (byte)CallSByteMethod(obj, methodID, args);
	}

	public static sbyte CallSByteMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallSByteMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static char CallCharMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallCharMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static float CallFloatMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallFloatMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static double CallDoubleMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallDoubleMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static long CallLongMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallLongMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static void CallVoidMethod(System.IntPtr obj, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		CallVoidMethod(obj, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static string GetStringField(System.IntPtr obj, System.IntPtr fieldID)
	{
		JStringBinding stringFieldInternal = GetStringFieldInternal(obj, fieldID);
		try
		{
			return ((Il2CppSystem.Object)stringFieldInternal).ToString();
		}
		finally
		{
			((Il2CppSystem.IDisposable)stringFieldInternal).Dispose();
		}
	}

	public static JStringBinding GetStringFieldInternal(System.IntPtr obj, System.IntPtr fieldID)
	{
		GetStringFieldInternal_Injected(obj, fieldID, out var ret);
		return ret;
	}

	public static System.IntPtr GetObjectField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetObjectFieldDelegateField(obj, fieldID);
	}

	public static bool GetBooleanField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetBooleanFieldDelegateField(obj, fieldID);
	}

	public static byte GetByteField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return (byte)GetSByteField(obj, fieldID);
	}

	public static sbyte GetSByteField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetSByteFieldDelegateField(obj, fieldID);
	}

	public static char GetCharField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetCharFieldDelegateField(obj, fieldID);
	}

	public static short GetShortField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetShortFieldDelegateField(obj, fieldID);
	}

	public static int GetIntField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetIntFieldDelegateField(obj, fieldID);
	}

	public static long GetLongField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetLongFieldDelegateField(obj, fieldID);
	}

	public static float GetFloatField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetFloatFieldDelegateField(obj, fieldID);
	}

	public static double GetDoubleField(System.IntPtr obj, System.IntPtr fieldID)
	{
		return GetDoubleFieldDelegateField(obj, fieldID);
	}

	public unsafe static void SetStringField(System.IntPtr obj, System.IntPtr fieldID, string val)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(val, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(val);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetStringField_Injected(obj, fieldID, ref managedSpanWrapper);
					return;
				}
			}
			SetStringField_Injected(obj, fieldID, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void SetObjectField(System.IntPtr obj, System.IntPtr fieldID, System.IntPtr val)
	{
		SetObjectFieldDelegateField(obj, fieldID, val);
	}

	public static void SetBooleanField(System.IntPtr obj, System.IntPtr fieldID, bool val)
	{
		SetBooleanFieldDelegateField(obj, fieldID, val);
	}

	public static void SetByteField(System.IntPtr obj, System.IntPtr fieldID, byte val)
	{
		SetSByteField(obj, fieldID, (sbyte)val);
	}

	public static void SetSByteField(System.IntPtr obj, System.IntPtr fieldID, sbyte val)
	{
		SetSByteFieldDelegateField(obj, fieldID, val);
	}

	public static void SetCharField(System.IntPtr obj, System.IntPtr fieldID, char val)
	{
		SetCharFieldDelegateField(obj, fieldID, val);
	}

	public static void SetShortField(System.IntPtr obj, System.IntPtr fieldID, short val)
	{
		SetShortFieldDelegateField(obj, fieldID, val);
	}

	public static void SetIntField(System.IntPtr obj, System.IntPtr fieldID, int val)
	{
		SetIntFieldDelegateField(obj, fieldID, val);
	}

	public static void SetLongField(System.IntPtr obj, System.IntPtr fieldID, long val)
	{
		SetLongFieldDelegateField(obj, fieldID, val);
	}

	public static void SetFloatField(System.IntPtr obj, System.IntPtr fieldID, float val)
	{
		SetFloatFieldDelegateField(obj, fieldID, val);
	}

	public static void SetDoubleField(System.IntPtr obj, System.IntPtr fieldID, double val)
	{
		SetDoubleFieldDelegateField(obj, fieldID, val);
	}

	public static System.IntPtr CallStaticObjectMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticObjectMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static int CallStaticIntMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticIntMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static bool CallStaticBooleanMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticBooleanMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static short CallStaticShortMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticShortMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static byte CallStaticByteMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return (byte)CallStaticSByteMethod(clazz, methodID, args);
	}

	public static sbyte CallStaticSByteMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticSByteMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static char CallStaticCharMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticCharMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static float CallStaticFloatMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticFloatMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static double CallStaticDoubleMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticDoubleMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static long CallStaticLongMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		return CallStaticLongMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppStructArray<jvalue> args)
	{
		CallStaticVoidMethod(clazz, methodID, new Il2CppSystem.Span<jvalue>((Il2CppArrayBase<jvalue>)(object)args));
	}

	public unsafe static void CallStaticVoidMethod(System.IntPtr clazz, System.IntPtr methodID, Il2CppSystem.Span<jvalue> args)
	{
		//IL_0009: Expected O, but got Ref
		fixed (jvalue* args2 = &((Il2CppSystem.Span<jvalue>)(&args)).GetPinnableReference())
		{
			CallStaticVoidMethodUnsafe(clazz, methodID, args2);
		}
	}

	public unsafe static void CallStaticVoidMethodUnsafe(System.IntPtr clazz, System.IntPtr methodID, jvalue* args)
	{
		CallStaticVoidMethodUnsafeDelegateField(clazz, methodID, (nint)args);
	}

	public static string GetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		JStringBinding staticStringFieldInternal = GetStaticStringFieldInternal(clazz, fieldID);
		try
		{
			return ((Il2CppSystem.Object)staticStringFieldInternal).ToString();
		}
		finally
		{
			((Il2CppSystem.IDisposable)staticStringFieldInternal).Dispose();
		}
	}

	public static JStringBinding GetStaticStringFieldInternal(System.IntPtr clazz, System.IntPtr fieldID)
	{
		GetStaticStringFieldInternal_Injected(clazz, fieldID, out var ret);
		return ret;
	}

	public static System.IntPtr GetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticObjectFieldDelegateField(clazz, fieldID);
	}

	public static bool GetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticBooleanFieldDelegateField(clazz, fieldID);
	}

	public static byte GetStaticByteField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return (byte)GetStaticSByteField(clazz, fieldID);
	}

	public static sbyte GetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticSByteFieldDelegateField(clazz, fieldID);
	}

	public static char GetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticCharFieldDelegateField(clazz, fieldID);
	}

	public static short GetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticShortFieldDelegateField(clazz, fieldID);
	}

	public static int GetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticIntFieldDelegateField(clazz, fieldID);
	}

	public static long GetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticLongFieldDelegateField(clazz, fieldID);
	}

	public static float GetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticFloatFieldDelegateField(clazz, fieldID);
	}

	public static double GetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID)
	{
		return GetStaticDoubleFieldDelegateField(clazz, fieldID);
	}

	public unsafe static void SetStaticStringField(System.IntPtr clazz, System.IntPtr fieldID, string val)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(val, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(val);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetStaticStringField_Injected(clazz, fieldID, ref managedSpanWrapper);
					return;
				}
			}
			SetStaticStringField_Injected(clazz, fieldID, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void SetStaticObjectField(System.IntPtr clazz, System.IntPtr fieldID, System.IntPtr val)
	{
		SetStaticObjectFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticBooleanField(System.IntPtr clazz, System.IntPtr fieldID, bool val)
	{
		SetStaticBooleanFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticByteField(System.IntPtr clazz, System.IntPtr fieldID, byte val)
	{
		SetStaticSByteField(clazz, fieldID, (sbyte)val);
	}

	public static void SetStaticSByteField(System.IntPtr clazz, System.IntPtr fieldID, sbyte val)
	{
		SetStaticSByteFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticCharField(System.IntPtr clazz, System.IntPtr fieldID, char val)
	{
		SetStaticCharFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticShortField(System.IntPtr clazz, System.IntPtr fieldID, short val)
	{
		SetStaticShortFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticIntField(System.IntPtr clazz, System.IntPtr fieldID, int val)
	{
		SetStaticIntFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticLongField(System.IntPtr clazz, System.IntPtr fieldID, long val)
	{
		SetStaticLongFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticFloatField(System.IntPtr clazz, System.IntPtr fieldID, float val)
	{
		SetStaticFloatFieldDelegateField(clazz, fieldID, val);
	}

	public static void SetStaticDoubleField(System.IntPtr clazz, System.IntPtr fieldID, double val)
	{
		SetStaticDoubleFieldDelegateField(clazz, fieldID, val);
	}

	public static System.IntPtr ToObjectArray(Il2CppStructArray<System.IntPtr> array)
	{
		return ToObjectArray(array, Il2CppSystem.IntPtr.Zero);
	}

	public unsafe static Il2CppStructArray<System.IntPtr> FromObjectArray(System.IntPtr array)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<System.IntPtr> result;
		try
		{
			FromObjectArray_Injected(array, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<System.IntPtr> array2);
			ret.Unmarshal(ref *(Il2CppArrayBase<System.IntPtr>*)(&array2));
			result = array2;
		}
		return result;
	}

	public static System.IntPtr NewBooleanArray(int size)
	{
		return NewBooleanArrayDelegateField(size);
	}

	public static System.IntPtr NewByteArray(int size)
	{
		return NewSByteArray(size);
	}

	public static System.IntPtr NewSByteArray(int size)
	{
		return NewSByteArrayDelegateField(size);
	}

	public static System.IntPtr NewCharArray(int size)
	{
		return NewCharArrayDelegateField(size);
	}

	public static System.IntPtr NewShortArray(int size)
	{
		return NewShortArrayDelegateField(size);
	}

	public static System.IntPtr NewIntArray(int size)
	{
		return NewIntArrayDelegateField(size);
	}

	public static System.IntPtr NewLongArray(int size)
	{
		return NewLongArrayDelegateField(size);
	}

	public static System.IntPtr NewFloatArray(int size)
	{
		return NewFloatArrayDelegateField(size);
	}

	public static System.IntPtr NewDoubleArray(int size)
	{
		return NewDoubleArrayDelegateField(size);
	}

	public static bool GetBooleanArrayElement(System.IntPtr array, int index)
	{
		return GetBooleanArrayElementDelegateField(array, index);
	}

	public static byte GetByteArrayElement(System.IntPtr array, int index)
	{
		return (byte)GetSByteArrayElement(array, index);
	}

	public static sbyte GetSByteArrayElement(System.IntPtr array, int index)
	{
		return GetSByteArrayElementDelegateField(array, index);
	}

	public static char GetCharArrayElement(System.IntPtr array, int index)
	{
		return GetCharArrayElementDelegateField(array, index);
	}

	public static short GetShortArrayElement(System.IntPtr array, int index)
	{
		return GetShortArrayElementDelegateField(array, index);
	}

	public static int GetIntArrayElement(System.IntPtr array, int index)
	{
		return GetIntArrayElementDelegateField(array, index);
	}

	public static long GetLongArrayElement(System.IntPtr array, int index)
	{
		return GetLongArrayElementDelegateField(array, index);
	}

	public static float GetFloatArrayElement(System.IntPtr array, int index)
	{
		return GetFloatArrayElementDelegateField(array, index);
	}

	public static double GetDoubleArrayElement(System.IntPtr array, int index)
	{
		return GetDoubleArrayElementDelegateField(array, index);
	}

	public static void SetBooleanArrayElement(System.IntPtr array, int index, byte val)
	{
		SetBooleanArrayElement(array, index, val != 0);
	}

	public static void SetBooleanArrayElement(System.IntPtr array, int index, bool val)
	{
		SetBooleanArrayElementDelegateField(array, index, val);
	}

	public static void SetByteArrayElement(System.IntPtr array, int index, sbyte val)
	{
		SetSByteArrayElement(array, index, val);
	}

	public static void SetSByteArrayElement(System.IntPtr array, int index, sbyte val)
	{
		SetSByteArrayElementDelegateField(array, index, val);
	}

	public static void SetCharArrayElement(System.IntPtr array, int index, char val)
	{
		SetCharArrayElementDelegateField(array, index, val);
	}

	public static void SetShortArrayElement(System.IntPtr array, int index, short val)
	{
		SetShortArrayElementDelegateField(array, index, val);
	}

	public static void SetIntArrayElement(System.IntPtr array, int index, int val)
	{
		SetIntArrayElementDelegateField(array, index, val);
	}

	public static void SetLongArrayElement(System.IntPtr array, int index, long val)
	{
		SetLongArrayElementDelegateField(array, index, val);
	}

	public static void SetFloatArrayElement(System.IntPtr array, int index, float val)
	{
		SetFloatArrayElementDelegateField(array, index, val);
	}

	public static void SetDoubleArrayElement(System.IntPtr array, int index, double val)
	{
		SetDoubleArrayElementDelegateField(array, index, val);
	}

	public unsafe static System.IntPtr NewDirectByteBuffer(byte* buffer, long capacity)
	{
		return NewDirectByteBufferDelegateField((nint)buffer, capacity);
	}

	public static System.IntPtr NewDirectByteBuffer(NativeArray<byte> buffer)
	{
		return NewDirectByteBufferFromNativeArray(buffer);
	}

	public static System.IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer)
	{
		return NewDirectByteBufferFromNativeArray(buffer);
	}

	public unsafe static System.IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) where T : struct
	{
		//IL_0008: Expected O, but got Ref
		//IL_0011: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		if (!((NativeArray<T>)(&buffer)).IsCreated || ((NativeArray<T>)(&buffer)).Length <= 0)
		{
			return Il2CppSystem.IntPtr.Zero;
		}
		return NewDirectByteBuffer((byte*)buffer.GetUnsafePtr(), ((NativeArray<T>)(&buffer)).Length);
	}

	public unsafe static sbyte* GetDirectBufferAddress(System.IntPtr buffer)
	{
		return (sbyte*)GetDirectBufferAddressDelegateField(buffer);
	}

	public static long GetDirectBufferCapacity(System.IntPtr buffer)
	{
		return GetDirectBufferCapacityDelegateField(buffer);
	}

	public unsafe static NativeArray<T> GetDirectBuffer<T>(System.IntPtr buffer) where T : struct
	{
		if (buffer == Il2CppSystem.IntPtr.Zero)
		{
			return null;
		}
		sbyte* directBufferAddress = GetDirectBufferAddress(buffer);
		if (directBufferAddress == null)
		{
			return null;
		}
		long directBufferCapacity = GetDirectBufferCapacity(buffer);
		if (directBufferCapacity > int.MaxValue)
		{
			throw new Il2CppSystem.Exception(Il2CppSystem.String.Format("Direct buffer is too large ({0}) for NativeArray (max {1})", (Il2CppSystem.Object)(object)directBufferCapacity, (Il2CppSystem.Object)(object)int.MaxValue));
		}
		return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>(directBufferAddress, (int)directBufferCapacity, Allocator.None);
	}

	public static NativeArray<byte> GetDirectByteBuffer(System.IntPtr buffer)
	{
		return GetDirectBuffer<byte>(buffer);
	}

	public static NativeArray<sbyte> GetDirectSByteBuffer(System.IntPtr buffer)
	{
		return GetDirectBuffer<sbyte>(buffer);
	}

	public static System.IntPtr RegisterNativesAllocate(int length)
	{
		return RegisterNativesAllocateDelegateField(length);
	}

	public unsafe static void RegisterNativesSet(System.IntPtr natives, int idx, string name, string signature, System.IntPtr fnPtr)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//The blocks IL_002b, IL_0038, IL_0046, IL_0054, IL_0059 are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper name2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					name2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							RegisterNativesSet_Injected(natives, idx, ref name2, ref managedSpanWrapper2, fnPtr);
							return;
						}
					}
					RegisterNativesSet_Injected(natives, idx, ref name2, ref managedSpanWrapper2, fnPtr);
					return;
				}
			}
			name2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					RegisterNativesSet_Injected(natives, idx, ref name2, ref managedSpanWrapper2, fnPtr);
					return;
				}
			}
			RegisterNativesSet_Injected(natives, idx, ref name2, ref managedSpanWrapper2, fnPtr);
		}
		finally
		{
		}
	}

	public static int RegisterNativesAndFree(System.IntPtr clazz, System.IntPtr natives, int n)
	{
		return RegisterNativesAndFreeDelegateField(clazz, natives, n);
	}

	public static int UnregisterNatives(System.IntPtr clazz)
	{
		return UnregisterNativesDelegateField(clazz);
	}

	public unsafe static int ThrowNew_Injected(System.IntPtr clazz, ref ManagedSpanWrapper message)
	{
		return ThrowNew_InjectedDelegateField(clazz, (nint)Unsafe.AsPointer(ref message));
	}

	public unsafe static void FatalError_Injected(ref ManagedSpanWrapper message)
	{
		FatalError_InjectedDelegateField((nint)Unsafe.AsPointer(ref message));
	}

	public unsafe static System.IntPtr GetFieldID_Injected(System.IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig)
	{
		return GetFieldID_InjectedDelegateField(clazz, (nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref sig));
	}

	public unsafe static System.IntPtr GetStaticFieldID_Injected(System.IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig)
	{
		return GetStaticFieldID_InjectedDelegateField(clazz, (nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref sig));
	}

	public unsafe static System.IntPtr NewString_Injected(ref ManagedSpanWrapper chars)
	{
		return NewString_InjectedDelegateField((nint)Unsafe.AsPointer(ref chars));
	}

	public unsafe static System.IntPtr NewStringUTF_Injected(ref ManagedSpanWrapper bytes)
	{
		return NewStringUTF_InjectedDelegateField((nint)Unsafe.AsPointer(ref bytes));
	}

	public unsafe static void GetStringUTFChars_Injected(System.IntPtr str, out ManagedSpanWrapper ret)
	{
		GetStringUTFChars_InjectedDelegateField(str, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetStringFieldInternal_Injected(System.IntPtr obj, System.IntPtr fieldID, out JStringBinding ret)
	{
		GetStringFieldInternal_InjectedDelegateField(obj, fieldID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetStringField_Injected(System.IntPtr obj, System.IntPtr fieldID, ref ManagedSpanWrapper val)
	{
		SetStringField_InjectedDelegateField(obj, fieldID, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void GetStaticStringFieldInternal_Injected(System.IntPtr clazz, System.IntPtr fieldID, out JStringBinding ret)
	{
		GetStaticStringFieldInternal_InjectedDelegateField(clazz, fieldID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetStaticStringField_Injected(System.IntPtr clazz, System.IntPtr fieldID, ref ManagedSpanWrapper val)
	{
		SetStaticStringField_InjectedDelegateField(clazz, fieldID, (nint)Unsafe.AsPointer(ref val));
	}

	public unsafe static void FromObjectArray_Injected(System.IntPtr array, out BlittableArrayWrapper ret)
	{
		FromObjectArray_InjectedDelegateField(array, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void RegisterNativesSet_Injected(System.IntPtr natives, int idx, ref ManagedSpanWrapper name, ref ManagedSpanWrapper signature, System.IntPtr fnPtr)
	{
		RegisterNativesSet_InjectedDelegateField(natives, idx, (nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref signature), fnPtr);
	}
}
