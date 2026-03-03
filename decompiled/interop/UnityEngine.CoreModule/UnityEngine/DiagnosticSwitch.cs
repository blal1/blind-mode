using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class DiagnosticSwitch
{
	public enum Flags
	{
		None,
		CanChangeAfterEngineStart,
		PropagateToAssetImportWorkerProcess
	}

	public static class BindingsMarshaller
	{
	}

	private delegate void get_name_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_description_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_owningModule_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate Flags get_flags_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_defaultValue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_minValue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_maxValue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_enumInfo_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetScriptingValue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetScriptingPersistentValue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetScriptingValue_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value, bool setPersistent);

	private static readonly get_name_InjectedDelegate get_name_InjectedDelegateField = IL2CPP.ResolveICall<get_name_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_name_Injected");

	private static readonly get_description_InjectedDelegate get_description_InjectedDelegateField = IL2CPP.ResolveICall<get_description_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_description_Injected");

	private static readonly get_owningModule_InjectedDelegate get_owningModule_InjectedDelegateField = IL2CPP.ResolveICall<get_owningModule_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_owningModule_Injected");

	private static readonly get_flags_InjectedDelegate get_flags_InjectedDelegateField = IL2CPP.ResolveICall<get_flags_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_flags_Injected");

	private static readonly get_defaultValue_InjectedDelegate get_defaultValue_InjectedDelegateField = IL2CPP.ResolveICall<get_defaultValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_defaultValue_Injected");

	private static readonly get_minValue_InjectedDelegate get_minValue_InjectedDelegateField = IL2CPP.ResolveICall<get_minValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_minValue_Injected");

	private static readonly get_maxValue_InjectedDelegate get_maxValue_InjectedDelegateField = IL2CPP.ResolveICall<get_maxValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_maxValue_Injected");

	private static readonly get_enumInfo_InjectedDelegate get_enumInfo_InjectedDelegateField = IL2CPP.ResolveICall<get_enumInfo_InjectedDelegate>("UnityEngine.DiagnosticSwitch::get_enumInfo_Injected");

	private static readonly GetScriptingValue_InjectedDelegate GetScriptingValue_InjectedDelegateField = IL2CPP.ResolveICall<GetScriptingValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingValue_Injected");

	private static readonly GetScriptingPersistentValue_InjectedDelegate GetScriptingPersistentValue_InjectedDelegateField = IL2CPP.ResolveICall<GetScriptingPersistentValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::GetScriptingPersistentValue_Injected");

	private static readonly SetScriptingValue_InjectedDelegate SetScriptingValue_InjectedDelegateField = IL2CPP.ResolveICall<SetScriptingValue_InjectedDelegate>("UnityEngine.DiagnosticSwitch::SetScriptingValue_Injected");

	public string name
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
				}
				get_name_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public string description
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
				}
				get_description_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public string owningModule
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
				}
				get_owningModule_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public Flags flags
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_flags_Injected(intPtr);
		}
	}

	public Il2CppSystem.Object value
	{
		get
		{
			return GetScriptingValue();
		}
		set
		{
			SetScriptingValue(value, setPersistent: false);
		}
	}

	public Il2CppSystem.Object defaultValue
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_defaultValue_Injected(intPtr);
		}
	}

	public Il2CppSystem.Object minValue
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_minValue_Injected(intPtr);
		}
	}

	public Il2CppSystem.Object maxValue
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_maxValue_Injected(intPtr);
		}
	}

	public Il2CppSystem.Object persistentValue
	{
		get
		{
			return GetScriptingPersistentValue();
		}
		set
		{
			SetScriptingValue(value, setPersistent: true);
		}
	}

	public EnumInfo enumInfo
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_enumInfo_Injected(intPtr);
		}
	}

	public bool isSetToDefault => Il2CppSystem.Object.Equals(persistentValue, defaultValue);

	public bool needsRestart => !Il2CppSystem.Object.Equals(value, persistentValue);

	public Il2CppSystem.Object GetScriptingValue()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetScriptingValue_Injected(intPtr);
	}

	public Il2CppSystem.Object GetScriptingPersistentValue()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return GetScriptingPersistentValue_Injected(intPtr);
	}

	public void SetScriptingValue(Il2CppSystem.Object value, bool setPersistent)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		SetScriptingValue_Injected(intPtr, value, setPersistent);
	}

	public override string ToString()
	{
		string str = ((value == null) ? "<null>" : value.ToString());
		return Il2CppSystem.String.Concat(name, " = ", str);
	}

	public unsafe static void get_name_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_name_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_description_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_description_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_owningModule_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_owningModule_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static Flags get_flags_Injected(System.IntPtr _unity_self)
	{
		return get_flags_InjectedDelegateField(_unity_self);
	}

	public static Il2CppSystem.Object get_defaultValue_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_defaultValue_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static Il2CppSystem.Object get_minValue_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_minValue_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static Il2CppSystem.Object get_maxValue_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_maxValue_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static EnumInfo get_enumInfo_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_enumInfo_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumInfo>(intPtr) : null;
	}

	public static Il2CppSystem.Object GetScriptingValue_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetScriptingValue_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static Il2CppSystem.Object GetScriptingPersistentValue_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetScriptingPersistentValue_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static void SetScriptingValue_Injected(System.IntPtr _unity_self, Il2CppSystem.Object value, bool setPersistent)
	{
		SetScriptingValue_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value), setPersistent);
	}
}
