using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class OutArrayMarshallingTests
{
	private delegate void OutArrayOfPrimitiveTypeWorks_InjectedDelegate([Out] System.IntPtr array, int value);

	private delegate void OutArrayOfStringTypeWorks_InjectedDelegate([Out] System.IntPtr array, System.IntPtr value);

	private delegate void OutArrayOfIntPtrObjectTypeWorks_InjectedDelegate([Out] System.IntPtr array, System.IntPtr value);

	private delegate void OutArrayOfNestedBlittableStructTypeWorks_InjectedDelegate([Out] System.IntPtr array, [In] System.IntPtr value);

	private static readonly OutArrayOfPrimitiveTypeWorks_InjectedDelegate OutArrayOfPrimitiveTypeWorks_InjectedDelegateField = IL2CPP.ResolveICall<OutArrayOfPrimitiveTypeWorks_InjectedDelegate>("UnityEngine.OutArrayMarshallingTests::OutArrayOfPrimitiveTypeWorks_Injected");

	private static readonly OutArrayOfStringTypeWorks_InjectedDelegate OutArrayOfStringTypeWorks_InjectedDelegateField = IL2CPP.ResolveICall<OutArrayOfStringTypeWorks_InjectedDelegate>("UnityEngine.OutArrayMarshallingTests::OutArrayOfStringTypeWorks_Injected");

	private static readonly OutArrayOfIntPtrObjectTypeWorks_InjectedDelegate OutArrayOfIntPtrObjectTypeWorks_InjectedDelegateField = IL2CPP.ResolveICall<OutArrayOfIntPtrObjectTypeWorks_InjectedDelegate>("UnityEngine.OutArrayMarshallingTests::OutArrayOfIntPtrObjectTypeWorks_Injected");

	private static readonly OutArrayOfNestedBlittableStructTypeWorks_InjectedDelegate OutArrayOfNestedBlittableStructTypeWorks_InjectedDelegateField = IL2CPP.ResolveICall<OutArrayOfNestedBlittableStructTypeWorks_InjectedDelegate>("UnityEngine.OutArrayMarshallingTests::OutArrayOfNestedBlittableStructTypeWorks_Injected");

	public static void OutArrayOfPrimitiveTypeWorks([Out] Il2CppStructArray<int> array, int value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static void OutArrayOfStringTypeWorks([Out] Il2CppStringArray array, string value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = value.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					OutArrayOfStringTypeWorks_Injected(array, ref managedSpanWrapper);
					return;
				}
			}
			OutArrayOfStringTypeWorks_Injected(array, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void OutArrayOfIntPtrObjectTypeWorks([Out] Il2CppReferenceArray<MyIntPtrObject> array, MyIntPtrObject value)
	{
		OutArrayOfIntPtrObjectTypeWorks_Injected(array, (value == null) ? ((System.IntPtr)0) : MyIntPtrObject.BindingsMarshaller.ConvertToNative(value));
	}

	public static void OutArrayOfNestedBlittableStructTypeWorks([Out] Il2CppStructArray<StructNestedBlittable> array, StructNestedBlittable value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static void OutArrayOfPrimitiveTypeWorks_Injected(out BlittableArrayWrapper array, int value)
	{
		OutArrayOfPrimitiveTypeWorks_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array), value);
	}

	public unsafe static void OutArrayOfStringTypeWorks_Injected([Out] Il2CppStringArray array, ref ManagedSpanWrapper value)
	{
		OutArrayOfStringTypeWorks_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public static void OutArrayOfIntPtrObjectTypeWorks_Injected([Out] Il2CppReferenceArray<MyIntPtrObject> array, System.IntPtr value)
	{
		OutArrayOfIntPtrObjectTypeWorks_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array), value);
	}

	public unsafe static void OutArrayOfNestedBlittableStructTypeWorks_Injected(out BlittableArrayWrapper array, [In] ref StructNestedBlittable value)
	{
		OutArrayOfNestedBlittableStructTypeWorks_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref array), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}
}
