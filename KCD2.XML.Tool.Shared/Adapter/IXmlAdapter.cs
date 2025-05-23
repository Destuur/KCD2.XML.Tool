﻿using KCD2.XML.Tool.Shared.Mods;

namespace KCD2.XML.Tool.Shared.Adapter
{
	public interface IXmlAdapter
	{
		Task Initialize();
		Task Deinitialize();
		Task<List<IModItem>> GetModItems();
		Task<IModItem> GetModItem(string id);
		Task<bool> WriteModItems(IEnumerable<IModItem> modItems);
		Task<bool> WriteModManifest(ModDescription modDescription);
	}
}
