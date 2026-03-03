using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class SystemReflectionFieldInfoMarshallingTests
{
	private delegate System.IntPtr CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtrDelegate(System.IntPtr param);

	private delegate System.IntPtr CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtrDelegate(System.IntPtr param);

	private delegate System.IntPtr CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfoDelegate();

	private delegate System.IntPtr CanUnmarshallScriptingFieldPtrToFieldInfoDelegate();

	private delegate System.IntPtr CanUnmarshallScriptingArrayPtrToFieldInfoArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArrayDelegate();

	private delegate void CanMarshallFieldInfoArgumentToScriptingFieldPtr_InjectedDelegate(System.IntPtr param, [Out] System.IntPtr ret);

	private static readonly CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtrDelegate CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtrDelegateField = IL2CPP.ResolveICall<CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtrDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtr");

	private static readonly CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtrDelegate CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtrDelegateField = IL2CPP.ResolveICall<CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtrDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtr");

	private static readonly CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfoDelegate CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfoDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfoDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfo");

	private static readonly CanUnmarshallScriptingFieldPtrToFieldInfoDelegate CanUnmarshallScriptingFieldPtrToFieldInfoDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingFieldPtrToFieldInfoDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanUnmarshallScriptingFieldPtrToFieldInfo");

	private static readonly CanUnmarshallScriptingArrayPtrToFieldInfoArrayDelegate CanUnmarshallScriptingArrayPtrToFieldInfoArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingArrayPtrToFieldInfoArrayDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanUnmarshallScriptingArrayPtrToFieldInfoArray");

	private static readonly CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArrayDelegate CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArrayDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArray");

	private static readonly CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArrayDelegate CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArrayDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArray");

	private static readonly CanMarshallFieldInfoArgumentToScriptingFieldPtr_InjectedDelegate CanMarshallFieldInfoArgumentToScriptingFieldPtr_InjectedDelegateField = IL2CPP.ResolveICall<CanMarshallFieldInfoArgumentToScriptingFieldPtr_InjectedDelegate>("UnityEngine.SystemReflectionFieldInfoMarshallingTests::CanMarshallFieldInfoArgumentToScriptingFieldPtr_Injected");

	public static string CanMarshallFieldInfoArgumentToScriptingFieldPtr(FieldInfo param)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			CanMarshallFieldInfoArgumentToScriptingFieldPtr_Injected(param, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static Il2CppStringArray CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtr(Il2CppReferenceArray<FieldInfo> param)
	{
		System.IntPtr intPtr = CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldInfoObjectPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtr(Il2CppReferenceArray<FieldInfo> param)
	{
		System.IntPtr intPtr = CanMarshallArrayOfFieldInfoArgumentToDynamicArrayOfScriptingFieldPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static FieldInfo CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfo()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingFieldInfoObjectPtrToFieldInfoDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr) : null;
	}

	public static FieldInfo CanUnmarshallScriptingFieldPtrToFieldInfo()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingFieldPtrToFieldInfoDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr) : null;
	}

	public static Il2CppReferenceArray<FieldInfo> CanUnmarshallScriptingArrayPtrToFieldInfoArray()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingArrayPtrToFieldInfoArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<FieldInfo> CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfScriptingFieldInfoObjectPtrToFieldInfoArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<FieldInfo> CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfScriptingFieldPtrToFieldInfoArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FieldInfo>>(intPtr) : null;
	}

	public unsafe static void CanMarshallFieldInfoArgumentToScriptingFieldPtr_Injected(FieldInfo param, out ManagedSpanWrapper ret)
	{
		CanMarshallFieldInfoArgumentToScriptingFieldPtr_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
