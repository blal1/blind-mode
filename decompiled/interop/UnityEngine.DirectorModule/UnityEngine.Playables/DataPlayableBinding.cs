using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables;

public static class DataPlayableBinding
{
	public unsafe static PlayableBinding Create<TDataStream, TPlayer>(string name, Object key) where TDataStream : new() where TPlayer : Object
	{
		return PlayableBinding.CreateInternal(name, key, Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TPlayer>()), new PlayableBinding.CreateOutputMethod(null, (nint)(delegate*<PlayableGraph, string, PlayableOutput>)(&CreateDataOutput<TDataStream>)));
	}

	public static PlayableOutput CreateDataOutput<TDataStream>(PlayableGraph graph, string name) where TDataStream : new()
	{
		return DataPlayableOutput.Create<TDataStream>(graph, name);
	}
}
