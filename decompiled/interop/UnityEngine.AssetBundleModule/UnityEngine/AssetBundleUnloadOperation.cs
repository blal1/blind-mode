using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AssetBundleUnloadOperation : AsyncOperation
{
	public new static class BindingsMarshaller
	{
	}

	private delegate void WaitForCompletion_InjectedDelegate(IntPtr _unity_self);

	private static readonly WaitForCompletion_InjectedDelegate WaitForCompletion_InjectedDelegateField;

	static AssetBundleUnloadOperation()
	{
		Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleUnloadOperation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleUnloadOperation>.NativeClassPtr);
		WaitForCompletion_InjectedDelegateField = IL2CPP.ResolveICall<WaitForCompletion_InjectedDelegate>("UnityEngine.AssetBundleUnloadOperation::WaitForCompletion_Injected");
	}

	public AssetBundleUnloadOperation(IntPtr pointer)
		: base(pointer)
	{
	}

	public void WaitForCompletion()
	{
		IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		WaitForCompletion_Injected(intPtr);
	}

	public static void WaitForCompletion_Injected(IntPtr _unity_self)
	{
		WaitForCompletion_InjectedDelegateField(_unity_self);
	}
}
