using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.Multiplayer.Internal;

public static class MultiplayerManager
{
	private delegate MultiplayerRoleFlags get_activeMultiplayerRoleMaskDelegate();

	private delegate MultiplayerRoleFlags GetMultiplayerRoleMaskForGameObject_InjectedDelegate(System.IntPtr gameObject);

	private delegate MultiplayerRoleFlags GetMultiplayerRoleMaskForComponent_InjectedDelegate(System.IntPtr component);

	private static readonly get_activeMultiplayerRoleMaskDelegate get_activeMultiplayerRoleMaskDelegateField = IL2CPP.ResolveICall<get_activeMultiplayerRoleMaskDelegate>("UnityEngine.Multiplayer.Internal.MultiplayerManager::get_activeMultiplayerRoleMask");

	private static readonly GetMultiplayerRoleMaskForGameObject_InjectedDelegate GetMultiplayerRoleMaskForGameObject_InjectedDelegateField = IL2CPP.ResolveICall<GetMultiplayerRoleMaskForGameObject_InjectedDelegate>("UnityEngine.Multiplayer.Internal.MultiplayerManager::GetMultiplayerRoleMaskForGameObject_Injected");

	private static readonly GetMultiplayerRoleMaskForComponent_InjectedDelegate GetMultiplayerRoleMaskForComponent_InjectedDelegateField = IL2CPP.ResolveICall<GetMultiplayerRoleMaskForComponent_InjectedDelegate>("UnityEngine.Multiplayer.Internal.MultiplayerManager::GetMultiplayerRoleMaskForComponent_Injected");

	public static MultiplayerRoleFlags activeMultiplayerRoleMask => get_activeMultiplayerRoleMaskDelegateField();

	public static MultiplayerRoleFlags GetMultiplayerRoleMaskForGameObject(GameObject gameObject)
	{
		return GetMultiplayerRoleMaskForGameObject_Injected(Object.MarshalledUnityObject.Marshal(gameObject));
	}

	public static MultiplayerRoleFlags GetMultiplayerRoleMaskForComponent(Component component)
	{
		return GetMultiplayerRoleMaskForComponent_Injected(Object.MarshalledUnityObject.Marshal(component));
	}

	public static MultiplayerRoleFlags GetMultiplayerRoleMaskForGameObject_Injected(System.IntPtr gameObject)
	{
		return GetMultiplayerRoleMaskForGameObject_InjectedDelegateField(gameObject);
	}

	public static MultiplayerRoleFlags GetMultiplayerRoleMaskForComponent_Injected(System.IntPtr component)
	{
		return GetMultiplayerRoleMaskForComponent_InjectedDelegateField(component);
	}
}
