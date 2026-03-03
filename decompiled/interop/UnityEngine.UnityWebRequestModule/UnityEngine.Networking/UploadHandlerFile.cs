using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public sealed class UploadHandlerFile : UploadHandler
{
	public new static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr Create_InjectedDelegate(System.IntPtr self, System.IntPtr filePath);

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("UnityEngine.Networking.UploadHandlerFile::Create_Injected");

	public unsafe static System.IntPtr Create(UploadHandlerFile self, string filePath)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filePath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(filePath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Create_Injected(self, ref managedSpanWrapper);
				}
			}
			return Create_Injected(self, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static System.IntPtr Create_Injected(UploadHandlerFile self, ref ManagedSpanWrapper filePath)
	{
		return Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self), (nint)Unsafe.AsPointer(ref filePath));
	}
}
