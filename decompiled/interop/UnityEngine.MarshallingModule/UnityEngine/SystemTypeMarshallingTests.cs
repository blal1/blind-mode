using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class SystemTypeMarshallingTests
{
	private delegate System.IntPtr CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtrDelegate(System.IntPtr param);

	private delegate System.IntPtr CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityTypeDelegate(System.IntPtr param);

	private delegate System.IntPtr CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtrDelegate(System.IntPtr param);

	private delegate System.IntPtr CanUnmarshallScriptingSystemTypeObjectPtrToSystemTypeDelegate();

	private delegate System.IntPtr CanUnmarshallUnityTypeToSystemTypeDelegate();

	private delegate System.IntPtr CanUnmarshallScriptingClassPtrToSystemTypeDelegate();

	private delegate System.IntPtr CanUnmarshallScriptingArrayPtrToSystemTypeArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfUnityTypeToSystemTypeArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArrayDelegate();

	private delegate void CanMarshallSystemTypeArgumentToScriptingClassPtr_InjectedDelegate(System.IntPtr param, [Out] System.IntPtr ret);

	private static readonly CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtrDelegate CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtrDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtrDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtr");

	private static readonly CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityTypeDelegate CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityTypeDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityTypeDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityType");

	private static readonly CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtrDelegate CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtrDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtrDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtr");

	private static readonly CanUnmarshallScriptingSystemTypeObjectPtrToSystemTypeDelegate CanUnmarshallScriptingSystemTypeObjectPtrToSystemTypeDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingSystemTypeObjectPtrToSystemTypeDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallScriptingSystemTypeObjectPtrToSystemType");

	private static readonly CanUnmarshallUnityTypeToSystemTypeDelegate CanUnmarshallUnityTypeToSystemTypeDelegateField = IL2CPP.ResolveICall<CanUnmarshallUnityTypeToSystemTypeDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallUnityTypeToSystemType");

	private static readonly CanUnmarshallScriptingClassPtrToSystemTypeDelegate CanUnmarshallScriptingClassPtrToSystemTypeDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingClassPtrToSystemTypeDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallScriptingClassPtrToSystemType");

	private static readonly CanUnmarshallScriptingArrayPtrToSystemTypeArrayDelegate CanUnmarshallScriptingArrayPtrToSystemTypeArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingArrayPtrToSystemTypeArrayDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallScriptingArrayPtrToSystemTypeArray");

	private static readonly CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArrayDelegate CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArrayDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArray");

	private static readonly CanUnmarshallArrayOfUnityTypeToSystemTypeArrayDelegate CanUnmarshallArrayOfUnityTypeToSystemTypeArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfUnityTypeToSystemTypeArrayDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallArrayOfUnityTypeToSystemTypeArray");

	private static readonly CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArrayDelegate CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArrayDelegate>("UnityEngine.SystemTypeMarshallingTests::CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArray");

	private static readonly CanMarshallSystemTypeArgumentToScriptingClassPtr_InjectedDelegate CanMarshallSystemTypeArgumentToScriptingClassPtr_InjectedDelegateField = IL2CPP.ResolveICall<CanMarshallSystemTypeArgumentToScriptingClassPtr_InjectedDelegate>("UnityEngine.SystemTypeMarshallingTests::CanMarshallSystemTypeArgumentToScriptingClassPtr_Injected");

	public static string CanMarshallSystemTypeArgumentToScriptingClassPtr(Type param)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			CanMarshallSystemTypeArgumentToScriptingClassPtr_Injected(param, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static Il2CppStringArray CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtr(Il2CppReferenceArray<Type> param)
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingSystemTypeObjectPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityType(Il2CppReferenceArray<Type> param)
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfUnityTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtr(Il2CppReferenceArray<Type> param)
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfSystemTypeArgumentToDynamicArrayOfScriptingClassPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Type CanUnmarshallScriptingSystemTypeObjectPtrToSystemType()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingSystemTypeObjectPtrToSystemTypeDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
	}

	public static Type CanUnmarshallUnityTypeToSystemType()
	{
		System.IntPtr intPtr = CanUnmarshallUnityTypeToSystemTypeDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
	}

	public static Type CanUnmarshallScriptingClassPtrToSystemType()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingClassPtrToSystemTypeDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Type>(intPtr) : null;
	}

	public static Il2CppReferenceArray<Type> CanUnmarshallScriptingArrayPtrToSystemTypeArray()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingArrayPtrToSystemTypeArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<Type> CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfScriptingSystemTypeObjectPtrToSystemTypeArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<Type> CanUnmarshallArrayOfUnityTypeToSystemTypeArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfUnityTypeToSystemTypeArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<Type> CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfScriptingClassPtrToSystemTypeArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr) : null;
	}

	public unsafe static void CanMarshallSystemTypeArgumentToScriptingClassPtr_Injected(Type param, out ManagedSpanWrapper ret)
	{
		CanMarshallSystemTypeArgumentToScriptingClassPtr_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
