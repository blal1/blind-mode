using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class EnumTests
{
	private delegate void ParameterDynamicArrayEnum_InjectedDelegate(System.IntPtr enumArray);

	private delegate void ParameterOutDynamicArrayEnum_InjectedDelegate([Out] System.IntPtr enumArray);

	private static readonly ParameterDynamicArrayEnum_InjectedDelegate ParameterDynamicArrayEnum_InjectedDelegateField = IL2CPP.ResolveICall<ParameterDynamicArrayEnum_InjectedDelegate>("UnityEngine.EnumTests::ParameterDynamicArrayEnum_Injected");

	private static readonly ParameterOutDynamicArrayEnum_InjectedDelegate ParameterOutDynamicArrayEnum_InjectedDelegateField = IL2CPP.ResolveICall<ParameterOutDynamicArrayEnum_InjectedDelegate>("UnityEngine.EnumTests::ParameterOutDynamicArrayEnum_Injected");

	public unsafe static void ParameterDynamicArrayEnum(Il2CppStructArray<SomeEnum> enumArray)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		//IL_001b: Expected O, but got Ref
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Span<SomeEnum> span);
		((Span<SomeEnum>)(&span))._002Ector((Il2CppArrayBase<SomeEnum>)(object)enumArray);
		fixed (SomeEnum* begin = &((Span<SomeEnum>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper enumArray2 = new ManagedSpanWrapper(begin, ((Span<SomeEnum>)(&span)).Length);
			ParameterDynamicArrayEnum_Injected(ref enumArray2);
		}
	}

	public static void ParameterOutDynamicArrayEnum([Out] Il2CppStructArray<SomeEnum> enumArray)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public unsafe static void ParameterDynamicArrayEnum_Injected(ref ManagedSpanWrapper enumArray)
	{
		ParameterDynamicArrayEnum_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref enumArray));
	}

	public unsafe static void ParameterOutDynamicArrayEnum_Injected(out BlittableArrayWrapper enumArray)
	{
		ParameterOutDynamicArrayEnum_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref enumArray));
	}
}
