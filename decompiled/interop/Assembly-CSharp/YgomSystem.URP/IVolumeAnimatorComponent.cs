using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace YgomSystem.URP;

[Token(Token = "0x2000312")]
public interface IVolumeAnimatorComponent
{
	[Token(Token = "0x170001E4")]
	VolumeComponent bindedComponent
	{
		[Token(Token = "0x6001328")]
		get;
	}

	[Token(Token = "0x6001329")]
	bool TryBind(VolumeComponent component);

	[Token(Token = "0x600132A")]
	void Import();

	[Token(Token = "0x600132B")]
	void Import(VolumeComponent component);

	[Token(Token = "0x600132C")]
	void Export();

	[Token(Token = "0x600132D")]
	void Export(VolumeComponent component);
}
