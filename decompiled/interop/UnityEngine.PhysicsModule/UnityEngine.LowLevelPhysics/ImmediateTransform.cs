namespace UnityEngine.LowLevelPhysics;

public struct ImmediateTransform
{
	public Quaternion m_Rotation;

	public Vector3 m_Position;

	public Quaternion Rotation
	{
		get
		{
			return m_Rotation;
		}
		set
		{
			m_Rotation = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			return m_Position;
		}
		set
		{
			m_Position = value;
		}
	}
}
