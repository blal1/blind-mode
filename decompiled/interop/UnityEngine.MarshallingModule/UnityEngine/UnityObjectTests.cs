using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class UnityObjectTests
{
	private delegate void ParameterUnityObjectDynamicArrayDelegate(System.IntPtr param);

	private delegate void ParameterUnityObjectPPtrDynamicArrayDelegate(System.IntPtr param);

	private delegate System.IntPtr ReturnUnityObjectDynamicArrayDelegate();

	private delegate System.IntPtr ReturnUnityObjectPPtrDynamicArrayDelegate();

	private delegate void ParameterUnityObject_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterUnityObjectByRef_InjectedDelegate(System.IntPtr param);

	private delegate void ParameterUnityObjectPPtr_InjectedDelegate(System.IntPtr param);

	private delegate System.IntPtr ReturnUnityObject_InjectedDelegate();

	private delegate System.IntPtr ReturnInUnityObject_InjectedDelegate(System.IntPtr obj);

	private delegate System.IntPtr ReturnUnityObjectFakeNull_InjectedDelegate();

	private delegate System.IntPtr ReturnUnassignedErrorObject_InjectedDelegate();

	private delegate System.IntPtr ReturnUnityObjectPPtr_InjectedDelegate();

	private static readonly ParameterUnityObjectDynamicArrayDelegate ParameterUnityObjectDynamicArrayDelegateField = IL2CPP.ResolveICall<ParameterUnityObjectDynamicArrayDelegate>("UnityEngine.UnityObjectTests::ParameterUnityObjectDynamicArray");

	private static readonly ParameterUnityObjectPPtrDynamicArrayDelegate ParameterUnityObjectPPtrDynamicArrayDelegateField = IL2CPP.ResolveICall<ParameterUnityObjectPPtrDynamicArrayDelegate>("UnityEngine.UnityObjectTests::ParameterUnityObjectPPtrDynamicArray");

	private static readonly ReturnUnityObjectDynamicArrayDelegate ReturnUnityObjectDynamicArrayDelegateField = IL2CPP.ResolveICall<ReturnUnityObjectDynamicArrayDelegate>("UnityEngine.UnityObjectTests::ReturnUnityObjectDynamicArray");

	private static readonly ReturnUnityObjectPPtrDynamicArrayDelegate ReturnUnityObjectPPtrDynamicArrayDelegateField = IL2CPP.ResolveICall<ReturnUnityObjectPPtrDynamicArrayDelegate>("UnityEngine.UnityObjectTests::ReturnUnityObjectPPtrDynamicArray");

	private static readonly ParameterUnityObject_InjectedDelegate ParameterUnityObject_InjectedDelegateField = IL2CPP.ResolveICall<ParameterUnityObject_InjectedDelegate>("UnityEngine.UnityObjectTests::ParameterUnityObject_Injected");

	private static readonly ParameterUnityObjectByRef_InjectedDelegate ParameterUnityObjectByRef_InjectedDelegateField = IL2CPP.ResolveICall<ParameterUnityObjectByRef_InjectedDelegate>("UnityEngine.UnityObjectTests::ParameterUnityObjectByRef_Injected");

	private static readonly ParameterUnityObjectPPtr_InjectedDelegate ParameterUnityObjectPPtr_InjectedDelegateField = IL2CPP.ResolveICall<ParameterUnityObjectPPtr_InjectedDelegate>("UnityEngine.UnityObjectTests::ParameterUnityObjectPPtr_Injected");

	private static readonly ReturnUnityObject_InjectedDelegate ReturnUnityObject_InjectedDelegateField = IL2CPP.ResolveICall<ReturnUnityObject_InjectedDelegate>("UnityEngine.UnityObjectTests::ReturnUnityObject_Injected");

	private static readonly ReturnInUnityObject_InjectedDelegate ReturnInUnityObject_InjectedDelegateField = IL2CPP.ResolveICall<ReturnInUnityObject_InjectedDelegate>("UnityEngine.UnityObjectTests::ReturnInUnityObject_Injected");

	private static readonly ReturnUnityObjectFakeNull_InjectedDelegate ReturnUnityObjectFakeNull_InjectedDelegateField = IL2CPP.ResolveICall<ReturnUnityObjectFakeNull_InjectedDelegate>("UnityEngine.UnityObjectTests::ReturnUnityObjectFakeNull_Injected");

	private static readonly ReturnUnassignedErrorObject_InjectedDelegate ReturnUnassignedErrorObject_InjectedDelegateField = IL2CPP.ResolveICall<ReturnUnassignedErrorObject_InjectedDelegate>("UnityEngine.UnityObjectTests::ReturnUnassignedErrorObject_Injected");

	private static readonly ReturnUnityObjectPPtr_InjectedDelegate ReturnUnityObjectPPtr_InjectedDelegateField = IL2CPP.ResolveICall<ReturnUnityObjectPPtr_InjectedDelegate>("UnityEngine.UnityObjectTests::ReturnUnityObjectPPtr_Injected");

	public static void ParameterUnityObject(MarshallingTestObject param)
	{
		ParameterUnityObject_Injected(Object.MarshalledUnityObject.Marshal(param));
	}

	public static void ParameterUnityObjectByRef(ref MarshallingTestObject param)
	{
		ParameterUnityObjectByRef_Injected(Object.MarshalledUnityObject.Marshal(param));
	}

	public static void ParameterUnityObjectPPtr(MarshallingTestObject param)
	{
		ParameterUnityObjectPPtr_Injected(Object.MarshalledUnityObject.Marshal(param));
	}

	public static void ParameterUnityObjectDynamicArray(Il2CppReferenceArray<MarshallingTestObject> param)
	{
		ParameterUnityObjectDynamicArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static void ParameterUnityObjectPPtrDynamicArray(Il2CppReferenceArray<MarshallingTestObject> param)
	{
		ParameterUnityObjectPPtrDynamicArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static MarshallingTestObject ReturnUnityObject()
	{
		return Unmarshal.UnmarshalUnityObject<MarshallingTestObject>(ReturnUnityObject_Injected());
	}

	public static MarshallingTestObject ReturnInUnityObject(MarshallingTestObject obj)
	{
		return Unmarshal.UnmarshalUnityObject<MarshallingTestObject>(ReturnInUnityObject_Injected(Object.MarshalledUnityObject.Marshal(obj)));
	}

	public static MarshallingTestObject ReturnUnityObjectFakeNull()
	{
		return Unmarshal.UnmarshalUnityObject<MarshallingTestObject>(ReturnUnityObjectFakeNull_Injected());
	}

	public static MarshallingTestObject ReturnUnassignedErrorObject()
	{
		return Unmarshal.UnmarshalUnityObject<MarshallingTestObject>(ReturnUnassignedErrorObject_Injected());
	}

	public static MarshallingTestObject ReturnUnityObjectPPtr()
	{
		return Unmarshal.UnmarshalUnityObject<MarshallingTestObject>(ReturnUnityObjectPPtr_Injected());
	}

	public static Il2CppReferenceArray<MarshallingTestObject> ReturnUnityObjectDynamicArray()
	{
		System.IntPtr intPtr = ReturnUnityObjectDynamicArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MarshallingTestObject>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MarshallingTestObject> ReturnUnityObjectPPtrDynamicArray()
	{
		System.IntPtr intPtr = ReturnUnityObjectPPtrDynamicArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MarshallingTestObject>>(intPtr) : null;
	}

	public static void ParameterUnityObject_Injected(System.IntPtr param)
	{
		ParameterUnityObject_InjectedDelegateField(param);
	}

	public static void ParameterUnityObjectByRef_Injected(System.IntPtr param)
	{
		ParameterUnityObjectByRef_InjectedDelegateField(param);
	}

	public static void ParameterUnityObjectPPtr_Injected(System.IntPtr param)
	{
		ParameterUnityObjectPPtr_InjectedDelegateField(param);
	}

	public static System.IntPtr ReturnUnityObject_Injected()
	{
		return ReturnUnityObject_InjectedDelegateField();
	}

	public static System.IntPtr ReturnInUnityObject_Injected(System.IntPtr obj)
	{
		return ReturnInUnityObject_InjectedDelegateField(obj);
	}

	public static System.IntPtr ReturnUnityObjectFakeNull_Injected()
	{
		return ReturnUnityObjectFakeNull_InjectedDelegateField();
	}

	public static System.IntPtr ReturnUnassignedErrorObject_Injected()
	{
		return ReturnUnassignedErrorObject_InjectedDelegateField();
	}

	public static System.IntPtr ReturnUnityObjectPPtr_Injected()
	{
		return ReturnUnityObjectPPtr_InjectedDelegateField();
	}
}
