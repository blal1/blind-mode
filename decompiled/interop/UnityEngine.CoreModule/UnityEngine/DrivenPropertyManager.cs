using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class DrivenPropertyManager
{
	private delegate void UnregisterProperties_InjectedDelegate(System.IntPtr driver);

	private delegate void RegisterPropertyPartial_InjectedDelegate(System.IntPtr driver, System.IntPtr target, System.IntPtr propertyPath);

	private delegate void TryRegisterPropertyPartial_InjectedDelegate(System.IntPtr driver, System.IntPtr target, System.IntPtr propertyPath);

	private delegate void UnregisterPropertyPartial_InjectedDelegate(System.IntPtr driver, System.IntPtr target, System.IntPtr propertyPath);

	private static readonly UnregisterProperties_InjectedDelegate UnregisterProperties_InjectedDelegateField = IL2CPP.ResolveICall<UnregisterProperties_InjectedDelegate>("UnityEngine.DrivenPropertyManager::UnregisterProperties_Injected");

	private static readonly RegisterPropertyPartial_InjectedDelegate RegisterPropertyPartial_InjectedDelegateField = IL2CPP.ResolveICall<RegisterPropertyPartial_InjectedDelegate>("UnityEngine.DrivenPropertyManager::RegisterPropertyPartial_Injected");

	private static readonly TryRegisterPropertyPartial_InjectedDelegate TryRegisterPropertyPartial_InjectedDelegateField = IL2CPP.ResolveICall<TryRegisterPropertyPartial_InjectedDelegate>("UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial_Injected");

	private static readonly UnregisterPropertyPartial_InjectedDelegate UnregisterPropertyPartial_InjectedDelegateField = IL2CPP.ResolveICall<UnregisterPropertyPartial_InjectedDelegate>("UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial_Injected");

	public static void RegisterProperty(Object driver, Object target, string propertyPath)
	{
		RegisterPropertyPartial(driver, target, propertyPath);
	}

	public static void TryRegisterProperty(Object driver, Object target, string propertyPath)
	{
		TryRegisterPropertyPartial(driver, target, propertyPath);
	}

	public static void UnregisterProperty(Object driver, Object target, string propertyPath)
	{
		UnregisterPropertyPartial(driver, target, propertyPath);
	}

	public static void UnregisterProperties(Object driver)
	{
		if ((object)driver == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(driver);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
		}
		UnregisterProperties_Injected(intPtr);
	}

	public unsafe static void RegisterPropertyPartial(Object driver, Object target, string propertyPath)
	{
		//IL_006f: Expected O, but got Ref
		//IL_007b: Expected O, but got Ref
		//The blocks IL_0080 are reachable both inside and outside the pinned region starting at IL_006f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if ((object)driver == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
		}
		if ((object)target == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(target, "target");
		}
		if (propertyPath == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(propertyPath, "propertyPath");
		}
		try
		{
			System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(driver);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
			}
			System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(target);
			if (intPtr2 == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(target, "target");
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyPath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(propertyPath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					RegisterPropertyPartial_Injected(intPtr, intPtr2, ref managedSpanWrapper);
					return;
				}
			}
			RegisterPropertyPartial_Injected(intPtr, intPtr2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void TryRegisterPropertyPartial(Object driver, Object target, string propertyPath)
	{
		//IL_006f: Expected O, but got Ref
		//IL_007b: Expected O, but got Ref
		//The blocks IL_0080 are reachable both inside and outside the pinned region starting at IL_006f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if ((object)driver == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
		}
		if ((object)target == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(target, "target");
		}
		if (propertyPath == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(propertyPath, "propertyPath");
		}
		try
		{
			System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(driver);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
			}
			System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(target);
			if (intPtr2 == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(target, "target");
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyPath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(propertyPath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					TryRegisterPropertyPartial_Injected(intPtr, intPtr2, ref managedSpanWrapper);
					return;
				}
			}
			TryRegisterPropertyPartial_Injected(intPtr, intPtr2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void UnregisterPropertyPartial(Object driver, Object target, string propertyPath)
	{
		//IL_006f: Expected O, but got Ref
		//IL_007b: Expected O, but got Ref
		//The blocks IL_0080 are reachable both inside and outside the pinned region starting at IL_006f. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if ((object)driver == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
		}
		if ((object)target == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(target, "target");
		}
		if (propertyPath == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(propertyPath, "propertyPath");
		}
		try
		{
			System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(driver);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(driver, "driver");
			}
			System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(target);
			if (intPtr2 == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(target, "target");
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyPath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(propertyPath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					UnregisterPropertyPartial_Injected(intPtr, intPtr2, ref managedSpanWrapper);
					return;
				}
			}
			UnregisterPropertyPartial_Injected(intPtr, intPtr2, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void UnregisterProperties_Injected(System.IntPtr driver)
	{
		UnregisterProperties_InjectedDelegateField(driver);
	}

	public unsafe static void RegisterPropertyPartial_Injected(System.IntPtr driver, System.IntPtr target, ref ManagedSpanWrapper propertyPath)
	{
		RegisterPropertyPartial_InjectedDelegateField(driver, target, (nint)Unsafe.AsPointer(ref propertyPath));
	}

	public unsafe static void TryRegisterPropertyPartial_Injected(System.IntPtr driver, System.IntPtr target, ref ManagedSpanWrapper propertyPath)
	{
		TryRegisterPropertyPartial_InjectedDelegateField(driver, target, (nint)Unsafe.AsPointer(ref propertyPath));
	}

	public unsafe static void UnregisterPropertyPartial_Injected(System.IntPtr driver, System.IntPtr target, ref ManagedSpanWrapper propertyPath)
	{
		UnregisterPropertyPartial_InjectedDelegateField(driver, target, (nint)Unsafe.AsPointer(ref propertyPath));
	}
}
