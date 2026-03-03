using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class GUIDebugger
{
	private delegate void LogLayoutEndGroupDelegate();

	private delegate void LogEndPropertyDelegate();

	private delegate bool get_activeDelegate();

	private delegate void LogLayoutEntry_InjectedDelegate([In] System.IntPtr rect, int left, int right, int top, int bottom, System.IntPtr style);

	private delegate void LogLayoutGroupEntry_InjectedDelegate([In] System.IntPtr rect, int left, int right, int top, int bottom, System.IntPtr style, bool isVertical);

	private delegate void LogBeginProperty_InjectedDelegate(System.IntPtr targetTypeAssemblyQualifiedName, System.IntPtr path, [In] System.IntPtr position);

	private static readonly LogLayoutEndGroupDelegate LogLayoutEndGroupDelegateField = IL2CPP.ResolveICall<LogLayoutEndGroupDelegate>("UnityEngine.GUIDebugger::LogLayoutEndGroup");

	private static readonly LogEndPropertyDelegate LogEndPropertyDelegateField = IL2CPP.ResolveICall<LogEndPropertyDelegate>("UnityEngine.GUIDebugger::LogEndProperty");

	private static readonly get_activeDelegate get_activeDelegateField = IL2CPP.ResolveICall<get_activeDelegate>("UnityEngine.GUIDebugger::get_active");

	private static readonly LogLayoutEntry_InjectedDelegate LogLayoutEntry_InjectedDelegateField = IL2CPP.ResolveICall<LogLayoutEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutEntry_Injected");

	private static readonly LogLayoutGroupEntry_InjectedDelegate LogLayoutGroupEntry_InjectedDelegateField = IL2CPP.ResolveICall<LogLayoutGroupEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutGroupEntry_Injected");

	private static readonly LogBeginProperty_InjectedDelegate LogBeginProperty_InjectedDelegateField = IL2CPP.ResolveICall<LogBeginProperty_InjectedDelegate>("UnityEngine.GUIDebugger::LogBeginProperty_Injected");

	public static bool active => get_activeDelegateField();

	public static void LogLayoutEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style)
	{
		LogLayoutEntry_Injected(ref rect, left, right, top, bottom, (style == null) ? ((System.IntPtr)0) : GUIStyle.BindingsMarshaller.ConvertToNative(style));
	}

	public static void LogLayoutGroupEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
	{
		LogLayoutGroupEntry_Injected(ref rect, left, right, top, bottom, (style == null) ? ((System.IntPtr)0) : GUIStyle.BindingsMarshaller.ConvertToNative(style), isVertical);
	}

	public static void LogLayoutEndGroup()
	{
		LogLayoutEndGroupDelegateField();
	}

	public unsafe static void LogBeginProperty(string targetTypeAssemblyQualifiedName, string path, Rect position)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper targetTypeAssemblyQualifiedName2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(targetTypeAssemblyQualifiedName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(targetTypeAssemblyQualifiedName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					targetTypeAssemblyQualifiedName2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(path);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							LogBeginProperty_Injected(ref targetTypeAssemblyQualifiedName2, ref managedSpanWrapper2, ref position);
							return;
						}
					}
					LogBeginProperty_Injected(ref targetTypeAssemblyQualifiedName2, ref managedSpanWrapper2, ref position);
					return;
				}
			}
			targetTypeAssemblyQualifiedName2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					LogBeginProperty_Injected(ref targetTypeAssemblyQualifiedName2, ref managedSpanWrapper2, ref position);
					return;
				}
			}
			LogBeginProperty_Injected(ref targetTypeAssemblyQualifiedName2, ref managedSpanWrapper2, ref position);
		}
		finally
		{
		}
	}

	public static void LogEndProperty()
	{
		LogEndPropertyDelegateField();
	}

	public unsafe static void LogLayoutEntry_Injected([In] ref Rect rect, int left, int right, int top, int bottom, System.IntPtr style)
	{
		LogLayoutEntry_InjectedDelegateField((nint)Unsafe.AsPointer(ref rect), left, right, top, bottom, style);
	}

	public unsafe static void LogLayoutGroupEntry_Injected([In] ref Rect rect, int left, int right, int top, int bottom, System.IntPtr style, bool isVertical)
	{
		LogLayoutGroupEntry_InjectedDelegateField((nint)Unsafe.AsPointer(ref rect), left, right, top, bottom, style, isVertical);
	}

	public unsafe static void LogBeginProperty_Injected(ref ManagedSpanWrapper targetTypeAssemblyQualifiedName, ref ManagedSpanWrapper path, [In] ref Rect position)
	{
		LogBeginProperty_InjectedDelegateField((nint)Unsafe.AsPointer(ref targetTypeAssemblyQualifiedName), (nint)Unsafe.AsPointer(ref path), (nint)Unsafe.AsPointer(ref position));
	}
}
