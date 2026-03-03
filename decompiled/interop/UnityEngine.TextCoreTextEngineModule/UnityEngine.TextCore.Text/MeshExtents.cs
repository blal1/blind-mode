using System;

namespace UnityEngine.TextCore.Text;

[Serializable]
public struct MeshExtents
{
	public Vector2 min;

	public Vector2 max;

	public override string ToString()
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
