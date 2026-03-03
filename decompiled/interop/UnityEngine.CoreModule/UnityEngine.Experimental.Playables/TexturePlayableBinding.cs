using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables;

public static class TexturePlayableBinding
{
	public unsafe static PlayableBinding Create(string name, Object key)
	{
		return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderTexture>()), new PlayableBinding.CreateOutputMethod(null, (nint)(delegate*<PlayableGraph, string, PlayableOutput>)(&CreateTextureOutput)));
	}

	public static PlayableOutput CreateTextureOutput(PlayableGraph graph, string name)
	{
		return TexturePlayableOutput.Create(graph, name, null);
	}
}
