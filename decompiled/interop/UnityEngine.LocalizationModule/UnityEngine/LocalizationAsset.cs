using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class LocalizationAsset : Object
{
	private delegate void Internal_CreateInstanceDelegate(System.IntPtr locAsset);

	private delegate void SetLocalizedString_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr original, System.IntPtr localized);

	private delegate void GetLocalizedString_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr original, [Out] System.IntPtr ret);

	private delegate void get_localeIsoCode_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_localeIsoCode_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate bool get_isEditorAsset_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_isEditorAsset_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private static readonly Internal_CreateInstanceDelegate Internal_CreateInstanceDelegateField = IL2CPP.ResolveICall<Internal_CreateInstanceDelegate>("UnityEngine.LocalizationAsset::Internal_CreateInstance");

	private static readonly SetLocalizedString_InjectedDelegate SetLocalizedString_InjectedDelegateField = IL2CPP.ResolveICall<SetLocalizedString_InjectedDelegate>("UnityEngine.LocalizationAsset::SetLocalizedString_Injected");

	private static readonly GetLocalizedString_InjectedDelegate GetLocalizedString_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalizedString_InjectedDelegate>("UnityEngine.LocalizationAsset::GetLocalizedString_Injected");

	private static readonly get_localeIsoCode_InjectedDelegate get_localeIsoCode_InjectedDelegateField = IL2CPP.ResolveICall<get_localeIsoCode_InjectedDelegate>("UnityEngine.LocalizationAsset::get_localeIsoCode_Injected");

	private static readonly set_localeIsoCode_InjectedDelegate set_localeIsoCode_InjectedDelegateField = IL2CPP.ResolveICall<set_localeIsoCode_InjectedDelegate>("UnityEngine.LocalizationAsset::set_localeIsoCode_Injected");

	private static readonly get_isEditorAsset_InjectedDelegate get_isEditorAsset_InjectedDelegateField = IL2CPP.ResolveICall<get_isEditorAsset_InjectedDelegate>("UnityEngine.LocalizationAsset::get_isEditorAsset_Injected");

	private static readonly set_isEditorAsset_InjectedDelegate set_isEditorAsset_InjectedDelegateField = IL2CPP.ResolveICall<set_isEditorAsset_InjectedDelegate>("UnityEngine.LocalizationAsset::set_isEditorAsset_Injected");

	public unsafe string localeIsoCode
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
				}
				get_localeIsoCode_Injected(intPtr, out ret);
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
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					ReadOnlySpan<char> readOnlySpan = value.AsSpan();
					fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_localeIsoCode_Injected(intPtr, ref managedSpanWrapper);
						return;
					}
				}
				set_localeIsoCode_Injected(intPtr, ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public bool isEditorAsset
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isEditorAsset_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_isEditorAsset_Injected(intPtr, value);
		}
	}

	public static void Internal_CreateInstance(LocalizationAsset locAsset)
	{
		Internal_CreateInstanceDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)locAsset));
	}

	public unsafe void SetLocalizedString(string original, string localized)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//IL_0062: Expected O, but got Ref
		//The blocks IL_0039, IL_0046, IL_0054, IL_0062, IL_0067 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper original2;
			ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(original, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = original.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					original2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(localized, ref managedSpanWrapper2))
					{
						readOnlySpan2 = localized.AsSpan();
						fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							SetLocalizedString_Injected(intPtr, ref original2, ref managedSpanWrapper2);
							return;
						}
					}
					SetLocalizedString_Injected(intPtr, ref original2, ref managedSpanWrapper2);
					return;
				}
			}
			original2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(localized, ref managedSpanWrapper2))
			{
				readOnlySpan2 = localized.AsSpan();
				fixed (char* begin2 = &((ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					SetLocalizedString_Injected(intPtr, ref original2, ref managedSpanWrapper2);
					return;
				}
			}
			SetLocalizedString_Injected(intPtr, ref original2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe string GetLocalizedString(string original)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(original, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = original.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetLocalizedString_Injected(intPtr, ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetLocalizedString_Injected(intPtr, ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void SetLocalizedString_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper original, ref ManagedSpanWrapper localized)
	{
		SetLocalizedString_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref original), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref localized));
	}

	public unsafe static void GetLocalizedString_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper original, out ManagedSpanWrapper ret)
	{
		GetLocalizedString_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref original), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_localeIsoCode_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_localeIsoCode_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_localeIsoCode_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_localeIsoCode_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public static bool get_isEditorAsset_Injected(System.IntPtr _unity_self)
	{
		return get_isEditorAsset_InjectedDelegateField(_unity_self);
	}

	public static void set_isEditorAsset_Injected(System.IntPtr _unity_self, bool value)
	{
		set_isEditorAsset_InjectedDelegateField(_unity_self, value);
	}
}
