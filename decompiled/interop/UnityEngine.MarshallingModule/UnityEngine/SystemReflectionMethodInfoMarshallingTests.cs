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

public static class SystemReflectionMethodInfoMarshallingTests
{
	private delegate System.IntPtr CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtrDelegate(System.IntPtr param);

	private delegate System.IntPtr CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtrDelegate(System.IntPtr param);

	private delegate System.IntPtr CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfoDelegate();

	private delegate System.IntPtr CanUnmarshallScriptingMethodPtrToMethodInfoDelegate();

	private delegate System.IntPtr CanUnmarshallScriptingArrayPtrToMethodInfoArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArrayDelegate();

	private delegate System.IntPtr CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArrayDelegate();

	private delegate void CanMarshallMethodInfoArgumentToScriptingMethodPtr_InjectedDelegate(System.IntPtr param, [Out] System.IntPtr ret);

	private static readonly CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtrDelegate CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtrDelegateField = IL2CPP.ResolveICall<CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtrDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtr");

	private static readonly CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtrDelegate CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtrDelegateField = IL2CPP.ResolveICall<CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtrDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtr");

	private static readonly CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfoDelegate CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfoDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfoDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfo");

	private static readonly CanUnmarshallScriptingMethodPtrToMethodInfoDelegate CanUnmarshallScriptingMethodPtrToMethodInfoDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingMethodPtrToMethodInfoDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanUnmarshallScriptingMethodPtrToMethodInfo");

	private static readonly CanUnmarshallScriptingArrayPtrToMethodInfoArrayDelegate CanUnmarshallScriptingArrayPtrToMethodInfoArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallScriptingArrayPtrToMethodInfoArrayDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanUnmarshallScriptingArrayPtrToMethodInfoArray");

	private static readonly CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArrayDelegate CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArrayDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArray");

	private static readonly CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArrayDelegate CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArrayDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArray");

	private static readonly CanMarshallMethodInfoArgumentToScriptingMethodPtr_InjectedDelegate CanMarshallMethodInfoArgumentToScriptingMethodPtr_InjectedDelegateField = IL2CPP.ResolveICall<CanMarshallMethodInfoArgumentToScriptingMethodPtr_InjectedDelegate>("UnityEngine.SystemReflectionMethodInfoMarshallingTests::CanMarshallMethodInfoArgumentToScriptingMethodPtr_Injected");

	public static string CanMarshallMethodInfoArgumentToScriptingMethodPtr(MethodInfo param)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			CanMarshallMethodInfoArgumentToScriptingMethodPtr_Injected(param, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static Il2CppStringArray CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtr(Il2CppReferenceArray<MethodInfo> param)
	{
		System.IntPtr intPtr = CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodInfoObjectPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static Il2CppStringArray CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtr(Il2CppReferenceArray<MethodInfo> param)
	{
		System.IntPtr intPtr = CanMarshallArrayOfMethodInfoArgumentToDynamicArrayOfScriptingMethodPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static MethodInfo CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfo()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingMethodInfoObjectPtrToMethodInfoDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr) : null;
	}

	public static MethodInfo CanUnmarshallScriptingMethodPtrToMethodInfo()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingMethodPtrToMethodInfoDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MethodInfo> CanUnmarshallScriptingArrayPtrToMethodInfoArray()
	{
		System.IntPtr intPtr = CanUnmarshallScriptingArrayPtrToMethodInfoArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MethodInfo> CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfScriptingMethodInfoObjectPtrToMethodInfoArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MethodInfo> CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArray()
	{
		System.IntPtr intPtr = CanUnmarshallArrayOfScriptingMethodPtrToMethodInfoArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr) : null;
	}

	public unsafe static void CanMarshallMethodInfoArgumentToScriptingMethodPtr_Injected(MethodInfo param, out ManagedSpanWrapper ret)
	{
		CanMarshallMethodInfoArgumentToScriptingMethodPtr_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
