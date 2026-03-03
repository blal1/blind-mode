using System;

namespace UnityEngine.Rendering;

public struct ScopedSubPass
{
	public ScriptableRenderContext m_Context;

	public void Dispose()
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
