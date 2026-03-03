using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.Subsystems;

public class ExampleSubsystemDescriptor : IntegratedSubsystemDescriptor<ExampleSubsystem>
{
	public static class BindingsMarshaller
	{
	}

	private delegate bool get_supportsEditorMode_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_disableBackbufferMSAA_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_stereoscopicBackbuffer_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_usePBufferEGL_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_supportsEditorMode_InjectedDelegate get_supportsEditorMode_InjectedDelegateField = IL2CPP.ResolveICall<get_supportsEditorMode_InjectedDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_supportsEditorMode_Injected");

	private static readonly get_disableBackbufferMSAA_InjectedDelegate get_disableBackbufferMSAA_InjectedDelegateField = IL2CPP.ResolveICall<get_disableBackbufferMSAA_InjectedDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_disableBackbufferMSAA_Injected");

	private static readonly get_stereoscopicBackbuffer_InjectedDelegate get_stereoscopicBackbuffer_InjectedDelegateField = IL2CPP.ResolveICall<get_stereoscopicBackbuffer_InjectedDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_stereoscopicBackbuffer_Injected");

	private static readonly get_usePBufferEGL_InjectedDelegate get_usePBufferEGL_InjectedDelegateField = IL2CPP.ResolveICall<get_usePBufferEGL_InjectedDelegate>("UnityEngine.Subsystems.ExampleSubsystemDescriptor::get_usePBufferEGL_Injected");

	public bool supportsEditorMode
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_supportsEditorMode_Injected(intPtr);
		}
	}

	public bool disableBackbufferMSAA
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_disableBackbufferMSAA_Injected(intPtr);
		}
	}

	public bool stereoscopicBackbuffer
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stereoscopicBackbuffer_Injected(intPtr);
		}
	}

	public bool usePBufferEGL
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_usePBufferEGL_Injected(intPtr);
		}
	}

	public static bool get_supportsEditorMode_Injected(IntPtr _unity_self)
	{
		return get_supportsEditorMode_InjectedDelegateField(_unity_self);
	}

	public static bool get_disableBackbufferMSAA_Injected(IntPtr _unity_self)
	{
		return get_disableBackbufferMSAA_InjectedDelegateField(_unity_self);
	}

	public static bool get_stereoscopicBackbuffer_Injected(IntPtr _unity_self)
	{
		return get_stereoscopicBackbuffer_InjectedDelegateField(_unity_self);
	}

	public static bool get_usePBufferEGL_Injected(IntPtr _unity_self)
	{
		return get_usePBufferEGL_InjectedDelegateField(_unity_self);
	}
}
