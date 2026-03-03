using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public class ManagedObjectTests
{
	private delegate System.IntPtr ParameterManagedObjectDelegate(System.IntPtr param);

	private delegate System.IntPtr ReturnNullManagedObjectArrayDelegate();

	private delegate System.IntPtr ParameterManagedObjectVectorDelegate(System.IntPtr param);

	private static readonly ParameterManagedObjectDelegate ParameterManagedObjectDelegateField = IL2CPP.ResolveICall<ParameterManagedObjectDelegate>("UnityEngine.ManagedObjectTests::ParameterManagedObject");

	private static readonly ReturnNullManagedObjectArrayDelegate ReturnNullManagedObjectArrayDelegateField = IL2CPP.ResolveICall<ReturnNullManagedObjectArrayDelegate>("UnityEngine.ManagedObjectTests::ReturnNullManagedObjectArray");

	private static readonly ParameterManagedObjectVectorDelegate ParameterManagedObjectVectorDelegateField = IL2CPP.ResolveICall<ParameterManagedObjectVectorDelegate>("UnityEngine.ManagedObjectTests::ParameterManagedObjectVector");

	public static MyManagedObject ParameterManagedObject(MyManagedObject param)
	{
		System.IntPtr intPtr = ParameterManagedObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MyManagedObject>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MyManagedObject> ReturnNullManagedObjectArray()
	{
		System.IntPtr intPtr = ReturnNullManagedObjectArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MyManagedObject>>(intPtr) : null;
	}

	public static Il2CppReferenceArray<MyManagedObject> ParameterManagedObjectVector(Il2CppReferenceArray<MyManagedObject> param)
	{
		System.IntPtr intPtr = ParameterManagedObjectVectorDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MyManagedObject>>(intPtr) : null;
	}
}
