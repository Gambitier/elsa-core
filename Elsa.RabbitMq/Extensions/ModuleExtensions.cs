using Elsa.Features.Services;
using Elsa.RabbitMq.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Elsa.Extensions;

public static class ModuleExtensions
{
    public static IModule UseRabbitMq(this IModule module, Action<RabbitMqFeature>? configure = default)
    {
        return module.Use(configure);
    }
}
