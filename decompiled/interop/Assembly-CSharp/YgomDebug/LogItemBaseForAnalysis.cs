using Il2CppDummyDll;
using UnityEngine;

namespace YgomDebug;

[Token(Token = "0x2000129")]
public class LogItemBaseForAnalysis : MonoBehaviour
{
	[Token(Token = "0x6000788")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public virtual void OnAdded()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void OnRemoved()
	{
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LogItemBaseForAnalysis()
	{
	}
}
