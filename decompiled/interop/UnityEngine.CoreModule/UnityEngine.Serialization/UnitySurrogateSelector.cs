using System;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization;

public class UnitySurrogateSelector
{
	public ISerializationSurrogate GetSurrogate(Il2CppSystem.Type type, StreamingContext context, out ISurrogateSelector selector)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void ChainSelector(ISurrogateSelector selector)
	{
		throw new Il2CppSystem.NotImplementedException();
	}

	public ISurrogateSelector GetNextSelector()
	{
		throw new Il2CppSystem.NotImplementedException();
	}
}
