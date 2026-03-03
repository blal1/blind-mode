using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class BoolStructTests
{
	private delegate void ParameterStructWith8ByteAndBoolFieldsArray_InjectedDelegate(System.IntPtr param);

	private static readonly ParameterStructWith8ByteAndBoolFieldsArray_InjectedDelegate ParameterStructWith8ByteAndBoolFieldsArray_InjectedDelegateField = IL2CPP.ResolveICall<ParameterStructWith8ByteAndBoolFieldsArray_InjectedDelegate>("UnityEngine.BoolStructTests::ParameterStructWith8ByteAndBoolFieldsArray_Injected");

	public unsafe static void ParameterStructWith8ByteAndBoolFieldsArray_Injected(ref ManagedSpanWrapper param)
	{
		ParameterStructWith8ByteAndBoolFieldsArray_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref param));
	}
}
