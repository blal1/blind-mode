using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class TextureMipmapLimitGroups
{
	private delegate System.IntPtr GetGroupsDelegate();

	private delegate bool HasGroup_InjectedDelegate(System.IntPtr groupName);

	private static readonly GetGroupsDelegate GetGroupsDelegateField = IL2CPP.ResolveICall<GetGroupsDelegate>("UnityEngine.TextureMipmapLimitGroups::GetGroups");

	private static readonly HasGroup_InjectedDelegate HasGroup_InjectedDelegateField = IL2CPP.ResolveICall<HasGroup_InjectedDelegate>("UnityEngine.TextureMipmapLimitGroups::HasGroup_Injected");

	public static Il2CppStringArray GetGroups()
	{
		System.IntPtr intPtr = GetGroupsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static bool HasGroup(string groupName)
	{
		//IL_0027: Expected O, but got Ref
		//IL_0033: Expected O, but got Ref
		//The blocks IL_0038 are reachable both inside and outside the pinned region starting at IL_0027. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (groupName == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(groupName, "groupName");
		}
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(groupName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(groupName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return HasGroup_Injected(ref managedSpanWrapper);
				}
			}
			return HasGroup_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static bool HasGroup_Injected(ref ManagedSpanWrapper groupName)
	{
		return HasGroup_InjectedDelegateField((nint)Unsafe.AsPointer(ref groupName));
	}
}
