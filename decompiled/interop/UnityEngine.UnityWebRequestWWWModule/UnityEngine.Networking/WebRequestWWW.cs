using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public static class WebRequestWWW
{
	private delegate System.IntPtr InternalCreateAudioClipUsingDH_InjectedDelegate(System.IntPtr dh, System.IntPtr url, bool stream, bool compressed, AudioType audioType);

	private static readonly InternalCreateAudioClipUsingDH_InjectedDelegate InternalCreateAudioClipUsingDH_InjectedDelegateField = IL2CPP.ResolveICall<InternalCreateAudioClipUsingDH_InjectedDelegate>("UnityEngine.Networking.WebRequestWWW::InternalCreateAudioClipUsingDH_Injected");

	public unsafe static AudioClip InternalCreateAudioClipUsingDH(DownloadHandler dh, string url, bool stream, bool compressed, AudioType audioType)
	{
		//IL_0027: Expected O, but got Ref
		//IL_0033: Expected O, but got Ref
		//The blocks IL_0038 are reachable both inside and outside the pinned region starting at IL_0027. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr gcHandlePtr);
		AudioClip result;
		try
		{
			System.IntPtr dh2 = ((dh == null) ? ((System.IntPtr)0) : DownloadHandler.BindingsMarshaller.ConvertToNative(dh));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = url.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					gcHandlePtr = InternalCreateAudioClipUsingDH_Injected(dh2, ref managedSpanWrapper, stream, compressed, audioType);
				}
			}
			else
			{
				gcHandlePtr = InternalCreateAudioClipUsingDH_Injected(dh2, ref managedSpanWrapper, stream, compressed, audioType);
			}
		}
		finally
		{
			result = Unmarshal.UnmarshalUnityObject<AudioClip>(gcHandlePtr);
		}
		return result;
	}

	public unsafe static System.IntPtr InternalCreateAudioClipUsingDH_Injected(System.IntPtr dh, ref ManagedSpanWrapper url, bool stream, bool compressed, AudioType audioType)
	{
		return InternalCreateAudioClipUsingDH_InjectedDelegateField(dh, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref url), stream, compressed, audioType);
	}
}
