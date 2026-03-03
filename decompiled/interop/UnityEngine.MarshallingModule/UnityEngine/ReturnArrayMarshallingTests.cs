using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public static class ReturnArrayMarshallingTests
{
	private delegate System.IntPtr ReturnArrayOfPrimitiveTypeWorks_Float1DDelegate();

	private static readonly ReturnArrayOfPrimitiveTypeWorks_Float1DDelegate ReturnArrayOfPrimitiveTypeWorks_Float1DDelegateField = IL2CPP.ResolveICall<ReturnArrayOfPrimitiveTypeWorks_Float1DDelegate>("UnityEngine.ReturnArrayMarshallingTests::ReturnArrayOfPrimitiveTypeWorks_Float1D");

	public static Il2CppStructArray<float> ReturnArrayOfPrimitiveTypeWorks_Float1D()
	{
		System.IntPtr intPtr = ReturnArrayOfPrimitiveTypeWorks_Float1DDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
	}
}
