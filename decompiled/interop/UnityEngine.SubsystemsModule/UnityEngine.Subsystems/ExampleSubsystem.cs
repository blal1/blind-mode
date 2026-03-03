using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.Subsystems;

public class ExampleSubsystem : IntegratedSubsystem<ExampleSubsystemDescriptor>
{
	public new static class BindingsMarshaller
	{
	}

	private delegate void PrintExample_InjectedDelegate(IntPtr _unity_self);

	private delegate bool GetBool_InjectedDelegate(IntPtr _unity_self);

	private static readonly PrintExample_InjectedDelegate PrintExample_InjectedDelegateField = IL2CPP.ResolveICall<PrintExample_InjectedDelegate>("UnityEngine.Subsystems.ExampleSubsystem::PrintExample_Injected");

	private static readonly GetBool_InjectedDelegate GetBool_InjectedDelegateField = IL2CPP.ResolveICall<GetBool_InjectedDelegate>("UnityEngine.Subsystems.ExampleSubsystem::GetBool_Injected");

	public void PrintExample()
	{
		IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		PrintExample_Injected(intPtr);
	}

	public bool GetBool()
	{
		IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetBool_Injected(intPtr);
	}

	public static void PrintExample_Injected(IntPtr _unity_self)
	{
		PrintExample_InjectedDelegateField(_unity_self);
	}

	public static bool GetBool_Injected(IntPtr _unity_self)
	{
		return GetBool_InjectedDelegateField(_unity_self);
	}
}
