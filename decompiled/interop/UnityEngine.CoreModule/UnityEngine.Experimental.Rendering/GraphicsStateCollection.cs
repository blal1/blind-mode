using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public sealed class GraphicsStateCollection : Object
{
	private delegate void Internal_CreateDelegate(System.IntPtr gsc);

	private delegate bool BeginTrace_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void EndTrace_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isTracing_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_version_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_version_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate GraphicsDeviceType get_graphicsDeviceType_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_graphicsDeviceType_InjectedDelegate(System.IntPtr _unity_self, GraphicsDeviceType value);

	private delegate RuntimePlatform get_runtimePlatform_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_runtimePlatform_InjectedDelegate(System.IntPtr _unity_self, RuntimePlatform value);

	private delegate void get_qualityLevelName_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_qualityLevelName_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate bool LoadFromFile_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr filePath);

	private delegate bool SaveToFile_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr filePath);

	private delegate bool SendToEditor_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr fileName);

	private delegate void WarmUp_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr dependency, [Out] System.IntPtr ret);

	private delegate void WarmUpProgressively_InjectedDelegate(System.IntPtr _unity_self, int count, [In] System.IntPtr dependency, [Out] System.IntPtr ret);

	private delegate int get_totalGraphicsStateCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_completedWarmupCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isWarmedUp_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_variantCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ClearVariants_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::Internal_Create");

	private static readonly BeginTrace_InjectedDelegate BeginTrace_InjectedDelegateField = IL2CPP.ResolveICall<BeginTrace_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::BeginTrace_Injected");

	private static readonly EndTrace_InjectedDelegate EndTrace_InjectedDelegateField = IL2CPP.ResolveICall<EndTrace_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::EndTrace_Injected");

	private static readonly get_isTracing_InjectedDelegate get_isTracing_InjectedDelegateField = IL2CPP.ResolveICall<get_isTracing_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_isTracing_Injected");

	private static readonly get_version_InjectedDelegate get_version_InjectedDelegateField = IL2CPP.ResolveICall<get_version_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_version_Injected");

	private static readonly set_version_InjectedDelegate set_version_InjectedDelegateField = IL2CPP.ResolveICall<set_version_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_version_Injected");

	private static readonly get_graphicsDeviceType_InjectedDelegate get_graphicsDeviceType_InjectedDelegateField = IL2CPP.ResolveICall<get_graphicsDeviceType_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_graphicsDeviceType_Injected");

	private static readonly set_graphicsDeviceType_InjectedDelegate set_graphicsDeviceType_InjectedDelegateField = IL2CPP.ResolveICall<set_graphicsDeviceType_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_graphicsDeviceType_Injected");

	private static readonly get_runtimePlatform_InjectedDelegate get_runtimePlatform_InjectedDelegateField = IL2CPP.ResolveICall<get_runtimePlatform_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_runtimePlatform_Injected");

	private static readonly set_runtimePlatform_InjectedDelegate set_runtimePlatform_InjectedDelegateField = IL2CPP.ResolveICall<set_runtimePlatform_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_runtimePlatform_Injected");

	private static readonly get_qualityLevelName_InjectedDelegate get_qualityLevelName_InjectedDelegateField = IL2CPP.ResolveICall<get_qualityLevelName_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_qualityLevelName_Injected");

	private static readonly set_qualityLevelName_InjectedDelegate set_qualityLevelName_InjectedDelegateField = IL2CPP.ResolveICall<set_qualityLevelName_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::set_qualityLevelName_Injected");

	private static readonly LoadFromFile_InjectedDelegate LoadFromFile_InjectedDelegateField = IL2CPP.ResolveICall<LoadFromFile_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::LoadFromFile_Injected");

	private static readonly SaveToFile_InjectedDelegate SaveToFile_InjectedDelegateField = IL2CPP.ResolveICall<SaveToFile_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::SaveToFile_Injected");

	private static readonly SendToEditor_InjectedDelegate SendToEditor_InjectedDelegateField = IL2CPP.ResolveICall<SendToEditor_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::SendToEditor_Injected");

	private static readonly WarmUp_InjectedDelegate WarmUp_InjectedDelegateField = IL2CPP.ResolveICall<WarmUp_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::WarmUp_Injected");

	private static readonly WarmUpProgressively_InjectedDelegate WarmUpProgressively_InjectedDelegateField = IL2CPP.ResolveICall<WarmUpProgressively_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::WarmUpProgressively_Injected");

	private static readonly get_totalGraphicsStateCount_InjectedDelegate get_totalGraphicsStateCount_InjectedDelegateField = IL2CPP.ResolveICall<get_totalGraphicsStateCount_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_totalGraphicsStateCount_Injected");

	private static readonly get_completedWarmupCount_InjectedDelegate get_completedWarmupCount_InjectedDelegateField = IL2CPP.ResolveICall<get_completedWarmupCount_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_completedWarmupCount_Injected");

	private static readonly get_isWarmedUp_InjectedDelegate get_isWarmedUp_InjectedDelegateField = IL2CPP.ResolveICall<get_isWarmedUp_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_isWarmedUp_Injected");

	private static readonly get_variantCount_InjectedDelegate get_variantCount_InjectedDelegateField = IL2CPP.ResolveICall<get_variantCount_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::get_variantCount_Injected");

	private static readonly ClearVariants_InjectedDelegate ClearVariants_InjectedDelegateField = IL2CPP.ResolveICall<ClearVariants_InjectedDelegate>("UnityEngine.Experimental.Rendering.GraphicsStateCollection::ClearVariants_Injected");

	public bool isTracing
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isTracing_Injected(intPtr);
		}
	}

	public int version
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_version_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_version_Injected(intPtr, value);
		}
	}

	public GraphicsDeviceType graphicsDeviceType
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_graphicsDeviceType_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_graphicsDeviceType_Injected(intPtr, value);
		}
	}

	public RuntimePlatform runtimePlatform
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_runtimePlatform_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_runtimePlatform_Injected(intPtr, value);
		}
	}

	public unsafe string qualityLevelName
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_qualityLevelName_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0028: Expected O, but got Ref
			//IL_0034: Expected O, but got Ref
			//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_qualityLevelName_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_qualityLevelName_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public int totalGraphicsStateCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_totalGraphicsStateCount_Injected(intPtr);
		}
	}

	public int completedWarmupCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_completedWarmupCount_Injected(intPtr);
		}
	}

	public bool isWarmedUp
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isWarmedUp_Injected(intPtr);
		}
	}

	public int variantCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_variantCount_Injected(intPtr);
		}
	}

	public bool BeginTrace()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return BeginTrace_Injected(intPtr);
	}

	public void EndTrace()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EndTrace_Injected(intPtr);
	}

	public unsafe bool LoadFromFile(string filePath)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filePath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(filePath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return LoadFromFile_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return LoadFromFile_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe bool SaveToFile(string filePath)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filePath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(filePath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return SaveToFile_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return SaveToFile_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe bool SendToEditor(string fileName)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(fileName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(fileName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return SendToEditor_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return SendToEditor_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public JobHandle WarmUp([Optional] JobHandle dependency)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		WarmUp_Injected(intPtr, ref dependency, out var ret);
		return ret;
	}

	public JobHandle WarmUpProgressively(int count, [Optional] JobHandle dependency)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		WarmUpProgressively_Injected(intPtr, count, ref dependency, out var ret);
		return ret;
	}

	public void ClearVariants()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearVariants_Injected(intPtr);
	}

	public static void Internal_Create(GraphicsStateCollection gsc)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gsc));
	}

	public static bool BeginTrace_Injected(System.IntPtr _unity_self)
	{
		return BeginTrace_InjectedDelegateField(_unity_self);
	}

	public static void EndTrace_Injected(System.IntPtr _unity_self)
	{
		EndTrace_InjectedDelegateField(_unity_self);
	}

	public static bool get_isTracing_Injected(System.IntPtr _unity_self)
	{
		return get_isTracing_InjectedDelegateField(_unity_self);
	}

	public static int get_version_Injected(System.IntPtr _unity_self)
	{
		return get_version_InjectedDelegateField(_unity_self);
	}

	public static void set_version_Injected(System.IntPtr _unity_self, int value)
	{
		set_version_InjectedDelegateField(_unity_self, value);
	}

	public static GraphicsDeviceType get_graphicsDeviceType_Injected(System.IntPtr _unity_self)
	{
		return get_graphicsDeviceType_InjectedDelegateField(_unity_self);
	}

	public static void set_graphicsDeviceType_Injected(System.IntPtr _unity_self, GraphicsDeviceType value)
	{
		set_graphicsDeviceType_InjectedDelegateField(_unity_self, value);
	}

	public static RuntimePlatform get_runtimePlatform_Injected(System.IntPtr _unity_self)
	{
		return get_runtimePlatform_InjectedDelegateField(_unity_self);
	}

	public static void set_runtimePlatform_Injected(System.IntPtr _unity_self, RuntimePlatform value)
	{
		set_runtimePlatform_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_qualityLevelName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_qualityLevelName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_qualityLevelName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_qualityLevelName_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool LoadFromFile_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper filePath)
	{
		return LoadFromFile_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref filePath));
	}

	public unsafe static bool SaveToFile_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper filePath)
	{
		return SaveToFile_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref filePath));
	}

	public unsafe static bool SendToEditor_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper fileName)
	{
		return SendToEditor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref fileName));
	}

	public unsafe static void WarmUp_Injected(System.IntPtr _unity_self, [In] ref JobHandle dependency, out JobHandle ret)
	{
		WarmUp_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref dependency), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void WarmUpProgressively_Injected(System.IntPtr _unity_self, int count, [In] ref JobHandle dependency, out JobHandle ret)
	{
		WarmUpProgressively_InjectedDelegateField(_unity_self, count, (nint)Unsafe.AsPointer(ref dependency), (nint)Unsafe.AsPointer(ref ret));
	}

	public static int get_totalGraphicsStateCount_Injected(System.IntPtr _unity_self)
	{
		return get_totalGraphicsStateCount_InjectedDelegateField(_unity_self);
	}

	public static int get_completedWarmupCount_Injected(System.IntPtr _unity_self)
	{
		return get_completedWarmupCount_InjectedDelegateField(_unity_self);
	}

	public static bool get_isWarmedUp_Injected(System.IntPtr _unity_self)
	{
		return get_isWarmedUp_InjectedDelegateField(_unity_self);
	}

	public static int get_variantCount_Injected(System.IntPtr _unity_self)
	{
		return get_variantCount_InjectedDelegateField(_unity_self);
	}

	public static void ClearVariants_Injected(System.IntPtr _unity_self)
	{
		ClearVariants_InjectedDelegateField(_unity_self);
	}
}
