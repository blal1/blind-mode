using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class AssetBundleRecompressOperation : AsyncOperation
{
	public new static class BindingsMarshaller
	{
	}

	private delegate void get_humanReadableResult_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void get_inputPath_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void get_outputPath_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate AssetBundleLoadResult get_result_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_success_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_humanReadableResult_InjectedDelegate get_humanReadableResult_InjectedDelegateField;

	private static readonly get_inputPath_InjectedDelegate get_inputPath_InjectedDelegateField;

	private static readonly get_outputPath_InjectedDelegate get_outputPath_InjectedDelegateField;

	private static readonly get_result_InjectedDelegate get_result_InjectedDelegateField;

	private static readonly get_success_InjectedDelegate get_success_InjectedDelegateField;

	public string humanReadableResult
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_humanReadableResult_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public string inputPath
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_inputPath_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public string outputPath
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_outputPath_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public AssetBundleLoadResult result
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_result_Injected(intPtr);
		}
	}

	public bool success
	{
		get
		{
			IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_success_Injected(intPtr);
		}
	}

	static AssetBundleRecompressOperation()
	{
		Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleRecompressOperation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr);
		get_humanReadableResult_InjectedDelegateField = IL2CPP.ResolveICall<get_humanReadableResult_InjectedDelegate>("UnityEngine.AssetBundleRecompressOperation::get_humanReadableResult_Injected");
		get_inputPath_InjectedDelegateField = IL2CPP.ResolveICall<get_inputPath_InjectedDelegate>("UnityEngine.AssetBundleRecompressOperation::get_inputPath_Injected");
		get_outputPath_InjectedDelegateField = IL2CPP.ResolveICall<get_outputPath_InjectedDelegate>("UnityEngine.AssetBundleRecompressOperation::get_outputPath_Injected");
		get_result_InjectedDelegateField = IL2CPP.ResolveICall<get_result_InjectedDelegate>("UnityEngine.AssetBundleRecompressOperation::get_result_Injected");
		get_success_InjectedDelegateField = IL2CPP.ResolveICall<get_success_InjectedDelegate>("UnityEngine.AssetBundleRecompressOperation::get_success_Injected");
	}

	public AssetBundleRecompressOperation(IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void get_humanReadableResult_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_humanReadableResult_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_inputPath_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_inputPath_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_outputPath_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_outputPath_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static AssetBundleLoadResult get_result_Injected(IntPtr _unity_self)
	{
		return get_result_InjectedDelegateField(_unity_self);
	}

	public static bool get_success_Injected(IntPtr _unity_self)
	{
		return get_success_InjectedDelegateField(_unity_self);
	}
}
