using Grand.Infrastructure;
using Grand.Infrastructure.Plugins;
using Shipping.CPost;

[assembly: PluginInfo(
    FriendlyName = "CPost Shipping",
    Group = "Shipping rate",
    SystemName = CPostShippingDefaults.ProviderSystemName,
    SupportedVersion = GrandVersion.SupportedPluginVersion,
    Author = "Laguna Solutions",
    Version = "1.00"
)]