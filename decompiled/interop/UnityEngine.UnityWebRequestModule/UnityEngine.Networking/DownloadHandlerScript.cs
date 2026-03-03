using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Networking;

public class DownloadHandlerScript : DownloadHandler
{
	public new static class BindingsMarshaller
	{
	}

	private delegate IntPtr CreateDelegate(IntPtr obj);

	private delegate IntPtr CreatePreallocatedDelegate(IntPtr obj, IntPtr preallocatedBuffer);

	private static readonly CreateDelegate CreateDelegateField = IL2CPP.ResolveICall<CreateDelegate>("UnityEngine.Networking.DownloadHandlerScript::Create");

	private static readonly CreatePreallocatedDelegate CreatePreallocatedDelegateField = IL2CPP.ResolveICall<CreatePreallocatedDelegate>("UnityEngine.Networking.DownloadHandlerScript::CreatePreallocated");

	public static IntPtr Create(DownloadHandlerScript obj)
	{
		return CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj));
	}

	public static IntPtr CreatePreallocated(DownloadHandlerScript obj, Il2CppStructArray<byte> preallocatedBuffer)
	{
		return CreatePreallocatedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)preallocatedBuffer));
	}

	public void InternalCreateScript()
	{
		base.m_Ptr = Create(this);
	}

	public void InternalCreateScript(Il2CppStructArray<byte> preallocatedBuffer)
	{
		base.m_Ptr = CreatePreallocated(this, preallocatedBuffer);
	}
}
