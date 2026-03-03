using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

namespace UnityEngine.Serialization;

public class ListSerializationSurrogate
{
	public void GetObjectData(Il2CppSystem.Object obj, SerializationInfo info, StreamingContext context)
	{
		IList list = ((Il2CppObjectBase)obj).Cast<IList>();
		info.AddValue("_size", ((ICollection)(object)list).Count);
		info.AddValue("_items", ArrayFromGenericList(list));
		info.AddValue("_version", 0);
	}

	public Il2CppSystem.Object SetObjectData(Il2CppSystem.Object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector)
	{
		IList list = ((Il2CppObjectBase)Il2CppSystem.Activator.CreateInstance(obj.GetType())).Cast<IList>();
		int @int = info.GetInt32("_size");
		if (@int == 0)
		{
			return (Il2CppSystem.Object)(object)list;
		}
		IEnumerator enumerator = ((Il2CppObjectBase)info.GetValue("_items", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<IEnumerable>()))).Cast<IEnumerable>().GetEnumerator();
		for (int i = 0; i < @int; i++)
		{
			if (!enumerator.MoveNext())
			{
				throw new Il2CppSystem.InvalidOperationException();
			}
			list.Add(enumerator.Current);
		}
		return (Il2CppSystem.Object)(object)list;
	}

	public static Il2CppSystem.Array ArrayFromGenericList(IList list)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
