using System;

namespace UnityEngine.SceneManagement;

[Serializable]
public struct CreateSceneParameters
{
	public LocalPhysicsMode m_LocalPhysicsMode;

	public LocalPhysicsMode localPhysicsMode
	{
		get
		{
			return m_LocalPhysicsMode;
		}
		set
		{
			m_LocalPhysicsMode = value;
		}
	}
}
