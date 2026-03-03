using System;

namespace UnityEngine.Rendering.RenderGraphModule;

[Flags]
public enum DepthAccess
{
	Read = 1,
	Write = 2,
	ReadWrite = 3
}
