using System;
using Il2CppInterop.Runtime;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public sealed class DownloadHandlerTexture : DownloadHandler
{
	public new static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr InternalGetTextureNative_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly InternalGetTextureNative_InjectedDelegate InternalGetTextureNative_InjectedDelegateField = IL2CPP.ResolveICall<InternalGetTextureNative_InjectedDelegate>("UnityEngine.Networking.DownloadHandlerTexture::InternalGetTextureNative_Injected");

	public Texture2D texture => InternalGetTextureNative();

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

	public Texture2D InternalGetTextureNative()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Texture2D>(InternalGetTextureNative_Injected(intPtr));
	}

	public static Texture2D GetContent(UnityWebRequest www)
	{
		return DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>(www).texture;
	}

	public static System.IntPtr InternalGetTextureNative_Injected(System.IntPtr _unity_self)
	{
		return InternalGetTextureNative_InjectedDelegateField(_unity_self);
	}
}
