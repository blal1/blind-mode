using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public class IntPtrObjectTests
{
	private delegate void ParameterIntPtrObjectDynamicArrayDelegate(System.IntPtr param);

	private delegate System.IntPtr ReturnIntPtrObjectDynamicArrayDelegate();

	private delegate void ParameterIntPtrObject_InjectedDelegate(System.IntPtr param);

	private delegate System.IntPtr ReturnIntPtrObject_InjectedDelegate(int value);

	private static readonly ParameterIntPtrObjectDynamicArrayDelegate ParameterIntPtrObjectDynamicArrayDelegateField = IL2CPP.ResolveICall<ParameterIntPtrObjectDynamicArrayDelegate>("UnityEngine.IntPtrObjectTests::ParameterIntPtrObjectDynamicArray");

	private static readonly ReturnIntPtrObjectDynamicArrayDelegate ReturnIntPtrObjectDynamicArrayDelegateField = IL2CPP.ResolveICall<ReturnIntPtrObjectDynamicArrayDelegate>("UnityEngine.IntPtrObjectTests::ReturnIntPtrObjectDynamicArray");

	private static readonly ParameterIntPtrObject_InjectedDelegate ParameterIntPtrObject_InjectedDelegateField = IL2CPP.ResolveICall<ParameterIntPtrObject_InjectedDelegate>("UnityEngine.IntPtrObjectTests::ParameterIntPtrObject_Injected");

	private static readonly ReturnIntPtrObject_InjectedDelegate ReturnIntPtrObject_InjectedDelegateField = IL2CPP.ResolveICall<ReturnIntPtrObject_InjectedDelegate>("UnityEngine.IntPtrObjectTests::ReturnIntPtrObject_Injected");

	public static void ParameterIntPtrObject(MyIntPtrObject param)
	{
		ParameterIntPtrObject_Injected((param == null) ? ((System.IntPtr)0) : MyIntPtrObject.BindingsMarshaller.ConvertToNative(param));
	}

	public static void ParameterIntPtrObjectDynamicArray(Il2CppReferenceArray<MyIntPtrObject> param)
	{
		ParameterIntPtrObjectDynamicArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static Il2CppReferenceArray<MyIntPtrObject> ReturnIntPtrObjectDynamicArray()
	{
		System.IntPtr intPtr = ReturnIntPtrObjectDynamicArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MyIntPtrObject>>(intPtr) : null;
	}

	public static MyIntPtrObject ReturnIntPtrObject(int value)
	{
		System.IntPtr intPtr = ReturnIntPtrObject_Injected(value);
		return (intPtr == (System.IntPtr)0) ? null : MyIntPtrObject.BindingsMarshaller.ConvertToManaged(intPtr);
	}

	public static void ParameterIntPtrObject_Injected(System.IntPtr param)
	{
		ParameterIntPtrObject_InjectedDelegateField(param);
	}

	public static System.IntPtr ReturnIntPtrObject_Injected(int value)
	{
		return ReturnIntPtrObject_InjectedDelegateField(value);
	}
}
