using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public class NonBlittableStructTests
{
	private delegate void CanMarshalManagedObjectToStructDelegate(System.IntPtr param);

	private delegate void CanMarshalOutManagedObjectToStructDelegate([Out] System.IntPtr param);

	private delegate void CanMarshalNativeAsStructArrayDelegate(System.IntPtr param);

	private delegate System.IntPtr CanUnmarshalManagedObjectFromStructDelegate();

	private delegate System.IntPtr CanUnmarshalNativeAsStructArrayDelegate();

	private static readonly CanMarshalManagedObjectToStructDelegate CanMarshalManagedObjectToStructDelegateField = IL2CPP.ResolveICall<CanMarshalManagedObjectToStructDelegate>("UnityEngine.NonBlittableStructTests::CanMarshalManagedObjectToStruct");

	private static readonly CanMarshalOutManagedObjectToStructDelegate CanMarshalOutManagedObjectToStructDelegateField = IL2CPP.ResolveICall<CanMarshalOutManagedObjectToStructDelegate>("UnityEngine.NonBlittableStructTests::CanMarshalOutManagedObjectToStruct");

	private static readonly CanMarshalNativeAsStructArrayDelegate CanMarshalNativeAsStructArrayDelegateField = IL2CPP.ResolveICall<CanMarshalNativeAsStructArrayDelegate>("UnityEngine.NonBlittableStructTests::CanMarshalNativeAsStructArray");

	private static readonly CanUnmarshalManagedObjectFromStructDelegate CanUnmarshalManagedObjectFromStructDelegateField = IL2CPP.ResolveICall<CanUnmarshalManagedObjectFromStructDelegate>("UnityEngine.NonBlittableStructTests::CanUnmarshalManagedObjectFromStruct");

	private static readonly CanUnmarshalNativeAsStructArrayDelegate CanUnmarshalNativeAsStructArrayDelegateField = IL2CPP.ResolveICall<CanUnmarshalNativeAsStructArrayDelegate>("UnityEngine.NonBlittableStructTests::CanUnmarshalNativeAsStructArray");

	public static void CanMarshalManagedObjectToStruct(ClassToStruct param)
	{
		CanMarshalManagedObjectToStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static void CanMarshalOutManagedObjectToStruct([Out] ClassToStruct param)
	{
		CanMarshalOutManagedObjectToStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static void CanMarshalNativeAsStructArray(Il2CppReferenceArray<ClassToStruct> param)
	{
		CanMarshalNativeAsStructArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param));
	}

	public static ClassToStruct CanUnmarshalManagedObjectFromStruct()
	{
		System.IntPtr intPtr = CanUnmarshalManagedObjectFromStructDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClassToStruct>(intPtr) : null;
	}

	public static Il2CppReferenceArray<ClassToStruct> CanUnmarshalNativeAsStructArray()
	{
		System.IntPtr intPtr = CanUnmarshalNativeAsStructArrayDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClassToStruct>>(intPtr) : null;
	}
}
