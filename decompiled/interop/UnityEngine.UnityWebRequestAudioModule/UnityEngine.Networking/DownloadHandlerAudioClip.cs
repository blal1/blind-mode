using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public sealed class DownloadHandlerAudioClip : DownloadHandler
{
	public new static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr Create_InjectedDelegate(System.IntPtr obj, System.IntPtr url, AudioType audioType);

	private delegate System.IntPtr get_audioClip_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_streamAudio_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_streamAudio_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_compressed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_compressed_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::Create_Injected");

	private static readonly get_audioClip_InjectedDelegate get_audioClip_InjectedDelegateField = IL2CPP.ResolveICall<get_audioClip_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_audioClip_Injected");

	private static readonly get_streamAudio_InjectedDelegate get_streamAudio_InjectedDelegateField = IL2CPP.ResolveICall<get_streamAudio_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_streamAudio_Injected");

	private static readonly set_streamAudio_InjectedDelegate set_streamAudio_InjectedDelegateField = IL2CPP.ResolveICall<set_streamAudio_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::set_streamAudio_Injected");

	private static readonly get_compressed_InjectedDelegate get_compressed_InjectedDelegateField = IL2CPP.ResolveICall<get_compressed_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::get_compressed_Injected");

	private static readonly set_compressed_InjectedDelegate set_compressed_InjectedDelegateField = IL2CPP.ResolveICall<set_compressed_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerAudioClip::set_compressed_Injected");

	public AudioClip audioClip
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<AudioClip>(get_audioClip_Injected(intPtr));
		}
	}

	public bool streamAudio
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_streamAudio_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_streamAudio_Injected(intPtr, value);
		}
	}

	public bool compressed
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_compressed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_compressed_Injected(intPtr, value);
		}
	}

	public unsafe static System.IntPtr Create(DownloadHandlerAudioClip obj, string url, AudioType audioType)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = url.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Create_Injected(obj, ref managedSpanWrapper, audioType);
				}
			}
			return Create_Injected(obj, ref managedSpanWrapper, audioType);
		}
		finally
		{
		}
	}

	public void InternalCreateAudioClip(string url, AudioType audioType)
	{
		base.m_Ptr = Create(this, url, audioType);
	}

	public override NativeArray<byte> GetNativeData()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public override void Dispose()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public override string GetText()
	{
		throw new NotSupportedException("String access is not supported for audio clips");
	}

	public static AudioClip GetContent(UnityWebRequest www)
	{
		return DownloadHandler.GetCheckedDownloader<DownloadHandlerAudioClip>(www).audioClip;
	}

	public unsafe static System.IntPtr Create_Injected(DownloadHandlerAudioClip obj, ref ManagedSpanWrapper url, AudioType audioType)
	{
		return Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref url), audioType);
	}

	public static System.IntPtr get_audioClip_Injected(System.IntPtr _unity_self)
	{
		return get_audioClip_InjectedDelegateField(_unity_self);
	}

	public static bool get_streamAudio_Injected(System.IntPtr _unity_self)
	{
		return get_streamAudio_InjectedDelegateField(_unity_self);
	}

	public static void set_streamAudio_Injected(System.IntPtr _unity_self, bool value)
	{
		set_streamAudio_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_compressed_Injected(System.IntPtr _unity_self)
	{
		return get_compressed_InjectedDelegateField(_unity_self);
	}

	public static void set_compressed_Injected(System.IntPtr _unity_self, bool value)
	{
		set_compressed_InjectedDelegateField(_unity_self, value);
	}
}
